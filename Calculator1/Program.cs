using System;
using System.Collections.Generic;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<string> calculations = new List<string>();

            Console.Clear();

            Greeting();

            bool runAgain = true;


            while (runAgain)
            {

                int userInput = 0;
                int choice = 0;
                double sum;

                Console.Clear();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("**************************************************************************");
                Console.WriteLine();
                Console.WriteLine("                            Main Menu                                      ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. Make a calculation");
                Console.WriteLine("2. Show all calculations");
                Console.WriteLine("3. Quit");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("**************************************************************************");
                Console.WriteLine();
   
                userInput = Convert.ToInt32(Console.ReadLine());


                switch (userInput)
                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine("1. Addition (+)");
                        Console.WriteLine("2. Subtraktion (-)");
                        Console.WriteLine("3. Multiplikation (*)");
                        Console.WriteLine("4. Division (/)");
                        Console.WriteLine();
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:

                                Console.WriteLine();
                                Console.WriteLine("Enter two numbers you want to add upp");
                                Console.WriteLine();
                                double num1 = Convert.ToDouble(Console.ReadLine());
                                double num2 = Convert.ToDouble(Console.ReadLine());

                                sum = num1 + num2;
                                Console.WriteLine();
                                Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
                                
                                string addition = " + ";
                                AddCalculation(num1, num2, sum, addition);

                                Console.WriteLine();
                                Console.WriteLine("Return to Main Menu? Y/N ");
                                char c = Convert.ToChar(Console.ReadLine());

                                if (char.ToLower(c) == 'y')
                                {
                                    continue;

                                }
                                else
                                {
                                    runAgain = false;
                                }
    
                                break;

                            case 2:

                                Console.WriteLine();
                                Console.WriteLine("Enter two numbers you want to subtract");
                                Console.WriteLine();
                                num1 = Convert.ToDouble(Console.ReadLine());
                                num2 = Convert.ToDouble(Console.ReadLine());

                                sum = num1 - num2;
                                Console.WriteLine();
                                Console.WriteLine("{0} - {1} = {2}", num1, num2, sum);

                                string subtraction = " - ";
                                AddCalculation(num1, num2, sum, subtraction);

                                Console.WriteLine();
                                Console.WriteLine("Return to Main Menu? Y/N ");
                                c = Convert.ToChar(Console.ReadLine());

                                if (char.ToLower(c) == 'y')
                                {
                                    continue;
                                    
                                }
                                else
                                {
                                    runAgain = false;
                                }

                                break;

                            case 3:

                                Console.WriteLine();
                                Console.WriteLine("Enter two numbers you want to multiply");
                                Console.WriteLine();
                                num1 = Convert.ToDouble(Console.ReadLine());
                                num2 = Convert.ToDouble(Console.ReadLine());

                                sum = num1 * num2;
                                Console.WriteLine();
                                Console.WriteLine("{0} * {1} = {2}", num1, num2, sum);

                                string multiplication = " * ";
                                AddCalculation(num1, num2, sum, multiplication);

                                Console.WriteLine();
                                Console.WriteLine("Return to Main Menu? Y/N ");
                                c = Convert.ToChar(Console.ReadLine());

                                if (char.ToLower(c) == 'y')
                                {
                                    continue;

                                }
                                else
                                {
                                    runAgain = false;
                                }

                                break;

                            case 4:

                                Console.WriteLine();
                                Console.WriteLine("Enter two numbers you want to divide");
                                Console.WriteLine();
                                num1 = Convert.ToDouble(Console.ReadLine());
                                num2 = Convert.ToDouble(Console.ReadLine());

                                sum = num1 / num2;
                                Console.WriteLine();
                                Console.WriteLine("{0} / {1} = {2}", num1, num2, sum);

                                string division = " / ";
                                AddCalculation(num1, num2, sum, division);

                                Console.WriteLine();
                                Console.WriteLine("Return to Main Menu? Y/N ");
                                c = Convert.ToChar(Console.ReadLine());

                                if (char.ToLower(c) == 'y')
                                {
                                    continue;

                                }
                                else
                                {
                                    runAgain = false;
                                }

                                break;

                            default:
                                break;
                        }
                        break;

                    case 2:

                        
                        PrintCalculations();
                        Console.WriteLine();
                        Console.WriteLine("1. Main Menu");
                        Console.WriteLine("2. Quit");
                        int answer = Convert.ToInt32(Console.ReadLine());

                        if (answer == 1)
                        {
                            continue;
                        }
                        else
                        {
                            runAgain = false;
                        }
                        break;

                    case 3:
                        runAgain = false;
                        break;

                    default:
                        runAgain = false;
                        break;

                }
         
            }

            void PrintCalculations()
            {
                Console.Clear();
                Console.WriteLine("Calculations : ");
                Console.WriteLine();

                foreach (string calc in calculations)
                {

                    Console.WriteLine(calc);
                }
         
            }

            void AddCalculation(double num1, double num2, double sum, string c)
            {
                string calculation = num1.ToString() + c.ToString() + num2.ToString() + " = " + sum.ToString();
                calculations.Add(calculation);

            }

            void Greeting()
            {
                Console.Write("Enter your name : ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Welcome {0}!", name);
                Console.WriteLine("Press any key to continue to the exciting calcylator Main Menu and start calculating stuff!");
                Console.ReadKey();
                Console.Clear();
            }



        }

    }
    }

