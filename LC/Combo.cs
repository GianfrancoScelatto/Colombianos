using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LC
{
    public static class Combo
    {
        public static bool Combo2campos(ComboBox combo, string campo1, string campo2, string tabla)
        {
            bool rta;
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var conectar = new Connect();
            var Sql = "Select " + campo1.ToUpper() + "," + campo2 + " From " + tabla + " Order by '" + campo1 + "'";

            try
            {
                conn = conectar.Abrir();
                cmd.Connection = conn;
                var cmd1 = new SqlCommand(Sql, conn);
                var da = new SqlDataAdapter(cmd1);
                var ds = new DataSet();
                da.Fill(ds);
                combo.DataSource = ds.Tables[0];
                combo.DisplayMember = ds.Tables[0].Columns[0].Caption;
                rta = true;
            } //Fin Try

            catch (Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");
                rta = false;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();

                }

            }

            return rta;
        }
    }
}