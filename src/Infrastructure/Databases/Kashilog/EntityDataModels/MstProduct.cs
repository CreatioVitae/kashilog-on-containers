using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class MstProduct
{
    public int ProductId { get; set; }

    public int ProductLineUpId { get; set; }

    public int ProductRevision { get; set; }

    public DateTime ValidBeginDateTime { get; set; }

    public DateTime ValidEndDateTime { get; set; }

    public string ProductName { get; set; } = null!;

    public int LargeCategory { get; set; }

    public int MiddleCategory { get; set; }

    public int SmallCategory { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Amount { get; set; }

    public int AmountType { get; set; }

    public string Description { get; set; } = null!;

    public int MakerCompanyId { get; set; }

    public int PublisherCompanyId { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public DateTime LastUpdatedTimeStamp { get; set; }

    public int LastUpdatedSign { get; set; }

    public byte[] Revision { get; set; } = null!;

    public virtual CmnCompany MakerCompany { get; set; } = null!;

    public virtual CmnCompany PublisherCompany { get; set; } = null!;
}
