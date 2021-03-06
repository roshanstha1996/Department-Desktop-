USE [AasthaDB]
GO
/****** Object:  Table [dbo].[BillTable]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillTable](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[SalesCodeId] [int] NULL,
	[Vat] [numeric](18, 2) NULL,
	[Discount] [numeric](18, 2) NULL,
	[NetTotal] [numeric](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryTable]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTable](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](100) NULL,
	[Description] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTable]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTable](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryId] [int] NULL,
	[ProductName] [varchar](100) NULL,
	[Rate] [numeric](18, 2) NULL,
	[QuantityInStock] [int] NULL,
	[ThresholdValue] [int] NULL,
	[MfgDate] [date] NULL,
	[ExpDate] [date] NULL,
	[Remarks] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesCodeTable]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesCodeTable](
	[SalesCodeId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](100) NULL,
	[SalesDate] [date] NULL,
	[CustomerEmail] [varchar](100) NULL,
	[ContactNumber] [varchar](30) NULL,
	[Address] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesCodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesTable]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesTable](
	[SalesId] [int] IDENTITY(1,1) NOT NULL,
	[SalesCodeId] [int] NULL,
	[ProductId] [int] NULL,
	[SalesQuantity] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategoryTable]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategoryTable](
	[SubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[SubCategoryName] [varchar](100) NULL,
	[Description] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[UserType] [varchar](30) NULL,
	[Role] [varchar](50) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDate] [varchar](40) NULL,
	[IsActive] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BillTable]  WITH CHECK ADD FOREIGN KEY([SalesCodeId])
REFERENCES [dbo].[SalesCodeTable] ([SalesCodeId])
GO
ALTER TABLE [dbo].[ProductTable]  WITH CHECK ADD FOREIGN KEY([SubCategoryId])
REFERENCES [dbo].[SubCategoryTable] ([SubCategoryId])
GO
ALTER TABLE [dbo].[SalesTable]  WITH CHECK ADD FOREIGN KEY([SalesCodeId])
REFERENCES [dbo].[SalesCodeTable] ([SalesCodeId])
GO
ALTER TABLE [dbo].[SubCategoryTable]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[CategoryTable] ([CategoryId])
GO
/****** Object:  StoredProcedure [dbo].[ManageBill]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[ManageBill]
(
@BillId int,
@SalesCodeId int,
@Vat numeric(18,2),
@Discount numeric(18,2),
@NetTotal numeric(18,2),
@Mode int
)
as
begin
if(@Mode=1)
insert into BillTable(
SalesCodeId,
Vat,
Discount,
NetTotal) 
values 
(
@SalesCodeId,
@Vat,
@Discount,
@NetTotal)
if(@Mode=2)
Update BillTable set 
SalesCodeId = @SalesCodeId,
Vat = @Vat,
NetTotal= @NetTotal,
Discount = @Discount where BillId =@BillId 
if(@Mode=3)
Delete from BillTable where BillId =@BillId 
end
GO
/****** Object:  StoredProcedure [dbo].[ManageProducts]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[ManageProducts]
(
@ProductId int,
@SubCategoryId int,
@ProductName varchar(100),
@Rate numeric(18,2),
@QuantityInStock int,
@ThresholdValue int,
@MfgDate date,
@ExpDate date,
@Mode int
)
as
begin
if(@Mode=1)
insert into ProductTable(SubCategoryId,
ProductName,
Rate,
QuantityInStock,
ThresholdValue,
MfgDate,
ExpDate) values (@SubCategoryId,
@ProductName,
@Rate,
@QuantityInStock,
@ThresholdValue,
@MfgDate,
@ExpDate)
if(@Mode=2)
Update ProductTable set SubCategoryId=@SubCategoryId,
ProductName=@ProductName,
Rate=@Rate,
QuantityInStock=@QuantityInStock,
ThresholdValue=@ThresholdValue,
MfgDate=@MfgDate,
ExpDate=@ExpDate where ProductId=@ProductId
if(@Mode=3)
Delete from ProductTable where ProductId=@ProductId
end
GO
/****** Object:  StoredProcedure [dbo].[ManageSCT]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ManageSCT]
(
@SalesCodeId  int,
@CustomerName varchar(100),
@SalesDate date,
@CustomerEmail varchar(100),
@ContactNumber varchar(30),
@Address varchar(200),
@Mode int
)
as
begin
if(@Mode=1)
insert into SalesCodeTable(
CustomerName,
SalesDate,
CustomerEmail,
ContactNumber,
Address) 
values 
(
@CustomerName,
@SalesDate,
@CustomerEmail,
@ContactNumber,
@Address)
if(@Mode=2)
Update SalesCodeTable set 
CustomerName = @CustomerName,
SalesDate= @SalesDate,
CustomerEmail = @CustomerEmail,
ContactNumber = @ContactNumber,
Address = @Address where SalesCodeId=@SalesCodeId
if(@Mode=3)
Delete from SalesCodeTable where SalesCodeId=@SalesCodeId
end
GO
/****** Object:  StoredProcedure [dbo].[ManageST]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[ManageST]
(
@SalesId int,
@SalesCodeId int,
@ProductId varchar(100),
@SalesQuantity int,
@Mode int
)
as
begin
if(@Mode=1)
insert into SalesTable(
SalesCodeId,
ProductId,
SalesQuantity)
 values 
(
@SalesCodeId,
@ProductId,
@SalesQuantity
)
if(@Mode=2)
Update SalesTable set SalesCodeId = @SalesCodeId,
ProductId = @ProductId,
SalesQuantity = @SalesQuantity where SalesId=@SalesId
if(@Mode=3)
Delete from SalesTable where SalesId=@SalesId
end
GO
/****** Object:  StoredProcedure [dbo].[ManageUser]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[ManageUser]
(
@UserId int,
@UserName varchar(100),
@Password varchar(100),
@UserType varchar(30),
@Role varchar(50),
@CreatedBy varchar(50),
@CreatedDate varchar(40),
@IsActive varchar(50),
@Mode int
)
as
begin
if(@Mode=1)
insert into UserTable(
UserName,
Password,
UserType,
Role,
CreatedBy,
CreatedDate,
IsActive) 
values 
(
@UserName,
@Password,
@UserType,
@Role,
@CreatedBy,
@CreatedDate,
@IsActive)
if(@Mode=2)
Update UserTable set 
UserName = @UserName,
Password = @Password,
UserType = @UserType,
Role = @Role,
CreatedBy = @CreatedBy,
CreatedDate= @CreatedDate,
IsActive = @IsActive where UserId =@UserId 
if(@Mode=3)
Delete from UserTable where UserId =@UserId 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ManageCategory]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_ManageCategory]
(
@CategoryId int,
@CategoryName varchar(100),
@Description varchar(max),
@Mode int
)
as
begin
if(@Mode=1)
insert into CategoryTable(CategoryName,Description) values (@CategoryName,@Description)
if(@Mode=2)
Update CategoryTable set CategoryName=@CategoryName,Description=@Description where CategoryId=@CategoryId
if(@Mode=3)
Delete from CategoryTable where CategoryId=@CategoryId
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ManageSubCategory]    Script Date: 24-Dec-20 7:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[SP_ManageSubCategory]
(
@SubCategoryId int,
@CategoryId int,
@SubCategoryName varchar(100),
@Description varchar(max),
@Mode int
)
as
begin
if(@Mode=1)
insert into SubCategoryTable(CategoryId,SubCategoryName,Description) values (@CategoryId,@SubCategoryName,@Description)
if(@Mode=2)
Update SubCategoryTable set CategoryId=@CategoryId,SubCategoryName=@SubCategoryName,Description=@Description where SubCategoryId=@SubCategoryId
if(@Mode=3)
Delete from SubCategoryTable where SubCategoryId=@SubCategoryId
end
GO


insert into UserTable values ('admin','admin','Main','Super','Sadmin', GETDATE(), 'Active');
GO
