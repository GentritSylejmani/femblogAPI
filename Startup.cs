using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using femblogAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace femblogAPI
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
<<<<<<< HEAD
=======
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

>>>>>>> d38ac58575da3c3b06520527d885d0e2e3824271
            services.AddDbContext<femblogapiContext>(options => options.UseSqlServer(Configuration.GetConnectionString("femblogapiConnection")));

            services.AddControllers();

<<<<<<< HEAD
            services.AddScoped<IFemblogRepo, MockFemblogRepo>();

=======
            //services.AddScoped<IFemblogRepo, MockFemblogRepo>();
            services.AddScoped<IFemblogRepo,SQLfemblogapiRepo>();
>>>>>>> d38ac58575da3c3b06520527d885d0e2e3824271
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
