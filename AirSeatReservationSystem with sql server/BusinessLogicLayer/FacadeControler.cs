using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

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
        public bool checkSeatExistance(string seat)
        {
            InfoClass cSE = new InfoClass();
            return cSE.isExist(seat);
        }
        public void getInfo(string [] inf)
        {
            InfoClass info = new InfoClass();
            info.getInfoC(inf);
        }
        public bool cancelSeat(string seatNo)
        {
            InfoClass info = new InfoClass();
            return info.cancelSeatC(seatNo);
        }
        public bool cnicFormat(string cnic)
        {
            InfoClass info = new InfoClass();
            return info.cnicFormatInfo(cnic);
        }
        public bool isCnicExist(string cnic)
        {
            InfoClass info = new InfoClass();
            return info.isExistCnic(cnic);
        }
    }
}
