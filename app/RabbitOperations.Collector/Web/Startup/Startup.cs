using System;
using NLog;
using NLog.Fluent;
using Owin;

namespace RabbitOperations.Collector.Web.Startup
{
    public class Startup
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public void Configuration(IAppBuilder app)
        {
            try
            {
                Nancy.Json.JsonSettings.MaxJsonLength = 10000000;
                app.MapSignalR();
                app.UseNancy();
            }
            catch (Exception err)
            {
                logger.Error("Failed to start web.", err);
                throw;
            }
        }
    }
}