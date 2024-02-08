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
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            string input = Console.ReadLine();

            string numbers = null;
            foreach (char item in input)
            {
                if (item != ' ') numbers += item;
            

            }
           
            try
            {
                float result = Evaluate(input);
                Console.WriteLine($"Result = {result}");
                //Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);

            }
            
            Console.ReadLine();
            
        }

       

        static float Evaluate(string expression)
        {
            //uslu sayi islemi karekok ekle
            //readme ekle hangi islemleri yapabiliyor ve projenin genel aciklamasini

            for (int i = 0; i < expression.Length; i++)
            {
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
