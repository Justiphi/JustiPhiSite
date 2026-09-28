# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS with-node
RUN apt-get update
RUN apt-get install -y curl
RUN curl -sL https://deb.nodesource.com/setup_22.x | bash
RUN apt-get -y install nodejs
RUN npm install -g @angular/cli

FROM with-node AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["JustiPhiSite.Server/JustiPhiSite.Server.csproj", "JustiPhiSite.Server/"]
COPY ["justiphisite.client/justiphisite.client.esproj", "justiphisite.client/"]
RUN dotnet restore "./JustiPhiSite.Server/JustiPhiSite.Server.csproj"
COPY . .
WORKDIR "/src/JustiPhiSite.Server"
RUN dotnet build "./JustiPhiSite.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./JustiPhiSite.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Build an EF Core migrations bundle (a standalone executable that applies pending migrations)
RUN dotnet tool install --global dotnet-ef --version 10.0.12
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet ef migrations bundle --configuration $BUILD_CONFIGURATION -o /app/efbundle --force

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=publish /app/efbundle .
# Apply any pending migrations, then start the app. Uses ConnectionStrings__DefaultConnection from the environment.
ENTRYPOINT ["/bin/sh", "-c", "./efbundle --connection \"$ConnectionStrings__DefaultConnection\" && exec dotnet JustiPhiSite.Server.dll"]
