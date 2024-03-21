using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einfacher Rechner in C#");

            try
            {
                // Benutzer auffordern, die erste Zahl einzugeben
                Console.Write("Geben Sie die erste Zahl ein: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Benutzer auffordern, die zweite Zahl einzugeben
                Console.Write("Geben Sie die zweite Zahl ein: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Benutzer auffordern, die Operation auszuwählen
                Console.WriteLine("Wählen Sie die Operation ( + , - , * , / ): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        // Überprüfen, ob num2 0 ist.
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Division durch Null ist nicht erlaubt.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Ungültige Operation.");
                        return;
                }

                // Ergebnis anzeigen
                Console.WriteLine($"Ergebnis: {num1} {operation} {num2} = {result}");
            }
            catch (FormatException) //Error wenn ein String "abc" in ein Int umgewandelt wird.
            {
                Console.WriteLine("Fehler: Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }
            catch (Exception ex) //allgemeiner fehler
            {
                Console.WriteLine($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}");
            }

            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();
        }
    }
}