# OpenapiClient::AttendancelogcommentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogcomment_delete**](AttendancelogcommentApi.md#attendancelogcomment_delete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**attendancelogcomment_get**](AttendancelogcommentApi.md#attendancelogcomment_get) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
[**attendancelogcomment_list**](AttendancelogcommentApi.md#attendancelogcomment_list) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
[**attendancelogcomment_save**](AttendancelogcommentApi.md#attendancelogcomment_save) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log



## attendancelogcomment_delete

> attendancelogcomment_delete(id, opts)

Delete a comment on an attendance log

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogcommentApi.new
id = 'id_example' # String | The id of the attendance log comment to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a comment on an attendance log
  api_instance.attendancelogcomment_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogcommentApi->attendancelogcomment_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the attendance log comment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancelogcomment_get

> attendancelogcomment_get(id)

View a comment on an attendance log

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogcommentApi.new
id = 'id_example' # String | The id of the comment to get.

begin
  #View a comment on an attendance log
  api_instance.attendancelogcomment_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogcommentApi->attendancelogcomment_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the comment to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcomment_list

> attendancelogcomment_list(attendancelog)

View all the comments on a specific attendance log

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogcommentApi.new
attendancelog = 'attendancelog_example' # String | The id of the attendance log whose comments have to be retrieved.

begin
  #View all the comments on a specific attendance log
  api_instance.attendancelogcomment_list(attendancelog)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogcommentApi->attendancelogcomment_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**String**](.md)| The id of the attendance log whose comments have to be retrieved. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcomment_save

> attendancelogcomment_save(id, opts)

Save a comment on an attendance log

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogcommentApi.new
id = 'id_example' # String | The id of the comment to edit (leave empty to create a new one)
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save a comment on an attendance log
  api_instance.attendancelogcomment_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogcommentApi->attendancelogcomment_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the comment to edit (leave empty to create a new one) | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

