CREATE TABLE [dbo].[TournamentEntries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,  
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentEntries_ToTournaments] FOREIGN KEY ([TournamentId]) REFERENCES Tournaments([Id]), 
    CONSTRAINT [FK_TournamentEntries_ToTeams] FOREIGN KEY ([TeamId]) REFERENCES [Teams]([Id])
)
