# How to Manually run a console app within a docker image
=========================================================

Create console app that does something
	Console.WriteLine("This is the Console output from the DockerTesterWindows app");

Create a docker file with the following contents below.
	* This will create a container from the mcr.microsoft.com/dotnet/framework/runtime image
	* Copy the contents of the already released bin/Release to the following location DockerTesterWindows/ inside the container
	* And it will execute the following command directly DockerTesterWindows\DockerTesterWindows.exe

		FROM mcr.microsoft.com/dotnet/framework/runtime
		COPY bin/Release/ DockerTesterWindows/
		ENTRYPOINT DockerTesterWindows\DockerTesterWindows.exe

Ensure you have Docker for windows in stalled for Win 10 Pro
Or Docker toolkit installed for Win 7, 8, 10 home
Start Docker

SWITCH DOCKER TO USE LINUX CONTAINERS

Execute the following command from the directory that contains the docker file
note the dot at the end dictates the 'context' is the base project folder
	docker build -t docker-tester .

Run the container by using this command
	docker run docker-tester

###################################################################################################################################

# How to Automatically run a console app within a docker image, VS2019
# NOTE: this option requires the project to be a .net core project
=====================================================================

Create console app that does something
	Console.WriteLine("This is the Console output from the DockerTesterWindows app");

Create a docker file in VS 2019 by right clicking the project, select 'add', and click 'Docker Support'

This will auto generate a docker file that contains much more complex commands to use the correct image version for your source,
as well as copy the raw source to the docker image, and then only compile and publish it within the image.

Ensure you have Docker for windows in stalled for Win 10 Pro
Or Docker toolkit installed for Win 7, 8, 10 home
Start Docker

SWITCH DOCKER TO USE LINUX CONTAINERS

Execute the following command from the directory that contains the docker file
note the dot at the end dictates the 'context' is the base project folder
	docker build -t docker-tester .

Run the container by using this command
	docker run docker-tester