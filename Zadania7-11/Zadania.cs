namespace Zadania7_11
{
    internal class Zadania
    {
        /*Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury
        liczby naturalnej n. Użyj pętli while. Np.: dla n=5 wypisz wynik 5!=120.*/
        public static void Zadanie7()
        {
            Console.WriteLine("Podaj liczbe n!: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            int liczbaN = 1;

            while (liczbaN <= n)
            {
                sum *= liczbaN;
                liczbaN++;
            }

            Console.WriteLine(sum);

        }

        /*8. Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.*/

        public static void Zadanie8()
        {
            Console.WriteLine("Podaj liczbe do sprawdzenia czy jest liczbą pierwszą: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba <= 1)
            {
                Console.WriteLine("Liczba nie jest liczbą pierwszą. ");
            }
            else
            {
                int i = 2;
                bool jestPierwsza = true;

                while (i <= Math.Sqrt(liczba))
                {
                    if (liczba % i == 0)
                    {
                        jestPierwsza = false;
                        break;
                    }
                    i++;
                }

                if (jestPierwsza)
                    Console.WriteLine("Liczba jest liczbą pierwszą. ");

                else
                    Console.WriteLine("Liczba nie jest liczbą pierwszą. ");

            }
        }

        /*9. Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej.
        Użyj pętli while. Np.: Dla liczby=1342 trzeba obliczyć sumę 1+3+4+2.*/
        public static void Zadanie9()
        {
            // długie rozwiazanie 

            Console.WriteLine("Podaj liczby do sumowania: ");
            string liczba = Console.ReadLine();

            char[] liczbyChar = liczba.ToCharArray();
            int[] gotoweLiczbyInt = new int[liczbyChar.Length];
            int sum = 0;
            int i = 0;
            int cyfra = 0;



            while (i < liczbyChar.Length && int.TryParse(liczbyChar[i].ToString(),out gotoweLiczbyInt[i]))
            {
                sum += gotoweLiczbyInt[i];
                i++;
            }


            Console.WriteLine("Suma liczb wynosi " + sum + ".");


        }

        public static void Zadanie9_1()
        {
            // krotkie rozwiazenie lepsze rozwiazanie 

            Console.WriteLine("Podaj liczby do sumowania: ");
            string liczby = Console.ReadLine();

            int sum = 0;
            int cyfra;

            foreach (char liczba in liczby)
            {
                if (int.TryParse(liczba.ToString(), out cyfra))
                    sum += cyfra;
            }

            Console.WriteLine("Suma liczb wynosi " + sum + ".");

        }

        /*10. Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, aż do
        napotkania zera. Wypisz otrzymaną sumę na ekranie. Użyj pętli do-while.*/

        public static void Zadanie10()
        {
            int sum = 0;
            int liczba = 0;

            do
            {
                Console.WriteLine("Podaj liczbe do sumowania: ");
                liczba = Convert.ToInt32(Console.ReadLine());

                sum += liczba;

                Console.WriteLine("Twoja suma to: " + sum);

            } while (liczba != 0);
        }

        /*11. Napisz program znajdujący wszystkie trójki liczb pitagorejskich z zadanego przedziału.
        Np.: dla przedziału [3,5] mamy jedną trójkę: 3, 4, 5 (bo 3^2+4^2=5^2).*/

        public static void Zadanie11()
        {
            Console.WriteLine("Podaj dolny zakres przedzialu: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj gorny zakres przedzialu: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int a = min;

            while (a <= max)
            {
                int b = a + 1;

                while (b <= max)
                {
                    double c = Math.Sqrt(a * a + b * b);

                    if (c % 1 == 0 && c <= max)
                    {
                        Console.WriteLine("{0}, {1}, {2}", a, b, (int)c);
                    }

                    b++;
                }

                a++;
            }

        }
    }
}
