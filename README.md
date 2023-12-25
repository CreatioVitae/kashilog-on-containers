# kashilog-on-containers

## Technology Stacks
* C# 12
* .NET 8
* SQLServer

## Infrastructures
### CI / CD
* Github Actions

### SCM
* Github

## How To Local Dev
この項では、Local開発を行う上で、各種リソースをセットアップする方法を説明する。

### Use MSSQL On Docker
`databases` フォルダの`StartupSqlserver.bat`をダブルクリックする。

### Use Redis On Docker
`redis` フォルダの`RunRedis.bat`をダブルクリックする。

### Use Mail Fake Server
`mail`フォルダの`RunMail.bat`をダブルクリックする。

#### Fake Serverへの接続情報
`server:`  
=> `localhost` ※ Docker To Dockerの場合は`Host.Docker.Internal`  
`port:`  
=> `2197`  

#### mail boxへの接続
http://127.0.0.1:1592/ ※ブラウザでアクセス可能

`dotnet build -c Release --property:AutoSwaggerToFile=true`

### Use Image Mock Server
`image-mock-server\dummy`フォルダの`StartupImageMoqServer.bat`をダブルクリックする。

### Startup Moq Api(他Serviceとの統合テスト時等に利用する用途)
#### 事前条件
KashilogのSQLServerを起動させておくこと。

#### Startup Kashilog Moq Api
`StartupTestApiKashilogContainer.bat`をダブルクリックする。

## Update swagger.json
下記commandを叩くことで生成可能。  
`dotnet build -c Release --property:AutoSwaggerToFile=true`

## Generate ApiClient Samples
`ApiClientExamples` フォルダの`GenerateExampleApiClient.bat`をダブルクリックする。  
`Examples.ApiClient.Kashilog`に.NET8のApiClientが生成される。  

## using EF Core Tools
この項では、EF Coreでのリバースエンジニアリングを行う方法を説明する。
### EF Core ToolsのUpdate
VisualStudio2022のパッケージマネージャーコンソールウインドウで、以下のコマンドを実行する。  
```dotnet tool update -g dotnet-ef```  
※ 基本的には EF Core Scaffold の直前にかけておくと良い。  

### EF Core Scaffold 
VisualStudio2022のパッケージマネージャーコンソールウインドウで、Scaffoldを行いたいProjectを既定のプロジェクトに設定した状態で以下のコマンドを実行する。  
```Scaffold-DbContext "Server=localhost,15331;Database=kashilogdb;user id=sa;password=h0geFuga;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -StartupProject Database.Kashilog -OutputDir EntityDataModels -ContextDir DbContexts -Force -NoOnConfiguring -Context KashilogContext```
