using System;

class Typhlosion: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Fire Wheel", "Fire", 50),
        new Move ("Rollout", "Ground", 50),
        new Move ("Wild Charge", "Electric", 50),
        new Move ("Smokescreen", "Normal", 0)};

    public Typhlosion(): 
    base("Typhlosion",
    "Fire",
    78,
    84,
    78,
    100,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetSpeed(GetSpeed()+(GetSpeed()/5));
        SetDefense(GetDefense()+(GetDefense()/5));
    }
}