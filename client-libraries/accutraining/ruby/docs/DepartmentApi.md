# OpenapiClient::DepartmentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**department_delete**](DepartmentApi.md#department_delete) | **DELETE** /department/{id} | Delete a college department
[**department_get**](DepartmentApi.md#department_get) | **GET** /department/{id} | Search and view details of a college department
[**department_list**](DepartmentApi.md#department_list) | **GET** /department/list | View a list of college departments
[**department_save**](DepartmentApi.md#department_save) | **POST** /department/{id} | Create or edit a college department



## department_delete

> department_delete(id, opts)

Delete a college department

Allows the user to delete an existing college department.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::DepartmentApi.new
id = 'id_example' # String | The id of the department to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a college department
  api_instance.department_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DepartmentApi->department_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the department to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## department_get

> department_get(id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::DepartmentApi.new
id = 'id_example' # String | The id of the department to get.

begin
  #Search and view details of a college department
  api_instance.department_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DepartmentApi->department_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the department to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## department_list

> department_list(from, count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::DepartmentApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of college departments
  api_instance.department_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DepartmentApi->department_list: #{e}"
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


## department_save

> department_save(id, opts)

Create or edit a college department

Allows the user to create or edit a college department.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::DepartmentApi.new
id = 'id_example' # String | The id of the department save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a college department
  api_instance.department_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DepartmentApi->department_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the department save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

