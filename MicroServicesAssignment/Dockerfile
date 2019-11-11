FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY MicroServicesAssignment/MicroServicesAssignment.csproj MicroServicesAssignment/
RUN dotnet restore MicroServicesAssignment/MicroServicesAssignment.csproj
COPY . .
WORKDIR /src/MicroServicesAssignment
RUN dotnet build MicroServicesAssignment.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MicroServicesAssignment.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroServicesAssignment.dll"]
