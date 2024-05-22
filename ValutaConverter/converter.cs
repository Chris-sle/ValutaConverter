namespace ValutaConverter
{
    internal class Converter

    {
        public static void converterRun()
        {
            while (true)
            {

                List<string> valuta = new List<string> { "NOK", "USD", "EUR", "GBP" };

                Console.WriteLine("Select a currency you want to convert FROM");
                for (int i = 0; i < valuta.Count; i++)
                {
                    Console.WriteLine($"{i}: {valuta[i]}");
                }

                string userReply1 = Console.ReadLine();

                int index1;
                if (int.TryParse(userReply1, out index1) && index1 >= 0 && index1 < valuta.Count)
                {
                    string fromCurrency = valuta[index1];
                    valuta.RemoveAt(index1);  // Remove the selected currency

                    Console.WriteLine($"Choose a valuta to convert to:");
                    for (int i = 0; i < valuta.Count; i++)
                    {
                        Console.WriteLine($"{i}: {valuta[i]}");
                    }

                    string userReply2 = Console.ReadLine();

                    int index2;
                    if (int.TryParse(userReply2, out index2) && index2 >= 0 && index2 < valuta.Count)
                    {
                        string toCurrency = valuta[index2];
                        Console.WriteLine("Choose the amount you want to convert");
                        double amount;
                        if (double.TryParse(Console.ReadLine(), out amount))
                        {
                            SelectCurrency(fromCurrency, toCurrency, amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount entered.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid currency selection.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid currency selection.");
                }

            }
        }


        private static void SelectCurrency(string fromCurrency, string toCurrency, double amount)
        {
            if (fromCurrency == "NOK")
            {
                switch (toCurrency)
                {
                    case "USD":
                        convertFromNokToUSD(amount);
                        break;
                    case "EUR":
                        convertFromNokToEUR(amount);
                        break;
                    case "GBP":
                        convertFromNokToGBP(amount);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
            }
            else if (fromCurrency == "USD")
            {
                switch (toCurrency)
                {
                    case "NOK":
                        convertFromUSDToNOK(amount);
                        break;
                    case "EUR":
                        convertFromUSDToEUR(amount);
                        break;
                    case "GBP":
                        convertFromUSDToGBP(amount);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
            }
            else if (fromCurrency == "EUR")
            {
                switch (toCurrency)
                {
                    case "NOK":
                        convertFromEURToNOK(amount);
                        break;
                    case "USD":
                        convertFromEURToUSD(amount);
                        break;
                    case "GBP":
                        convertFromEURToGBP(amount);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
            }
            else if (fromCurrency == "GBP")
            {
                switch (toCurrency)
                {
                    case "NOK":
                        convertFromGBPToNOK(amount);
                        break;
                    case "USD":
                        convertFromGBPToUSD(amount);
                        break;
                    case "EUR":
                        convertFromGBPToEUR(amount);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
            }
        }

        private static void ConvertCurrency(double amount, double convertionRate, string currency)
        {
            double result = amount * convertionRate;
            Console.WriteLine($"Result is {result} {currency}\n");
        }

        private static void convertFromNokToEUR(double amount)
        {
            ConvertCurrency(amount, 0.086223, "EUR");
        }

        private static void convertFromNokToUSD(double amount)
        {
            ConvertCurrency(amount, 0.093529, "USD");
        }

        private static void convertFromNokToGBP(double amount)
        {
            ConvertCurrency(amount, 0.073467, "GBP");
        }

        private static void convertFromUSDToEUR(double amount)
        {
            ConvertCurrency(amount, 0.922367, "EUR");
        }

        private static void convertFromUSDToNOK(double amount)
        {
            ConvertCurrency(amount, 10.6847, "NOK");
        }

        private static void convertFromUSDToGBP(double amount)
        {
            ConvertCurrency(amount, 0.785591, "GBP");
        }

        private static void convertFromEURToUSD(double amount)
        {
            ConvertCurrency(amount, 1.08425, "USD");
        }

        private static void convertFromEURToNOK(double amount)
        {
            ConvertCurrency(amount, 11.5861, "NOK");
        }

        private static void convertFromEURToGBP(double amount)
        {
            ConvertCurrency(amount, 0.851892, "GBP");
        }

        private static void convertFromGBPToUSD(double amount)
        {
            ConvertCurrency(amount, 1.08425, "USD");
        }

        private static void convertFromGBPToNOK(double amount)
        {
            ConvertCurrency(amount, 13.5969, "NOK");
        }

        private static void convertFromGBPToEUR(double amount)
        {
            ConvertCurrency(amount, 1.17378, "EUR");
        }
    }
}
