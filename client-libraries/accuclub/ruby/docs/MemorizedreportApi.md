# OpenapiClient::MemorizedreportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**memorizedreport_delete**](MemorizedreportApi.md#memorizedreport_delete) | **DELETE** /memorizedreport/{id} | Delete memorized report
[**memorizedreport_get**](MemorizedreportApi.md#memorizedreport_get) | **GET** /memorizedreport/{id} | View details of a memorized report
[**memorizedreport_list**](MemorizedreportApi.md#memorizedreport_list) | **GET** /memorizedreport/list | View a list of all his memorized reports
[**memorizedreport_save**](MemorizedreportApi.md#memorizedreport_save) | **POST** /memorizedreport/{id} | Create or edit a memorized report



## memorizedreport_delete

> memorizedreport_delete(id, opts)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MemorizedreportApi.new
id = 'id_example' # String | The id of the report settings to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete memorized report
  api_instance.memorizedreport_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MemorizedreportApi->memorizedreport_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the report settings to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## memorizedreport_get

> memorizedreport_get(id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MemorizedreportApi.new
id = 'id_example' # String | The id of the report configuration to get.

begin
  #View details of a memorized report
  api_instance.memorizedreport_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MemorizedreportApi->memorizedreport_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the report configuration to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## memorizedreport_list

> memorizedreport_list(from, count, opts)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MemorizedreportApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  customname: 'customname_example' # String | If specified filters the memorized reports by custom name.
}

begin
  #View a list of all his memorized reports
  api_instance.memorizedreport_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MemorizedreportApi->memorizedreport_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **customname** | **String**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## memorizedreport_save

> memorizedreport_save(id, opts)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MemorizedreportApi.new
id = 'id_example' # String | The id of the report settings to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a memorized report
  api_instance.memorizedreport_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MemorizedreportApi->memorizedreport_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the report settings to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

