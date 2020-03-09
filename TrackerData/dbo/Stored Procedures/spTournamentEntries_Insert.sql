CREATE PROCEDURE [dbo].[spTournamentEntries_Insert]
	@TournamentId int,
	@TeamId int,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[TournamentEntries] (TournamentId, TeamId)
	VALUES (@TournamentId, @TeamId)

	SELECT @Id = SCOPE_IDENTITY();

END
