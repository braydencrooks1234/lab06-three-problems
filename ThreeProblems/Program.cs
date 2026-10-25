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
        System.Console.WriteLine("=== Excercise 2: The Dice Table ===");
        char ans = 'y';
        int roll = 0;
        int wins = 0;
        int die1 = 0;
        int die2 = 0;
        int total = 0;
        do
        {
            roll += 1;
            die1 = rng.Next(1, 7);
            die2 = rng.Next(1, 7);
            total = die1 + die2;
            System.Console.Write($"Roll {roll}: {die1} and {die2}, total {total}. ");
            if (die1 == 1 && die2 == 1)
            {
                System.Console.WriteLine("Snake eyes.");
            }
            else if (die1 == die2)
            {
                System.Console.WriteLine("Doubles!");
            }
            else if (total == 7 || total == 11)
            {
                System.Console.WriteLine("A winner.");
                wins += 1;
            }
            else
            {
                System.Console.WriteLine("");
            }
            System.Console.Write("Roll again? (y/n): ");
            ans = Convert.ToChar(Console.ReadLine());
        } while (ans != 'n');
        System.Console.WriteLine($"You rolled {roll} times and won {wins}.");
        System.Console.WriteLine("");
    }
    if (choice == 3 || choice == 4)
    {
        int[] scores = new int[5];
        System.Console.WriteLine("Exercise 3: The Score Report ===");

        for (int i = 0; i < 5; i++)
        {
            System.Console.Write($"Score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = 0;
        int highest = scores[0];
        int count = 0;

        foreach (int score in scores)
        {
            total += score;

            if (score > highest)
            {
                highest = score;
            }

            if (score >= 60)
            {
                count += 1;
            }
        }

        double average = (double)total / scores.Length;

        System.Console.WriteLine("");
        System.Console.WriteLine("Scores entered: " + scores.Length.ToString());
        System.Console.WriteLine("Total: " + total.ToString());
        System.Console.WriteLine("Average: " + average.ToString("F1"));
        System.Console.WriteLine("Highest: " + highest.ToString());
        System.Console.WriteLine($"Passing: {count.ToString()} of {scores.Length.ToString()}");
        System.Console.WriteLine("");


    }

} while (choice != 5);

System.Console.WriteLine("");
System.Console.WriteLine("Goodbye.");