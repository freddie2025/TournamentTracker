CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT		[Prizes].[Id], 
				[Prizes].[PlaceNumber], 
				[Prizes].[PlaceName], 
				[Prizes].[PrizeAmount], 
				[Prizes].[PrizePercentage]
	FROM		[dbo].[Prizes]
	INNER JOIN	[dbo].[TournamentPrizes]
	ON			TournamentPrizes.PrizeId = Prizes.Id
	WHERE		TournamentPrizes.TournamentId = @TournamentId;

END