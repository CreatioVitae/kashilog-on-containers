FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Management.Kashilog/Management.Kashilog.csproj", "Management.Kashilog/"]
RUN dotnet restore "Management.Kashilog/Management.Kashilog.csproj"
COPY . .
WORKDIR "/src/Management.Kashilog"
RUN dotnet build "Management.Kashilog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Management.Kashilog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Management.Kashilog.dll"]