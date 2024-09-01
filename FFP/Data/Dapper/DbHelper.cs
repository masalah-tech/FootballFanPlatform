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

        private static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
