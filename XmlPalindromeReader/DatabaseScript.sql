USE [master]
GO
/****** Object:  Database [PalindromeDatabase]    Script Date: 25-Jul-17 11:03:03 AM ******/
CREATE DATABASE [PalindromeDatabase]
GO
USE [PalindromeDatabase]
GO
/****** Object:  Table [dbo].[Palindrome]    Script Date: 25-Jul-17 11:03:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palindrome](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Word] [nvarchar](max) NOT NULL,
	[IsPalindrome] [bit] NOT NULL,
	[DateTimeStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_Palindrome] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO