using System;

public class Fraction
{
    // variables / attributes
    private int _topNum;
    private int _bottomNum;

    // CONSTRUCTORS
    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNum = wholeNumber;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }


    // GETTERS AND SETTERS
    public int GetTop()
    {
        return _topNum;
    }

    public void SetTop(int top)
    {
        _topNum = top;
    }

    public int GetBottom()
    {
        return _bottomNum;
    }

    public void SetBottom(int bottom)
    {
        _bottomNum = bottom;
    }


    // METHODS
    public string GetFractionString() //formatting the output
    {
        string text = $"{_topNum}/{_bottomNum}";
        return text;
    }

    public double GetDecimalValue() // logic to the purpos
    {
        return (double)_topNum / (double)_bottomNum;
    }
}