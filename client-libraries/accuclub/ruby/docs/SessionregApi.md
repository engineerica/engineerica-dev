# OpenapiClient::SessionregApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionreg_addcurrentuser**](SessionregApi.md#sessionreg_addcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
[**sessionreg_adduser**](SessionregApi.md#sessionreg_adduser) | **GET** /sessionreg/adduser | Register users for events
[**sessionreg_getmysessions**](SessionregApi.md#sessionreg_getmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
[**sessionreg_getsessions**](SessionregApi.md#sessionreg_getsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
[**sessionreg_getsettings**](SessionregApi.md#sessionreg_getsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
[**sessionreg_getusers**](SessionregApi.md#sessionreg_getusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
[**sessionreg_listsessions**](SessionregApi.md#sessionreg_listsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
[**sessionreg_listupcoming**](SessionregApi.md#sessionreg_listupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
[**sessionreg_listupcomingevent**](SessionregApi.md#sessionreg_listupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
[**sessionreg_removecurrentuser**](SessionregApi.md#sessionreg_removecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
[**sessionreg_removeuser**](SessionregApi.md#sessionreg_removeuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
[**sessionreg_savesettings**](SessionregApi.md#sessionreg_savesettings) | **POST** /sessionreg/savesettings | Save the settings for an event&#39;s session registration



## sessionreg_addcurrentuser

> sessionreg_addcurrentuser(eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Register current user to an event session
  api_instance.sessionreg_addcurrentuser(eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_addcurrentuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_adduser

> sessionreg_adduser(userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
userid = 'userid_example' # String | The id of the user to add.
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Register users for events
  api_instance.sessionreg_adduser(userid, eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_adduser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to add. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_getmysessions

> sessionreg_getmysessions(opts)

View all the sessions the logged user is registered to

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
opts = {
  date: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Start date to filter the sessions.
}

begin
  #View all the sessions the logged user is registered to
  api_instance.sessionreg_getmysessions(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_getmysessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime**| Start date to filter the sessions. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_getsessions

> sessionreg_getsessions(userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
userid = 'userid_example' # String | The user id to list sessions.

begin
  #Lists the registrations for a specific user
  api_instance.sessionreg_getsessions(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_getsessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The user id to list sessions. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_getsettings

> sessionreg_getsettings(opts)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
opts = {
  locationid: 'locationid_example', # String | The id of the location to save settings.
  eventid: 'eventid_example', # String | The id of the event to save settings.
  sessiondate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The date and time when the session starts.
  noinherit: true # Boolean | True to get the location/event/session specific settings without looking for the more global settings.
}

begin
  #Get the settings for session registration
  api_instance.sessionreg_getsettings(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_getsettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**String**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **DateTime**| The date and time when the session starts. | [optional] 
 **noinherit** | **Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_getusers

> sessionreg_getusers(eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
eventid = 'eventid_example' # String | The event id to list sessions.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date of the session to find.

begin
  #Lists the registrations for a specific session
  api_instance.sessionreg_getusers(eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_getusers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_listsessions

> sessionreg_listsessions(eventid, opts)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
eventid = 'eventid_example' # String | The event id to list sessions.
opts = {
  sessiondate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date of the session to find.
}

begin
  #List the sessions available for a specific event
  api_instance.sessionreg_listsessions(eventid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_listsessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_listupcoming

> sessionreg_listupcoming(date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
date = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Only sessions in the week of the specified date will be returned.

begin
  #View a list of upcoming event sessions
  api_instance.sessionreg_listupcoming(date)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_listupcoming: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime**| Only sessions in the week of the specified date will be returned. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_listupcomingevent

> sessionreg_listupcomingevent(date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
date = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Start date to filter the returned sessions.
event = 'event_example' # String | The id of the event whose sessions will be returned

begin
  #View a list of upcoming sessions of a particular event
  api_instance.sessionreg_listupcomingevent(date, event)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_listupcomingevent: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime**| Start date to filter the returned sessions. | 
 **event** | [**String**](.md)| The id of the event whose sessions will be returned | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_removecurrentuser

> sessionreg_removecurrentuser(eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Unregister current user from an event session
  api_instance.sessionreg_removecurrentuser(eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_removecurrentuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_removeuser

> sessionreg_removeuser(userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
userid = 'userid_example' # String | The id of the user to remove.
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Removes a user from an event session
  api_instance.sessionreg_removeuser(userid, eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_removeuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreg_savesettings

> sessionreg_savesettings(opts)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionregApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save the settings for an event's session registration
  api_instance.sessionreg_savesettings(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionregApi->sessionreg_savesettings: #{e}"
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

