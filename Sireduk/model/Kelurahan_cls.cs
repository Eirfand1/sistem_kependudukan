using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sireduk.config;

namespace Sireduk.model
{
    class Kelurahan_cls
    {
        private string _id_kelurahan, _id_kecamatan, _nama_kelurahan, _kode_pos;
        KoneksiDb_cls server;
        string Query;

        public Kelurahan_cls()
        {
            _id_kelurahan = "";
            _id_kecamatan = "";
            _nama_kelurahan = "";
            _kode_pos = "";

            server = new KoneksiDb_cls();
            Query = "";
        }

        public string ID_Kelurahan
        {
            set { _id_kelurahan = value; }
        }

        public string ID_kecamatan
        {
            set { _id_kecamatan = value; }
        }

        public string Nama_kelurahan
        {
            set { _nama_kelurahan = value; }
        }

        public string Kode_pos
        {
            set { _kode_pos = value; }
        }
        public bool isExist(string id)
        {
            bool cek = false;
            Query = $"select * from kelurahan where id_kelurahan='{id}'";

            if (server.EksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public int simpanData()
        {
            int hasil = 1;
            Query = $"insert into kelurahan values('{_id_kelurahan}', {_id_kecamatan},'{_nama_kelurahan}', '{_kode_pos}')";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }


        public int updateData()
        {
            int hasil = 1;

            Query = $"update kelurahan set nama_kelurahan ='{_nama_kelurahan}', id_kecamatan='{_id_kecamatan}', kode_pos='{_kode_pos}' where id_kelurahan='{_id_kelurahan}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }


        public int hapusData()
        {
            int hasil = 1;
            Query = $"delete from kelurahan where id_kelurahan='{_id_kelurahan}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }

            return hasil;
        }

        public DataTable index()
        {
            Query = "select kl.*, kc.nama_kecamatan from kelurahan kl join kecamatan kc on kc.id_kecamatan=kl.id_kecamatan";

            return server.EksekusiQuery(Query);
        }
        public DataTable search(string nama)
        {

            Query = $"select kl.*, kc.nama_kecamatan from kelurahan kl join kecamatan kc on kc.id_kecamatan=kl.id_kecamatan where nama_kelurahan like '%{nama}%'";
            return server.EksekusiQuery(Query);
        }

    }
}
