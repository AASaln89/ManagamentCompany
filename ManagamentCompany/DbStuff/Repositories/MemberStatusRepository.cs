using Net14Web.DbStuff.ManagementCompany.Models;
using Net14Web.Models;

namespace Net14Web.DbStuff.Repositories
{
    public class MemberStatusRepository : ManagementCompanyBaseRepository<MemberStatus>
    {
        public MemberStatusRepository(ManagementCompanyDbContext context) : base(context) { }

        public void UpdateStatus(StatusViewModel viewModel, int id)
        {
            var status = _context.MemberStatuses.Single(x => x.Id == id);

            status.Status = viewModel.Status;

            _context.SaveChanges();
        }
    }
}
