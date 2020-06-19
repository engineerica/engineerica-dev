# OpenapiClient::ServiceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**service_delete**](ServiceApi.md#service_delete) | **DELETE** /service/{id} | Delete a service
[**service_get**](ServiceApi.md#service_get) | **GET** /service/{id} | Search and view details of a service
[**service_list**](ServiceApi.md#service_list) | **GET** /service/list | View a list of services
[**service_save**](ServiceApi.md#service_save) | **POST** /service/{id} | Create or edit a service



## service_delete

> service_delete(id, opts)

Delete a service

Allows the user to delete a service from the existing list.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceApi.new
id = 'id_example' # String | The id of the service to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a service
  api_instance.service_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceApi->service_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the service to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## service_get

> service_get(id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceApi.new
id = 'id_example' # String | The id of the service to get.

begin
  #Search and view details of a service
  api_instance.service_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceApi->service_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the service to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## service_list

> service_list(from, count)

View a list of services

Allows the user to view the full list of existing services.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of services
  api_instance.service_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceApi->service_list: #{e}"
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


## service_save

> service_save(id, opts)

Create or edit a service

Allows the user to create or edit a service.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceApi.new
id = 'id_example' # String | The id of the service save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a service
  api_instance.service_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceApi->service_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the service save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

