﻿-- INSERT ROUTES
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

-- truncate table __MigrationHistory
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'	201507031503187_V1',	Less.Sup.WebApi.Migrations.Configuration,	0x1F8B0800000000000400ED59CD6EE33610BE17E83B083AB545D6B2B397D6B07791DAC9C268120751B2DB5B404B639B2845AA2215D828FA643DF491FA0A1DFD9AA2245BF6268BB628020436C9F9E67F3843FFF5C79FA3F79B8059CF10492AF8D81EF4FAB605DC133EE5ABB11DABE59BEFEDF7EFBEFE6A74E9071BEB6371EE6D720E29B91CDB6BA5C2A1E3486F0D0191BD807A919062A97A9E081CE20BE7BCDFFFC1190C1C40081BB12C6B741F73450348BFE0D789E01E842A26EC46F8C064BE8E3B6E8A6ADD920064483C18DBD72065CF8DC3DE27585C84B49751D8D605A304A571812D6D8B702E145128EBF05182AB22C1576E880B843D6C43C0734BC224E43A0C77C7BBAAD33F4FD47176840594174B25822301076F73FB3826F94956B64BFBA1052FD1D26A9B689D5A716CDF8B58A1E626A7E18445C9A9360BF752BA33CBD83D2B83026327F93BB32631537104630EB18A083BB3EEE205A3DE4FB07D10BF001FF398315D441412F72A0BB87417891022B5BD87652EF8CCB72DA74AE79884259946936935E3EAEDB96DDD2273B26050468066015789083E00878828F0EF885210F10403521BD6B81BBC92FF05370C39CC20DBBA219B6BE02BB51EDBF8D1B6AEE806FC622597E091534C382452510C3526B7E499AE52F90C769FC8F64E50AE30F6EF81A527E49A86590AF48ADDA7DCDD579108EE05D3E8B29DA70712AD40A1DCA271DB1571E419528D9C5D50ED0DB502EB84682B48FF0FB8765ED3C50710AB8884EB6DC1545BD84F7B8D1591AAD82F23762AD068D020EF011CD4E40560667C295E3E770C2669441F7650D704CC33EB7392AFC8AE96E42B72B34BF25D48293C9A4A62645F2E4555AB4BEE5BFB45CA7CA1AB832EC14CA321E6160A30B6BFABD9AA15B5AC323BD4DC3655C8816DA6E59C4F818102EBC2CBEED309911EF1EB7E42BBF8D515CC64889254220C3B0C89B50105AAA73DE51E0D09DB2BB841D5B15C245295F8E6CE1442E049A6EFF54317C6655CD7B9974C0C5B1D32CDC8D1E2A95EE39146210544B904589E9325D834957AECC0F26A2FF33C358326817441E9EAE0ADB68BF36AC4D462AE4AAEDD8B35845D241B209AB675A4228DB543CD896E9AFF609295B257C4AEB9F1605A693885F5CCECA86AD850504A9FEEBA6F276BBF8B36DD69E9D34737240CB1646B7D7BBE62B959D33E79E31EDFC9061986E3C98686B694B6E48477295981B18BAC51D22B1A4935258A2C4852E0277E503BA645704B78158C2A415AF7541171C5F1E4737E55EEE9AB1BF23C07B842AD82A44AA4CD82E9E83A5D3A341146A286C66422581CF0F66AD54E9DF5B63A7DB65247183986E0B59A54B351AD8E572DDEC91FBBF47901979465E278AFB493BE8E632A3DA00E53D9E88EA7F5853A9AB67C0456D91B56A0CAD5EE48597B58B152BAD21DA1BC237590D68BF395C3B85672CD2325F7B2F41A25769497BBC3EF25B5FA971DB12D34D033F5D3DAB7950A825E72A0E7FECA268C42724516076E08A74B902A1BA6ECF3FEE0DC786EF9E73C7D3852FAACCBFBC7171F07D3AEE3E0C077E4D8A43F39F06712796B127D1390CDB73A527D343A7E80FF6F98AB61605EED16F659ACC300BD6482A8CF9E9F4F43D1C7E723E2E0E088DCFC7633C3896233B67F4B6986D6ECE7A79CECCC9A4758308656DFFAFD800E2F3EC6E63DFA171D30EB7DF98973F349936A5BE3F86A93E9BF6418AD77FC1DE6CDF67133BB2FC7B6BF48522C0BE89621AB6D14DD3B8936E1B70E83AF3EA8568CA1CD195D86D2C679F67526D17AFB8361A4FDA884312CE96A0791FCC4C4C1AB04507926A99E45201B1215478C3279038AF8185D1791A24BE229DCF67094489F2D3F1216E391CB6001FE8CCF6315C60A558660C12A9D78920FFBF8A7E37655E6D13C4C5F1A5F42051493A20A30E73FC694F9A5DC570DB5BA052249B4FC764E7CA9925B7AB52D916E05EF08949BAFAC0F0F10840CC1E49CBBE4194E91ED51C235AC88B72DBAD87690C38EA89A7D34A5047B8640E6183B7AFC8A31EC079B777F03D2FE0EBD5B1D0000	,'	6.1.3-40302')



INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (	1	,	0xE6100000010C1C7DCC0704AA1C409D81919735674740	,	7.166031	,	46.806323	,	'	Start	',	1	)
INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (	2	,	0xE6100000010C187C9A9317A91C404391EEE714684740	,	7.165129	,	46.813138	,	'	WegPunkt	',	1	)
INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (	3	,	0xE6100000010C7AFF1F274CB81C406D1D1CEC4D6E4740	,	7.179978	,	46.861753	,	'	Ende	',	1	)
INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (	4	,	0xE6100000010C5E81E84999C41D40F8FD9B17277A4740	,	7.441991	,	46.954318	,	'	Start	',	2	)
INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (	5	,	0xE6100000010C1B66683C11D41D4099D53BDC0E7D4740	,	7.457097	,	46.977016	,	'	WegPunkt1	',	2	)
INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (	6	,	0xE6100000010C4CFBE6FEEAC11D40C287122D797C4740	,	7.439373	,	46.972448	,	'	WegPunkt2	',	2	)
INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (	7	,	0xE6100000010C58E542E55FAB1D40B682A625567C4740	,	7.417358	,	46.971379	,	'	Ende	',	2	)