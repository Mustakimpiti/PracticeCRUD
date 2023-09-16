<%@ Page Language="VB" AutoEventWireup="false" CodeFile="book.aspx.vb" Inherits="book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    &nbsp;&nbsp;&nbsp; 
        <table width="100%">
            <td align="center">

        `<table width="500px">
        <tr>
            <td colspan="2"><h1 style="font-family: Algerian">BOOK ENTRY</h1></td>
        </tr>
        <tr>
            <td>
                <h4 style="font-family: Algerian; background-color: #008080;">BOOK_ID</h4></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="required id" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
               <h4 style="font-family: Algerian; background-color: #008080;">BOOK_NAME</h4></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="PLEASE ENTER NAME" ControlToValidate="TextBox2"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <h4 style="font-family: Algerian; background-color: #008080;">AUTHOR</h4></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <h4 style="font-family: Algerian; background-color: #008080;">PUBLISHER</h4></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <h4 style="font-family: Algerian; background-color: #008080;">DATE_OF_PUBLISH</h4></td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <h4 style="font-family: Algerian; background-color: #008080;">PRICE</h4></td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <h4 style="font-family: Algerian; background-color: #008080;">NO_OF_PAGES</h4></td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><h4 style="font-family: Algerian; background-color: #008080;">CATEGORIES</h4></td>
        </tr>
        <tr>
            <td style="font-family: Algerian; background-color: #008080;">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="c" Text="facinity" /></td>
        </tr>
        <tr>
            <td style="font-family: Algerian; background-color: #008080;">
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="c" Text="horror" /></td>
        </tr>
        <tr>
            <td style="font-family: Algerian; background-color: #008080;">
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="c" Text="history" /></td>
        </tr>
        <tr>
            <td style="font-family: Algerian; background-color: #008080;">
                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="c" Text="cartoon" /></td>
        </tr>
        <tr>
            <td style="font-family: Algerian; background-color: #008080;">
                <asp:RadioButton ID="RadioButton5" runat="server" GroupName="c" Text="mystery" /></td>
        </tr>
        <tr>
            <td colspan="2" style="font-family: Algerian">
                <asp:Button ID="Button1" runat="server" Text="SUBMIT" BackColor="#006666" BorderStyle="Dashed" ForeColor="Black" />
            </td>
        </tr>
        
       
        
    </table>
                </td>
            </table>
    </form>
</body>
</html>
