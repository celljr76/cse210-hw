using System;

class Program
{
    static void Main(string[] args)
    {
        int _choice = 0;
        while (_choice != 6)
        {
            GoalManager _goalManager = new GoalManager();
            _goalManager.DisplayPlayerInfo();
            Console.WriteLine();
            _goalManager.Start();
            _choice = int.Parse(Console.ReadLine());
            if (_choice == 1)
            {
                _goalManager.CreateGoal();
            }
            else if (_choice == 2)
            {
                _goalManager.ListGoalNames();
            }
            else if (_choice == 3)
            {
                _goalManager.Savegoals();
            }
            else if (_choice == 4)
            {
                _goalManager.LoadGoals();
            }
            else if (_choice == 5)
            {
                _goalManager.RecordEvent();
            }
        }
    }
}