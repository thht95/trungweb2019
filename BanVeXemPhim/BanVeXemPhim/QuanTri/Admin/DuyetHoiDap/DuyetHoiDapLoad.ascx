<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DuyetHoiDapLoad.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.DuyetHoiDap.DuyetHoiDapLoad" %>


<asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" OnRowCommand="GridView1_RowCommand">
                <Columns>
                 <asp:TemplateField HeaderText="Người gửi">
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("NguoiGui") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Thời gian">
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("ThoiGian") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                      <asp:TemplateField HeaderText="Nội Dung">
                    <ItemTemplate>
                         <asp:Label ID="Label2" runat="server" Text='<%#Eval("NoiDung") %>'></asp:Label>
                     </ItemTemplate>
                          </asp:TemplateField>
                           <asp:TemplateField HeaderText="Xử lý">
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CommandName="duyet" CommandArgument='<%#Eval("MaPhanHoi") %>' Text="Duyệt" />
                    <asp:Button ID="Button2" runat="server" CommandName="xoa" CommandArgument='<%#Eval("MaPhanHoi") %>' Text="Xóa" />
                </ItemTemplate>
                     </asp:TemplateField>
                     </Columns>
</asp:GridView>




