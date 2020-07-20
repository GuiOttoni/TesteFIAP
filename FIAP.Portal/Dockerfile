#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["FIAP.Portal/FIAP.Portal.csproj", "FIAP.Portal/"]
RUN dotnet restore "FIAP.Portal/FIAP.Portal.csproj"
COPY . .
WORKDIR "/src/FIAP.Portal"
RUN dotnet build "FIAP.Portal.csproj" -c Release -o /app/build
RUN dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p teste
RUN dotnet dev-certs https --trust

FROM build AS publish
RUN dotnet publish "FIAP.Portal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FIAP.Portal.dll"]