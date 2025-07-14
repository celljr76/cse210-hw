using System;

class Program
{
    static int Menu()
    {
        Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Start eating activity\n 5. Quit");
        Console.Write("Select a choice from the menu:");
        int _choice = int.Parse(Console.ReadLine());
        return _choice;

    }
    static void ClearMenu()
    {
        Console.Clear();
    }
    static void Main(string[] args)
    {
        bool _choices = false;

        BreathingActivity breathing = new BreathingActivity("Breathing", "relax by walking you through your breathing in and out slowly.\nClear your mind and focus on your breathing");
        ListingActivity listing = new ListingActivity("Listing", "reflect on the good things in your life by having you list as many things\n as you can in a certain area.");
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "reflect on times in your life when you have shown strength and resilience.\nThis will help you recongnize the power you have and how you can use it in other aspects of your\nlife");
        EatingActivity eating = new EatingActivity("Eating", "to enjoy eating and to slow down while eating. Sometimes we are always in a rush to eat and go. This helps you slow down, and to take a bite and chew slowly.");


        while (_choices == false)
        {

            ClearMenu();
            int _choice = Menu();
            if (_choice == 1)
            {
                ClearMenu();
                breathing.Run();
            }
            else if (_choice == 2)
            {
                ClearMenu();
                reflecting.Run();
            }
            else if (_choice == 3)
            {
                ClearMenu();
                listing.Run();
            }
            else if (_choice == 4)
            {
                ClearMenu();
                eating.Run();
            }
            else if (_choice == 5)
            {
                _choices = true;
            }
        }

    }






}


// I added another activity to show creativeness. I added an eating activity. A person would select it if they ever find that they are eating to fast and want to slow down.
// The activity walks them through a series of taking a bite and chewing for 10 seconds. it will repeat based upon the duration they chose for.