# OpenapiClient::AttendancerestrictionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancerestriction_delete**](AttendancerestrictionApi.md#attendancerestriction_delete) | **DELETE** /attendancerestriction/{id} | Delete an attendance restriction
[**attendancerestriction_get**](AttendancerestrictionApi.md#attendancerestriction_get) | **GET** /attendancerestriction/{id} | View details of an attendance restriction
[**attendancerestriction_list**](AttendancerestrictionApi.md#attendancerestriction_list) | **GET** /attendancerestriction/list | View a list of attendance restrictions
[**attendancerestriction_save**](AttendancerestrictionApi.md#attendancerestriction_save) | **POST** /attendancerestriction/{id} | Create or edit an attendance restriction



## attendancerestriction_delete

> attendancerestriction_delete(id, opts)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancerestrictionApi.new
id = 'id_example' # String | The id of the restriction to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an attendance restriction
  api_instance.attendancerestriction_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancerestrictionApi->attendancerestriction_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the restriction to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancerestriction_get

> attendancerestriction_get(id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancerestrictionApi.new
id = 'id_example' # String | The id of the restriction to get.

begin
  #View details of an attendance restriction
  api_instance.attendancerestriction_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancerestrictionApi->attendancerestriction_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the restriction to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancerestriction_list

> attendancerestriction_list(from, count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancerestrictionApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of attendance restrictions
  api_instance.attendancerestriction_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancerestrictionApi->attendancerestriction_list: #{e}"
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


## attendancerestriction_save

> attendancerestriction_save(id, opts)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancerestrictionApi.new
id = 'id_example' # String | The id of the restriction save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an attendance restriction
  api_instance.attendancerestriction_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancerestrictionApi->attendancerestriction_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the restriction save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

