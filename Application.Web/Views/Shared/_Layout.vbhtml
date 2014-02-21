@*<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>@ViewData("Title") - My ASP.NET MVC Application</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")
        @Scripts.Render("~/bundles/knockout")
    </head>
    <body>
        <header>
            <div class="content-wrapper">
                <div class="float-left">
                    <p class="site-title">@Html.ActionLink("your logo here", "Index", "Home")</p>
                </div>
                <div class="float-right">
                    <section id="login">
                        @Html.Partial("_LoginPartial")
                    </section>
                    <nav>
                        <ul id="menu">
                            <li>@Html.ActionLink("Home", "Index", "Home")</li>
                            <li>@Html.ActionLink("About", "About", "Home")</li>
                            <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </header>
        <div id="body">
            @RenderSection("featured", required:=false)
            <section class="content-wrapper main-content clear-fix">
                @RenderBody()
            </section>
        </div>
        <footer>
            <div class="content-wrapper">
                <div class="float-left">
                    <p>&copy; @DateTime.Now.Year - My ASP.NET MVC Application</p>
                </div>
            </div>
        </footer>

        @Scripts.Render("~/bundles/jquery")
        @RenderSection("scripts", required:=False)
    </body>
</html>
*@
   
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title - Contact manager</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width" />
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/knockout")
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
        @RenderSection("scripts", required:=False)
</head>
<body>

    <div class="container-narrow">
        @*<div class="masthead">
            <ul class="nav nav-pills pull-right">
                
            </ul>
            <h3 class="muted">Contact Manager</h3>
        </div>*@
        <div id="body" class="container">
        <h3 class="muted">Contact Manager</h3>
                @RenderSection("scripts", required:=False)
            <section>
                @RenderBody()
            </section>
        </div>
        <hr />
        <div id="footer">
            <div class="container">
                <p class="muted credit">&copy; @DateTime.Now.Year - Design and devloped by <a href="http://www.anandpandey.com">Anand Pandey</a>.</p>
            </div>
        </div>
    </div>

</body>
</html>