using System;

class MegaGyarados: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Hydropump", "Water", 100),
        new Move ("Thunder", "Electric", 100),
        new Move ("Fire Blast", "Fire", 100),
        new Move ("Over Powered", "Normal", 0)};

    public MegaGyarados(): 
    base("Mega Gyarados",
    "Dragon",
    96,
    155,
    109,
    50,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetHP(1000);
        SetAttackPower(1000);
        SetDefense(1000);
        SetSpeed(1000);
    }
}