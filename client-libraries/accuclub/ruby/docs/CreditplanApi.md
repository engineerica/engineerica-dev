# OpenapiClient::CreditplanApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**creditplan_delete**](CreditplanApi.md#creditplan_delete) | **DELETE** /creditplan/{id} | Deletes a credit plan
[**creditplan_get**](CreditplanApi.md#creditplan_get) | **GET** /creditplan/{id} | Gets a credit plan
[**creditplan_list**](CreditplanApi.md#creditplan_list) | **GET** /creditplan/list | Gets the credit plans available
[**creditplan_save**](CreditplanApi.md#creditplan_save) | **POST** /creditplan/{id} | Saves a credit plan



## creditplan_delete

> creditplan_delete(id, opts)

Deletes a credit plan

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditplanApi.new
id = 'id_example' # String | The id of the credit plan to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Deletes a credit plan
  api_instance.creditplan_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditplanApi->creditplan_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the credit plan to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## creditplan_get

> creditplan_get(id)

Gets a credit plan

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditplanApi.new
id = 'id_example' # String | The id of the credit plan to get.

begin
  #Gets a credit plan
  api_instance.creditplan_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditplanApi->creditplan_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the credit plan to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditplan_list

> creditplan_list(from, count)

Gets the credit plans available

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditplanApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #Gets the credit plans available
  api_instance.creditplan_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditplanApi->creditplan_list: #{e}"
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


## creditplan_save

> creditplan_save(id, opts)

Saves a credit plan

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditplanApi.new
id = 'id_example' # String | The id of the credit save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a credit plan
  api_instance.creditplan_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditplanApi->creditplan_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the credit save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

