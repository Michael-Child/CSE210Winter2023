using System;

class GoalContainer
{
    List<Goal> GoalList = new List<Goal>{};

    public void list()
    {
        for(int i = 0; i < GoalList.Count(); i++){
            if(GoalList[i]is(ChecklistGoal)){
                Console.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()}) -- Currently completed: {GoalList[i].GetCompletion()}/{GoalList[i].GetCompletionGoal()}");
            }else{
                Console.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()})");
            }
        }
    }

    public void load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

    public void save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            for(int i = 0; i < GoalList.Count(); i++){
                if(GoalList[i]is(ChecklistGoal)){
                    outputFile.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()}) -- Currently completed: {GoalList[i].GetCompletion()}/{GoalList[i].GetCompletionGoal()}");
                }else{
                    outputFile.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()})");
                }}}}}