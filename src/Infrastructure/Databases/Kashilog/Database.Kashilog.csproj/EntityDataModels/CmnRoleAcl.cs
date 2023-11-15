using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnRoleAcl
{
    public int RoleAclId { get; set; }

    public int RoleId { get; set; }

    public int AuthorityForKashi { get; set; }

    public int AuthorityForEnterprise { get; set; }

    public int AuthorityForAccount { get; set; }

    public DateTime CreateDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }

    public virtual CmnRole Role { get; set; } = null!;
}
