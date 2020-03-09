CREATE PROCEDURE [dbo].[spTournaments_Insert]
	@TournamentName nvarchar(200),
	@EntryFee money,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Tournaments] (TournamentName, EntryFee, Active)
	VALUES(@TournamentName, @EntryFee, 1);

	SELECT @Id = SCOPE_IDENTITY();
END
GO
