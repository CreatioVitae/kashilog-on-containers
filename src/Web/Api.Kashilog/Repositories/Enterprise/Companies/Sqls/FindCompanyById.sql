Select
	CompanyId			AS CompanyId,
	CompanyName			AS CompanyName,
	ZipCode				AS ZipCode,
	Country				AS Country,
	City				AS City,
	Address				AS Address,
	TelephoneNumber		AS TelephoneNumber
From
	enterprise.CmnCompany
Where
	CompanyId = @Id