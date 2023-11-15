Select
	ProductTaste.ProductId	AS ProductId,
	ProductTaste.TasteId	AS TasteId,
	Taste.TasteName			AS TasteName,
	ProductTaste.Value		AS Value
From
	kashi.MstProductTaste ProductTaste
Inner Join
	Kashi.CmnTaste Taste
On
	ProductTaste.TasteId = Taste.TasteId
Where
	ProductTaste.ProductId In @ProductIds