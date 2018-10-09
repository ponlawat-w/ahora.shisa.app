FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["AhoraShisa/AhoraShisa.csproj", "AhoraShisa/"]
RUN dotnet restore "AhoraShisa/AhoraShisa.csproj"
COPY . .
WORKDIR "/src/AhoraShisa"
RUN dotnet build "AhoraShisa.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AhoraShisa.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AhoraShisa.dll"]
