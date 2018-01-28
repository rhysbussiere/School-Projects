USE [Library]
GO

/****** Object:  StoredProcedure [dbo].[StephenKing]    Script Date: 1/15/2018 2:02:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[StephenKing]
AS
BEGIN
SELECT
	 B.Title, BC.Copies
	FROM Book_Copies AS BC
INNER JOIN Library_Branch AS LB
	ON BC.Library_BranchID = LB.ID
INNER JOIN Book AS B
	ON BC.BookID = B.ID
INNER JOIN Author AS A
	ON B.ID = A.BookID
	WHERE A.Name = 'Stephen King' and LB.Name = 'Central'
END

GO

