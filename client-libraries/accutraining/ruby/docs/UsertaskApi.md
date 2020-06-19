# OpenapiClient::UsertaskApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usertask_deleteplan**](UsertaskApi.md#usertask_deleteplan) | **DELETE** /usertask/deleteplan | Deletes a task plan
[**usertask_getmine**](UsertaskApi.md#usertask_getmine) | **GET** /usertask/getmine | Lists the task plans of the logged user
[**usertask_getplan**](UsertaskApi.md#usertask_getplan) | **GET** /usertask/getplan | Gets a task plan by Id
[**usertask_listdefs**](UsertaskApi.md#usertask_listdefs) | **GET** /usertask/listdefs | Lists task types or definitions
[**usertask_listplan**](UsertaskApi.md#usertask_listplan) | **GET** /usertask/listplan | Lists task plans
[**usertask_saveplan**](UsertaskApi.md#usertask_saveplan) | **POST** /usertask/saveplan | Saves a task plan



## usertask_deleteplan

> usertask_deleteplan(opts)

Deletes a task plan

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsertaskApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Deletes a task plan
  api_instance.usertask_deleteplan(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsertaskApi->usertask_deleteplan: #{e}"
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


## usertask_getmine

> usertask_getmine

Lists the task plans of the logged user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsertaskApi.new

begin
  #Lists the task plans of the logged user
  api_instance.usertask_getmine
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsertaskApi->usertask_getmine: #{e}"
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


## usertask_getplan

> usertask_getplan(id)

Gets a task plan by Id

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsertaskApi.new
id = 'id_example' # String | The id of the task plan to get.

begin
  #Gets a task plan by Id
  api_instance.usertask_getplan(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsertaskApi->usertask_getplan: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the task plan to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usertask_listdefs

> usertask_listdefs

Lists task types or definitions

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::UsertaskApi.new

begin
  #Lists task types or definitions
  api_instance.usertask_listdefs
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsertaskApi->usertask_listdefs: #{e}"
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


## usertask_listplan

> usertask_listplan(from, count)

Lists task plans

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsertaskApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #Lists task plans
  api_instance.usertask_listplan(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsertaskApi->usertask_listplan: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usertask_saveplan

> usertask_saveplan(opts)

Saves a task plan

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsertaskApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a task plan
  api_instance.usertask_saveplan(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsertaskApi->usertask_saveplan: #{e}"
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

