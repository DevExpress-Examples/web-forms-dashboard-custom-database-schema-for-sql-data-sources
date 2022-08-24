Imports DevExpress.DashboardWeb
Imports System

Namespace WebFormsDashboard_CustomSchemaProvider

    Public Partial Class [Default]
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim dashboardFileStorage As DashboardFileStorage = New DashboardFileStorage("~/App_Data/Dashboards")
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage)
            ASPxDashboard1.SetConnectionStringsProvider(New DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider())
            ' This method assigns the database schema provider to the Web Dashboard.
            ' Uncomment one of the following lines depending on the provider.
            ASPxDashboard1.SetDBSchemaProvider(New ManualDBSchemaProvider())
        'ASPxDashboard1.SetDBSchemaProvider(new LimitDBSchemaProvider());
        End Sub
    End Class
End Namespace
