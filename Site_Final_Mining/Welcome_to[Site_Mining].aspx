<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome_to[Site_Mining].aspx.cs" Inherits="Site_Final_Mining.Welcome_to_Site_Mining_" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>MiningSite_Timeframe | frontPage</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="icon" href="admin-lte/img/Research.ico" />
    <!-- Bootstrap 3.3.7 -->
    <link href="Content/css_frontPage/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="Content/font-awesome.min.css">
    <link href="Content/css_frontPage/animate.css" rel="stylesheet" />
    <link href="Content/css_frontPage/owl.carousel.css" rel="stylesheet" />
    <link href="Content/css_frontPage/style.css" rel="stylesheet" />
    <link href="Content/css_frontPage/footer-distributed-with-address-and-phones.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body>
    <form runat="server">
        <div id="preloder">
            <div class="loader"></div>
        </div>

        <!-- Header section start -->
        <header class="header-area">
            <a href="home.html" class="logo-area">
                <img src="admin-lte/img/img_frontPage/logo.png" />
            </a>
            <div class="nav-switch">
                <i class="fa fa-bars"></i>
            </div>
            <div class="phone-number">+675 334 567 223</div>
            <nav class="nav-menu">
                <ul>
                    <li class="active"><a href="home.html">Home</a></li>
                    <li><a href="about.html">About us</a></li>
                    <li><a href="service.html">Services</a></li>
                    <li>
                        <asp:LinkButton ID="loginKlik" OnClick="loginClick" runat="server">
                      Login</asp:LinkButton>
                    </li> 
                </ul>
            </nav>
        </header>
        <!-- Header section end -->


        <!-- Hero section start -->
        <section class="hero-section">
            <!-- left social link ber -->
            <div class="left-bar">
                <div class="left-bar-content">
                    <div class="social-links">
                        <a href="#"><i class="fa fa-pinterest"></i></a>
                        <a href="#"><i class="fa fa-linkedin"></i></a>
                        <a href="#"><i class="fa fa-instagram"></i></a>
                        <a href="#"><i class="fa fa-facebook"></i></a>
                        <a href="#"><i class="fa fa-twitter"></i></a>
                    </div>
                </div>
            </div>
            <!-- hero slider area -->
            <div class="hero-slider">
                <div class="hero-slide-item set-bg" data-setbg="admin-lte/img/ff.jpg">
                    <div class="slide-inner">
                        <div class="slide-content">
                            <h2>Minimalistic
                                <br>
                                Architecture
                                <br>
                                and more</h2>
                            <a href="#" class="site-btn sb-light">See Project</a>
                        </div>
                    </div>
                </div>
               <div class="hero-slide-item set-bg" data-setbg="admin-lte/img/cc.jpg"">
                    <div class="slide-inner">
                        <div class="slide-content">
                            <h2>Minimalistic
                                <br>
                                Architecture
                                <br>
                                and more</h2>
                            <a href="#" class="site-btn sb-light">See Project</a>
                        </div>
                    </div>
                </div>
                <div class="hero-slide-item set-bg" data-setbg="admin-lte/img/ee.jpg"">
                    <div class="slide-inner">
                        <div class="slide-content">
                            <h2>Minimalistic
                                <br>
                                Architecture
                                <br>
                                and more</h2>
                            <a href="#" class="site-btn sb-light">See Project</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="slide-num-holder" id="snh-1"></div>
            <div class="hero-right-text">architecture</div>
        </section>
        <!-- Hero section end -->


        <!-- Intro section start -->
        <section class="intro-section pt100 pb50">
            <div class="container">
                <div class="row">
                    <div class="col-lg-7 intro-text mb-5 mb-lg-0">
                        <h2 class="sp-title">We are a creative Architecture<span>Studio</span></h2>
                        <p>Pellentesque lorem dolor, malesuada eget tortor vitae, tristique lacinia lectus. Pellentesque sed accumsan risus, id aliquam nulla. Integer lorem risus, feugiat at mauris malesuada, accumsan pellentesque ipsum. Nunc dapibus, libero ut pulvinar accumsan, tortor nisl iaculis ligula. Curabitur finibus dolor vel lectus pretium interdum a eget ante. Morbi rhoncus feugiat imperdiet. Curabitur non maximus leo. Nulla in ipsum sed magna egestas bibendum. Integer in sem sagittis, commodo mi sit amet, commodo nibh. Suspendisse potenti. Aliquam erat volutpat. </p>
                        <a href="#" class="site-btn sb-dark">See Project</a>
                    </div>
                    <div class="col-lg-5 pt-4">
                        <img src="admin-lte/img/cc.jpg" />
                    </div>
                </div>
            </div>
        </section>
        <!-- Intro section end -->


        <!-- Service section start -->
        <section class="service-section spad">
            <div class="container">
                <div class="section-title">
                    <h2>Services</h2>
                </div>
                <div class="row">
                    <div class="col-lg-4 col-md-6">
                        <div class="service-box">
                            <div class="sb-icon">
                                <div class="sb-img-icon">
                                    <img src="admin-lte/img/img_frontPage/icon/dark/1.png" />
                                </div>
                            </div>
                            <h3>Plans and Projects</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed dui eget lorem tincidunt.</p>
                            <a href="#" class="readmore">READ MORE</a>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="service-box">
                            <div class="sb-icon">
                                <div class="sb-img-icon">
                                    <img src="admin-lte/img/img_frontPage/icon/dark/2.png" />
                                </div>
                            </div>
                            <h3>Conceptual Architecture</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed dui eget lorem tincidunt.</p>
                            <a href="#" class="readmore">READ MORE</a>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="service-box">
                            <div class="sb-icon">
                                <div class="sb-img-icon">
                                    <img src="admin-lte/img/img_frontPage/icon/dark/3.png" />
                                </div>
                            </div>
                            <h3>Apartment Buildings</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed dui eget lorem tincidunt.</p>
                            <a href="#" class="readmore">READ MORE</a>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="service-box">
                            <div class="sb-icon">
                                <div class="sb-img-icon">
                                    <img src="admin-lte/img/img_frontPage/icon/dark/4.png" />
                                </div>
                            </div>
                            <h3>Skyscrapers Buildings</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed dui eget lorem tincidunt.</p>
                            <a href="#" class="readmore">READ MORE</a>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="service-box">
                            <div class="sb-icon">
                                <div class="sb-img-icon">
                                    <img src="admin-lte/img/img_frontPage/icon/dark/5.png" />
                                </div>
                            </div>
                            <h3>Documentation</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed dui eget lorem tincidunt.</p>
                            <a href="#" class="readmore">READ MORE</a>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="service-box">
                            <div class="sb-icon">
                                <div class="sb-img-icon">
                                    <img src="admin-lte/img/img_frontPage/icon/dark/6.png" />
                                </div>
                            </div>
                            <h3>Restauration Projects</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed dui eget lorem tincidunt.</p>
                            <a href="#" class="readmore">READ MORE</a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Service section end -->



        <!-- CTA section start -->
        <section class="cta-section pt100 pb50">
            <div class="cta-image-box"></div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-7 pl-lg-0 offset-lg-5 cta-content">
                        <h2 class="sp-title">Dare to dream of a modern <span>home</span></h2>
                        <p>Pellentesque lorem dolor, malesuada eget tortor vitae, tristique lacinia lectus. Pellentesque sed accumsan risus, id aliquam nulla. Integer lorem risus, feugiat at mauris malesuada, accumsan pellentesque ipsum. Nunc dapibus, libero ut pulvinar accumsan, tortor nisl iaculis ligula. Curabitur finibus dolor vel lectus pretium interdum a eget ante. </p>
                        <div class="cta-icons">
                            <div class="cta-img-icon">
                                <img src="admin-lte/img/img_frontPage/icon/light/1.png" />
                            </div>
                            <div class="cta-img-icon">
                                <img src="admin-lte/img/img_frontPage/icon/light/2.png" />
                            </div>
                            <div class="cta-img-icon">
                                <img src="admin-lte/img/img_frontPage/icon/color/3.png" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- CTA section end -->


        <!-- Milestones section Start -->

        <!-- Clients section end -->


        <!-- Footer section start -->
        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->

        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->

        <footer class="footer-distributed">

            <div class="footer-left">

                <h3>Company<span>logo</span></h3>

                <p class="footer-links">
                    <a href="#">Home</a>
                    ·
					<a href="#">Blog</a>
                    ·
					<a href="#">Pricing</a>
                    ·
					<a href="#">About</a>
                    ·
					<a href="#">Faq</a>
                    ·
					<a href="#">Contact</a>
                </p>

                <p class="footer-company-name">Company Name &copy; 2015</p>
            </div>

            <div class="footer-center">

                <div>
                    <i class="fa fa-map-marker"></i>
                    <p><span>21 Revolution Street</span> Paris, France</p>
                </div>

                <div>
                    <i class="fa fa-phone"></i>
                    <p>+1 555 123456</p>
                </div>

                <div>
                    <i class="fa fa-envelope"></i>
                    <p><a href="mailto:support@company.com">support@company.com</a></p>
                </div>

            </div>

            <div class="footer-right">

                <p class="footer-company-about">
                    <span>About the company</span>
                    Lorem ipsum dolor sit amet, consectateur adispicing elit. Fusce euismod convallis velit, eu auctor lacus vehicula sit amet.
                </p>

                <div class="footer-icons">

                    <a href="#"><i class="fa fa-facebook"></i></a>
                    <a href="#"><i class="fa fa-twitter"></i></a>
                    <a href="#"><i class="fa fa-linkedin"></i></a>
                    <a href="#"><i class="fa fa-github"></i></a>

                </div>

            </div>

        </footer>
        <!-- Footer section end -->
        <!--====== Javascripts & Jquery ======-->
        <script src="Scripts/js_frontPage/jquery-2.1.4.min.js"></script>
        <script src="Scripts/js_frontPage/bootstrap.min.js"></script>
        <script src="Scripts/js_frontPage/isotope.pkgd.min.js"></script>
        <script src="Scripts/js_frontPage/owl.carousel.min.js"></script>
        <script src="Scripts/js_frontPage/jquery.owl-filter.js"></script>
        <script src="Scripts/js_frontPage/magnific-popup.min.js"></script>
        <script src="Scripts/js_frontPage/circle-progress.min.js"></script>
        <script src="Scripts/js_frontPage/main.js"></script>
    </form>
</body>
</html>

