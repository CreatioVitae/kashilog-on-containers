using DomainObject.Kashilog.Enterprise;

namespace Repository.Constraints.Kashilog.Enterprise;
public interface ICompaniesRepository {
    Task<IEnumerable<Company>> FindAllCompanyAsync();
    Task<IEnumerable<Company>> FindCompaniesInIdsAsync(IEnumerable<int> ids);
    Task<IEnumerable<Company>> FindCompanyByIdAsync(int id);
}
