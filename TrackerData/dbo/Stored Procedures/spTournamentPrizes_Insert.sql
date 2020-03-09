CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert]
	@TournamentId int,
	@PrizeId int,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[TournamentPrizes] (TournamentId, PrizeId)
	VALUES (@TournamentId, @PrizeId);

	SELECT @Id = SCOPE_IDENTITY();
END
