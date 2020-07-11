#!/usr/bin/env

read -p "Enter the location (as an absolute or relative path) to save the client-libraries folder to: " path
read -p "Enter the container name or container ID number: " containerID
docker cp $containerID:/client-libraries $path