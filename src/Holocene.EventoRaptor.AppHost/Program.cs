using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiapp = builder.AddProject<Holocene_EventoRaptor_ApiApp>("apiapp");

var webapp = builder.AddProject<Holocene_EventoRaptor_WebApp>("webapp")
                    .WithReference(apiapp);

builder.Build().Run();
