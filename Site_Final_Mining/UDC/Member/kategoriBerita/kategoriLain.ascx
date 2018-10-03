<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="kategoriLain.ascx.cs" Inherits="Site_Final_Mining.UDC.Member.kategoriBerita.kategoriLain" %>


<section class="content-header">
    <h1>Konten Berita Lainya
        <small>Control panel</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Member</a></li>
        <li class="active">kategori Lainya</li>
    </ol>
</section>

<section class="content">
    <div class="row">
        <div class="col-md-12">
            <div class="box">
                <div class="box-header with-border">
                    <div class="row">
                        <div class="col-md-9">
                            <h1 class="box-title" style="margin-top: 5px">Tabel Berita Lainya</h1>
                            <input type="hidden" id="tanggal" runat="server" value="" />
                        </div>
                        <div class="col-md-3">
                            <div class="input-group input-group-sm date">
                                <div class="input-group-addon">
                                    <i class="fa fa-calendar"></i>
                                </div>
                                <asp:TextBox ID="datepicker" runat="server" CssClass="form-control" placeholder="Masukkan Tanggal Berita" ClientIDMode="Static" ReadOnly="true" required="true"></asp:TextBox>
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
                                <div class="box-header with-border">
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body">
                                    <table class="table table-bordered">
                                        <tr>
                                            <th style="width: 10px">No</th>
                                            <th style="width: 500px">Judul Berita</th>
                                            <th style="width: 200px">Link Berita</th>
                                            <th style="width: 150px">Sumber Berita</th>
                                            <th style="text-align: center">Aksi</th>
                                        </tr>
                                        <tr>
                                            <td>1.</td>
                                            <td>Update software</td>
                                            <td>google.com</td>
                                            <td><span class="label label-success">TribunNews.com</span></td>
                                            <td style="text-align: center">
                                                <asp:Button runat="server" CssClass="btn btn-success btn-sm" aria-pressed="false" autocomplete="off" Text="Read more" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>2.</td>
                                            <td>Clean database</td>
                                            <td>google.com</td>
                                            <td>
                                                <span class="label label-primary">Detik.com</span>
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button runat="server" CssClass="btn btn-success btn-sm" aria-pressed="false" autocomplete="off" Text="Read more" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>3.</td>
                                            <td>Cron job running</td>
                                            <td>google.com</td>
                                            <td>
                                                <span class="label label-warning">Liputan6.com</span>
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button runat="server" CssClass="btn btn-success btn-sm" aria-pressed="false" autocomplete="off" Text="Read more" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>4.</td>
                                            <td>Fix and squish bugs</td>
                                            <td>google.com</td>
                                            <td>
                                                <span class="label label-primary">Detik.com</span>
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button runat="server" CssClass="btn btn-success btn-sm" aria-pressed="false" autocomplete="off" Text="Read more" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>5.</td>
                                            <td>Fix and squish bugs</td>
                                            <td>google.com</td>
                                            <td><span class="label label-primary">Detik.com</span></td>
                                            <td style="text-align: center">
                                                <asp:Button runat="server" CssClass="btn btn-success btn-sm" aria-pressed="false" autocomplete="off" Text="Read more" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>6.</td>
                                            <td>Cron job running programmer</td>
                                            <td>google.com</td>
                                            <td>
                                                <span class="label label-warning">Liputan6.com</span>
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button runat="server" CssClass="btn btn-success btn-sm" aria-pressed="false" autocomplete="off" Text="Read more" />
                                            </td>
                                        </tr>
                                        <tr>
                                    </table>
                                </div>
                                <!-- /.box-body -->
                                <div class="box-footer clearfix">
                                    <ul class="pagination pagination-sm no-margin pull-right">
                                        <li><a href="#">&laquo;</a></li>
                                        <li><a href="#">1</a></li>
                                        <li><a href="#">2</a></li>
                                        <li><a href="#">3</a></li>
                                        <li><a href="#">&raquo;</a></li>
                                    </ul>
                                </div>
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