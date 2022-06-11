FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TechWithPatTut/TechWithPatTut.csproj", "TechWithPatTut/"]
RUN dotnet restore "TechWithPatTut/TechWithPatTut.csproj"
COPY . .
WORKDIR "/src/TechWithPatTut"
RUN dotnet build "TechWithPatTut.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechWithPatTut.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechWithPatTut.dll"]
