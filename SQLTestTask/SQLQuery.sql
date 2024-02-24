/*
Предполагаю, что таблицы уже созданы, имеют структуру:
dbo.Product (
	ID int not null,
	Name varchar(255) null
	PK ID identity(1,1)
)
dbo.Category (
	ID int not null,
	Name varchar(255) null,
	ID_Product int null
	PK ID identity(1,1),
	FK ID_Product dbo.Product ID
)
*\

select
	p.Name as ProductName
	,c.Name as CategoryName
from dbo.Product as p
	left join dbo.Category as c on c.ID_Product = p.ID
