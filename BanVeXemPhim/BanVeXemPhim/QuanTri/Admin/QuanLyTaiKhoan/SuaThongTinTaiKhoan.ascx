<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SuaThongTinTaiKhoan.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.QuanLyTaiKhoan.SuaThongTinTaiKhoan" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    .auto-style2 {
        height: 23px;
        width: 169px;
    }
    .auto-style3 {
        width: 169px;
    }
    .auto-style4 {
        height: 23px;
        width: 590px;
    }
    .auto-style5 {
        width: 590px;
    }
</style>

<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">Tên Đăng Nhập</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3">Mật Khẩu</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Mã Quyền Sử Dụng</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtQuyenSuDung" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sửa" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Xóa" />
            </td>
            <td class="auto-style5">
                 <a  href="/Admin.aspx?md=quanlytaikhoan">Quay Lại</a>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>


