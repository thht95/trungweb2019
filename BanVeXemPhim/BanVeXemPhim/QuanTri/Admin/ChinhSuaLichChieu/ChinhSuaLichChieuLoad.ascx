<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChinhSuaLichChieuLoad.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.ChinhSuaLichChieu.ChinhSuaLichChieuLoad" %>


<style type="text/css">
    .auto-style1 {
        margin-left: 79px;
    }
    .auto-style2 {
        margin-left: 86px;
    }
    .auto-style3 {
        margin-left: 81px;
    }
    .auto-style4 {
        margin-left: 24px;
    }
    .auto-style5 {
        margin-left: 44px;
    }
</style>


<asp:DataList ID="dtlChinhSuaLichChieu" runat="server">
        <ItemTemplate>
        <tr>
            <td>Mã Xuất Chiếu</td>
            <td>Tên Phòng</td>
            <td>Tên Phim</td>
            <td>Giờ Chiếu</td>
            <td>Số Lượng Ghế Vip</td>
            <td>Số Lượng Ghế Thường</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("MaXuatChieu") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("IDMaPhong") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text='<%#Eval("IDMaPhim") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text='<%#Eval("GioChieu") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text='<%#Eval("SoLuongGheVip") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text='<%#Eval("SoLuongGheThuong") %>'></asp:Label>
            </td>
            <td>
                <a  href="/Admin.aspx?md=sualichchieu&id=<%#Eval("MaXuatChieu") %>">Sửa</a>
            </td>
            <td>
                <a  href="/Admin.aspx?md=xoalichchieu&id=<%#Eval("MaXuatChieu") %>">Xóa</a>
            </td>
        </tr>
    </ItemTemplate>
</asp:DataList>
<p>
    Mã Xuất Chiếu:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtMaXuatChieu" runat="server" Width="116px" CssClass="auto-style5"></asp:TextBox>
</p>
<p>
    Mã&nbsp; Phòng:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtTenPhong" runat="server" CssClass="auto-style1"></asp:TextBox>
</p>
<p>
    Mã Phim:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtTenPhim" runat="server" CssClass="auto-style2"></asp:TextBox>
</p>
<p>
    Giờ Chiếu:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtGioChieu" runat="server" CssClass="auto-style3"></asp:TextBox>
</p>
<p>
    Số Lượng Ghế Vip:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSoLuongGheVip" runat="server" CssClass="auto-style4"></asp:TextBox>
</p>
<p>
    Số Lượng Ghế Thường:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSoLuongGheThuong" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Thêm Xuất Chiếu" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>





