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
    public partial class PendudukControl: UserControl 
    {
        Penduduk_cls penduduk = new Penduduk_cls();
        public PendudukControl()
        {
            InitializeComponent();
        }

        private void PendudukControl_Load(object sender, EventArgs e)
        {
            indexGrid();
            DataTable kelurahan = new Kelurahan_cls().index();
            kelurahanCb.DataSource = kelurahan;
            kelurahanCb.DisplayMember = "nama_kelurahan";
            kelurahanCb.ValueMember = "id_kelurahan";

            lakiRb.Checked = true;
        }


        private void bersihkan()
        {
            nikTb.Clear();
            nama_pendudukTb.Clear();
            desaTb.Clear();
            nikTb.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!penduduk.isExist(nikTb.Text))
            {
                string jenis_kelamin = lakiRb.Checked ? "L" : "P";

                penduduk.Nik = nikTb.Text;
                penduduk.Nama_Penduduk = nama_pendudukTb.Text;
                penduduk.Jenis_Kelamin = jenis_kelamin;
                penduduk.Desa = desaTb.Text;
                penduduk.Id_Kelurahan = kelurahanCb.SelectedValue.ToString();

                if (penduduk.simpanData() > 0)
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
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string nik = nikTb.Text;

            if (penduduk.isExist(nik))
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                 "Konfirmasi Hapus",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    penduduk.Nik = nik;
                    if (penduduk.hapusData() > 0)
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (penduduk.isExist(nikTb.Text))
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?",
                                                     "Konfirmasi Ubah Data",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string jenis_kelamin = lakiRb.Checked ? "L" : "P";
                    penduduk.Nik = nikTb.Text;
                    penduduk.Nama_Penduduk = nama_pendudukTb.Text;
                    penduduk.Jenis_Kelamin = jenis_kelamin;
                    penduduk.Desa = desaTb.Text;
                    penduduk.Id_Kelurahan = kelurahanCb.SelectedValue.ToString();

                    if (penduduk.updateData() > 0)
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

        void indexGrid()
        {

            if (cariTb.Text.Length == 0)
            {
                penduduk_dgv.DataSource = penduduk.index();

                warnaBelang(penduduk_dgv);
                return;
            }

            warnaBelang(penduduk_dgv);
            penduduk_dgv.DataSource = penduduk.search(cariTb.Text);
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

        private void penduduk_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow baris = this.penduduk_dgv.Rows[e.RowIndex]; 
                nikTb.Text = baris.Cells[0].Value.ToString(); 
                nama_pendudukTb.Text = baris.Cells[1].Value.ToString(); 
                string jenis_kelamin = baris.Cells[2].Value.ToString(); 

                if(jenis_kelamin == "L")
                {
                    lakiRb.Checked = true;
                }else
                {
                    perempuanRb.Checked = true;
                }

                    desaTb.Text = baris.Cells[3].Value.ToString(); 
                kelurahanCb.SelectedValue = baris.Cells[4].Value.ToString(); 
            }
        }


    }
}
