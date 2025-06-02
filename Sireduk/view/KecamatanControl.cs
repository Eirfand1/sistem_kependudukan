using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sireduk.model;

namespace Sireduk.view
{
    public partial class KecamatanControl: UserControl 
    {
        Kecamatan_cls kecamatan = new Kecamatan_cls();
        public KecamatanControl()
        {
            InitializeComponent();
        }

        private void KecamatanControl_Load(object sender, EventArgs e)
        {
            indexGrid();

            DataTable kabupaten = new Kabupaten_cls().index(); 
            kabupatenCb.DataSource = kabupaten;
            kabupatenCb.DisplayMember = "nama_kabupaten";
            kabupatenCb.ValueMember = "id_kabupaten";
        }


        private void bersihkan()
        {
            idTb.Clear();
            nama_kecamatanTb.Clear();
            idTb.Focus();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string idKecamatan = idTb.Text;

            if (kecamatan.isExist(idKecamatan))
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                 "Konfirmasi Hapus",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    kecamatan.ID_Kecamatan = idKecamatan;
                    if (kecamatan.hapusData() > 0)
                    {
                        MessageBox.Show("Sukses Hapus Data", "SUKSES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Gagal update data", "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                indexGrid();
                return;
            }
            MessageBox.Show("Data tidak ditemukan", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!kecamatan.isExist(idTb.Text))
            {
                kecamatan.ID_Kecamatan = idTb.Text;
                kecamatan.Nama_kecamatan = nama_kecamatanTb.Text;
                kecamatan.ID_Kabupaten = kabupatenCb.SelectedValue.ToString();

                if (kecamatan.simpanData() > 0)
                {
                    MessageBox.Show("Sukses menambahkan data", "SUKSES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data", "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                indexGrid();
                return;
            }

            indexGrid();
            MessageBox.Show("Data telah tersedia", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        void indexGrid()
        {

            if (cariTb.Text.Length == 0)
            {
                kecamatan_dgv.DataSource = kecamatan.index();

                warnaBelang(kecamatan_dgv);
                return;
            }

            warnaBelang(kecamatan_dgv);
            kecamatan_dgv.DataSource = kecamatan.search(cariTb.Text);
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

        private void cariTb_TextChanged(object sender, EventArgs e)
        {
            indexGrid();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (kecamatan.isExist(idTb.Text))
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?",
                                                     "Konfirmasi Ubah Data",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    kecamatan.ID_Kecamatan = idTb.Text;
                    kecamatan.Nama_kecamatan = nama_kecamatanTb.Text;
                    kecamatan.ID_Kabupaten = kabupatenCb.SelectedValue.ToString();

                    if (kecamatan.updateData() > 0)
                    {
                        MessageBox.Show("Sukses update data", "SUKSES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Gagal update data", "SUKSES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                indexGrid();
                return;
            }
            MessageBox.Show("Data tidak ditemukan", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void kecamatan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.kecamatan_dgv.Rows[e.RowIndex];
                idTb.Text = baris.Cells[0].Value.ToString();
                nama_kecamatanTb.Text = baris.Cells[1].Value.ToString();
                string idKabupaten = baris.Cells[2].Value.ToString();

                kabupatenCb.SelectedValue = idKabupaten;

            }
        }

    }
}
