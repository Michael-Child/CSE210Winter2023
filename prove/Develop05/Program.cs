using System;

class Program
{
    static int totalpoint = 0;
    static void Main(string[] args)
    {
        int UI = 0;
        List<Goal> GoalList = new List<Goal>{};
        var s = new SimpleGoal();
        var e = new EternalGoal();
        var c = new ChecklistGoal(0,0,0);

        while(UI != 6){
            display();
            string response = Console.ReadLine() ?? "";
            UI = int.Parse(response);
            if(UI == 1){
                response = Console.ReadLine() ?? "";
                UI = int.Parse(response);
                if(UI == 1){
                    s.SetGoal();
                    GoalList.Add(s);
                }
                else if(UI == 2){
                    e.SetGoal();
                    GoalList.Add(e);
                }
                else if(UI == 3){
                    c.SetGoal();
                    GoalList.Add(c);
                }else{
                    Console.WriteLine("Please enter a valid number. Starting over at the menu. ");
                }
            }else if(UI == 2){
                foreach(var g in GoalList){
                    g.list();
                }
            }else if(UI == 3){
                Console.WriteLine("What name would you like to save the file? ");
                response = Console.ReadLine() ?? "";
                foreach(var g in GoalList){
                    g.save(response);
                }
            }else if(UI == 4){
                Console.WriteLine("What's the name of the file? ");
                response = Console.ReadLine() ?? "";
                foreach(var g in GoalList){
                    g.load(response);
                }
            }else if(UI == 5){
                int i = 1;
                foreach(var g in GoalList){
                    Console.WriteLine($"{i}. {g.DisplayX} {g.GetName()} ({g.GetDescription()})");
                    i++;
                }
                Console.WriteLine("Which goal did you accomplish? ");
                response = Console.ReadLine() ?? "";
                int num = int.Parse(response) - 1;
                totalpoint = GoalList[num].GetPoints();
                GoalList[num].SetRecord(true);
                Console.WriteLine($"Congratulations! You have earned {GoalList[num].GetPoints()} points! ");
            }else if(UI == 6){
            }else{
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    static void display(){
        Console.WriteLine($"You have {totalpoint} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }


}

