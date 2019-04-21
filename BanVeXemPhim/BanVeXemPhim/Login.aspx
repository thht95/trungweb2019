<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BanVeXemPhim.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 295px;
        }
        .auto-style2 {
            width: 112px;
        }
        .auto-style3 {
            margin-left: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="padding-login">
  <table style="width:100%;">
        <tr>
            <td class="auto-style2">Tên Đăng Nhập</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenDangNhap" ForeColor="Red" ValidationGroup="lg">Vui Lòng Điền Tên Đăng Nhập</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style2">Mật Khẩu</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="lg">Vui Lòng Nhập Mật Khẩu</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            
            <td class="auto-style2">
                <asp:Button ID="btnDangNhap" runat="server" Text="Đăng Nhập" OnClick="btnDangNhap_Click" ValidationGroup="lg" />
            </td>
            <td>

                <asp:Button ID="btnThoat" runat="server" Text="Thoát" Width="96px" OnClick="btnThoat_Click" />

            </td>
        </tr>
 
    </table>           
    </div>
        <p>
        <asp:Button ID="btnDangKy" runat="server" Text="Đăng Ký" Width="93px" OnClick="btnDangKy_Click" CssClass="auto-style3" />
        </p>
    </form>
</body>
</html>
