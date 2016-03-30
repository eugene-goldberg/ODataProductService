# ODataProductService
A brief working example of building an OData v4 service on top of an existing (a standard Northwind) database. 
To make things work, pay attention to:
    a) WebApiConfig.cs - builder.EntitySet statements; 
    b) the fact that your POCO classes should all have a [Key] sttribute above the respective primary key columns
