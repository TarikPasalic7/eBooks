using System.Collections.Generic;

using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using eKnjige.WebaAPI.Data;
using eKnjige.WebaAPI.Services;

using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using eKnjige.WebaAPI.Database;
using eKnjige.WebaAPI.Security;

namespace eKnjige.WebaAPI
{
    public class Startup
    {

        //public class BasicAuthDocumentFilter : IDocumentFilter
        //{
        //    public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        //    {
        //        var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        //{
        //    { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        //};

        //        swaggerDoc.Security = new[] { securityRequirements };
        //    }
        //}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
      


            services.AddDbContext<AppContext>(options =>
options.UseSqlServer(Configuration.GetConnectionString("eKnjigeDB")));



            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
          
           
            services.AddScoped<ICRUDService<Model.Grad, Model.Grad, Model.Grad, Model.Grad>, BaseCRUDService<Model.Grad, Model.Grad, eKnjige.WebaAPI.Grad, Model.Grad, Model.Grad>>();
            services.AddScoped<ICRUDService<Model.Spol, Model.Spol, Model.Spol, Model.Spol>, BaseCRUDService<Model.Spol, Model.Spol, eKnjige.WebaAPI.Spol, Model.Spol, Model.Spol>>();
            services.AddScoped<ICRUDService<Model.Kategorija, object, Model.Requests.KategorijaInertRequest, Model.Requests.KategorijaInertRequest>, BaseCRUDService<Model.Kategorija, object, eKnjige.WebaAPI.Kategorija, Model.Requests.KategorijaInertRequest, Model.Requests.KategorijaInertRequest>>();
            //services.AddScoped<ICRUDService<Model.Klijent, Model.Requests.KlijentiSearchRequest, Model.KlijentInsertRequest, Model.KlijentInsertRequest>, KlijentService>();
          
            services.AddScoped<IKlijentService, KlijentService>();
            services.AddScoped<ICRUDService<Model.Uloga, Model.UlogeRequest, Model.UlogeRequest, Model.UlogeRequest>, BaseCRUDService<Model.Uloga, Model.UlogeRequest, Uloga, Model.UlogeRequest, Model.UlogeRequest>>();
            services.AddScoped<ICRUDService<Model.Drzava, Model.Drzava, Model.Drzava, Model.DrzavaRequest>, BaseCRUDService<Model.Drzava,Model.Drzava,eKnjige.WebaAPI.Drzava,Model.Drzava,Model.DrzavaRequest>>();
            services.AddScoped<IEKnjigaService, EKnjigaService>();
            services.AddScoped<ICRUDService<Model.Autor, Model.AutorSearchRequest, Model.Autor, Model.Autor>, BaseCRUDService<Model.Autor, Model.AutorSearchRequest, Autor, Model.Autor, Model.Autor>>();
            services.AddScoped<ICRUDService<Model.EKnjigeAutor, Model.EKnjigeAutor, Model.EKnjigeAutorRequest, Model.EKnjigeAutorRequest>, BaseCRUDService<Model.EKnjigeAutor, Model.EKnjigeAutor, EKnjigeAutor, Model.EKnjigeAutorRequest, Model.EKnjigeAutorRequest>>();
            services.AddScoped<ICRUDService<Model.EKnjigaKategorija, Model.EKnjigaKategorija, Model.EKnjigaKategorijaRequest, Model.EKnjigaKategorijaRequest>, BaseCRUDService<Model.EKnjigaKategorija, Model.EKnjigaKategorija, EKnjigaKategorija, Model.EKnjigaKategorijaRequest, Model.EKnjigaKategorijaRequest>>();
            services.AddScoped<ICRUDService<Model.Komentar, Model.KomentarRequest, Model.KomentarRequest, Model.KomentarRequest>, BaseCRUDService<Model.Komentar, Model.KomentarRequest, Komentar, Model.KomentarRequest, Model.KomentarRequest>>();
            services.AddScoped<ICRUDService<Model.KupovinaKnjige, Model.KupovinaKnjigeRequest, Model.KupovinaKnjigeRequest, Model.KupovinaKnjigeRequest>, BaseCRUDService<Model.KupovinaKnjige, Model.KupovinaKnjigeRequest, KupovinaKnjige, Model.KupovinaKnjigeRequest, Model.KupovinaKnjigeRequest>>();
            services.AddScoped<ICRUDService<Model.PrijedlogKnjiga, Model.PrijedlogKnjigaRequest, Model.PrijedlogKnjigaRequest, Model.PrijedlogKnjigaRequest>, BaseCRUDService<Model.PrijedlogKnjiga, Model.PrijedlogKnjigaRequest, PrijedlogKnjiga, Model.PrijedlogKnjigaRequest, Model.PrijedlogKnjigaRequest>>();
            services.AddScoped<IPreporukaService, PreporukaService>();
            services.AddScoped<ICRUDService<Model.KlijentKnjigaOcjena, Model.KlijentKnjigaOcjena, Model.KlijentKnjigaOcijenaRequest, Model.KlijentKnjigaOcijenaRequest>,
                BaseCRUDService<Model.KlijentKnjigaOcjena, Model.KlijentKnjigaOcjena, KlijentKnjigaOcjena, Model.KlijentKnjigaOcijenaRequest, Model.KlijentKnjigaOcijenaRequest>>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                //c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                //c.DocumentFilter<BasicAuthDocumentFilter>();

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });

            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseAuthentication();
             
            //app.UseHttpsRedirection();

            app.UseRouting();

            
           app.UseAuthorization();
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
      
            app.UseSwagger();
           
            
           
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
               
            });

            

        }
    }
}
