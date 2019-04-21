<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Phim.ascx.cs" Inherits="BanVeXemPhim.Nguoi_Dung.Phim.Phim" %>
&nbsp;<div>
            <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="4" Width="100%" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                <ItemTemplate>
                    <div>
                        <div>
                            <asp:Image ID="imgDT" runat="server" Height="109px" Width="212px" ImageUrl='<%# Eval("AnhUrl") %>' />
                        </div>
                        <div style="margin-left:0px">
                            <asp:Label ID="Label3" runat="server" Text='Tên Phim: '></asp:Label>
                            <asp:Label ID="lbTenDT" runat="server" Text='<%# Eval("TenPhim") %>'></asp:Label>
                        </div>
                        <div style="margin-left: 70px">
                            <a  href="/TrangChu.aspx?md=muave&id=<%# Eval("MaPhim") %>">Mua Vé</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
