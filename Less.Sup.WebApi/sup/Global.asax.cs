using System.Web.Http;
using Less.Sup.WebApi.Models;

namespace Less.Sup.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);

            
            //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseAlways<Sup.WebApi.Models.SupContext>());
            //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseAlways<SupContext>());
            //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<SupContext>());
        }
    }
}