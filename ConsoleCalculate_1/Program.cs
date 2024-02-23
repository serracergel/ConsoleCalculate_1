using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculate_1
{
    internal class Program
    {
        #region 2.way
        //for (int i= 0; i < input.Length ; i++)
        //{
        //    if (input[i] != ' ')
        //    {
        //        numbers += input[i];
        //    }
        //}
        #endregion

        static string input;
        static string numbers;
        static string entry;
        static void Main(string[] args)
        {



            do
            {
                 if (input == null)
                    {
                        Console.WriteLine("\"-\"=Subtract \n \"+\"=Add \n \"/\"=Divide \n \"*\"=Multiply \n Please type your calculation");
                        input = Console.ReadLine();

                    }
                   if (input[0] != '/' && input[0] != '*' && input[0] != '-' && input[0] != '+') numbers = null;
                   GetTheNumbers();

                    try
                    {
                        float result = Evaluate(numbers);
                        numbers = result.ToString(); //buradaki input en bastaki input olucak
                        Console.WriteLine($"Result = {result}\nIf you want to continue the calculation please type or press any key to exit the program");


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hata: {ex.Message}");


                    }

                    entry = Console.ReadLine();
                    input = entry;
                 
            } while (entry!=null);
           
            
        }

        private static string GetTheNumbers()
        {
           
            foreach (char item in input)
            {
                if (item != ' ') numbers += item;

            }

            return numbers;
        }

        static float Evaluate(string expression)
        {
            //uslu sayi islemi karekok ekle
            //readme ekle hangi islemleri yapabiliyor ve projenin genel aciklamasini

            for (int i = 0; i < expression.Length; i++)
            {// ½25
                
                if (expression[i] == '½')
                {
                    //sıfırlayabilirim ve bu isaret sonraki sayilari farkli degiskende toplayip onlari math sprt ile hesaba sokabilirim 
                    
                    string deneme=expression[i].ToString();
                    string test=expression.Replace(deneme, "Math.Sqrt(").Replace("16","16)");
                }

            }

            //expression =expression.Replace("½","Math.Sqrt(");


            System.Data.DataTable dataTable = new System.Data.DataTable();
            
            return Convert.ToSingle(dataTable.Compute(expression,""),CultureInfo.InvariantCulture);

        }



    }
    
}
