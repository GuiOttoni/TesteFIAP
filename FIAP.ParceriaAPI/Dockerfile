#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 5555
EXPOSE 5556
ENV ASPNETCORE_URLS=https://+:5556;http://+:5555

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["FIAP.ParceriaAPI/FIAP.ParceriaAPI.csproj", "FIAP.ParceriaAPI/"]
RUN dotnet restore "FIAP.ParceriaAPI/FIAP.ParceriaAPI.csproj"
COPY . .
WORKDIR "/src/FIAP.ParceriaAPI"
RUN dotnet build "FIAP.ParceriaAPI.csproj" -c Release -o /app/build
RUN dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p teste
RUN dotnet dev-certs https --trust

FROM build AS publish
RUN dotnet publish "FIAP.ParceriaAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FIAP.ParceriaAPI.dll"]