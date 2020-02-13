﻿CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [WinnerId] INT NULL, 
    [MatchupRound] INT NOT NULL, 
    CONSTRAINT [FK_Matchups_ToTeams] FOREIGN KEY ([WinnerId]) REFERENCES [Teams]([Id])
)