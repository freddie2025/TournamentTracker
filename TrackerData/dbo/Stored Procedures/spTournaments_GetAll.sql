CREATE PROCEDURE [dbo].[spTournaments_GetAll]
AS
BEGIN

	SET NOCOUNT ON;
	
	SELECT	Tournaments.Id, 
			Tournaments.TournamentName, 
			Tournaments.EntryFee, 
			Tournaments.Active
	FROM	[dbo].[Tournaments]
	WHERE	Active = 1;

END