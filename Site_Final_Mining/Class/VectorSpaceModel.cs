using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site_Final_Mining.Model;
using Site_Final_Mining.Class;
using System.Data;

namespace Site_Final_Mining.Class
{
    class VectorSpaceModel
    {
        TALA tala = new TALA();
        string[] idDoc;
        double hasil_TF_IDF_Query;
        double[] hasilTF_IDF_Perkata_Pembilang;
        double[] hasilTF_IDF_Perkata_Pembagi;
        double sum_arrayQuery;
        double value_arrayQuery;
        int panjangQuery;
        string[] idDoc_Terlibat = new string[50];
        List<string> idList = new List<string>();
        string[] idList_Array = new string[50];
        int[] frekuensiArray;
        string[] queryArray;
        string[] queryArraySearch;
        List<int> frekuensiList = new List<int>();
        List<string> queryList = new List<string>();
        List<string> ListHasil_Akhir = new List<string>();
        List<string> listHasilAkhir_toSearchDate = new List<string>();
        string[] arrayHasil_Akhir;
        string[] arrayHasilDate;
        string[] arrayHasilDatePure;

        public string getIDF_Term(string term)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            double getIDF_Term = 0;
            string QgetDF_Term = "SELECT \"IDF\"  FROM public.\"Term\" where \"Term\"='" + term + "';";
            DataTable result = con.getResult(QgetDF_Term);
            getIDF_Term = Convert.ToDouble(result.Rows[0]["IDF"]);
            return getIDF_Term.ToString();

        }

        public double cekKetersediaan_Term(string kata)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            string query = "SELECT \"Term\"  FROM public.\"Term\" where \"Term\"='" + kata + "';";
            DataTable result = con.getResult(query);
            if (result.Rows.Count >= 1)
            {
                con.openConnection();
                double getIDF_Term = 0;
                string QgetDF_Term = "SELECT \"IDF\"  FROM public.\"Term\" where \"Term\"='" + kata + "';";
                DataTable result2 = con.getResult(QgetDF_Term);
                getIDF_Term = Convert.ToDouble(result2.Rows[0]["IDF"]);
                return getIDF_Term;

            }
            else
            {
                return 0;
            }

        }
        public double count_TF_IDF_Query(double Tf_Idf, double frekuensi)
        {
            double hasil = 0;
            hasil = frekuensi * Tf_Idf;
            return hasil;
        }


        public string cariID_Term(string data)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            string termCari = null;
            string termMasuk = "SELECT * FROM public.\"Term\" where \"Term\"='" + data + "';";
            DataTable result2 = con.getResult(termMasuk);
            idDoc = new string[result2.Rows.Count];
            if (result2.Rows.Count >= 1)
            {
                termCari = result2.Rows[0]["id_Term"].ToString();
                return termCari;
            }
            else
            {
                return "null";
            }

        }

        public double cariTF_IDF(string id_doc, string idTerm)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            double termCari;
            string termMasuk = "SELECT \"TF-IDF\" FROM public.\"bobotTerm\" where" +
                " \"idDokumen\"=" + id_doc + " and \"id_Term\"=" + idTerm + ";";
            DataTable result2 = con.getResult(termMasuk);
            if (result2.Rows.Count >= 1)
            {
                termCari = Convert.ToDouble(result2.Rows[0]["TF-IDF"]);
                return termCari;
            }
            else
            {
                return 0;
            }

        }

        public void getDoc_MengandungQuery(string[] query)
        {
            double[] hasilPembilang_Perkata;
            double[] hasilPenyebut_Perkata;
            for (int i = 0; i < query.Length; i++)
            {
                string queryPakek = cariID_Term(query[i]);
                if (queryPakek.Equals("0"))
                {
                    Console.WriteLine("Tidak ada dokument yang memakai kata '" + query + "'");
                    Console.WriteLine("======================================================================");
                }
                else
                {
                    connectionClass con = new connectionClass();
                    con.openConnection();
                    string queryDF = "SELECT \"idDokumen\", \"id_Term\", \"TF-IDF\" FROM public.\"bobotTerm\" where" +
                        " \"id_Term\"='" + queryPakek + "'";
                    DataTable result = con.getResult(queryDF);
                    string[] dataID_Term = new string[result.Rows.Count];
                    hasilTF_IDF_Perkata_Pembagi = new double[dataID_Term.Length];
                    hasilTF_IDF_Perkata_Pembilang = new double[dataID_Term.Length];
                    string[] dataTF_IDF_Term = new string[result.Rows.Count];
                }
            }




        }

        public void getFrekuensi_fromQuery(string[] data)
        {
            int[] frekuensi = new int[data.Length];
            int i, j, ctr;
            Console.WriteLine("Query mengandung " + data.Length + " kata");
            panjangQuery = data.Length;
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
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < data.Length; i++)

            {
                if (frekuensi[i] != 0)

                {
                    if (!data[i].Equals(""))
                    {
                        if (data[i].Length > 2)
                        {
                            string cek = cariID_Term(data[i]);
                            if (!cek.Equals("null"))
                            {
                                frekuensiList.Add(frekuensi[i]);
                                queryList.Add(data[i]);
                            }
                        }
                    }
                }
            }
            frekuensiArray = frekuensiList.ToArray();
            queryArray = queryList.ToArray();
        }

        public string[] getDokumen(string query)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '-', '(', ')', '"', '`' };
            System.Console.WriteLine($"Original text: '{query}'");
            List<double> semuaTF_IDFQuery = new List<double>();
            string[] words = query.Split(delimiterChars);
            for (int i = 0; i < words.Length; i++)
            {
                List<string> ListQuery = new List<string>();
                queryArraySearch = new string[words.Length];
                ListQuery.Add("'" + words[i] + "'");
            }
            queryArraySearch = queryList.ToArray();
            for (int i = 0; i < queryArraySearch.Length; i++)
            {
                Console.WriteLine(queryArraySearch[i]);
            }

            return words;

        }

        public string[] getID_Term(string[] query)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            string queryTerm = "SELECT \"id_Term\" FROM public.\"Term\" where \"Term\" in ( " + string.Join(", ", query) + ");";
            DataTable result = con.getResult(queryTerm);
            string[] arrayTerm = new string[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                if (result.Rows.Count > 0)
                {
                    arrayTerm[i] = "'" + result.Rows[i]["id_Term"] + "'".ToString();
                }
                else
                {
                    arrayTerm[i] = "null".ToString();
                }

            }
            return arrayTerm;

        }
        public string[] getID_Doc(string[] idTerm)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            string queryTerm = "SELECT \"idDokumen\" ,count(*) FROM public.\"bobotTerm\" where \"id_Term\" in " +
                "(" + string.Join(", ", idTerm) + ") group by \"idDokumen\";";
            DataTable result = con.getResult(queryTerm);
            string[] arrayDoc = new string[result.Rows.Count];
            List<string> List_idDoc = new List<string>();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                if (!List_idDoc.Contains(result.Rows[i]["idDokumen"]))
                {
                    List_idDoc.Add("'" + result.Rows[i]["idDokumen"] + "'".ToString());
                }
            }
            arrayDoc = List_idDoc.ToArray();
            return arrayDoc;
        }

        public string[] getQuery()
        {
            List<string> listQuery = new List<string>();
            for (int i = 0; i < queryArray.Length; i++)
            {
                listQuery.Add("'" + queryArray[i] + "'");
            }
            string[] querySearch = listQuery.ToArray();
            return querySearch;
        }

        public string[] getId_Doc(string idTerm)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            string query = "SELECT \"idDokumen\" FROM public.\"bobotTerm\" where \"id_Term\" = '" + idTerm + "'";
            DataTable result = con.getResult(query);
            string[] arrayDoc = new string[result.Rows.Count];
            for (int i = 0; i < result.Rows.Count; i++)
            {
                arrayDoc[i] = result.Rows[i]["idDokumen"].ToString();
            }
            return arrayDoc;
        }
        public string[] getDate_Doc(string[] idDoc)
        {
            connectionClass con = new connectionClass();
            con.openConnection();
            string queryTerm = "SELECT  \"dateDoc\"  FROM public.\"Dokumen\" where \"idDokumen\" in (" + string.Join(", ", idDoc) + ") order by  \"dateDoc\" desc;";
            DataTable result = con.getResult(queryTerm);
            string[] arrayDate = new string[result.Rows.Count];
            string[] arrayDateAkhir = new string[result.Rows.Count];
            List<string> List_dateDoc = new List<string>();
            List<string> List_dateDocAkhir = new List<string>();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                string temp = result.Rows[i]["dateDoc"].ToString();
                if (temp.Length > 10)
                {
                    temp = temp.Substring(0, temp.Length - 1);
                }
                List_dateDoc.Add(temp);
            }
            arrayDate = List_dateDoc.OrderBy(x => DateTime.Parse(x)).ToArray();
            for (int i = 0; i < arrayDate.Length; i++)
            {
                List_dateDocAkhir.Add("'" + arrayDate[i] + "'");
            }
            arrayDateAkhir = List_dateDocAkhir.ToArray();
            Console.WriteLine("=============ini urutannya");
            for (int i = 0; i < arrayDateAkhir.Length; i++)
            {
                Console.WriteLine(arrayDateAkhir[i]);
            }
            return arrayDateAkhir;
        }
        public string[] getDate_PURE(string[] idDoc)
        {
            List<string> List_dateDoc = new List<string>();
            connectionClass con = new connectionClass();
            con.openConnection();
            string queryTerm = "SELECT  \"dateDoc\"  FROM public.\"Dokumen\" where \"idDokumen\" in (" + string.Join(", ", idDoc) + ") order by  \"dateDoc\" desc;";
            DataTable result = con.getResult(queryTerm);
            string[] arrayDate = new string[result.Rows.Count];
            for (int i = 0; i < result.Rows.Count; i++)
            {
                string temp = result.Rows[i]["dateDoc"].ToString();
                if (temp.Length > 10)
                {
                    temp = temp.Substring(0, temp.Length - 1);
                }
                List_dateDoc.Add(temp);
            }
            arrayHasilDatePure = List_dateDoc.ToArray();
            return arrayHasilDatePure;
        }

        public void runVSM(string query)
        {
            double[] arrayQuery_TF_IDF;
            List<double> semuaTF_IDFQuery = new List<double>();
            List<double> semuaTF_IDFQuery_toPenyebut = new List<double>();
            List<double> pembilang = new List<double>();
            double hasilPembilangPER_doc = 0;
            double hasilPenyebutPER_doc = 0;
            List<double> tempPembilang = new List<double>();
            List<double> tempPenyebut = new List<double>();
            getFrekuensi_fromQuery(getDokumen(query)); // ambil frekunsi query perkata (query dan frekuensinya)
            if (queryArray.Length != 0)
            {
                for (int i = 0; i < queryArray.Length; i++)
                {
                    Console.WriteLine("kata '" + queryArray[i] + "' pd query muncul " + frekuensiArray[i] + " kali");
                    double TF_IDF_Query = Convert.ToDouble(cekKetersediaan_Term(queryArray[i]));
                    hasil_TF_IDF_Query = count_TF_IDF_Query(TF_IDF_Query, Convert.ToDouble(frekuensiArray[i]));
                    Console.WriteLine("nilai TF-IDF kata '" + queryArray[i] + "' = " + hasil_TF_IDF_Query);
                    semuaTF_IDFQuery.Add(hasil_TF_IDF_Query);
                    semuaTF_IDFQuery_toPenyebut.Add(Math.Pow(hasil_TF_IDF_Query, 2));
                }
                arrayQuery_TF_IDF = semuaTF_IDFQuery_toPenyebut.ToArray();
                double hasilAkhir_Penyebutquery = Math.Sqrt(arrayQuery_TF_IDF.Sum());
                Console.WriteLine("Nilai sum akar query = " + hasilAkhir_Penyebutquery);
                string[] idTerm = getID_Term(getQuery());
                string[] idDocTerlibat = getID_Doc(idTerm);
                Console.WriteLine("Dokument Yang Terlibat Pada Query Ada " + idDocTerlibat.Length + ", yaitu: ");
                for (int i = 0; i < idDocTerlibat.Length; i++)
                {
                    Console.WriteLine(idDocTerlibat[i]);
                    for (int f = 0; f < queryArray.Length; f++)
                    {
                        double[] hasilTF_IDF_Query = semuaTF_IDFQuery.ToArray();
                        double temp_TF_IDF_doc_toQuery = cariTF_IDF(idDocTerlibat[i], idTerm[f]);
                        tempPembilang.Add(temp_TF_IDF_doc_toQuery);
                        tempPenyebut.Add(Math.Pow(temp_TF_IDF_doc_toQuery, 2));
                        Console.WriteLine(temp_TF_IDF_doc_toQuery);
                    }
                    hasilPembilangPER_doc = tempPembilang.ToArray().Sum();
                    hasilPenyebutPER_doc = tempPenyebut.ToArray().Sum();
                    tempPembilang.Clear();
                    tempPenyebut.Clear();
                    Console.WriteLine("==========================");
                    Console.WriteLine("hasil total pembilang id Doc " + idDocTerlibat[i] + " = " + hasilPembilangPER_doc);
                    Console.WriteLine("hasil total penyebut id Doc  " + idDocTerlibat[i] + " = " + hasilPenyebutPER_doc);
                    Console.WriteLine("Go Hitung Similarity Doc id " + idDocTerlibat[i] + " dengan Query");
                    double hasilSimilarity = Math.Round(hasilPembilangPER_doc / (hasilAkhir_Penyebutquery * hasilPenyebutPER_doc), 5);
                    Console.WriteLine("Nilai Similarity Doc id " + idDocTerlibat[i] + " dengan Query = " + hasilSimilarity);

                    if (hasilSimilarity >= 0.5)
                    {
                        if (!ListHasil_Akhir.Contains(idDocTerlibat[i]))
                        {
                            ListHasil_Akhir.Add(idDocTerlibat[i]);
                        }

                    }
                    arrayHasil_Akhir = ListHasil_Akhir.ToArray();

                    for (int ferry = 0; ferry < arrayHasil_Akhir.Length; ferry++)
                    {
                        if (idDocTerlibat.Length - 1 == i)
                        {
                            Console.WriteLine("Id Doc yang masuk :");
                            Console.WriteLine(arrayHasil_Akhir[ferry]);

                        }

                    }
                }
            }
            else
            {
                string status = "tidak ada dokumen yang mengandung kata pada setiap query";
            }

        }
        public void run(string query)
        {
            List<double> semuaTF_IDFQuery = new List<double>();
            List<double> semuaTF_IDFQuery_toPembilang = new List<double>();
            double[] arrayQuery_TF_IDF;
            double[] arrayQuery_TF_IDF_toPembilang;
            double hasilPembilangPER_doc = 0;
            double hasilPenyebutPER_doc = 0;
            getFrekuensi_fromQuery(getDokumen(query));
            if (queryArray.Length == 0)
            {
                string status = "tidak ada dokumen yang mengandung kata pada setiap query";
            }
            else
            {
                string[] idTerm = getID_Term(getQuery());
                Console.WriteLine("ini idTermnya");
                string[] idDocTerlibat = getID_Doc(idTerm);
                List<double> tempPembilang = new List<double>();
                List<double> tempPenyebut = new List<double>();
                List<double> ListpanjangQuery = new List<double>();
                for (int i = 0; i < queryArray.Length; i++)
                {
                    double TF_IDF_Query = Convert.ToDouble(cekKetersediaan_Term(queryArray[i]));
                    hasil_TF_IDF_Query = count_TF_IDF_Query(TF_IDF_Query, Convert.ToDouble(frekuensiArray[i]));
                    Console.WriteLine("kata '" + queryArray[i] + "' pd query muncul " + frekuensiArray[i] + " kali & hasil TF-IDFnya: " + hasil_TF_IDF_Query);
                    semuaTF_IDFQuery.Add(Math.Round(Math.Pow(hasil_TF_IDF_Query, 2), 5));//panjang query
                    semuaTF_IDFQuery_toPembilang.Add(hasil_TF_IDF_Query);
                }
                arrayQuery_TF_IDF = semuaTF_IDFQuery.ToArray();
                arrayQuery_TF_IDF_toPembilang = semuaTF_IDFQuery_toPembilang.ToArray();
                Console.WriteLine("Dokument Yang Terlibat Pada Query Ada " + idDocTerlibat.Length + ", yaitu: ");
                Console.WriteLine("");
                for (int fer = 0; fer < idDocTerlibat.Length; fer++)
                {
                    double temp_TF_IDF_doc_toQuery = 0;
                    double temp_TF_IDF_doc_toQuery_penyebut = 0;
                    //hitung pembilang
                    for (int ry = 0; ry < idTerm.Length; ry++)
                    {
                        temp_TF_IDF_doc_toQuery = cariTF_IDF(idDocTerlibat[fer], idTerm[ry]);
                        Console.WriteLine(idDocTerlibat[fer] + ", " + idTerm[ry] + " : " + temp_TF_IDF_doc_toQuery);
                        tempPembilang.Add(temp_TF_IDF_doc_toQuery * arrayQuery_TF_IDF_toPembilang[ry]);
                    }
                    hasilPembilangPER_doc = tempPembilang.Sum();
                    tempPembilang.Clear();
                    //hitung penyebut atu panjang vector
                    for (int wr = 0; wr < idTerm.Length; wr++)
                    {
                        //hitung panjang vector doc
                        temp_TF_IDF_doc_toQuery_penyebut = cariTF_IDF(idDocTerlibat[fer], idTerm[wr]);
                        tempPenyebut.Add(Math.Round(Math.Pow(temp_TF_IDF_doc_toQuery_penyebut, 2), 5));
                    }
                    double[] akhirPenyebut = tempPenyebut.ToArray();
                    tempPenyebut.Clear();
                    //hitung panjang vector query
                    double akhirPanjangQuery = Math.Round(Math.Sqrt(arrayQuery_TF_IDF.Sum()), 5);
                    hasilPenyebutPER_doc = Math.Round(Math.Sqrt(akhirPenyebut.Sum()), 5);//menentukan panjang vector doc
                    Console.WriteLine("Panjang Q = " + akhirPanjangQuery);
                    Console.WriteLine("hasil total pembilang id Doc " + idDocTerlibat[fer] + " = " + hasilPembilangPER_doc);
                    Console.WriteLine("hasil total penyebut id Doc  " + idDocTerlibat[fer] + " = " + hasilPenyebutPER_doc);
                    double hasilSimilarity = Math.Round(hasilPembilangPER_doc / (akhirPanjangQuery * hasilPenyebutPER_doc), 5);
                    Console.WriteLine("Similarity Doc id " + idDocTerlibat[fer] + " dengan Query = " + hasilSimilarity);
                    Console.WriteLine("=====================================>>>.................");
                    Console.WriteLine("");
                    semuaTF_IDFQuery.Clear();
                    if (hasilSimilarity >= 0.8)
                    {
                        if (!ListHasil_Akhir.Contains(idDocTerlibat[fer]))
                        {
                            ListHasil_Akhir.Add(idDocTerlibat[fer]);
                        }
                    }
                    arrayHasil_Akhir = ListHasil_Akhir.ToArray();
                    for (int ferry = 0; ferry < arrayHasil_Akhir.Length; ferry++)
                    {
                        if (idDocTerlibat.Length - 1 == fer)
                        {
                            Console.WriteLine("Id Doc yang masuk :");
                            Console.WriteLine(arrayHasil_Akhir[ferry]);
                        }
                    }
                }
            }
        }
        public bool getStatus_Search()
        {
            bool status = false;
            if (queryArray.Length != 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        public string[] getDoc()
        {
            return arrayHasil_Akhir;
        }
        public string[] getdateDoc_akhir()
        {
            arrayHasilDate = getDate_Doc(getDoc());
            return arrayHasilDate;
        }
        public string[] getDatePure()
        {
            return arrayHasilDatePure = getDate_PURE(getDoc());
        }
    }
}