<!-- ko with: home -->
@*<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
    <p><a href="http://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>
<div class="row">
    <div class="col-md-4">
        <h2>Your information</h2>
        <p>This section shows how you can call ASP.NET Web API to get the user details.</p>
        <p data-bind="text: myHometown"></p>
       
        <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=273732">Learn more &raquo;</a></p>
    </div>

    <div class="col-md-4">
        <h2>Getting started</h2>
        <p>
            ASP.NET Single Page Application (SPA) helps you build applications that include significant client-side interactions using HTML, CSS, and JavaScript.
            It's now easier than ever before to getting started writing highly interactive web applications.
        </p>
        <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=273732">Learn more &raquo;</a></p>
    </div>

    <div class="col-md-4">
        <h2>Web Hosting</h2>
        <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
        <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
    </div>
</div>*@

<!-- /ko -->
<div class="navbar navbar-fixed-top visible-lg">
    <div class="container">
        <div class="navbar-collapse collapse">
            @Html.Partial("_LoginPartial")
        </div>
    </div>
</div>
<!-- Outer Container -->
<div id="outer-container">
    <!-- Left Sidebar -->
    <section id="left-sidebar">

        <div class="logo">
            <a href="#intro" class="link-scroll"><span class="fa fa-newspaper-o btn-lg" style="width:100%"></span>TFN | Keep in Touch</a>
        </div><!-- .logo -->
        <!-- Menu Icon for smaller viewports -->
        <div id="mobile-menu-icon" class="visible-xs" onClick="toggle_main_menu();"><span class="glyphicon glyphicon-th"></span></div>
        <ul id="main-menu">
            <li id="menu-item-text" class="menu-item scroll"><a href="#text">The Latest News</a></li>
            <li id="menu-item-contact" class="menu-item scroll"><a href="#contact">Status Update</a></li>
            <li id="menu-item-featured" class="menu-item scroll"><a href="#featured">Photos</a></li>
            <li id="menu-item-tabs" class="menu-item scroll"><a href="#tabs">Threads</a></li>
            <li id="menu-item-carousel" class="menu-item scroll"><a href="#carousel">Members</a></li>
            <li id="menu-item-grid" class="menu-item scroll"><a href="#grid">About TFN</a></li>
        @If Request.IsAuthenticated Then
            @<li class="menu-item scroll hidden-lg"><a href="javascript:sessionStorage.removeItem('accessToken');$('#logoutForm').submit();">Log off</a></li>
        End If
        </ul><!-- #main-menu -->
    </section><!-- #left-sidebar -->
    <!-- end: Left Sidebar -->
    <section id="main-content" class="clearfix">

            <article id="intro" class="section-wrapper clearfix" data-custom-background-img="/assets/images/other_images/bg5.jpg">
                <div class="content-wrapper clearfix wow fadeInDown" data-wow-delay="0.3s">
                    <div class="col-sm-10 col-md-9 pull-right">
                        <section class="feature-text">
                            <h1>The Family News</h1>
                            <p>Keep in touch with your famaily with direct messages, photos, ideas, and group conversations.</p>
                            <p>
                                <a href="#text" class="link-scroll btn btn-outline-inverse btn-lg">the latest news</a>
                            </p>
                        </section>
                    </div><!-- .col-sm-10 -->
                </div><!-- .content-wrapper -->
            </article><!-- .section-wrapper -->
            <article id="text" class="section-wrapper clearfix" data-custom-background-img="/assets/images/other_images/bg1.jpg">
                <div class="content-wrapper clearfix">
                    <div class="col-sm-10 col-md-9 pull-right">
                        <h1 class="section-title">The Latest News</h1>
                        <p class="feature-paragraph"><img data-img-src="/assets/images/other_images/transp-image5b.png" class="lazy pull-right" alt="Lorem Ipsum">Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. <a href="#carousel">Suspendisse molestie lorem odio</a>, sit amet. Laoreet consequat. Duis dictum lorem metus, vitae dapibus.</p>
                        <h4>Duis dictum lorem metus</h4>
                        <p>Suspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio. Etiam scelerisque lacus tempor, rhoncus diam vel, gravida felis. Fusce tristique sem et leo. Pellentesque sed malesuada turpis. Quisque eget lacus sit amet dui.</p>
                        <p><a href="" onclick="populate_and_open_modal(event, 'modal-content-1');" class="btn btn-outline-inverse btn-sm">read all the news</a></p>

                        <div class="content-to-populate-in-modal" id="modal-content-1">
                            <h1>Lorem Ipsum</h1>
                            <p><img data-img-src="/assets/images/other_images/transp-image4.png" class="lazy rounded_border hover_effect pull-right" alt="Lorem Ipsum">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in urna vel ante mollis tincidunt. Donec nec magna condimentum tortor laoreet lobortis. Nunc accumsan sapien eu tortor fringilla, et condimentum metus pellentesque. Maecenas rhoncus tortor nec mi congue aliquet. Integer eu turpis scelerisque, iaculis magna non, tempor sem. Quisque consectetur nisi eu felis euismod, sit amet faucibus justo molestie. Ut pretium sapien dui, id facilisis metus interdum pharetra.</p>
                            <p>Etiam scelerisque lacus tempor, rhoncus diam vel, gravida felis. Fusce tristique sem et leo aliquam vulputate. Ut eget orci in sapien commodo fringilla. Ut luctus faucibus viverra. Quisque ut ante eget libero rutrum imperdiet. Morbi in diam bibendum, venenatis arcu sed, consequat libero. Nulla imperdiet, ipsum et adipiscing pulvinar, nibh metus porta mauris, et vestibulum dolor sapien sit amet justo. In dignissim leo nec erat faucibus volutpat.</p>
                            <h3>Duis dictum lorem metus, vitae dapibus</h3>
                            <p><img data-img-src="/assets/images/other_images/transp-image3.png" class="lazy rounded_border hover_effect pull-left" alt="Lorem Ipsum">Sed auctor urna mi, sed fringilla felis vulputate nec. Cras eu nibh id quam pretium convallis. Donec ante enim, placerat nec sagittis sit amet, tempor in velit. Maecenas ultricies commodo lacus id porta. Suspendisse eros elit, lacinia vitae erat vitae, egestas accumsan nunc. Maecenas dictum odio ipsum, non volutpat erat consequat tempor. Pellentesque sed malesuada turpis. Quisque eget lacus sit amet dui feugiat molestie sit amet eget purus. Morbi eget neque nec lectus tempus sagittis nec at ante. </p>
                            <p>Etiam scelerisque lacus tempor, rhoncus diam vel, gravida felis. Fusce tristique sem et leo aliquam vulputate. Ut eget orci in sapien commodo fringilla. Ut luctus faucibus viverra. Quisque ut ante eget libero rutrum imperdiet. Morbi in diam bibendum, venenatis arcu sed, consequat libero. Nulla imperdiet, ipsum et adipiscing pulvinar, nibh metus porta mauris, et vestibulum dolor sapien sit amet justo. In dignissim leo nec erat faucibus volutpat.</p>
                        </div><!-- #modal-content-1 -->
                    </div><!-- .col-sm-10 -->
                </div><!-- .content-wrapper -->
            </article><!-- .section-wrapper -->
            <article id="contact" class="section-wrapper clearfix" data-custom-background-img="/assets/images/other_images/bg4.jpg">
                <div class="content-wrapper clearfix">

                    <h1 class="section-title">Status Update</h1>

                    <!-- CONTACT DETAILS -->
                    <div class="contact-details col-sm-5 col-md-3">
                        <p>123A,<br/>Molestie Lorem Avenue,<br/>Aliquam<br/>AAA0010</p>
                        <p>Tel: (+20) 21 301 524</p>
                        <p><a href="mailto:info@loremipsum.com">info@loremipsum.com</a></p>
                        </div>
                        <!-- END: CONTACT DETAILS -->
                        <!-- CONTACT FORM -->
                        <div class="col-sm-7 col-md-9">
                            <!-- IMPORTANT: change the email address at the top of the assets/php/mail.php file to the email address that you want this form to send to -->
                            <form class="form-style validate-form clearfix" action="/assets/php/mail.php" method="POST" role="form">
                                <!-- form left col -->
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="text" class="text-field form-control validate-field required" data-validation-type="string" id="form-name" placeholder="Full Name" name="name">
                            </div>
                                    <div class="form-group">
                                        <input type="email" class="text-field form-control validate-field required" data-validation-type="email" id="form-email" placeholder="Email Address" name="email">
                            </div>
                                    <div class="form-group">
                                        <input type="tel" class="text-field form-control validate-field phone" data-validation-type="phone" id="form-contact-number" placeholder="Contact Number" name="contact_number">
                            </div>
                                    <div class="form-group text-right">
                                        <img id="form-captcha-img" src="/assets/php/form_captcha/captcha_img.php">
                                            <input type="text" class="text-field form-control validate-field required" data-validation-type="captcha" id="form-captcha" placeholder="Enter text" name="captcha">
                                                <span id="form-captcha-refresh" class="fa fa-refresh" title="Reload"></span>
                            </div>
                                </div><!-- end: form left col -->
                                <!-- form right col -->
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <textarea placeholder="Message..." class="form-control validate-field required" name="message"></textarea>
                                    </div>
                                    <div class="form-group">
                                        <img src="/assets/images/theme_images/loader-form.GIF" class="form-loader">
                                            <button type="submit" class="btn btn-sm btn-outline-inverse">Submit</button>
                            </div>
                                    <div class="form-group form-general-error-container"></div>
                                </div><!-- end: form right col -->
                            </form>
                        </div><!-- end: CONTACT FORM -->
                    </div><!-- .content-wrapper -->
                </article><!-- .section-wrapper -->
                <article id="featured" class="section-wrapper clearfix" data-custom-background-img="/assets/images/other_images/bg3.jpg">
                    <div class="content-wrapper clearfix">
                        <div class="col-sm-11 pull-right">
                            <h1 class="section-title">Photos</h1>

                            <!-- feature columns -->
                            <section class="feature-columns row clearfix">
                                <!-- feature 1 -->
                                <article class="feature-col col-md-4">
                                    <a href="" onclick="populate_and_open_modal(event, 'modal-content-6');" class="thumbnail linked">
                                        <div class="image-container">
                                            <img data-img-src="/assets/images/other_images/project-3.jpg" class="lazy item-thumbnail" alt="Lorem Ipsum">
                                </div>
                                        <div class="caption">
                                            <h5>Image Carousel</h5>
                                            <p>This feature contains an image carousel when you open popup.</p>
                                        </div><!-- .caption -->
                                    </a><!-- .thumbnail -->
                                    <div class="content-to-populate-in-modal" id="modal-content-6">
                                        <h1>Sed scelerisque</h1>
                                        <p>Nullam ac rhoncus. Aliquam adipiscing eros non elit imperdiet congue. Etiam at ligula sit amet arcu laoreet consequat.<br/></p>
                                        <!-- image slider inside popup -->
                                        <div id="unique-id-for-image-slider" class="owl-carousel popup-image-gallery">
                                            <!-- slide -->
                                            <div>
                                                <!-- caption is optional. To remove it, remove the <h6> below -->
                                                <h6 class="caption">Caption for Image 1</h6>
                                                <img class="lazyOwl" data-src="/assets/images/other_images/bg1.jpg">
                                    </div>
                                            <!-- slide -->
                                            <div>
                                                <h6 class="caption">Caption for Image 2</h6>
                                                <img class="lazyOwl" data-src="/assets/images/other_images/bg2.jpg">
                                    </div>
                                            <!-- slide -->
                                            <div>
                                                <h6 class="caption">Caption for Image 3</h6>
                                                <img class="lazyOwl" data-src="/assets/images/other_images/bg3.jpg">
                                    </div>
                                        </div>
                                    </div><!-- #modal-content-6 -->
                                </article>
                                <!-- feature 2 -->
                                <article class="feature-col col-md-4">
                                    <a href="" onclick="populate_and_open_modal(event, 'modal-content-7');" class="thumbnail linked">
                                        <div class="image-container">
                                            <img data-img-src="/assets/images/other_images/project-2.jpg" class="lazy item-thumbnail" alt="Lorem Ipsum">
                                </div>
                                        <div class="caption">
                                            <h5>Text popup</h5>
                                            <p>This feature contains generic image and text content when you open popup.</p>
                                        </div><!-- .caption -->
                                    </a><!-- .thumbnail -->
                                    <div class="content-to-populate-in-modal" id="modal-content-7">
                                        <img data-img-src="/assets/images/other_images/top-image2.jpg" class="lazy full-width" alt="Lorem Ipsum">
                                            <h1>Sed scelerisque</h1>
                                            <p>Nullam ac rhoncus. Aliquam adipiscing eros non elit imperdiet congue. Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio</a>, sit amet. </p>
                                        <p>Laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio, sit amet.</p>
                                        <p>Suspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio test.</p>
                                    </div><!-- #modal-content-7 -->
                                </article>
                                <!-- feature 3 -->
                                <article class="feature-col col-md-4">
                                    <a href="" onclick="populate_and_open_modal(event, 'modal-content-8', '', 'full-size');" class="thumbnail linked">
                                        <div class="image-container">
                                            <img data-img-src="/assets/images/other_images/project-4.jpg" class="lazy item-thumbnail" alt="Lorem Ipsum">
                                </div>
                                        <div class="caption">
                                            <h5>Alternate Gallery</h5>
                                            <p>Inside this feature's popup you'll find an alternative version of an image gallery.</p>
                                        </div><!-- .caption -->
                                    </a><!-- .thumbnail -->
                                    <div class="content-to-populate-in-modal" id="modal-content-8">
                                        <h1>Sed scelerisque</h1>
                                        <p>Nullam ac rhoncus. Aliquam adipiscing eros non elit imperdiet congue. Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio</a>, sit amet. Adipiscing eros non elit imperdiet congue tiam at ligula sit amet arcu.</p>
                                    <!-- alt image slider inside popup -->
                                    <div id="unique-id-for-alt-image-slider" class="owl-carousel popup-alt-image-gallery">
                                        <div class="item"><a href="/assets/images/other_images/bg1.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-1.jpg"></a></div>
                                        <div class="item"><a href="/assets/images/other_images/bg2.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-2.jpg"></a></div>
                                        <div class="item"><a href="/assets/images/other_images/bg3.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-3.jpg"></a></div>
                                        <div class="item"><a href="/assets/images/other_images/bg4.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-4.jpg"></a></div>
                                        <div class="item"><a href="/assets/images/other_images/bg5.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-5.jpg"></a></div>
                                        <div class="item"><a href="/assets/images/other_images/bg6.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-6.jpg"></a></div>
                                        <div class="item"><a href="/assets/images/other_images/bg2.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-2.jpg"></a></div>
                                        <div class="item"><a href="/assets/images/other_images/bg3.jpg" data-lightbox="popup-alt-gallery"><img class="lazyOwl" data-src="/assets/images/other_images/gallery-thumb-3.jpg"></a></div>
                                    </div>
                            </div><!-- #modal-content-8 -->
                        </article>
            </section><!-- end: .feature-columns - ->
            <!-- End: Section content to edit -->
                </div><!-- .col-sm-10 -->
            </div><!-- .content-wrapper -->
        </article><!-- .section-wrapper -->
        <article id = "tabs" Class="section-wrapper clearfix" data-custom-background-img="/assets/images/other_images/bg7.jpg">
            <div Class="content-wrapper mid-vertical-positioning clearfix">
                <div Class="col-sm-10 col-md-9 pull-right">
                    <h1 Class="section-title">Threads</h1>
                    <div Class="tabpanel styled-tabs uniform-height" role="tabpanel">
                        <!-- Nav tabs -->
                        <ul Class="nav nav-tabs" role="tablist" text-hidden-xs="true">
                            <li role = "presentation" Class="active"><a href="#tabs-tab1" aria-controls="tabs-tab1" role="tab" data-toggle="tab"><i Class="icon fa fa-diamond"></i><span>Donec</span></a></li>
                            <li role = "presentation" <> a href="#tabs-tab2" aria-controls="tabs-tab2" role="tab" data-toggle="tab"><i Class="icon fa fa-train"></i><span>Maecenas</span></a></li>
                            <li role = "presentation" <> a href="#tabs-tab3" aria-controls="tabs-tab3" role="tab" data-toggle="tab"><i Class="icon fa fa-coffee"></i><span>Iaculis</span></a></li>
                            <li role = "presentation" <> a href="#tabs-tab4" aria-controls="tabs-tab4" role="tab" data-toggle="tab"><i Class="icon fa fa-comment"></i><span>Quisque</span></a></li>
                        </ul>
                        <!-- Tab panes -->
                        <div Class="tab-content">
                            <div role = "tabpanel" Class="tab-pane fade in active" id="tabs-tab1">
                                <img src = "/assets/images/other_images/tabs-icon4.png" Class="pull-right hidden-xs">
                                <h4> Donec nec magna condimentum</h4>
                                <p> Uspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio. Etiam scelerisque lacus tempor, rhoncus diam vel, gravida felis. Fusce tristique sem et leo. Pellentesque sed malesuada turpis. Quisque eget lacus sit amet dui.</p>
                                <p> Ut pretium sapien dui, id facilisis metus interdum pharetra. Totam REM aperiam, eaque ipsa quae ab illo inventore.</p>
                            </div>
                            <div role = "tabpanel" Class="tab-pane fade" id="tabs-tab2">
                                <img src = "/assets/images/other_images/tabs-icon3.png" Class="pull-right hidden-xs">
                                <h4> Maecenas rhoncus tortor nec mi congue</h4>
                                <p> Sed ut perspiciatis unde omnis iste natus Error sit voluptatem accusantium doloremque laudantium, totam REM aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio.</p>
                            </div>
                            <div role = "tabpanel" Class="tab-pane fade" id="tabs-tab3">
                                <img src = "/assets/images/other_images/tabs-icon2.png" Class="pull-right hidden-xs">
                                <h4> Lorem ipsum dolor sit amet, consectetur adipiscing elit</h4>
                                <p> Nunc accumsan sapien eu tortor fringilla, et condimentum metus pellentesque. Maecenas rhoncus tortor nec mi congue aliquet. Integer eu turpis scelerisque, iaculis magna non, tempor sem. Quisque consectetur nisi eu felis euismod, sit amet faucibus justo molestie. Ut pretium sapien dui, id facilisis metus interdum pharetra.</p>
                            </div>
                            <div role = "tabpanel" Class="tab-pane fade" id="tabs-tab4">
                                <img src = "/assets/images/other_images/tabs-icon1.png" Class="pull-right hidden-xs">
                                <h4> Quisque consectetur nisi</h4>
                                <p> Etiam scelerisque lacus tempor, rhoncus diam vel, gravida felis. Fusce tristique sem et leo aliquam vulputate. Ut eget orci In sapien commodo fringilla. Maecenas rhoncus tortor nec mi congue aliquet. Integer eu turpis scelerisque, iaculis magna non, tempor sem.</p>
                                <p>Integer eu turpis scelerisque, iaculis magna non.</p>
                            </div>
                        </div><!-- .tab-content -->
                    </div><!-- .tabpanel -->
                </div><!-- .col-sm-10 -->
            </div><!-- .content-wrapper -->
        </article><!-- .section-wrapper -->
        <article id = "carousel" Class="section-wrapper clearfix" data-custom-background-img="/assets/images/other_images/bg6.jpg">
            <div Class="content-wrapper clearfix">
                <h1 Class="section-title">Members</h1>
                <div id = "features-carousel" Class="carousel slide with-title-indicators max-height" data-height-percent="70" data-ride="carousel">

                    <!-- Indicators - slide navigation -->
                    <ol Class="carousel-indicators title-indicators">
                        <li data-target="#features-carousel" data-slide-To="0" Class="active">Lorem Ipsum</li>
                        <li data-target="#features-carousel" data-slide-To="1">Suspendisse</li>
                        <li data-target="#features-carousel" data-slide-To="2">Maecenas</li>
                        <li data-target="#features-carousel" data-slide-To="3">Scelerisque</li>
                    </ol>
                    <!-- Wrapper for slides -->
                    <div Class="carousel-inner">
                        <div Class="item active">
                            <div Class="carousel-text-content">
                                <img src = "/assets/images/other_images/transp-image1.png" Class="icon" alt="Lorem Ipsum">
                                <h2 Class="title">Lorem Ipsum</h2>
                                <p> Suspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio.</p>
                                <p> <a href = "" onclick="populate_and_open_modal(event, 'modal-content-2');" Class="btn btn-outline-inverse btn-sm">read more</a></p>
                                <div Class="content-to-populate-in-modal" id="modal-content-2">
                                    <h1> Lorem Ipsum</h1>
                                    <p> <img data-img-src="/assets/images/other_images/transp-image1.png" Class="lazy rounded_border hover_effect pull-left" alt="Lorem Ipsum">Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. <a href="#">Suspendisse molestie lorem odio</a>, sit amet. </p>
                                    <p> Laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio, sit amet.</p>
                                    <p> Suspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio test.</p>
                                </div><!-- #modal-content-2 -->
                            </div>
                        </div><!-- .item -->
                        <div Class="item">
                            <div Class="carousel-text-content">
                                <img src = "/assets/images/other_images/transp-image6.png" Class="icon" alt="Lorem Ipsum">
                                <h2 Class="title">Suspendisse molestie</h2>
                                <p> Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Duis dictum lorem metus.</p>
                                <p> <a href = "" onclick="populate_and_open_modal(event, 'modal-content-3');" Class="btn btn-outline-inverse btn-sm">read more</a></p>
                                <div Class="content-to-populate-in-modal" id="modal-content-3">
                                    <h1> Suspendisse molestie</h1>
                                    <p> <img data-img-src="/assets/images/other_images/transp-image6.png" Class="lazy rounded_border hover_effect pull-left" alt="Lorem Ipsum">Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. <a href="#">Suspendisse molestie lorem odio</a>, sit amet. </p>
                                    <p> Laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio, sit amet.</p>
                                    <p> Suspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio test.</p>
                                </div><!-- #modal-content-3 -->
                            </div>
                        </div><!-- .item -->
                        <div Class="item">
                            <div Class="carousel-text-content">
                                <img src = "/assets/images/other_images/transp-image7.png" Class="icon" alt="Lorem Ipsum">
                                <h2 Class="title">Maecenas id dolor</h2>
                                <p> Fusce erat augue, fermentum sit amet congue a, ullamcorper ac enim. Maecenas id dolor imperdiet, mollis felis ut, pellentesque ante. Sed id congue arcu. Nulla eget commodo sem. Suspendisse suscipit, sem ac.</p>
                                <p> <a href = "" onclick="populate_and_open_modal(event, 'modal-content-4');" Class="btn btn-outline-inverse btn-sm">read more</a></p>
                                <div Class="content-to-populate-in-modal" id="modal-content-4">
                                    <h1> Maecenas id dolor</h1>
                                    <p> <img data-img-src="/assets/images/other_images/transp-image7.png" Class="lazy rounded_border hover_effect pull-left" alt="Lorem Ipsum">Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. <a href="#">Suspendisse molestie lorem odio</a>, sit amet. </p>
                                    <p> Laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio, sit amet.</p>
                                    <p> Suspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio test.</p>
                                </div><!-- #modal-content-4 -->
                            </div>
                        </div><!-- .item -->
                        <div Class="item">
                            <div Class="carousel-text-content">
                                <img src = "/assets/images/other_images/transp-image4.png" Class="icon" alt="Lorem Ipsum">
                                <h2 Class="title">Sed scelerisque</h2>
                                <p> Aenean a est fringilla, malesuada eros vel, condimentum augue. Sed lorem sapien, vestibulum quis nisl volutpat, fermentum adipiscing massa. Cras ac faucibus nisl. Proin ac convallis sapien. </p>
                                <p> <a href = "" onclick="populate_and_open_modal(event, 'modal-content-5');" Class="btn btn-outline-inverse btn-sm">read more</a></p>
                                <div Class="content-to-populate-in-modal" id="modal-content-5">
                                    <h1> Sed scelerisque</h1>
                                    <p> <img data-img-src="/assets/images/other_images/transp-image4.png" Class="lazy rounded_border hover_effect pull-left" alt="Lorem Ipsum">Etiam at ligula sit amet arcu laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. <a href="#">Suspendisse molestie lorem odio</a>, sit amet. </p>
                                    <p> Laoreet consequat. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio, sit amet.</p>
                                    <p> Suspendisse molestie lorem odio, sit amet. Duis dictum lorem metus, vitae dapibus risus imperdiet nec. Suspendisse molestie lorem odio test.</p>
                                </div><!-- #modal-content-5 -->
                            </div>
                        </div><!-- .item -->
                    </div><!-- .carousel-inner -->
                    <!-- Controls -->
                    <a Class="left carousel-control" href="#features-carousel" data-slide="prev"></a>
                    <a Class="right carousel-control" href="#features-carousel" data-slide="next"></a>
                </div><!-- #about-carousel -->
            </div><!-- .content-wrapper -->
        </article><!-- .section-wrapper -->
        <article id = "grid" Class="section-wrapper clearfix" data-custom-background-img="/assets/images/other_images/bg2.jpg">
            <div Class="content-wrapper clearfix">
                <div Class="col-sm-11 col-md-10 pull-right">
                    <h1 Class="section-title">About TFN</h1>

                    <!-- grid -->
                    <section Class="grid row clearfix clearfix-for-2cols">
                        <!-- grid item -->
                        <div Class="grid-item col-md-6">
                            <div Class="item-content clearfix">
                                <span Class="icon fa fa-area-chart"></span>
                                <div Class="text-content">
                                    <h5> Lorem ipsum dolor sit amet</h5>
                                    <p> Nullam ac rhoncus sapien, non gravida purus. Aliquam adipiscing eros non elit imperdiet congue. Integer ultricies.</p>
                                </div>
                            </div><!-- end: .item-content - ->
                        </div><!-- end: .grid-item - ->
                                                                                                                                                        <!-- grid item -->
                        <div Class="grid-item col-md-6">
                            <div Class="item-content clearfix">
                                <span Class="icon fa fa-globe"></span>
                                <div Class="text-content">
                                    <h5> Aliquam adipiscing eros non elit</h5>
                                    <p> Nullam ac rhoncus sapien, non gravida purus. Alinon elit imperdiet congue. Integer ultricies sed ligula eget tempus.</p>
                                </div>
                            </div><!-- end: .item-content - ->
                        </div><!-- end: .grid-item - ->
                                                                                                                                                                        <!-- grid item -->
                        <div Class="grid-item col-md-6">
                            <div Class="item-content clearfix">
                                <span Class="icon fa fa-certificate"></span>
                                <div Class="text-content">
                                    <h5>Integer ultricies sed ligula</h5>
                                    <p> Aliquam adipiscing eros non elit imperdiet congue. Integer ultricies sed ligula ligula eget.</p>
                                </div>
                            </div><!-- end: .item-content - ->
                        </div><!-- end: .grid-item - ->
                                                                                                                                                                                        <!-- grid item -->
                        <div Class="grid-item col-md-6">
                            <div Class="item-content clearfix">
                                <span Class="icon fa fa-cloud"></span>
                                <div Class="text-content">
                                    <h5> Lorem ipsum dolor sit amet</h5>
                                    <p> Nullam ac rhoncus. Aliquam adipiscing eros non elit imperdiet congue. Integer ultricies sed ligula eget tempus.</p>
                                </div>
                            </div><!-- end: .item-content - ->
                        </div><!-- end: .grid-item - ->
                    </section><!-- end: grid -->
                </div><!-- .col-sm-11 -->
            </div><!-- .content-wrapper -->
        </article><!-- .section-wrapper -->
    </section><!-- #main-content -->
    <!-- Footer -->
    <section id = "footer" >
                                                                                                                                                                                                        <!-- Go to Top -->
                                                                                                                                                                                                        <div id = "go-to-top" onclick="scroll_to_top();"><span Class="icon glyphicon glyphicon-chevron-up"></span></div>
        <ul Class="social-icons">
            <li> <a href = "#" target="_blank" title="Facebook"><img src="/assets/images/theme_images/social_icons/facebook.png" alt="Facebook"></a></li>
            <li> <a href = "#" target="_blank" title="Twitter"><img src="/assets/images/theme_images/social_icons/twitter.png" alt="Twitter"></a></li>
            <li> <a href = "#" target="_blank" title="Google+"><img src="/assets/images/theme_images/social_icons/googleplus.png" alt="Google+"></a></li>
        </ul>
        <!-- copyright text -->
        <div Class="footer-text-line">&copy; @DateTime.Now.Year TFN</div>
    </section>
    <!-- end: Footer -->
</div><!-- #outer-container -->
<!-- end: Outer Container -->