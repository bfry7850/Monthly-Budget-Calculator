 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MonthlyBudget.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/Style.css"/>
    <title>Monthly Budget Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="MainDiv">
            <h1>Monthly Budget Calculator</h1>
            <h3>Monthly Income</h3>
            <img src="Images/StageOne.PNG" />
            <div class="Input">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Income/Wages: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox1" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Other Income: "></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox2" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
            </div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>