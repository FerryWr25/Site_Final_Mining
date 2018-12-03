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
        <div class="col-md-12" id="aktivitas" runat="server">
            <div class="box box-primary box-solid">
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="col-md-12">
                        <div class="box box-info" id="tabel_panel" runat="server">
                            <div class="box-body">
                                <div class="tweetEntry-tweetHolder">
                                    <h1 class="tweetEntry" style="margin-bottom: 0px;">Aktivitas Member</h1>
                                    <!---------------------------------------->
                                    <!-- Entry with Media turned on. -->
                                    <div class="tweetEntry">
                                        <div class="tweetEntry-content">
                                            <a class="tweetEntry-account-group" href="[accountURL]">
                                                <img class="tweetEntry-avatar" src="http://placekitten.com/200/200">
                                                <strong class="tweetEntry-fullname">[fullname]
                                                </strong>
                                                <span class="tweetEntry-username">@<b>[username]</b>
                                                </span>
                                                <span class="tweetEntry-timestamp">- [timestamp]</span>
                                            </a>
                                            <div class="tweetEntry-text-container">
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed quam ipsum, finibus ac est sed, vestibulum condimentum neque. Sed eget iaculis.
                                            </div>
                                        </div>
                                         <div class="tweetEntry-action-list" style="line-height: 24px; color: #b1bbc3;">
                                            <i class="fa fa-reply" style="width: 80px;">&nbsp;15k</i>
                                            <i class="fa fa-thumbs-o-down" style="width: 80px;">&nbsp;200</i>
                                            <i class="fa fa-heart" style="width: 80px">&nbsp;1k</i>
                                        </div>
                                    </div>

                                    <!-- Entry with Media turned off. -->
                                    <div class="tweetEntry">
                                        <div class="tweetEntry-content">
                                            <a class="tweetEntry-account-group" href="[accountURL]">
                                                <img class="tweetEntry-avatar" src="http://placekitten.com/100/100">
                                                <strong class="tweetEntry-fullname">[fullname]
                                                </strong>
                                                <span class="tweetEntry-username">@<b>[username]</b>
                                                </span>
                                                <span class="tweetEntry-timestamp">- [timestamp]</span>
                                            </a>
                                            <div class="tweetEntry-text-container">
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed quam ipsum, finibus ac est sed, vestibulum condimentum neque. Sed eget iaculis.
                                            </div>
                                        </div>
                                        <div class="optionalMedia" style="display: none;">
                                            <img class="optionalMedia-img" src="https://i.imgur.com/kOhhPAk.jpg">
                                        </div>
                                         <div class="tweetEntry-action-list" style="line-height: 24px; color: #b1bbc3;">
                                            <i class="fa fa-reply" style="width: 80px;">&nbsp;15k</i>
                                            <i class="fa fa-thumbs-o-down" style="width: 80px;">&nbsp;200</i>
                                            <i class="fa fa-heart" style="width: 80px">&nbsp;1k</i>
                                        </div>
                                    </div>
                                    <!-- Entry with Media turned on. -->
                                    <div class="tweetEntry">
                                        <div class="tweetEntry-content">
                                            <a class="tweetEntry-account-group" href="[accountURL]">
                                                <img class="tweetEntry-avatar" src="http://placekitten.com/150/150">
                                                <strong class="tweetEntry-fullname">[fullname]
                                                </strong>
                                                <span class="tweetEntry-username">@<b>[username]</b>
                                                </span>
                                                <span class="tweetEntry-timestamp">- [timestamp]</span>
                                            </a>
                                            <div class="tweetEntry-text-container">
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed quam ipsum, finibus ac est sed, vestibulum condimentum neque. Sed eget iaculis.
                                            </div>
                                        </div>
                                        <div class="tweetEntry-action-list" style="line-height: 24px; color: #b1bbc3;">
                                            <i class="fa fa-reply" style="width: 80px;">&nbsp;15k</i>
                                            <i class="fa fa-thumbs-o-down" style="width: 80px;">&nbsp;200</i>
                                            <i class="fa fa-heart" style="width: 80px">&nbsp;1k</i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.box-body -->
        </div>
    </div>
</section>
