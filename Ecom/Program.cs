﻿using Ecom.Context;
using Ecom.Interfaces;
using Ecom.Repository;
using Ecom.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AutoMapper;
using Ecom.Dto.ProductTest;
using Ecom.AutoMapper;
using Ecom.Services.Common;
using Microsoft.Extensions.FileProviders;
using Ecom.Entity;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connect")));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

builder.Services.AddHttpClient();

//service
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<IDanhMucSanPhamService, DanhMucSanPham>();
builder.Services.AddTransient<ISanPhamService, SanPhamService>();
builder.Services.AddTransient<INganHangService, NganHangService>();
builder.Services.AddTransient<IPhieuNhapKhoService, PhieuNhapKhoService>();
builder.Services.AddTransient<IDonHangService, DonHangService>();
builder.Services.AddTransient<IDoanhThuService, DoanhThuService>();
builder.Services.AddTransient<IGioHangService, GioHangService>();
builder.Services.AddTransient<IDanhGiaService, DanhGiaService>();
builder.Services.AddTransient<SaveFileCommon>();
builder.Services.AddScoped<StripePaymentService>();
builder.Services.AddTransient<IZaloPaymentService, ZaloPaymentService>();

builder.Services.AddHttpContextAccessor();

// Configure Stripe
builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));
Stripe.StripeConfiguration.ApiKey = builder.Configuration["Stripe:SecretKey"];
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        //options.Events = new JwtBearerEvents
        //{
        //    OnMessageReceived = context =>
        //    {
        //        if (context.Request.Cookies.ContainsKey("accessToken"))
        //        {
        //            context.Token = context.Request.Cookies["accessToken"];
        //        }
        //        return Task.CompletedTask;
        //    }
        //};

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),
            ClockSkew = TimeSpan.Zero
        };
    });
builder.Services.AddAuthorization();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors(MyAllowSpecificOrigins);
app.UseCors("AllowAll");
if (!app.Environment.IsDevelopment())
{
    app.UseDefaultFiles();
    app.UseStaticFiles();
}
app.UseRouting();

app.UseAuthentication(); // Đảm bảo đã thêm dòng này
app.UseAuthorization(); // Bắt buộc có

//app.UseEndpoints(endpoints =>
//{
app.MapControllers();
app.MapFallbackToFile("index.html"); // Định tuyến SPA về index.html
//});


app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "san_pham")),
    RequestPath = "/san_pham"
});
app.MapControllers();

app.Run();
