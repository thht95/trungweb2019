<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="BanVeXemPhim.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            width: 142px;
        }
        .auto-style3 {
            width: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  <table style="width:100%;">
        <tr>
            <td class="auto-style2">Tên Đăng Nhập</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtTenDangNhap" runat="server" CssClass="auto-style1"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenDangNhap" ErrorMessage="Vui Lòng" ForeColor="Red" ValidationGroup="dk">Vui Lòng Nhập Tên Đăng Nhập</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Mật Khẩu</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="dk">Vui Lòng Nhập Mật Khẩu</asp:RequiredFieldValidator>
            </td>
        </tr>
              <tr>
            <td class="auto-style2">Họ Tên</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtHoTen" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="dk">Vui Lòng Nhập Họ Tên</asp:RequiredFieldValidator>
                  </td>
        </tr>
              <tr>
            <td class="auto-style2">CMND</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCMND" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCMND" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="dk">Vui Lòng Nhập CMND</asp:RequiredFieldValidator>
                  </td>
        </tr>
        <tr>
            
            <td class="auto-style2">
                <asp:Button ID="btnDangKy" runat="server" Text="Đăng Ký" OnClick="btnDangNhap_Click" style="height: 26px" />
            </td>
            <td class="auto-style3">

                <asp:Button ID="btnThoat" runat="server" Text="Thoát" Width="96px" OnClick="btnThoat_Click" />

            </td>
        </tr>
 
    </table>           
    </div>
    </form>
</body>
</html>
