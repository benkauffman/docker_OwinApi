# Use the microsoft/aspnet image as a base.
# FROM microsoft/aspnet
FROM mono

# Run updates and install git
RUN apt-get update
RUN apt-get install git -y

# Create a folder to clone the source code
RUN mkdir src

# Set the working directory
WORKDIR src

# Clone the source code with git
RUN git clone https://github.com/benkauffman/docker_OwinApi.git

# Set the working directory to the source that was just cloned
WORKDIR docker_OwinApi

# Get the dependencies as defined by the solution
RUN nuget restore docker_OwinApi.sln

# Build the application with xbuild
RUN xbuild docker_OwinApi.sln /p:DefineConstants=LINUX

# Expose port 9000 for the application.
EXPOSE 9000

# Start the application using mono.
ENTRYPOINT ["mono", "docker_OwinApi/bin/Debug/docker_OwinApi.exe"]
