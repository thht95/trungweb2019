<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MuaVe.ascx.cs" Inherits="BanVeXemPhim.Nguoi_Dung.Phim.MuaVe" %>
<div class="padding-top-20">
<div class="row">
    <div class="col-md-3">
                    <asp:DataList ID="DataList1" runat="server">
                 <ItemTemplate>
                   <tr>                 
                            <asp:Image ID="images1" runat="server" Height="109px" Width="212px" ImageUrl='<%# Eval("AnhUrl") %>' />
                       <td><%#Eval("TenPhim") %>
                       </td>                     
                   </tr>
               </ItemTemplate>
            </asp:DataList>
    </div>
    <div class="col-md-9">
        <div class="">
<asp:DataList ID="DataList2" runat="server" Width="460px">
        <ItemTemplate>
        <tr>
            <td>Phòng Chiếu</td>
            <td>Giờ Chiếu</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("TenPhong") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("GioChieu") %>'></asp:Label>
            </td>
            <td>
                <a  href="/TrangChu.aspx?md=muavechitiet&id=<%# Eval("MaXuatChieu") %>">Mua Vé</a>
            </td>
        </tr>
    </ItemTemplate>
</asp:DataList>
            </div>

        </div>
    </div>
</div>
