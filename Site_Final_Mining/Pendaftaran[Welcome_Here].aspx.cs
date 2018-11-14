using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;
using System.IO;
using System.Threading;
using EASendMail;

namespace Site_Final_Mining
{
    public partial class Pendaftaran_Welcome_Here_ : System.Web.UI.Page
    {
        private connectionClass con;
        int kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            kode = GenerateRandomKode();
        }
        protected void kembali_click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome_to[Site_Mining].aspx");
        }
        private Boolean cekEmail_db(string email)
        {
            this.con = new connectionClass();
            DataTable result = this.con.getResult("SELECT * FROM public.user_register WHERE email = '" + email + "';");
            if (result.Rows.Count > 0)
                return true;
            else
                return false;
        }
        protected void submit_click(object sender, EventArgs e)
        {
            string[] getphoto_profil = this.getFile(photo_profil);
            if (!nama.Value.Equals(""))
            {
                if (!password.Value.Equals(""))
                {
                    if (!pekerjaan.Value.Equals(""))
                    {
                        if (!alamat.Value.Equals(""))
                        {
                            if (!alasan.Value.Equals(""))
                            {
                                if (!email.Value.Equals(""))
                                {
                                    if (EmailValidate(email.Value))
                                    {
                                        if (!getphoto_profil[1].Equals("kosong"))
                                        {
                                            if (!getphoto_profil[1].Contains("Not Allowed"))
                                            {
                                                if (cekEmail_db(email.Value) == false)
                                                {
                                                    if (!password.Value.Equals(""))
                                                    {
                                                        Session["EmailPendaftar"] = email.Value;
                                                        labelNotifikasi.Attributes["CssClas"] = "";
                                                        labelNotifikasi.Text = "Formulir berhasil dimasukkan!!";
                                                        Thread.Sleep(3000);
                                                        photo_profil.PostedFile.SaveAs(getphoto_profil[0]);
                                                        this.con = new connectionClass();
                                                        if (sendMail(email.Value) == true)
                                                        {
                                                            string query = "INSERT INTO public.user_register(nama, email, password, jenis_kelamin, agama, \"statusDaftar\", \"userStatus\", \"pathPhoto\", alamat , \"alasanBergabung\" ,pekerjaan ,\"kodeReg\")" +
                                                           " VALUES ('" + nama.Value + "', '" + email.Value + "', '" + password.Value + "', '" + getChecked(1) + "', '" + agama.Value + "'," + "1, '"
                                                           + getChecked(2) + "', '" + getphoto_profil[1] + "', '" + alamat.Value + "' , '" + alasan.Value + "' , '" + pekerjaan.Value + "' , '" + kode + "')";
                                                            this.con.excequteQuery(query);
                                                            Response.Redirect("verifikasiKode.aspx");
                                                        }
                                                        else
                                                        {
                                                            labelNotifikasi.Attributes["CssClas"] = "";
                                                            labelNotifikasi.Text = "Gagal Mengirimkan kode email";
                                                        }

                                                    }
                                                    else
                                                    {
                                                        labelNotifikasi.Attributes["CssClas"] = "";
                                                        labelNotifikasi.Text = "Silahkan lengkapi formulir tersebut!!";
                                                    }
                                                }
                                                else
                                                {
                                                    labelNotifikasi.Attributes["CssClas"] = "";
                                                    labelNotifikasi.Text = "Alamat email Tersebut sudah terdaftar, silahkan gunakan akun email lain!!";
                                                }
                                            }
                                            else
                                            {
                                                labelNotifikasi.Attributes["CssClas"] = "";
                                                labelNotifikasi.Text = "Format tidak mendukung, Gunakan Format jpg atau jpeg!!";
                                            }
                                        }
                                        else
                                        {
                                            labelNotifikasi.Attributes["CssClas"] = "";
                                            labelNotifikasi.Text = "Silahkan masukkan foto identitas anda terlebih dahulu!!";
                                        }
                                    }
                                    else
                                    {
                                        labelNotifikasi.Attributes["CssClas"] = "";
                                        labelNotifikasi.Text = "Format Email Anda tidak sesuai";
                                    }
                                }
                                else
                                {
                                    labelNotifikasi.Attributes["CssClas"] = "";
                                    labelNotifikasi.Text = "Silahkan lengkapi formulir tersebut!!";
                                }
                            }
                            else
                            {
                                labelNotifikasi.Attributes["CssClas"] = "";
                                labelNotifikasi.Text = "Silahkan lengkapi formulir tersebut!!";
                            }

                        }
                        else
                        {
                            labelNotifikasi.Attributes["CssClas"] = "";
                            labelNotifikasi.Text = "Silahkan lengkapi formulir tersebut!!";
                        }

                    }
                    else
                    {
                        labelNotifikasi.Attributes["CssClas"] = "";
                        labelNotifikasi.Text = "Silahkan lengkapi formulir tersebut!!";
                    }

                }
                else
                {
                    labelNotifikasi.Attributes["CssClas"] = "";
                    labelNotifikasi.Text = "Silahkan lengkapi formulir tersebut!!";
                }

            }
            else
            {
                labelNotifikasi.Attributes["CssClas"] = "";
                labelNotifikasi.Text = "Silahkan lengkapi formulir tersebut!!";
            }

        }
        public string getChecked(int perintah)
        {
            string data = null;
            if (perintah == 1)
            {
                if (laki.Checked)
                {
                    data = "laki-laki";
                }
                else
                {
                    data = "perempuan";
                }
            }
            else if (perintah == 2)
            {
                if (personal.Checked)
                {
                    data = "personal";
                }
                else
                {
                    data = "company";
                }
            }
            return data;
        }

        private string[] getFile(FileUpload upload)
        {
            string[] allowedExtension = { ".jpg", ".jpeg" };
            string[] img = new string[2];
            if (upload.HasFile)
            {
                string fileExtension = Path.GetExtension(upload.FileName).ToLower();
                img[1] = fileExtension + " Not Allowed !";
                for (int i = 0; i < allowedExtension.Length; i++)
                {
                    if (fileExtension == allowedExtension[i])
                    {
                        string filepath = Server.MapPath("/admin-lte/img/");
                        string fileName = nama.Value;
                        img[0] = filepath + fileName + fileExtension;
                        img[1] = fileName + fileExtension;
                    }
                }
            }
            else
            {
                img[1] = "kosong";
            }
            return img;
        }
        public int GenerateRandomKode()
        {
            int _min = 0000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private Boolean EmailValidate(string email)
        {
            if (email.Contains("@"))
                return true;
            else
                return false;
        }

        public bool sendMail(string email)
        {
            bool status = false;
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();
            oMail.From = "adminSite@mail.com";
            oMail.To = email;
            oMail.Subject = "Verifikasi Kode Pendaftaran Site monitoring";
            oMail.TextBody = "Ini kode Verifikasi pendaftaran site monitoring Anda <strong> Kode: " + kode + "</strong>";
            SmtpServer oserver = new SmtpServer("smtp.gmail.com");
            oserver.User = "ferrywr25@gmail.com";
            oserver.Password = "uzngllivqsqbvdst";
            oserver.Port = 465;
            oserver.ConnectType = SmtpConnectType.ConnectSSLAuto;
            try
            {
                oSmtp.SendMail(oserver, oMail);
                status = true;
            }
            catch (Exception fer)
            {
                Console.WriteLine(fer.Message);
                status = false;
            }
            return status;
        }
    }
}