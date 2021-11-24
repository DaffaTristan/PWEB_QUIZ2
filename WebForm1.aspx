<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PWEB_quiz2.WebForm1" %>

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
                    <h2 class="text-center">Account</h2>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <asp:Button ID="BtnLogout" OnClick="BtnLogout_Click" CssClass="top-buffer btn btn-outline-danger col-12 mt-4" runat="server" Text="Log Out" />
                </form>
            </div>
            <div class="col-md-4 col-sm-12"></div>
            
        </div>
    </div>
    <script src="bootstrap/js/bootstrap.min.js"></script>
</body>
</html>