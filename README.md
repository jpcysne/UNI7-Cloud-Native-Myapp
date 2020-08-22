# UNI7-Cloud-Native-Myapp
UNI7-Cloud-Native-Myapp

## Building docker image
```
docker build -t jprubio/myapp:<VERSION_TAG> . 
```

## Running docker image
```
docker run -it -p 8080:8080 jprubio/myapp:<VERSION_TAG>
```

## Pushing to DockerHub
```
docker login 
docker push jprubio/myapp:<VERSION_TAG>
```

## Docker image
Docker image are available at [DockerHub](https://hub.docker.com/r/jprubio/myapp).

## For testing purposes
Running locally with Docker compose
```
docker-compose up
```
