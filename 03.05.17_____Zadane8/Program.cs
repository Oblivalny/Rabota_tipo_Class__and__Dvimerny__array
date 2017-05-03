using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._17_____Zadane8
{
    class Program
    {
        public struct Man
        {
            public string famili;
            public string name, othistvo;
            public int adres;
            public int year;
            /*string famili ;
           
            string othistvo;
            string adres;
            string year;*/
        
        }

        /*struct famili
        {
            Man name, othistvo, adres, year;
        }*/
        static void Main(string[] args)
        {
            string str = File.ReadAllText(@"C:\Users\student\Desktop\text.txt");

            char r = '\n';
           
            string count = "";
            
            
            for (int i = 0; str[i] != r; i++)
            {
                count += str[i];
            }

            string[] stolb = count.Split(new Char[] { '\t' });

            string[] matrix = str.Split(new Char[] { '\n', '\t' });

            string[] strok = str.Split(new Char[] { '\n' });

            string[,] arr = new string[strok.Length, stolb.Length];



            int c = 0;
            for (int i = 0; i < strok.Length; i++)
            {
                for (int j = 0; j < stolb.Length; j++)
                {
                    arr[i,j] = matrix[c];
                    c++;
                }
            }
            
           for (int i = 0; i < strok.Length; i++)
            {
                
               
                for (int j = 0; j < stolb.Length; j++)
                {
                    Console.Write(arr[i, j]);
                    c = 1;
                }
                Console.WriteLine();
            }


           int[] got = new int[strok.Length];
           string k = ""; 
           for (int i = 1; i < strok.Length; i++)
           {
               k = "";
               for (int j = 6; j < 10; j++)
               {
                   string h = arr[i, 4];
                   k += h[j];
               }
               got[i] = Convert.ToInt32(k);
           }




           Man[] men = new Man[strok.Length];
           for (int i = 0; i < strok.Length ; i++)
           {
               men[i].famili = arr[i, 0];
           }
           for (int i = 0; i < strok.Length; i++)
           {
               men[i].name = arr[i, 1];
           }
           for (int i = 0; i < strok.Length; i++)
           {
               men[i].othistvo = arr[i, 2];
           }
           for (int i = 1; i < strok.Length; i++)
           {
               men[i].adres = Convert.ToInt32(arr[i, 3]);
           }
           for (int i = 0; i < strok.Length; i++)
           {
               men[i].year = got[i];
           }

           for (int i = 0; i < strok.Length; i++)
           {
               if (men[i].year == 2010)
                   Console.WriteLine(men[i].famili + " " + men[i].name + " " + men[i].othistvo + " " + men[i].adres + " " + men[i].year + " ");
           }

            Console.ReadKey();
        }




    }
}
