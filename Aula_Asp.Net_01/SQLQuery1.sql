restore filelistonly
from disk = 'C:\Users\Geovanna\Downloads\AdventureWorks2016.bak'
GO

restore database AdventureWorks2016
from disk = 'C:\Users\Geovanna\Downloads\AdventureWorks2016.bak'
with move 'AdventureWorks2016_Data' to 'C:\Users\Geovanna\Downloads\AdventureWorks2016_Data.mdf',
move 'AdventureWorks2016_log' to 'C:\Users\Geovanna\Downloads\AdventureWorks2016_log.ldf'
GO