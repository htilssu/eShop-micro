var builder = DistributedApplication.CreateBuilder(args);

var kafka = builder.AddKafka("kafka").WithKafkaUI();
var redis = builder.AddRedis("redis");

var cart = builder.AddProject<Projects.Cart>("cart").WithReference(kafka).WithReference(redis);

var catalog = builder.AddProject<Projects.Catalog>("catalog").WithReference(kafka).WithReference(redis);

var inventory = builder.AddProject<Projects.Inventory>("inventory").WithReference(kafka);

var payment = builder.AddProject<Projects.Payment>("payment").WithReference(kafka).WithReference(redis);

var product = builder.AddProject<Projects.Product>("product").WithReference(kafka).WithReference(redis);

var search = builder.AddProject<Projects.Search>("search").WithReference(kafka).WithReference(redis);


builder.Build().Run();
