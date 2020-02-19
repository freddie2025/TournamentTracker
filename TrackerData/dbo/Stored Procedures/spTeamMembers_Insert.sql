CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
	@TeamId int,
	@PersonId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[TeamMembers] (TeamId, PersonId)
	VALUES (@TeamId, @PersonId)

	SELECT @Id = SCOPE_IDENTITY();
END
GO
