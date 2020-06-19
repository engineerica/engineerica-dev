# OpenapiClient::SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**session_bulkupdate**](SessionApi.md#session_bulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**session_get**](SessionApi.md#session_get) | **GET** /session/{id} | View details of a session
[**session_getschedule**](SessionApi.md#session_getschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**session_list**](SessionApi.md#session_list) | **GET** /session/list | Gets all future sessions of the current semester



## session_bulkupdate

> session_bulkupdate(eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionApi.new
eventid = 'eventid_example' # String | The id of the event to bulk update.
sessions = 'sessions_example' # String | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

begin
  #Bulk update event sessions
  api_instance.session_bulkupdate(eventid, sessions)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionApi->session_bulkupdate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event to bulk update. | 
 **sessions** | **String**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## session_get

> session_get(id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionApi.new
id = 'id_example' # String | The id of the session to get.

begin
  #View details of a session
  api_instance.session_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionApi->session_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the session to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## session_getschedule

> session_getschedule(opts)

Gets the schedule for a location, instructor or attendees

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionApi.new
opts = {
  day: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The day to return. It will also return the whole week for that day.
  attendee: 'attendee_example', # String | The id of the attendee to get the schedule.
  location: 'location_example', # String | The id of the location to get the schedule.
  instructor: 'instructor_example' # String | The id of the instructor to get the schedule.
}

begin
  #Gets the schedule for a location, instructor or attendees
  api_instance.session_getschedule(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionApi->session_getschedule: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **day** | **DateTime**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**String**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**String**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**String**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## session_list

> session_list(from, count, opts)

Gets all future sessions of the current semester

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date to filter the sessions
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date to filter the sessions.
}

begin
  #Gets all future sessions of the current semester
  api_instance.session_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionApi->session_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **startdate** | **DateTime**| The start date to filter the sessions | [optional] 
 **enddate** | **DateTime**| The end date to filter the sessions. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

