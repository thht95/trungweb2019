<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="BanVeXemPhim.TrangChu" %>

<%@ Register Src="~/Nguoi Dung/NguoiDungLoad.ascx" TagPrefix="uc1" TagName="NguoiDungLoad" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Chủ</title>
        <link rel="stylesheet" href="css/owl.carousel.min.css" type="text/css" />
        <link rel="stylesheet" href="css/fontawesome.css" type="text/css" />   
        <link rel="stylesheet" href="css/fa-solid.css" type="text/css" />     
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
                        <a class="nav-link" href="/TrangChu.aspx?md=phim">PHIM</a>
                        <a class="nav-link" href="/TrangChu.aspx?md=lichchieu">LỊCH CHIẾU</a>
                        <a class="nav-link" href="/TrangChu.aspx?md=phanhoi">PHẢN HỒI</a> 
                    </div>     
                </div>
                <div class="col-md-2">
                    <a class="nav-link" href="Login.aspx">ĐĂNG NHẬP</a>
                </div>
            </div>
        </div>
    </div>
    <div class="container form-1">
    <form id="form1" runat="server">
    <div>
        <uc1:NguoiDungLoad runat="server" id="NguoiDungLoad" />
    </div>
    </form>
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
