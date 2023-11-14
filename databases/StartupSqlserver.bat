@echo off
echo Build kashilogdb, kashilogdbtest...

docker build -t kashilogdb .

echo Run kashilogdb, kashilogdbtest...

docker run --name kashilogdb -p 15331:1433 -d kashilogdb 

pause
