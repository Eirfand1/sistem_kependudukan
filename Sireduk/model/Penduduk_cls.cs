using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sireduk.config;

namespace Sireduk.model
{
    class Penduduk_cls
    {
        private string _nik, _nama_penduduk, _jenis_kelamin, _desa, _id_kecamatan;
        KoneksiDb_cls server;
        string Query;

        public Penduduk_cls()
        {
            _nik = "";
            _nama_penduduk = "";
            _jenis_kelamin = "";
            _desa = "";
            _id_kecamatan = "";

            server = new KoneksiDb_cls();

            Query = "";
        }

        public string Nik
        {
            set { _nik = value; }
        }

        public string Nama_Penduduk
        {
            set { _nama_penduduk = value; }
        }

        public string Jenis_Kelamin
        {
            set { _jenis_kelamin = value; }
        }

        public string Desa
        {
            set { _desa = value; }
        }

        public string Id_Kecamatan
        {
            set { _id_kecamatan = value; }
        }

        public bool isExist(string id)
        {
            bool cek = false;
            Query = $"select * from penduduk where nik='{id}'";

            if (server.EksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }


        public int simpanData()
        {
            int hasil = 1;
            Query = $"insert into penduduk values('{_nik}', '{_nama_penduduk}', '{_jenis_kelamin}', '{_desa}', '{_id_kecamatan}')";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }

        public int updateData()
        {
            int hasil = 1;

            Query = $"update penduduk set nama_penduduk ='{_nama_penduduk}', jenis_kelamin = '{_jenis_kelamin}', desa = '{_desa}', id_kecamatan = '{_id_kecamatan}' where nik='{_nik}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }

        public int hapusData()
        {
            int hasil = 1;
            Query = $"delete from penduduk where nik='{_nik}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }

            return hasil;
        }

        public DataTable index()
        {
            Query = "select p.*, kc.nama_kecamatan from penduduk p join kecamatan kc on kc.id_kecamatan=p.id_kecamatan";

            return server.EksekusiQuery(Query);
        }
        public DataTable search(string nama)
        {

            Query = $"select p.*, kc.nama_kecamatan from penduduk p join kecamatan kc on kc.id_kecamatan=p.id_kecamatan where nama_penduduk like '%{nama}%'";

            return server.EksekusiQuery(Query);
        }
    }
}
