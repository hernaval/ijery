using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ijery.core
{
    class Model
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Model()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\PROGRAMMING\LANGAGE C#\projet et code source\ijery\ijery\ijery\gvf.mdf;Integrated Security=True ";

        }

        public void etablirConnection()
        {
            con.Open();
        }
        public void finConnection()
        {
            con.Close();
        }

      

        public void insertion(String table, String column, String val)
        {
            try
            {
                con.Open();
                String sql = "insert into " + table + "(" + column + ") values(" + val + ") ";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void update(String table, String modif, String condition) {
            try {
                etablirConnection();
                String sql = " update " + table + " set " + modif+" where " + condition;
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                finConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public SqlDataReader select(String table, String condition)
        {

            String[] d = new String[100];
            etablirConnection();
            String sql = "select *  from " + table + " where " + condition;
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();

            return dr;
        }

        public SqlDataReader calcul(String function, String fields, String name, String table, String condition)
        {
            String[] c = new String[2];
            etablirConnection();
            String sql = " select " + function + "(" + fields + ") as "+name+" from "+table+" where " + condition;
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();

            return dr;
        }


        
    }
}
