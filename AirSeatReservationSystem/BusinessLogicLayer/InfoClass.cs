﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogicLayer
{
    class InfoClass
    {
        public bool isExist(string seatNo)
        {
            FileHandler f = new FileHandler();
            string[] str = f.readFile();
            if (str.Length == 0)
                return false;
            else
            {
                for (int i = 3; i < str.Length; i += 4)
                {
                    if (seatNo == str[i])
                        return true;
                }
                return false;
            }
        }

        public bool isExistCnic(string cnic)
        {
            FileHandler f = new FileHandler();
            string[] str = f.readFile();
            if (str.Length == 0)
                return false;
            else
            {
                for (int i = 2; i < str.Length; i += 4)
                {
                    if (cnic == str[i])
                        return true;
                }
                return false;
            }
        }
        public void getInfoC(string [] inf)
        {
            FileHandler file = new FileHandler();
            file.writeFile(inf);

        }
        public bool cancelSeatC(string seatNo)
        {
            FileHandler f = new FileHandler();
            string[] str = f.readFile();
            string[] info = new string[str.Length];
            info[0] = "";
            for (int i = 3; i < str.Length; i += 4)
            {
                if (seatNo == str[i])
                {
                    continue;
                }
                else
                {
                    info[i - 3] = str[i - 3];
                    info[i - 2] = str[i - 2];
                    info[i - 1] = str[i - 1];
                    info[i] = str[i];
                }
            }
            f.writeFile1(info);
            return true;
        }
        public void deleteFileI()
        {
            FileHandler f = new FileHandler();
            f.deleteFile();
        }
        public bool cnicFormatInfo(string cnic)
        {
            if (cnic.Length < 13 || cnic.Length > 13)
            {
                return false;
            }
            else
            {
                char[] arr = cnic.ToCharArray();
                bool flage = true;
                for (int i = 0; i < cnic.Length; i++)
                {
                    if (!(arr[i] >= '0' && arr[i] <= '9'))
                    {
                        flage = false;
                        break;
                    }
                }
                return flage;
            }
        }
    }
}