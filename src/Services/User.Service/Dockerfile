FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
COPY src/Services/User.Service/*.csproj src/Services/User.Service/
RUN dotnet restore src/Services/User.Service/*.csproj
COPY . .
RUN dotnet publish src/Services/User.Service/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet","User.Service.dll"]