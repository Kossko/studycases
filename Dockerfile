FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["StudyCasesConsole.csproj", "."]
RUN dotnet restore "./StudyCasesConsole.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "StudyCasesConsole.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StudyCasesConsole.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudyCasesConsole.dll"]