# Build on local Docker

In order to not just create a copy of what the documentation already provides I only included a cheat sheet of commands that you can run to get from code to a container running locally in docker.
For more complete instructions and explanation refer to this page: https://docs.microsoft.com/en-us/dotnet/core/docker/build-container or this page: https://docs.docker.com/engine/examples/dotnetcore/
Change directory to the rool of the repo where the Dockerfile is stored and run this command
```
docker build -t barebonescrudmicroservice .
```
Check the image among the local docker images and run it.
The -d flag runs the container in detached mode. In detached mode it doesn't stream the container logs onto the terminal so you still have the terminal available to run further commands.
```
docker images
docker run -d -p 8080:80 barebonescrudmicroservice:latest
```
When it runs the output should be something like this
92d9ec8d50f0caa0a39e0b9fafeedf4520e1e49d8201d7c2c36d4f709f6a581f

For debugging purposes, since we're running in detached mode, you can check the logs by typing docker logs and putting in the first 4 letters of the container id
```
docker logs 92d9
```
The output should be something like this
warn: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[35]
      No XML encryptor configured. Key {cb786682-3883-40c6-ae5d-6b7a0afe98db} may be persisted to storage in unencrypted form.
Hosting environment: Production
Content root path: /app
Now listening on: http://[::]:80
Application started. Press Ctrl+C to shut down.

You can test it locally by trying this URL in the browser: http://localhost:8080/swagger/index.html

To check the running containers
```
docker ps
```

To stop the container
```
docker container stop 92d9
```
or to stop and remove
```
docker container rm -f 92d9
```
