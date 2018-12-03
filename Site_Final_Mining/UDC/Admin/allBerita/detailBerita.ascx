<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="detailBerita.ascx.cs" Inherits="Site_Final_Mining.UDC.Admin.allBerita.detailBerita" %>

<section class="content-header">
    <h1>Detail Berita
                <small>
                    <asp:Label ID="sumberBerita" runat="server" Text="Tribunnews.com"></asp:Label>
                </small>
    </h1>
</section>

<section class="content">
    <div class="row">
        <div class="col-md-12">
            <div class="box">
                <div class="box-header with-border">
                    <div class="row">
                        <div class="col-md-10"></div>
                        <div class="col-md-2">
                            <asp:LinkButton ID="home" runat="server" CssClass="btn btn-primary">
                                <i class="fa fa-home"></i>&nbsp;Daftar Berita
                            </asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-3">
                            <div class="info-box bg-blue-gradient">
                                <span class="info-box-icon"><i class="fa fa-user"></i></span>
                                <div class="info-box-content">
                                    <span class="info-box-text">Penulis</span>
                                    <strong id="penulis" runat="server">Muhamat Abdul Rohim - Tribunnews</strong>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="info-box bg-yellow-gradient">
                                <span class="info-box-icon"><i class="fa fa-calendar"></i></span>
                                <div class="info-box-content">
                                    <span class="info-box-text">Publikasi</span>
                                    <strong id="tanggal_berita" runat="server">Sabtu 30 Desember 2017, 19.06 WIB</strong>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="info-box bg-red-gradient">
                                <span class="info-box-icon"><i class="fa fa-download"></i></span>
                                <div class="info-box-content">
                                    <span class="info-box-text">Ektraksi</span>
                                    <strong id="tanggal_scrap" runat="server">Sabtu 30 Desember 2017, 19.10 WIB</strong>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3"></div>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="box box-widget" style="background: #D2E0E6 !important;">
                                <div class="box-header with-border">
                                    <div class="user-block">
                                        <asp:Image ID="logo" runat="server" CssClass="img-circle" />
                                        <span class="username" id="judul" runat="server"></span>
                                        <span class="description" id="waktu" runat="server"></span>
                                    </div>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body" id="contentBerita" runat="server">
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /.row -->
                </div>
                <!-- /.box-footer -->
            </div>
            <!-- /.box -->
        </div>
    </div>
</section>
