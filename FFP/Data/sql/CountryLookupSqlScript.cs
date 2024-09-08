namespace FFP.WebApp.Data.sql
{
    public class CountryLookupSqlScript
    {
        public static string GetListQuery()
        {
            return "select * from CountriesLookup";
        }
    }
}
