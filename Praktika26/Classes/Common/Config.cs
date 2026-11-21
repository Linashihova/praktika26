using Microsoft.EntityFrameworkCore;

namespace Praktika26.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=localhost;uid=root;pwd=;database=pcClub";
        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8,0,11));
    }
}
