#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebApps/AspnetRunBasics/Shopping.Web.csproj", "WebApps/AspnetRunBasics/"]
RUN dotnet restore "WebApps/AspnetRunBasics/Shopping.Web.csproj"
COPY . .
WORKDIR "/src/WebApps/AspnetRunBasics"
RUN dotnet build "Shopping.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shopping.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Web.dll"]
