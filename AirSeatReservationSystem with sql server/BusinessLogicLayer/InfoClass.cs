using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogicLayer
{
    class InfoClass
    {
        public bool isExist(string seatNo)
        {
            DataHandler f = new DataHandler();
            int count = 0; 
            object c = f.isExit(seatNo);
            try
            {
                count = (int)c;
            }
            catch (InvalidCastException)
            { }
            catch (NullReferenceException)
            { }
            if (count == 0)
                return false;
            else
                return true;
        }

        public bool isExistCnic(string cnic)
        {
            DataHandler f = new DataHandler();
            object c = f.isCnicExit(cnic);
            int count = 0;
            try
            {
                count = (int)c;
            }
            catch (InvalidCastException)
            { }
            catch (NullReferenceException)
            { }
            if (count == 0)
                return false;
            else
                return true;
        }
        public void getInfoC(string [] inf)
        {
            DataHandler file = new DataHandler();
            file.writeFile(inf);

        }
        public bool cancelSeatC(string seatNo)
        {
            DataHandler f = new DataHandler();
            int c = 0;
            try
            {
                object o  = (int)f.deleteRecord(seatNo);
                c = (int)o;
            }
            catch (InvalidCastException)
            { }
            catch (NullReferenceException)
            { }
            if (c == 0)
                return false;
            else
                return true;
        }
        public bool cnicFormatInfo(string cnic)
        {
        
            string pattern = @"^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$";
            Regex rgx = new Regex(pattern,RegexOptions.IgnoreCase);
            return rgx.IsMatch(cnic);
        }
       
    }
}
