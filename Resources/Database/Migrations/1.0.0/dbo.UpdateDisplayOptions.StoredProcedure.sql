USE [{DATABASE_NAME}]
GO
/****** Object:  StoredProcedure [dbo].[UpdateDisplayOptions]    Script Date: 12/10/2012 22:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDisplayOptions]
	(
	@FavoriteId int,
  @Height int,
  @Width int,
  @Size tinyint,
  @Colors tinyint
	)
AS
	update DisplayOptions 
  set
  Height = @Height, Width = @Width, Size = @Size, Colors = @Colors
    where FavoriteId = @FavoriteId
GO
