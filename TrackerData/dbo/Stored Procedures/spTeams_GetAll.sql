CREATE PROCEDURE [dbo].[spTeams_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT	[Teams].[Id], 
			[Teams].[TeamName]
	FROM	[dbo].[Teams];

END