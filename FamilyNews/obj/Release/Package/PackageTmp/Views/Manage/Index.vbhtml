﻿@ModelType IndexViewModel
@Code
    ViewBag.Title = "Manage"
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

    <p class="text-success">@ViewBag.StatusMessage</p>
    <div>
        <h4>Change your account settings</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>Password:</dt>
            <dd>
                [
                @If Model.HasPassword Then
                    @Html.ActionLink("Change your password", "ChangePassword")
                Else
                    @Html.ActionLink("Create", "SetPassword")
                End If
                ]
            </dd>
            @*<dt>External Logins:</dt>
                <dd>
                    @Model.Logins.Count [
                    @Html.ActionLink("Manage", "ManageLogins") ]
                </dd>*@
            @*
                Phone Numbers can used as a second factor of verification in a two-factor authentication system.

                 See <a href="http://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                    for details on setting up this ASP.NET application to support two-factor authentication using SMS.

                 Uncomment the following block after you have set up two-factor authentication
            *@
            @*
                <dt>Phone Number:</dt>
                <dd>
                    @(If(Model.PhoneNumber, "None"))
                    @If (Model.PhoneNumber <> Nothing) Then
                        @<br />
                        @<text>[&nbsp;&nbsp;@Html.ActionLink("Change", "AddPhoneNumber")&nbsp;&nbsp;]</text>
                        @Using Html.BeginForm("RemovePhoneNumber", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                            @Html.AntiForgeryToken
                            @<text>[<input type="submit" value="Remove" class="btn-link" />]</text>
                        End Using
                    Else
                        @<text>[&nbsp;&nbsp;@Html.ActionLink("Add", "AddPhoneNumber") &nbsp;&nbsp;]</text>
                    End If
                </dd>
            *@
           @*<dt>Two-Factor Authentication:</dt>
                <dd>
                    <p>
                        There are no two-factor authentication providers configured. See <a href="http://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                        for details on setting up this ASP.NET application to support two-factor authentication.
                    </p>
                        @If Model.TwoFactor Then
                            @Using Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                              @Html.AntiForgeryToken()
                              @<text>
                              Enabled
                              <input type="submit" value="Disable" class="btn btn-link" />
                              </text>
                            End Using
                        Else
                            @Using Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                              @Html.AntiForgeryToken()
                              @<text>
                              Disabled
                              <input type="submit" value="Enable" class="btn btn-link" />
                              </text>
                            End Using
                        End If
            </dd>*@
        </dl>
    </div>
</div>
