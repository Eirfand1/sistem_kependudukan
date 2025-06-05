using MySql.Data.MySqlClient;
using Sireduk.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sireduk.model
{ 
    class Dashboard_cls
    {
        MySqlConnection conn;

        public Dashboard_cls() 
        {
            KoneksiDb_cls koneksi = new KoneksiDb_cls();
            conn = koneksi.getConn();
        }

        public void LoadStatistikGender(Chart chart)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "SELECT jenis_kelamin, COUNT(*) AS jumlah FROM penduduk GROUP BY jenis_kelamin";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart.Series.Clear();
                Series series = chart.Series.Add("Jenis Kelamin");
                series.ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    string jk = row["jenis_kelamin"].ToString() == "L" ? "Laki-Laki" : "Perempuan";
                    int jumlah = Convert.ToInt32(row["jumlah"]);
                    series.Points.AddXY(jk, jumlah);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load statistik: " + ex.Message);
            }
        }

        public void LoadStatistikKelurahan(Chart chart)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Query dengan JOIN untuk mendapatkan nama kelurahan
                string query = @"SELECT k.nama_kelurahan, COUNT(*) AS jumlah 
                               FROM penduduk p 
                               INNER JOIN kelurahan k ON p.id_kelurahan = k.id_kelurahan 
                               GROUP BY k.id_kelurahan, k.nama_kelurahan 
                               ORDER BY jumlah DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart.Series.Clear();
                chart.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea("ChartArea1");
                chart.ChartAreas.Add(chartArea);

                Series series = new Series("Jumlah Penduduk per Kelurahan");
                series.ChartType = SeriesChartType.Bar;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data kelurahan untuk ditampilkan");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string kelurahan = row["nama_kelurahan"].ToString();
                    int jumlah = Convert.ToInt32(row["jumlah"]);
                    series.Points.AddXY(kelurahan, jumlah);
                }

                chart.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load statistik kelurahan: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void LoadStatistikKecamatan(Chart chart)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = @"SELECT kc.nama_kecamatan, COUNT(*) AS jumlah 
                         FROM penduduk p 
                         JOIN kelurahan k ON p.id_kelurahan = k.id_kelurahan 
                         JOIN kecamatan kc ON k.id_kecamatan = kc.id_kecamatan 
                         GROUP BY kc.id_kecamatan, kc.nama_kecamatan 
                         ORDER BY kc.nama_kecamatan";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart.Series.Clear();
                chart.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea("ChartArea1");
                chart.ChartAreas.Add(chartArea);

                Series series = new Series("Jumlah Penduduk per Kecamatan");
                series.ChartType = SeriesChartType.Column;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data kecamatan untuk ditampilkan");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string kecamatan = row["nama_kecamatan"].ToString();
                    int jumlah = Convert.ToInt32(row["jumlah"]);
                    series.Points.AddXY(kecamatan, jumlah);
                }

                chart.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load statistik kecamatan: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void LoadStatistikKabupaten(Chart chart)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Query dengan JOIN untuk mendapatkan nama kabupaten
                string query = @"SELECT kb.nama_kabupaten, COUNT(*) AS jumlah 
                               FROM penduduk p 
                               INNER JOIN kelurahan k ON p.id_kelurahan = k.id_kelurahan 
                               INNER JOIN kecamatan kc ON k.id_kecamatan = kc.id_kecamatan 
                               INNER JOIN kabupaten kb ON kc.id_kabupaten = kb.id_kabupaten 
                               GROUP BY kb.id_kabupaten, kb.nama_kabupaten 
                               ORDER BY kb.nama_kabupaten";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart.Series.Clear();
                chart.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea("ChartArea1");
                chart.ChartAreas.Add(chartArea);

                Series series = new Series("Jumlah Penduduk per Kabupaten");
                series.ChartType = SeriesChartType.Column;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data kabupaten untuk ditampilkan");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string kabupaten = row["nama_kabupaten"].ToString();
                    int jumlah = Convert.ToInt32(row["jumlah"]);
                    series.Points.AddXY(kabupaten, jumlah);
                }

                chart.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load statistik kabupaten: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
