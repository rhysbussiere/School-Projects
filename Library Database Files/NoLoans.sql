USE [Library]
GO

/****** Object:  StoredProcedure [dbo].[NoLoans]    Script Date: 1/15/2018 2:02:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NoLoans]
AS
BEGIN
SELECT B.Name
    FROM Borrower AS B
LEFT JOIN Loans
    ON Loans.CardNumber = B.Card_Number
WHERE Loans.CardNumber IS NULL
END

GO

