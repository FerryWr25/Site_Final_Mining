<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome[Here_MemberPanel].aspx.cs" Inherits="Site_Final_Mining.Welcome_Here_Member_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>siteMining | Member</title>
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <link href="Other_component/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="Content/font-awesome.min.css" />
    <link href="Ionicons/css/ionicons.min.css" rel="stylesheet" />
    <link href="admin-lte/css/AdminLTE.min.css" rel="stylesheet" />
    <link href="admin-lte/css/skins/_all-skins.min.css" rel="stylesheet" />
     <script src="chart/js/Chart.min.js"></script>
</head>
<body class="hold-transition skin-blue fixed sidebar-mini">
    <form runat="server">
        <!-- Site wrapper -->
        <div class="wrapper">

            <header class="main-header">
                <!-- Logo -->
                <a href="../../index2.html" class="logo">
                    <!-- mini logo for sidebar mini 50x50 pixels -->
                    <span class="logo-mini"><b>M</b>BM</span>
                    <!-- logo for regular state and mobile devices -->
                    <span class="logo-lg"><b>Member</b>Panel</span>
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
                                                        <asp:Image ID="profileImage" CssClass="img-circle" src="" runat="server" />
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
                                    <asp:Image ID="profileImage_dropdown" CssClass="user-image" src="" runat="server" />
                                    <span class="hidden-xs">
                                        <asp:Label ID="labelNama2" runat="server"></asp:Label>
                                    </span>
                                </a>
                                <ul class="dropdown-menu">
                                    <!-- User image -->
                                    <li class="user-header">
                                        <asp:Image ID="profileSideBar" CssClass="img-circle" src="" runat="server" />

                                        <p>
                                            <asp:Label ID="labelNama3" runat="server"></asp:Label>
                                            - System Analist
                  <small>Enjoying Here</small>
                                        </p>
                                    </li>
                                    <!-- Menu Body -->
                                    <li class="user-body">
                                        <div class="row">
                                            <div class="col-xs-4 text-center">
                                                <a href="#">Followers</a>
                                            </div>
                                            <div class="col-xs-4 text-center">
                                                <a href="#">Sales</a>
                                            </div>
                                            <div class="col-xs-4 text-center">
                                                <a href="#">Friends</a>
                                            </div>
                                        </div>
                                        <!-- /.row -->
                                    </li>
                                    <!-- Menu Footer-->
                                    <li class="user-footer">
                                        <div class="pull-left">
                                            <asp:Button ID="btn_Profile_member" Text="Profile" CssClass="btn btn-default btn-flat" runat="server" OnClick="profile_Click" />
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
                                    <span class="label label-primary pull-right">3</span>
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
                        <li id="menu_all_konten_berita" runat="server">
                            <asp:LinkButton ID="allBerita" runat="server" OnClick="allBerita_Click">
                                <i class="fa fa-book" runat="server"></i><span>Semua Konten Berita</span>
                            <span class="pull-right-container">
                                <small class="label pull-right bg-green">news</small>
                            </span>
                            </asp:LinkButton>
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
                    </ul>
                </section>
                <!-- /.sidebar -->
            </aside>

            <!-- =============================================== -->

            <!-- Content Wrapper. Contains page content -->
            <div class="content-wrapper">
                <!-- Main content -->
                <section class="content">
                    <asp:PlaceHolder ID="Content_Member" runat="server" EnableViewState="false"></asp:PlaceHolder>
                    <!-- /.box -->
                </section>
                <!-- /.content -->
            </div>
            <!-- /.content-wrapper -->

            <footer class="main-footer">
                <div class="pull-right hidden-xs">
                    <b>Version</b> 1.0.0
                </div>
                <strong>Copyright &copy; 2018-2019 <a href="https://adminlte.io">Ferry wiranto</a>.</strong> All rights
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
