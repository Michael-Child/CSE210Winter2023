using System;

class Program
{
    static List<Pokemon> One = new List<Pokemon>{};
    static List<Pokemon> Two = new List<Pokemon>{};
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
        swampert,
        megaGyarados
    };

    static void Main(string[] args){
        Console.WriteLine($"Welcome players to the arena!");
        Console.WriteLine($"Here are the rules. The first and then second player will each select 3 Pokemon. When a pokemon is defeated the next pokemons of each player in line will battle!");
        Console.WriteLine($"First player please select your three pokemon:");
        playerSelection(One);
        foreach(var i in One){
            Console.WriteLine($"{i.GetName()}");
        }
        Console.WriteLine($"Second player please select your three pokemon:");
        playerSelection(Two);
        battle(0); //First pokemon battle
        battle(1); //Second pokemon battle
        battle(2); //Third pokemon battle\
        Console.WriteLine();
        Console.WriteLine($"FINAL RESULTS:");
        if(Player_One_Points > Player_Two_Points){
            Console.WriteLine($"Player one wins!");
        }else{
            Console.WriteLine($"Player one wins!");
        }
    }

    static void battle(int PokemonOrder){
        Console.WriteLine();
        Console.WriteLine($"Let the battle BEGIN!!!");
        //Needs to loop again
        Console.WriteLine($"Players one pokemon {(One[PokemonOrder]).GetName()} vs. Players two pokemon {(Two[PokemonOrder]).GetName()}!");
        if((One[PokemonOrder]).GetSpeed() > (Two[PokemonOrder]).GetSpeed()){
            while(One[PokemonOrder].GetHP() > 0 && Two[PokemonOrder].GetHP() > 0){
                attack(One, Two, PokemonOrder);
                if(Two[PokemonOrder].GetHP() > 0){
                    attack(Two, One, PokemonOrder);
        }}}else{
            while(One[PokemonOrder].GetHP() > 0 && Two[PokemonOrder].GetHP() > 0){
                attack(Two, One, PokemonOrder);
                if(One[PokemonOrder].GetHP() > 0){
                    attack(One, Two, PokemonOrder);
        }}}
        if(One[PokemonOrder].GetHP() > 0){
            Console.WriteLine($"Players one pokemon {(One[PokemonOrder]).GetName()} was defeated.");
            Player_Two_Points++;
        }else{
            Console.WriteLine($"Players one pokemon {(Two[PokemonOrder]).GetName()} was defeated.");
            Player_One_Points++;
        }
    }

    static void attack(List<Pokemon> first, List<Pokemon> second, int PokemonOrder){
        string name = "";
        if(first == One){
            name = "one";
        }else{
            name = "two";
        }
        Console.WriteLine($"Player {name} which pokemon move do you want {(first[PokemonOrder]).GetName()} to use: ");
        int move = 0;
        foreach(var i in (first[PokemonOrder].GetMoves())){
            move++;
            Console.WriteLine($"{move}. {i.GetName()}");
        }

        Console.WriteLine();
        Console.Write($"Choose your pokemons next move: ");
        string userInput = Console.ReadLine() ?? "";
        int selection = int.Parse(userInput);
        Console.WriteLine();

        int dmg;

        if(selection == 4){
            (first[PokemonOrder]).DoThe4thMove();
            Console.WriteLine($"{(first[PokemonOrder]).GetName()} uses {(first[PokemonOrder].GetMove(selection-1)).GetName()} and increases their stats!");
        }else{
            if(first[PokemonOrder].GetAttackPower() > 100){
                second[PokemonOrder].TookDamage(first[PokemonOrder].GetMove(selection).GetDamage() + (first[PokemonOrder].GetMove(selection).GetDamage()/(first[PokemonOrder].GetAttackPower() - 100)));
                dmg = first[PokemonOrder].GetMove(selection).GetDamage() + (first[PokemonOrder].GetMove(selection).GetDamage()/(first[PokemonOrder].GetAttackPower() - 100));
            }else{
                second[PokemonOrder].TookDamage(first[PokemonOrder].GetMove(selection).GetDamage() - (first[PokemonOrder].GetMove(selection).GetDamage()/(100 - first[PokemonOrder].GetAttackPower())));
                dmg = first[PokemonOrder].GetMove(selection).GetDamage() - (first[PokemonOrder].GetMove(selection).GetDamage()/(100 - first[PokemonOrder].GetAttackPower()));
            }
            Console.WriteLine($"{(first[PokemonOrder]).GetName()} uses {(first[PokemonOrder].GetMove(selection-1)).GetName()} on {(second[PokemonOrder]).GetName()}.");
            Console.WriteLine($"{(second[PokemonOrder]).GetName()} took {second[PokemonOrder].GetTookDamage(dmg)} damage and has only has {(second[PokemonOrder]).GetHP()} HP left!");
    }}

    static void playerSelection(List<Pokemon> name){
        
        List<Pokemon> temperaryList = PokemonSelection;

        for(int i = 0; i < 3; i++){
            int num = 0;
            Console.WriteLine($"Pokemon Selection List: ");
            foreach(var o in temperaryList){
                num++;
                Console.WriteLine($"{num}. {o.GetName()}");
            }
            Console.WriteLine();
            Console.WriteLine($"Select your pokemon by entering their number: ");

            Console.Write($"{i+1}. ");
            string userInput = Console.ReadLine() ?? "";
            int selection = int.Parse(userInput);
            name.Add(temperaryList[selection-1]);
            temperaryList.Remove(temperaryList[selection-1]);
            Console.WriteLine("___________________________________");
        }
    }
}
