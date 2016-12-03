using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
namespace logicLayer
{
  class Check
    {
    
        public bool check(string id, string password)
        {
            FileHandler f = new FileHandler();
            string [] str = f.check();
            for (int i = 0; i < str.Length-1; i+= 2)
            {
                if (str[i] == id)
                {
                    if (str[i + 1] == password)
                    {
                        return true;
                    }
                }   
            }
            return false;
        }
    }
}
