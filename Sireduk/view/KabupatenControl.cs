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
    public partial class KabupatenControl : UserControl
    {
        Kabupaten_cls kabupaten = new Kabupaten_cls();
        public KabupatenControl()
        {
            InitializeComponent();
        }

        private void KabupatenControl_Load(object sender, EventArgs e)
        {
            indexGrid();

        }

        void bersihkan()
        {
            nama_kabupatenTb.Clear();
            idTb.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!kabupaten.isExist(idTb.Text))
            {
                kabupaten.ID_Kabupaten = idTb.Text;
                kabupaten.Nama_Kabupaten = nama_kabupatenTb.Text;

                if (kabupaten.simpanData() > 0)
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
                kabupaten_dgv.DataSource = kabupaten.index();

                warnaBelang(kabupaten_dgv);
                return;
            }

            warnaBelang(kabupaten_dgv);
            kabupaten_dgv.DataSource = kabupaten.search(cariTb.Text);
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
            if (kabupaten.isExist(idTb.Text))
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?",
                                                     "Konfirmasi Ubah Data",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    kabupaten.ID_Kabupaten = idTb.Text;
                    kabupaten.Nama_Kabupaten = nama_kabupatenTb.Text;

                    if (kabupaten.updateData() > 0)
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
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string idKabupaten = idTb.Text;

            if (kabupaten.isExist(idKabupaten))
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                 "Konfirmasi Hapus",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    kabupaten.ID_Kabupaten = idKabupaten;
                    if (kabupaten.hapusData() > 0)
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

        private void kabupaten_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.kabupaten_dgv.Rows[e.RowIndex];
                idTb.Text = baris.Cells[0].Value.ToString();
                nama_kabupatenTb.Text = baris.Cells[1].Value.ToString();
            }
        }
    }

}
