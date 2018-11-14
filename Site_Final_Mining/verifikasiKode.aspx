<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verifikasiKode.aspx.cs" Inherits="Site_Final_Mining.verifikasiKode" %>

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
    <br/>
    <br/>
    <br/>
    <div class="container">
        <div class="col-md-12">
            <form class="form-horizontal templatemo-contact-form-1" runat="server">
                <div class="form-group">
                    <div class="col-md-12">
                        <h1 class="margin-bottom-15">Form Verifikasi Kode Email</h1>
                        <p style="color: yellow">
                            Silahkan periksa email anda, kami sudah mengirimkan kode pendaftaran 
                        pada alamat email [<asp:Label ID="labelEmail" runat="server" ></asp:Label>] !!!
                        </p>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <label for="subject" class="control-label" style="color: yellow">
                            Biodata Berhasil dimasukkan,
                                 selanjutnya silahkan masukkan !!
                        </label>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <br />
                        <label for="subject" class="control-label">Kode Verifikasi Email *</label>
                        <div class="templatemo-input-icon-container">
                            <i class="fa fa-code-fork" aria-hidden="true"></i>
                            <input type="number" id="kode" runat="server" class="form-control" required />
                        </div>
                    </div>
                </div>
                <asp:Label ID="labelNotifikasi" CssClas="hidden"  runat="server" ForeColor="Red"></asp:Label>
                <div class="form-group">
                    <div class="col-md-12">
                         <asp:LinkButton ID="sendVerifikasi" runat="server" CssClass="btn btn-success" Font-Underline="false" OnClick="verifikasi_click">Kirim Form Biodata</asp:LinkButton>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
