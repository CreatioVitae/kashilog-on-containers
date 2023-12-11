using Database.Kashilog.DbContexts;
using DomainObject.Kashilog.Enterprise;
using ORMIntegrator;
using Service.Extensions.DependencyInjection.Markers;

namespace Api.Kashilog.Repositories.Enterprise.Companies;

public class CompanyRepository(SqlManager<KashilogContext> sqlManager) : IRepository {
    SqlManager<KashilogContext> SqlManager { get; } = sqlManager;

    public Task<IEnumerable<Company>> FindAllCompanyAsync() =>
        SqlManager.SelectAsync<Company>($"""
            SELECT
                CompanyId			AS CompanyId,
                CompanyName			AS CompanyName,
                ZipCode				AS ZipCode,
                Country				AS Country,
                City				AS City,
                Address				AS Address,
                TelephoneNumber		AS TelephoneNumber
            FROM
                enterprise.CmnCompany
            """);

    public Task<IEnumerable<Company>> FindCompanyByIdAsync(int id) =>
        SqlManager.SelectAsync<Company>($"""
            SELECT
                CompanyId			AS CompanyId,
                CompanyName			AS CompanyName,
                ZipCode				AS ZipCode,
                Country				AS Country,
                City				AS City,
                Address				AS Address,
                TelephoneNumber		AS TelephoneNumber
            FROM
                enterprise.CmnCompany
            WHERE
                CompanyId = @Id
            """,
            new { Id = id });

    public Task<IEnumerable<Company>> FindCompaniesInIdsAsync(IEnumerable<int> ids) =>
        SqlManager.SelectAsync<Company>($"""
            SELECT
                CompanyId			AS CompanyId,
                CompanyName			AS CompanyName,
                ZipCode				AS ZipCode,
                Country				AS Country,
                City				AS City,
                Address				AS Address,
                TelephoneNumber		AS TelephoneNumber
            FROM
                enterprise.CmnCompany
            WHERE
                CompanyId IN @Ids
            """, new { Ids = ids });
}
