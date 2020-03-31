CREATE PROCEDURE [dbo].[spMatchups_Update]
	@Id int,
	@WinnerId int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[Matchups]
	SET WinnerId = @WinnerId
	WHERE id = @id;

END
