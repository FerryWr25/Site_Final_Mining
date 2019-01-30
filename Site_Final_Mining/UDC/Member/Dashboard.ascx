<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.ascx.cs" Inherits="Site_Final_Mining.UDC.Member.Dashboard" %>

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
                        <asp:Label ID="jml_userActive" runat="server" Text="Label"></asp:Label> <sup style="font-size: 12px"> Pengguna</sup></h3>
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
                                <strong>Goal Completion</strong>
                            </p>
                            <div class="progress-group">
                                <span class="progress-text">Add Products to Cart</span>
                                <span class="progress-number"><b>50</b>/200</span>
                                <div class="progress sm">
                                    <div class="progress-bar progress-bar-aqua" style="width: 25%"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
                            <div class="progress-group">
                                <span class="progress-text">Complete Purchase</span>
                                <span class="progress-number"><b>310</b>/400</span>
                                <div class="progress sm">
                                    <div class="progress-bar progress-bar-red" style="width: 80%"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
                            <div class="progress-group">
                                <span class="progress-text">Visit Premium Page</span>
                                <span class="progress-number"><b>400</b>/800</span>
                                <div class="progress sm">
                                    <div class="progress-bar progress-bar-green" style="width: 50%"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
                            <div class="progress-group">
                                <span class="progress-text">Send Inquiries</span>
                                <span class="progress-number"><b>450</b>/500</span>
                                <div class="progress sm">
                                    <div class="progress-bar progress-bar-yellow" style="width: 90%"></div>
                                </div>
                            </div>
                            <!-- /.progress-group -->
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
    <script>
        let myChart = document.getElementById('myChart').getContext('2d');
        Chart.defaults.global.defaultFontSize = 12;
        Chart.defaults.global.defaultFontColor = '#777';
        let ChartPopulation = new Chart(myChart, {
            type: 'line',
            data: {
                labels: ['Boston city', 'Worcester city', 'Springfield city', 'Lowell city', 'Cambridge city', 'New Bedford city'],
                datasets: [{
                    label: 'Human Population',
                    data: [
                        617594,
                        181045,
                        153060,
                        106519,
                        105162,
                        95072
                    ],
                    backgroundColor: [
                        'rgba(255,99,132,0.6)',
                        'rgba(54,162,235,0.6)',
                        'rgba(255,206,86,0.6)',
                        'rgba(75,192,192,0.6)',
                        'rgba(255,159,64,0.6)',
                        'rgba(255,15,80,0.6)'
                    ],
                    borderWidth: 1,
                    borderColor: '#777',
                    hoverBorderWidth:2,
                    hoverBorderColor: '#000'
                }]
            },
            options: {
                title: {
                    display:true,
                    text: 'Largest Cities In Jangkar',
                    fontSize:18
                },
            }
        });
    </script>
</section>
