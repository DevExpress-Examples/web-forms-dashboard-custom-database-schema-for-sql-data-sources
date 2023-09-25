<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/528006310/21.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1110914)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for Web Forms - How to customize a database schema for SQL data sources

This example shows how to create a custom database schema for the dashboard. The example contains two implementation of the [IDBSchemaProviderEx](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.IDBSchemaProviderEx) interface, `LimitDBSchemaProvider` and `ManualDBSchemaProvider`. Call the [ASPxDashboard.SetDBSchemaProvider](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.SetDBSchemaProvider(DevExpress.DataAccess.Sql.IDBSchemaProviderEx)?p=netframework) method to assign the database schema to the Web Dashboard.

To see the result, add a new query or edit the existing query.

### The LimitDBSchemaProvider class

File: [LimitDBSchemaProvider.cs](./CS/WebFormsDashboard_CustomSchemaProvider/LimitDBSchemaProvider.cs) (VB: [LimitDBSchemaProvider.vb](./VB/WebFormsDashboard_CustomSchemaProvider/LimitDBSchemaProvider.vb))

This provider displays only the following database entities:

- Tables which names start with the letter *C*
- Views which names start with *Sales*
- Stored procedures with zero arguments

![](images/custom_dbschema_views.png)

### The ManualDBSchemaProvider class

File: [ManualDBSchemaProvider.cs](./CS/WebFormsDashboard_CustomSchemaProvider/ManualDBSchemaProvider.cs) (VB: [LimitDBSchemaProvider.vb](./VB/WebFormsDashboard_CustomSchemaProvider/ManualDBSchemaProvider.vb))

This provider loads two tables (`Categories` and `Products`) for the `NWindConnectionString` connection. Both tables contain only two columns and the tables are linked by the `CategoryID` field.

![](images/custom_dbschema_tables.png)

This technique improves the [Data Source Wizard](https://docs.devexpress.com/Dashboard/117680/) performance when loading the database schema to the dashboard.

## Files to Review

* [LimitDBSchemaProvider.cs](./CS/WebFormsDashboard_CustomSchemaProvider/LimitDBSchemaProvider.cs) (VB: [LimitDBSchemaProvider.vb](./VB/WebFormsDashboard_CustomSchemaProvider/LimitDBSchemaProvider.vb))
* [ManualDBSchemaProvider.cs](./CS/WebFormsDashboard_CustomSchemaProvider/ManualDBSchemaProvider.cs) (VB: [ManualDBSchemaProvider.vb](./VB/WebFormsDashboard_CustomSchemaProvider/ManualDBSchemaProvider.vb))
* [Default.aspx.cs](/CS/WebFormsDashboard_CustomSchemaProvider/Default.aspx.cs#L16) (VB: [Default.aspx.vb](./VB/WebFormsDashboard_CustomSchemaProvider/Default.aspx.vb))

## Documentation

* [Implement a Custom Database Schema in ASP.NET Web Forms](https://docs.devexpress.com/Dashboard/404054/web-dashboard/aspnet-web-forms-dashboard-control/implement-a-custom-database-schema-in-asp-net-web-forms?p=netframework)

## More Examples

* [Dashboard for MVC - How to customize a data store schema for SQL data sources](https://github.com/DevExpress-Examples/aspnet-mvc-dashboard-how-to-customize-a-data-store-schema-for-sql-data-sources-t584271)
* [Dashboard for ASP.NET Core - How to customize a data store schema for SQL data sources](https://github.com/DevExpress-Examples/aspnet-mvc-dashboard-how-to-customize-a-data-store-schema-for-sql-data-sources-t584271)
* [Dashboard for ASP.NET Core - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedAspNetCore#data-source-schema)
* [Dashboard for ASP.NET MVC - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedMVC)

