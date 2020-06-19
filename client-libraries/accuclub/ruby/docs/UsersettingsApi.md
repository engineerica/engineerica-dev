# OpenapiClient::UsersettingsApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usersettings_get**](UsersettingsApi.md#usersettings_get) | **GET** /usersettings/get | Lists available user settings
[**usersettings_getmultiple**](UsersettingsApi.md#usersettings_getmultiple) | **GET** /usersettings/getmultiple | Get multiple user settings
[**usersettings_save**](UsersettingsApi.md#usersettings_save) | **POST** /usersettings/save | Saves a user setting
[**usersettings_savemultiple**](UsersettingsApi.md#usersettings_savemultiple) | **POST** /usersettings/savemultiple | Save multiple user settings at once



## usersettings_get

> usersettings_get(keys, opts)

Lists available user settings

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsersettingsApi.new
keys = 'keys_example' # String | Setting key to get. Can be multiple separated by commas.
opts = {
  user: 'user_example' # String | The user id whose settings have to be returned.
}

begin
  #Lists available user settings
  api_instance.usersettings_get(keys, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsersettingsApi->usersettings_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**String**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usersettings_getmultiple

> usersettings_getmultiple(keys, opts)

Get multiple user settings

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsersettingsApi.new
keys = 'keys_example' # String | Setting key to get. Can be multiple separated by commas.
opts = {
  user: 'user_example' # String | The user id whose settings have to be returned.
}

begin
  #Get multiple user settings
  api_instance.usersettings_getmultiple(keys, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsersettingsApi->usersettings_getmultiple: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**String**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usersettings_save

> usersettings_save(opts)

Saves a user setting

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsersettingsApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a user setting
  api_instance.usersettings_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsersettingsApi->usersettings_save: #{e}"
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


## usersettings_savemultiple

> usersettings_savemultiple(opts)

Save multiple user settings at once

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsersettingsApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save multiple user settings at once
  api_instance.usersettings_savemultiple(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsersettingsApi->usersettings_savemultiple: #{e}"
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

