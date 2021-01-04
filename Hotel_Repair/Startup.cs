using Hotel_APIs.IRespository;
using Hotel_APIs.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Hotel_Repair
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<HotelDbCotext>(builder =>
            {
                builder.UseSqlServer(Configuration.GetConnectionString("Hotel"));
            });

            services.AddScoped<IBookingStatusRespository, BookingStatusRespository>();
            services.AddScoped<IHotelsRespository, HotelRepository>();
            services.AddScoped<IPaymentsRespository, PaymentRespository>();
            services.AddScoped<IPaymentStatusRespository, PaymentStatusRepostory>();
            services.AddScoped<IPaymentTypeRepository, PaymentTypesRespository>();
            services.AddScoped<IPositionsRespository, PositionsRespository>();
            services.AddScoped<IRatesRespository, RatesRespository>();
            services.AddScoped<IRateTypesRespository, RateTypesRespository>();
            services.AddScoped<IRoomsTypesRespository, RoomsBookedRespository>();
            services.AddScoped<IRoomsRespository, RoomsRespository>();
            services.AddScoped<IRoomStatusRespository, RoomStatusRespository>();
            services.AddScoped<IRoomTypesRespository, RoomTypesRespository>();
            services.AddScoped<IStaffRespository, StaffRespository>();
            services.AddScoped<IStaffRoomsRespository, StaffRoomsRespository>();
            services.AddScoped<IPositionsRespository, PositionsRespository>();
            services.AddScoped<IGuestsRespository, GuestRespository>();
            services.AddScoped<IBookingRespository, BookingRespository>();
            services.AddScoped<IReservationAgentsRespository, ReservationAgentsRespository>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = Configuration["Auth:Authority"];
                    options.Audience = Configuration["Auth:Audience"];
                    options.RequireHttpsMetadata = false;
                });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
