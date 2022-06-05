// See https://aka.ms/new-console-template for more information
string[] currency = { "USD", "RUB", "TRY", "EUR" };
string[] commandBox =
{"/show-recent-currency-rates"," /find-currency-rate-by-code"," /calculate-amount-by-currecy","/exit"};
for (int i = 0; i < commandBox.Length; i++)
{
    Console.WriteLine(commandBox[i]);
}
string requiredCommand = Console.ReadLine();
int indexCommand = 0;
int totalrequiredCommand = 0;
float oneUSD = 1.7000f;
float oneRUB = 0.0271f;
float oneEUR = 1.8271f;
while (indexCommand < commandBox.Length)
{
    if (commandBox[indexCommand] == requiredCommand)
    {

        for (int i = 0; i < currency.Length; i++)
        {
            Console.WriteLine($"1 {currency[0]} - {oneUSD}AZN");
            break;
        }
        for (int j = 1; j < commandBox.Length; j++)
        {
            Console.WriteLine($"1 {currency[1]} - {oneRUB}AZN");
            break;
        }

        for (int b = 2; b < commandBox.Length; b++)
        {
            Console.WriteLine($"1 {currency[3]} - {oneEUR}AZN");
            break;
        }


        totalrequiredCommand++;


    }

    break;
    indexCommand++;
}

