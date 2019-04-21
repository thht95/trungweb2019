<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuanLyTaiKhoanLoad.ascx.cs" Inherits="BanVeXemPhim.QuanTri.Admin.QuanLyTaiKhoan.QuanLyTaiKhoanLoad" %>
<style type="text/css">

    .auto-style2 {
        height: 23px;
        width: 169px;
    }
    .auto-style4 {
        height: 23px;
        width: 590px;
    }
    .auto-style3 {
        width: 169px;
    }
    .auto-style5 {
        width: 590px;
    }
</style>
&nbsp;<asp:DataList ID="dtlQuanLyTaiKhoan" runat="server" Width="943px">
            <ItemTemplate>
        <tr>
            <td>Mã Đăng Nhập</td>
            <td>Tên Đăng Nhập</td>
            <td>Mật Khẩu</td>
            <td>Quyền Sử Dụng</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("MaDangNhap") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("TenDangNhap") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text='<%#Eval("MatKhau") %>'></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text='<%#Eval("QuyenSuDung") %>'></asp:Label>
            </td>
            <td>
                <a  href="/Admin.aspx?md=suathongtintaikhoan&id=<%#Eval("MaDangNhap") %>">Sửa</a>
            </td>
        </tr>
    </ItemTemplate>
</asp:DataList>

<p>
    &nbsp;</p>
    <table style="width:100%;">
                <tr>
            <td class="auto-style2">Mã Đăng Nhập</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtMaDangNhap" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Tên Đăng Nhập</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mật Khẩu</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mã Quyền Sử Dụng</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtQuyenSuDung" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>


<p>
    <asp:Label ID="lbMaPhim" runat="server" ForeColor="Red"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Thêm" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Thoát" />
</p>



