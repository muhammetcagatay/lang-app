FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
COPY src/Services/AuthServer/AuthServer.API/*.csproj src/Services/AuthServer/AuthServer.API/
RUN dotnet restore src/Services/AuthServer/AuthServer.API/*.csproj
COPY . .
RUN dotnet publish src/Services/AuthServer/AuthServer.API/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet","AuthServer.API.dll"]