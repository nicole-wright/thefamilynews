﻿@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated Then
    @Using Html.BeginForm("LogOff", "Account", New With {.area = ""}, FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<a>@Html.ActionLink("Hello " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.title = "Manage"})</a>
        @<a href = "javascript:sessionStorage.removeItem('accessToken');$('#logoutForm').submit();" > Log off</a>
        @*@<ul class="nav navbar-nav navbar-right">
            <li>
                @Html.ActionLink("Hello " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.title = "Manage"})
            </li>
            <li><a href="javascript:sessionStorage.removeItem('accessToken');$('#logoutForm').submit();">Log off</a></li>
        </ul>*@
    End Using
Else
    @<a Class="link-scroll btn btn-outline-inverse btn-lg">@Html.ActionLink("login", "Login", "Account", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.id = "loginLink"})</a>
    @<a Class="link-scroll btn btn-outline-inverse btn-lg">@Html.ActionLink("register", "Register", "Account", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.id = "registerLink"})</a>

    @*@<ul class="nav navbar-nav navbar-right">
        <li>@Html.ActionLink("Register", "Register", "Account", routeValues := New With { .area = "" }, htmlAttributes := New With { .id = "registerLink" })</li>
        <li>@Html.ActionLink("Log in", "Login", "Account", routeValues := New With { .area = "" }, htmlAttributes := New With { .id = "loginLink" })</li>
    </ul>*@
End If
