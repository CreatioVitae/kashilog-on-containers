@echo off
echo Build image-moq-nginx-kashilog

docker build -t image-moq-nginx-kashilog .

echo Run image-moq-server-nginx-kashilog...

docker run --name image-moq-server-nginx-kashilog -d -p 8748:80 image-moq-nginx-kashilog

pause
