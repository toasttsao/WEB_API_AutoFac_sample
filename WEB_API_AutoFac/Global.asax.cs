using Autofac;
using Autofac.Configuration;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEB_API_AutoFac
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //取得HttpConfiguration 設定.
            var config = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();
            //讀取web.config設定檔
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            //取得所有API Controller
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            //builder.RegisterWebApiFilterProvider(config);

            // 註冊至Autofac容器內
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}