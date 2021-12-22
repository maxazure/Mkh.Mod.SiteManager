﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 6240

# 打包前端
FROM node:16 AS ui
WORKDIR /src
COPY . .
WORKDIR /src/src/UI/sitemanager-web
RUN npm i
RUN npm run build

# 打包后端
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY . .
WORKDIR /src/src/WebHost
RUN dotnet publish "WebHost.csproj" -c Release -o /src/publish

# 复制文件
FROM base AS final
WORKDIR /app
COPY --from=build /src/publish .
COPY --from=ui /src/src/WebHost/wwwroot ./wwwroot
ENTRYPOINT ["dotnet", "Mkh.Mod.SiteManager.WebHost.dll"]