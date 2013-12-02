declare @db nvarchar(20)
set @db='你的数据库名称'

dump transaction @db with no_log
backup log @db with no_log

dbcc shrinkdatabase(@db)