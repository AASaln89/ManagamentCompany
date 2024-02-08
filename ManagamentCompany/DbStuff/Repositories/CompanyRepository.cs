using Microsoft.EntityFrameworkCore;
using Net14Web.DbStuff.ManagementCompany.Models;
using Net14Web.Models;

namespace Net14Web.DbStuff.Repositories
{
    public class CompanyRepository : ManagementCompanyBaseRepository<Company>
    {
        public CompanyRepository(ManagementCompanyDbContext context) : base(context) { }

        public IEnumerable<Company> GetCompaniesWithStatus()
        {
            return _entities
                .Include(x => x.Status)
                .ToList();
        }

        public Company GetCompanyWithStatusById( int id)
        {
            return _entities
                .Include(x => x.Status)
                .First(x => x.Id == id);
        }

        public void UpdateCompany(CompanyViewModel viewModel, int id, int statusId)
        {
            var company = _context.Companies.Include(x => x.Status).First(x => x.Id == id);

            company.Name = viewModel.CompanyName;
            company.ShortName = viewModel.CompanyShortName;
            company.Adress = viewModel.CompanyAdress;
            company.Email = viewModel.CompanyEmail;
            company.PhoneNumber = viewModel.CompanyPhoneNumber;
            company.Status = _context.MemberStatuses.First(x => x.Id == statusId);

            _context.SaveChanges();
        }
    }
}
