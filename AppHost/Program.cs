var builder = DistributedApplication.CreateBuilder(args);

var kafka = builder.AddKafka("kafka");

var cart = builder.AddProject<Projects.Cart>("cart").WithReference(kafka);

var catalog = builder.AddProject<Projects.Catalog>("catalog").WithReference(kafka);

var inventory = builder.AddProject<Projects.Inventory>("inventory").WithReference(kafka);

var payment = builder.AddProject<Projects.Payment>("payment").WithReference(kafka);

var product = builder.AddProject<Projects.Product>("product").WithReference(kafka);

var search = builder.AddProject<Projects.Search>("search").WithReference(kafka);



builder.Build().Run();
