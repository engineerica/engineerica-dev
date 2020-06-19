# OpenapiClient::MyApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**my_account**](MyApi.md#my_account) | **GET** /my/account | Gets the logged in user account.
[**my_ianatimezone**](MyApi.md#my_ianatimezone) | **GET** /my/ianatimezone | Gets the current time zone&#39;s iana name
[**my_profile**](MyApi.md#my_profile) | **GET** /my/profile | Gets the logged in user information.
[**my_rights**](MyApi.md#my_rights) | **GET** /my/rights | Gets the list of actions the user can execute.
[**my_saveprofile**](MyApi.md#my_saveprofile) | **POST** /my/saveprofile | Updates logged user&#39;s profile information



## my_account

> my_account

Gets the logged in user account.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MyApi.new

begin
  #Gets the logged in user account.
  api_instance.my_account
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MyApi->my_account: #{e}"
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


## my_ianatimezone

> my_ianatimezone

Gets the current time zone's iana name

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MyApi.new

begin
  #Gets the current time zone's iana name
  api_instance.my_ianatimezone
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MyApi->my_ianatimezone: #{e}"
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


## my_profile

> my_profile(opts)

Gets the logged in user information.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MyApi.new
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Gets the logged in user information.
  api_instance.my_profile(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MyApi->my_profile: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## my_rights

> my_rights

Gets the list of actions the user can execute.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MyApi.new

begin
  #Gets the list of actions the user can execute.
  api_instance.my_rights
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MyApi->my_rights: #{e}"
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


## my_saveprofile

> my_saveprofile(opts)

Updates logged user's profile information

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MyApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Updates logged user's profile information
  api_instance.my_saveprofile(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MyApi->my_saveprofile: #{e}"
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

