using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Handler
    {
        string[,] matrix1;
        string[,] matrix2;
        string[,] matrix3;
        public Handler()
        {
            matrix1 = new string[2,2];
            matrix2 = new string[4,2];
            matrix3 = new string[4,4];
            //
            //matrxi 1
            //
            matrix1[0, 0] = "A'B'";
            matrix1[0, 1] = "A'B";
            matrix1[1, 0] = "AB'";
            matrix1[1, 1] = "AB";
            //
            //matrix2
            //
            matrix2[0, 0] = "A'B'C'";
            matrix2[0, 1] = "A'B'C";
            matrix2[1, 0] = "A'BC'";
            matrix2[1, 1] = "A'BC";
            matrix2[2, 0] = "ABC'";
            matrix2[2, 1] = "ABC";
            matrix2[3, 0] = "AB'C'";
            matrix2[3, 1] = "AB'C";
            //
            //matrix3
            //
            matrix3[0, 0] = "A'B'C'D'";
            matrix3[0, 1] = "A'B'C'D";
            matrix3[0, 2] = "A'B'CD";
            matrix3[0, 3] = "A'B'CD'";
            matrix3[1, 0] = "A'BC'D'";
            matrix3[1, 1] = "A'BC'D";
            matrix3[1, 2] = "A'BCD";
            matrix3[1, 3] = "A'BCD'";
            matrix3[2, 0] = "ABC'D'";
            matrix3[2, 1] = "ABC'D";
            matrix3[2, 2] = "ABCD";
            matrix3[2, 3] = "ABCD'";
            matrix3[3, 0] = "AB'C'D'";
            matrix3[3, 1] = "AB'C'D";
            matrix3[3, 2] = "AB'CD";
            matrix3[3, 3] = "AB'CD'";
        }
        public string getEquation(int[,] k_map, int rows, int cols)
        {
            string[,] str = new string[rows, cols];
            if (rows == 2 && cols == 2)
                str = matrix1;
            else if (rows == 4 && cols == 2)
                str = matrix2;
            else if (rows == 4 && cols == 4)
                str = matrix3;
            string s = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (k_map[i, j] == 1)
                    {
                        if (s != "")
                            s += "+" + str[i, j];
                        else
                            s += str[i, j];
                    }
                }
            }
            return s;
        }

    }
}

