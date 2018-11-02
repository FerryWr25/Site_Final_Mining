<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Site_Final_Mining.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>MiningSite_Timeframe | Register</title>
    <!-- Tell the browser to be responsive to screen width -->
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <!-- Bootstrap 3.3.7 -->
    <link href="Content/ccs_register/style.css" rel="stylesheet" />
    <link href="Content/ccs_register/material-design-iconic-font.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <div class="main">
        <div class="container">
            <div class="booking-content">
                <div class="booking-image">
                    <img class="booking-img" src="admin-lte/img/as.jpg" alt="Booking Image" />
                </div>
                <div class="booking-form">
                    <form runat="server" method="post" action="#" >
                        <h2>Pendaftaran akun!</h2>
                        <div class="form-group form-input">
                            <input type="text" name="email" id="email" value="" runat="server" required />
                            <label for="email" class="form-label">Email</label>
                        </div>
                        <div class="form-group form-input">
                            <input type="password" name="pass" id="pass" value="" runat="server" required />
                            <label for="pass" class="form-label">Password</label>
                        </div>
                        <div class="form-group form-input">
                            <input type="password" name="pass2" id="pass2" value="" runat="server" required />
                            <label for="pass2" class="form-label">Re-enter password</label>
                        </div>
                        <div class="form-group form-input">
                            <input type="number" name="phone" id="phone" value="" runat="server" required />
                            <label for="phone" class="form-label">Your phone number</label>
                        </div>
                        <div class="form-group">
                            <div class="select-list">
                                <select name="jenkel" id="jenkel" runat="server" required>
                                    <option value="">Jenis Kelamin</option>
                                    <option value="laki-laki">Laki-laki</option>
                                    <option value="perempuan">Perempuan</option>
                                </select>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="select-list">
                                <select name="instansi" id="instansi" runat="server" required>
                                    <option value="">Instansi</option>
                                    <option value="personal">Personal</option>
                                    <option value="company">Company</option>
                                </select>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="select-list" id="comboAgama" runat="server">
                                <select name="agama" id="agama" runat="server" required>
                                    <option value="">Agama</option>
                                    <option value="islam">Islam</option>
                                    <option value="kristen">Kristen</option>
                                    <option value="budha">Budha</option>
                                    <option value="conghucu">Conghucu</option>
                                    <option value="hindu">Hindu</option>
                                </select>
                            </div>
                        </div>
                        <div class="form-submit">
                           
                            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" CssClass="btn-primary" type="submit" OnClick="submit_Clik" />
                        </div>
                        <div class="hidden" runat="server" id="message_success">
                            <span style="margin-bottom: 10px" class="label label-success">Success!, Please wait after admin verification your account &nbsp;
                                <asp:LinkButton ID="messageRegister_fix"
                                    runat="server" OnClick="dissmissMessage_click" Style="text-decoration: none; color: white; font-size: 13px">&times;</asp:LinkButton></span>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <script src="Scripts/js_register/jquery.min.js"></script>
    <script src="Scripts/js_register/main.js"></script>
</body>
</html>
