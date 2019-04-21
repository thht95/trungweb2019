<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LichChieu.ascx.cs" Inherits="BanVeXemPhim.Nguoi_Dung.LichChieu.LichChieu" %>
<div class="padding-top-20">
<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" SelectedDate="2018-11-13" ShowGridLines="True" Width="220px">
    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
    <OtherMonthDayStyle ForeColor="#CC9966" />
    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
    <SelectorStyle BackColor="#FFCC66" />
    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
</asp:Calendar>
<table>
    <tr>
        <td>
            <asp:TextBox ID="txtNgay" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="Chọn Ngày" OnClick="Button2_Click" />
            <asp:Button ID="Button1" runat="server" Text="Tìm" OnClick="Button1_Click" Width="86px" />
        </td>
    </tr>
</table>
</div>
<asp:DataList ID="DataList1" runat="server" Width="773px">
                    <ItemTemplate>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text='Tên Phim'></asp:Label></td>
                            <td><asp:Label ID="Label2" runat="server" Text='Giờ Chiếu'></asp:Label></td>
                            <td><asp:Label ID="Label4" runat="server" Text='Phòng Chiếu'></asp:Label></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label5" runat="server" Text='<%# Eval("TenPhim") %>'></asp:Label></td>
                            <td><asp:Label ID="Label6" runat="server" Text='<%# Eval("GioChieu") %>'></asp:Label></td>
                            <td><asp:Label ID="Label7" runat="server" Text='<%# Eval("TenPhong") %>'></asp:Label></td>
                            <td><a  href="/TrangChu.aspx?md=muavechitiet&id=<%# Eval("MaXuatChieu") %>">Mua Vé</a></td>
                        </tr>
                </ItemTemplate>
</asp:DataList>