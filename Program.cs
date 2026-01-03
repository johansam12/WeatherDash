using WeatherDash.Components;
using WeatherDash;

var builder = WebApplication.CreateBuilder(args);

// 1. Add Razor Component support
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); 

// 2. Add the HttpClient tool for the Weather API
builder.Services.AddHttpClient(); 

// 3. Add Security (Antiforgery)
builder.Services.AddAntiforgery(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<WeatherDash.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
