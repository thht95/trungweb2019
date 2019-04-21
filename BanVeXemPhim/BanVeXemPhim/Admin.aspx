<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="BanVeXemPhim.Admin" %>

<%@ Register Src="~/QuanTri/Admin/AdminLoadControl.ascx" TagPrefix="uc2" TagName="AdminLoadControl" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Chủ</title>
        <link rel="stylesheet" href="css/owl.carousel.min.css" type="text/css" />
        <link rel="stylesheet" href="css/fontawesome.css" type="text/css" />   
        <link rel="stylesheet" href="css/fa-solid.css" type="text/css" />     s
        <link rel="stylesheet" href="css/bootstrap.min.css" type="text/css" />
        <link rel="stylesheet" href="css/StyleSheet1.css" type="text/css" />
</head>
<body>
    <div class="header-top">
        <div class="header-top-1" style="background-image: url(../images/header.jpg);"></div>
    </div>
    <div class="header">
                <div class="container">
            <div class="row">
                <div class="col-md-10">
                    <div class="nav">
                        <a class="nav-link" href="/Admin.aspx?md=themphim">THÊM PHIM</a>
                        <a class="nav-link" href="/Admin.aspx?md=suathongtinphim">SỬA THÔNG TIN PHIM</a>
                        <a class="nav-link" href="/Admin.aspx?md=chinhsualichchieu">CHỈNH SỬA LỊCH CHIẾU</a>
                        <a class="nav-link" href="/Admin.aspx?md=duyethoidap">DUYỆT HỎI ĐÁP</a> 
                        <a class="nav-link" href="/Admin.aspx?md=quanlytaikhoan">QUẢN LÝ TÀI KHOẢN</a> 
                    </div>     
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="form-1">
    <form id="form1" runat="server">
    <div>
        <uc2:AdminLoadControl runat="server" id="AdminLoadControl" />
    </div>
    </form>
    </div>
        </div>

    <div class="footer-top">
        <div class="container"></div>
    </div>
    <div class="footer">
        <div class="container">
            <div class="p-b-20">Rạp chiếu phim TRÙM CƯỜNG</div>
            <div class="">Liên hệ: 0962998893</div>
        </div>
    </div>

</body>
</html>
