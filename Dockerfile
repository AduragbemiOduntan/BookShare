#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/backend/presentaion/BookShare.WebAPI/BookShare.WebAPI.csproj", "src/backend/presentaion/BookShare.WebAPI/"]
COPY ["src/backend/core/LoggerService/LoggerService.csproj", "src/backend/core/LoggerService/"]
COPY ["src/backend/core/BookShare.Appliation/BookShare.Appliation.csproj", "src/backend/core/BookShare.Appliation/"]
COPY ["src/backend/core/BookShare.Domain/BookShare.Domain.csproj", "src/backend/core/BookShare.Domain/"]
COPY ["src/backend/infrastructure/BookShare.Persistence/BookShare.Persistence.csproj", "src/backend/infrastructure/BookShare.Persistence/"]
COPY ["src/backend/infrastructure/BookShare.ServiceRepository/BookShare.ServiceRepository.csproj", "src/backend/infrastructure/BookShare.ServiceRepository/"]
RUN dotnet restore "src/backend/presentaion/BookShare.WebAPI/BookShare.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/backend/presentaion/BookShare.WebAPI"
RUN dotnet build "BookShare.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BookShare.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BookShare.WebAPI.dll"]