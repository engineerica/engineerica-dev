# OpenapiClient::AdvancedstationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advancedstation_checkunknownuser**](AdvancedstationApi.md#advancedstation_checkunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**advancedstation_checkuserrole**](AdvancedstationApi.md#advancedstation_checkuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**advancedstation_createuser**](AdvancedstationApi.md#advancedstation_createuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
[**advancedstation_getevents**](AdvancedstationApi.md#advancedstation_getevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**advancedstation_getinfo**](AdvancedstationApi.md#advancedstation_getinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**advancedstation_getlocations**](AdvancedstationApi.md#advancedstation_getlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**advancedstation_getlogstaff**](AdvancedstationApi.md#advancedstation_getlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**advancedstation_getroles**](AdvancedstationApi.md#advancedstation_getroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**advancedstation_getservices**](AdvancedstationApi.md#advancedstation_getservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
[**advancedstation_getstaff**](AdvancedstationApi.md#advancedstation_getstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**advancedstation_issignedin**](AdvancedstationApi.md#advancedstation_issignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.



## advancedstation_checkunknownuser

> advancedstation_checkunknownuser(station, user, location)

Check whether the user is known by the system.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location the user picked.

begin
  #Check whether the user is known by the system.
  api_instance.advancedstation_checkunknownuser(station, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_checkunknownuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_checkuserrole

> advancedstation_checkuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location the user picked.

begin
  #Check whether the user is a staff member, an attendee or both.
  api_instance.advancedstation_checkuserrole(station, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_checkuserrole: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_createuser

> advancedstation_createuser(station, user, location, firstname, lastname, email, opts)

Creates a user via a sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user to create.
location = 'location_example' # String | The id of the location the user picked.
firstname = 'firstname_example' # String | The first name of the user to create.
lastname = 'lastname_example' # String | The last name of the user to create.
email = 'email_example' # String | The email of the user to create.
opts = {
  middlename: 'middlename_example' # String | The middle name of the user to create.
}

begin
  #Creates a user via a sign-in station.
  api_instance.advancedstation_createuser(station, user, location, firstname, lastname, email, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_createuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user to create. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 
 **firstname** | **String**| The first name of the user to create. | 
 **lastname** | **String**| The last name of the user to create. | 
 **email** | **String**| The email of the user to create. | 
 **middlename** | **String**| The middle name of the user to create. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_getevents

> advancedstation_getevents(station, location, user)

Gets the courses available for a specific location and a specific student.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
location = 'location_example' # String | The id of the location the student picked.
user = 'user_example' # String | The card of the user.

begin
  #Gets the courses available for a specific location and a specific student.
  api_instance.advancedstation_getevents(station, location, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_getevents: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **location** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_getinfo

> advancedstation_getinfo(id, opts)

Gets the info to display in the sign-in station by it's ID.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
id = 'id_example' # String | The id of the sign-in station to get.
opts = {
  event: 'event_example' # String | The id of the event (or session), to override the scheduled one.
}

begin
  #Gets the info to display in the sign-in station by it's ID.
  api_instance.advancedstation_getinfo(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_getinfo: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to get. | 
 **event** | [**String**](.md)| The id of the event (or session), to override the scheduled one. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_getlocations

> advancedstation_getlocations(station, user)

Gets the locations available in a sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station whose locations have to be returned.
user = 'user_example' # String | The card of the user.

begin
  #Gets the locations available in a sign-in station.
  api_instance.advancedstation_getlocations(station, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_getlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station whose locations have to be returned. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_getlogstaff

> advancedstation_getlogstaff(station, attendancelog, opts)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
attendancelog = 'attendancelog_example' # String | The id of the attendance log to filter the staff members.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
  api_instance.advancedstation_getlogstaff(station, attendancelog, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_getlogstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **attendancelog** | [**String**](.md)| The id of the attendance log to filter the staff members. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_getroles

> advancedstation_getroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
signinrole = 'signinrole_example' # String | Specifies how the user is signing-in.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location the user picked.

begin
  #Gets the user roles of the user trying to sign-in.
  api_instance.advancedstation_getroles(station, signinrole, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_getroles: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **signinrole** | **String**| Specifies how the user is signing-in. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_getservices

> advancedstation_getservices(station, location, user)

Gets the services available for a specific location.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
location = 'location_example' # String | The id of the location the student picked.
user = 'user_example' # String | The card of the user.

begin
  #Gets the services available for a specific location.
  api_instance.advancedstation_getservices(station, location, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_getservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **location** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_getstaff

> advancedstation_getstaff(station, locationid, user, opts)

Gets the staff/tutors available for a specific location, course and service.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
locationid = 'locationid_example' # String | The id of the location the student picked.
user = 'user_example' # String | The card of the user.
opts = {
  services: 'services_example', # String | The list of services selected by the user, in JSON format.
  eventid: 'eventid_example', # String | The ID of the event selected.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Gets the staff/tutors available for a specific location, course and service.
  api_instance.advancedstation_getstaff(station, locationid, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_getstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **locationid** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 
 **services** | **String**| The list of services selected by the user, in JSON format. | [optional] 
 **eventid** | [**String**](.md)| The ID of the event selected. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstation_issignedin

> advancedstation_issignedin(station, time, user, opts)

Gets whether a user is signed-in or not.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AdvancedstationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
time = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time of the swipe.
user = 'user_example' # String | The card of the user.
opts = {
  location: 'location_example' # String | The id of the location the user picked.
}

begin
  #Gets whether a user is signed-in or not.
  api_instance.advancedstation_issignedin(station, time, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvancedstationApi->advancedstation_issignedin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **time** | **DateTime**| The date and time of the swipe. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

