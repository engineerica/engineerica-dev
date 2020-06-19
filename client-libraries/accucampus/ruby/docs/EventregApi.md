# OpenapiClient::EventregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventreg_addme**](EventregApi.md#eventreg_addme) | **GET** /eventreg/addme | Register current user to a course
[**eventreg_addmetoall**](EventregApi.md#eventreg_addmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
[**eventreg_addmetogroup**](EventregApi.md#eventreg_addmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
[**eventreg_adduser**](EventregApi.md#eventreg_adduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
[**eventreg_addusertoall**](EventregApi.md#eventreg_addusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
[**eventreg_addusertogroup**](EventregApi.md#eventreg_addusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
[**eventreg_getevents**](EventregApi.md#eventreg_getevents) | **GET** /eventreg/getevents | View course registration by user
[**eventreg_getgroups**](EventregApi.md#eventreg_getgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
[**eventreg_getmyevents**](EventregApi.md#eventreg_getmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
[**eventreg_getmygroups**](EventregApi.md#eventreg_getmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
[**eventreg_getusers**](EventregApi.md#eventreg_getusers) | **GET** /eventreg/getusers | View course registration
[**eventreg_getusersfromgroup**](EventregApi.md#eventreg_getusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**eventreg_getuserstoall**](EventregApi.md#eventreg_getuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
[**eventreg_removeme**](EventregApi.md#eventreg_removeme) | **GET** /eventreg/removeme | Unregister current user from a course
[**eventreg_removemefromall**](EventregApi.md#eventreg_removemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
[**eventreg_removemefromgroup**](EventregApi.md#eventreg_removemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
[**eventreg_removeuser**](EventregApi.md#eventreg_removeuser) | **GET** /eventreg/removeuser | Remove a user from a course
[**eventreg_removeuserfromall**](EventregApi.md#eventreg_removeuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**eventreg_removeuserfromgroup**](EventregApi.md#eventreg_removeuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group



## eventreg_addme

> eventreg_addme(eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register current user to a course
  api_instance.eventreg_addme(eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_addme: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_addmetoall

> eventreg_addmetoall(listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register current user to all courses
  api_instance.eventreg_addmetoall(listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_addmetoall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_addmetogroup

> eventreg_addmetogroup(codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
codegroup = 'codegroup_example' # String | The code used to group events.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register current user to a course group
  api_instance.eventreg_addmetogroup(codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_addmetogroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_adduser

> eventreg_adduser(userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The id of the user to add.
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register a user to a course for attendance
  api_instance.eventreg_adduser(userid, eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_adduser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to add. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_addusertoall

> eventreg_addusertoall(userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The id of the user to add.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register a user to assist with all courses
  api_instance.eventreg_addusertoall(userid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_addusertoall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to add. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_addusertogroup

> eventreg_addusertogroup(userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The id of the user to add.
codegroup = 'codegroup_example' # String | The code used to group events.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register a user to an course group
  api_instance.eventreg_addusertogroup(userid, codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_addusertogroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to add. | 
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_getevents

> eventreg_getevents(userid, listname, opts)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The user id to list events.
listname = 'listname_example' # String | The name of the list where the user is registered.
opts = {
  termid: 'termid_example', # String | The term id to list events.
  namefilter: 'namefilter_example' # String | The value used to filter the events by name.
}

begin
  #View course registration by user
  api_instance.eventreg_getevents(userid, listname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_getevents: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The user id to list events. | 
 **listname** | **String**| The name of the list where the user is registered. | 
 **termid** | [**String**](.md)| The term id to list events. | [optional] 
 **namefilter** | **String**| The value used to filter the events by name. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_getgroups

> eventreg_getgroups(userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The user id to list events.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Lists the course group registrations of a user
  api_instance.eventreg_getgroups(userid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_getgroups: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The user id to list events. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_getmyevents

> eventreg_getmyevents(listname, opts)

View the event registrations of the current user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
listname = 'listname_example' # String | The name of the list where the user is registered.
opts = {
  termid: 'termid_example', # String | The term id to list events.
  namefilter: 'namefilter_example' # String | The value used to filter the events by name.
}

begin
  #View the event registrations of the current user
  api_instance.eventreg_getmyevents(listname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_getmyevents: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **String**| The name of the list where the user is registered. | 
 **termid** | [**String**](.md)| The term id to list events. | [optional] 
 **namefilter** | **String**| The value used to filter the events by name. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_getmygroups

> eventreg_getmygroups(listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #View all current user registrations to course groups
  api_instance.eventreg_getmygroups(listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_getmygroups: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_getusers

> eventreg_getusers(eventid, listname, opts)

View course registration

Allows the user to view all users registered for an individual course.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
eventid = 'eventid_example' # String | The event id to list users.
listname = 'listname_example' # String | The name of the list to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View course registration
  api_instance.eventreg_getusers(eventid, listname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_getusers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The event id to list users. | 
 **listname** | **String**| The name of the list to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_getusersfromgroup

> eventreg_getusersfromgroup(codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
codegroup = 'codegroup_example' # String | The code group to list users.
listname = 'listname_example' # String | The name of the list to get.

begin
  #Lists the registrations for a course group
  api_instance.eventreg_getusersfromgroup(codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_getusersfromgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**String**](.md)| The code group to list users. | 
 **listname** | **String**| The name of the list to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_getuserstoall

> eventreg_getuserstoall(listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
listname = 'listname_example' # String | The name of the list to get.

begin
  #View the users that are registered to all courses
  api_instance.eventreg_getuserstoall(listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_getuserstoall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **String**| The name of the list to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_removeme

> eventreg_removeme(eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Unregister current user from a course
  api_instance.eventreg_removeme(eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_removeme: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_removemefromall

> eventreg_removemefromall(listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove current user from the registration to all courses
  api_instance.eventreg_removemefromall(listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_removemefromall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_removemefromgroup

> eventreg_removemefromgroup(codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
codegroup = 'codegroup_example' # String | The code group of the events/courses.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove current user from a course group
  api_instance.eventreg_removemefromgroup(codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_removemefromgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_removeuser

> eventreg_removeuser(userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The id of the user to remove.
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove a user from a course
  api_instance.eventreg_removeuser(userid, eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_removeuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_removeuserfromall

> eventreg_removeuserfromall(userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The id of the user to remove.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove a user from the registration to all courses
  api_instance.eventreg_removeuserfromall(userid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_removeuserfromall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreg_removeuserfromgroup

> eventreg_removeuserfromgroup(userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EventregApi.new
userid = 'userid_example' # String | The id of the user to remove.
codegroup = 'codegroup_example' # String | The code group of the events/courses.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove a user from a course group
  api_instance.eventreg_removeuserfromgroup(userid, codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EventregApi->eventreg_removeuserfromgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

