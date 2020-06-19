# OpenapiClient::DeadendrecordingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deadendrecording_delete**](DeadendrecordingApi.md#deadendrecording_delete) | **DELETE** /deadendrecording/delete | Deletes a dead-end record group
[**deadendrecording_list**](DeadendrecordingApi.md#deadendrecording_list) | **GET** /deadendrecording/list | Lists the recorded dead ends, if enabled
[**deadendrecording_listcomments**](DeadendrecordingApi.md#deadendrecording_listcomments) | **GET** /deadendrecording/listcomments | Lists the comments for a specific dead end
[**deadendrecording_save**](DeadendrecordingApi.md#deadendrecording_save) | **POST** /deadendrecording/save | Saves a dead-end record



## deadendrecording_delete

> deadendrecording_delete(opts)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::DeadendrecordingApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Deletes a dead-end record group
  api_instance.deadendrecording_delete(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DeadendrecordingApi->deadendrecording_delete: #{e}"
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


## deadendrecording_list

> deadendrecording_list

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::DeadendrecordingApi.new

begin
  #Lists the recorded dead ends, if enabled
  api_instance.deadendrecording_list
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DeadendrecordingApi->deadendrecording_list: #{e}"
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


## deadendrecording_listcomments

> deadendrecording_listcomments(hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::DeadendrecordingApi.new
hierarchykey = 'hierarchykey_example' # String | The hierarchy key of the record to get the feedback.

begin
  #Lists the comments for a specific dead end
  api_instance.deadendrecording_listcomments(hierarchykey)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DeadendrecordingApi->deadendrecording_listcomments: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hierarchykey** | **String**| The hierarchy key of the record to get the feedback. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## deadendrecording_save

> deadendrecording_save(opts)

Saves a dead-end record

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DeadendrecordingApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a dead-end record
  api_instance.deadendrecording_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DeadendrecordingApi->deadendrecording_save: #{e}"
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

