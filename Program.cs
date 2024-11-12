// See https://aka.ms/new-console-template for more information
using System;

class program
{
    static void Main(string[]   args)
    {
        Console.WriteLine("please select your favourite coffee");
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);

        //reading user input
        string input = Console.ReadLine();
        int choise;

        //checking that user input is numeric
        if (int.TryParse(input, out choise))
        {
            switch (choise)
            {
                case 1:
                    Console.WriteLine("you chose the first coffee");
                    break;
                    case 2:
                    Console.WriteLine("you chose the secound coffee");
                    break ;
                    case 3:
                    Console.WriteLine("you chose the third coffee");
                    break;
                    default:
                    Console.WriteLine("please enter a number between 1 and 3");
                    break;
            
            }
        }
        else
        {
            Console.WriteLine("please enter a valid number");
        }
    }





}





