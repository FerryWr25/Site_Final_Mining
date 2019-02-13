    <%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AllBerita.ascx.cs" Inherits="Site_Final_Mining.UDC.Member.Filter_dokumen.AllBerita" %>
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
                        <div id="judul" runat="server">
                            <h1 class="box-title" style="margin-top: 5px">Dokumen Berita</h1>
                            <input type="hidden" id="tanggal" runat="server" value="" />
                        </div>
                        <div class="col-md-2" id="groupBtn_showAll" runat="server">
                            <div class="input-group input-group-sm">
                                <div class="input-group-addon">
                                    <i class="fa fa-reply-all"></i>
                                </div>
                                <input type="hidden" id="asa" cssclass="form-control" runat="server" value="" />
                                <span class="input-group-btn">
                                    <asp:Button ID="btnShowALL" runat="server" Text="Show all Document" CssClass="btn btn-info" type="submit" OnClick="show_all_klik" />
                                </span>
                            </div>
                        </div>

                        <div class="col-md-3" id="groupFilter_date" runat="server">
                            <div class="input-group input-group-sm">
                                <div class="input-group-addon">
                                    <i class="fa fa-calendar"></i>
                                </div>
                                <asp:DropDownList ID="Drop_Date" CssClass="form-control" runat="server">
                                </asp:DropDownList>
                                <span class="input-group-btn">
                                    <asp:LinkButton ID="btn_Drop" runat="server" Text="Filter By Time" CssClass="btn btn-info" type="submit" OnClick="filterByTime_klik"></asp:LinkButton>
                                </span>
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="input-group input-group-sm">
                                <div class="input-group-addon">
                                    <i class="fa fa-search"></i>
                                </div>
                                <asp:TextBox ID="query" runat="server" CssClass="form-control" placeholder="Masukan Pencarian" required="true"></asp:TextBox>
                                <span class="input-group-btn">
                                    <asp:Button ID="btnSubmit_Query" runat="server" Text="Search" CssClass="btn btn-info" type="submit" OnClick="submitQuery_click" />
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
                                        <asp:GridView ID="tabelBerita" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover" AllowPaging="True" OnPageIndexChanging="nextView" ShowHeaderWhenEmpty="True" EmptyDataRowStyle-HorizontalAlign="Center" PageSize="3" PagerSettings-PageButtonCount="10" PagerSettings-Mode="NumericFirstLast">
                                            <Columns>
                                                <asp:TemplateField ItemStyle-Width="1000" ItemStyle-HorizontalAlign="Justify">
                                                    <ItemTemplate>
                                                        <asp:Label ID="judul" runat="server" Font-Bold="true" Font-Size="16"><%# Eval("title")%></asp:Label><br />
                                                        <asp:Label ID="SumberBerita" runat="server"><span class="label label-success"><i class="fa fa-book" aria-hidden="true"></i>&nbsp;<%# Eval("site_name") %></span></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:Label ID="penulis" ForeColor="#a0a0c5" runat="server"><i class="fa fa-user-circle-o" aria-hidden="true"></i>&nbsp;<%# Eval("author") %></span></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:Label ID="tanggal" ForeColor="#a0a0c5" runat="server"><i class="fa fa-clock-o" aria-hidden="true"></i>&nbsp;Terbit: <%# Eval("date")%></span></asp:Label><br />
                                                        <br />
                                                        <asp:Label ID="konten" runat="server"><%# Eval("news").ToString().Substring(0, Eval("news").ToString().Length-(Eval("news").ToString().Length)/3)+"[.....]" %></asp:Label><br />
                                                        <br />
                                                        <asp:LinkButton ID="matane" runat="server" CommandArgument='<%# Eval("id") %>' CommandName='<%# Eval("title") %>'  OnClick="readmore_click" CssClass="btn btn-primary">
                                                           Read more <i class="fa fa-long-arrow-right" aria-hidden="true"></i>
                                                        </asp:LinkButton>
                                                        <asp:Label runat="server" Font-Bold="true" Font-Size="16"><%# Eval("id")%></asp:Label><br />
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
                        <div class="col-md-12">
                            <div class="chart" id="grafik" runat="server">
                                <!-- timeFrame Chart Canvas -->
                                <canvas id="barChart" style="height: 290px;"></canvas>
                            </div>
                            <!-- /.chart-responsive -->
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
