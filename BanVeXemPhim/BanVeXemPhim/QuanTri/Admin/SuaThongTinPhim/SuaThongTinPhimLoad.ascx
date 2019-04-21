<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SuaThongTinPhimLoad.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.SuaThongTinPhim.SuaThongTinPhimLoad" %>
<asp:DataList ID="dtlSuaThongTinPhim" runat="server">
    <ItemTemplate>
        <tr>
            <td>Mã Phim</td>
            <td>Tên Phim</td>
            <td>Tùy Chỉnh</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("MaPhim") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("TenPhim") %>'></asp:Label>
            </td>
            <td>
                <a  href="/Admin.aspx?md=suathongtin&id=<%#Eval("MaPhim") %>">Sửa</a>
            </td>
        </tr>
    </ItemTemplate>
</asp:DataList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Ketnoi %>" SelectCommand="SELECT * FROM [Phim]"></asp:SqlDataSource>


