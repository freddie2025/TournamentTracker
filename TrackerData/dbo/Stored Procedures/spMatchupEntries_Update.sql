CREATE PROCEDURE [dbo].[spMatchupEntries_Update]
	@Id int,
	@TeamCompetingId int = null,
	@Score float = null
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE	[dbo].[MatchupEntries]
	SET		TeamCompetingId = @TeamCompetingId,
			Score = @Score 
	WHERE	Id = @Id;

END
