#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PN.WeatherForecast.API.csproj", "./"]
RUN dotnet restore "PN.WeatherForecast.API.csproj"
COPY . .
RUN dotnet publish "PN.WeatherForecast.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "PN.WeatherForecast.API.dll"]