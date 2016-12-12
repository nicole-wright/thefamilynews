@*<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title - My ASP.NET Application</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Application name", "Index", "Home", New With { .area = "" }, New With { .class = "navbar-brand" })
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home", New With { .area = "" }, Nothing)</li>
                    <li>@Html.ActionLink("API", "Index", "Help", New With { .area = "HelpPage" }, Nothing)</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        @RenderSection("SPAViews", required:=False)
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>*@
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>The Family News</title>
    <!-- favicon -->
    <link rel="icon" type="image/png" href="/assets/images/other_images/favicon.png">
    <!-- Bootstrap core CSS -->
    <link href="/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Bootstrap theme -->
    <link href="/assets/bootstrap/css/bootstrap-theme.min.css" rel="stylesheet">
    <!-- vegas bg -->
    <link href="/assets/js/vegas/jquery.vegas.min.css" rel="stylesheet">
    <!-- owl carousel css -->
    <link href="/assets/js/owl-carousel/owl.carousel.css" rel="stylesheet">
    <link href="/assets/js/owl-carousel/owl.theme.css" rel="stylesheet">
    <link href="/assets/js/owl-carousel/owl.transitions.css" rel="stylesheet">
    <!-- intro animations -->
    <link href="/assets/js/wow/animate.css" rel="stylesheet">
    <!-- font awesome -->
    @*<link href="/assets/css/font-awesome/css/font-awesome.min.css" rel="stylesheet">*@
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
    <!-- lightbox -->
    <link href="/assets/js/lightbox/css/lightbox.css" rel="stylesheet">
    <!-- styles for this template -->
    <link href="/assets/css/styles.css" rel="stylesheet">
    <!-- place your extra custom styles in this file -->
    <link href="/assets/css/custom.css" rel="stylesheet">
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
    <![endif]-->
</head>
<body data-default-background-img="/assets/images/other_images/bg5.jpg" data-overlay="true" data-overlay-opacity="0.35">    
    @RenderBody()
    @RenderSection("SPAViews", required:=False)
    <!-- Modal -->
    <!-- DO NOT MOVE, EDIT OR REMOVE - this is needed in order for popup content to be populated in it -->
    <div class="modal fade" id="common-modal" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <div class="modal-body clearfix">
                </div><!-- .modal-body -->
            </div><!-- .modal-content -->
        </div><!-- .modal-dialog -->
    </div><!-- .modal -->
    <!-- Javascripts
    ================================================== -->
    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)
    <!-- Jquery and Bootstrap JS -->
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="/assets/js/jquery-1.11.2.min.js"><\/script>')</script>
    <script src="/assets/bootstrap/js/bootstrap.min.js"></script>
    <!-- Easing - for transitions and effects -->
    <script src="/assets/js/jquery.easing.1.3.js"></script>
    <!-- background image strech script -->
    <script src="/assets/js/vegas/jquery.vegas.min.js"></script>
    <!-- detect mobile browsers -->
    <script src="/assets/js/detectmobilebrowser.js"></script>
    <!-- detect scrolling -->
    <script src="/assets/js/jquery.scrollstop.min.js"></script>
    <!-- owl carousel js -->
    <script src="/assets/js/owl-carousel/owl.carousel.min.js"></script>
    <!-- lightbox js -->
    <script src="/assets/js/lightbox/js/lightbox.min.js"></script>
    <!-- intro animations -->
    <script src="/assets/js/wow/wow.min.js"></script>
    <!-- responsive videos -->
    <script src="/assets/js/jquery.fitvids.js"></script>
    <!-- Custom functions for this theme -->
    <script src="/assets/js/functions.js"></script>
    <script src="/assets/js/initialise-functions.js"></script>
    <!-- IE9 form fields placeholder fix -->
    <!--[if lt IE 9]>
    <script>contact_form_IE9_placeholder_fix();</script>
    <![endif]-->

</body>
</html>