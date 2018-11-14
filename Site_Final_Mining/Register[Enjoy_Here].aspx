<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register[Enjoy_Here].aspx.cs" Inherits="Site_Final_Mining.Register_Enjoy_Here_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>MiningSite_Timeframe | Register</title>
    <!-- Tell the browser to be responsive to screen width -->
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link href="Ionicons/css/ionicons.min.css" rel="stylesheet" />
    <link href="admin-lte/css/AdminLTE.min.css" rel="stylesheet" />
    <link href="admin-lte/css/skins/_all-skins.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrapAlert.min.js"></script>
</head>
<body style="background-color: #ecf0f5">
    <form id="form1" runat="server">
        <div class="row">
            <section class="content">
                <!-- Info boxes -->
                <div class="row" style="margin: auto;">
                    <div class="col-md-11">
                        <div class="box box-success" style="background-color: #ecf0f5">
                            <br />
                            <div class="box-body">
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="box box-primary bg-white">
                                            <div class="box-header">
                                                <asp:Image ID="imageProfile" CssClass="profile-user-img img-responsive img-circle" ImageUrl="~/admin-lte/img/regis.png" runat="server" />
                                                <h3 class="profile-username text-center"><i class="fa fa-expeditedssl"></i>&nbsp;Informasi Akun</h3>
                                                <p class="text-muted text-center">Already to a member ?</p>
                                            </div>
                                            <div class="box-body">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <div class="form-group">
                                                            <label>E-Mail</label>
                                                            <div class="input-group">
                                                                <div class="input-group-addon">
                                                                    <i class="fa fa-envelope"></i>
                                                                </div>
                                                                <input type="email" class="form-control"
                                                                    placeholder="Masukkan Alamat E-mail" runat="server" id="email" required />
                                                            </div>
                                                        </div>
                                                        <div class="form-group">
                                                            <label>Password</label>
                                                            <div class="input-group">
                                                                <div class="input-group-addon">
                                                                    <i class="fa fa-lock"></i>
                                                                </div>
                                                                <input type="password" class="form-control"
                                                                    placeholder="Masukkan Password" runat="server" id="password" required>
                                                            </div>
                                                        </div>
                                                        <div class="form-group">
                                                            <label for="photo_profil">Foto Profil</label>
                                                            <asp:FileUpload ID="photo_profil" runat="server" required="true" />
                                                            <p class="help-block">
                                                                Unggah Foto sebagai Foto Profil Akun (Jpg/Jpeg).
                                                            </p>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Nama</label>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    <i class="fa fa-user"></i>
                                                </div>
                                                <input type="text" class="form-control" placeholder="Masukkan Nama Lengkap" runat="server" id="nama" required>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label>Tanggal Lahir</label>
                                            <div class="input-group date">
                                                <div class="input-group-addon">
                                                    <i class="fa fa-calendar"></i>
                                                </div>
                                                <asp:TextBox ID="tgl_lahir" runat="server" CssClass="form-control" placeholder="Masukkan Tanggal Lahir" ClientIDMode="Static" ReadOnly="true" required="true"></asp:TextBox>
                                            </div>
                                            <p class="help-block">
                                                Minimal Hari Ini Anda Sudah Berusia 17 tahun.
                                            </p>
                                        </div>
                                        <div class="form-group">
                                            <label>Jenis Kelamin</label>
                                            <div class="input-group">
                                                <div class="radio" id="chekedKelamin" runat="server" style="margin: 0px !important;">
                                                    <label>
                                                        <input type="radio" name="optionsRadios" checked runat="server" id="laki">
                                                        Laki-Laki &nbsp;
                                                    </label>
                                                    <label>
                                                        <input type="radio" name="optionsRadios" runat="server" id="perempuan">
                                                        Perempuan
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label>Alamat</label>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    <i class="fa fa-address-book"></i>
                                                </div>
                                                <textarea class="form-control" placeholder="Masukkan Alamat" runat="server" required id="alamat"></textarea>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label>Alasan Ingin Bergabung</label>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    <i class="fa fa-thumbs-up"></i>
                                                </div>
                                                <textarea class="form-control" placeholder="Masukkan Alasan" runat="server" required id="alasan"></textarea>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Nomer Telepon</label>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    <i class="fa fa-phone"></i>
                                                </div>
                                                <input type="number" class="form-control" placeholder="Masukkan Nomor Telepon" runat="server" required id="nomor_tlp">
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label>Agama</label>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    <i class="fa fa-star"></i>
                                                </div>
                                                <select class="form-control" runat="server" required id="agama">
                                                    <option value="Islam">Islam</option>
                                                    <option value="Kristen Katolik">Kristen Katolik</option>
                                                    <option value="Kristen Protestan">Kristen Protestan</option>
                                                    <option value="Hindu">Hindu</option>
                                                    <option value="Budha">Budha</option>
                                                    <option value="Konghucu">Konghucu</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label>Status Pengguna</label>
                                            <div class="input-group">
                                                <div class="radio" style="margin: 0px !important;">
                                                    <label>
                                                        <input type="radio" name="statusPerkawinan" checked runat="server" id="personal">
                                                        Personal
                                                    &nbsp;
                                                    </label>
                                                    <label>
                                                        <input type="radio" name="statusPerkawinan" runat="server" id="company">
                                                        Company
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label>Pekerjaan</label>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    <i class="fa fa-dollar"></i>
                                                </div>
                                                <input type="text" class="form-control" placeholder="Masukkan Pekerjaan" runat="server" required id="pekerjaan">
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="checkbox-inline">
                                                <input type="checkbox" value="true" required>I agree to the terms and conditions
                                            </label>
                                        </div>
                                    </div>
                                </div>

                                <div class="alert alert-danger fade" runat="server" id="alertRegister" role="alert">
                                    <button type="button" class="close" id="btnClose" data-dismiss="alert" aria-label="Close" runat="server">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                    <asp:Label ID="pesanGagal" runat="server"></asp:Label>
                                </div>
                            </div>
                            <div class="box-footer" style="background-color: #ecf0f5">
                                <div class="pull-right">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-success" type="submit" OnClick="submit_Clik" />
                                </div>
                                <div class="pull-left">
                                    <asp:Button ID="btnKembali" runat="server" Text="Kembali" CssClass="btn btn-danger" type="button" OnClick="kembali_click" />
                                </div>
                            </div>
                            <!-- /.box-body -->
                        </div>
                        <!-- /.box -->
                    </div>
                </div>
            </section>
        </div>
    </form>
</body>

</html>
