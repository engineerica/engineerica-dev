# OpenapiClient::ComputerlabApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**computerlab_deletecomputer**](ComputerlabApi.md#computerlab_deletecomputer) | **DELETE** /computerlab/deletecomputer | Delete a computer
[**computerlab_getcomputer**](ComputerlabApi.md#computerlab_getcomputer) | **GET** /computerlab/getcomputer | Search and view details of a computer
[**computerlab_getsettings**](ComputerlabApi.md#computerlab_getsettings) | **GET** /computerlab/getsettings | Loads the settings for a computer lab
[**computerlab_issignedin**](ComputerlabApi.md#computerlab_issignedin) | **GET** /computerlab/issignedin | Gets whether a user is signed-in or not.
[**computerlab_listcomputers**](ComputerlabApi.md#computerlab_listcomputers) | **GET** /computerlab/listcomputers | View a list of computers
[**computerlab_listlabs**](ComputerlabApi.md#computerlab_listlabs) | **GET** /computerlab/listlabs | View a list of the locations that use the Computer Lab add-on
[**computerlab_liststations**](ComputerlabApi.md#computerlab_liststations) | **GET** /computerlab/liststations | View a list of sign-in stations available for computer labs.
[**computerlab_savecomputer**](ComputerlabApi.md#computerlab_savecomputer) | **POST** /computerlab/savecomputer | Create or edit a computer
[**computerlab_savesettings**](ComputerlabApi.md#computerlab_savesettings) | **POST** /computerlab/savesettings | Saves the settings for a computer lab
[**computerlab_saveswipe**](ComputerlabApi.md#computerlab_saveswipe) | **POST** /computerlab/saveswipe | Save a new swipe from a computer in a computer lab.



## computerlab_deletecomputer

> computerlab_deletecomputer(opts)

Delete a computer

Allows the user to delete an existing computer.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ComputerlabApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Delete a computer
  api_instance.computerlab_deletecomputer(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_deletecomputer: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## computerlab_getcomputer

> computerlab_getcomputer(id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ComputerlabApi.new
id = 'id_example' # String | The unique device id of the computer to get.

begin
  #Search and view details of a computer
  api_instance.computerlab_getcomputer(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_getcomputer: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The unique device id of the computer to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlab_getsettings

> computerlab_getsettings(id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::ComputerlabApi.new
id = 'id_example' # String | The id of the computer lab/location.

begin
  #Loads the settings for a computer lab
  api_instance.computerlab_getsettings(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_getsettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the computer lab/location. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlab_issignedin

> computerlab_issignedin(station, user)

Gets whether a user is signed-in or not.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::ComputerlabApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.

begin
  #Gets whether a user is signed-in or not.
  api_instance.computerlab_issignedin(station, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_issignedin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlab_listcomputers

> computerlab_listcomputers(from, count, opts)

View a list of computers

Allows the user to view the list of all computers.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ComputerlabApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  location: 'location_example', # String | The id of the location whose computers have to be returned.
  freeonly: true # Boolean | If true, only free computers will be returned.
}

begin
  #View a list of computers
  api_instance.computerlab_listcomputers(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_listcomputers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **location** | [**String**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **Boolean**| If true, only free computers will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlab_listlabs

> computerlab_listlabs

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ComputerlabApi.new

begin
  #View a list of the locations that use the Computer Lab add-on
  api_instance.computerlab_listlabs
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_listlabs: #{e}"
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


## computerlab_liststations

> computerlab_liststations

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ComputerlabApi.new

begin
  #View a list of sign-in stations available for computer labs.
  api_instance.computerlab_liststations
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_liststations: #{e}"
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


## computerlab_savecomputer

> computerlab_savecomputer(opts)

Create or edit a computer

Allows the user to create or edit a computer.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ComputerlabApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a computer
  api_instance.computerlab_savecomputer(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_savecomputer: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## computerlab_savesettings

> computerlab_savesettings(opts)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ComputerlabApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves the settings for a computer lab
  api_instance.computerlab_savesettings(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_savesettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## computerlab_saveswipe

> computerlab_saveswipe(opts)

Save a new swipe from a computer in a computer lab.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::ComputerlabApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save a new swipe from a computer in a computer lab.
  api_instance.computerlab_saveswipe(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ComputerlabApi->computerlab_saveswipe: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

