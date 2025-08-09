using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void Start()
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Menu");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1: CreateGoal(); break;
                    case 2: ListGoals(); break;
                    case 3: RecordEvent(); break;
                    case 4: ShowScore(); break;
                    case 5: SaveGoals(); break;
                    case 6: LoadGoals(); break;
                    case 7: Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

        } while (choice != 7);
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(name, desc, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, desc, points));
                break;
            case 3:
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, target, 0, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            Console.WriteLine($"You earned {earned} points!");
            score += earned;
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void ShowScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string file = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(score);
            foreach (Goal g in goals)
                writer.WriteLine(g.GetSaveString());
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string file = Console.ReadLine();
        if (File.Exists(file))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(file);
            score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];
                int pts = int.Parse(parts[3]);

                switch (type)
                {
                    case "SimpleGoal":
                        bool done = bool.Parse(parts[4]);
                        goals.Add(new SimpleGoal(name, desc, pts, done));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(name, desc, pts));
                        break;
                    case "ChecklistGoal":
                        int target = int.Parse(parts[4]);
                        int count = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        goals.Add(new ChecklistGoal(name, desc, pts, target, count, bonus));
                        break;
                }
            }

            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}