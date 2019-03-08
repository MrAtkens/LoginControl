FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY EarthqueakeApi/EarthqueakeApi.csproj EarthqueakeApi/
RUN dotnet restore EarthqueakeApi/EarthqueakeApi.csproj
COPY . .
WORKDIR /src/EarthqueakeApi
RUN dotnet build EarthqueakeApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish EarthqueakeApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EarthqueakeApi.dll"]
