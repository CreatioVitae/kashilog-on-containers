FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Web/Apis/Kashilog/Api.Kashilog.csproj", "src/Web/Apis/Kashilog/"]
COPY ["src/Domain/DomainObjects/Kashilog/DomainObject.Kashilog.csproj", "src/Domain/DomainObjects/Kashilog/"]
COPY ["src/Domain/Repositories/Constraints/Kashilog/Repository.Constraints.Kashilog.csproj", "src/Domain/Repositories/Constraints/Kashilog/"]
COPY ["src/Domain/Repositories/Kashilog/Repository.Kashilog.csproj", "src/Domain/Repositories/Kashilog/"]
COPY ["src/Infrastructure/Databases/Kashilog/Database.Kashilog.csproj", "src/Infrastructure/Databases/Kashilog/"]
COPY ["src/Domain/Services/Constraints/Kashilog/Service.Constraints.Kashilog.csproj", "src/Domain/Services/Constraints/Kashilog/"]
COPY ["src/Domain/Services/Kashilog/Service.Kashilog.csproj", "src/Domain/Services/Kashilog/"]
COPY ["src/Domain/ApiClients/Dummy/ApiClient.Dummy.csproj", "src/Domain/ApiClients/Dummy/"]
COPY ["src/Domain/Caches/Kashilog/Cache.Kashilog.csproj", "src/Domain/Caches/Kashilog/"]
COPY ["src/Web/Web.Kashilog.Core/Web.Kashilog.Core.csproj", "src/Web/Web.Kashilog.Core/"]
RUN dotnet restore "./src/Web/Apis/Kashilog/./Api.Kashilog.csproj"
COPY . .
WORKDIR "/src/src/Web/Apis/Kashilog"
RUN dotnet build "./Api.Kashilog.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Api.Kashilog.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Kashilog.dll"]
