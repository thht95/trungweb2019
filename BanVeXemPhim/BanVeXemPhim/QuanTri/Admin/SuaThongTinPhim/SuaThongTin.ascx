<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SuaThongTin.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.SuaThongTinPhim.SuaThongTin" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    .auto-style2 {
        height: 23px;
        width: 152px;
    }
    .auto-style3 {
        width: 152px;
    }
</style>

<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">Mã Phim</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtMaPhim" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3">Tên Phim</td>
            <td>
                <asp:TextBox ID="txtTenPhim" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sửa" />
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Xóa" />
            </td>
            <td>
                 <a  href="/Admin.aspx?md=suathongtinphim">Quay Lại</a>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</p>
<p>
    &nbsp;</p>

