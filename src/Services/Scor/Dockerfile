FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
COPY src/Services/Scor/*.csproj src/Services/Scor/
RUN dotnet restore src/Services/Scor/*.csproj
COPY . .
RUN dotnet publish src/Services/Scor/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet","Scor.dll"]