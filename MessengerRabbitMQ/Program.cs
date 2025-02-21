
using Application.Interface.Messager;
using Application.Interface.Repository;
using Data.Context;
using Infrastructure.Messager;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace MessengerRabbitMQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IBidRepository, BidRepository>();

            builder.Services.AddScoped<IRabbitMQProducer, RabbitMQProducer>();

            var connStr = builder.Configuration.GetConnectionString("ConnStr");


            builder.Services.AddDbContext<SqlDbContext>(option => option.UseSqlServer(connStr, context =>
            context.MigrationsAssembly("BidApi")));




            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
