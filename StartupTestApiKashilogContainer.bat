docker build -f src/Web/Apis/Kashilog/Dockerfile -t test-api-kashilog .
docker run --name Test.Api.kashilog -d -p 51913:5000 -e ASPNETCORE_ENVIRONMENT="Development" -e ASPNETCORE_URLS="http://0.0.0.0:5000" -e kashilogDatabaseConfig__connectionString="Data Source=host.docker.internal,15331;Initial Catalog=KashiLogDB;TrustServerCertificate=True;User ID=sa;Password=h0geFuga;Pooling=true;Max Pool Size=20;Min Pool Size=5;MultipleActiveResultSets=True;" -e kashilogDatabaseConfig__applicationName="Mock.Api.Kashilog" test-api-kashilog

pause
