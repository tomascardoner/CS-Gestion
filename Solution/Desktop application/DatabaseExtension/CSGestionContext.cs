using System.Data.Entity;

namespace CS_Gestion
{
    public partial class CSGestionContext : DbContext
    {
        static public string ConnectionString;

        public CSGestionContext(bool useCustomConnectionString)
            : base(ConnectionString)
        {
        }
    }
}