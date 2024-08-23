using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace myFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //All variables
            int successfulattempts1 = 0;
            int totalattempts1 = 0;
            int successfulattempts2 = 0;
            int totalattempts2 = 0;
            int successfulattempts3 = 0;
            int totalattempts3 = 0;
            int successfulattempts4 = 0;
            int totalattempts4 = 0;
            int successfulattempts5 = 0;
            int totalattempts5 = 0;
            string playagain = "yes";
            string changelevel;
            Random random = new Random();
            string[] numbers = new string[18];
            string numberlist;
            bool possible;
            int dr1;
            int dr2;
            int diceroll;
            int a;
            int b;
            int c;
            int d;
            bool validanswer;
            string answer;
            int length;
            bool aisinlist;
            bool bisinlist;
            bool cisinlist;
            bool disinlist;

            Console.WriteLine("Welcome tooooooo.....");
            Console.WriteLine("SHUT THE BOX");
            Console.WriteLine(" ");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("You are given a list of numbers and a diceroll");
            Console.WriteLine("You need to select numbers from your list that add up to the diceroll");
            Console.WriteLine("The aim is to finish all of your numbers");
            Console.WriteLine("You cannot repeat numbers");
            Console.WriteLine("And make sure to format your answers as numbers seperated by spaces");
            Console.WriteLine(" ");
            Console.WriteLine("ARE YOU READYYY");
            string ans = Console.ReadLine();
            ans = ans.ToLower();

            if (ans == "no" || ans == "nope" || ans == "nah")
            {
                Console.WriteLine("Well too bad, we're starting anyway.");
            }
            if(ans == "yes" || ans == "yep" || ans == "yeah" || ans == "yess" || ans == "yesss" || ans == "yessss")
            {
                Console.WriteLine("Love the enthusiam. Let's go!");
            }
            Console.WriteLine("Good Luck!");
            Console.WriteLine(" ");
            while (playagain != "no")
            {
                Console.WriteLine("Which level would you like to do? (1-5 or exit)");
                string level = Console.ReadLine();

                switch (level)
                {
                    case "1":
                        successfulattempts1 = 0;
                        totalattempts1 = 0;

                        changelevel = "no";
                        playagain = "yes";
                        while (playagain != "no" && changelevel != "yes")
                        {
                            numbers = ["1", " ", "2", " ", "3", " ", "4", " ", "5", " "];
                            numberlist = " ";
                            possible = true;
                            Console.WriteLine("This Level is played with two three sided dice");
                            Console.WriteLine(" ");
                            while (possible == true && numberlist != "")
                            {
                                dr1 = random.Next(1, 4);
                                dr2 = random.Next(1, 4);
                                diceroll = dr1 + dr2;

                                possible = false;

                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    if (Convert.ToInt32(numbers[i]) == diceroll)
                                    {
                                        possible = true;
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        if (i != j)
                                        {
                                            if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) == diceroll)
                                            {
                                                possible = true;
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            if (i != j && j != k && k != i)
                                            {
                                                if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) == diceroll)
                                                {
                                                    possible = true;
                                                }
                                            }
                                        }
                                    }
                                }
                                
                                numberlist = "";
                                foreach (string i in numbers)
                                {

                                    if (i != "0")
                                    {
                                        numberlist = numberlist + i;
                                    }
                                }
                                Console.WriteLine("Your current numbers: " + numberlist);
                                Console.WriteLine("Diceroll: " + diceroll);

                                if (possible == true)
                                {
                                    a = 0;
                                    b = 0;
                                    c = 0;

                                    validanswer = false;
                                    while (validanswer == false)
                                    {
                                        a = 0;
                                        b = 0;
                                        c = 0;

                                        Console.WriteLine("Enter your number(s)");
                                        Console.Write("Your Number: ");
                                        answer = Console.ReadLine();
                                        Console.WriteLine(" ");
                                        validanswer = true;
                                        length = answer.Length;
                                        if (answer == "")
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Please enter something.");
                                        }
                                        if (validanswer == true)
                                        {
                                            foreach (char i in answer)
                                            {
                                                string j = Convert.ToString(i);
                                                if (j != "1" && j != "2" && j != "3" && j != "4" && j != "5" && j != "6" && j != "7" && j != "8" && j != "9" && j != " " && validanswer == true)
                                                {
                                                    validanswer = false;
                                                    Console.WriteLine("Please only include numbers and spaces in your answer.");
                                                }
                                            }
                                        }
                                        
                                        if (validanswer == true)
                                        {
                                            switch (length)
                                            {
                                                case 1:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    break;
                                                case 3:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    break;
                                                case 5:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    break;
                                                default:
                                                    Console.WriteLine("Please seperate each number by a space.");
                                                    validanswer = false;
                                                    break;
                                            }
                                        }

                                        if (validanswer == true && (a > 5 || b > 5 || c > 5))
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number higher than 5.");
                                        }

                                        if (a + b + c != diceroll && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Your guess needs to add up to the dice roll.");
                                        }

                                        if (((a != 0 && a == b) || (a != 0 && a == c) || (b != 0 && b == c)) && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You are not allowed to repeat.");
                                        }

                                        aisinlist = false;
                                        bisinlist = false;
                                        cisinlist = false;

                                        foreach (string i in numbers)
                                        {
                                            if (i == Convert.ToString(a))
                                            {
                                                aisinlist = true;
                                            }
                                            if (i == Convert.ToString(b))
                                            {
                                                bisinlist = true;
                                            }
                                            if (i == Convert.ToString(c))
                                            {
                                                cisinlist = true;
                                            }
                                            
                                        }
                                        if (aisinlist == false && a != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (bisinlist == false && b != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (cisinlist == false && c != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        
                                    }
                                    for (int i = 0; i < numbers.Length; i += 2)
                                    {
                                        if (numbers[i] == Convert.ToString(a))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(b))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(c))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                    }
                                    numberlist = "";
                                    foreach (string i in numbers)
                                    {
                                        if (i != "0")
                                        {
                                            numberlist = numberlist + i;
                                        }
                                    }
                                }
                            }

                            if (possible == false)
                            {
                                Console.WriteLine("You LOST :(");
                            }
                            else
                            {
                                Console.WriteLine("You WON :)");
                                successfulattempts1++;
                            }
                            totalattempts1++;
                            Console.WriteLine("Do you want to play again? (yes or no)");
                            playagain = Console.ReadLine();
                            if (playagain != "no")
                            {
                                Console.WriteLine("Do you want to change level? (yes or no)");
                                changelevel = Console.ReadLine();
                            }
                        }

                        break;

                    //------------------------------------------------------------- NEXT LEVEL -----------------------------------------------------------------------

                    case "2":
                        successfulattempts2 = 0;
                        totalattempts2 = 0;

                        changelevel = "no";
                        playagain = "yes";
                        while (playagain != "no" && changelevel != "yes")
                        {
                            numbers = ["1", " ", "2", " ", "3", " ", "4", " ", "5", " ", "6", " "];
                            numberlist = " ";
                            possible = true;
                            Console.WriteLine("This Level is played with two four sided dice");
                            Console.WriteLine(" ");

                            while (possible == true && numberlist != "")
                            {
                                dr1 = random.Next(1, 5);
                                dr2 = random.Next(1, 5);
                                diceroll = dr1 + dr2;

                                possible = false;

                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    if (Convert.ToInt32(numbers[i]) == diceroll)
                                    {
                                        possible = true;
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        if (i != j)
                                        {
                                            if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) == diceroll)
                                            {
                                                possible = true;
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            if (i != j && j != k && k != i)
                                            {
                                                if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) == diceroll)
                                                {
                                                    possible = true;
                                                }
                                            }
                                        }
                                    }
                                }

                                numberlist = "";
                                foreach (string i in numbers)
                                {

                                    if (i != "0")
                                    {
                                        numberlist = numberlist + i;
                                    }
                                }
                                Console.WriteLine("Your current numbers: " + numberlist);
                                Console.WriteLine("Diceroll: " + diceroll);

                                if (possible == true)
                                {
                                    a = 0;
                                    b = 0;
                                    c = 0;

                                    validanswer = false;
                                    while (validanswer == false)
                                    {
                                        a = 0;
                                        b = 0;
                                        c = 0;

                                        Console.WriteLine("Enter your number(s)");
                                        Console.Write("Your Number: ");
                                        answer = Console.ReadLine();
                                        Console.WriteLine(" ");
                                        validanswer = true;
                                        length = answer.Length;
                                        if (answer == "")
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Please enter something.");
                                        }
                                        if (validanswer == true)
                                        {
                                            foreach (char i in answer)
                                            {
                                                string j = Convert.ToString(i);
                                                if (j != "1" && j != "2" && j != "3" && j != "4" && j != "5" && j != "6" && j != "7" && j != "8" && j != "9" && j != " " && validanswer == true)
                                                {
                                                    validanswer = false;
                                                    Console.WriteLine("Please only include numbers and spaces in your answer.");
                                                }
                                            }
                                        }

                                        

                                        if (validanswer == true)
                                        {
                                            switch (length)
                                            {
                                                case 1:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    break;
                                                case 3:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    break;
                                                case 5:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    break;
                                                default:
                                                    Console.WriteLine("Please seperate each number by a space.");
                                                    validanswer = false;
                                                    break;
                                            }
                                        }

                                        if (validanswer == true && (a > 6 || b > 6 || c > 6))
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number higher than 6.");
                                        }

                                        if (a + b + c != diceroll && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Your guess needs to add up to the dice roll.");
                                        }

                                        if (((a != 0 && a == b) || (a != 0 && a == c) || (b != 0 && b == c)) && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You are not allowed to repeat.");
                                        }

                                        aisinlist = false;
                                        bisinlist = false;
                                        cisinlist = false;

                                        foreach (string i in numbers)
                                        {
                                            if (i == Convert.ToString(a))
                                            {
                                                aisinlist = true;
                                            }
                                            if (i == Convert.ToString(b))
                                            {
                                                bisinlist = true;
                                            }
                                            if (i == Convert.ToString(c))
                                            {
                                                cisinlist = true;
                                            }                                            
                                        }
                                        if (aisinlist == false && a != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (bisinlist == false && b != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (cisinlist == false && c != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }                                        
                                    }
                                    for (int i = 0; i < numbers.Length; i += 2)
                                    {
                                        if (numbers[i] == Convert.ToString(a))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(b))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(c))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                    }
                                    numberlist = "";
                                    foreach (string i in numbers)
                                    {
                                        if (i != "0")
                                        {
                                            numberlist = numberlist + i;
                                        }
                                    }
                                }
                            }

                            if (possible == false)
                            {
                                Console.WriteLine("You LOST :(");
                            }
                            else
                            {
                                Console.WriteLine("You WON :)");
                                successfulattempts2++;
                            }
                            totalattempts2++;
                            Console.WriteLine("Do you want to play again? (yes or no)");
                            playagain = Console.ReadLine();
                            if (playagain != "no")
                            {
                                Console.WriteLine("Do you want to change level? (yes or no)");
                                changelevel = Console.ReadLine();
                            }

                        }

                        break;

                    //--------------------------------------------------------------- NEXT LEVEL ----------------------------------------------------------------------

                    case "3":
                        successfulattempts3 = 0;
                        totalattempts3 = 0;

                        changelevel = "no";
                        playagain = "yes";
                        while (playagain != "no" && changelevel != "yes")
                        {
                            numbers = ["1", " ", "2", " ", "3", " ", "4", " ", "5", " ", "6", " ", "7", " "];
                            numberlist = " ";
                            possible = true;
                            Console.WriteLine("This Level is played with two five sided dice");
                            Console.WriteLine(" ");

                            while (possible == true && numberlist != "")
                            {
                                dr1 = random.Next(1, 6);
                                dr2 = random.Next(1, 6);
                                diceroll = dr1 + dr2;

                                possible = false;

                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    if (Convert.ToInt32(numbers[i]) == diceroll)
                                    {
                                        possible = true;
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        if (i != j)
                                        {
                                            if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) == diceroll)
                                            {
                                                possible = true;
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            if (i != j && j != k && k != i)
                                            {
                                                if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) == diceroll)
                                                {
                                                    possible = true;
                                                }
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            for (int l = 0; l < numbers.Length; l += 2)
                                            {
                                                if (i != j && j != k && k != i && i != l && j != l && k != l)
                                                {
                                                    if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) + Convert.ToInt32(numbers[l]) == diceroll)
                                                    {
                                                        possible = true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                numberlist = "";
                                foreach (string i in numbers)
                                {

                                    if (i != "0")
                                    {
                                        numberlist = numberlist + i;
                                    }
                                }
                                Console.WriteLine("Your current numbers: " + numberlist);
                                Console.WriteLine("Diceroll: " + diceroll);

                                if (possible == true)
                                {
                                    a = 0;
                                    b = 0;
                                    c = 0;
                                    d = 0;

                                    validanswer = false;
                                    while (validanswer == false)
                                    {
                                        a = 0;
                                        b = 0;
                                        c = 0;
                                        d = 0;

                                        Console.WriteLine("Enter your number(s)");
                                        Console.Write("Your Number: ");
                                        answer = Console.ReadLine();
                                        Console.WriteLine(" ");
                                        validanswer = true;
                                        length = answer.Length;
                                        if (answer == "")
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Please enter something.");
                                        }
                                        if (validanswer == true)
                                        {
                                            foreach (char i in answer)
                                            {
                                                string j = Convert.ToString(i);
                                                if (j != "1" && j != "2" && j != "3" && j != "4" && j != "5" && j != "6" && j != "7" && j != "8" && j != "9" && j != " " && validanswer == true)
                                                {
                                                    validanswer = false;
                                                    Console.WriteLine("Please only include numbers and spaces in your answer.");
                                                }
                                            }
                                        }
                                                                                
                                        if (validanswer == true)
                                        {
                                            switch (length)
                                            {
                                                case 1:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    break;
                                                case 3:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    break;
                                                case 5:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    break;
                                                case 7:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    d = Convert.ToInt32(answer.Substring(6, 1));
                                                    break;
                                                default:
                                                    Console.WriteLine("Please seperate each number by a space.");
                                                    validanswer = false;
                                                    break;
                                            }
                                        }

                                        if (validanswer == true && (a > 7 || b > 7 || c > 7))
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number higher than 7.");
                                        }

                                        if (a + b + c + d != diceroll && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Your guess needs to add up to the dice roll.");
                                        }

                                        if (((a != 0 && a == b) || (a != 0 && a == c) || (a != 0 && a == d) || (b != 0 && b == c) || (b != 0 && b == d) || (c != 0 && c == d)) && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You are not allowed to repeat.");
                                        }

                                        aisinlist = false;
                                        bisinlist = false;
                                        cisinlist = false;
                                        disinlist = false;

                                        foreach (string i in numbers)
                                        {
                                            if (i == Convert.ToString(a))
                                            {
                                                aisinlist = true;
                                            }
                                            if (i == Convert.ToString(b))
                                            {
                                                bisinlist = true;
                                            }
                                            if (i == Convert.ToString(c))
                                            {
                                                cisinlist = true;
                                            }
                                            if (i == Convert.ToString(d))
                                            {
                                                disinlist = true;
                                            }
                                        }
                                        if (aisinlist == false && a != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (bisinlist == false && b != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (cisinlist == false && c != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (disinlist == false && d != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                    }
                                    for (int i = 0; i < numbers.Length; i += 2)
                                    {
                                        if (numbers[i] == Convert.ToString(a))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(b))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(c))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(d))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                    }
                                    numberlist = "";
                                    foreach (string i in numbers)
                                    {
                                        if (i != "0")
                                        {
                                            numberlist = numberlist + i;
                                        }
                                    }
                                }
                            }

                            if (possible == false)
                            {
                                Console.WriteLine("You LOST :(");
                            }
                            else
                            {
                                Console.WriteLine("You WON :)");
                                successfulattempts3++;
                            }
                            totalattempts3++;
                            Console.WriteLine("Do you want to play again? (yes or no)");
                            playagain = Console.ReadLine();
                            if (playagain != "no")
                            {
                                Console.WriteLine("Do you want to change level? (yes or no)");
                                changelevel = Console.ReadLine();
                            }
                        }

                        break;

                    //---------------------------------------------------------- NEXT LEVEL --------------------------------------------------------------------

                    case "4":
                        successfulattempts4 = 0;
                        totalattempts4 = 0;

                        changelevel = "no";
                        playagain = "yes";
                        while (playagain != "no" && changelevel != "yes")
                        {
                            numbers = ["1", " ", "2", " ", "3", " ", "4", " ", "5", " ", "6", " ", "7", " ", "8", " "];
                            numberlist = " ";
                            possible = true;
                            Console.WriteLine("This Level is played with two six sided dice");
                            Console.WriteLine(" ");


                            while (possible == true && numberlist != "")
                            {
                                dr1 = random.Next(1, 7);
                                dr2 = random.Next(1, 7);
                                diceroll = dr1 + dr2;

                                possible = false;

                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    if (Convert.ToInt32(numbers[i]) == diceroll)
                                    {
                                        possible = true;
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        if (i != j)
                                        {
                                            if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) == diceroll)
                                            {
                                                possible = true;
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            if (i != j && j != k && k != i)
                                            {
                                                if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) == diceroll)
                                                {
                                                    possible = true;
                                                }
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            for (int l = 0; l < numbers.Length; l += 2)
                                            {
                                                if (i != j && j != k && k != i && i != l && j != l && k != l)
                                                {
                                                    if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) + Convert.ToInt32(numbers[l]) == diceroll)
                                                    {
                                                        possible = true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                numberlist = "";
                                foreach (string i in numbers)
                                {

                                    if (i != "0")
                                    {
                                        numberlist = numberlist + i;
                                    }
                                }
                                Console.WriteLine("Your current numbers: " + numberlist);
                                Console.WriteLine("Diceroll: " + diceroll);

                                if (possible == true)
                                {
                                    a = 0;
                                    b = 0;
                                    c = 0;
                                    d = 0;

                                    validanswer = false;
                                    while (validanswer == false)
                                    {
                                        a = 0;
                                        b = 0;
                                        c = 0;
                                        d = 0;

                                        Console.WriteLine("Enter your numbers");
                                        Console.Write("Your Number: ");
                                        answer = Console.ReadLine();
                                        Console.WriteLine(" ");
                                        validanswer = true;
                                        length = answer.Length;
                                        if (answer == "")
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Please enter something.");
                                        }
                                        if (validanswer == true)
                                        {
                                            foreach (char i in answer)
                                            {
                                                string j = Convert.ToString(i);
                                                if (j != "1" && j != "2" && j != "3" && j != "4" && j != "5" && j != "6" && j != "7" && j != "8" && j != "9" && j != " " && validanswer == true)
                                                {
                                                    validanswer = false;
                                                    Console.WriteLine("Please only include numbers and spaces in your answer.");
                                                }
                                            }
                                        }                                                                           

                                        if (validanswer == true)
                                        {
                                            switch (length)
                                            {
                                                case 1:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    break;
                                                case 3:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    break;
                                                case 5:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    break;
                                                case 7:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    d = Convert.ToInt32(answer.Substring(6, 1));
                                                    break;
                                                default:
                                                    Console.WriteLine("Please seperate each number by a space.");
                                                    validanswer = false;
                                                    break;
                                            }
                                        }

                                        if (validanswer == true && (a > 8 || b > 8 || c > 8))
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number higher than 8.");
                                        }

                                        if (a + b + c + d != diceroll && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Your guess needs to add up to the dice roll.");
                                        }

                                        if (((a != 0 && a == b) || (a != 0 && a == c) || (a != 0 && a == d) || (b != 0 && b == c) || (b != 0 && b == d) || (c != 0 && c == d)) && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You are not allowed to repeat.");
                                        }

                                        aisinlist = false;
                                        bisinlist = false;
                                        cisinlist = false;
                                        disinlist = false;

                                        foreach (string i in numbers)
                                        {
                                            if (i == Convert.ToString(a))
                                            {
                                                aisinlist = true;
                                            }
                                            if (i == Convert.ToString(b))
                                            {
                                                bisinlist = true;
                                            }
                                            if (i == Convert.ToString(c))
                                            {
                                                cisinlist = true;
                                            }
                                            if (i == Convert.ToString(d))
                                            {
                                                disinlist = true;
                                            }
                                        }
                                        if (aisinlist == false && a != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (bisinlist == false && b != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (cisinlist == false && c != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (disinlist == false && d != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                    }
                                    for (int i = 0; i < numbers.Length; i += 2)
                                    {
                                        if (numbers[i] == Convert.ToString(a))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(b))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(c))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(d))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                    }
                                    numberlist = "";
                                    foreach (string i in numbers)
                                    {
                                        if (i != "0")
                                        {
                                            numberlist = numberlist + i;
                                        }
                                    }
                                }
                            }

                            if (possible == false)
                            {
                                Console.WriteLine("You LOST :(");
                            }
                            else
                            {
                                Console.WriteLine("You WON :)");
                                successfulattempts4++;
                            }
                            totalattempts4++;
                            Console.WriteLine("Do you want to play again? (yes or no)");
                            playagain = Console.ReadLine();
                            if (playagain != "no")
                            {
                                Console.WriteLine("Do you want to change level? (yes or no)");
                                changelevel = Console.ReadLine();
                            }
                        }


                        break;


                    // ------------------------------------------------------------ NEXT LEVEL -----------------------------------------------------------------------

                    case "5":
                        successfulattempts5 = 0;
                        totalattempts5 = 0;

                        changelevel = "no";
                        playagain = "yes";
                        while (playagain != "no" && changelevel != "yes")
                        {
                            numbers = ["1", " ", "2", " ", "3", " ", "4", " ", "5", " ", "6", " ", "7", " ", "8", " ", "9", " "];
                            numberlist = " ";
                            possible = true;
                            Console.WriteLine("This Level is played with two six sided dice");
                            Console.WriteLine(" ");

                            while (possible == true && numberlist != "")
                            {
                                dr1 = random.Next(1, 7);
                                dr2 = random.Next(1, 7);
                                diceroll = dr1 + dr2;

                                possible = false;

                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    if (Convert.ToInt32(numbers[i]) == diceroll)
                                    {
                                        possible = true;
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        if (i != j)
                                        {
                                            if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) == diceroll)
                                            {
                                                possible = true;
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            if (i != j && j != k && k != i)
                                            {
                                                if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) == diceroll)
                                                {
                                                    possible = true;
                                                }
                                            }
                                        }
                                    }
                                }
                                for (int i = 0; i < numbers.Length; i += 2)
                                {
                                    for (int j = 0; j < numbers.Length; j += 2)
                                    {
                                        for (int k = 0; k < numbers.Length; k += 2)
                                        {
                                            for (int l = 0; l < numbers.Length; l += 2)
                                            {
                                                if (i != j && j != k && k != i && i != l && j != l && k != l)
                                                {
                                                    if (Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[j]) + Convert.ToInt32(numbers[k]) + Convert.ToInt32(numbers[l]) == diceroll)
                                                    {
                                                        possible = true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                numberlist = "";
                                foreach (string i in numbers)
                                {

                                    if (i != "0")
                                    {
                                        numberlist = numberlist + i;
                                    }
                                }
                                Console.WriteLine("Your current numbers: " + numberlist);
                                Console.WriteLine("Diceroll: " + diceroll);

                                if (possible == true)
                                {
                                    a = 0;
                                    b = 0;
                                    c = 0;
                                    d = 0;

                                    validanswer = false;
                                    while (validanswer == false)
                                    {
                                        a = 0;
                                        b = 0;
                                        c = 0;
                                        d = 0;

                                        Console.WriteLine("Enter your number(s)" +
                                            "");
                                        Console.Write("Your Number: ");
                                        answer = Console.ReadLine();
                                        Console.WriteLine(" ");
                                        validanswer = true;
                                        length = answer.Length;
                                        if (answer == "")
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Please enter something.");
                                        }
                                        if (validanswer == true)
                                        {
                                            foreach (char i in answer)
                                            {
                                                string j = Convert.ToString(i);
                                                if (j != "1" && j != "2" && j != "3" && j != "4" && j != "5" && j != "6" && j != "7" && j != "8" && j != "9" && j != " " && validanswer == true)
                                                {
                                                    validanswer = false;
                                                    Console.WriteLine("Please only include numbers and spaces in your answer.");
                                                }
                                            }
                                        }

                                        if (validanswer == true)
                                        {
                                            switch (length)
                                            {
                                                case 1:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    break;
                                                case 3:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    break;
                                                case 5:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    break;
                                                case 7:
                                                    a = Convert.ToInt32(answer.Substring(0, 1));
                                                    b = Convert.ToInt32(answer.Substring(2, 1));
                                                    c = Convert.ToInt32(answer.Substring(4, 1));
                                                    d = Convert.ToInt32(answer.Substring(6, 1));
                                                    break;
                                                default:
                                                    Console.WriteLine("Please seperate each number by a space.");
                                                    validanswer = false;
                                                    break;
                                            }
                                        }
                                        if (a + b + c + d != diceroll && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("Your guess needs to add up to the dice roll.");
                                        }

                                        if (((a != 0 && a == b) || (a != 0 && a == c) || (a != 0 && a == d) || (b != 0 && b == c) || (b != 0 && b == d) || (c != 0 && c == d)) && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You are not allowed to repeat.");
                                        }
                                        aisinlist = false;
                                        bisinlist = false;
                                        cisinlist = false;
                                        disinlist = false;

                                        foreach (string i in numbers)
                                        {
                                            if (i == Convert.ToString(a))
                                            {
                                                aisinlist = true;
                                            }
                                            if (i == Convert.ToString(b))
                                            {
                                                bisinlist = true;
                                            }
                                            if (i == Convert.ToString(c))
                                            {
                                                cisinlist = true;
                                            }
                                            if (i == Convert.ToString(d))
                                            {
                                                disinlist = true;
                                            }
                                        }
                                        if (aisinlist == false && a != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (bisinlist == false && b != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (cisinlist == false && c != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                        if (disinlist == false && d != 0 && validanswer == true)
                                        {
                                            validanswer = false;
                                            Console.WriteLine("You cannot use a number that has already been used.");
                                        }
                                    }
                                    for (int i = 0; i < numbers.Length; i += 2)
                                    {
                                        if (numbers[i] == Convert.ToString(a))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(b))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(c))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                        if (numbers[i] == Convert.ToString(d))
                                        {
                                            numbers[i] = "0";
                                            numbers[i + 1] = "";
                                        }
                                    }
                                    numberlist = "";
                                    foreach (string i in numbers)
                                    {
                                        if (i != "0")
                                        {
                                            numberlist = numberlist + i;
                                        }
                                    }
                                }
                            }
                            if (possible == false)
                            {
                                Console.WriteLine("You LOST :(");
                            }
                            else
                            {
                                Console.WriteLine("You WON :)");
                                successfulattempts5++;
                            }
                            totalattempts5++;
                            Console.WriteLine("Do you want to play again? (yes or no)");
                            playagain = Console.ReadLine();
                            if (playagain != "no")
                            {
                                Console.WriteLine("Do you want to change level? (yes or no)");
                                changelevel = Console.ReadLine();
                            }
                        }
                        break;
                    case "exit":
                        playagain = "no";
                        break;
                    default:
                        Console.WriteLine("Please enter a valid level.");
                        break;
                }
            }
            Console.WriteLine("Here is your final scoreboard:");
            Console.WriteLine("Level 1: " + successfulattempts1 + " out of " + totalattempts1);
            Console.WriteLine("Level 2: " + successfulattempts2 + " out of " + totalattempts2);
            Console.WriteLine("Level 3: " + successfulattempts3 + " out of " + totalattempts3);
            Console.WriteLine("Level 4: " + successfulattempts4 + " out of " + totalattempts4);
            Console.WriteLine("Level 5: " + successfulattempts5 + " out of " + totalattempts5);
            Console.ReadKey();
        }
    }
}