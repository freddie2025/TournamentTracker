CREATE PROCEDURE [dbo].[spMatchups_Insert]
	@TournamentId int,
	@MatchupRound int,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Matchups] (TournamentId, MatchupRound)
	VALUES(@TournamentId, @MatchupRound);

	SELECT @Id = SCOPE_IDENTITY();

END
