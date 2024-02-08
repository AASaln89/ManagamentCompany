using Net14Web.DbStuff.ManagementCompany.Models;
using Net14Web.Models;

namespace Net14Web.DbStuff.Repositories
{
    public class TaskStatusRepository : ManagementCompanyBaseRepository<UserTaskStatus>
    {
        public TaskStatusRepository(ManagementCompanyDbContext context) : base(context) { }

        public void UpdateStatus(StatusViewModel viewModel, int id)
        {
            var status = _context.TaskStatuses.Single(x => x.Id == id);

            status.Status = viewModel.Status;

            _context.SaveChanges();
        }
    }
}
