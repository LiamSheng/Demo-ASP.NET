<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApp.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 93px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td class="style1">
                    Username
                </td>
                <td>
                    <asp:TextBox ID="tb_username" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Password
                </td>
                <td>
                    <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Name
                </td>
                <td>
                    <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Address</td>
                <td>
                    <asp:TextBox ID="tb_address" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Gender</td>
                <td>
                    <asp:DropDownList ID="ddl_sex" runat="server">
                        <asp:ListItem Selected="True" Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="0">Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Mobile</td>
                <td>
                    <asp:TextBox ID="tb_mobile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    E-mail</td>
                <td>
                    <asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    SocialNumber</td>
                <td>
                    <asp:TextBox ID="tb_socialNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    
                </td>
                <td>
                    <asp:Button ID="btn_register" runat="server" Text="Register!" 
                        onclick="btn_register_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
