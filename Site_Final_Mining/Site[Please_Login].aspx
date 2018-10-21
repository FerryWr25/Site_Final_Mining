<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Site[Please_Login].aspx.cs" Inherits="Site_Final_Mining.Site_Please_Login_" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Welcome | Login</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <!-- Bootstrap 3.3.7 -->
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Other_component/bootstrap/dist/css/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/css_login/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body>
    <!-- //title -->
    <!-- content -->
    <asp:PlaceHolder ID="Alert_Message" runat="server" EnableViewState="false"></asp:PlaceHolder>
    <asp:PlaceHolder ID="Content_Login" runat="server" EnableViewState="false"></asp:PlaceHolder>
    <!-- //content -->

    <!-- copyright -->
    <div class="footer">
        <p>
            &copy; 2018 Validator Signup Form. All rights reserved | Design by
				<a href="http://w3layouts.com">W3layouts</a>
        </p>
    </div>
    <!-- //copyright -->
    <script src="Scripts/js_login/jquery-2.2.3.min.js"></script>
    <script src="Scripts/js_login/jquery-simple-validator.min.js"></script>
    <!-- Jquery -->
</body>
</html>
