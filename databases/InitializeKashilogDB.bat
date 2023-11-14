@echo off

echo Copy sql file to docker...
docker cp ./initialize-scripts/SetupKashilog.sql kashilogdb:/tmp/SetupKashilog.sql

echo Create data for kashilogdb from sql file...
docker exec -it kashilogdb /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P h0geFuga -i /tmp/SetupKashilog.sql

echo Create data task for kashilogdb is Completed!

pause
