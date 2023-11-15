using DomainObject.Kashilog.Enterprise;
using MicroORMWrapper;
using Service.Extensions.DependencyInjection.Markers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Kashilog.Repositories.DatabaseConnections;
using Api.Kashilog.Repositories.Enterprise.Companies.Sqls;

namespace Api.Kashilog.Repositories.Enterprise.Companies {
    public class CompanyRepository : IRepository {
        private SqlManager<KashilogConnection> SqlManager { get; }

        public CompanyRepository(SqlManager<KashilogConnection> sqlManager) => SqlManager = sqlManager;

        public Task<IEnumerable<Company>> FindAllCompanyAsync() => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindAllCompany);

        public Task<IEnumerable<Company>> FindCompanyByIdAsync(int id) => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyById, new { Id = id });

        public Task<IEnumerable<Company>> FindCompanyInIdsAsync(IEnumerable<int> ids) => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyInIds, new { Ids = ids });
    }
}
