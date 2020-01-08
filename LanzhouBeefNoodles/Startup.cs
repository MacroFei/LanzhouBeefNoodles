using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LanzhouBeefNoodles
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            //services.AddTransient<INoodleRepository, MockNoodleRepository>();
            //services.AddTransient<IFeedbackRepository, MockFeedbackRepository>();
            services.AddTransient<INoodleRepository, NoodleRepository>();
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            /*    app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/

            app.UseMvc(route =>
            {
                route.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
