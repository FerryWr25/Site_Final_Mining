<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="logMember.ascx.cs" Inherits="Site_Final_Mining.UDC.Admin.manage_pengguna.logMember" %>

<section class="content-header">
    <h1>Management Pengguna
        <small>Control panel</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-user"></i>Admin</a></li>
        <li class="active">Management pengguna</li>
    </ol>
</section>

<section class="content">
    <div class="row">
        <div class="col-md-12" id="aktivitas" runat="server">
            <div class="box box-primary box-solid">
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="col-md-12">
                        <div class="box box-info" id="tabel_panel" runat="server">
                            <div class="box-header">
                                <h3 class="box-title"><b><i class="fa fa-history" aria-hidden="true"></i>&nbsp;Log Activity <asp:Label ID="memberLog_Name" runat="server"></asp:Label> <i class="fa fa-check" style="color:green"></i></b></h3>
                            </div>
                            <div class="box-body">
                                <div class="table-responsive" style="background: white !important;">
                                    <asp:GridView ID="tabelLog" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" AllowPaging="True" OnPageIndexChanging="nextView" ShowHeaderWhenEmpty="True" EmptyDataText="Tidak Ada Aktivitas" EmptyDataRowStyle-HorizontalAlign="Center" PageSize="10" PagerSettings-Mode="NumericFirstLast">
                                        <Columns>
                                            <asp:ImageField ItemStyle-Width="150px" ItemStyle-HorizontalAlign="Center" DataImageUrlField="pathPhoto" ControlStyle-Width="100" ControlStyle-Height="100" ControlStyle-CssClass="profile-user-img img-responsive img-circle"></asp:ImageField>
                                            <asp:TemplateField ItemStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID="Label1" runat="server"><span class="label label-primary"><i class="fa fa-user" aria-hidden="true"></i></span> Nama : <%# Eval("Nama") %> </asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Label ID="waktuAkses" runat="server"><i class="fa fa-clock-o" aria-hidden="true"></i> Waktu Akses : <%# Eval("timeAccess")%> WIB</asp:Label>
                                                    <br /><br />
                                                    <asp:Label ID="kodeberita" runat="server"><span class="label label-success"><i class="fa fa-key" aria-hidden="true"></i></span> Kode Berita : <%# Eval("id_berita")%></span></asp:Label><br /><br />
                                                    <asp:Label ID="judul" runat="server"><span class="label label-success"><i class="fa fa-book" aria-hidden="true"></i></span> Judul Berita : <%# Eval("judul")%></span></asp:Label><br /><br />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <EmptyDataRowStyle HorizontalAlign="Center"></EmptyDataRowStyle>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
        </div>
    </div>
</section>