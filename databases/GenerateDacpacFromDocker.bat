@echo off
echo clean up...
docker exec -i -t -d kashilogdb rm -r -f /tmp/dacpac
docker exec -t -t -d kashilogdb mkdir /tmp/dacpac

echo create kashilogdb.dacpac...
docker exec -i -t -d kashilogdb /opt/sqlpackage/sqlpackage /Action:Extract /ssn:localhost /sec:False /sdn:KashiLogDB /su:sa /sp:h0geFuga /tf:/tmp/dacpac/kashilogdb.dacpac

echo Loop until create dacpac...
:FILECHECK

for /f "usebackq delims=" %%A in (`docker exec -i -t -w /tmp/dacpac kashilogdb ls -l`) do set FILELIST=%%A

set SEARCH=kashilogdb.dacpac

echo "%FILELIST%" | find "%SEARCH%" >NUL
if not ERRORLEVEL 1 goto END

goto FILECHECK

:END

echo copy kashilogdb.dacpac from kashilogdb container...
if not exist dacpacs\dacpac-generated-results mkdir dacpacs\dacpac-generated-results

docker cp kashilogdb:/tmp/dacpac/kashilogdb.dacpac ./dacpacs/dacpac-generated-results/KashiLogDB.dacpac

echo remove kashilogdb.dacpac in kashilogdb container...
docker exec -i -t -d kashilogdb rm /tmp/dacpac/kashilogdb.dacpac

pause
