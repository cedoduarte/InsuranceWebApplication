# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./InsuranceWebApplication/InsuranceWebApplication.csproj" --disable-parallel
RUN dotnet publish "./InsuranceWebApplication/InsuranceWebApplication.csproj" -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "InsuranceWebApplication.dll"]