Select
	ProductTexture.ProductId	AS ProductId,
	ProductTexture.TextureId	AS TextureId,
	Texture.TextureName			AS TextureName,
	ProductTexture.Value		AS Value
From
	kashi.MstProductTexture ProductTexture
Inner Join
	Kashi.CmnTexture Texture
On
	ProductTexture.TextureId = Texture.TextureId
Where
	ProductTexture.ProductId = @ProductId