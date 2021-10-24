using AutoMapper;
using HekaLojisticsApp.Business.Abstract.Order;
using HekaLojisticsApp.Business.AutoMapper.Profiles.Order;
using HekaLojisticsApp.Business.Concrete.Order;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Context;
using HekaLojisticsApp.DataAccess.Concrete.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HekaLojisticsApp.UI.Web
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
            services.AddControllersWithViews();
            services.AddHealthChecks();


            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<LojistikAppContext>();


            services.AddAutoMapper(typeof(Startup));

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new OrderProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }



            app.UseStaticFiles();


            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {


                endpoints.MapAreaControllerRoute(
                    name: "Secure",
                    areaName: "Secure",
                    pattern: "{areas=Secure}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
