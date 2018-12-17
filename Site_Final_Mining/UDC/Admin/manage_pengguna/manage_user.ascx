<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="manage_user.ascx.cs" Inherits="Site_Final_Mining.UDC.Admin.manage_pengguna.manage_user" %>

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
                                <h3 class="box-title"><b><i class="fa fa-info-circle" aria-hidden="true"></i>&nbsp;Daftar Member</b></h3>
                            </div>
                            <div class="box-body">
                                <div class="table-responsive" style="background: white !important;">
                                    <asp:GridView ID="tabelPendaftar" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" AllowPaging="True" OnPageIndexChanging="nextView" ShowHeaderWhenEmpty="True" EmptyDataText="Tidak Ada Pendaftar" EmptyDataRowStyle-HorizontalAlign="Center" PageSize="5" PagerSettings-PageButtonCount="5" PagerSettings-Mode="NumericFirstLast">
                                        <Columns>
                                            <asp:ImageField ItemStyle-Width="250px" ItemStyle-HorizontalAlign="Center" DataImageUrlField="path_photo" ControlStyle-Width="175px" ControlStyle-Height="175px" ControlStyle-CssClass="profile-user-img img-responsive img-circle"></asp:ImageField>
                                            <asp:TemplateField ItemStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID="judul" runat="server" Font-Bold="true"><span class="label label-warning"><i class="fa fa-user-o" aria-hidden="true"></i></span> Nama : <%# Eval("namaPengguna")%></asp:Label>&nbsp;&nbsp;&nbsp;
                                                        <asp:Label ID="SumberBerita" runat="server" Font-Bold="true"><span class="label label-danger"><i class="fa fa-envelope-o" aria-hidden="true"></i></span> Email : <%# Eval("email") %></asp:Label><br />
                                                    <br />
                                                    <asp:Label ID="penulis" runat="server"><span class="label label-success"><i class="fa fa-briefcase" aria-hidden="true"></i></span> Pekerjaan : <%# Eval("pekerjaan") %></span></asp:Label><br />
                                                    <br />
                                                    <asp:Label ID="tanggal" runat="server"><span class="label label-success"><i class="fa fa-briefcase" aria-hidden="true"></i></span> Alamat : <%# Eval("alamat")%></span></asp:Label><br />
                                                    <br />
                                                    <asp:Label ID="jenisKelamin" runat="server"><span class="label label-primary"><i class="fa fa-briefcase" aria-hidden="true"></i></span> Jenis Kelamin : <%# Eval("jenis_kelamin") %></asp:Label><br />
                                                    <br />
                                                    <asp:Label ID="Alasan" runat="server"><span class="label label-primary"><i class="fa fa-briefcase" aria-hidden="true"></i></span> Alasan Bergabung : <%# Eval("alasanBergabung") %></asp:Label><br />
                                                    <br />
                                                    <asp:LinkButton OnClick="a_Click" runat="server" CommandArgument='<%# Eval("email") %>' CssClass="btn btn-primary">
                                                           Log Activity <i class="fa fa-long-arrow-right" aria-hidden="true"></i>
                                                    </asp:LinkButton>
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

