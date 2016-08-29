@echo off
setlocal
cd docker_OwinApi

REM stop and delete any previous versions of this image/container
docker rm -f $(docker ps -aq --filter name=OwinApi)
docker rmi -f $(docker images benkauffman/owinapi -aq)

REM build the image
docker build --rm --no-cache --tag benkauffman/owinapi:latest .

REM run the image inside a container
docker run -td --restart=always -h localhost -p 9001:9000 --name OwinApi benkauffman/owinapi:latest
