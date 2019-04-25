<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="MonthlyBudget.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/Style.css"/>
    <title>Sign-In</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div  class="SignInDiv">
            <h1>Sign In</h1>
            <div id="Login" class="Login">
                <asp:Label CssClass="lblSign" ID="username" runat="server" Text="Username:"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="txtUserName" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label CssClass="lblSign" ID="Label1" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style1" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ControlToValidate="txtPassword" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label CssClass="lblErrorMsg" ID="lblErrorMessage" runat="server" Text="Incorrect User Credentials" ForeColor="#FF5050"></asp:Label>
                <br />
                <br />
                <asp:Button class="btnLogin" ID="btnLogin" runat="server" Text="Sign In" Width="113px" OnClick="btnLogin_Click" />
                <br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Registration.aspx">Sign-Up Now!</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
