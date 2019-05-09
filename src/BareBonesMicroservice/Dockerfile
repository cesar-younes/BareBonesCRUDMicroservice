FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app
EXPOSE 80

# copy csproj and restore as distinct layers
COPY . BareBonesMicroservice/
WORKDIR /app/BareBonesMicroservice
RUN dotnet restore
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/BareBonesMicroservice/out ./
ENTRYPOINT ["dotnet", "BareBonesCRUDMicroservice.dll"]