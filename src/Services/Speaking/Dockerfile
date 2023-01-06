FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
COPY src/Services/Speaking/*.csproj src/Services/Speaking/
RUN dotnet restore src/Services/Speaking/*.csproj
COPY . .
RUN dotnet publish src/Services/Speaking/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet","Speaking.dll"]