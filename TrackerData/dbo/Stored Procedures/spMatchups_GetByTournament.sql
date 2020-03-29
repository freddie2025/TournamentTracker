CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
	@TournamentId int
AS
BEGIN 

	SET NOCOUNT ON;

	SELECT		[Matchups].[Id], 
				[Matchups].[TournamentId], 
				[Matchups].[WinnerId], 
				[Matchups].[MatchupRound]
	FROM		[dbo].[Matchups]
	WHERE		Matchups.TournamentId = @TournamentId
	ORDER BY	Matchups.MatchupRound;

END
