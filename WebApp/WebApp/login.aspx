<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApp.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 124px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 415px">
            <tr>
                <td class="style1">
                    Username
                </td>
                <td>
                    <asp:TextBox ID="tb_reg_username" runat="server" Width="276px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Password
                </td>
                <td>
                    <asp:TextBox ID="tb_reg_password" runat="server" Width="276px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                </td>
                <td>
                    <asp:Button ID="btn_Login" runat="server" Text="Login!" 
                        onclick="btn_Login_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
