CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT		[People].[Id], 
				[People].[FirstName], 
				[People].[LastName], 
				[People].[EmailAddress], 
				[People].[CellphoneNumber]
	FROM		[dbo].[TeamMembers]
	INNER JOIN	[dbo].[People]
	ON			[People].[Id] = [TeamMembers].[PersonId]
	WHERE		[TeamMembers].[TeamId] = @TeamId;

END