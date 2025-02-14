using Globomantics;
using Globomantics.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IConferenceRepository, ConferenceRepository>();
builder.Services.AddSingleton<IProposalRepository, ProposalRepository>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();

builder.Services.AddAuthentication(o => {
    o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
    .AddCookie()
    .AddCookie(ExternalAuthenticationDefaults.AuthenticationScheme)
    //.AddTwitter(...)  //add another external provider
    .AddGoogle(o =>
    {
        o.SignInScheme =
            ExternalAuthenticationDefaults.AuthenticationScheme;
        o.ClientId = "686977813024-d9i87jqqovj5tu5luks9rk8gl33ck3rb.apps.googleusercontent.com";
        o.ClientSecret = "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";
    });

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute("default","{controller=Conference}/{action=Index}/{id?}");

app.Run();
