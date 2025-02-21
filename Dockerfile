FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

# Criar diretório para o banco de dados SQLite
RUN mkdir -p /app/data
# Copiar a base SQLite para o container
COPY data/users.db /app/data/users.db

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["AuthServer.csproj", "src/"]
RUN dotnet restore "src/AuthServer.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "AuthServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthServer.dll"]