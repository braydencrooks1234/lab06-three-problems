/*
* Name: Brayden Crooks
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/



//Set variables

int choice = 0;
Random rng = new Random(4000);


do {
    //Create Menu

    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All Three");
    System.Console.WriteLine("5. Quit");
    choice = 0;
    System.Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());

    // Determine the choice and run the program

    if (choice == 1 || choice == 4)
    {
                System.Console.WriteLine("");
        System.Console.WriteLine("=== Excercise 1: The Grade Checker");
        double score = 0;


        do
        {
            score = 0;
            System.Console.Write("Score: ");
            score = Convert.ToDouble(Console.ReadLine());
           
            if (score <= 0 || score >= 100)
            {
                System.Console.WriteLine("A score must be between 0 and 100.");
            }
        } while (score <= 0 || score >= 100);


        if (score >= 90)
        {
            System.Console.WriteLine(score + " earns an A.");
        }
        else if (score >= 80)
        {
            System.Console.WriteLine(score + " earns a B.");
        }
        else if (score >= 70)
        {
            System.Console.WriteLine(score + " earns a C.");
        }
        else if (score >= 60)
        {
            System.Console.WriteLine(score + " earns a D.");
        }
        else if (score < 60)
        {
            System.Console.WriteLine(score + " earns a F.");
        }


        System.Console.WriteLine("");

    }
    if (choice == 2 || choice == 4)
    {
        
    }
    if (choice == 3 || choice == 4)
    {
        
    }

} while (choice != 5);

System.Console.WriteLine("");
System.Console.WriteLine("Goodbye.");