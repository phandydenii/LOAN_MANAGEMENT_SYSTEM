# # Use the official .NET image
# FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# WORKDIR /app
# EXPOSE 80

# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /src
# COPY ["./LOAN_MANAGEMENT_API.csproj", "LOAN_MANAGEMENT_APP/"]
# RUN dotnet restore "./LOAN_MANAGEMENT_API.csproj"
# COPY . .
# WORKDIR "/src/LOAN_MANAGEMENT_APP"
# RUN dotnet build "LOAN_MANAGEMENT_API.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "LOAN_MANAGEMENT_API.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "LOAN_MANAGEMENT_API.dll"]

# Use the official .NET 6 ASP.NET runtime image
# FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443

# # Use the official .NET 6 SDK image
# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /src
# COPY ["./LOAN_MANAGEMENT_API.csproj", "LOAN_MANAGEMENT_API/"]
# RUN dotnet restore "./LOAN_MANAGEMENT_API.csproj"
# COPY . .
# WORKDIR "/src/LOAN_MANAGEMENT_API"
# RUN dotnet build "LOAN_MANAGEMENT_API.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "LOAN_MANAGEMENT_API.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "LOAN_MANAGEMENT_API.dll"]




# Use the official .NET image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LOAN_MANAGEMENT_API.csproj", "./"]
RUN dotnet restore "./LOAN_MANAGEMENT_API.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "LOAN_MANAGEMENT_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LOAN_MANAGEMENT_API.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LOAN_MANAGEMENT_API.dll"]