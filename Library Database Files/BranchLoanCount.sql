USE [Library]
GO

/****** Object:  StoredProcedure [dbo].[BranchLoanCount]    Script Date: 1/15/2018 2:01:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BranchLoanCount]
AS
BEGIN
SELECT 
	LB.Name, COUNT(Loans.ID) AS 'Number of Loans'
FROM Loans
INNER JOIN Library_Branch AS LB
    ON Loans.ID = LB.ID
GROUP BY LB.Name
END

GO

