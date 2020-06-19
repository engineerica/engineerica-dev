# OpenapiClient::GeneralApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**changelog**](GeneralApi.md#changelog) | **GET** /changelog | Get the application change log
[**doc**](GeneralApi.md#doc) | **GET** /doc | Get the documentation
[**export**](GeneralApi.md#export) | **GET** /export | Export AccuCampus data
[**import**](GeneralApi.md#import) | **GET** /import | Import data into AccuCampus
[**listtimezones**](GeneralApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**login**](GeneralApi.md#login) | **GET** /login | Login
[**logout**](GeneralApi.md#logout) | **GET** /logout | Logout
[**search**](GeneralApi.md#search) | **GET** /search | Search
[**texttoimage**](GeneralApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**version**](GeneralApi.md#version) | **GET** /version | Get current version information



## changelog

> changelog

Get the application change log

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::GeneralApi.new

begin
  #Get the application change log
  api_instance.changelog
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->changelog: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## doc

> doc(opts)

Get the documentation

Retrieves the list of actions available in the system.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::GeneralApi.new
opts = {
  excludeanonymous: true # Boolean | If true it excludes the anonymous actions from the returned list.
}

begin
  #Get the documentation
  api_instance.doc(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->doc: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **Boolean**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## export

> export(exporttype, exportformat, opts)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::GeneralApi.new
exporttype = 'exporttype_example' # String | What to export.
exportformat = 'exportformat_example' # String | The format of the resulting file. Valid types are CSV, HTML, XLS.
opts = {
  filters: 'filters_example' # String | Pipe separated filters for the export, eg: aaa=val|bbb=val|...
}

begin
  #Export AccuCampus data
  api_instance.export(exporttype, exportformat, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->export: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exporttype** | **String**| What to export. | 
 **exportformat** | **String**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## import

> import(importtype, upload, opts)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::GeneralApi.new
importtype = 'importtype_example' # String | The kind of data that is being uploaded.
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
opts = {
  filename: 'filename_example', # String | The local name of the uploaded file. For later reference.
  parameters: 'parameters_example' # String | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.
}

begin
  #Import data into AccuCampus
  api_instance.import(importtype, upload, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->import: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **importtype** | **String**| The kind of data that is being uploaded. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 
 **parameters** | **String**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## listtimezones

> listtimezones

Lists the available timezones

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::GeneralApi.new

begin
  #Lists the available timezones
  api_instance.listtimezones
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->listtimezones: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## login

> login(domain, username, password, method, opts)

Login

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::GeneralApi.new
domain = 'domain_example' # String | The account domain to login.
username = 'username_example' # String | The username (email) of the user to login as.
password = 'password_example' # String | The password of the user to login as.
method = 'method_example' # String | The authentication method. Valid values are 'token' and 'cookie'.
opts = {
  rememberme: true # Boolean | If true then the session will not expire.
}

begin
  #Login
  api_instance.login(domain, username, password, method, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->login: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **String**| The account domain to login. | 
 **username** | **String**| The username (email) of the user to login as. | 
 **password** | **String**| The password of the user to login as. | 
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **Boolean**| If true then the session will not expire. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## logout

> logout

Logout

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::GeneralApi.new

begin
  #Logout
  api_instance.logout
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->logout: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## search

> search(query, opts)

Search

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::GeneralApi.new
query = 'query_example' # String | The query to search for.
opts = {
  page: 56 # Integer | Current page to show, zero-based.
}

begin
  #Search
  api_instance.search(query, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->search: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **String**| The query to search for. | 
 **page** | **Integer**| Current page to show, zero-based. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## texttoimage

> texttoimage(text, opts)

Generates a dynamic image from text

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::GeneralApi.new
text = 'text_example' # String | The text to convert to an image, use double pipes (||) as a new line.
opts = {
  fontcolor: 'fontcolor_example', # String | The color of the text, in hex format, without the #.
  fontsize: 56, # Integer | The size of the text, in points.
  direction: 'direction_example', # String | Either vertical or horizontal, default horizontal.
  width: 56 # Integer | The image width in pixels (or height if the direction is vertical).
}

begin
  #Generates a dynamic image from text
  api_instance.texttoimage(text, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->texttoimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **String**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **String**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **Integer**| The size of the text, in points. | [optional] 
 **direction** | **String**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **Integer**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## version

> version

Get current version information

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::GeneralApi.new

begin
  #Get current version information
  api_instance.version
rescue OpenapiClient::ApiError => e
  puts "Exception when calling GeneralApi->version: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

