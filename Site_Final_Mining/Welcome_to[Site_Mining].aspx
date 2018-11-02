<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome_to[Site_Mining].aspx.cs" Inherits="Site_Final_Mining.Welcome_to_Site_Mining_" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>MiningSite_Timeframe | frontPage</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <!-- Bootstrap 3.3.7 -->
    <link href="Content/css_frontPage/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/css_frontPage/business-frontpage.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="Content/font-awesome.min.css" />
    <link href="Content/css_frontPage/footer-distributed-with-address-and-phones.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
            <div class="container">
                <a class="navbar-brand" href="#"><i class="fa fa-desktop" aria-hidden="true"></i>&nbsp;&nbsp;Welcome to Monitoring Site News Content</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ml-auto" runat="server">
                        <li class="nav-item active" id="menuHome" runat="server">
                            <asp:LinkButton CssClass="nav-link" ID="homeKlik" OnClick="home_Click" runat="server">
                      Home</asp:LinkButton>
                        </li>
                        <li class="nav-item" id="menuKlasifikasi" runat="server">
                            <asp:LinkButton CssClass="nav-link" ID="klasfikasiKlik" OnClick="klasifikasi_Click" runat="server">
                      Klasifikasi</asp:LinkButton>
                        </li>
                        <li class="nav-item" id="menuIR" runat="server">
                            <asp:LinkButton CssClass="nav-link" ID="IRKlik" OnClick="IR_Click" runat="server">
                      IR</asp:LinkButton>
                        </li>
                        <li class="nav-item" id="menuVSM" runat="server">
                            <asp:LinkButton CssClass="nav-link" ID="vsmKlik" OnClick="VSM_Click" runat="server">
                      VSM</asp:LinkButton>
                        </li>
                        <li class="nav-item" id="Li1" runat="server">
                            <asp:LinkButton CssClass="nav-link" ID="registerKlik" OnClick="register_Click" runat="server">
                      Daftar</asp:LinkButton>
                        </li>
                        <li class="nav-item" id="menuLogin" runat="server">
                            <asp:LinkButton CssClass="nav-link" ID="loginKlik" OnClick="loginClick" runat="server">
                      Login</asp:LinkButton>
                        </li>

                    </ul>
                </div>
            </div>
        </nav>

        <!-- Header with Background Image -->
        <header class="business-header">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="display-3 text-center text-white mt-5">Temukan Informasi yang Anda Perlukan !!!</h1>
                    </div>
                </div>
            </div>
        </header>

        <!-- Page Content -->
        <div class="container">
            <asp:PlaceHolder ID="Content_Guest" runat="server" EnableViewState="false"></asp:PlaceHolder>
        </div>
        <!-- /.container -->

        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">
                    Copyright &copy; Ferry Wiranto 2019 
                    <br />
                    Jember University
                </p>
            </div>
            <!-- /.container -->
        </footer>
        <!-- Footer section end -->
        <!--====== Javascripts & Jquery ======-->
        <script src="Scripts/js_frontPage/bootstrap.bundle.min.js"></script>
        <script src="Scripts/js_frontPage/jquery.min.js"></script>
    </form>
</body>
</html>

