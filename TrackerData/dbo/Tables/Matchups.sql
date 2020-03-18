CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [WinnerId] INT NULL, 
    [MatchupRound] INT NOT NULL, 
    CONSTRAINT [FK_Matchups_ToTeams] FOREIGN KEY ([WinnerId]) REFERENCES [Teams]([Id]), 
    CONSTRAINT [FK_Matchups_ToTournaments] FOREIGN KEY ([TournamentId]) REFERENCES [Tournaments]([Id])
)
