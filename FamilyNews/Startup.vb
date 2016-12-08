Imports Owin
Imports Microsoft.Extensions.Configuration

Partial Public Class Startup
    Public Sub Configuration(app As IAppBuilder)
        ConfigureAuth(app)
    End Sub
End Class
