using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sireduk.model;

namespace Sireduk.view
{
    public partial class KelurahanControl : UserControl
    {
        Kelurahan_cls kelurahan = new Kelurahan_cls();
        public KelurahanControl()
        {
            InitializeComponent();
        }

        private void penduduk_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void KelurahanControl_Load(object sender, EventArgs e)
        {
            indexGrid();
            DataTable kelurahan = new Kelurahan_cls().index();

        }

        void indexGrid()
        {

            if (cariTb.Text.Length == 0)
            {
                kelurahan_dgv.DataSource = kelurahan.index();

                warnaBelang(kelurahan_dgv);
                return;
            }

            warnaBelang(kelurahan_dgv);
            kelurahan_dgv.DataSource = kelurahan.search(cariTb.Text);
        }

        void warnaBelang(DataGridView grid)
        {
            foreach (DataGridViewRow baris in grid.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.White;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void kelurahan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.kelurahan_dgv.Rows[e.RowIndex];
                id_kelurahanTb.Text = baris.Cells[0].Value.ToString();
                id_kecamatanTb.Text = baris.Cells[1].Value.ToString();
                nama_kelurahanTb.Text = baris.Cells[2].Value.ToString();
                kode_posTb.Text = baris.Cells[3].Value.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string idKelurahan = id_kelurahanTb.Text;

            if (kelurahan.isExist(idKelurahan))
            {
                DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini ?",
                                                       "Konfirmasi Hapus",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {


                    kelurahan.ID_Kelurahan = idKelurahan;

                    if (kelurahan.hapusData() > 0)
                    {
                        MessageBox.Show("Alhamdulilah Sukses Menghapus", "SUKSESSS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        indexGrid();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data Dongg", "GAGALLL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                indexGrid();
                MessageBox.Show("Maaf Banget Data Tidak Ditemukan", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }


    }
}