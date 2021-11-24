<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PWEB_quiz2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="additional-file/css/global.css" rel="stylesheet" />
</head>
<body>
    <div class="container-fluid bg">
        <div class="row">
            <div class="col-md-4 col-sm-12"></div>
            <div class="col-md-4 col-sm-12">
                <form class="container-form text-white" runat="server">
                    <h2 class="text-center">Form Log In</h2>
                  <div class="top-buffer form-group">
                    <label class="text-white" for="exampleInputEmail1">Email address</label>
                      <asp:TextBox ID="TxtEmail"  CssClass="form-control" placeholder="Enter email" runat="server"></asp:TextBox>
                  </div>
                  <div class="top-buffer form-group">
                    <label class="text-hwite" for="exampleInputPassword1">Password</label>
                      <asp:TextBox ID="TxtPassword" TextMode="Password" CssClass="form-control" placeholder="Enter password" runat="server"></asp:TextBox>
                  </div>
                    <asp:Button ID="BtnLogin" OnClick="BtnLogin_Click" CssClass="top-buffer btn btn-outline-danger col-12 mt-4" runat="server" Text="Log In" />
                    <asp:Button ID="BtnSignup" OnClick="BtnSignup_Click" CssClass="top-buffer btn btn-warning col-12 mt-4" runat="server" Text="Sign Up"/>
                    <asp:Label ID="LblWarning" CssClass="text-white fw-bold" Visible="false" runat="server" Text="--"></asp:Label>
                </form>
            </div>
            <div class="col-md-4 col-sm-12"></div>
            
        </div>
    </div>

    <script src="bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
