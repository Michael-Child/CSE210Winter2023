using System;

class Sceptile: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Leaf Blade", "Grass", 50),
        new Move ("Fury Cut", "Bug", 50),
        new Move ("Dragon Breath", "Dragon", 50),
        new Move ("Quick Guard", "Normal", 0)};

    public Sceptile(): 
    base("Sceptile",
    "Grass",
    70,
    85,
    65,
    120,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetHP(GetHP()+(GetHP()/5));
        SetDefense(GetDefense()+(GetDefense()/5));
    }
}