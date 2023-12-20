# kashilog-on-containers

`dotnet build -c Release --property:AutoSwaggerToFile=true`

## using EF Core Tools
この項では、EF Coreでのリバースエンジニアリングを行う方法を説明する。
### EF Core ToolsのUpdate
VisualStudio2022のパッケージマネージャーコンソールウインドウで、以下のコマンドを実行する。  
```dotnet tool update -g dotnet-ef```  
※ 基本的には EF Core Scaffold の直前にかけておくと良い。  

### EF Core Scaffold 
VisualStudio2022のパッケージマネージャーコンソールウインドウで、Scaffoldを行いたいProjectを既定のプロジェクトに設定した状態で以下のコマンドを実行する。  
```Scaffold-DbContext "Server=localhost,15331;Database=kashilogdb;user id=sa;password=h0geFuga;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -StartupProject Database.Kashilog -OutputDir EntityDataModels -ContextDir DbContexts -Force -NoOnConfiguring -Context KashilogContext```
