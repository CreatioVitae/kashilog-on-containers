using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class CmnTexture
{
    public int TextureId { get; set; }

    public string TextureName { get; set; } = null!;

    public int? TextureVector { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }
}
