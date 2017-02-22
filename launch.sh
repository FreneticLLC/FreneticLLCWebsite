gulp clean min
dotnet restore
ASPNETCORE_ENVIRONMENT=Production ASPNETCORE_URLS=https://*:8045 dotnet run
