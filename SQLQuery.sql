Create table dbo.Products
(
	IDPro int primary key, 
	ProName varchar(max) Not null,
	Pro_Quantity int not null,
	Pro_Des nvarchar(max),
	Pro_Image nvarchar(max),
	IdCate int,
	Pro_Price Nvarchar(max),
	Pro_Type nvarchar(max) not null
);

insert Products values(1,N'Combo Ga Ran A',20,N'2 Mieng Ga Gion Cay + 1 Pepsi Lon','~/Content/Image/ComboA.jpg',1,'79.000 ',N'C')
insert Products values(2,N'Ga Quay (1 Mieng)',20,N'1 Mieng Ga Quay Giay Bac','~/Content/Image/ComboB.jpg',1,'66.000 ',N'M')
insert Products values(3,N'Com Phi Le Ga Gion (1 Phan)',20,N'Com Phi Le Ga Gion (1 Phan)','~/Content/Image/ComboC.jpg',1,'40.000 ',N'M')
insert Products values(4,N'Pho mai vien',20,N'Pho mai vien','~/Content/Image/ComboD.jpg',1,'28.000 ',N'S')
insert Products values(5,N'Khoai tay chien (Vua)',20,N'Khoai tay chien (Vua)','~/Content/Image/ComboE.jpg',1,'14.000 ',N'S')
insert Products values(6,N'Banh Trung',20,N'Banh Trung','~/Content/Image/ComboF.jpg',1,'17.000 ',N'S')
insert Products values(7,N'Hop Milo',20,N'Hop Milo','~/Content/Image/ComboG.jpg',1,'19.000 ',N'D')
insert Products values(8,N'Pepsi Vi Chanh Khong Calo',20,N'Pepsi Vi Chanh Khong Calo','~/Content/Image/ComboH.jpg',1,'17.000 ',N'D')
insert Products values(9,N'Tra dao',20,N'Tra dao','~/Content/Image/ComboI.jpg',1,'23.000 ',N'D')

ALTER TABLE dbo.Products
  ADD Pro_Price Nvarchar(max);

  DELETE  FROM dbo.Products
