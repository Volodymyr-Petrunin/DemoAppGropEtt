using System.Text;

namespace DemoApp_09_22;

internal class Program {

    private static readonly AgeChecker AgeChecker = new AgeChecker();

    private static readonly Calculator Calculator = new Calculator();

    static void Main(string[] args) {
        bool running = true;

        while (running) {
            Console.Clear();
            PrintMenu();

            Console.Write("Välj, använd 0 för att avsluta: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    AgeChecker.Run();
                    break;
                case "2":
                    Calculator.Run();
                    break;
                case "3":
                    // Not implemented
                    Console.WriteLine("Not implemented");
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Felaktig inmatning");
                    break;
            }

            if (choice is "0") {
                continue;
            }

            Console.WriteLine("Click on any key to continue");
            Console.ReadKey();
        }
    }

    private static void PrintMenu() {
        string menu = new StringBuilder()
            .AppendLine("---Klassens verktygsläda---")
            .AppendLine("1. Kolla åldern")
            .AppendLine("2. Räkna med siffror")
            .AppendLine("3. Skapa en bil")
            .AppendLine("0. Avsluta")
            .AppendLine(new string('-', 40))
            .ToString();

        Console.WriteLine(menu);
    }
}