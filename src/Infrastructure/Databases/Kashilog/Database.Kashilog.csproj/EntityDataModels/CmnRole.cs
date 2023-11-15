using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }

    public virtual ICollection<CmnRoleAcl> CmnRoleAcls { get; set; } = new List<CmnRoleAcl>();

    public virtual ICollection<CmnUser> CmnUsers { get; set; } = new List<CmnUser>();
}
