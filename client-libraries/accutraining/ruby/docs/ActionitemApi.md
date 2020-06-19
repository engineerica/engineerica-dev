# OpenapiClient::ActionitemApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionitem_delete**](ActionitemApi.md#actionitem_delete) | **DELETE** /actionitem/{id} | Delete an action item
[**actionitem_get**](ActionitemApi.md#actionitem_get) | **GET** /actionitem/{id} | Search and view details of an action item
[**actionitem_list**](ActionitemApi.md#actionitem_list) | **GET** /actionitem/list | View a list of action items
[**actionitem_save**](ActionitemApi.md#actionitem_save) | **POST** /actionitem/{id} | Create or edit an action item



## actionitem_delete

> actionitem_delete(id, opts)

Delete an action item

Allows the user to delete an action item.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionitemApi.new
id = 'id_example' # String | The id of the action item to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an action item
  api_instance.actionitem_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionitemApi->actionitem_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action item to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actionitem_get

> actionitem_get(id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionitemApi.new
id = 'id_example' # String | The id of the action item to get.

begin
  #Search and view details of an action item
  api_instance.actionitem_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionitemApi->actionitem_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action item to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionitem_list

> actionitem_list(from, count)

View a list of action items

Allows the user to view a list of action items

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionitemApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of action items
  api_instance.actionitem_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionitemApi->actionitem_list: #{e}"
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


## actionitem_save

> actionitem_save(id, opts)

Create or edit an action item

Allows the user to edit an action item.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionitemApi.new
id = 'id_example' # String | The id of the action item to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an action item
  api_instance.actionitem_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionitemApi->actionitem_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action item to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

