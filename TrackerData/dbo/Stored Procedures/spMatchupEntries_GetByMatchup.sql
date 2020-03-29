CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT	[MatchupEntries].[Id], 
			[MatchupEntries].[MatchupId], 
			[MatchupEntries].[ParentMatchupId], 
			[MatchupEntries].[TeamCompetingId], 
			[MatchupEntries].[Score]
	FROM	[dbo].[MatchupEntries]
	WHERE	[MatchupEntries].[MatchupId] = @MatchupId;

END
