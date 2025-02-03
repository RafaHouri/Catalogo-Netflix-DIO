using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = FunctionsWorkerHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(sp =>
{
    string connectionString = Environment.GetEnvironmentVariable("CosmosDBConnection");
    return new CosmosClient(connectionString);
});

builder.Build().Run();
