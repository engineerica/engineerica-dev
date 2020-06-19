# OpenapiClient::ReportscheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportschedule_delete**](ReportscheduleApi.md#reportschedule_delete) | **DELETE** /reportschedule/{id} | Delete a report schedule
[**reportschedule_get**](ReportscheduleApi.md#reportschedule_get) | **GET** /reportschedule/{id} | Get a report schedule
[**reportschedule_list**](ReportscheduleApi.md#reportschedule_list) | **GET** /reportschedule/list | View a list of the scheduled reports
[**reportschedule_save**](ReportscheduleApi.md#reportschedule_save) | **POST** /reportschedule/{id} | Create or edit a report schedule



## reportschedule_delete

> reportschedule_delete(id, opts)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportscheduleApi.new
id = 'id_example' # String | The id of the report schedule to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a report schedule
  api_instance.reportschedule_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportscheduleApi->reportschedule_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the report schedule to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## reportschedule_get

> reportschedule_get(id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportscheduleApi.new
id = 'id_example' # String | The id of the schedule to get.

begin
  #Get a report schedule
  api_instance.reportschedule_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportscheduleApi->reportschedule_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the schedule to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportschedule_list

> reportschedule_list(from, count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportscheduleApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of the scheduled reports
  api_instance.reportschedule_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportscheduleApi->reportschedule_list: #{e}"
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


## reportschedule_save

> reportschedule_save(id, opts)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportscheduleApi.new
id = 'id_example' # String | The id of the schedule save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a report schedule
  api_instance.reportschedule_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportscheduleApi->reportschedule_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the schedule save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

