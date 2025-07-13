using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int Menu()
    {
        Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
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
            
        BreathingActivity breathing = new BreathingActivity("Breathing","relax by walking you through your breathing in and out slowly.\nClear your mind and focus on your breathing");
        ListingActivity listing = new ListingActivity("Listing", "reflect on the good things in your life by having you list as many things\n as you can in a certain area.");
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "");
        

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
            }
            else if (_choice == 3)
            {
                ClearMenu();
                listing.Run();
            }
            else if (_choice == 4)
            {
                _choices = true;
            }
        }

    }
    
    
    
    

    
}