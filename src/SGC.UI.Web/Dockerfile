FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/SGC.UI.Web/SGC.UI.Web.csproj", "src/SGC.UI.Web/"]
RUN dotnet restore "src/SGC.UI.Web/SGC.UI.Web.csproj"
COPY . .
WORKDIR "/src/src/SGC.UI.Web"
RUN dotnet build "SGC.UI.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SGC.UI.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SGC.UI.Web.dll"]