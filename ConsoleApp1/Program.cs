using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // use this method to add valu to Array´s indexs
       static void AddvalutoArray(int[] x)
        {
           
            for (int i = 0; i <x.Length; i++)

            {
                Console.WriteLine("Add valu to arrayindex number :" + (i + 1));
                x[i] = int.Parse(Console.ReadLine());
               
            }
        }
        // we use this method to display an array
        static void displayarray(int []x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

        //this is a method to count the total and the average in Array
        static void TotalAndavarege(int [] arr)
        {
            int total = 0;
            for(int t =0; t < arr.Length; t++)
            {
                total = total+ arr[t];
            }
            Console.WriteLine("The total in the Array is :" + "" + total);
            Console.WriteLine("The avvarege in the array is :" + total / arr.Length);
        }
        
        static void Main(string[] args)
        {   // in this app is an example how we can use the array in methods

            Console.WriteLine("Enter your Array length");
            int Input1 = int.Parse(Console.ReadLine());
            int[] Numbers = new int[Input1];
            // here we use the Arrays methods
            AddvalutoArray(Numbers);
            displayarray(Numbers);    
            TotalAndavarege(Numbers);

        }
    }
}
