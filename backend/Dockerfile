# FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# WORKDIR /app

# COPY . .
# RUN dotnet restore

# COPY . ./
# RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/aspnet:7.0.0

# EXPOSE 80

# WORKDIR /app

# COPY --from=build /app/out .

# ENV ASPNETCORE_URLS=http://+:80
# ENV ASPNETCORE_ENVIRONMENT=Development

# RUN apt-get update && apt-get install -y wget
# RUN wget -q https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb
# RUN dpkg -i packages-microsoft-prod.deb
# RUN apt-get update && apt-get install -y dotnet-sdk-7.0
# # RUN dotnet tool install --global dotnet-ef --version 7.0.0
# RUN dotnet tool update --global dotnet-ef --version 7.0.0
# ENV PATH="${PATH}:/root/.dotnet/tools"

# WORKDIR /app/backend
# COPY /bookNookStarterCode ./
# RUN ls -la
# RUN dotnet ef database update --project bookNookStarterCode.csproj

# # Start the application
# # ENTRYPOINT ["dotnet", "bookNookStarterCode.dll"]
# ENTRYPOINT ["sh", "-c", "sleep 30 && dotnet bookNookStarterCode.dll"]
# Build image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . .
RUN dotnet restore

# Copy everything else and build app
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0.0
WORKDIR /app
COPY --from=build /app/out .

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development

# Start the application
ENTRYPOINT ["sh", "-c", "sleep 30 && dotnet bookNookStarterCode.dll"]
