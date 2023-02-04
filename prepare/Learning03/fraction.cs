using System;

public class Fraction
{
    // Place variables for the class here
    private int _top;
    private int _bottom;

    // Place class methods here
    public Fraction()
    {
        // Fraction will always be 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fraction(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }

    // Create get/set methods to assign a value to the variables in the class
    // from within the class itself
    public void SetTopValue(int top)
    {
        _top = top;
    }

    public int GetTopValue()
    {
        return _top;
    }
    public void SetBottomValue(int bottom)
    {
        _bottom = bottom;
    }

    public int GetBottomValue()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}