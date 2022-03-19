
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP ROCEDURE dbo.GetallApps

CREATE PROCEDURE dbo.GetallApps
  AS 

 Select * from dbo.svntable;  

GO 