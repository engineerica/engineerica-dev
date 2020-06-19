# OpenapiClient::SessionattendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionattendancelog_addnote**](SessionattendancelogApi.md#sessionattendancelog_addnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
[**sessionattendancelog_get**](SessionattendancelogApi.md#sessionattendancelog_get) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
[**sessionattendancelog_getuser**](SessionattendancelogApi.md#sessionattendancelog_getuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**sessionattendancelog_list**](SessionattendancelogApi.md#sessionattendancelog_list) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
[**sessionattendancelog_listevent**](SessionattendancelogApi.md#sessionattendancelog_listevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
[**sessionattendancelog_listsummary**](SessionattendancelogApi.md#sessionattendancelog_listsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**sessionattendancelog_mylistsummary**](SessionattendancelogApi.md#sessionattendancelog_mylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
[**sessionattendancelog_save**](SessionattendancelogApi.md#sessionattendancelog_save) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
[**sessionattendancelog_saveswipe**](SessionattendancelogApi.md#sessionattendancelog_saveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe



## sessionattendancelog_addnote

> sessionattendancelog_addnote(id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
id = 'id_example' # String | The id of the attendance log.
text = 'text_example' # String | The text of the note to add.

begin
  #Add a note to a class attendance log
  api_instance.sessionattendancelog_addnote(id, text)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_addnote: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the attendance log. | 
 **text** | **String**| The text of the note to add. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelog_get

> sessionattendancelog_get(id, opts)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
id = 'id_example' # String | The id of the attendance log to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a class attendance log
  api_instance.sessionattendancelog_get(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the attendance log to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelog_getuser

> sessionattendancelog_getuser(attendee, eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
attendee = 'attendee_example' # String | The id of the attendee to get statistic for.
eventid = 'eventid_example' # String | The id of the event whose attendee statistics have to be returned.

begin
  #View the class session attendance information for a specific user
  api_instance.sessionattendancelog_getuser(attendee, eventid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_getuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**String**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**String**](.md)| The id of the event whose attendee statistics have to be returned. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelog_list

> sessionattendancelog_list(session, from, count, opts)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
session = 'session_example' # String | The id of the session whose attendees logs have to be returned.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View attendance logs of the specified session
  api_instance.sessionattendancelog_list(session, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **session** | [**String**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelog_listevent

> sessionattendancelog_listevent(eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
eventid = 'eventid_example' # String | The id of the event whose attendance has to be returned.

begin
  #View the attendance information of an entire class
  api_instance.sessionattendancelog_listevent(eventid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_listevent: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelog_listsummary

> sessionattendancelog_listsummary(opts)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
opts = {
  eventid: 'eventid_example', # String | The id of the event whose attendance has to be returned.
  attendeeid: 'attendeeid_example', # String | The id of the attendee whose attendance has to be returned.
  groupid: 'groupid_example', # String | The id of the group whose attendance has to be returned.
  start: 'start_example', # String | The start date to filter (beginning of time by default).
  _end: '_end_example' # String | The end date to filter (today by default).
}

begin
  #View the attendance summary for a class and/or a attendee
  api_instance.sessionattendancelog_listsummary(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_listsummary: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**String**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**String**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **_end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelog_mylistsummary

> sessionattendancelog_mylistsummary(opts)

View my attendance summary

Allows the user to view their own attendance summary.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
opts = {
  eventid: 'eventid_example', # String | The id of the event whose attendance has to be returned.
  start: 'start_example', # String | The start date to filter (beginning of time by default).
  _end: '_end_example' # String | The end date to filter (today by default).
}

begin
  #View my attendance summary
  api_instance.sessionattendancelog_mylistsummary(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_mylistsummary: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **_end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelog_save

> sessionattendancelog_save(id, opts)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
id = 'id_example' # String | The id of the att log to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a class attendance log
  api_instance.sessionattendancelog_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the att log to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionattendancelog_saveswipe

> sessionattendancelog_saveswipe(opts)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionattendancelogApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a class attendance log swipe
  api_instance.sessionattendancelog_saveswipe(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionattendancelogApi->sessionattendancelog_saveswipe: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

