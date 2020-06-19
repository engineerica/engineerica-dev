# OpenapiClient::AttendancelogApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelog_delete**](AttendancelogApi.md#attendancelog_delete) | **DELETE** /attendancelog/{id} | Delete an attendance log
[**attendancelog_get**](AttendancelogApi.md#attendancelog_get) | **GET** /attendancelog/{id} | Search and view details of an attendance log
[**attendancelog_getchangehistory**](AttendancelogApi.md#attendancelog_getchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**attendancelog_list**](AttendancelogApi.md#attendancelog_list) | **GET** /attendancelog/list | View a list of attendance logs
[**attendancelog_listmine**](AttendancelogApi.md#attendancelog_listmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
[**attendancelog_save**](AttendancelogApi.md#attendancelog_save) | **POST** /attendancelog/{id} | Create or edit an attendance log
[**attendancelog_signout**](AttendancelogApi.md#attendancelog_signout) | **GET** /attendancelog/signout | Sign out an attendance log
[**attendancelog_whosin**](AttendancelogApi.md#attendancelog_whosin) | **GET** /attendancelog/whosin | View who&#39;s in a location



## attendancelog_delete

> attendancelog_delete(id, opts)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
id = 'id_example' # String | The id of the attendance log to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an attendance log
  api_instance.attendancelog_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the attendance log to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancelog_get

> attendancelog_get(id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
id = 'id_example' # String | The id of the attendance log to get.

begin
  #Search and view details of an attendance log
  api_instance.attendancelog_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the attendance log to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelog_getchangehistory

> attendancelog_getchangehistory(id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
id = 'id_example' # String | The id of the attendance log to get.

begin
  #Search and view details of an attendance log's swipe history
  api_instance.attendancelog_getchangehistory(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_getchangehistory: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the attendance log to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelog_list

> attendancelog_list(from, count, opts)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  filter: 'filter_example', # String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
  userid: 'userid_example' # String | The user ID of the user to get the logs.
}

begin
  #View a list of attendance logs
  api_instance.attendancelog_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**String**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelog_listmine

> attendancelog_listmine(from, count, opts)

Gets the attendance logs of the current user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  filter: 'filter_example' # String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
}

begin
  #Gets the attendance logs of the current user
  api_instance.attendancelog_listmine(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_listmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelog_save

> attendancelog_save(id, opts)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
id = 'id_example' # String | The id of the room to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an attendance log
  api_instance.attendancelog_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the room to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancelog_signout

> attendancelog_signout(opts)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
opts = {
  id: 'id_example', # String | The id of the attendance log to sign-out.
  location: 'location_example', # String | The id of the location to filter the users to sign out.
  event: 'event_example', # String | The id of the event to filter the users to sign out.
  datetime: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Specifies the date and time when the specified logs have to be signed out.
}

begin
  #Sign out an attendance log
  api_instance.attendancelog_signout(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_signout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**String**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **event** | [**String**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **DateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelog_whosin

> attendancelog_whosin(from, count, opts)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AttendancelogApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  location: 'location_example', # String | The id of the location to search for users that are in.
  event: 'event_example', # String | The id of the event to search for users that are in.
  sorting: 'sorting_example', # String | Field to sort by. Either first-name, last-name or sign-in-time.
  roles: 'roles_example', # String | The comma-separated list of ids of the roles to search for users that are in.
  photosize: 56, # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  extensions: 'extensions_example', # String | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
  export: true # Boolean | True to export the results as CSV
}

begin
  #View who's in a location
  api_instance.attendancelog_whosin(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AttendancelogApi->attendancelog_whosin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **location** | [**String**](.md)| The id of the location to search for users that are in. | [optional] 
 **event** | [**String**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **String**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **String**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **Boolean**| True to export the results as CSV | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

