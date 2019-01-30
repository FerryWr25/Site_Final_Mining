﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.ascx.cs" Inherits="Site_Final_Mining.UDC.Admin.Dashboard" %>

<section class="content-header">
    <h1>Dashboard
        <small>Control panel</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
        <li class="active">Dashboard</li>
    </ol>
</section>

<!-- Konten Body Dasboard Admin -->
<section class="content">
    <!-- Small boxes (Stat box) -->
    <div class="row">
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-aqua">
                <div class="inner">
                    <h3>
                        <asp:Label ID="totalTribun" runat="server" Text="Label"></asp:Label><sup style="font-size: 12px"> Doc</sup></h3>
                    <p>TribunNews</p>
                </div>
                <div class="icon">
                    <i class="fa fa-newspaper-o" aria-hidden="true"></i>
                </div>
                <asp:LinkButton ID="btnShow_Tribun" OnClick="tribunnews_Click" CssClass="small-box-footer" Text="More info" runat="server">More Info <i class="fa fa-arrow-circle-right"></i></asp:LinkButton>
            </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-green">
                <div class="inner">
                    <h3>
                        <asp:Label ID="TotalDetik" runat="server" Text="Label"></asp:Label><sup style="font-size: 12px"> Doc</sup></h3>
                    <p>Detik.com</p>
                </div>
                <div class="icon">
                    <i class="fa fa-newspaper-o" aria-hidden="true"></i>
                </div>
                <asp:LinkButton ID="btnShow_Detik" OnClick="detik_Click" CssClass="small-box-footer" Text="More info" runat="server">More Info <i class="fa fa-arrow-circle-right"></i></asp:LinkButton>
            </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-yellow">
                <div class="inner">
                    <h3>
                        <asp:Label ID="TotalLiputan6" runat="server" Text="Label"></asp:Label><sup style="font-size: 12px"> Doc</sup></h3>
                    <p>Liputan6</p>
                </div>
                <div class="icon">
                    <i class="fa fa-newspaper-o" aria-hidden="true"></i>
                </div>
                <asp:LinkButton ID="btnShow_Liputan6" OnClick="liputan6_Click" CssClass="small-box-footer" Text="More info" runat="server">More Info <i class="fa fa-arrow-circle-right"></i></asp:LinkButton>
            </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-red">
                <div class="inner">
                    <h3>
                        <asp:Label ID="jml_userActive" runat="server" Text="Label"></asp:Label>
                        <sup style="font-size: 12px">Pengguna</sup></h3>
                    <p>User Active</p>
                </div>
                <div class="icon">
                    <i class="ion ion-person-add"></i>
                </div>
                <asp:LinkButton ID="bnAnggotaActive" OnClick="anggotaActive_Click" CssClass="small-box-footer" Text="More info" runat="server">More Info <i class="fa fa-arrow-circle-right"></i></asp:LinkButton>
            </div>
        </div>

        <div class="col-md-12">
            <div class="box">
                <div class="box-header with-border">
                    <h3 class="box-title">Enjoying here with us</h3>
                    <div class="box-tools pull-right">
                        <button type="button" class="btn btn-box-tool" data-widget="collapse">
                            <i class="fa fa-minus"></i>
                        </button>
                        <div class="btn-group">
                            <button type="button" class="btn btn-box-tool dropdown-toggle" data-toggle="dropdown">
                                <i class="fa fa-wrench"></i>
                            </button>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="row">
                        <div class="col-md-8">
                            <div class="chart">
                                <canvas id="myChart" height="350"></canvas>
                            </div>
                        </div>
                        <!-- /.col -->
                        <div class="col-md-4">
                            <p class="text-center">
                                <strong>Detail Persentation Newspaper</strong>
                            </p>
                            <br />
                            <div class="progress-group">
                                <span class="progress-text">Tribunnews.com (<asp:Label ID="labelPersenTribun" runat="server"></asp:Label>%)</span>
                                <span class="progress-number"><b>
                                    <asp:Label ID="labelTibunnews1" runat="server"></asp:Label></b>/<asp:Label ID="labelTibunnews2" runat="server"></asp:Label></span>
                                <div class="progress progress-sm progress-striped active">
                                    <div class="progress-bar progress-bar-aqua" id="bar_Tribun" runat="server"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
                            <div class="progress-group">
                                <span class="progress-text">Detik.com (<asp:Label ID="labelPersenDetik" runat="server"></asp:Label>%)</span>
                                <span class="progress-number"><b>
                                    <asp:Label ID="labelDetik1" runat="server"></asp:Label></b>/<asp:Label ID="labelDetik2" runat="server"></asp:Label></span>
                                <div class="progress progress-sm progress-striped active">
                                    <div class="progress-bar progress-bar-green" id="bar_Detik" runat="server"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
                            <div class="progress-group">
                                <span class="progress-text">Liputan6.com (<asp:Label ID="labelPersenLiputan6" runat="server"></asp:Label>%)</span>
                                <span class="progress-number"><b>
                                    <asp:Label ID="labeliputan1" runat="server"></asp:Label></b>/<asp:Label ID="labeliputan2" runat="server"></asp:Label></span>
                                <div class="progress progress-sm progress-striped active">
                                    <div class="progress-bar progress-bar-yellow" id="bar_Lipuan6" runat="server"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
                            <div class="progress-group">
                                <span class="progress-text">User Active (<asp:Label ID="labelPersenUser" runat="server"></asp:Label>%)</span>
                                <span class="progress-number"><b>
                                    <asp:Label ID="labelUser1" runat="server"></asp:Label></b>/<asp:Label ID="labelUser2" runat="server"></asp:Label></span>
                                <div class="progress progress-sm progress-striped active">
                                    <div class="progress-bar progress-bar-red" id="bar_User" runat="server"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
                        </div>
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- ./box-body -->
            <div class="box-footer">
                <div class="row">
                    <div class="col-sm-3 col-xs-6">
                        <div class="description-block border-right">
                            <span class="description-percentage text-green"><i class="fa fa-caret-up"></i>17%</span>
                            <h5 class="description-header">$35,210.43</h5>
                            <span class="description-text">TOTAL REVENUE</span>
                        </div>
                        <!-- /.description-block -->
                    </div>
                    <!-- /.col -->
                    <div class="col-sm-3 col-xs-6">
                        <div class="description-block border-right">
                            <span class="description-percentage text-yellow"><i class="fa fa-caret-left"></i>0%</span>
                            <h5 class="description-header">$10,390.90</h5>
                            <span class="description-text">TOTAL COST</span>
                        </div>
                        <!-- /.description-block -->
                    </div>
                    <!-- /.col -->
                    <div class="col-sm-3 col-xs-6">
                        <div class="description-block border-right">
                            <span class="description-percentage text-green"><i class="fa fa-caret-up"></i>20%</span>
                            <h5 class="description-header">$24,813.53</h5>
                            <span class="description-text">TOTAL PROFIT</span>
                        </div>
                        <!-- /.description-block -->
                    </div>
                    <!-- /.col -->
                    <div class="col-sm-3 col-xs-6">
                        <div class="description-block">
                            <span class="description-percentage text-red"><i class="fa fa-caret-down"></i>18%</span>
                            <h5 class="description-header">1200</h5>
                            <span class="description-text">GOAL COMPLETIONS</span>
                        </div>
                        <!-- /.description-block -->
                    </div>
                </div>
                <!-- /.row -->
            </div>
            <!-- /.box-footer -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
    </div>

</section>


