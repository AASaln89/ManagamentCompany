using Microsoft.EntityFrameworkCore;
using Net14Web.DbStuff.ManagementCompany.Models;

namespace Net14Web.DbStuff.Repositories
{
    public class ProjectRepository : ManagementCompanyBaseRepository<Project>
    {
        public ProjectRepository(ManagementCompanyDbContext context) : base(context) { }

        public IEnumerable<Project> GetProjectsWithStatus()
        {
            return _entities
                .Include(x => x.Status)
                .Include(x => x.Company)
                .ToList();
        }
    }
}
