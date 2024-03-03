using Zenhealthcareservice;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var zenhealthcareserviceapp = builder.Build();
startup.Configure(zenhealthcareserviceapp, builder.Environment);

