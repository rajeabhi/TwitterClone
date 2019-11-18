using System.Configuration;

namespace TwitterClone.App_Code
{
    public static class TweeterDbConnection
    {
        public static string Get
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TweeterConnectionString"].ConnectionString;
            }
        }
    }
}