<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pendaftaran[Welcome_Here].aspx.cs" Inherits="Site_Final_Mining.Pendaftaran_Welcome_Here_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MiningSite_Timeframe | Register</title>
    <!-- Tell the browser to be responsive to screen width -->
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:300,400,700" rel="stylesheet" type="text/css">
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="Content/ccs_register/templatemo_style.css" rel="stylesheet" />
</head>
<body class="templatemo-bg-image-2">
    <div class="container">
        <div class="col-md-12">
            <form class="form-horizontal templatemo-contact-form-1" runat="server">
                <div class="form-group">
                    <div class="col-md-12">
                        <h1 class="margin-bottom-15">Form Pendaftaran</h1>
                        <p>
                            Silahkan lengkapi form dibawah ini, baca lebih lanjut terkait
						persyaratan yang diminta, selamat bergabung dengan kami !!
                        </p>

                        <p style="color: yellow">
                            Verifikasi akun anda akan melalui email, pastikan email
						yang anda masukkan sudah benar !!
                        </p>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <label for="name" class="control-label">Nama Pengguna *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-user"></i>
                            <input type="text" id="nama" runat="server" class="form-control" required />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="website" class="control-label">Password Akun *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-unlock-alt"></i>
                            <input type="password" class="form-control" id="password" runat="server" required />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="email" class="control-label">Email *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-envelope-o"></i>
                            <input type="email" class="form-control" id="email" runat="server" required />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="subject" class="control-label">Pekerjaan *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-suitcase" aria-hidden="true"></i>
                            <input type="text" class="form-control" id="pekerjaan" runat="server" required />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="subject" class="control-label">Alamat *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-suitcase" aria-hidden="true"></i>
                            <input type="text" class="form-control" id="alamat" runat="server" required />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="message" class="control-label">Jenis Kelamin *</label>
                        <br>
                        <input type="radio" id="laki" runat="server">
                        Laki-laki &nbsp; &nbsp;
					<input type="radio" id="perempuan" runat="server">
                        Perempuan<br>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="subject" class="control-label">Agama *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-money"></i>
                            <select class="form-control" style="height: 45px;" id="agama" runat="server" required>
                                <option value="Islam">Islam</option>
                                <option value="Kristen Protestan">Kristen Protestan</option>
                                <option value="Kristen Katolik">Katolik</option>
                                <option value="Hindu">Hindu</option>
                                <option value="Budha">Budha</option>
                                <option value="Conghucu">Conghucu</option>
                            </select>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="message" class="control-label">Status Pendaftar *</label>
                        <br />
                        <input type="radio" id="personal" runat="server" />
                        Personal &nbsp; &nbsp;
					<input type="radio" id="company" runat="server" />
                        Company<br />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="message" class="control-label">Alasan Bergabung *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-pencil-square-o"></i>
                            <textarea rows="8" cols="50" id="alasan" runat="server" class="form-control" required></textarea>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="message" class="control-label">Upload Photo *</label>
                        <asp:FileUpload ID="photo_profil" runat="server" />
                    </div>
                </div>
                <asp:Label ID="labelNotifikasi" CssClas="hidden"  runat="server" ForeColor="Red"></asp:Label>
                <br/>
                <br/>
                <div class="form-group">
                    <div class="col-md-12">
                         <asp:LinkButton ID="kembali" runat="server" CssClass="btn btn-warning" Font-Underline="false" OnClick="kembali_click">kembali_click</asp:LinkButton>
                        <asp:LinkButton ID="daftar" runat="server" CssClass="btn btn-success" Font-Underline="false" OnClick="submit_click">Kirim form biodata</asp:LinkButton>
                       
                    </div>
                </div>

            </form>
        </div>
    </div>
</body>
</html>
