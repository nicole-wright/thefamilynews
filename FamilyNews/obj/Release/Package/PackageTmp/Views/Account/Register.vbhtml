@ModelType RegisterViewModel
@Code
    ViewBag.Title = "Register"
End Code
<div class="col-sm-12 col-md-5" style="margin:0 auto;float:none">
    <h2>@ViewBag.Title.</h2>

    @Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})

        @Html.AntiForgeryToken()

        @<text>
            <h4>Create a new account.</h4>
            <hr />
            @Html.ValidationSummary("", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-3 control-label"})
                <div class="col-md-9">
                    @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.Hometown, New With {.class = "col-md-3 control-label"})
                <div class="col-md-9">
                    @Html.TextBoxFor(Function(m) m.Hometown, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-3 control-label"})
                <div class="col-md-9">
                    @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-3 control-label"})
                <div class="col-md-9">
                    @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-offset-3 col-md-9">
                    <input type="submit" class="btn btn-default" value="Register" />
                </div>
            </div>
            <p>
                @Html.ActionLink("login instead", "Login")
            </p>
        </text>
    End Using
</div>
@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
