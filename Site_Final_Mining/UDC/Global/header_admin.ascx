<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header_admin.ascx.cs" Inherits="Site_Final_Mining.UDC.Global.header_admin" %>

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



