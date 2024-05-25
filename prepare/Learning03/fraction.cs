using System;

using System.Diagnostics;

public class Fraction
{
    private int _topValue;
    private int _bottomValue;

    public Fraction()
    {
        _topValue = 1;
        _bottomValue = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topValue = wholeNumber;
        _bottomValue = 1;
    }

    public Fraction(int topValue, int bottomValue)
    {
        _topValue = topValue;
        _bottomValue = bottomValue;
    }

    public string GetFractionString()
    {
        string text = $"{_topValue}/{_bottomValue}";
        
        return text;
    }

    public double GetFractionValue()
    {
        return (double)_topValue / (double)_bottomValue;
    }
}