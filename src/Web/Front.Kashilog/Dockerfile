FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Web/Front.Kashilog/Front.Kashilog.csproj", "src/Web/Front.Kashilog/"]
COPY ["src/Domain/DomainObject.Kashilog/DomainObject.Kashilog.csproj", "src/Domain/DomainObject.Kashilog/"]
RUN dotnet restore "./src/Web/Front.Kashilog/./Front.Kashilog.csproj"
COPY . .
WORKDIR "/src/src/Web/Front.Kashilog"
RUN dotnet build "./Front.Kashilog.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Front.Kashilog.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Front.Kashilog.dll"]
