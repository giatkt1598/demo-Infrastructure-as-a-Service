#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
LABEL name="mywebapp" version="1.0"
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ProjectIaaS.csproj", "ProjectIaaS/"]
RUN dotnet restore "ProjectIaaS/ProjectIaaS.csproj"
COPY . .
WORKDIR "/src/ProjectIaaS"
COPY . .
RUN dotnet build "ProjectIaaS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectIaaS.csproj" -c Release -o /app/publish

RUN dotnet tool install --global dotnet-ef
RUN dotnet ef database update

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectIaaS.dll"]
