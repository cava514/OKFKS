using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var key = builder.Configuration["JwtSettings:Key"];

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidateAudience = true,
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(key))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/token", (string username, string role, HttpContext context) =>
{
    var config = context.RequestServices.GetRequiredService<IConfiguration>();

    return Results.Ok(CreateAccessToken(config, username, role));
});

app.Run();

static string CreateAccessToken(
    IConfiguration configuration,
    string username,
    string role
    )
{
    var claims = new[]
    {
        new Claim(ClaimTypes.Name, username),
        new Claim(ClaimTypes.Role, role)
    };

    var key = new SymmetricSecurityKey(
        Encoding.ASCII.GetBytes(configuration["JwtSettings:Key"]));

    var creditionals = new SigningCredentials(
        key, SecurityAlgorithms.HmacSha256);

    var token = new JwtSecurityToken(
        issuer: configuration["JwtSettings:Issuer"],
        audience: configuration["JwtSettings:Audience"],
        claims: claims,
        expires: DateTime.UtcNow.AddMinutes(15),
        signingCredentials: creditionals);

    return new JwtSecurityTokenHandler().WriteToken(token);
}