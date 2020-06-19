# OpenapiClient::CompasscategoryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**compasscategory_delete**](CompasscategoryApi.md#compasscategory_delete) | **DELETE** /compasscategory/{id} | Delete a compass category
[**compasscategory_get**](CompasscategoryApi.md#compasscategory_get) | **GET** /compasscategory/{id} | View details of a compass category
[**compasscategory_list**](CompasscategoryApi.md#compasscategory_list) | **GET** /compasscategory/list | View a list of compass categories
[**compasscategory_save**](CompasscategoryApi.md#compasscategory_save) | **POST** /compasscategory/{id} | Create or edit a compass category



## compasscategory_delete

> compasscategory_delete(id, opts)

Delete a compass category

Allows the user to delete an existing compass category.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CompasscategoryApi.new
id = 'id_example' # String | The id of the category to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a compass category
  api_instance.compasscategory_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CompasscategoryApi->compasscategory_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the category to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## compasscategory_get

> compasscategory_get(id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CompasscategoryApi.new
id = 'id_example' # String | The id of the category to get.

begin
  #View details of a compass category
  api_instance.compasscategory_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CompasscategoryApi->compasscategory_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the category to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compasscategory_list

> compasscategory_list(opts)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CompasscategoryApi.new
opts = {
  from: 56, # Integer | The first record to return.
  count: 56, # Integer | The max number of records to return.
  onlywithservices: true # Boolean | Specified whether only categories with services are returned or all.
}

begin
  #View a list of compass categories
  api_instance.compasscategory_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CompasscategoryApi->compasscategory_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 
 **onlywithservices** | **Boolean**| Specified whether only categories with services are returned or all. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compasscategory_save

> compasscategory_save(id, opts)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CompasscategoryApi.new
id = 'id_example' # String | The id of the category save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a compass category
  api_instance.compasscategory_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CompasscategoryApi->compasscategory_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the category save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

