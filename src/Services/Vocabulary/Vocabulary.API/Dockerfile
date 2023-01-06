FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
COPY src/Services/Vocabulary/Vocabulary.API/*.csproj src/Services/Vocabulary/Vocabulary.API/
RUN dotnet restore src/Services/Vocabulary/Vocabulary.API/*.csproj
COPY . .
RUN dotnet publish src/Services/Vocabulary/Vocabulary.API/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet","Vocabulary.API.dll"]