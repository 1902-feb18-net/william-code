# the parts of this image identifier...

#..."repository"........."name"............"tag"
#.......v...................v...............v
FROM mcr.microsoft.com/dotnet/core/runtime:2.2

#this copies out/ folder next to the Dockerfile ("outside Docker")
# to /app folder inside Docker image.
COPY out/ /app

# this sets bash as the command to run when container starts
# CMD [ "/bin/bash" ]
CMD [ "dotnet", "/out/ConsoleApp.dll" ]