#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AdminPart/WebApplication/WebApplication.csproj", "AdminPart/WebApplication/"]
COPY ["AdminPart/Application/Application.csproj", "AdminPart/Application/"]
COPY ["AdminPart/Domain/Domain.csproj", "AdminPart/Domain/"]
COPY ["AdminPart/Infrastructure/Infrastructure.csproj", "AdminPart/Infrastructure/"]
RUN dotnet restore "AdminPart/WebApplication/WebApplication.csproj"
COPY . .
WORKDIR "/src/AdminPart/WebApplication"
RUN dotnet build "WebApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication.dll"]