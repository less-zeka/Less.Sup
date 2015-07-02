-- INSERT ROUTES
INSERT INTO [dbo].[Routes]([Name])
VALUES('Schiffenen')
GO
INSERT INTO [dbo].[Routes]([Name])
VALUES('Bern-Bremgarten')
GO

-- Insert Locations
INSERT INTO [dbo].[Locations]([Point] ,[Longitude] ,[Latitude] ,[Info] ,[RouteId])
VALUES (0xE6100000010C1C7DCC0704AA1C409D81919735674740, 7.166031, 46.806323, 'Start', 1)
GO
INSERT INTO [dbo].[Locations]([Point] ,[Longitude] ,[Latitude] ,[Info] ,[RouteId])
VALUES (0xE6100000010C187C9A9317A91C404391EEE714684740, 7.165129, 46.813138 ,'WegPunkt', 1)
GO
INSERT INTO [dbo].[Locations]([Point] ,[Longitude] ,[Latitude] ,[Info] ,[RouteId])
VALUES (0xE6100000010C7AFF1F274CB81C406D1D1CEC4D6E4740, 7.179978, 46.861753, 'Ende', 1)
GO
INSERT INTO [dbo].[Locations]([Point] ,[Longitude] ,[Latitude] ,[Info] ,[RouteId])
VALUES (0xE6100000010C5E81E84999C41D40F8FD9B17277A4740, 7.441991, 46.954318, 'Start', 2)
GO
INSERT INTO [dbo].[Locations]([Point] ,[Longitude] ,[Latitude] ,[Info] ,[RouteId])
VALUES (0xE6100000010C1B66683C11D41D4099D53BDC0E7D4740, 7.457097, 46.977016, 'WegPunkt1', 2)
GO
INSERT INTO [dbo].[Locations]([Point] ,[Longitude] ,[Latitude] ,[Info] ,[RouteId])
VALUES (0xE6100000010C4CFBE6FEEAC11D40C287122D797C4740, 7.439373, 46.972448,'WegPunkt2', 2)
GO
INSERT INTO [dbo].[Locations]([Point] ,[Longitude] ,[Latitude] ,[Info] ,[RouteId])
VALUES (0xE6100000010C58E542E55FAB1D40B682A625567C4740, 7.417358, 46.971379, 'Ende', 2)
GO



