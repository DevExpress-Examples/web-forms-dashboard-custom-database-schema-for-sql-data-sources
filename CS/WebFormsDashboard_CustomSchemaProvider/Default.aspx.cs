using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Sql;
using System;

namespace WebFormsDashboard_CustomSchemaProvider {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage);

            ASPxDashboard1.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());

            // This method assigns the database schema provider to the Web Dashboard.
            // Uncomment one of the following lines depending on the provider.
            ASPxDashboard1.SetDBSchemaProvider(new ManualDBSchemaProvider());
            //ASPxDashboard1.SetDBSchemaProvider(new LimitDBSchemaProvider());

        }
    }
}