User Manual: Client Libraries Script

I. Overview

The purpose of this script is to quickly generate client libraries given any OpenAPI file. Currently, the script generates client libraries for the following languages:

-  Python
-  Kotlin
-  C
-  Perl
-  Go
-  PHP
-  JavaScript
-  Java
-  TypeScript-Node
-  Ruby
-  C# / .NET

II. Download

The script can be downloaded directly from GitHub at: https://github.com/engineerica/engineerica-dev/blob/master/script.sh

III. Required Software

-  [OpenAPI Generator](https://openapi-generator.tech/docs/installation)- Used to automatically generate clients from OpenAPI 2.0/3.x documents

   -  It is recommended to install OpenAPI generator using NPM. The latest version of the tool can be installed by entering the following command in a terminal (Platform(s): Linux, macOS, Windows):

      npm install @openapitools/openapi-generator-cli -g

IV. Running the Script

1. Place the script.sh file and the OpenAPI files in the same directory
2. Open a terminal and enter the following command to run the script:

   bash script.sh

3. When prompted, enter the OpenAPI filename. For example: &quot;openapi.json&quot;
4. Ta-Da! New directories are created that contains the client libraries for the languages listed above. You can modify the -o parameter in the script to redirect the output files to a different location.
