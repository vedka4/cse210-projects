using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // --- getters / setters 
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // getter / setter 
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom == 0)
            throw new ArgumentException("Denominator cannot be zero", nameof(bottom));


        if (bottom < 0)
        {
            _top = -_top;
            bottom = -bottom;
        }

        _bottom = bottom;
    }

    // --- Constructores ---
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
            throw new ArgumentException("Denominator cannot be zero", nameof(bottom));

        if (bottom < 0)
        {
            top = -top;
            bottom = -bottom;
        }

        _top = top;
        _bottom = bottom;
    }

   
}