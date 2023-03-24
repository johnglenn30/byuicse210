using System;


public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int anyNumber)
    {
        _top = anyNumber;
        _bottom = 1;
    }
    public Fractions(int numberTop, int numberBottom )
    {
        _top = numberTop;
        _bottom = numberBottom;
    }

    public string DisplayFraction()
    {
        string Text =$"{_top}/{_bottom}";
        return Text;

    }
    public double DisplayDecimal()
    {
        return (double)_top/(double)_bottom; 
    }

}