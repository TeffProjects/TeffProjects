using System.Configuration;

namespace Student_management_system
{

    //connection string class and a method
    class Helper
    {
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
