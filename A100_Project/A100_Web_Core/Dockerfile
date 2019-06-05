FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["A100_Web_Core/A100_Web_Core.csproj", "A100_Web_Core/"]
RUN dotnet restore "A100_Web_Core/A100_Web_Core.csproj"
COPY . .
WORKDIR "/src/A100_Web_Core"
RUN dotnet build "A100_Web_Core.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "A100_Web_Core.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "A100_Web_Core.dll"]