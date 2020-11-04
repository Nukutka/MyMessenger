#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MyMessenger.WebApi/MyMessenger.WebApi.csproj", "MyMessenger.WebApi/"]
COPY ["MyMessenger.Application/MyMessenger.Application.csproj", "MyMessenger.Application/"]
COPY ["MyMessenger.Core/MyMessenger.Core.csproj", "MyMessenger.Core/"]
COPY ["MyMessenger.Domain.Shared/MyMessenger.Domain.Shared.csproj", "MyMessenger.Domain.Shared/"]
COPY ["MyMessenger.Domain/MyMessenger.Domain.csproj", "MyMessenger.Domain/"]
COPY ["MyMessenger.Application.Contracts/MyMessenger.Application.Contracts.csproj", "MyMessenger.Application.Contracts/"]
COPY ["MyMessenger.EntityFramework/MyMessenger.EntityFramework.csproj", "MyMessenger.EntityFramework/"]
COPY ["MyMessenger.Security/MyMessenger.Security.csproj", "MyMessenger.Security/"]
RUN dotnet restore "MyMessenger.WebApi/MyMessenger.WebApi.csproj"
COPY . .
WORKDIR "/src/MyMessenger.WebApi"
RUN dotnet build "MyMessenger.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyMessenger.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyMessenger.WebApi.dll"]