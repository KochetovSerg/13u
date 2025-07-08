using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._3U
{
    internal class Program
    {
        // ---------------формат ввода через '.'
        static IFormatProvider formatter =
                   new NumberFormatInfo { NumberDecimalSeparator = "." };

        static void Main(string[] args)
        { 
           // levels = new List<level>();
        
           // Proba_Time();
            //------ ввод   сетки -----------------
            string str = "Задайте колличество уровней целое число";
            str = In_Ot(str);
            num_step = Convert.ToInt32(str);
            str = "Задаййте верхнюю цену через(.) ";
            str = In_Ot(str);
            hig_price = decimal.Parse(str, formatter);
            str = "Задайте шаг цены уровня через (.)";
            str = In_Ot(str); ;
            step_price = decimal.Parse(str,formatter);


            // ----- расчет пар.сетки--------
             Rasch_Grid();
            // ------вывод пар.сетки---------
            Write_Grid();
        }
        //=================end prog====================================

        // ------------- переменные(поля) ------------
        #region Fieds      

        static decimal hig_price;// верхняя цена сетки
        static decimal step_price;// шаг сетки 
        static int num_step;  // кол-во шагов сетки,размер 
                              //--- массив уровней сетки --
        static List<level>levels = new List<level>();
        static int sec; //текущ.время сек.
        #endregion
        //=================== menod grid------------------------------------       
        #region metod grid       
        // ---функия ввода вывода числа--------
        static string In_Ot(string message)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();
            if (str != null && str.Length > 0)
            {
                return str;
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");
                return "1";
            }
        }
        //----вывод параметров сетки--------------
        static void Write_Grid()
        {
            // --вывод параметров сетки--------------
            Console.WriteLine("Колличество шагов = " + num_step);
            if (levels.Count > 0)
            {
                Console.WriteLine("верхняя цена = " 
                    + levels[0].Pricelevel +
                 "  нижняя цена = " + levels[levels.Count-1].Pricelevel);
                for (int i = 0; i < levels.Count; i++)
                {
                    Console.WriteLine(levels[i].Pricelevel);
                }
            }
            else
            {
                Console.WriteLine("КОЛИЧЕСТВО УРОВНЕЙ = 0");
            }
        }
        //------------------ расчет сетки-------
        static void Rasch_Grid()
        {
            decimal Pricelevel = hig_price;
            for (int i = 0; i < num_step; i++)
            {
                level level = new level();
                level.Pricelevel = Pricelevel;  
                     levels.Add(level);         
                    Pricelevel = Pricelevel - step_price;
            }
            // --- расчет сетки от верхней цены------------------ 
            //level.Calclevels(hig_price, step_price, num_step);
        }
        #endregion//====================
        static Trade trade = new Trade();

        static void Proba_Time()
        {
            trade.Price = 2345;
            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(90);
                int Sec = DateTime.Now.Millisecond;
                Console.WriteLine("Sec = " + Sec);
            }
        }

    }
    
}


