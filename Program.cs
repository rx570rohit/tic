using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic
{
    public static class Program
    {

        static char[] arr = new char[10];

        public static void Main(String[] arg)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ' ';
            }

            for (int i = 0; i < arr.Length; i++)
            {
               Console.WriteLine(arr[i]) ;
            }

            Console.WriteLine(CheckWin());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(i);
            }

            Console.WriteLine(CheckWin());

        }
        private static bool CheckWin()
        {
          
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return true;
            }
            
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return true;
            }
            
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return true;
            }
            
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return true;
            }
           
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return true;
            }
         
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return true;
            }
       
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return true;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return true;
            }
            

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return false;
            }
    
            else
            {
                return false;
            }

        }
    }
}

