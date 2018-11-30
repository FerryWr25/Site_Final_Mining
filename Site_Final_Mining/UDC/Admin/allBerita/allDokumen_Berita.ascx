<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="allDokumen_Berita.ascx.cs" Inherits="Site_Final_Mining.UDC.Admin.allBerita.allDokumen_Berita" %>

<section class="content-header">
    <h1>Konten Berita
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
                            <h1 class="box-title" style="margin-top: 5px">Dokumen Berita</h1>
                            <input type="hidden" id="tanggal" runat="server" value="" />
                        </div>
                        <div class="col-md-3">
                            <div class="input-group input-group-sm date">
                                <div class="input-group-addon">
                                    <i class="fa fa-calendar"></i>
                                </div>
                                <asp:TextBox ID="datepicker" runat="server" CssClass="form-control" placeholder="Masukkan Tanggal Berita" ClientIDMode="Static"></asp:TextBox>
                                <span class="input-group-btn">
                                    <asp:Button ID="cari_berita" runat="server" Text="Cari" CssClass="btn btn-info btn-flat" />
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="row">
                        <div class="col-md-9">
                            <!-- isi table -->
                            <div class="box">
                                <!-- /.box-header -->
                                <div class="box-body">
                                    <div class="table-responsive" style="background: white !important;">
                                        <asp:GridView ID="tabelBerita" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover" AllowPaging="True" OnPageIndexChanging="nextView" ShowHeaderWhenEmpty="True" EmptyDataText="Tidak Ada Berita" EmptyDataRowStyle-HorizontalAlign="Center" PageSize="10" PagerSettings-PageButtonCount="10" PagerSettings-Mode="NumericFirstLast">
                                            <Columns>
                                                <asp:TemplateField HeaderText="No" ItemStyle-Width="30" ItemStyle-HorizontalAlign="Justify">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField HeaderText="Judul Berita" DataField="title">
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="site_name" HeaderText="Sumber Berita" />
                                                <asp:BoundField DataField="author" HeaderText="Penulis" />
                                                <asp:BoundField DataField="date" HeaderText="Tanggal Publikasi" />
                                                <asp:TemplateField HeaderText="Aksi" ShowHeader="False">
                                                    <ItemTemplate>
                                                        <asp:Button ID="btnDetail" runat="server" Text="Read more" CommandArgument='<%# Eval("id") %>' CssClass="btn btn-success btn-sm" CausesValidation="false"></asp:Button>
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
                        <div class="col-md-3">
                            <div class="info-box bg-aqua">
                                <span class="info-box-icon"><i class="fa fa-bookmark-o"></i></span>
                                <div class="info-box-content">
                                    <span class="info-box-text">Bookmarks</span>
                                    <span class="info-box-number">41,410</span>

                                    <div class="progress">
                                        <div class="progress-bar" style="width: 70%"></div>
                                    </div>
                                    <a href="#" class="small-box-footer" style="color: whitesmoke">More info <i class="fa fa-arrow-circle-right"></i></a>
                                </div>
                                <!-- /.info-box-content -->
                            </div>
                            <div class="info-box bg-green">
                                <span class="info-box-icon"><i class="fa fa-thumbs-o-up"></i></span>

                                <div class="info-box-content">
                                    <span class="info-box-text">Likes</span>
                                    <span class="info-box-number">41,410</span>

                                    <div class="progress">
                                        <div class="progress-bar" style="width: 70%"></div>
                                    </div>
                                    <a href="#" class="small-box-footer" style="color: whitesmoke">More info <i class="fa fa-arrow-circle-right"></i></a>
                                </div>
                                <!-- /.info-box-content -->
                            </div>
                            <div class="info-box bg-yellow">
                                <span class="info-box-icon"><i class="fa fa-calendar"></i></span>

                                <div class="info-box-content">
                                    <span class="info-box-text">Events</span>
                                    <span class="info-box-number">41,410</span>

                                    <div class="progress">
                                        <div class="progress-bar" style="width: 70%"></div>
                                    </div>
                                    <a href="#" class="small-box-footer" style="color: whitesmoke">More info <i class="fa fa-arrow-circle-right"></i></a>
                                </div>
                                <!-- /.info-box-content -->
                            </div>
                            <div class="info-box bg-red">
                                <span class="info-box-icon"><i class="fa fa-comments-o"></i></span>

                                <div class="info-box-content">
                                    <span class="info-box-text">Comments</span>
                                    <span class="info-box-number">41,410</span>

                                    <div class="progress">
                                        <div class="progress-bar" style="width: 70%"></div>
                                    </div>
                                    <a href="#" class="small-box-footer" style="color: whitesmoke">More info <i class="fa fa-arrow-circle-right"></i></a>
                                </div>
                                <!-- /.info-box-content -->
                            </div>
                        </div>
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

