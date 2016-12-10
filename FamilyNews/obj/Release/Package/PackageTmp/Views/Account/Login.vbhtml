@ModelType LoginViewModel
@Code
    ViewBag.Title = "Log in"
End Code
<div class="navbar navbar-fixed-top visible-lg">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            @Html.ActionLink("The Family News", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        </div>
        <div class="navbar-collapse collapse">
            @Html.Partial("_LoginPartial")
        </div>
    </div>
</div>
<div class="col-sm-12 col-md-5" style="margin:0 auto;float:none">
    <h2>@ViewBag.Title.</h2>
    <div class="row">
        <div>
            <section id="loginForm">
                @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                    @Html.AntiForgeryToken()
                    @<text>
                        <h4>Use a local account to log in.</h4>
                        <hr />
                        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                        <div class="form-group">
                            @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 control-label"})
                            <div class="col-md-10">
                                @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                            </div>
                        </div>
                        <div class="form-group">
                            @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
                            <div class="col-md-10">
                                @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <div class="checkbox">
                                    @Html.CheckBoxFor(Function(m) m.RememberMe)
                                    @Html.LabelFor(Function(m) m.RememberMe)
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <input type="submit" value="Log in" class="btn btn-default" />
                            </div>
                        </div>
                        <p>
                            @Html.ActionLink("register a new account", "Register")
                        </p>
                        @* Enable this once you have account confirmation enabled for password reset functionality
                            <p>
                                @Html.ActionLink("Forgot your password?", "ForgotPassword")
                            </p>*@
                    </text>
                End Using
            </section>
        </div>
        @*<div class="col-md-4">
            <section id="socialLoginForm">
                @Html.Partial("_ExternalLoginsListPartial", New ExternalLoginListViewModel With {.ReturnUrl = ViewBag.ReturnUrl})
            </section>
        </div>*@
    </div>
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
