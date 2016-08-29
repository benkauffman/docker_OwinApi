# We use the microsoft/aspnet image as a starting point.
FROM microsoft/aspnet

# Run updates and install git
RUN apt-get update
RUN apt-get install git -y

# Create a folder to clone our source code
RUN mkdir repositories

# Set our working folder
WORKDIR repositories

# Clone the source code
RUN git clone https://github.com/benkauffman/docker_OwinApi.git

# Set our working folder
WORKDIR docker_OwinApi

# Restore nuget packages
RUN nuget restore docker_OwinApi.sln

# Build the application
RUN xbuild docker_OwinApi.sln /p:DefineConstants=LINUX

# Expose port 9000 for the application.
EXPOSE 9000

# Start de application using mono!!!
ENTRYPOINT ["mono", "docker_OwinApi/bin/Debug/docker_OwinApi.exe"]
