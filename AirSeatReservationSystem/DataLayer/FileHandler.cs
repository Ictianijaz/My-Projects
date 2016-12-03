using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    public class FileHandler
    {
        public string[] readFile()
        {
            StreamReader sr = new StreamReader(@"G:\5th semester\Visual Studio Projects\AirSeatReservationSystem\DataLayer\bin\Debug\seat.txt");
            string[] str = new string[100];
            str[0] = "";
            int co = 0;
            while (!(sr.EndOfStream))
            {
                string s = sr.ReadLine();
                if (s != "")
                {
                    str[co] = s;
                    co++;
                }
            }
            sr.Close();
            return str;
        }
        public void writeFile(string[] inf)
        {
            if (inf.Length > 0)
            {
                StreamWriter sw = new StreamWriter(@"G:\5th semester\Visual Studio Projects\AirSeatReservationSystem\DataLayer\bin\Debug\seat.txt", true);
                for(int i = 0; i < inf.Length; i++)
                {
                    sw.WriteLine(inf[i]);
                }
                sw.Close();
            }
           
        }
        public void writeFile1(string[] inf)
        {
            StreamWriter sw = new StreamWriter(@"G:\5th semester\Visual Studio Projects\AirSeatReservationSystem\DataLayer\bin\Debug\seat.txt", false);
            if (inf.Length == 1)
            { }
            else
            {
                for (int i = 0; i < inf.Length; i++)
                {
                    if (inf[i] != "")
                    {
                        sw.WriteLine(inf[i]);
                    }
                }
            }
            sw.Close();
        }
        public void deleteFile()
        {
            File.Delete(@"G:\5th semester\Visual Studio Projects\AirSeatReservationSystem\DataLayer\bin\Debug\seat.txt");
            File.Create(@"G:\5th semester\Visual Studio Projects\AirSeatReservationSystem\DataLayer\bin\Debug\seat.txt").Close();
        }
    }
}
