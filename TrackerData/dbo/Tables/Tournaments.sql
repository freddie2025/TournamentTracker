CREATE TABLE [dbo].[Tournaments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TournamentName] NVARCHAR(50) NOT NULL, 
    [EntryFee] MONEY NOT NULL
)
