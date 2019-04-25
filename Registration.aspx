<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MonthlyBudget.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/Style.css"/>
    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnReg">
        <div class="MainDiv">
            <h1>Sign Up Now</h1>
            <div id="reg" class="Input">
                <asp:Label CssClass="lbReg" ID="lblUser" runat="server" Text="Username: "></asp:Label>
                <asp:TextBox CssClass="txtReg" ID="txtUsername" runat="server" Width="75px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required Field" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label CssClass="lbReg" ID="lbPass" runat="server" Text="Password: "></asp:Label>
                <asp:TextBox CssClass="txtReg" ID="txtPassWord" runat="server" Width="75px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassWord" ErrorMessage="Required Field" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label CssClass="lbReg" ID="lbVerify" runat="server" Text="Verify Password: "></asp:Label>
                <asp:TextBox CssClass="txtReg" ID="txtVerify" runat="server" Width="75px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtVerify" ErrorMessage="Required Field" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords do not match" ControlToValidate="txtVerify" ControlToCompare="txtPassWord" ForeColor="#FF5050"></asp:CompareValidator>
                <br />
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click" CausesValidation="false"/>
            <asp:Button ID="btnReg" runat="server" CssClass="btnReg" Text="Sign Up" OnClick="btnReg_Click" Width="75px"/> 
        </div>
    </form>
</body>
</html>
