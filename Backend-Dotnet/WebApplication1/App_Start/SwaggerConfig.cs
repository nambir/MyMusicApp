using System.Web.Http;
using WebActivatorEx;
using WebApplication1;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApplication1
{
    /// <summary>
    /// 
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration

                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "SongsWebAPI");
                    c.IncludeXmlComments(string.Format(@"{0}\bin\WebApplication1.xml", 
                                         System.AppDomain.CurrentDomain.BaseDirectory));
                })
               .EnableSwaggerUi();



            
        }
    }
}