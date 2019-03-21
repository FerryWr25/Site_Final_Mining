<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome[Here_AdminPanel].aspx.cs" Inherits="Site_Final_Mining.Welcome_Here_AdminPanel_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>siteMining | Admin</title>
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <link href="Other_component/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="Content/font-awesome.min.css" />
    <link href="Ionicons/css/ionicons.min.css" rel="stylesheet" />
    <link href="admin-lte/css/AdminLTE.min.css" rel="stylesheet" />
    <link href="admin-lte/css/skins/_all-skins.min.css" rel="stylesheet" />
    <!--chart -->
    <script src="chart/js/Chart.min.js"></script>
    <style>
        /* This element would be replaced by where you want the templates. */
        body {
            font-family: Arial,sans-serif;
            color: #292f33;
        }

        .tweetEntry-tweetHolder {
            border-left: 1px solid #e1e8ed;
            border-right: 1px solid #e1e8ed;
            border-top: 1px solid #e1e8ed;
            width: 1000px;
            margin: auto;
            border-radius: 5px;
        }

        /* The action list is optional. */
        .tweetEntry-action-list {
            display: block;
            line-height: 18px;
            margin-left: 58px;
            margin-top: 10px;
            color: #292f33;
        }

        .fa-reply:hover {
            color: #292f33;
        }

        .fa-thumbs-o-down:hover {
            color: blue;
        }

        .fa-heart:hover {
            color: #ff3333;
        }
        /************************/

        .tweetEntry {
            border-bottom: 1px solid #e1e8ed;
            cursor: pointer;
            min-height: 51px;
            padding: 9px 12px;
        }

        .tweetEntry-content {
            display: block;
            font-size: 14px;
            margin-left: 58px;
            font-size: 14px;
        }

        .tweetEntry-account-group {
            color: #8899a6;
            padding: 0px;
            text-decoration: none;
            line-height: 20px;
        }

        .tweetEntry-avatar {
            float: left;
            height: 48px;
            width: 48px;
            margin-left: -58px;
            border-radius: 5px;
        }

        .tweetEntry-fullname {
            font-weight: bold;
            font-size: 14px;
            color: #292f33;
            padding: 0px;
        }

        .tweetEntry-username {
            font-weight: bold;
            font-size: 14px;
            color: #b1bbc3;
            padding: 0px;
        }

        .tweetEntry-timestamp {
            font-size: 14px;
            color: #b1bbc3;
            padding: 0px;
        }

        .tweetEntry-text-container {
            font-size: 14px;
            color: #292f33;
            line-height: 18px;
        }

        .optionalMedia {
            margin-left: 58px;
            margin-top: 10px;
        }

        .optionalMedia-img {
            border-radius: 5px;
            max-width: 506px;
            max-height: 506px;
        }
    </style>
</head>
<body class="hold-transition skin-blue fixed sidebar-mini">
    <form runat="server">
        <!-- Site wrapper -->
        <div class="wrapper">
            <header class="main-header">
                <!-- Logo -->
                <a href="#" class="logo">
                    <!-- mini logo for sidebar mini 50x50 pixels -->
                    <span class="logo-mini"><b>A</b>DM</span>
                    <!-- logo for regular state and mobile devices -->
                    <span class="logo-lg"><b>Admin</b>Panel</span>
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
                                    <i class="fa fa-bell-o"></i>
                                    <span class="label label-warning">
                                       <i class="fa fa-arrow-circle-down" aria-hidden="true"></i></span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li class="header"><i class="fa fa-info-circle"></i>&nbsp; Member baru</li>
                                    <li>
                                        <!-- inner menu: contains the actual data -->
                                        <ul class="menu">
                                            <li>
                                                <!-- start message -->
                                                <a href="#">
                                                    <div class="pull-left">
                                                        <asp:Image ID="profileImage1" CssClass="img-circle" src="" runat="server" />
                                                    </div>
                                                    <h4>
                                                        <asp:Label ID="Nama1" runat="server"></asp:Label>
                                                        <small><i class="fa fa-clock-o"></i>
                                                            <asp:Label ID="tanggalDaftar1" runat="server"></asp:Label></small>
                                                    </h4>
                                                    <p>
                                                        <asp:Label ID="pekerjaan1" runat="server"></asp:Label>
                                                    </p>
                                                </a>

                                                <a href="#">
                                                    <div class="pull-left">
                                                        <asp:Image ID="profileImage2" CssClass="img-circle" src="" runat="server" />
                                                    </div>
                                                    <h4>
                                                        <asp:Label ID="Nama2" runat="server"></asp:Label>
                                                        <small><i class="fa fa-clock-o"></i>
                                                            <asp:Label ID="tanggalDaftar2" runat="server"></asp:Label></small>
                                                    </h4>
                                                    <p>
                                                        <asp:Label ID="pekerjaan2" runat="server"></asp:Label>
                                                    </p>
                                                </a>

                                                <a href="#">
                                                    <div class="pull-left">
                                                        <asp:Image ID="profileImage3" CssClass="img-circle" src="" runat="server" />
                                                    </div>
                                                    <h4>
                                                        <asp:Label ID="Nama3" runat="server"></asp:Label>
                                                        <small><i class="fa fa-clock-o"></i>
                                                            <asp:Label ID="tanggalDaftar3" runat="server"></asp:Label></small>
                                                    </h4>
                                                    <p>
                                                        <asp:Label ID="pekerjaan3" runat="server"></asp:Label>
                                                    </p>
                                                </a>
                                            </li>
                                            <!-- end message -->
                                        </ul>
                                    </li>
                                    <li class="footer">
                                        <asp:LinkButton ID="lihatSemua_member" OnClick="manageUser_Click" Text="Lihat Semua Member" runat="server"></asp:LinkButton></li>
                                </ul>
                            </li>
                            <!-- User Account: style can be found in dropdown.less -->
                            <li class="dropdown user user-menu">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <asp:Image ID="profileImage_dropdown" CssClass="user-image" src="" runat="server" />
                                    <span class="hidden-xs">
                                        <asp:Label ID="labelNama2" runat="server"></asp:Label></span>
                                </a>
                                <ul class="dropdown-menu">
                                    <!-- User image -->
                                    <li class="user-header">
                                        <asp:Image ID="profileSideBar" CssClass="img-circle" src="" runat="server" />
                                        <p>
                                            <asp:Label ID="labelNama3" runat="server"></asp:Label>
                                            - Admin-Site
                  <small>Enjoying Here</small>
                                        </p>
                                    </li>
                                    <!-- Menu Footer-->
                                    <li class="user-footer">
                                        <div class="pull-left">
                                            <asp:Button ID="btn_Profile_admin" Text="Profile" CssClass="btn btn-default btn-flat" runat="server" OnClick="profile_Click" />
                                        </div>
                                        <div class="pull-right">
                                            <asp:Button ID="btnKeluar_dashAdmin" Text="Sign out" CssClass="btn btn-default btn-flat" runat="server" OnClick="keluar_Click" />
                                        </div>
                                    </li>
                                </ul>
                            </li>
                            <!-- Control Sidebar Toggle Button -->
                            <li>
                                <a href="#" data-toggle="control-sidebar"><i class="fa fa-gears"></i></a>
                            </li>
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
                            <asp:Image ID="sidebarProfile" CssClass="img-circle" src="" runat="server" />
                        </div>
                        <div class="pull-left info">
                            <p>
                                <asp:Label ID="labelNama" runat="server"></asp:Label>
                            </p>
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
                                <span>Sumber Berita</span>
                                <span class="pull-right-container">
                                    <i class="fa fa-angle-left pull-right"></i>&nbsp; <span class="label label-primary pull-right">3</span>
                                </span>
                            </a>
                            <ul class="treeview-menu">
                                <li id="btn_tribunnews" runat="server" class="">
                                    <asp:LinkButton ID="olahraga" runat="server" OnClick="tribunnews_Click">
                                    <i class="fa fa-globe" aria-hidden="true"></i>Tribunnews.com
                                    </asp:LinkButton>
                                </li>
                                <li id="btn_detik" runat="server" class="">
                                    <asp:LinkButton ID="pemerintahan" runat="server" OnClick="detik_Click">
                                    <i class="fa fa-globe" aria-hidden="true"></i>Detik.com
                                    </asp:LinkButton>
                                </li>
                                <li id="btn_liputan6" runat="server" class="">
                                    <asp:LinkButton ID="kejahatan" runat="server" OnClick="liputan6_Click">
                                    <i class="fa fa-globe" aria-hidden="true"></i>Liputan6.com
                                    </asp:LinkButton>
                                </li>
                            </ul>
                        </li>
                        <li id="menu_calender" runat="server">
                            <asp:LinkButton ID="btnActivity" runat="server" OnClick="feedActivity_Click">
                                <i class="fa fa-calendar"></i><span>Feed Activity</span>
                                <span class="pull-right-container">
                                    <small class="label pull-right bg-red">3</small>
                                    <small class="label pull-right bg-blue">17</small>
                                </span>
                            </asp:LinkButton>
                        </li>
                        <li class="header">Search Enginee & Timeframe</li>
                        <li id="menu_all_konten_berita" runat="server">
                            <asp:LinkButton ID="allBerita" runat="server" OnClick="allBerita_Click">
                                <i class="fa fa-book" runat="server"></i><span>Semua Konten Berita</span>
                            <span class="pull-right-container">
                                <small class="label pull-right bg-green">news</small>
                            </span>
                            </asp:LinkButton>
                        </li>
                        <li class="header">Kelola Member</li>
                        <li id="pengguna" runat="server">
                            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="manageUser_Click">
                               <i class="fa fa-user-circle-o" aria-hidden="true"></i><span>Pengguna</span>
                            <span class="pull-right-container">
                                <small class="label pull-right bg-green"><i class="fa fa-address-card" aria-hidden="true"></i></small>
                            </span>
                            </asp:LinkButton>
                        </li>

                    </ul>
                </section>
                <!-- /.sidebar -->
            </aside>

            <!-- =============================================== -->

            <!-- Content Wrapper. Contains page content -->
            <div class="content-wrapper">
                <!-- Main content -->
                <section class="content">
                    <asp:PlaceHolder ID="Content_Admin" runat="server" EnableViewState="false"></asp:PlaceHolder>
                    <!-- /.box -->
                </section>
                <!-- /.content -->
            </div>
            <!-- /.content-wrapper -->

            <footer class="main-footer">
                <div class="pull-right hidden-xs">
                    <b>Version</b> 1.0.0
                </div>
                <strong>Copyright &copy; 2018-2019 <a href="https://adminlte.io">Ferry Wiranto</a>.</strong> All rights
    reserved.
            </footer>

            <!-- Control Sidebar -->
            <aside class="control-sidebar control-sidebar-dark">
                <!-- Create the tabs -->
                <div class="tab-content">
                    <!-- Home tab content -->
                    <div class="tab-pane" id="control-sidebar-home-tab">
                        <h3 class="control-sidebar-heading">Recent Activity</h3>
                        <ul class="control-sidebar-menu">
                            <li>
                                <a href="javascript:void(0)">
                                    <i class="menu-icon fa fa-birthday-cake bg-red"></i>
                                </a>
                            </li>
                            <li>
                                <a href="javascript:void(0)">
                                    <i class="menu-icon fa fa-user bg-yellow"></i>
                                </a>
                            </li>
                            <li>
                                <a href="javascript:void(0)">
                                    <i class="menu-icon fa fa-envelope-o bg-light-blue"></i>
                                </a>
                            </li>
                            <li>
                                <a href="javascript:void(0)">
                                    <i class="menu-icon fa fa-file-code-o bg-green"></i>
                                </a>
                            </li>
                        </ul>
                        <!-- /.control-sidebar-menu -->

                        <h3 class="control-sidebar-heading">Tasks Progress</h3>
                        <ul class="control-sidebar-menu">
                            <li>
                                <a href="javascript:void(0)">
                                    <h4 class="control-sidebar-subheading">Custom Template Design
                <span class="label label-danger pull-right">70%</span>
                                    </h4>
                                </a>
                            </li>
                            <li>
                                <a href="javascript:void(0)">
                                    <h4 class="control-sidebar-subheading">Update Resume
                <span class="label label-success pull-right">95%</span>
                                    </h4>
                                </a>
                            </li>
                            <li>
                                <a href="javascript:void(0)">
                                    <h4 class="control-sidebar-subheading">Laravel Integration
                <span class="label label-warning pull-right">50%</span>
                                    </h4>
                                </a>
                            </li>
                            <li>
                                <a href="javascript:void(0)">
                                    <h4 class="control-sidebar-subheading">Back End Framework
                <span class="label label-primary pull-right">68%</span>
                                    </h4>
                                </a>
                            </li>
                        </ul>
                        <!-- /.control-sidebar-menu -->

                    </div>
                    <!-- /.tab-pane -->
                    <!-- Stats tab content -->
                    <div class="tab-pane" id="control-sidebar-stats-tab">Stats Tab Content</div>
                    <!-- /.tab-pane -->
                    <!-- Settings tab content -->
                    <!-- /.tab-pane -->
                </div>
            </aside>
            <!-- /.control-sidebar -->
            <!-- Add the sidebar's background. This div must be placed
       immediately after the control sidebar -->
            <div class="control-sidebar-bg"></div>
        </div>
        <!-- ./wrapper -->

        <!-- jQuery 3 -->

        <script src="Other_component/jquery/dist/jquery.min.js"></script>
        <!-- Bootstrap 3.3.7 -->
        <script src="Other_component/bootstrap/dist/js/bootstrap.min.js"></script>
        <!-- SlimScroll -->
        <script src="Other_component/jquery-slimscroll/jquery.slimscroll.min.js"></script>
        <!-- FastClick -->
        <script src="Other_component/fastclick/lib/fastclick.js"></script>
        <!-- AdminLTE App -->
        <script src="Other_component/dist/js/adminlte.min.js"></script>
        <!-- AdminLTE for demo purposes -->
        <script src="Other_component/dist/js/demo.js"></script>
    </form>
</body>
</html>
