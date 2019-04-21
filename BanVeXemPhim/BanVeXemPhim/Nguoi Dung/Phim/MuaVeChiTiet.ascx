<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MuaVeChiTiet.ascx.cs" Inherits="BanVeXemPhim.Nguoi_Dung.Phim.MuaVeChiTiet" %>
                    <asp:DataList ID="DataList1" runat="server" Width="901px">
                 <ItemTemplate>
                   <tr>                 
                       <td>Tên Phim: <asp:Label ID="lbTenPhim" runat="server" Text=<%#Eval("TenPhim") %> ></asp:Label> </td>
                       <td>Phòng Chiếu: <asp:Label ID="lbTenPhongChieu" runat="server" Text=<%#Eval("TenPhong") %> ></asp:Label></td>
                       <td>Giờ Chiếu:  <asp:Label ID="lbGioChieu" runat="server" Text=<%#Eval("GioChieu") %> ></asp:Label> </td>
                       <td>Ghế Vip: <asp:CheckBox ID="CheckBox2" runat="server"/></td>                                        
                   </tr>
               </ItemTemplate>
            </asp:DataList>
<asp:Button ID="Button1" runat="server" Text="Mua" OnClick="Button1_Click1" Width="51px" Padding-right="20px" />
<asp:Button ID="Button2" runat="server" Text="Thoát" OnClick="Button2_Click" />

