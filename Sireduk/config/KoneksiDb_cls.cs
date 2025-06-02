using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sireduk.config
{
    class KoneksiDb_cls : Services_cls
    {
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter adp;

        string alamatKoneksi = "server=localhost;port=3306;database=sireduk;uid=root;pwd=";
        public KoneksiDb_cls()
        {
            conn = new MySqlConnection(alamatKoneksi);
            comm = new MySqlCommand();
            adp = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Koneksi Gagal : {ex.Message}", "KONEKSI GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void tutupKoneksi()
        {
            conn.Close();
        }

        public override int EksekusiBukanQuery(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                comm.Connection = conn;
                comm.CommandText = query;

                result = comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "KONEKSI GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tutupKoneksi();
            }

            return result;
        }

        public override DataTable EksekusiQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();
                comm.Connection = conn;
                comm.CommandText = query;
                adp.SelectCommand = comm;
                adp.Fill(result);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "KONEKSI GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tutupKoneksi();
            }

            return result;
        }
    }
}
