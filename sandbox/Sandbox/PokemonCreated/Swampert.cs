using System;

class Swampert: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Muddy Water", "Water", 50),
        new Move ("Mud Shot", "Ground", 50),
        new Move ("Stomp", "Normal", 50),
        new Move ("Rain Dance", "Normal", 0)};

    public Swampert(): 
    base("Swampert",
    "Water",
    100,
    110,
    90,
    60,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetSpeed(GetSpeed()+(GetSpeed()/4));
    }
}