using MagiQL.Framework.Interfaces;
using MagiQL.Service.WebAPI.Routes;
using MagiQL.Service.WebAPI.StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using MagiQL.StarterProject.DataAdapter1;

namespace MagiQL.StarterProject.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        // enable if you want log4net
        // private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            try
            {
                // enable if you want log4net
                //log4net.Config.XmlConfigurator.Configure();  

                // setup structuremap and configure datasources
                GlobalConfiguration.Configuration.ConfigureStructureMapForMagiQL<WebApiApplication, NullLoggingProvider>(
                    x =>
                    {
                    // your data source implementations
                        x.For<IReportsDataSource>().Use<MyDataSource1>();
                        //x.For<IReportsDataSource>().Use<MyDataSource2>();
                    });

                // use the MagiQL API Controllers
                GlobalConfiguration.Configuration.UseMagiQLApi();

                //CustomisationsRegistration.RegisterAllCustomisations();
            }
            catch (Exception e)
            {
                try
                {
                    // enable if you want log4net
                    //Log.Error(e);
                    System.Diagnostics.Debug.WriteLine(e);
                }
                catch
                {
                    // We're stuffed. 
                }

                throw;
            }
        }
    }
}
