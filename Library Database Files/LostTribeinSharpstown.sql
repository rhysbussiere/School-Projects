USE [Library]
GO

/****** Object:  StoredProcedure [dbo].[LostTribeInSharpstown]    Script Date: 1/15/2018 2:02:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LostTribeInSharpstown]
AS
BEGIN
SELECT
	 LB.Name, BC.Copies
	FROM Book_Copies AS BC
INNER JOIN Library_Branch AS LB
	ON BC.Library_BranchID = LB.ID
INNER JOIN Book AS B
	ON BC.BookID = B.ID
	WHERE B.Title = 'The Lost Tribe' and LB.Name = 'Sharpstown'
END

GO
