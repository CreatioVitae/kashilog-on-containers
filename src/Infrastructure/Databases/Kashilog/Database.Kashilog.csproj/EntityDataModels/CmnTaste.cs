using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnTaste
{
    public int TasteId { get; set; }

    public string TasteName { get; set; } = null!;

    public int? TasteVector { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }
}
