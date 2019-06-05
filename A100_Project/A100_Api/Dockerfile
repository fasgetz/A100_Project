FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["A100_Api/A100_Api.csproj", "A100_Api/"]
RUN dotnet restore "A100_Api/A100_Api.csproj"
COPY . .
WORKDIR "/src/A100_Api"
RUN dotnet build "A100_Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "A100_Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "A100_Api.dll"]