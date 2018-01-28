USE [Library]
GO

/****** Object:  StoredProcedure [dbo].[BorrowerBookCount]    Script Date: 1/15/2018 2:01:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BorrowerBookCount]
AS
BEGIN
SELECT 
	B.Name, B.Address, COUNT(Loans.ID) AS 'Number of Loans'
FROM Loans
INNER JOIN Library_Branch AS LB
    ON Loans.ID = LB.ID
INNER JOIN Borrower AS B
	ON Loans.CardNumber = B.Card_Number
GROUP BY B.Name, B.Address
HAVING COUNT(Loans.ID) > 5
END

GO

