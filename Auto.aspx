<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auto.aspx.cs" Inherits="MonthlyBudget.Auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/Style.css"/>
    <title>Monthly Budget Calculator</title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button2">
        <div class="MainDiv">
            <h1>Monthly Budget Calculator</h1>
            <h3>Monthly Auto Expenses</h3>
            <img src="Images/StageTwo.PNG" />
            <div class="Input">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Car Payment: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox1" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Auto Insurance: "></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox2" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Gas/Fuel: "></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox3" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Auto Repairs: "></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox4" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                <br />
                <br />
            </div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" CausesValidation="false" />            
            <asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
