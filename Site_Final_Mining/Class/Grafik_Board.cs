using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace Site_Final_Mining.Class
{
    public class Grafik_Board
    {
        string[] labelSumbuX;
        string[] labelSumbuY;
        int[] waktuLiputan = new int[12];
        int[] waktuTribun = new int[12];
        int[] waktuDetik = new int[12];
        public DataTable readJson()
        {
            String path = @"D:\Kuliah\Tugas Kuliah Semester 7\Skripsi\Skripsi.Skom\Program\BIsmillah FFIX\Site_Final_Mining\Site_Final_Mining\dokumenBerita\konten.json";
            using (StreamReader sr = new StreamReader(path))
            {
                string jsonpakek = sr.ReadToEnd();
                var table = JsonConvert.DeserializeObject<DataTable>(jsonpakek);
                return table;
            }
        }

        public void readJson_getDateDETIK()
        {
            string search = "site_name = 'Detik.com' ";
            DataRow[] fer = readJson().Select(search);
            DataTable dataTemp = new DataTable();
            dataTemp = fer.CopyToDataTable();
            List<string> frequensiDetik = new List<string>();
            string[] ArrayfrequensiDetik;
            for (int i = 0; i < dataTemp.Rows.Count; i++)
            {
                Console.WriteLine(dataTemp.Rows[i]["site_name"].ToString());
                string date = dataTemp.Rows[i]["date"].ToString().Substring(0, dataTemp.Rows[i]["date"].ToString().Length - 8);
                if (date.Length > 10)
                {
                    date = date.Substring(0, date.Length - 1);
                }
                Console.WriteLine(date);
                frequensiDetik.Add(date);
            }
            ArrayfrequensiDetik = frequensiDetik.ToArray();
            TALA tala = new TALA();
            tala.getFrekunsiKata(ArrayfrequensiDetik);
            Console.WriteLine("======================");
            int[] resultFrekuensi = tala.getArrayAkhir_frekuensi();
            string[] resultTanggal = tala.getArrayAkhir_tanggal();
            for (int i = 0; i < resultTanggal.Length; i++)
            {
                string cekTanggal = resultTanggal[i].Substring(2, 4);
                if (cekTanggal.Equals("/01/"))
                {
                    waktuDetik[0] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/02/"))
                {
                    waktuDetik[1] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/03/"))
                {
                    waktuDetik[2] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/04/"))
                {
                    waktuDetik[3] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/05/"))
                {
                    waktuDetik[4] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/06/"))
                {
                    waktuDetik[5] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/07/"))
                {
                    waktuDetik[6] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/08/"))
                {
                    waktuDetik[7] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/09/"))
                {
                    waktuDetik[8] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/10/"))
                {
                    waktuDetik[9] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/11/"))
                {
                    waktuDetik[10] += resultFrekuensi[i];
                }
                else
                {
                    waktuDetik[11] += resultFrekuensi[i];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("ini array akhir perbulannya");
                }
                Console.WriteLine(waktuDetik[i]);
            }
        }

        public void readJson_getDateTRIBUN()
        {
            string search = "site_name = 'Tribunnews.com' ";
            DataRow[] fer = readJson().Select(search);
            DataTable dataTemp = new DataTable();
            dataTemp = fer.CopyToDataTable();
            List<string> frequensiDetik = new List<string>();
            string[] ArrayfrequensiTribun;
            for (int i = 0; i < dataTemp.Rows.Count; i++)
            {
                Console.WriteLine(dataTemp.Rows[i]["site_name"].ToString());
                string date = dataTemp.Rows[i]["date"].ToString().Substring(0, dataTemp.Rows[i]["date"].ToString().Length - 8);
                if (date.Length > 10)
                {
                    date = date.Substring(0, date.Length - 1);
                }
                Console.WriteLine(date);
                frequensiDetik.Add(date);
            }
            ArrayfrequensiTribun = frequensiDetik.ToArray();
            TALA tala = new TALA();
            tala.getFrekunsiKata(ArrayfrequensiTribun);
            Console.WriteLine("======================");
            int[] resultFrekuensi = tala.getArrayAkhir_frekuensi();
            string[] resultTanggal = tala.getArrayAkhir_tanggal();
            for (int i = 0; i < resultTanggal.Length; i++)
            {
                string cekTanggal = resultTanggal[i].Substring(2, 4);
                if (cekTanggal.Equals("/01/"))
                {
                    waktuTribun[0] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/02/"))
                {
                    waktuTribun[1] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/03/"))
                {
                    waktuTribun[2] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/04/"))
                {
                    waktuTribun[3] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/05/"))
                {
                    waktuTribun[4] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/06/"))
                {
                    waktuTribun[5] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/07/"))
                {
                    waktuTribun[6] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/08/"))
                {
                    waktuTribun[7] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/09/"))
                {
                    waktuTribun[8] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/10/"))
                {
                    waktuTribun[9] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/11/"))
                {
                    waktuTribun[10] += resultFrekuensi[i];
                }
                else
                {
                    waktuTribun[11] += resultFrekuensi[i];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("ini array akhir perbulannya");
                }
                Console.WriteLine(waktuTribun[i]);
            }
        }

        public void readJson_getDateLIPUTAN()
        {
            string search = "site_name = 'Liputan6.com' ";
            DataRow[] fer = readJson().Select(search);
            DataTable dataTemp = new DataTable();
            dataTemp = fer.CopyToDataTable();
            List<string> frequensiLiputan = new List<string>();
            string[] ArrayfrequensiTribun;
            for (int i = 0; i < dataTemp.Rows.Count; i++)
            {
                Console.WriteLine(dataTemp.Rows[i]["site_name"].ToString());
                string date = dataTemp.Rows[i]["date"].ToString().Substring(0, dataTemp.Rows[i]["date"].ToString().Length - 8);
                if (date.Length > 10)
                {
                    date = date.Substring(0, date.Length - 1);
                }
                Console.WriteLine(date);
                frequensiLiputan.Add(date);
            }
            ArrayfrequensiTribun = frequensiLiputan.ToArray();
            TALA tala = new TALA();
            tala.getFrekunsiKata(ArrayfrequensiTribun);
            Console.WriteLine("======================");
            int[] resultFrekuensi = tala.getArrayAkhir_frekuensi();
            string[] resultTanggal = tala.getArrayAkhir_tanggal();
            for (int i = 0; i < resultTanggal.Length; i++)
            {
                string cekTanggal = resultTanggal[i].Substring(2, 4);
                if (cekTanggal.Equals("/01/"))
                {
                    waktuLiputan[0] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/02/"))
                {
                    waktuLiputan[1] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/03/"))
                {
                    waktuLiputan[2] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/04/"))
                {
                    waktuLiputan[3] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/05/"))
                {
                    waktuLiputan[4] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/06/"))
                {
                    waktuLiputan[5] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/07/"))
                {
                    waktuLiputan[6] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/08/"))
                {
                    waktuLiputan[7] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/09/"))
                {
                    waktuLiputan[8] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/10/"))
                {
                    waktuLiputan[9] += resultFrekuensi[i];
                }
                else if (cekTanggal.Equals("/11/"))
                {
                    waktuLiputan[10] += resultFrekuensi[i];
                }
                else
                {
                    waktuLiputan[11] += resultFrekuensi[i];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("ini array akhir perbulannya");
                }
                Console.WriteLine(waktuLiputan[i]);
            }
        }
        public string[] getArrayX()
        {
            return labelSumbuX;
        }
        public string[] getArrayY()
        {
            return labelSumbuY;
        }
        public int[] getData_Detik()
        {
            return waktuDetik;
        }
        public int[] getData_Tribun()
        {
            return waktuTribun;
        }
        public int[] getData_Liputan()
        {
            return waktuLiputan;
        }
    }
}