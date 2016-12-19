using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class FacadeControler
    {
        private FacadeControler() { }
        private static FacadeControler Instance = null;
        public static FacadeControler getFacadeControler()
        {
            if (Instance == null)
                Instance = new FacadeControler();
            return Instance;
        }
        public string getEquation(int[,] k_map, int rows, int cols)
        {
            Handler h = new Handler();
            return h.getEquation(k_map, rows, cols);
        }
    }
}
