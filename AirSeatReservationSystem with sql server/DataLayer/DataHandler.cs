using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataHandler
    {
        string connStr = @"Data Source=DESKTOP-VEMAT4L\SQLEXPRESS;Initial Catalog=reservationSystem;Integrated Security=True";
        public string[] readFile()
        {
            string[] se = { "ada" };
            return se;
        }
        public object isExit(string seat)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            object c = (object)0;
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "select count(seatNo) from seatReservation where seatNo = '"+seat+"'";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    c = cmd.ExecuteScalar();
                }
                catch (SqlException)
                { }
                return c;
            }
            return c;
        }
        public object isCnicExit(string cnic)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            object c = (object)0;
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "select count(cnic) from seatReservation where cnic = '"+cnic+"'";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    c = cmd.ExecuteScalar();
                }
                catch (SqlException)
                { }
                conn.Close();
                return c;
            }
            conn.Close();
            return c;
        }
        public object deleteRecord(string seatNo)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            object c = 0;
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "delete from seatReservation where seatNo = '"+seatNo+"'";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    c = cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                { }
                conn.Close();
                return c;
            }
            conn.Close();
            return c;
        }
        public void writeFile(string[] inf)
        {
            
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = "insert into seatReservation (seatNo, name, fName, cnic) values ('" + inf[0] + "', '" + inf[1] + "', '" + inf[2] + "', '" + inf[3] + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                { }
               
            }
            conn.Close();
        }
    }
}
