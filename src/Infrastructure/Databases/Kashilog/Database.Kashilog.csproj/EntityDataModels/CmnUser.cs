using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int RoleId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }

    public virtual ICollection<CmnCompanyUserProperty> CmnCompanyUserProperties { get; set; } = new List<CmnCompanyUserProperty>();

    public virtual ICollection<CmnCustomerUserProperty> CmnCustomerUserProperties { get; set; } = new List<CmnCustomerUserProperty>();

    public virtual ICollection<CmnManagementUserProperty> CmnManagementUserProperties { get; set; } = new List<CmnManagementUserProperty>();

    public virtual ICollection<CmnUserAuthentication> CmnUserAuthentications { get; set; } = new List<CmnUserAuthentication>();

    public virtual CmnRole Role { get; set; } = null!;
}
