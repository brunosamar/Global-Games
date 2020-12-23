#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["GlobalGames_BrunoSa_Marques/GlobalGames_BrunoSa_Marques.csproj", "GlobalGames_BrunoSa_Marques/"]
RUN dotnet restore "GlobalGames_BrunoSa_Marques/GlobalGames_BrunoSa_Marques.csproj"
COPY . .
WORKDIR "/src/GlobalGames_BrunoSa_Marques"
RUN dotnet build "GlobalGames_BrunoSa_Marques.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GlobalGames_BrunoSa_Marques.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GlobalGames_BrunoSa_Marques.dll"]