# docker_OwinApi
C# self hosted OWIN web API

There is no need to clone the repo unless you want to change the code...
<i>Just</i> install <a href="https://docs.docker.com/engine/installation/">docker</a>

<br>To build the image run:
  <br>`docker build --rm --no-cache --tag benkauffman/owinapi:latest https://github.com/benkauffman/docker_OwinApi.git#master:docker_OwinApi`
<br>To run the image in a container run:
  <br>`docker run -td -h localhost --restart=always -h localhost -p 9001:9000 --name OwinApi benkauffman/owinapi:latest`

<br>You can then navigate to or curl the API at `http://localhost:9001/api/example`

<br>You can stop and remove the container with
  <br>`docker rm -f $(docker ps -aq --filter name=OwinApi)`

<br>You can remove the image with
  <br>`docker rmi -f $(docker images benkauffman/owinapi -aq)`
