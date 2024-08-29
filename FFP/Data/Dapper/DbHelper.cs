using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Saned.Data.Dapper
{
    public class DbHelper
    {
        public static string GetConnectionString()
        {
            var configuartion = GetConfiguration();
            return configuartion.GetConnectionString("DefaultConnection");
        }

        public static string GetMobileConnectionString()
        {
            var configuartion = GetConfiguration();
            return configuartion.GetConnectionString("MobileConnection");
        }

        private static IConfigurationRoot GetConfiguration()
        {
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                return builder.Build();
            }
            catch (Exception ex)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);

                return builder.Build();
            }
        }

    }// end
    
}// NS
