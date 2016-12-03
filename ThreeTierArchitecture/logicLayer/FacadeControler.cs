using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace logicLayer
{
    public class FacadeControler
    {
        private FacadeControler() { }
        private static FacadeControler Instance = null;
        public static FacadeControler getFacadeControler()
        {
            if(Instance == null)
                {
                Instance = new FacadeControler();
            }
            return Instance;
        }
        public bool check(string id, string password)
        {
            Check c = new Check();
           return c.check(id, password);
        }
       }
}
