using System;

public class Fraction{

    private int _top = 0;
    private int _bottom = 0;

    public Fraction(int _top, int _bottom){
        this._top = _top;
        this._bottom = _bottom;
    }
    
    public int GetTop(){
        return this._top;
    }
    public void SetTop(int top){
        _top = top;
    }
    public int GetBottom(){
        return this._bottom;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }
    public string GetFractionString(Fraction fract){
        string fraction1 = Convert.ToString(fract.GetTop());
        string fraction2 = Convert.ToString(fract.GetBottom());
        string fraction = fraction1 + " / " + fraction2;
        return fraction;
    }
    public double GetDecimalValue(Fraction fract){
        double fraction1 = Convert.ToDouble(fract.GetTop());
        double fraction2 = Convert.ToDouble(fract.GetBottom());
        return fraction1 / fraction2;
    } 
}
