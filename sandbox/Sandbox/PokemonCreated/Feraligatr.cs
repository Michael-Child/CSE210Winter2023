using System;

class Feraligatr: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Water Gun", "Water", 50),
        new Move ("Ice Fang", "Ice", 50),
        new Move ("Metal Claw", "Steel", 50),
        new Move ("Dragon Dance", "Dragon", 0)};

    public Feraligatr(): 
    base("Feraligatr",
    "Water",
    85,
    105,
    100,
    78,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetHP(GetHP()+(GetHP()/10));
        SetAttackPower(GetAttackPower()+(GetAttackPower()/10));
        SetDefense(GetDefense()+(GetDefense()/10));
        SetSpeed(GetSpeed()+(GetSpeed()/10));
    }
}