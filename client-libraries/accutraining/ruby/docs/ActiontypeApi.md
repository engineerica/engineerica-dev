# OpenapiClient::ActiontypeApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actiontype_delete**](ActiontypeApi.md#actiontype_delete) | **DELETE** /actiontype/{id} | Delete an action item type
[**actiontype_get**](ActiontypeApi.md#actiontype_get) | **GET** /actiontype/{id} | View details of an action item type
[**actiontype_list**](ActiontypeApi.md#actiontype_list) | **GET** /actiontype/list | View a list of action item types
[**actiontype_save**](ActiontypeApi.md#actiontype_save) | **POST** /actiontype/{id} | Create or edit an action item type



## actiontype_delete

> actiontype_delete(id, opts)

Delete an action item type

Allows the user to delete an action item type.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActiontypeApi.new
id = 'id_example' # String | The id of the action type to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an action item type
  api_instance.actiontype_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActiontypeApi->actiontype_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action type to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actiontype_get

> actiontype_get(id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActiontypeApi.new
id = 'id_example' # String | The id of the action type to get.

begin
  #View details of an action item type
  api_instance.actiontype_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActiontypeApi->actiontype_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action type to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actiontype_list

> actiontype_list(from, count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActiontypeApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of action item types
  api_instance.actiontype_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActiontypeApi->actiontype_list: #{e}"
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


## actiontype_save

> actiontype_save(id, opts)

Create or edit an action item type

Allows the user to dit an action item type.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActiontypeApi.new
id = 'id_example' # String | The id of the action type to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an action item type
  api_instance.actiontype_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActiontypeApi->actiontype_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action type to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

