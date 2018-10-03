<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard[Site_Admin].aspx.cs" Inherits="Site_Final_Mining.Dashboard_Site_Admin_" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>MiningSite_Timeframe | Admin</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <!-- Bootstrap 3.3.7 -->
    <link href="admin-lte/css_sideBar/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="Content/font-awesome.min.css">
    <!-- Ionicons -->
    <link href="Ionicons/css/ionicons.min.css" rel="stylesheet" />
    <link href="admin-lte/css/skins/_all-skins.min.css" rel="stylesheet" />
    <link href="Content/jquery-jvectormap.css" rel="stylesheet" />
    <link href="Content/morris.css" rel="stylesheet" />
    <link href="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css" rel="stylesheet" />
    <link href="Content/bootstrap3-wysihtml5.min.css" rel="stylesheet" />
    <!-- Theme style -->
    <link href="admin-lte/css/AdminLTE.css" rel="stylesheet" />
    <script src="Scripts/morris.min.js"></script>
    <link href="Ionicons/css/ionicons.min.css" rel="stylesheet" />
    <!-- AdminLTE Skins. Choose a skin from the css/skins
         folder instead of downloading all of them to reduce the load. -->
    <link href="admin-lte/css/skins/_all-skins.min.css" rel="stylesheet" />
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition skin-blue fixed sidebar-mini">
    <form runat="server" id="MemberHome">
        <!-- Site wrapper -->
        <div class="wrapper">
            <header class="main-header">
                <!-- Logo -->
                <a href="../../index2.html" class="logo">
                    <!-- mini logo for sidebar mini 50x50 pixels -->
                    <span class="logo-mini"><b>A</b>DM</span>
                    <!-- logo for regular state and mobile devices -->
                    <span class="logo-lg"><b>Admin</b>Here</span>
                </a>
                <!-- Header Navbar: style can be found in header.less -->
                <nav class="navbar navbar-static-top">
                    <!-- Sidebar toggle button-->
                    <a href="#" class="sidebar-toggle" data-toggle="push-menu" role="button">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </a>
                    <div class="navbar-custom-menu">
                        <ul class="nav navbar-nav">
                            <!-- Messages: style can be found in dropdown.less-->
                            <li class="dropdown messages-menu">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <i class="fa fa-envelope-o"></i>
                                    <span class="label label-success">4</span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li class="header">You have 4 messages</li>
                                    <li>
                                        <!-- inner menu: contains the actual data -->
                                        <ul class="menu">
                                            <li>
                                                <!-- start message -->
                                                <a href="#">
                                                    <div class="pull-left">
                                                        <img src="admin-lte/img/lul.jpg" class="img-circle" alt="User Image" />
                                                    </div>
                                                    <h4>Support Team
                        <small><i class="fa fa-clock-o"></i>5 mins</small>
                                                    </h4>
                                                    <p>Why not buy a new awesome theme?</p>
                                                </a>
                                            </li>
                                            <!-- end message -->
                                        </ul>
                                    </li>
                                    <li class="footer"><a href="#">See All Messages</a></li>
                                </ul>
                            </li>
                            <!-- Notifications: style can be found in dropdown.less -->
                            <li class="dropdown notifications-menu">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <i class="fa fa-bell-o"></i>
                                    <span class="label label-warning">10</span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li class="header">You have 10 notifications</li>
                                    <li>
                                        <!-- inner menu: contains the actual data -->
                                        <ul class="menu">
                                            <li>
                                                <a href="#">
                                                    <i class="fa fa-users text-aqua"></i>5 new members joined today
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li class="footer"><a href="#">View all</a></li>
                                </ul>
                            </li>
                            <!-- Tasks: style can be found in dropdown.less -->
                            <li class="dropdown tasks-menu">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <i class="fa fa-flag-o"></i>
                                    <span class="label label-danger">9</span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li class="header">You have 9 tasks</li>
                                    <li>
                                        <!-- inner menu: contains the actual data -->
                                        <ul class="menu">
                                            <li>
                                                <!-- Task item -->
                                                <a href="#">
                                                    <h3>Design some buttons
                        <small class="pull-right">20%</small>
                                                    </h3>
                                                    <div class="progress xs">
                                                        <div class="progress-bar progress-bar-aqua" style="width: 20%" role="progressbar" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                                                            <span class="sr-only">20% Complete</span>
                                                        </div>
                                                    </div>
                                                </a>
                                            </li>
                                            <!-- end task item -->
                                        </ul>
                                    </li>
                                    <li class="footer">
                                        <a href="#">View all tasks</a>
                                    </li>
                                </ul>
                            </li>
                            <!-- User Account: style can be found in dropdown.less -->
                            <li class="dropdown user user-menu">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <img src="admin-lte/img/lul.jpg" class="user-image" alt="User Image">
                                    <span class="hidden-xs">Ferry Wiranto</span>
                                </a>
                                <ul class="dropdown-menu">
                                    <!-- User image -->
                                    <li class="user-header">
                                        <img src="admin-lte/img/lul.jpg" class="img-circle" alt="User Image">
                                        <p>
                                            Ferry Wiranto - Web Developer
                  <small>Admin since Nov. 2012</small>
                                        </p>
                                    </li>
                                    <!-- Menu Body -->
                                    <!-- Menu Footer-->
                                    <li class="user-footer">
                                        <div class="pull-left">
                                            <asp:Button ID="Button1" Text="Profile" CssClass="btn btn-primary" runat="server" />
                                        </div>
                                        <div class="pull-right">
                                            <asp:Button ID="btnKeluar_dashAdmin" Text="Sign out" CssClass="btn btn-danger" runat="server" OnClick="keluarClick" />
                                        </div>
                                    </li>
                                </ul>
                            </li>
                            <!-- Control Sidebar Toggle Button -->
                        </ul>
                    </div>
                </nav>
            </header>

            <!-- =============================================== -->

            <!-- Left side column. contains the sidebar -->
            <aside class="main-sidebar">
                <!-- sidebar: style can be found in sidebar.less -->
                <section class="sidebar">
                    <!-- Sidebar user panel -->
                    <div class="user-panel">
                        <div class="pull-left image">
                            <img src="admin-lte/img/lul.jpg" class="img-circle" alt="User Image">
                        </div>
                        <div class="pull-left info">
                            <p>Ferry Wiranto, S Kom</p>
                            <a href="#"><i class="fa fa-circle text-success"></i>Online</a>
                        </div>
                    </div>
                    <!-- search form -->
                    <!-- sidebar menu: : style can be found in sidebar.less -->
                    <ul class="sidebar-menu" data-widget="tree">
                        <li class="header">MENU UTAMA</li>
                        <li class="treeview active" id="menu_dashboard" runat="server">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="dashBoard_click">
                                <i class="fa fa-dashboard"></i><span>Dashboard</span>
                            </asp:LinkButton>
                        </li>
                        <li class="treeview" id="menu_kategori_berita" runat="server">
                            <a href="#">
                                <i class="fa fa-paper-plane"></i>
                                <span>Kategori Berita</span>
                                <span class="pull-right-container">
                                    <span class="label label-primary pull-right">6</span>
                                </span>
                            </a>
                            <ul class="treeview-menu">
                                <li id="kategori_berita_olahraga" runat="server" class="">
                                    <asp:LinkButton ID="olahraga" runat="server" OnClick="olahraga_Click">
                                    <i class="fa fa-genderless"></i>Olahraga
                                    </asp:LinkButton>
                                </li>
                                <li id="kategori_berita_pemerintahan" runat="server" class="">
                                    <asp:LinkButton ID="pemerintahan" runat="server" OnClick="pemerintahan_Click">
                                    <i class="fa fa-genderless"></i>Pemerintahan
                                    </asp:LinkButton>
                                </li>
                                <li id="kategori_berita_kejahatan" runat="server" class="">
                                    <asp:LinkButton ID="kejahatan" runat="server" OnClick="kejahatan_Click">
                                    <i class="fa fa-genderless"></i>Kejahatan
                                    </asp:LinkButton>
                                </li>
                                <li id="kategori_berita_kecelakaan" runat="server" class="">
                                    <asp:LinkButton ID="kecelakaan" runat="server" OnClick="kecelakaan_Click">
                                    <i class="fa fa-genderless"></i>Kecelakaan
                                    </asp:LinkButton>
                                </li>
                                <li id="kategori_berita_bencana_alam" runat="server" class="">
                                    <asp:LinkButton ID="bencana_alam" runat="server" OnClick="bencana_Click">
                                <i class="fa fa-genderless"></i>Bencana Alam
                                    </asp:LinkButton>
                                </li>
                                <li id="kategori_berita_lain_lainnya" runat="server" class="">
                                    <asp:LinkButton ID="lain_lainnya" runat="server" OnClick="lainnya_Click">
                                    <i class="fa fa-genderless"></i>Lain-lain..
                                    </asp:LinkButton>
                                </li>
                            </ul>
                        </li>
                        <li id="menu_all_konten_berita" runat="server">
                            <asp:LinkButton ID="allBerita" runat="server" OnClick="allBerita_Click">
                                <i class="fa fa-book" runat="server"></i><span>Semua Konten Berita</span>
                            <span class="pull-right-container">
                                <small class="label pull-right bg-green">news</small>
                            </span>
                            </asp:LinkButton>
                        </li>
                        <li id="menu_calender" runat="server">
                            <a href="#">
                                <i class="fa fa-calendar"></i><span>Feed Activity</span>
                                <span class="pull-right-container">
                                    <small class="label pull-right bg-red">3</small>
                                    <small class="label pull-right bg-blue">17</small>
                                </span>
                            </a>
                        </li>
                        <li class="treeview" id="statistic_berita" runat="server">
                            <a href="#">
                                <i class="fa fa-area-chart"></i><span>Statistic Kategori Berita</span>
                                <span class="pull-right-container">
                                    <i class="fa fa-angle-left pull-right"></i>
                                </span>
                            </a>
                            <ul class="treeview-menu">
                                <li><a href="#"><i class="fa fa-caret-right"></i>Olahraga</a></li>
                                <li><a href="#"><i class="fa fa-caret-right"></i>Politik</a></li>
                                <li><a href="#"><i class="fa fa-caret-right"></i>Kejahatan</a></li>
                                <li><a href="#"><i class="fa fa-caret-right"></i>Kecelakaan</a></li>
                                <li><a href="#"><i class="fa fa-caret-right"></i>Bencana Alam</a></li>
                                <li><a href="#"><i class="fa fa-caret-right"></i>Lain-lain..</a></li>
                            </ul>
                        </li>
                        <li>
                            <li class="header">Timeframe Berita</li>
                            <li class="treeview" id="timeFrameBerita" runat="server">
                                <a href="#">
                                    <i class="fa fa-pie-chart"></i><span>Konten Berita</span>
                                    <span class="pull-right-container">
                                        <i class="fa fa-angle-left pull-right"></i>
                                    </span>
                                </a>
                                <ul class="treeview-menu">
                                    <li><a href="#"><i class="fa fa-caret-right"></i>Olahraga</a></li>
                                    <li><a href="#"><i class="fa fa-caret-right"></i>Politik</a></li>
                                    <li><a href="#"><i class="fa fa-caret-right"></i>Kejahatan</a></li>
                                    <li><a href="#"><i class="fa fa-caret-right"></i>Kecelakaan</a></li>
                                    <li><a href="#"><i class="fa fa-caret-right"></i>Bencana Alam</a></li>
                                    <li><a href="#"><i class="fa fa-caret-right"></i>Lain-lain..</a></li>
                                </ul>
                            </li>
                        </li>
                        <li class="treeview" id="Li1" runat="server">
                            <asp:LinkButton ID="LinkButton2" runat="server">
                                <i class="fa fa-dashboard"></i><span>Management Konten</span>
                            </asp:LinkButton>
                        </li>

                    </ul>
                </section>
                <!-- /.sidebar -->
            </aside>
        </div>
        <!-- =============================================== -->

        <!-- Content Wrapper. Contains page content -->
        <div class="content-wrapper">
            <asp:PlaceHolder ID="Content_Admin" runat="server" EnableViewState="false"></asp:PlaceHolder>
        </div>
        <!-- /.content-wrapper -->

        <footer class="main-footer">
            <div class="pull-right hidden-xs">
                <b>Version</b> 1.0.0-<b>FR</b>
            </div>
            <strong>Copyright &copy; 2018-2019 <a href="#">Ferry Wiranto</a>.</strong> All rights
    reserved.
        </footer>

        <script src="Scripts/js_sidebar/jquery/dist/jquery.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
        <script src="admin-lte/js/demo.js"></script>
        <script src="admin-lte/js/adminlte.min2.js"></script>
        <script src="admin-lte/js/fastclick.js"></script>
        <script src="admin-lte/js/jquery.slimscroll.min.js"></script>
      
    </form>
</body>
</html>
