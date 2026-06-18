using System;
public class GoalManager
{
    private List<Goal> goalsList;
    private double _score;
    public GoalManager()
    {
        goalsList = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        int input = -1;
        while (input != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice form the menu: ");
            string userInput = Console.ReadLine();
            input = int.Parse(userInput);
            Console.WriteLine();

            if (input == 1)
            {
                CreateGoal();
            }
            if (input == 2)
            {
                ListGoalDetails();
            }
            if (input == 3)
            {
                SaveGoals();
            }
            if (input == 4)
            {
                LoadGoals();
            }
            if (input == 5)
            {
                RecordEvent();
            }
            if (input == 6)
            {
                break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points!");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. " + goalsList[i].GetShortName());
        }
        Console.WriteLine();

        // int i = 1;
        // foreach (Goal goal in goalsList)
        // {
        //    Console.Write($"{i}.");
        //    goal.GetShortName();
        //    i += 1;
        // }
    }
    public void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in goalsList)
        {
            Console.WriteLine($"{i}. " + goal.GetDetailString());
            i += 1;
        }
        Console.WriteLine();
    }
    public void CreateGoal()
    {
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("     1. Simple Goal");
            Console.WriteLine("     2. Eternal Goal");
            Console.WriteLine("     3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string userGoalInput = Console.ReadLine();
            int goalInput = int.Parse(userGoalInput);
            Console.WriteLine();
            Console.Write("What is the name of your Goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string goalPointsInput = Console.ReadLine();
            double goalPoints = int.Parse(goalPointsInput);
            Console.WriteLine();
            
            if (goalInput == 1)
            {
                SimpleGoal simplegoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                goalsList.Add(simplegoal);
            }

            if (goalInput == 2)
            {
                EternalGoal eternalgoal = new EternalGoal(goalName, goalDescription, goalPoints);
                goalsList.Add(eternalgoal);
            }

            if (goalInput == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string goalTargetInput = Console.ReadLine();
                double goalTarget = int.Parse(goalTargetInput);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string goalBonusInput = Console.ReadLine();
                double goalBonus = int.Parse(goalBonusInput);
                Console.WriteLine();

                ChecklistGoal checklistgoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, 0, goalBonus);
                goalsList.Add(checklistgoal);
            }
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        string goalRecordInput = Console.ReadLine();
        int goalRecord = int.Parse(goalRecordInput);
        int i = goalRecord - 1;
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {goalsList[i]._points} points!");
        _score += goalsList[i]._points;
        Console.WriteLine($"You now have {_score} points!");
        Console.WriteLine();
        goalsList[i].RecordEvent();
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        
        foreach (Goal item in goalsList)
        {
            string line = item.GetStringRepresentation();
            File.AppendAllText(filename, line + "\n");
        }
        Console.WriteLine();
   }
   public void LoadGoals()
    {
        goalsList.Clear();

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string goalType = parts[0];

            if (goalType == "Simple Goal")
            {
                string name = parts[1];
                string description = parts[2];
                double points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal simplegoal = new SimpleGoal(name, description, points);

                if (isComplete == true)
                {
                    simplegoal.RecordEvent();
                }

                goalsList.Add(simplegoal);
            }
            if (goalType == "Eternal Goal")
            {
                string name = parts[1];
                string description = parts[2];
                double points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                EternalGoal eternalgoal = new EternalGoal(name, description, points);

                if (isComplete == true)
                {
                    eternalgoal.RecordEvent();
                }

                goalsList.Add(eternalgoal);
            }
            if (goalType == "Checklist Goal")
            {
                string name = parts[1];
                string description = parts[2];
                double points = int.Parse(parts[3]);
                double target = int.Parse(parts[4]);
                double amountCompleted = int.Parse(parts[5]);
                double bonus = int.Parse(parts[6]);
                bool isComplete = bool.Parse(parts[7]);

                ChecklistGoal checklistgoal = new ChecklistGoal(name, description, points, target, amountCompleted, bonus);

                if (isComplete == true)
                {
                    checklistgoal.RecordEvent();
                }

                goalsList.Add(checklistgoal);
            }                     
        }
    }
}