using System;

class Charizard: Pokemon{
    static List<Move> moves = new List<Move>{
        new Move ("Fire Fang", "Fire", 50),
        new Move ("Dragon Claw", "Dragon", 50),
        new Move ("Slash", "Normal", 50),
        new Move ("Roar", "Normal", 0)};

    public Charizard(): 
    base("Charizard",
    "Fire",
    100,
    84,
    78,
    100,
    //Moves 
    moves){}

    public override void DoThe4thMove(){
        SetAttackPower(GetAttackPower() + (GetAttackPower()/4));
    }
}