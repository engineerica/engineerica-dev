#!/usr/bin/env

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g go \
    -o client-libraries/go

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g python \
    -o client-libraries/python 

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g kotlin \
    -o client-libraries/kotlin

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g c \
    -o client-libraries/c

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g perl \
    -o client-libraries/perl

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g php \
    -o client-libraries/php

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g java \
    -o client-libraries/java

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g typescript-node \
    -o client-libraries/typescript-node
    
  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g ruby \
    -o client-libraries/ruby

  docker-entrypoint.sh generate \
    -i https://accucampus.net/openapi \
    -g csharp-dotnet2 \
    -o client-libraries/csharp-dotnet2


