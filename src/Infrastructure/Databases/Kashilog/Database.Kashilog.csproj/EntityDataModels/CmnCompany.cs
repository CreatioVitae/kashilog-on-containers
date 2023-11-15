using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnCompany
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string TelephoneNumber { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }

    public virtual ICollection<MstProduct> MstProductMakerCompanies { get; set; } = new List<MstProduct>();

    public virtual ICollection<MstProduct> MstProductPublisherCompanies { get; set; } = new List<MstProduct>();
}
