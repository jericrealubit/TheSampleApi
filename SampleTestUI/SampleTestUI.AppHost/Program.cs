var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.SampleTestUI_ApiService>("apiservice");

builder.AddProject<Projects.SampleTestUI_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
