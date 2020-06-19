# OpenapiClient::SettingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**setting_addlogo**](SettingApi.md#setting_addlogo) | **GET** /setting/addlogo | Add a logo to the account
[**setting_get**](SettingApi.md#setting_get) | **GET** /setting/get | Get settings for the account or the specified scope
[**setting_save**](SettingApi.md#setting_save) | **POST** /setting/save | Save settings for the account or the specified scope
[**setting_viewgeneral**](SettingApi.md#setting_viewgeneral) | **GET** /setting/viewgeneral | View general settings for the account



## setting_addlogo

> setting_addlogo(upload, filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SettingApi.new
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # String | The original filename, needed to process the file.

begin
  #Add a logo to the account
  api_instance.setting_addlogo(upload, filename)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SettingApi->setting_addlogo: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The original filename, needed to process the file. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## setting_get

> setting_get(keys, opts)

Get settings for the account or the specified scope

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SettingApi.new
keys = 'keys_example' # String | The option keys to get values for. Enter multiple separated by comma.
opts = {
  domain: 'domain_example', # String | The account domain, in case of reading settings annonymously.
  scope: 'scope_example' # String | The scope of the settings to get.
}

begin
  #Get settings for the account or the specified scope
  api_instance.setting_get(keys, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SettingApi->setting_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **String**| The option keys to get values for. Enter multiple separated by comma. | 
 **domain** | **String**| The account domain, in case of reading settings annonymously. | [optional] 
 **scope** | **String**| The scope of the settings to get. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## setting_save

> setting_save(opts)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SettingApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save settings for the account or the specified scope
  api_instance.setting_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SettingApi->setting_save: #{e}"
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


## setting_viewgeneral

> setting_viewgeneral

View general settings for the account

Allows the user to view the settings' general section.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SettingApi.new

begin
  #View general settings for the account
  api_instance.setting_viewgeneral
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SettingApi->setting_viewgeneral: #{e}"
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

