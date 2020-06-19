# OpenapiClient::ScheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**schedule_delete**](ScheduleApi.md#schedule_delete) | **DELETE** /schedule/delete | Delete a schedule slot
[**schedule_deletemine**](ScheduleApi.md#schedule_deletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**schedule_enable**](ScheduleApi.md#schedule_enable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
[**schedule_enablemine**](ScheduleApi.md#schedule_enablemine) | **GET** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**schedule_findallstaffslots**](ScheduleApi.md#schedule_findallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**schedule_findslots**](ScheduleApi.md#schedule_findslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**schedule_findstaffavail**](ScheduleApi.md#schedule_findstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**schedule_get**](ScheduleApi.md#schedule_get) | **GET** /schedule/get | Search and view details of a specific schedule slot
[**schedule_getmine**](ScheduleApi.md#schedule_getmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
[**schedule_getstaff**](ScheduleApi.md#schedule_getstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
[**schedule_getstaffmine**](ScheduleApi.md#schedule_getstaffmine) | **GET** /schedule/getstaffmine | View current user&#39;s schedule information
[**schedule_myofftimes**](ScheduleApi.md#schedule_myofftimes) | **GET** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**schedule_save**](ScheduleApi.md#schedule_save) | **POST** /schedule/save | Create or edit a schedule slot
[**schedule_savemine**](ScheduleApi.md#schedule_savemine) | **POST** /schedule/savemine | Create or edit a block in current user&#39;s schedule



## schedule_delete

> schedule_delete(opts)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Delete a schedule slot
  api_instance.schedule_delete(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_delete: #{e}"
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


## schedule_deletemine

> schedule_deletemine(opts)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Delete a specific block from a user's own schedule
  api_instance.schedule_deletemine(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_deletemine: #{e}"
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


## schedule_enable

> schedule_enable(userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
userid = 'userid_example' # String | The id of the user to enable or disable the schedule.
enable = true # Boolean | True to enable schedules, false to disable.

begin
  #Enable or disable the schedule for a specific person
  api_instance.schedule_enable(userid, enable)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_enable: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_enablemine

> schedule_enablemine(enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
enable = true # Boolean | True to enable schedules, false to disable.

begin
  #Enable or disable current user's schedule
  api_instance.schedule_enablemine(enable)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_enablemine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_findallstaffslots

> schedule_findallstaffslots(starttime, endtime, opts)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  staffid: 'staffid_example', # String | The id of the staff to filter by.
  serviceids: 'serviceids_example', # String | CSV list of the service Ids to filter by.
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the location to filter by.
  staffroleids: 'staffroleids_example', # String | CSV list of the staff member role ids to filter by.
  availablefor: 'availablefor_example' # String | The specific availability type to filter by.
}

begin
  #Search available schedule slots by service, event, date
  api_instance.schedule_findallstaffslots(starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_findallstaffslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **staffid** | [**String**](.md)| The id of the staff to filter by. | [optional] 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the location to filter by. | [optional] 
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **String**| The specific availability type to filter by. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_findslots

> schedule_findslots(staffid, starttime, endtime, opts)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
staffid = 'staffid_example' # String | The id of the staff to filter by.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  serviceids: 'serviceids_example', # String | CSV list of the service Ids to filter by.
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the service to filter by.
  availablefor: 'availablefor_example' # String | The specific availability type to filter by.
}

begin
  #Search available schedule slots by service, event, date and/or staff
  api_instance.schedule_findslots(staffid, starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_findslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**String**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **availablefor** | **String**| The specific availability type to filter by. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_findstaffavail

> schedule_findstaffavail(starttime, endtime, opts)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  serviceids: 'serviceids_example', # String | CSV list of the service ids to filter by.
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the service to filter by.
  staffroleids: 'staffroleids_example', # String | CSV list of the staff member role ids to filter by.
  availablefor: 'availablefor_example', # String | Filter slots by a specific availability type.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Search available staff members slots by service, event, and/or date
  api_instance.schedule_findstaffavail(starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_findstaffavail: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **String**| Filter slots by a specific availability type. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_get

> schedule_get(scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
scheduleid = 'scheduleid_example' # String | The id of the schedule.

begin
  #Search and view details of a specific schedule slot
  api_instance.schedule_get(scheduleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_getmine

> schedule_getmine(scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
scheduleid = 'scheduleid_example' # String | The id of the schedule.

begin
  #View details of a specific schedule block, for current user
  api_instance.schedule_getmine(scheduleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_getmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_getstaff

> schedule_getstaff(userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
userid = 'userid_example' # String | The id of the user to get info.

begin
  #View a list of schedule information of a specified person
  api_instance.schedule_getstaff(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_getstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to get info. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_getstaffmine

> schedule_getstaffmine

View current user's schedule information

Allows the user to view their own schedule.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new

begin
  #View current user's schedule information
  api_instance.schedule_getstaffmine
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_getstaffmine: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_myofftimes

> schedule_myofftimes(opts)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
opts = {
  includedeleted: true, # Boolean | If true the deleted offtimes are also returned.
  onlyupcoming: true, # Boolean | If true then only upcoming offtimes are returned.
  modifiedafter: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | If specified, only offtimes modified after the specified date will be returned.
}

begin
  #View current user's schedule exceptions
  api_instance.schedule_myofftimes(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_myofftimes: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includedeleted** | **Boolean**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **Boolean**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedule_save

> schedule_save(opts)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a schedule slot
  api_instance.schedule_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_save: #{e}"
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


## schedule_savemine

> schedule_savemine(opts)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a block in current user's schedule
  api_instance.schedule_savemine(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleApi->schedule_savemine: #{e}"
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

