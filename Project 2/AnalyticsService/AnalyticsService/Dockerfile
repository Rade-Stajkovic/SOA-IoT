#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /src
COPY ./AnalyticsService/AnalyticsService .
RUN dotnet restore
RUN dotnet publish -c Release -o /publish
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /publish
COPY --from=build-env /publish .
ENTRYPOINT [ "dotnet", "AnalyticsService.dll" ]


#FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
#WORKDIR /app
#
#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /src
#COPY ["AnalyticsService/AnalyticsService.csproj", "AnalyticsService/"]
#RUN dotnet restore "AnalyticsService/AnalyticsService.csproj"
#COPY . .
#WORKDIR "/src/AnalyticsService"
#RUN dotnet build "AnalyticsService.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "AnalyticsService.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "AnalyticsService.dll"]