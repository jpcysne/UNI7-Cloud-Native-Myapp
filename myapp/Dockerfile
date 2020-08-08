FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY myapp/myapp.csproj myapp/
RUN dotnet restore myapp/myapp.csproj
COPY . .
WORKDIR /src/myapp
RUN dotnet build myapp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish myapp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "myapp.dll"]
