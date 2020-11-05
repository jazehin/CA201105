using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201105
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            string nev = "Kiss Bence";
            Ritkitott(nev);
            Fuggoleges(nev);
            Atlos(nev);

            Var();
            Keret(Beker());

            Var();
            Forditva(Beker());

            Var();
            Console.WriteLine($"{ EBetu(Beker()) } db e betű van benne");

            Var();
            Console.WriteLine($"{ SzavakSzama(Beker()) } db szó van benne");

            Var();
            Console.WriteLine($"{MondatTipus(Beker())}  mondat");

            Var();
            KarakterCsere(Beker());

            Var();
            Eldontes(Beker(), "j");
            Eldontes(Beker(), "ly");

            Var(); */
            MaganhangzokSzama(Beker());
            Angolositas(Beker());


            //if(Eldontes)

            Console.ReadKey();
        }

        static string Beker()
        {
            Console.Write("Adjon meg egy szót: ");
            return Console.ReadLine();
        }

        static void Var()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void Ritkitott(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write($"{text[i]} ");
            }
            Console.WriteLine("\n");
        }

        static void Fuggoleges(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{text[i]}");
            }
            Console.WriteLine();
        }

        static void Atlos(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.SetCursorPosition(i, Console.CursorTop);
                Console.WriteLine($"{text[i]}");
            }
        }

        static void Keret(string text)
        {
            text = '*' + text + '*';
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine(text);
                        break;
                    default:
                        for (int j = 0; j < text.Length; j++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void Forditva(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

        static int EBetu(string text)
        {
            int e = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.ToLower()[i] == 'e') e++;
            }
            return e;
        }

        static int SzavakSzama(string text)
        {
            string[] szoveg = text.Split(' ');
            int c = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] != "") c++;
            }
            return c;
        }

        static string MondatTipus(string text)
        {
            if (text.Contains('.'))
            {
                return "kijelentő";
            }
            else if (text.Contains('?'))
            {
                return "kérdő";
            }
            else
            {
                return "felszólító";
            }
        }

        static void NagyKisBetu()
        {

        }

        static void KarakterCsere(string text)
        {
            text = text.ToUpper()[0] + text.Substring(1);
            Console.WriteLine(text);
        }
        static void Eldontes(string text, string keresett)
        {
            if (text.Contains(keresett)) Console.WriteLine($"A(z) {text} tartalmaz {keresett} betűt");
            else Console.WriteLine($"A(z) {text} nem tartalmaz {keresett} betűt");
        }

        static void MaganhangzokSzama(string text)
        {
            string maganh = "aáeéiíoóöőuúüű";

            int c = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (maganh.Contains(text[i])) c++;
            }
            Console.WriteLine($"{c} magánh van benne");
        }

        static void Angolositas(string text)
        {
            text = text.Replace("á", "a");
            text = text.Replace("é", "e");
            text = text.Replace("í", "i");
            text = text.Replace("ó", "o");
            text = text.Replace("ö", "o");
            text = text.Replace("ő", "o");
            text = text.Replace("ú", "u");
            text = text.Replace("ü", "u");
            text = text.Replace("ű", "u");
            Console.WriteLine(text);
        }
    }
}
