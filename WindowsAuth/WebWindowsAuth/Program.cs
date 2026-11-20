using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAuthentication(NegotiateDefaults.AuthenticationScheme)
    .AddNegotiate();
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/me", [Authorize(Roles = "PC-KLASS\\Student")] (HttpContext context) =>
{
    return Results.Ok(context.User.Identity.Name);
});
//.RequireAuthorization(policy => policy.RequireRole("PC-KLASS\\Student"));

app.Run();

