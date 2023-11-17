FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Web/Api.Kashilog/Api.Kashilog.csproj", "src/Web/Api.Kashilog/"]
COPY ["src/Domain/DomainObject.Kashilog/DomainObject.Kashilog.csproj", "src/Domain/DomainObject.Kashilog/"]
COPY ["src/Infrastructure/Databases/Kashilog/Database.Kashilog.csproj/Database.Kashilog.csproj", "src/Infrastructure/Databases/Kashilog/Database.Kashilog.csproj/"]
RUN dotnet restore "./src/Web/Api.Kashilog/./Api.Kashilog.csproj"
COPY . .
WORKDIR "/src/src/Web/Api.Kashilog"
RUN dotnet build "./Api.Kashilog.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Api.Kashilog.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Kashilog.dll"]
