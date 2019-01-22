<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="readMore_detik.ascx.cs" Inherits="Site_Final_Mining.UDC.Global.Filter_Dokumen.readMore_detik" %>
<section class="content-header">
    <h1>Detail Konten Berita
        <small>Control panel</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
        <li class="active">Dashboard</li>
    </ol>
</section>

<section class="content">
    <div class="row">
        <div class="col-md-12">
            <div class="box">
                <div class="box-header with-border">
                    <div class="row">
                        <div class="col-md-9">
                            <h1 class="box-title" style="margin-top: 5px">Dokumen Berita Detik.com</h1>
                            <input type="hidden" id="tanggal" runat="server" value="" />
                        </div>  
                        <div class="col-md-3">
                            <asp:LinkButton OnClick="backDetik_Click" runat="server" CssClass="btn btn-primary">
                                <i class="fa fa-long-arrow-left" aria-hidden="true"></i>&nbsp;Kembali
                            </asp:LinkButton>
                        </div>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="row">
                        <div class="col-md-12">
                            <!-- isi table -->
                            <div class="box">
                                <!-- /.box-header -->
                                <div class="box-body">
                                    <div class="table-responsive" style="background: white !important;">
                                        <asp:GridView ID="tabelBerita" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover" AllowPaging="True" ShowHeaderWhenEmpty="True" EmptyDataText="Tidak Ada Berita" EmptyDataRowStyle-HorizontalAlign="Center" PageSize="10" PagerSettings-PageButtonCount="10" PagerSettings-Mode="NumericFirstLast">
                                            <Columns>
                                                <asp:TemplateField ItemStyle-Width="1000" ItemStyle-HorizontalAlign="Justify">
                                                    <ItemTemplate>
                                                        <asp:Label ID="judul" runat="server" Font-Bold="true" Font-Size="16"><%# Eval("title")%></asp:Label><br />
                                                        <asp:Label ID="SumberBerita" runat="server"><span class="label label-primary"><i class="fa fa-book" aria-hidden="true"></i>&nbsp;<%# Eval("site_name") %></span></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:Label ID="penulis" ForeColor="#a0a0c5" runat="server"><i class="fa fa-user-circle-o" aria-hidden="true"></i>&nbsp;<%# Eval("author") %></span></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:Label ID="tanggal" ForeColor="#a0a0c5" runat="server"><i class="fa fa-clock-o" aria-hidden="true"></i>&nbsp;Terbit: <%# Eval("date")%></span></asp:Label><br />
                                                        <br />
                                                        <asp:Label ID="konten" runat="server"><%# Eval("news") %></asp:Label><br />
                                                        <br />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <EmptyDataRowStyle HorizontalAlign="Center"></EmptyDataRowStyle>
                                        </asp:GridView>
                                    </div>
                                </div>
                                <!-- /.box-body -->
                            </div>
                        </div>

                        <!-- /.isi box sebelah tabel -->
                        <!-- /.col -->
                    </div>
                    <!-- /.row -->
                </div>
                <!-- /.box-footer -->
            </div>
            <!-- /.box -->
        </div>
    </div>
</section>
