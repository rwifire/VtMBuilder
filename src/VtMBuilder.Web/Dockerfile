FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VtMBuilder.Web/VtMBuilder.Web.csproj", "VtMBuilder.Web/"]
RUN dotnet restore "VtMBuilder.Web/VtMBuilder.Web.csproj"
COPY . .
WORKDIR "/src/VtMBuilder.Web"
RUN dotnet build "VtMBuilder.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VtMBuilder.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VtMBuilder.Web.dll"]
