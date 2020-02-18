CREATE PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT	[People].[Id], 
			[People].[FirstName], 
			[People].[LastName], 
			[People].[EmailAddress], 
			[People].[CellphoneNumber]
	FROM	[dbo].[People];
END
