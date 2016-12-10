﻿@ModelType ChangePasswordViewModel
@Code
    ViewBag.Title = "Change Password"
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

    @Using Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()

        @<text>
            <h4>Change Password Form</h4>
            <hr />
            @Html.ValidationSummary("", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(m) m.OldPassword, New With {.class = "col-md-3 control-label"})
                <div class="col-md-9">
                    @Html.PasswordFor(Function(m) m.OldPassword, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-3 control-label"})
                <div class="col-md-9">
                    @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
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
                    <input type="submit" value="Change password" class="btn btn-default" />
                </div>
            </div>
        </text>
    End Using
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section