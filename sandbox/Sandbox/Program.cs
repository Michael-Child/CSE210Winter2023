using System;

class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.Setlhs(10);
        divider.Setrhs(1);
        divider.DisplayResult();

        divider.Setlhs(0);
        divider.Setrhs(100);
        divider.DisplayResult();

        divider.Setlhs(5);
        divider.Setrhs(0);
        divider.DisplayResult();

        divider.Setlhs(25);
        divider.Setrhs(5);
        divider.DisplayResult();

        // divider.lhs = 10;
        // divider.rhs = 1;
        // divider.DisplayResult();

        // divider.lhs = 0;
        // divider.rhs = 100;
        // divider.DisplayResult();

        // divider.lhs = 5;
        // divider.rhs = 0;
        // divider.DisplayResult();

        // divider.lhs = 25;
        // divider.rhs = 5;
        // divider.DisplayResult();
    }
}

class IntegerDivision {
    private int _lhs = 1;
    private int _rhs = 1;

    public int Result() {
        return Getlhs() / Getrhs();
    }
    public int Getlhs(){
        return this._lhs;
    }
    public void Setlhs(int lhs){
        _lhs = lhs;
    }

    public int Getrhs(){
        return this._rhs;
    }
    public void Setrhs(int rhs){
        if(rhs == 0){
            Console.WriteLine("Can't divide by 0. Default to 1 for no error.");
            _rhs = 1;
        }else{
            _rhs = rhs;
        }
    }

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
    }
}
