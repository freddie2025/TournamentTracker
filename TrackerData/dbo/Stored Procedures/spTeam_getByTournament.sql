CREATE PROCEDURE [dbo].[spTeam_getByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT		[Teams].[Id], 
				[Teams].[TeamName]
	FROM		[dbo].[Teams]
	INNER JOIN	[dbo].[TournamentEntries]
	ON			TournamentEntries.TeamId = Teams.Id
	WHERE		[TournamentEntries].[TournamentId] = @TournamentId;

END