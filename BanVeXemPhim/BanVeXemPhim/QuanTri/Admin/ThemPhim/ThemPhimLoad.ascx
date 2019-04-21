<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThemPhimLoad.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.ThemPhim.ThemPhimLoad" %>

<asp:GridView ID="grvThemPhim" runat="server" Height="156px" Width="457px">
</asp:GridView>
<p>
    Mã Phim:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtMaPhim" runat="server" Width="116px"></asp:TextBox>
</p>
<p>
    Tên Phim:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtTenPhim" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbMaPhim" runat="server" ForeColor="Red" Text=""></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Thêm" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Thoát" />
</p>

