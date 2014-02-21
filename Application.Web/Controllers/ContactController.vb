Namespace Application.Web
    Public Class ContactController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Contact

        Function Index() As ActionResult
            Return View()
        End Function

    End Class
End Namespace