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
                            <div class="box-header" >
                                <h3 class="box-title"><b><i class="fa fa-info-circle" aria-hidden="true"></i>&nbsp;Daftar Member</b></h3>
                            </div>
                            <div class="box-body">
                                <div class="table-responsive" style="background: white !important;">
                                    <asp:GridView ID="tabelPendaftar" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover" AllowPaging="True" OnPageIndexChanging="nextView" ShowHeaderWhenEmpty="True" EmptyDataText="Tidak Ada Pendaftar" EmptyDataRowStyle-HorizontalAlign="Center" PageSize="5" PagerSettings-PageButtonCount="5" PagerSettings-Mode="NumericFirstLast">
                                        <Columns>
                                            <asp:BoundField DataField="nama" HeaderText="Nama" />
                                            <asp:BoundField DataField="jenis_kelamin" HeaderText="Jenis kelamin" />
                                            <asp:BoundField DataField="email" HeaderText="Email" />
                                            <asp:BoundField DataField="alamat" HeaderText="Alamat" />
                                            <asp:ImageField DataImageUrlField="pathPhoto" HeaderText="Foto Diri" ControlStyle-Width="70px" ControlStyle-BorderWidth="0.8px" FooterStyle-VerticalAlign="Middle"></asp:ImageField>
                                            <asp:TemplateField HeaderText="Aksi">
                                                <ItemTemplate>
                                                    <asp:Button ID="Verifikasi" CommandName="verifikasi" runat="server" Text="Ubah" CssClass="btn btn-flat btn-success" CausesValidation="false" ToolTip="Data diurutkan sesuai pendaftaran terlama"></asp:Button>
                                                    <asp:Button ID="Hapus" CommandName="hapus" runat="server" Text="Shit" CssClass="btn btn-flat btn-danger" CausesValidation="false"></asp:Button>
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
        <//div>
</section>

