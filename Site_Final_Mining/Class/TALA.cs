using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site_Final_Mining.Model;
using System.Data;

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
        public bool getKataSambung(string kata)
        {
            con.openConnection();
            string query = "SELECT kata FROM public.kata_sambung where kata =  '" + kata + "'";
            DataTable result = this.con.getResult(query);
            if (result.Rows.Count == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool getKataDasar(string kata)
        {
            con.openConnection();
            string query = "SELECT katadasar FROM public.katadasar where katadasar= '" + kata + "' ";
            DataTable result = this.con.getResult(query);
            if (result.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int cekSandang(string kata)
        {
            int verified = 0;
            string[] test_1 = { "lah", "kah", "pun" };
            for (int i = 0; i < kata.Length; i++)
            {
                for (int f = 0; f < test_1.Length; f++)
                {
                    if (kata.Length < 3)
                    {

                    }
                    else if (kata.Substring(kata.Length - 3).Equals(test_1[f]))
                    {
                        verified++;
                    }

                }
            }
            return verified;
        }

        public string replace_Sandang(string kata)
        {
            string replace = "";
            string[] test_1 = { "lah", "kah", "pun" };
            for (int i = 0; i < kata.Length; i++)
            {
                for (int f = 0; f < test_1.Length; f++)
                {
                    if (kata.Substring(kata.Length - 3).Equals(test_1[f]))
                    {
                        replace = kata.Replace(kata.Substring(kata.Length - 3), string.Empty);
                        break;
                    }
                }
            }
            return replace;
        }
        public int cekAkhiran(string kata)
        {
            int verified = 0;
            string[] test_2 = { "ku", "nya", "mu", "kan", "an", "i" };
            for (int i = 0; i < kata.Length; i++)
            {
                for (int f = 0; f < test_2.Length; f++)
                {
                    if (kata.Length < 3)
                    {

                    }
                    else if (kata.Substring(kata.Length - 3).Equals(test_2[f]))
                    {
                        verified++;
                    }
                    else if (kata.Substring(kata.Length - 2).Equals(test_2[f]))
                    {
                        verified++;
                    }
                }
            }
            return verified;
        }
        public string replace_Akhiran(string kata)
        {
            string replace = "";
            string[] test_2 = { "ku", "nya", "mu", "kan", "an", "i" };
            for (int i = 0; i < kata.Length; i++)
            {
                for (int f = 0; f < test_2.Length; f++)
                {
                    if (kata.Substring(kata.Length - 3).Equals(test_2[f]))
                    {
                        replace = kata.Replace(kata.Substring(kata.Length - 3), string.Empty);
                        break;
                    }
                    else if (kata.Substring(kata.Length - 2).Equals(test_2[f]))//kenak replace kalau akhiran juga sama
                    {
                        replace = kata.Replace(kata.Substring(kata.Length - 2), string.Empty);
                        break;
                    }
                }
            }
            return replace;
        }
        public int cekawalan1(string kata)
        {
            int verified = 0;
            string[] test_2 = { "meng", "menya", "menyi" , "menyu","menye" , "menyo" ,"meny","men","mema","memi","memu","meme","memo",
            "mem","me","peng","penya","penyi","penyu","penye","penyo","peny","pen","pema","pemi","pemu","peme","pemo","pem","di","ter","ke","ber","bel","be","per","pel","pe"};
            for (int i = 0; i < kata.Length; i++)
            {
                for (int f = 0; f < test_2.Length; f++)
                {
                    if (kata.Length < 3)
                    {
                        verified = 0;
                    }
                    else if (kata.Substring(0, 2).Equals(test_2[f]))
                    {
                        verified++;
                    }
                    else if (kata.Substring(0, 3).Equals(test_2[f]))
                    {
                        verified++;
                    }

                }
            }
            return verified;
        }
        public string replace_Awalan1(string kata)
        {
            string replace = "";
            string[] test_3 = { "meng", "menya", "menyi" , "menyu","menye" , "menyo" ,"meny","men","mema","memi","memu","meme","memo",
            "mem","me","peng","penya","penyi","penyu","penye","penyo","peny","pen","pema","pemi","pemu","peme","pemo","pem","di","ter","ke","ber","bel","be","per","pel","pe"};
            string[] test_3replace = { "", "s", "s", "s", "s", "s", "s", "t", "pa", "p", "p", "p", "p" ,"","","","s","s","s","s","s","s","",
            "p","p","p","p","p","","","","","","","","","",""};

            for (int i = 0; i < kata.Length; i++)
            {
                for (int f = 0; f < test_3.Length; f++)
                {
                    if (kata.Length < 5)
                    {
                        Console.WriteLine("kata ini kurang dari 5 karakter jadi tidak bisa dihilangkan awalannya ");
                    }
                    else
                    {
                        if (kata.Substring(0, 2).Equals(test_3[f]))
                        {
                            replace = kata.Replace(kata.Substring(0, 2), test_3replace[f]);
                            Console.WriteLine("2 kata sama ");
                            break;
                        }
                        else if (kata.Substring(0, 3).Equals(test_3[f]))
                        {
                            replace = kata.Replace(kata.Substring(0, 3), test_3replace[f]);
                            Console.WriteLine("3 kata sama ");
                            break;
                        }
                        else if (kata.Substring(0, 4).Equals(test_3[f]))
                        {
                            replace = kata.Replace(kata.Substring(0, 4), test_3replace[f]);
                            Console.WriteLine("4 kata sama ");
                            break;
                        }
                        else if (kata.Substring(0, 5).Equals(test_3[f]))
                        {
                            replace = kata.Replace(kata.Substring(0, 5), test_3replace[f]);
                            if (getKataDasar(replace) == true)
                            {
                                replace = kata;
                            }
                            else
                            {
                                Console.WriteLine("dia bukan kata dasar");
                                string[] alternative = { "sa", "si", "su", "se", "so" };
                                string[] temp = new string[alternative.Length];
                                for (int fer = 0; fer < temp.Length; fer++)
                                {
                                    temp[fer] = kata.Replace(kata.Substring(0, 5), alternative[fer]);
                                    Console.WriteLine(temp[fer]);
                                    if (getKataDasar(temp[fer]) == true)
                                    {
                                        replace = kata.Replace(kata.Substring(0, 5), alternative[fer]);
                                        Console.WriteLine(temp[fer]);
                                        break;
                                    }
                                    else
                                    {
                                        replace = kata.Replace(kata.Substring(0, 5), test_3replace[f]);
                                    }
                                }
                            }
                            Console.WriteLine("5 kata sama ");
                            break;
                        }
                    }

                }
            }
            return replace;
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
        public string[] runStemming_Tala_on_Array(string data_query)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '-', '(', ')', '"', '`' };
            string[] data = data_query.Split(delimiterChars);
            List<string> ListHasil_Akhir = new List<string>();
            string[] queryHasil;
            //proses memasukkan kata kedalam array//
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = data[i].ToString().ToLower();
                //Proses filtering, atau menghilangkan kata sambung//

                if (getKataSambung(data[i]) == true)
                {
                    //proses menghilangkan wordList//
                    Console.WriteLine("[" + data[i] + "]" + "=> masuk kata sambung, kata dalam index ini dihapus");
                    data[i] = "";
                }
                //memeriksa apakah sudah kata dasar//
                else if (getKataDasar(data[i]) == true)
                {
                    data[i] = data[i];
                    Console.WriteLine("[" + data[i] + "]" + "[ini kata dasar_ so Fix]");
                }
                //proses tala ke-1// hilangkan sandang kalau ada
                else if (cekSandang(data[i]) > 0)//cek apakah punyak sandang
                {
                    Console.WriteLine("[" + data[i] + "]" + " Masuk Proses Tala 1");
                    data[i] = replace_Sandang(data[i]);//proses hapus sandang

                    if (getKataDasar(data[i]) == true)
                    {
                        Console.WriteLine("sudah kata dasar jadi " + "[" + data[i] + "]");
                    }
                    else if (cekAkhiran(data[i]) > 0)//cek akhirannya
                    {
                        Console.WriteLine("[" + data[i] + "]" + " Masuk Proses Tala 1");
                        data[i] = replace_Akhiran(data[i]);//proses hapus akhiran
                        if (getKataDasar(data[i]) == true)
                        {
                            Console.WriteLine("sudah kata dasar jadi " + "[" + data[i] + "]");
                        }

                        else
                        {
                            Console.WriteLine("belum kata dasar " + "[" + data[i] + "]" + " Lanjut ke proses selanjutnya");
                        }
                    }
                    else
                    {
                        Console.WriteLine("belum kata dasar " + "[" + data[i] + "]" + " Lanjut ke proses selanjutnya");
                        if (cekAkhiran(data[i]) > 0)// cek apakah punyak akhiran
                        {
                            data[i] = replace_Akhiran(data[i]);//proses hapus akhiran
                            Console.WriteLine("diproses 2 jadi " + "[" + data[i] + "]");
                        }

                        else
                        {
                            Console.WriteLine("[" + data[i] + "]" + "Tidak Punyak akhiran, maka dilakukan menghilangkan awalan 1");
                            data[i] = replace_Awalan1(data[i]);
                            //runVSM_DB(arrayWord[i], id, getFrekunsiKata());//lakukan proses kelola DB
                            Console.WriteLine("Tidak Punyak akhiran, maka dilakukan menghilangkan awalan 1 menjadi " + "[" + data[i] + "]");
                        }
                    }
                }
                else if (cekAkhiran(data[i]) > 0)//cek akhirannya
                {
                    Console.WriteLine("[" + data[i] + "]" + " Masuk Proses Tala 1");
                    data[i] = replace_Akhiran(data[i]);//proses hapus akhiran
                    if (getKataDasar(data[i]) == true)
                    {
                        //runVSM_DB(arrayWord[i], id, getFrekunsiKata());//lakukan proses kelola DB
                        Console.WriteLine("sudah kata dasar jadi " + "[" + data[i] + "]");
                    }
                    else
                    {
                        Console.WriteLine("belum kata dasar " + "[" + data[i] + "]" + " Lanjut ke proses selanjutnya");
                        if (getKataDasar(data[i]) == true)
                        {
                            Console.WriteLine("sudah kata dasar jadi " + "[" + data[i] + "]");
                        }
                        else if (cekawalan1(data[i]) > 0)//cek punyak awalan kah ???
                        {
                            Console.WriteLine("[" + data[i] + "]" + "Tidak Punyak akhiran, maka dilakukan menghilangkan awalan 1");
                            data[i] = replace_Awalan1(data[i]);
                            //runVSM_DB(arrayWord[i], id, getFrekunsiKata());//lakukan proses kelola DB
                            Console.WriteLine("Tidak Punyak akhiran, maka dilakukan menghilangkan awalan 1 menjadi " + "[" + data[i] + "]");
                        }
                    }
                }
                else if (cekawalan1(data[i]) > 0)
                {
                    Console.WriteLine("[" + data[i] + "]" + "Tidak Punyak akhiran, maka dilakukan menghilangkan awalan");
                    data[i] = replace_Awalan1(data[i]);
                    //runVSM_DB(arrayWord[i], id, getFrekunsiKata());//lakukan proses kelola DB
                    Console.WriteLine("Tidak Punyak akhiran, maka dilakukan menghilangkan awalan 1 menjadi " + "[" + data[i] + "]");
                }
                else if (data[i].Length < 3)
                {
                    data[i] = "";
                }
                else
                {
                    data[i] = data[i];
                    //runVSM_DB(arrayWord[i], id, getFrekunsiKata());//lakukan proses kelola DB
                    Console.WriteLine("[" + data[i] + "]");
                }
                if (!data[i].ToString().Equals(""))
                {
                    ListHasil_Akhir.Add(data[i]);
                }
            }
            queryHasil = ListHasil_Akhir.ToArray();
            return queryHasil;
        }
    }
}