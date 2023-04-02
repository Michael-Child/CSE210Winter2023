using System;

class Program
{
    static Player One;
    static Player Two;
    static int Player_One_Points;
    static int Player_Two_Points;
    static Venusaur venusaur = new Venusaur();
    static Blastiose blastiose = new Blastiose();
    static Charizard charizard = new Charizard();
    static Blaziken blaziken = new Blaziken();
    static Feraligatr feraligatr = new Feraligatr();
    static Magikarp magikarp = new Magikarp();
    static MegaGyarados megaGyarados = new MegaGyarados();
    static Meganium meganium = new Meganium();
    static Sceptile sceptile = new Sceptile();
    static Swampert swampert = new Swampert();
    static Typhlosion typhlosion = new Typhlosion();

    static List<Pokemon> PokemonSelection = new List<Pokemon>{
        venusaur,
        charizard,
        blastiose,
        meganium,
        typhlosion,
        feraligatr,
        sceptile,
        blaziken,
        swampert
    };

    static void Main(string[] args){
        Console.WriteLine($"Welcome players to the arena!");
        Console.WriteLine($"Here are the rules. The first and then second player will each select 3 Pokemon and battle until one is defeated!");
        Console.WriteLine($"First player please select your three pokemon:");
        playerSelection(One);
        Console.WriteLine($"Second player please select your three pokemon:");
        playerSelection(Two);
        battle(); //First pokemon battle
        battle(); //Second pokemon battle
        battle(); //Third pokemon battle
        if(Player_One_Points > Player_Two_Points){
            Console.WriteLine($"Player one wins!");
        }else{
            Console.WriteLine($"Player one wins!");
        }
    }

    static void battle(){
        Console.WriteLine($"Let the battle BEGIN!!!");
        //Needs to loop again
        Console.WriteLine($"Players one pokemon {(One.GetPokemon(0)).GetName()} vs. Players two pokemon {(Two.GetPokemon(0)).GetName()}!");
        if((One.GetPokemon(0)).GetSpeed() > (Two.GetPokemon(0)).GetSpeed()){
            while(One.GetPokemon(0).GetHP() > 0 || Two.GetPokemon(0).GetHP() > 0){
                attack(One, Two);
                if(Two.GetPokemon(0).GetHP() > 0){
                    attack(Two, One);
        }}}else{
            while(One.GetPokemon(0).GetHP() > 0 || Two.GetPokemon(0).GetHP() > 0){
                attack(Two, One);
                if(One.GetPokemon(0).GetHP() > 0){
                    attack(One, Two);
        }}}
        if(One.GetPokemon(0).GetHP() > 0){
            Console.WriteLine($"Players one pokemon {(One.GetPokemon(0)).GetName()} was defeated.");
            Player_Two_Points++;
        }else{
            Console.WriteLine($"Players one pokemon {(Two.GetPokemon(0)).GetName()} was defeated.");
            Player_One_Points++;
        }
        One.ReleasePokemon(One.GetPokemon(0));
        Two.ReleasePokemon(Two.GetPokemon(0));
    }

    static void attack(Player first, Player second){
        string name = "";
        if(first == One){
            name = "one";
        }else{
            name = "two";
        }
        Console.WriteLine($"Player {name} which pokemon move do you want {(first.GetPokemon(0)).GetName()} to use: ");
        int move = 0;
        foreach(var i in (first.GetPokemon(0).GetMoves())){
            move++;
            Console.WriteLine($"{move}. {i.GetName()}");
        }
        string userInput = Console.ReadLine() ?? "";
        int selection = int.Parse(userInput);
        if(selection == 4){
            (first.GetPokemon(0)).DoThe4thMove();
            Console.WriteLine($"{(first.GetPokemon(0)).GetName()} uses {(first.GetPokemon(0).GetMove(selection-1)).GetName()} and increases their stats!");
        }else{
            second.GetPokemon(0).TookDamage((first.GetPokemon(0).GetAttackPower()/100)*(first.GetPokemon(0).GetMove(selection-1)).GetDamage());
            Console.WriteLine($"{(first.GetPokemon(0)).GetName()} uses {(first.GetPokemon(0).GetMove(selection-1)).GetName()} on {(second.GetPokemon(0)).GetName()}.");
            Console.WriteLine($"{(second.GetPokemon(0)).GetName()} took {second.GetPokemon(0).GetDefense()/100 * (first.GetPokemon(0).GetAttackPower()/100) * (first.GetPokemon(0).GetMove(selection-1)).GetDamage()} damage!");
    }}

    static void playerSelection(Player name){
        
        List<Pokemon> temperary = new List<Pokemon>();
        List<Pokemon> temperaryList = PokemonSelection;

        for(int i = 0; i < 3; i++){
            int num = 1;
            foreach(var o in temperaryList){
                num++;
                Console.WriteLine($"{num}. {o.GetName()}");
            }
            Console.WriteLine($"");
            Console.WriteLine();
            Console.WriteLine($"Select your pokemon by entering their number: ");

            Console.Write($"{i}. ");
            string userInput = Console.ReadLine() ?? "";
            int selection = int.Parse(userInput);
            temperary.Add(temperaryList[selection-1]);
            temperaryList.Remove(temperaryList[selection-1]);
            Console.WriteLine("___________________________________");
        }
        name.SetPokemons(temperary);
    }
}

// using System;

// class Program {

//     static void Main(string[] args) {
//         var p = new Person();
//         var s = new Student();

//         Console.WriteLine(p.GetName());
//         Console.WriteLine(s.GetName());
//     }


// // For IntegerDivision Class
//     // static void Main(string[] args) {
        
//     //     var divider =  new IntegerDivision();
//     //     divider.Setlhs(10);
//     //     divider.Setrhs(1);
//     //     divider.DisplayResult();

//     //     divider.Setlhs(0);
//     //     divider.Setrhs(100);
//     //     divider.DisplayResult();

//     //     divider.Setlhs(5);
//     //     divider.Setrhs(0);
//     //     divider.DisplayResult();

//     //     divider.Setlhs(25);
//     //     divider.Setrhs(5);
//     //     divider.DisplayResult();

//         // divider.lhs = 10;
//         // divider.rhs = 1;
//         // divider.DisplayResult();

//         // divider.lhs = 0;
//         // divider.rhs = 100;
//         // divider.DisplayResult();

//         // divider.lhs = 5;
//         // divider.rhs = 0;
//         // divider.DisplayResult();

//         // divider.lhs = 25;
//         // divider.rhs = 5;
//         // divider.DisplayResult();
//     // }
// }

// class Student: Person{

// }

// class Person{
//     public string GetName(){
//         return "Layne";
//     }
// }

// class IntegerDivision {
//     private int _lhs = 1;
//     private int _rhs = 1;

//     public int Result() {
//         return Getlhs() / Getrhs();
//     }
//     public int Getlhs(){
//         return this._lhs;
//     }
//     public void Setlhs(int lhs){
//         _lhs = lhs;
//     }

//     public int Getrhs(){
//         return this._rhs;
//     }
//     public void Setrhs(int rhs){
//         if(rhs == 0){
//             Console.WriteLine("Can't divide by 0. Default to 1 for no error.");
//             _rhs = 1;
//         }else{
//             _rhs = rhs;
//         }
//     }

//     public void DisplayResult() {
//         var result = Result();
//         Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
//     }
// }
