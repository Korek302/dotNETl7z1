using System;

//Program.cs

/// <summary>
/// Klasa Program
/// Zawiera metoda main, która uruchamia program.
/// </summary>
class Program
{
    /// <summary>
    /// Punkt wejściowy aplikacji.
    /// </summary>
    /// <param name="args"> Lista argumentów wiersza poleceń. </param>
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.GetEncoding("UTF-8");
        ConsoleKeyInfo cki;
        do
        {
            Console.WriteLine("Naciśnij: \n[1] - dodawanie\n[2] - odejmowanie\n[3] - mnozenie\n" +
                "[4] - dzielenie\n[5] - skracanie\n[6] - zamiana na postać z liczbą całkowitą\n" +
                "[7] - konwersja do inta\n[8] - konwersja z inta\n");
            String choice = Console.ReadLine() + " ";

            if (choice[0] == '1')
            {
                Console.WriteLine("Podaj licznik pierwszego ułamka: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Console.WriteLine("Podaj mianownik pierwszego ułamka: ");
                string sy1 = Console.ReadLine();
                while (!int.TryParse(sy1, out num) || sy1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy1 = Console.ReadLine();
                }
                int iy1 = int.Parse(sy1);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sx2 = Console.ReadLine();
                while (!int.TryParse(sx2, out num) || sx2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx2 = Console.ReadLine();
                }
                int ix2 = int.Parse(sx2);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sy2 = Console.ReadLine();
                while (!int.TryParse(sy2, out num) || sy2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy2 = Console.ReadLine();
                }
                int iy2 = int.Parse(sy2);

                if (iy1 != 0 && iy2 != 0)
                {
                    Fraction frac1 = new Fraction(ix1, iy1);
                    Fraction frac2 = new Fraction(ix2, iy2);
                    Fraction frac3 = frac1 + frac2;

                    Console.WriteLine("{0} + {1} = {2}", frac1.toString(), frac2.toString(), frac3.toString());
                }
                else
                {
                    Console.WriteLine("Podałeś 0 w mianowniku!");
                }
            }
            else if (choice[0] == '2')
            {
                Console.WriteLine("Podaj licznik pierwszego ułamka: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Console.WriteLine("Podaj mianownik pierwszego ułamka: ");
                string sy1 = Console.ReadLine();
                while (!int.TryParse(sy1, out num) || sy1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy1 = Console.ReadLine();
                }
                int iy1 = int.Parse(sy1);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sx2 = Console.ReadLine();
                while (!int.TryParse(sx2, out num) || sx2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx2 = Console.ReadLine();
                }
                int ix2 = int.Parse(sx2);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sy2 = Console.ReadLine();
                while (!int.TryParse(sy2, out num) || sy2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy2 = Console.ReadLine();
                }
                int iy2 = int.Parse(sy2);

                if (iy1 != 0 && iy2 != 0)
                {
                    Fraction frac1 = new Fraction(ix1, iy1);
                    Fraction frac2 = new Fraction(ix2, iy2);
                    Fraction frac3 = frac1 - frac2;

                    Console.WriteLine("{0} - {1} = {2}", frac1.toString(), frac2.toString(), frac3.toString());
                }
                else
                {
                    Console.WriteLine("Podałeś 0 w mianowniku!");
                }
            }
            else if (choice[0] == '3')
            {
                Console.WriteLine("Podaj licznik pierwszego ułamka: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Console.WriteLine("Podaj mianownik pierwszego ułamka: ");
                string sy1 = Console.ReadLine();
                while (!int.TryParse(sy1, out num) || sy1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy1 = Console.ReadLine();
                }
                int iy1 = int.Parse(sy1);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sx2 = Console.ReadLine();
                while (!int.TryParse(sx2, out num) || sx2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx2 = Console.ReadLine();
                }
                int ix2 = int.Parse(sx2);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sy2 = Console.ReadLine();
                while (!int.TryParse(sy2, out num) || sy2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy2 = Console.ReadLine();
                }
                int iy2 = int.Parse(sy2);

                if (iy1 != 0 && iy2 != 0)
                {
                    Fraction frac1 = new Fraction(ix1, iy1);
                    Fraction frac2 = new Fraction(ix2, iy2);
                    Fraction frac3 = frac1 * frac2;

                    Console.WriteLine("{0} * {1} = {2}", frac1.toString(), frac2.toString(), frac3.toString());
                }
                else
                {
                    Console.WriteLine("Podałeś 0 w mianowniku!");
                }
            }
            else if (choice[0] == '4')
            {
                Console.WriteLine("Podaj licznik pierwszego ułamka: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Console.WriteLine("Podaj mianownik pierwszego ułamka: ");
                string sy1 = Console.ReadLine();
                while (!int.TryParse(sy1, out num) || sy1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy1 = Console.ReadLine();
                }
                int iy1 = int.Parse(sy1);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sx2 = Console.ReadLine();
                while (!int.TryParse(sx2, out num) || sx2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx2 = Console.ReadLine();
                }
                int ix2 = int.Parse(sx2);

                Console.WriteLine("Podaj licznik drugiego ułamka: ");
                string sy2 = Console.ReadLine();
                while (!int.TryParse(sy2, out num) || sy2.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy2 = Console.ReadLine();
                }
                int iy2 = int.Parse(sy2);

                if (iy1 != 0 && iy2 != 0)
                {
                    Fraction frac1 = new Fraction(ix1, iy1);
                    Fraction frac2 = new Fraction(ix2, iy2);
                    Fraction frac3 = frac1 / frac2;

                    Console.WriteLine("{0} / {1} = {2}", frac1.toString(), frac2.toString(), frac3.toString());
                }
                else
                {
                    Console.WriteLine("Podałeś 0 w mianowniku!");
                }
            }
            else if (choice[0] == '5')
            {
                Console.WriteLine("Podaj licznik ułamka: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Console.WriteLine("Podaj mianownik ułamka: ");
                string sy1 = Console.ReadLine();
                while (!int.TryParse(sy1, out num) || sy1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy1 = Console.ReadLine();
                }
                int iy1 = int.Parse(sy1);

                if (iy1 != 0)
                { 
                    Fraction frac1 = new Fraction(ix1, iy1);
                    Fraction frac2 = frac1.simplify();

                    Console.WriteLine("{0} po skróceniu ma postać: {1}", frac1.toString(), frac2.toString());
                }
                else
                {
                    Console.WriteLine("Podałeś 0 w mianowniku!");
                }
            }
            else if (choice[0] == '6')
            {
                Console.WriteLine("Podaj licznik ułamka: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Console.WriteLine("Podaj mianownik ułamka: ");
                string sy1 = Console.ReadLine();
                while (!int.TryParse(sy1, out num) || sy1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy1 = Console.ReadLine();
                }
                int iy1 = int.Parse(sy1);

                if (iy1 != 0)
                {
                    Fraction frac1 = new Fraction(ix1, iy1);
                    Tuple<int, Fraction> outcome = frac1.toWhole();

                    Console.WriteLine("{0} po wyciągnięciu całości ma postać: {1}", frac1.toString(), 
                        outcome.Item1 + " " + outcome.Item2.toString());
                }
                else
                {
                    Console.WriteLine("Podałeś 0 w mianowniku!");
                }
            }
            else if (choice[0] == '7')
            {
                Console.WriteLine("Podaj licznik ułamka: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Console.WriteLine("Podaj mianownik ułamka: ");
                string sy1 = Console.ReadLine();
                while (!int.TryParse(sy1, out num) || sy1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sy1 = Console.ReadLine();
                }
                int iy1 = int.Parse(sy1);

                if (iy1 != 0)
                {
                    Fraction frac1 = new Fraction(ix1, iy1);
                    int outcome = (int)frac1;

                    Console.WriteLine("{0} po zamianie na liczbę całkowitą ma postać: {1}", frac1.toString(), outcome);
                }
                else
                {
                    Console.WriteLine("Podałeś 0 w mianowniku!");
                }
            }
            else if(choice[0] == '8')
            {
                Console.WriteLine("Podaj liczbę całkowitą: ");
                string sx1 = Console.ReadLine();
                int num;
                while (!int.TryParse(sx1, out num) || sx1.Length == 0)
                {
                    Console.WriteLine("Nie podałeś liczby! Podaj jeszcze raz: ");
                    sx1 = Console.ReadLine();
                }
                int ix1 = int.Parse(sx1);

                Fraction frac1 = ix1;

                Console.WriteLine("{0} po zamianie na ułamek zwykły ma postać: {1}", ix1, frac1.toString());
            }
            else
            {
                Console.WriteLine("Błędne polecenie");
            }
            Console.WriteLine("Naciśnij esc, aby zakończyć lub dowolny inny klawisz aby powtórzyć.");
            cki = Console.ReadKey();
        } while (cki.Key != ConsoleKey.Escape);
    }
}
