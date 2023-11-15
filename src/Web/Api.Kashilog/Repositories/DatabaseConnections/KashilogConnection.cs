using MicroORMWrapper;
using System.Data.Common;

namespace Api.Kashilog.Repositories.DatabaseConnections {
    public class KashilogConnection : IDatabaseConnection {

        public string ConnectionName { get; set; } = null!;

        public DbConnection DbConnection { get; set; } = null!;
    }
}
