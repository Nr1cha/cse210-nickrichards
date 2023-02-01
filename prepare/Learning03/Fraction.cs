using System;

class Fraction
{
    // variables / attributes
    private int _topNum;
    private int _bottomNum;


    private Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    private Fraction(int wholeNumber)
    {
        _topNum = wholeNumber;
    }

    private Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }
}