
SELECT 'INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N''',MigrationId+''',',ContextKey+',',Model,',''',ProductVersion+''')'
FROM dbo.__MigrationHistory


SELECT 'INSERT [dbo].[WayPoints]([Id], [DbGeography], [Longitude], [Latitude], Info, RouteId)
VALUES (',Id,',',DbGeography,',',Longitude,',',Latitude,',','''',info,''',',RouteId,')'
FROM dbo.WayPoints 