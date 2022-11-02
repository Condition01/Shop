FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY Shop/*.csproj ./Shop/
COPY Domain/*.csproj ./Domain/

RUN dotnet restore
    
# Copy everything else and build
COPY Shop/. ./Shop/
COPY Domain/. ./Domain/

WORKDIR /app/Shop
RUN dotnet publish -c Release -o out
    
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build-env /app/Shop/out .
ENTRYPOINT ["dotnet", "Shop.dll"]