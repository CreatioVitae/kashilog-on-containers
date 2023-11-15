using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnUserAuthentication
{
    public int UserAuthenticationId { get; set; }

    public int UserId { get; set; }

    public string LoginName { get; set; } = null!;

    public string HashedPassword { get; set; } = null!;

    public string? SecurityStamp { get; set; }

    public string? Email { get; set; }

    public DateTime? LockoutEndDate { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public DateTime LastUpdatedSign { get; set; }

    public virtual CmnUser User { get; set; } = null!;
}
