<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SuaLichChieu.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.ChinhSuaLichChieu.SuaLichChieu" %>
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
            <td class="auto-style2">Mã Phòng</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtMaPhong" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3">Mã Phim</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMaPhim" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Giờ Chiếu</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtGioChieu" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Số Lượng Ghế Vip</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtSoLuongGheVip" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Số Lượng Ghế Thường</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtSoLuongGheThuong" runat="server"></asp:TextBox>
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
                 <a  href="/Admin.aspx?md=chinhsualichchieu">Quay Lại</a>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

