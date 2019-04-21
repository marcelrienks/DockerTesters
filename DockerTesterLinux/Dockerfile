### Linux ###
#======================================================
# Manually build a container using an image that does not have dotnet installed
# this will pull down and install dotnet
# 'docker build -t docker-tester-lin .'
#======================================================
#FROM mcr.microsoft.com/dotnet/core/runtime-deps:2.2-stretch-slim

#RUN apt-get update \
#    && apt-get install -y --no-install-recommends \
#        curl \
#    && rm -rf /var/lib/apt/lists/*

## Install .NET Core
#ENV DOTNET_VERSION 2.2.4

#RUN curl -SL --output dotnet.tar.gz https://dotnetcli.blob.core.windows.net/dotnet/Runtime/$DOTNET_VERSION/dotnet-runtime-$DOTNET_VERSION-linux-x64.tar.gz \
#    && dotnet_sha512='14b9dfad2899054b55a533adb213a88c19977c34d1b40d7d5095d05ba72eb3e3c229f2a6ec5bb5605133bcaef0b4a68416a90a9c6d572dce1e2c423abda2272b' \
#    && echo "$dotnet_sha512 dotnet.tar.gz" | sha512sum -c - \
#    && mkdir -p /usr/share/dotnet \
#    && tar -zxf dotnet.tar.gz -C /usr/share/dotnet \
#    && rm dotnet.tar.gz \
#    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

#COPY bin/Release/netcoreapp2.1/publish/ DockerTester/
#ENTRYPOINT dotnet DockerTester/DockerTester.dll



#======================================================
# Manually build a container using an image that does have dotnet already installed
# 'docker build -t docker-tester-lin .'
#======================================================
FROM mcr.microsoft.com/dotnet/core/runtime:2.2-stretch-slim
COPY bin/Release/netcoreapp2.1/publish/ DockerTester/
ENTRYPOINT dotnet DockerTester/DockerTester.dll



#======================================================
# Auto Generated Dockerfile from VS2019
# This will build an image, copy source across, compile and build the source
# 'docker build -t docker-tester-lin .'
#======================================================
#FROM mcr.microsoft.com/dotnet/core/runtime:2.1-stretch-slim AS base
#WORKDIR /app
#
#
#FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
#WORKDIR /src
#COPY ["DockerTesterLinux/DockerTesterLinux.csproj", "DockerTesterLinux/"]
#RUN dotnet restore "DockerTesterLinux/DockerTesterLinux.csproj"
#COPY . .
#WORKDIR "/src/DockerTesterLinux"
#RUN dotnet build "DockerTesterLinux.csproj" -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish "DockerTesterLinux.csproj" -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "DockerTesterLinux.dll"]