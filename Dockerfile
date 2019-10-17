FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["src/BareBonesCRUDMicroservice.csproj", "src/"]
RUN dotnet restore "src/BareBonesCRUDMicroservice.csproj"
COPY . .
WORKDIR "/src/src"
RUN dotnet build "BareBonesCRUDMicroservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BareBonesCRUDMicroservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BareBonesCRUDMicroservice.dll"]