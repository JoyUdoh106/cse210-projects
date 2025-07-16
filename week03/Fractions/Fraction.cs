using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int numerator)
    {
        _topNumber = numerator;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string letter = $"{_topNumber}/{_bottomNumber}";
        return letter;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetTopNumber(int topValue)
    {
        _topNumber = topValue;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public double GetDecimalvalue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}

