using System;
using System.Collections.Generic;

namespace Database.Kashilog.EntityDataModels;

public partial class MstProductTexture
{
    public int ProductTextureId { get; set; }

    public int ProductId { get; set; }

    public int TextureId { get; set; }

    public int? Value { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime LastUpdatedDateTime { get; set; }

    public int LastUpdatedSign { get; set; }
}
