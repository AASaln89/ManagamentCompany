using Microsoft.EntityFrameworkCore;
using Net14Web.DbStuff.ManagementCompany.Models;
using Net14Web.DbStuff.ManagementCompany.Models.Enums;

namespace Net14Web.DbStuff.Repositories
{
    public class UserTaskRepository : ManagementCompanyBaseRepository<UserTask>
    {
        public UserTaskRepository(ManagementCompanyDbContext context) : base(context) { }

        public IEnumerable<UserTask> GetInProgressTasks()
        {
            return _entities
                .Include(x => x.Status)
                .Where(x => x.Status.Id != (int)UserTaskStatusEnum.Complete);
        }

        public IEnumerable<UserTask> GetCompletedTasks()
        {
            return _entities
                .Include(x => x.Status)
                .Where(x => x.Status.Id == (int)UserTaskStatusEnum.Complete);
        }

        public IEnumerable<UserTask> GetCurrentUserTasks(User user)
        {
            return _entities
                .Include(t => t.Author)
                .Include(t => t.Status)
                .Where(t => t.Author.Id == user.Id)
                .ToList();
        }
    }
}
