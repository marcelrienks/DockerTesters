# run this from command line in base project filder, note the dot at the end dictates the 'context' is the base project folder
# docker build -t docker-tester .

FROM mcr.microsoft.com/dotnet/framework/runtime
COPY bin/Release/ DockerTesterWindows/
ENTRYPOINT DockerTesterWindows\DockerTesterWindows.exe