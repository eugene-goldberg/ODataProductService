using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ODataProductService.Models;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataProductService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Customer>("Customers");
            builder.EntitySet<Product>("Products");
            builder.EntitySet<Order>("Orders").EntityType.HasKey(o => o.OrderID);
            builder.EntitySet<Order_Detail>("Order Details").EntityType.HasKey(od => od.OrderID);
            builder.EntitySet<CustomerDemographic>("CustomerDemographics").EntityType.HasKey(cd => cd.CustomerTypeID);
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
