CREATE PROCEDURE [dbo].[spTournaments_Complete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[Tournaments]
	SET Active = 0
	WHERE Id = @Id;

END