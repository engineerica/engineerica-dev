#!/usr/bin/env

read -p "Enter the filename for the OpenAPI" val
openapi-generator generate -i $val -g python -o client-libraries/python
openapi-generator generate -i $val -g kotlin  -o client-libraries/kotlin
openapi-generator generate -i $val -g c -o client-libraries/c
openapi-generator generate -i $val -g perl -o client-libraries/perl
openapi-generator generate -i $val  -g go -o client-libraries/go
openapi-generator generate -i $val  -g php -o client-libraries/php
openapi-generator generate -i $val  -g javascript -o client-libraries/javascript
openapi-generator generate -i $val  -g java -o client-libraries/java
openapi-generator generate -i $val  -g typescript-node -o client-libraries/typescript-node
openapi-generator generate -i $val  -g ruby -o client-libraries/ruby
openapi-generator generate -i $val  -g csharp-dotnet2  -o client-libraries/csharp-dotnet2






