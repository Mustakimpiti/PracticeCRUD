<%@ Page Language="VB" AutoEventWireup="false" CodeFile="menu.aspx.vb" Inherits="menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 112px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%">
            <td align="center" class="auto-style2">
                <table>
                   <tr>
                       <td colspan="2"> <h1 style="font-family: Algerian; background-color: #008080;">MENU PAGE OF BOOK MANAGEMENT</h1></td>
                   </tr> 
                    <tr>
                        <td></td>
                         </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/book.aspx">BOOK ENTRY</asp:HyperLink>

                        </td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/book_data.aspx">BOOK_DATA</asp:HyperLink></td>
                    </tr>
                </table>

            </td>

        </table>
    
    </div>
    </form>
</body>
</html>
