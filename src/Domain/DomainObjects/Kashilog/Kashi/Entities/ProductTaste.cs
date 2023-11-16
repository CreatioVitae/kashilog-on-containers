namespace DomainObject.Kashilog.Kashi.Entities;

public class ProductTaste {
    public int ProductId { get; set; }
    public int TasteId { get; set; }

    public string TasteName { get; set; } = default!;

    public int Value { get; set; }

}
