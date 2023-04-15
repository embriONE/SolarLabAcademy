FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Board/Host/Board.Host.Api/Board.Host.Api.csproj", "Board/Host/Board.Host.Api/"]
COPY ["Board/Application/Board.Application.Appdata/Board.Application.Appdata.csproj", "Board/Application/Board.Application.Appdata/"]
COPY ["Board/Contracts/Board.Contracts/Board.Contracts.csproj", "Board/Contracts/Board.Contracts/"]
RUN dotnet restore "Board/Host/Board.Host.Api/Board.Host.Api.csproj"
COPY . .
WORKDIR "/src/Board/Host/Board.Host.Api"
RUN dotnet build "Board.Host.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Board.Host.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Board.Host.Api.dll"]
