# Imagen base con SDK para compilar
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar los archivos de proyecto y restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto del proyecto y compilar
COPY . ./
RUN dotnet publish -c Release -o out

# Imagen final para producción
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copiar los archivos compilados desde la etapa anterior
COPY --from=build /app/out .

# Exponer el puerto donde corre la API
EXPOSE 8080

# Comando de inicio
ENTRYPOINT ["dotnet", "gestor-cdch.dll"]
