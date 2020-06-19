# OpenapiClient::EventApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**event_checksessions**](EventApi.md#event_checksessions) | **GET** /event/checksessions | Edit an event&#39;s sessions according to their schedule
[**event_delete**](EventApi.md#event_delete) | **DELETE** /event/{id} | Delete a course
[**event_get**](EventApi.md#event_get) | **GET** /event/{id} | Search and view details of a course
[**event_getsessionsbydate**](EventApi.md#event_getsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
[**event_list**](EventApi.md#event_list) | **GET** /event/list | View a list of courses
[**event_listregistered**](EventApi.md#event_listregistered) | **GET** /event/listregistered | View a list of courses I am registered to
[**event_save**](EventApi.md#event_save) | **POST** /event/{id} | Create or edit a course
[**event_searchgroup**](EventApi.md#event_searchgroup) | **GET** /event/searchgroup | Searches for the available event groups



## event_checksessions

> event_checksessions(eventid, autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
eventid = 'eventid_example' # String | The id of the event to check.
autorepair = true # Boolean | True to automatically fix the invalid sessions.

begin
  #Edit an event's sessions according to their schedule
  api_instance.event_checksessions(eventid, autorepair)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_checksessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event to check. | 
 **autorepair** | **Boolean**| True to automatically fix the invalid sessions. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## event_delete

> event_delete(id, opts)

Delete a course

Allows the user to delete an existing course.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
id = 'id_example' # String | The id of the event to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a course
  api_instance.event_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the event to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## event_get

> event_get(id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
id = 'id_example' # String | The id of the event to get.

begin
  #Search and view details of a course
  api_instance.event_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the event to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## event_getsessionsbydate

> event_getsessionsbydate(opts)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
opts = {
  location: 'location_example', # String | The location to filter the events.
  date: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The date to filter the events. Today will be used if this parameter is omitted.
  type: 'type_example' # String | Type of event to list.
}

begin
  #View a list of courses by date
  api_instance.event_getsessionsbydate(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_getsessionsbydate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**String**](.md)| The location to filter the events. | [optional] 
 **date** | **DateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **String**| Type of event to list. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## event_list

> event_list(from, count, opts)

View a list of courses

Allows the user to view the full list of courses.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
from = 'from_example' # String | The first record to return.
count = 'count_example' # String | The max number of records to return.
opts = {
  summaryonly: true, # Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  termid: 'termid_example' # String | Id of the term to list the events. Null to list all events.
}

begin
  #View a list of courses
  api_instance.event_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_list: #{e}"
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


## event_listregistered

> event_listregistered(from, count, opts)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
from = 'from_example' # String | The first record to return.
count = 'count_example' # String | The max number of records to return.
opts = {
  summaryonly: true, # Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  termid: 'termid_example' # String | Id of the term to list the events. Null to list all events.
}

begin
  #View a list of courses I am registered to
  api_instance.event_listregistered(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_listregistered: #{e}"
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


## event_save

> event_save(id, opts)

Create or edit a course

Allows the user to create or edit a course.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
id = 'id_example' # String | The id of the event to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a course
  api_instance.event_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_save: #{e}"
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


## event_searchgroup

> event_searchgroup(query)

Searches for the available event groups

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventApi.new
query = 'query_example' # String | Query to search event groups.

begin
  #Searches for the available event groups
  api_instance.event_searchgroup(query)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventApi->event_searchgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**String**](.md)| Query to search event groups. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

