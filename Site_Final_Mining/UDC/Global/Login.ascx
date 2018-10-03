<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Site_Final_Mining.UDC.Login.Login" %>

<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<section class="content">
    <!-- Info boxes -->
    <div class="sub-main-w3">
        <form runat="server" action="#" method="post">
            <div class="form-group">
                <label for="exampleInputEmail1">Email address</label>
                <input type="email" class="form-control" name="email" id="email" aria-describedby="emailHelp" placeholder="Enter email here" required runat="server">
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password</label>
                <input maxlength="10" minlength="3" type="password" name="name" class="form-control" id="password" placeholder="Enter password here"
                    required runat="server">
            </div>
            <div class="form-group">
                <label class="checkbox-inline">
                    <input type="checkbox" value="true" required>I agree to the terms and conditions
                </label>
            </div>
            <div class="form-group has-feedback">
                <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" CssClass="btn-primary" type="submit" OnClick="Masuk_Click" />
            </div>
        </form>
    </div>
</section>
