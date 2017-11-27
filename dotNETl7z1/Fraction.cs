using System;

//Fraction.cs

/// <summary>
/// Struktura Fraction stanowi reprezentacje ułameka zwykłego.
/// Struktura Fraction udostępnia typowe dziaania na ułamkach.
/// </summary>
struct Fraction
{
    /// <summary>
    /// Pole x (int) - reprezentuje licznik ułamka.
    /// </summary>
    int x;

    /// <summary>
    /// Pole y (int) - reprezentuje mianownik ułamka.
    /// </summary>
    int y;

    /// <summary>
    /// Publiczny konstruktor parametryczny.
    /// Przypisuje polom x i y zadane wartości przy czym sprawdza czy mianownik jest równy 0.
    /// </summary>
    /// <param name="x"> Zadana wartość licznika (int) </param>
    /// <param name="y"> Zadana wartość mianownika (int) </param>
    public Fraction(int x, int y)
    {
        this.x = x;
        if (y == 0)
        {
            throw new DivideByZeroException();
        }
        this.y = y;
    }

    /// <summary>
    /// Przeciążony operator dodawania "+".
    /// Dodaje do siebie 2 zadane ułamki.
    /// </summary>
    /// <param name="a"> Pierwszy składnik sumy (Fraction) </param>
    /// <param name="b"> Drugi składnik sumy (Fraction) </param>
    /// <returns> Suma ułamków (Fraction) </returns>
    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(a.x * b.y + b.x * a.y, a.y * b.y);
    }

    /// <summary>
    /// Przeciążony operator odejmowania "-".
    /// Odejmuje pierwszy zadany ułamek od drugiego.
    /// </summary>
    /// <param name="a"> Odjemna różnicy (Fraction) </param>
    /// <param name="b"> Odjemnik różnicy (Fraction) </param>
    /// <returns> Róznica ułamków (Fraction) </returns>
    public static Fraction operator -(Fraction a, Fraction b)
    {
        return new Fraction(a.x * b.y - b.x * a.y, a.y * b.y);
    }

    /// <summary>
    /// Przeciążony operator mnożenia "*".
    /// Mnoży 2 zadane ułamki.
    /// </summary>
    /// <param name="a"> Pierwszy czynnik mnożenia (Fraction) </param>
    /// <param name="b"> Drugi czynnik mnożenia (Fraction) </param>
    /// <returns> Iloczyn ułamków (Fraction) </returns>
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.x * b.x, a.y * b.y);
    }

    /// <summary>
    /// Przeciążony operator dzielenia "/".
    /// Dzieli pierwszy zadany ułamek przez drugiego.
    /// </summary>
    /// <param name="a"> Dzielna ilorazu (Fraction) </param>
    /// <param name="b"> Dzielnik ilorazu (Fraction) </param>
    /// <returns> Iloraz ułamków (Fraction) </returns>
    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.x * b.y, a.y * b.x);
    }

    /// <summary>
    /// Funkcja simplify().
    /// Skraca ułamek do najprostszej postaci.
    /// </summary>
    /// <returns> Ułamek w najprostszej postaci (Fraction) </returns>
    public Fraction simplify()
    {
        return new Fraction(this.x / GCD(this.x, this.y), this.y / GCD(this.x, this.y));
    }

    /// <summary>
    /// Funkcja GCD().
    /// Funkcja pomcnicza funkcji simplify().
    /// Oblicza największą wspólną wielkorotność dwóch liczb całkowitych.
    /// </summary>
    /// <param name="a"> Pierwsza zadana liczba całkowita (int) </param>
    /// <param name="b"> Druga zadana liczba całkowita (int) </param>
    /// <returns> Największa wspólna wielokrotność zadanych ułamków (int) </returns>
    int GCD(int a, int b)
    {
        while (b > 0)
        {
            int rem = a % b;
            a = b;
            b = rem;
        }
        return a;
    }
    
    /// <summary>
    /// Funkcja toWhole().
    /// Funkcja zamienia ułamek niewłaściwy na liczbę całkowitą z ułamkiem zwykłym
    /// w postaci krotki.
    /// </summary>
    /// <returns> Krotka zawierająca na pierwszej pozycji liczbę całkowita,
    /// a na drugiej ułamek właściwy(Tuple<int, Fraction>) </returns>
    public Tuple<int, Fraction> toWhole()
    {
        int whole = 0;
        int x = this.x;
        while (x >= this.y)
        {
            whole++;
            x -= this.y;
        }
        return new Tuple<int, Fraction>(whole, new Fraction(x, this.y));
    }

    /// <summary>
    /// Niejawny operator konwersji z typu int na typ Fraction.
    /// Zwraca ułamek zwykły, mający 1 w mianowniku i zadaną liczbę całkowitą w liczniku.
    /// </summary>
    /// <param name="x"> Zadana wartość (int) </param>
    public static implicit operator Fraction(int x) => new Fraction(x, 1);

    /// <summary>
    /// Jawny operator konwersji z typu Fraction na typ int.
    /// Zwraca liczbę całości zawartych w zdanym ułamku.
    /// </summary>
    /// <param name="f"> Zadany ułamek (Fraction) </param>
    public static explicit operator int(Fraction f) => f.x / f.y;

    /// <summary>
    /// Getter struktury Fraction.
    /// Zwraca wartość pola x.
    /// </summary>
    public int FracX => x;

    /// <summary>
    /// Getter struktury Fraction.
    /// Zwraca wartość pola y.
    /// </summary>
    public int FracY => y;

    /// <summary>
    /// Funkcja toString().
    /// Funkcja reprezentuje ułamek zwykły w postaci ciągu znaków.
    /// </summary>
    /// <returns> Ciąg znaków postaci [licznik]/[mianownik] (string) </returns>
    public string toString()
    {
        return this.FracX + "/" + this.FracY;
    }
}
