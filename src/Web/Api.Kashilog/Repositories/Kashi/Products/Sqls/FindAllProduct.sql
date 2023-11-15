Select
	ProductId				AS ProductId,
	ProductRevision			AS ProductRevision,	
	ValidBeginDateTime		AS ValidBeginDateTime,
	ValidEndDateTime		AS ValidEndDateTime,		
	ProductName				AS ProductName,			
	LargeCategory			AS LargeCategory,		
	MiddleCategory			AS MiddleCategory,
	SmallCategory			AS SmallCategory,			
	UnitPrice				AS UnitPrice,
	Amount					AS Amount,
	AmountType				AS AmountType,
	Description				AS Description,
	MakerCompanyId			AS MakerCompanyId,
	PublisherCompanyId		AS PublisherCompanyId
From
	kashi.MstProduct