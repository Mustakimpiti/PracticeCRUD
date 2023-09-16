<%@ Page Language="VB" AutoEventWireup="false" CodeFile="book_data.aspx.vb" Inherits="book_data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%">
            <td align="center">
        <table width="500px">
            <tr>
                <td colspan="4"><h4>BOOK_DATA</h4></td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="BOOK_ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="BOOK_NAME"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="AUTHOR"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="PUBLISHER"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="DATE_OF_PUBLISH"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="PRICE"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="NO_OF_PAGES"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="CATEGORIES"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="UPDATE" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="DELETE" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button3" runat="server" Text="FIRST" /><asp:Button ID="Button4" runat="server" Text="PREVIOUS" /><asp:Button ID="Button5" runat="server" Text="NEXT" /><asp:Button ID="Button6" runat="server" Text="LAST" /></td>
               
                 
            </tr>
        </table>
                </td>
        </table>
    
    </div>
    </form>
</body>
</html>
