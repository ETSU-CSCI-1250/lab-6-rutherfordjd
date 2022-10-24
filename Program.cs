public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("SHOW for show character, RETAIL for retail price, TEMP for temperature table, PRIME for prime numbers: ");
        string input = Console.ReadLine();

        Console.Clear();
        switch (input.Trim().ToUpper())

        {
            case "SHOW":
                Console.Write("Enter a string: ");
                string str = Console.ReadLine();
                Console.Write("Enter a position: ");
                int position = Convert.ToInt32(Console.ReadLine());
                char letter = LastLetter(str, position);
                Console.WriteLine("The letter at position " + position + $" is {letter}");
                break;
            case "RETAIL":
                Console.Write("Enter the item's wholesale price: ");
                double wholesalePrice = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the item's markup percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());
                double markup = percentage / 100;
                double price = CalculateRetail(wholesalePrice, markup);
                Console.Write("The item's retail price is " + price);
                break;
            case "TEMP":
                Console.Write("Please enter a temperature: ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                double final = Celsius(temperature);
                Console.WriteLine("Fahrenheit to Celsius ");
                Console.Write("Your temperature in celsius is: " + final + "\n");
                double fahrenheit = 80;
                double temp = fahrenheit;
                for (double i = 0; i < 20; i++)
                {
                    double end = temp++;
                    Console.Write(temp + " - ");
                    Console.WriteLine(.55 * (temp - 32));
                }
                break;
            case "PRIME":
                Console.WriteLine("Please enter a number: ");
                double n = Convert.ToInt32(Console.ReadLine());
                bool prime = true;
                for (var x = 2; x <= Math.Sqrt(n); x++)
                {
                    if (n % x == 0)
                    {
                        prime = false;
                        break;
                    }
                    }
                        if (prime)
                        {
                            Console.WriteLine("Prime");
                        }
                        else
                        {
                            Console.WriteLine("Not prime");
                        }
                        break;
                //https://csharp-book.softuni.org/Content/Chapter-7-1-complex-loops/infinite-loops/examples/example-prime-number-checking.html
        }

    }
                static char LastLetter(string str, int position)
                {
                    return str[str.Length - position];
                }
                static double CalculateRetail(double wholesalePrice, double markup)
                {
                    return (wholesalePrice + (markup * wholesalePrice));
                }
                static double Celsius(double temperature)
                {
                    return .55 * (temperature - 32);
                }


        }
    
