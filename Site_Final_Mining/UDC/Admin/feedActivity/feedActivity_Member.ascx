<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="feedActivity_Member.ascx.cs" Inherits="Site_Final_Mining.UDC.Admin.feedActivity.feedActivity_Member" %>

<section class="content-header">
    <h1>Feed Activity Member
        <small>Control panel</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-user"></i>Admin</a></li>
        <li class="active">News Feed</li>
    </ol>
</section>

<section class="content">
    <div class="row">
        <div class="col-md-12">
            <div class="box">
                <div class="box-header with-border">
                    <div class="row">
                        <div class="col-md-7">
                            <h1 class="box-title" style="margin-top: 5px">Activitas member terbaru</h1>
                            <input type="hidden" id="tanggal" runat="server" value="" />
                        </div>
                        <div class="col-md-1">
                            <asp:Button ID="btnShowALL" runat="server" Text="Show all"  CssClass="btn btn-info" type="submit" OnClick="show_all_klik" />
                        </div>
                        <div class="col-md-4">
                            <div class="input-group input-group-sm">

                                <div class="input-group-addon">
                                    <i class="fa fa-search"></i>
                                </div>
                                <asp:TextBox ID="query" runat="server" CssClass="form-control" placeholder="Masukan Pencarian" required="true"></asp:TextBox>
                                <span class="input-group-btn">
                                    <asp:Button ID="btnSubmit_Query" runat="server" Text="Search" CssClass="btn btn-info" type="submit" OnClick="search_klik" />
                                </span>
                            </div>

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
                                        <asp:GridView ID="tabelActivity" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover" AllowPaging="True" OnPageIndexChanging="nextView" ShowHeaderWhenEmpty="True" EmptyDataText="Tidak ada berita yang mengandung kata pada setiap query" EmptyDataRowStyle-HorizontalAlign="Center" PageSize="10" PagerSettings-PageButtonCount="10" PagerSettings-Mode="NumericFirstLast">
                                            <Columns>
                                                <asp:ImageField ItemStyle-Width="150px" ItemStyle-HorizontalAlign="Center" DataImageUrlField="path_photo" ControlStyle-Width="100px" ControlStyle-Height="100px" ControlStyle-CssClass="profile-user-img img-responsive img-circle"></asp:ImageField>
                                                <asp:TemplateField ItemStyle-Width="1000" ItemStyle-HorizontalAlign="Justify">
                                                    <ItemTemplate>
                                                        <asp:Label ID="judul" runat="server" Font-Bold="true" Font-Size="16"><%# Eval("judul")%></asp:Label><br />
                                                        <br />
                                                        <asp:Label ID="email" runat="server"><span class="label label-success"><i class="fa fa-book" aria-hidden="true"></i>&nbsp;<%# Eval("email") %></span></asp:Label>&nbsp;
                                                        <asp:Label ID="pekerjaan" ForeColor="#a0a0c5" runat="server"><i class="fa fa-clock-o" aria-hidden="true"></i>&nbsp;Pekerjaan: <%# Eval("pekerjaan")%></asp:Label>&nbsp;
                                                        <asp:Label ID="tglDaftar" ForeColor="#a0a0c5" runat="server"><i class="fa fa-clock-o" aria-hidden="true"></i>&nbsp;Bergabung sejak: <%# Eval("tanggalDaftar") %></asp:Label>&nbsp;
                                                        <asp:Label ID="timeAccess" ForeColor="#a0a0c5" runat="server"><i class="fa fa-clock-o" aria-hidden="true"></i>&nbsp;Waktu akses: <%# Eval("timeAccess") %></asp:Label>
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
</section>
