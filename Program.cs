namespace Bankomat
// kod wzorowany na "How To Code An ATM Console App In C# | Programming Tutorial For Beginners | Visual Studio 2022"


{
    public class WłaścicielKarty
    {
        string numerKarty;
        int pin;
        string imie;
        string nazwisko;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int balance = 1000000;
            Console.WriteLine("Witaj w bankomacie!");

            while (true)
            {
                Console.WriteLine("\nWybierz opcję:");
                Console.WriteLine("1: Srawdź środki");
                Console.WriteLine("2: Wypłać pieniądze");
                Console.WriteLine("3: Wpłać kase");
                Console.WriteLine("4: Zakończ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nPosiadasz najstępującą liczbę pitosu: " + balance);
                        break;

                    case 2:
                        Console.Write("\nPodaj liczbę do wypłacenia: ");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Nie posiadasz tyle pieniędzy.");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine("Wypłacono " + withdrawAmount + ".");
                            Console.WriteLine("Twoja nowa liczba środków: " + balance + ".");
                        }
                        break;

                    case 3:
                        Console.Write("\nPodaj liczbę do wpłacenia: ");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine("Udało się wpłacić " + depositAmount + ".");
                        Console.WriteLine("Twoja nowa liczba środków: " + balance + ".");
                        break;

                    case 4:
                        Console.WriteLine("\nDziękuje za użycie bankomatu.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nNiepoprawna decyzja, spróbuj jeszcze raz.");
                        break;
                }
            }
        }
    }
}
