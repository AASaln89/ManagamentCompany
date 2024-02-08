using Net14Web.DbStuff.ManagementCompany.Models;
using Net14Web.Models;

namespace Net14Web.DbStuff.Repositories
{
    public class MemberPermissionRepository : ManagementCompanyBaseRepository<MemberPermission>
    {
        public MemberPermissionRepository(ManagementCompanyDbContext context) : base(context) { }

        public void UpdatePermission(PermissionViewModel viewModel, int id)
        {
            var permission = _context.MemberPermissions.Single(x => x.Id == id);

            permission.Permission = viewModel.Permission;

            _context.SaveChanges();
        }
    }
}
