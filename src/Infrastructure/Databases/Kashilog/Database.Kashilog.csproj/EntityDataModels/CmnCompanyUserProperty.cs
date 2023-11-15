using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnCompanyUserProperty
{
    public int CompanyUserPropertyId { get; set; }

    public int UserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }

    public virtual CmnUser User { get; set; } = null!;
}
