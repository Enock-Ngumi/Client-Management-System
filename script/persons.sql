CREATE TABLE [dbo].[persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phonenumber] [numeric](18, 0) NOT NULL,
	[dateofbirth] [varchar](50) NOT NULL,
