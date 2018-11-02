using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;


namespace Site_Final_Mining
{
    public partial class Register_Enjoy_Here_ : System.Web.UI.Page
    {
        private connectionClass con;

        protected void Page_Load(object sender, EventArgs e)
        {
            
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
        protected void submit_Clik(object sender, EventArgs e)
        {
            string[] getphoto_profil = this.getFile(photo_profil);
            if (!email.Value.Equals(""))
            {
                if (cekEmail_db(email.Value) == false)
                {
                    if (!password.Value.Equals(""))
                    {
                        photo_profil.PostedFile.SaveAs(getphoto_profil[0]);
                        this.con = new connectionClass();
                        string query = "INSERT INTO public.user_register(nama, email, password, jenis_kelamin, agama, \"statusDaftar\", \"userStatus\", \"pathPhoto\", alamat , \"alasanBergabung\" ,pekerjaan)" +
                            " VALUES ('" + nama.Value + "', '" + email.Value + "', '" + password.Value + "', '" + getChecked(1) + "', '" + agama.Value + "'," + "1, '"
                            + getChecked(2) + "', '" + getphoto_profil[1] + "', '" + alamat.Value + "' , '" + alasan.Value + "' , '" + pekerjaan.Value + "')";

                        this.con.excequteQuery(query);
                        alertRegister.Attributes["class"] = "alert alert-info";
                        pesanGagal.Text = "<strong>Pendaftaran Sukses!</strong> Akun anda akan segera diverifikasi oleh admin";
                        alertRegister.Style.Add("background-color", "#d9edf7 !important");
                        alertRegister.Style.Add("border-color", "#bce8f1 !important");
                        alertRegister.Style.Add("color", "#004085 !important");
                        btnClose.Style.Add("color", "blue !important");
                    }
                    else
                    {

                    }
                }
                else
                {
                    alertRegister.Attributes["class"] = "alert alert-danger";
                    pesanGagal.Text = "<strong>Pendaftaran Gagal!</strong> Email yang Anda Masukkan Telah Digunakan, Silahkan Masukkan Email Lain!!";
                    alertRegister.Style.Add("background-color", "#f2dede !important");
                    alertRegister.Style.Add("border-color", "#ebccd1 !important");
                    alertRegister.Style.Add("color", "#a94442 !important");
                    btnClose.Style.Add("color", "red !important");
                }
            }
            else
            {

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

        protected void kembali_click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome_to[Site_Mining].aspx");
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

        static async Task Execute(string target)
        {
            var apiKey = Environment.GetEnvironmentVariable("SG.znkeJDT6T0WdfMzz90x8Cg.D8SFNztMHX_IqdQER - L7Y_hFUbd08xKGhIZqiZfDa1E");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("ferrywr25@gmail.com", "");
            var subject = "Semangat Skripsi";
            var to = new EmailAddress(target, "");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere Skripsi, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
       
    }
    
}
