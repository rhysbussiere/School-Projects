USE [Library]
GO

/****** Object:  StoredProcedure [dbo].[DueDate]    Script Date: 1/15/2018 2:02:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DueDate]
AS
BEGIN
SELECT
	Book.Title, B.Name, B.Address
	FROM Book
INNER JOIN Loans
	ON Book.ID = Loans.BookID
INNER JOIN Library_Branch AS LB 
	ON Loans.ID = LB.ID
INNER JOIN Borrower AS B
	ON Loans.CardNumber = B.Card_Number
WHERE LB.Name = 'Sharpstown' AND Loans.Due_Date = CONVERT(date, GETDATE())
END

GO

