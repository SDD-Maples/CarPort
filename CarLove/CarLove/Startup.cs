using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
namespace CarLove
{
    public class Startup
    {
        public void Database()
        {
            using( var db = new CarLove.Models.MapleContext()){
                if( db.Lots.Count() != 0) return;
                var meh = new CarLove.Models.Lot(){CurrentCount = 8, Maxsize = 8, Location = "Troy", Lotname= "City Station North", Src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d732.7186600056425!2d-73.688382511855!3d42.72754399869134!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zNDLCsDQzJzM5LjIiTiA3M8KwNDEnMTYuMiJX!5e0!3m2!1sen!2sus!4v1511746488605"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 34, Maxsize = 100, Location = "Troy", Lotname= "North Campus", Src= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1197.1235806046566!2d-73.68031572578926!3d42.73152023360161!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89de0fa1ac7a7cfd%3A0x381283c262003ef4!2sNorth+Lot%2C+Troy%2C+NY+12180!5e0!3m2!1sen!2sus!4v1511745472248"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 20, Maxsize = 40, Location = "Troy", Lotname= "City Station Overflow", Src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d345.7967623813872!2d-73.68639018367278!3d42.72761504218436!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89de0f08fe765f95%3A0x259a5fe5714e7662!2sCity+Station+Parking+Lot%2C+Troy%2C+NY+12180!5e0!3m2!1sen!2sus!4v1511745419455"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 10, Maxsize = 12, Location = "Troy", Lotname= "Union", Src= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d732.6949726718277!2d-73.67662351183891!3d42.729549298691396!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89de0f9fef37f073%3A0x83f376b86fc3020e!2sUnnamed+Road%2C+Troy%2C+NY+12180!5e0!3m2!1sen!2sus!4v1511745369887"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 5, Maxsize = 10, Location = "Troy", Lotname= "City Station South", Src = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d732.7106395108905!2d-73.68832851185499!3d42.72822299869132!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89de0f0861ef8feb%3A0x36dd68b275e2a031!2s134+Congress+St%2C+Troy%2C+NY+12180!5e0!3m2!1sen!2sus!4v1511744553985"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 20, Maxsize = 30, Location = "Scotia", Lotname= "LakeSide", Src= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2926.1668996906096!2d-73.95145768452886!3d42.82708817915818!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89de6e6d13eef9e5%3A0x3d8f0fce06ecceaa!2s199+Washington+Ave%2C+Scotia%2C+NY+12302!5e0!3m2!1sen!2sus!4v1511744435654"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 34, Maxsize = 50, Location = "Scotia", Lotname= "FlapJacks", Src= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2926.4010856494815!2d-73.958732784529!3d42.822140779158616!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89de6e15d34ad0af%3A0x425fdf3059500af!2s5+Schonowee+Ave%2C+Scotia%2C+NY+12302!5e0!3m2!1sen!2sus!4v1511744319180"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 17, Maxsize = 30, Location = "Scotia", Lotname= "Gabriels" , Src= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d731.5388868101951!2d-73.96802351183872!3d42.82732799869099!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zNDLCsDQ5JzM4LjQiTiA3M8KwNTgnMDIuOSJX!5e0!3m2!1sen!2sus!4v1511746542531"};
                db.Lots.Add(meh);
                meh = new CarLove.Models.Lot(){CurrentCount = 19, Maxsize = 27, Location = "Scotia", Lotname= "Turf Tavern", Src = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d731.5649811074655!2d-73.96167451183874!3d42.82512299869099!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zNDLCsDQ5JzMwLjQiTiA3M8KwNTcnNDAuMSJX!5e0!3m2!1sen!2sus!4v1511746578271"};
                db.Lots.Add(meh);
                db.SaveChanges();
            }
        }


        public Startup(IHostingEnvironment env)
        {
            Database();
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            Database();
        }
    }
}
