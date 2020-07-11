#!/usr/bin/env

read -p "Enter the filename for the OpenAPI: " val
openapi-generator generate -i $val -g python -o python
openapi-generator generate -i $val -g kotlin  -o kotlin
openapi-generator generate -i $val -g c -o c
openapi-generator generate -i $val -g perl -o perl
openapi-generator generate -i $val  -g go -o go
openapi-generator generate -i $val  -g php -o php
openapi-generator generate -i $val  -g javascript -o javascript
openapi-generator generate -i $val  -g java -o java
openapi-generator generate -i $val  -g typescript-node -o typescript-node
openapi-generator generate -i $val  -g ruby -o ruby
openapi-generator generate -i $val  -g csharp-dotnet2  -o csharp-dotnet2






