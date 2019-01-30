using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site_Final_Mining.Model;

namespace Site_Final_Mining.Class
{
    public class TALA
    {
        string[] arrayWord;
        string[] Array_frekuensi, countFrekuensi;
        int[] Array_frekuensiCopy;
        int[] Array_frekuensiResult;
        private string[] value;
        string[] idIDF_berubah;
        string[] array = new string[10];
        connectionClass con = new connectionClass();
        int[] frekuensi;
        List<string> ListlabelSumbux = new List<string>();
        List<string> ListlabelSumbuY = new List<string>();
        List<int> totalFrekuensi = new List<int>();

        public string[] getFrekunsiKata_onArray(string[] data)
        {
            frekuensi = new int[data.Length];
            int i, j, ctr;
            for (i = 0; i < data.Length; i++)
            {
                frekuensi[i] = -1;
            }
            for (i = 0; i < data.Length; i++)
            {
                ctr = 1;
                for (j = i + 1; j < data.Length; j++)
                {
                    if (data[i].Equals(data[j]))
                    {
                        ctr++;
                        frekuensi[j] = 0;
                    }
                }
                if (frekuensi[i] != 0)
                {
                    frekuensi[i] = ctr;
                }
            }
            for (i = 0; i < data.Length; i++)

            {
                if (frekuensi[i] != 0)
                {
                    Console.WriteLine(data[i] + " muncul sebanyak " + (frekuensi[i] % 49));
                }
            }
            return data;
        }
        public int[] getFrekuensiDateDoc()
        {
            return frekuensi;
        }
        public void getFrekunsiKata(string[] data)
        {
            string[] labelSumbuX;
            string[] labelSumbuY;
            int[] frekuensi = new int[data.Length];
            int i, j, ctr;
            for (i = 0; i < data.Length; i++)
            {
                frekuensi[i] = -1;
            }
            for (i = 0; i < data.Length; i++)
            {
                ctr = 1;
                for (j = i + 1; j < data.Length; j++)
                {
                    if (data[i].Equals(data[j]))
                    {
                        ctr++;
                        frekuensi[j] = 0;
                    }
                }
                if (frekuensi[i] != 0)
                {
                    frekuensi[i] = ctr;
                }
            }
            for (i = 0; i < data.Length; i++)
            {
                if (frekuensi[i] != 0)

                {
                    Console.WriteLine(data[i] + " muncul sebanyak " + frekuensi[i]);
                    ListlabelSumbux.Add(data[i]);
                    ListlabelSumbuY.Add(Convert.ToString(frekuensi[i]));
                    totalFrekuensi.Add(frekuensi[i]);
                }

            }
            labelSumbuX = ListlabelSumbux.ToArray();
            labelSumbuY = ListlabelSumbuY.ToArray();
            Console.WriteLine("Jumlah Total Datanya : " + totalFrekuensi.Sum());
        }
        public int[] getArrayAkhir_frekuensi()
        {
            return totalFrekuensi.ToArray();
        }
        public string[] getArrayAkhir_tanggal()
        {
            return ListlabelSumbux.ToArray();
        }
    }
}