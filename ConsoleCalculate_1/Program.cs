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
        //readme ekle hangi islemleri yapabiliyor ve projenin genel aciklamasini
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please use '*' for multiplication and '/' for division\nNotice:If the ongoing calculation begins with a negative number,write it in parentheses (ex:(-5) - 4).To exit the game, please click the cross on the top right\nPlease type your calculation(ex:15-2/5)\n");

            string input = Console.ReadLine();
            string numbers = null;
            string entry;
            do
            {
                try
                {
                    if (input[0] != '/' && input[0] != '*' && input[0] != '-' && input[0] != '+') numbers = null;
                 
                    foreach (char item in input)
                    {
                        if (item != ' ') numbers += item;

                    }

                    numbers = NumberControl(numbers);


                    float result = Evaluate(numbers);
                    //We will take it as input to continue the calculation

                    numbers = NumberControl(result.ToString());

                    Console.WriteLine($"Result = {result}\nIf you want to continue the calculation please type or press enter to exit the program");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("To exit the game,please click the cross on the top right ");
                   
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Hata: {ex.Message}");

                }

                    entry = Console.ReadLine();
                    input = entry;
                 
            } while (entry!=null);


          
        }

        private static string NumberControl(string numberToCheck)
        {
            string numberToAdd = numberToCheck;
             return numberToAdd.Replace(',', '.');
            
        }

        static float Evaluate(string expression)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            
            return Convert.ToSingle(dataTable.Compute(expression,""),CultureInfo.InvariantCulture);
        }



    }
    
}
