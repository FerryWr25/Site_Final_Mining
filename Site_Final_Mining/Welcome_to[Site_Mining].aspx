<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome_to[Site_Mining].aspx.cs" Inherits="Site_Final_Mining.Welcome_to_Site_Mining_" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>MiningSite_Timeframe | frontPage</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <!-- Bootstrap 3.3.7 -->
    <link href="Other_component/frontPage/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Other_component/frontPage/vendor/fontawesome-free/css/all.min.css" rel="stylesheet" />
    <link href="Other_component/frontPage/vendor/magnific-popup/magnific-popup.css" rel="stylesheet" />
    <link href="Other_component/frontPage/css/creative.min2.css" rel="stylesheet" />
    <!-- Script -->

    <!-- Font Awesome -->
</head>
<body id="page-top">
    <form runat="server">
        <nav class="navbar navbar-expand-lg navbar-light fixed-top" id="mainNav">
            <div class="container">
                <a class="navbar-brand js-scroll-trigger" href="#page-top"><i class="fas fa-cat"></i>&nbsp;&nbsp;Site Time Frame </a>
                <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ml-auto">
                        <li class="nav-item">
                            <a class="nav-link js-scroll-trigger" href="#about"><i class="fas fa-caret-down"></i>&nbsp; About</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link js-scroll-trigger" href="#services"><i class="fas fa-caret-down"></i>&nbsp;Layanan</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link js-scroll-trigger" href="#portfolio"><i class="fas fa-caret-down"></i>&nbsp;Pengetahuan</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link js-scroll-trigger" href="#contact"><i class="fas fa-caret-down"></i>&nbsp;Contact</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <header class="masthead text-center text-white d-flex">
            <div class="container my-auto">
                <div class="row">
                    <div class="col-lg-10 mx-auto">
                        <h1 class="text-uppercase">
                            <strong>Temukan Informasi yang Anda Butuhkan</strong>
                        </h1>
                        <hr>
                    </div>
                    <div class="col-lg-8 mx-auto">
                        <p class="text-faded mb-5">Website dengan media pembelajaran pentingnya membaca. Informasi yang disediakan berdasarkan sumber yang terpercaya. selamat bergabung dengan kami</p>
                       
                        <asp:LinkButton CssClass="btn btn-primary btn-xl js-scroll-trigger" ID="registerKlik" OnClick="register_Click" runat="server">
                      Register Member <i class="fas fa-registered"></i></asp:LinkButton>

                        <asp:LinkButton CssClass="btn btn-success btn-xl js-scroll-trigger" ID="loginKlik" OnClick="loginClick" runat="server">
                      Login Member <i class="fas fa-user"></i></asp:LinkButton>

                    </div>
                </div>
            </div>
        </header>

        <section class="bg-primary" id="about">
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 mx-auto text-center">
                        <h2 class="section-heading text-white">Kami menemukan informasi yang anda perlukan!</h2>
                        <hr class="light my-4">
                        <p class="text-faded mb-4">Mempelajari suatu kejadian merupakan langkah awal anda untuk tetap selangkah lebih maju. Wujudkan indonesia menjadi negara dengan populasi yang masyarakatnya gemar membaca</p>
                        <a class="btn btn-light btn-xl js-scroll-trigger" href="#services">See Our Service!</a>
                    </div>
                </div>
            </div>
        </section>

        <section id="services">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <h2 class="section-heading">Layanan pada site time frame</h2>
                        <hr class="my-4">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-globe-asia text-primary mb-3 sr-icon-1"></i>
                            <h3 class="mb-3">Dokumen Berita</h3>
                            <p class="text-muted mb-0">Kami menyediakan berita dari situs berita dengan rating tertinggi diindonesia</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-search text-primary mb-3 sr-icon-2"></i>
                            <h3 class="mb-3">Cari Berita</h3>
                            <p class="text-muted mb-0">Kami menyediakan layanan untuk pencarian berita sesuai dengan kebutuhan anda</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-grin-beam text-primary mb-3 sr-icon-3"></i>
                            <h3 class="mb-3">Tampilan Menarik</h3>
                            <p class="text-muted mb-0">Kami mendesain website ini sedemikian baik, agar semakin nyaman membuat anda membaca informasi dan mencari informasi</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-chart-line text-primary mb-3 sr-icon-4"></i>
                            <h3 class="mb-3">Time Frame</h3>
                            <p class="text-muted mb-0">Kami memberikan suatu layanan bagi anda untuk mengetahui durasi kejadian pada pencarian anda dalam bentuk grafilk time series</p>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section class="bg-dark text-white">
            <div class="container text-center">
                <h2 class="mb-4">It's Time, Let's Join With Us!</h2>
                <asp:LinkButton CssClass="btn btn-light btn-xl sr-button" ID="reg2" OnClick="register_Click" runat="server">
                      Register Now! <i class="fas fa-registered"></i></asp:LinkButton>
            </div>

        </section>

        <section id="portfolio">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <h2 class="section-heading">Ilmu Pengetahuan</h2>
                        <hr class="my-4">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-search-plus text-primary mb-3 sr-icon-1"></i>
                            <h3 class="mb-3">Text<br>
                                Mining</h3>
                            <p class="text-muted mb-0">Teknik menemukan ekstraksi pola (informasi dan pengetahuan yang berguna) dari sejumlah besar sumber data tak terstruktur. Penambangan teks memiliki tujuan dan menggunakan proses yang sama dengan penambangan data.</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-database text-primary mb-3 sr-icon-2"></i>
                            <h3 class="mb-3">Information Retrieval</h3>
                            <p class="text-muted mb-0">Ilmu yang mempelajari prosedur-prosedur dan metode-metode untuk menemukan kembali informasi yang tersimpan dari berbagai sumber (resources) yang relevan atau koleksi sumber informasi yang dicari atau dibutuhkan.</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-vector-square text-primary mb-3 sr-icon-3"></i>
                            <h3 class="mb-3">Vector Space
                                <br>
                                Model</h3>
                            <p class="text-muted mb-0">Ilmu yang mempelajari tentang model yang digunakan untuk mengukur kemiripan antara suatu dokumen dengan suatu query. Query dan dokumen dianggap sebagai vektor-vektor pada ruang n-dimensi, dimana t adalah jumlah dari seluruh term yang ada dalam leksikon.</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="service-box mt-5 mx-auto">
                            <i class="fas fa-4x fa-american-sign-language-interpreting text-primary mb-3 sr-icon-4"></i>
                            <h3 class="mb-3">Cosine
                                <br>
                                Similarity</h3>
                            <p class="text-muted mb-0">Ilmu yang mempelajari untuk membandingkan kemiripan antar dokumen, dalam hal ini yang dibandingkan adalah query dengan dokumen berita</p>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section class="bg-dark text-white">
            <div class="container text-center">
                <h2 class="mb-4">It's Time, Let's Join With Us!</h2>
                <asp:LinkButton CssClass="btn btn-light btn-xl sr-button" ID="reg3" OnClick="register_Click" runat="server">
                      Register Now! <i class="fas fa-registered"></i></asp:LinkButton>
            </div>
        </section>

        <section id="contact">
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 mx-auto text-center">
                        <h2 class="section-heading">Let's Get In Touch!</h2>
                        <hr class="my-4">
                        <p class="mb-5">Ready to start with us? That's great! Give us a call or send us an email and we will get back to you as soon as possible!</p>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-4 ml-auto text-center">
                        <i class="fas fa-phone fa-3x mb-3 sr-contact-1"></i>
                        <p>0899-1087-383</p>
                    </div>
                    <div class="col-lg-4 mr-auto text-center">
                        <i class="fas fa-envelope fa-3x mb-3 sr-contact-2"></i>
                        <p>
                            ferrywr25@gmail.com
                        </p>
                    </div>
                </div>
            </div>
        </section>
        <script src="Other_component/frontPage/vendor/jquery/jquery.min.js"></script>
        <script src="Other_component/frontPage/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
        <script src="Other_component/frontPage/vendor/jquery-easing/jquery.easing.min.js"></script>
        <script src="Other_component/frontPage/vendor/scrollreveal/scrollreveal.min.js"></script>
        <script src="Other_component/frontPage/vendor/magnific-popup/jquery.magnific-popup.min.js"></script>
        <script src="Other_component/frontPage/js/creative.min.js"></script>
    </form>
</body>
</html>

