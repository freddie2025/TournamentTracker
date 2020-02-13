CREATE TABLE [dbo].[Prizes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlaceNumber] INT NOT NULL, 
    [PlaceName] NVARCHAR(50) NOT NULL, 
    [PrizeAmount] MONEY NOT NULL, 
    [PrizePercentage] FLOAT NOT NULL
)
