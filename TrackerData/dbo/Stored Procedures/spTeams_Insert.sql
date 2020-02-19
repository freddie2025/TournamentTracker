CREATE PROCEDURE [dbo].[spTeams_Insert]
	@TeamName nvarchar(100),
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Teams] (TeamName)
	VALUES (@TeamName)

	SELECT @Id = SCOPE_IDENTITY();
END
GO