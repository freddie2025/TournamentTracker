CREATE TABLE [dbo].[MatchupEntries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MatchupId] INT NOT NULL, 
    [ParentMatchupId] INT NULL, 
    [TeamCompetingId] INT NULL, 
    [Score] DECIMAL NULL, 
    CONSTRAINT [FK_MatchupEntries_ToMatchups] FOREIGN KEY ([MatchupId]) REFERENCES [Matchups]([Id]), 
    CONSTRAINT [FK_MatchupEntries_ToParentMatchups] FOREIGN KEY ([ParentMatchupId]) REFERENCES [Matchups]([Id]), 
    CONSTRAINT [FK_MatchupEntries_ToTeams] FOREIGN KEY ([TeamCompetingId]) REFERENCES [Teams]([Id])
)
