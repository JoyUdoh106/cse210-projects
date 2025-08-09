public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount = 0, int bonusPoints = 0)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.currentCount = currentCount;
        this.bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            return currentCount == targetCount ? points + bonusPoints : points;
        }
        return 0;
    }

    public override bool IsComplete() => currentCount >= targetCount;

    public override string GetStatus() =>
        $"[{(IsComplete() ? "X" : " ")}] {name} ({description}) -- Completed {currentCount}/{targetCount}";

    public override string GetSaveString() =>
        $"ChecklistGoal|{name}|{description}|{points}|{targetCount}|{currentCount}|{bonusPoints}";
}