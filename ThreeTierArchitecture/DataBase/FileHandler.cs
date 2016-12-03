
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DataBase
{
     public class FileHandler
    {
        
        public string[] check()
        {

            string[] str = new string[10];
            
            int counter = 0;
            StreamReader sr = new StreamReader(@"G:\5th semester\Visual Studio Projects\ThreeTierArchitecture\DataBase\bin\Debug\log.txt");
            while (!sr.EndOfStream)
            {
                str[counter] = sr.ReadLine();
                counter++;
            }
            return str;
        }
            
        }
    }

