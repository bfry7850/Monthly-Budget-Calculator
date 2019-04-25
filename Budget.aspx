<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Budget.aspx.cs" Inherits="MonthlyBudget.Budget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/Style.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button1">
        <div class="MainDiv">
            <h1>Monthly Budget Calculator</h1>
            <h3>Monthly Budget</h3>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <div class="GridDiv" id="GridDiv">

            <asp:GridView  HorizontalAlign="Center" CssClass="Grid" ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" DataKeyNames="ExpenseType" DataSourceID="ExpensesData" ForeColor="Black" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="ExpenseType" HeaderText="Expense Type" ReadOnly="True" SortExpression="ExpenseType" />
                    <asp:BoundField DataField="ExpenseAmount" HeaderText="Expense Amount" SortExpression="ExpenseAmount" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:SqlDataSource ID="ExpensesData" runat="server" ConnectionString="<%$ ConnectionStrings:ExpensesData %>" SelectCommand="SELECT [ExpenseType], [ExpenseAmount] FROM [Expenses] ORDER BY [id]"></asp:SqlDataSource>            
            
            </div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Get Budget" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="btnNext" runat="server" Text="Home" OnClick="btnNext_Click" />
        </div>
    </form>
</body>
</html>
