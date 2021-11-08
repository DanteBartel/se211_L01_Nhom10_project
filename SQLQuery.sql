Create table dbo.Products
(
	IDPro int primary key, 
	ProName varchar(max) Not null,
	Pro_Quantity int not null,
	Pro_Des nvarchar(max),
	Pro_Image nvarchar(max),
	IdCate int,
	Pro_Price Nvarchar(max)
);

insert Products values(1,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(2,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(3,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(4,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(5,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(6,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(7,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(8,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')
insert Products values(9,N'CheckendA',20,N'Fired Chickend spicy','~/Content/Image/ComboA.jpg',1,'79.000 ')

ALTER TABLE dbo.Products
  ADD Pro_Price Nvarchar(max);

  DELETE  FROM dbo.Products
