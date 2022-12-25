
using System;

namespace AT_Course_Project
{
    class Program
    {
        
        public enum States { c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28, c29, c30 };

        
        public static void Main(string[] args)
        {
            string Src = "<!DOCTYPE html> <html> <body> <img src='schoolsw3.jpg' alt='Изображение SchoolsW3.com' width='104' height='142'> </body> </html>";
            int npos2 = Src.Length;
            
            int nPos = 0;
            States st = States.c0;

            while (nPos < Src.Length)
            {
                switch (st)
                {
                    case States.c0:
                        Console.WriteLine("\nСостояние 0");
                        if (Src[nPos] == '<') st = States.c1; // начало тега
                        else st = States.c2;
                        break;
                    case States.c1:
                        Console.WriteLine("\nСостояние 1");
                        if (Src.Contains("<p")) st = States.c2;// тег p
                        else if (Src.Contains("DOCTYPE")) st = States.c3;
                        else if (Src.Contains("<a>")) st = States.c4;
                        else if (Src.Contains("<abbr>")) st = States.c5;
                        else if (Src.Contains("<address>")) st = States.c6;
                        else if (Src.Contains("<area>")) st = States.c7;
                        else if (Src.Contains("<article>")) st = States.c8;
                        else if (Src.Contains("<aside>")) st = States.c9;
                        else if (Src.Contains("<audio>")) st = States.c10;
                        else if (Src.Contains("<b>")) st = States.c11;
                        else if (Src.Contains("<base>")) st = States.c12;
                        else if (Src.Contains("<body>")) st = States.c13;
                        else if (Src.Contains("<br>")) st = States.c14;
                        else if (Src.Contains("<button>")) st = States.c15;
                        else if (Src.Contains("<caption>")) st = States.c16;
                        else if (Src.Contains("<code>")) st = States.c17;
                        else if (Src.Contains("<col>")) st = States.c18;
                        else if (Src.Contains("<colgroup>")) st = States.c19;
                        else if (Src.Contains("<div>")) st = States.c20;
                        else if (Src.Contains("<form>")) st = States.c21;
                        else if (Src.Contains("<head>")) st = States.c22;
                        else if (Src.Contains("html")) st = States.c23;
                        else if (Src.Contains("<h")) st = States.c24;
                        else if (Src.Contains("<em")) st = States.c25;
                        else if (Src.Contains("<img")) st = States.c30;
                        else if (Src.Contains("</")) st = States.c29;
                        else st = States.c31;
                        break;
                    case States.c2:
                        Console.WriteLine("\nСостояние 2");
                        Src = Src.Replace("<p", "");// удаление тега p
                        Src = Src.Replace("/p", "");
                        st = States.c1;
                        break;
                    case States.c3:
                        Console.WriteLine("\nСостояние 3");
                        Src = Src.Replace("!DOCTYPE", "");// удаление тега p
                        if (Src.Contains("< ")) st = States.c26;
                        break;
                    case States.c4:
                        Console.WriteLine("\nСостояние 4");
                        Src = Src.Replace("<a>", "");// удаление тега p
                        st = States.c1;
                        break;
                    case States.c5:
                        Console.WriteLine("\nСостояние 5");
                        Src = Src.Replace("<abbr>", "");// удаление тега p
                        st = States.c1;
                        break;
                    case States.c6:
                        Console.WriteLine("\nСостояние 6");
                        Src = Src.Replace("<address>", "");
                        st = States.c1;
                        break;
                    case States.c7:
                        Console.WriteLine("\nСостояние 7");
                        Src = Src.Replace("<area>", "");
                        st = States.c1;
                        break;
                    case States.c8:
                        Console.WriteLine("\nСостояние 8");
                        Src = Src.Replace("<article>", "");
                        st = States.c1;
                        break;
                    case States.c9:
                        Console.WriteLine("\nСостояние 9");
                        Src = Src.Replace("<aside>", "");
                        st = States.c1;
                        break;
                    case States.c10:
                        Console.WriteLine("\nСостояние 10");
                        Src = Src.Replace("<audio>", "");
                        st = States.c1;
                        break;
                    case States.c11:
                        Console.WriteLine("\nСостояние 11");
                        Src = Src.Replace("<b>", "");
                        st = States.c1;
                        break;
                    case States.c12:
                        Console.WriteLine("\nСостояние 12");
                        Src = Src.Replace("<base>", "");
                        st = States.c1;
                        break;
                    case States.c13:
                        Console.WriteLine("\nСостояние 13");
                        Src = Src.Replace("<body", "");
                        Src = Src.Replace("/body", "");
                        Src = Src.Replace("<body>", "");
                        if (Src.Contains("<>")) st = States.c27;
                        else st = States.c1;
                        break;
                    case States.c14:
                        Console.WriteLine("\nСостояние 14");
                        Src = Src.Replace("<br>", "");
                        st = States.c1;
                        break;
                    case States.c15:
                        Console.WriteLine("\nСостояние 15");
                        Src = Src.Replace("<button>", "");
                        st = States.c1;
                        break;
                    case States.c16:
                        Console.WriteLine("\nСостояние 16");
                        Src = Src.Replace("<caption>", "");
                        st = States.c1;
                        break;
                    case States.c17:
                        Console.WriteLine("\nСостояние 17");
                        Src = Src.Replace("<code>", "");
                        st = States.c1;
                        break;
                    case States.c18:
                        Console.WriteLine("\nСостояние 18");
                        Src = Src.Replace("<col>", "");
                        st = States.c1;
                        break;
                    case States.c19:
                        Console.WriteLine("\nСостояние 19");
                        Src = Src.Replace("<colgroup>", "");
                        st = States.c1;
                        break;
                    case States.c20:
                        Console.WriteLine("\nСостояние 20");
                        Src = Src.Replace("<div>", "");
                        st = States.c1;
                        break;
                    case States.c21:
                        Console.WriteLine("\nСостояние 21");
                        Src = Src.Replace("<form>", "");
                        st = States.c1;
                        break;
                    case States.c22:
                        Console.WriteLine("\nСостояние 22");
                        Src = Src.Replace("<head>", "");
                        st = States.c1;
                        break;
                    case States.c23:
                        Console.WriteLine("\nСостояние 23");
                        Src = Src.Replace("html>", "");
                        Src = Src.Replace("<html", "");
                        Src = Src.Replace("<html>", "");
                        if (Src.Contains(" >")) st = States.c28;
                        else if (Src.Contains("< ")) st = States.c28;
                        else st = States.c1;
                        break;
                    case States.c24:
                        Console.WriteLine("\nСостояние 24");
                        Src = Src.Replace("h>", "");
                        Src = Src.Replace("<h", "");
                        Src = Src.Replace("<h>", "");
                        Src = Src.Replace("</h", "");
                        st = States.c1;
                        break;
                    case States.c25:
                        Console.WriteLine("\nСостояние 25");
                        Src = Src.Replace("em>", "");
                        Src = Src.Replace("<em", "");
                        st = States.c1;
                        break;
                    case States.c26:
                        Console.WriteLine("\nСостояние 26");
                        Src = Src.Replace("< ", "");
                        st = States.c1;
                        break;
                    case States.c27:
                        Console.WriteLine("\nСостояние 27");
                        Src = Src.Replace("<>", "");
                        Src = Src.Replace(" >", "");
                        st = States.c1;
                        break;
                    case States.c28:
                        Console.WriteLine("\nСостояние 28");
                        Src = Src.Replace(" >", "");
                        Src = Src.Replace("< ", "");
                        st = States.c1;
                        break;
                    case States.c29:
                        Console.WriteLine("\nСостояние 29");
                        Src = Src.Replace("</", "");
                        st = States.c1;
                        break;
                    case States.c30:
                        Console.WriteLine("\nСостояние 30");
                        Src = Src.Replace("<img", "");
                        Src = Src.Replace("'>", "");
                        st = States.c1;
                        break;
                }
                
                nPos++;
            }


            Console.WriteLine(Src);
            Console.WriteLine(nPos);
            Console.WriteLine(npos2);
        }
    }
}