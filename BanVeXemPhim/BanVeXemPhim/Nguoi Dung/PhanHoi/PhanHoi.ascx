<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PhanHoi.ascx.cs" Inherits="BanVeXemPhim.Nguoi_Dung.PhanHoi.PhanHoi" %>
<div class="row">
    <div class="col-md-6">
        <div class="padding-top-20">
<asp:Label ID="Label5" runat="server" Text="Tên"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="auto-style1"></asp:TextBox>
</div>

<br />
<br />


<p>
    Nội Dung</p>
<p>
    <asp:TextBox ID="TextBox2" runat="server" Height="82px" Width="333px"></asp:TextBox>
<p>
    <asp:Button ID="Button2" runat="server" Text="Gửi Phản Hồi" OnClick="Button1_Click" />
</p>
<p>
    &nbsp;</p>
    </div>
    <div class="col-md-6">
        <asp:DataList ID="DataList1" runat="server" Width="290px">
    <ItemTemplate>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text='<%# Eval("NguoiGui") %>'></asp:Label></td>

        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text='<%# Eval("NoiDung") %>'></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label4" runat="server" Text='<%# Eval("ThoiGian") %>'></asp:Label></td>
        </tr>
    </ItemTemplate>
</asp:DataList>

    </div>
</div>
<style type="text/css">
    .auto-style1 {
        margin-left: 23px;
    }
    </style>



