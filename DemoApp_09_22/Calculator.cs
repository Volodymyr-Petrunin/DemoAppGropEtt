using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_09_22
{
    internal class Calculator
    {
        public void Run()
        {
            // Info message
            Console.WriteLine("----------------------------" +
                "\nCalculator 2.1" +
                "\n----------------------------" +
                "\n" +
                "\nVälkommen till miniräknaren!" +
                "\nAnge 2 hel- eller decimal tal, + ett räknesätt" +
                "\nSå kommer miniräknaren att räkna ut det åt dig.");

            // Variables for the method
            double num1 = 0.0;
            double num2 = 0.0;
            string math = "";
            double result = 0.0;

            // Loop for the first number, num1 
            while (true)
            {
                try
                {
                    // Try to double.Parse the user input
                    Console.Write("Ange första talet");
                    num1 = double.Parse(Console.ReadLine());
                    break;
                }
                // Catch the incorrect input here
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast siffror gäller." +
                        "\nFörsök igen!" +
                        "\n");
                }
            }
            // Loop for the operator, math
            while (true)
            {
                Console.Write("Ange räknesätt (+,-,*,/):");
                math = Console.ReadLine();

                // Check the input for the operator
                if (math == "+" || math == "-" || math == "*" || math == "/")
                {
                    // If the input is valid we break the loop
                    break;
                }
                else
                {
                    // If it is anything other than +,-,*,/ we give an error messages and run the input again
                    Console.WriteLine("Endast +, -, *, / är gilltliga räknesätt" +
                        "\nFörsök igen!");
                }
            }
            // Loop for the 2nd number, num2, and for using the operator to calculate the result
            while (true)
            {
                try
                {
                    // Here we use switch and case in order to give the proper result for the operator
                    Console.Write("Ange andra talet: ");
                    num2 = double.Parse(Console.ReadLine());
                    switch (math)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                    }
                    break;
                }
                // We catch if the user enters anything other than a double and print an error message
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast heltal eller decimal tal med , accepteras (t ex 2 eller 5,3)." +
                        "\nFörsök igen!");
                }
                // Here we catch if the user tries to divide by zero
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Fel inmatning, 0 är inte ett giltligt tal vid division. Försök igen!");
                }
            }
            // If num1, the operator, and num3 all pass their loops we print the result here
            Console.WriteLine($"\n" +
                $"Beräknar... " +
                $"\n{num1} {math} {num2} = {result}" +
                $"\n");
            Console.ReadKey();

        }
    }
}
