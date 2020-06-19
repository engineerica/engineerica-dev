# OpenapiClient::SeminarApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**seminar_delete**](SeminarApi.md#seminar_delete) | **DELETE** /seminar/{id} | Delete an event
[**seminar_get**](SeminarApi.md#seminar_get) | **GET** /seminar/{id} | Search and view details of a event
[**seminar_list**](SeminarApi.md#seminar_list) | **GET** /seminar/list | View a list of events
[**seminar_save**](SeminarApi.md#seminar_save) | **POST** /seminar/{id} | Create or edit a event



## seminar_delete

> seminar_delete(id, opts)

Delete an event

Allows the user to delete an existing event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SeminarApi.new
id = 'id_example' # String | The id of the seminar to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an event
  api_instance.seminar_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SeminarApi->seminar_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the seminar to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## seminar_get

> seminar_get(id)

Search and view details of a event

Allows the user to view a event and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SeminarApi.new
id = 'id_example' # String | The id of the seminar to get.

begin
  #Search and view details of a event
  api_instance.seminar_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SeminarApi->seminar_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the seminar to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## seminar_list

> seminar_list(from, count, opts)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SeminarApi.new
from = 'from_example' # String | The first record to return.
count = 'count_example' # String | The max number of records to return.
opts = {
  summaryonly: true, # Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  termid: 'termid_example' # String | Id of the term to list the events. Null to list all events.
}

begin
  #View a list of events
  api_instance.seminar_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SeminarApi->seminar_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **String**| The first record to return. | 
 **count** | **String**| The max number of records to return. | 
 **summaryonly** | **Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**String**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## seminar_save

> seminar_save(id, opts)

Create or edit a event

Allows the user to create or edit a event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SeminarApi.new
id = 'id_example' # String | The id of the event to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a event
  api_instance.seminar_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SeminarApi->seminar_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the event to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

