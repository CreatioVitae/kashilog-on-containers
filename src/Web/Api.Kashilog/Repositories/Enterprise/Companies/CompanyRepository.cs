using Api.Kashilog.Repositories.Enterprise.Companies.Sqls;
using Database.Kashilog.DbContexts;
using DomainObject.Kashilog.Enterprise;
using ORMIntegrator;
using Service.Extensions.DependencyInjection.Markers;

namespace Api.Kashilog.Repositories.Enterprise.Companies {
    public class CompanyRepository : IRepository {
        private SqlManager<KashilogContext> SqlManager { get; }

        public CompanyRepository(SqlManager<KashilogContext> sqlManager) =>
            SqlManager = sqlManager;

        public Task<IEnumerable<Company>> FindAllCompanyAsync() => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindAllCompany);

        public Task<IEnumerable<Company>> FindCompanyByIdAsync(int id) => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyById, new { Id = id });

        public Task<IEnumerable<Company>> FindCompanyInIdsAsync(IEnumerable<int> ids) => SqlManager.SelectAsync<Company>(SqlForCompanyResource.FindCompanyInIds, new { Ids = ids });
    }
}
