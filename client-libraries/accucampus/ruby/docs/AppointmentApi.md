# OpenapiClient::AppointmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appointment_cancel**](AppointmentApi.md#appointment_cancel) | **GET** /appointment/cancel | Cancel an appointment
[**appointment_checkisvalid**](AppointmentApi.md#appointment_checkisvalid) | **GET** /appointment/checkisvalid | Check if an appointment is valid or not
[**appointment_editanyway**](AppointmentApi.md#appointment_editanyway) | **GET** /appointment/editanyway | Edit an appointment even if it breaks activated rules
[**appointment_editpresence**](AppointmentApi.md#appointment_editpresence) | **GET** /appointment/editpresence | Edit the no-show status of an appointment
[**appointment_findallstaffslots**](AppointmentApi.md#appointment_findallstaffslots) | **GET** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
[**appointment_findslots**](AppointmentApi.md#appointment_findslots) | **GET** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
[**appointment_findstaff**](AppointmentApi.md#appointment_findstaff) | **GET** /appointment/findstaff | Finds staff available by service, date, event, etc
[**appointment_get**](AppointmentApi.md#appointment_get) | **GET** /appointment/{id} | Search and view details of an appointment
[**appointment_getcurrent**](AppointmentApi.md#appointment_getcurrent) | **GET** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**appointment_getlocations**](AppointmentApi.md#appointment_getlocations) | **GET** /appointment/getlocations | Find locations where a service is available
[**appointment_list**](AppointmentApi.md#appointment_list) | **GET** /appointment/list | View a list of appointments
[**appointment_listmine**](AppointmentApi.md#appointment_listmine) | **GET** /appointment/listmine | View all my upcoming appointments
[**appointment_listupcoming**](AppointmentApi.md#appointment_listupcoming) | **GET** /appointment/listupcoming | Search and view details of all my upcoming appointments
[**appointment_rescheduleoutlook**](AppointmentApi.md#appointment_rescheduleoutlook) | **GET** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
[**appointment_restore**](AppointmentApi.md#appointment_restore) | **GET** /appointment/restore | Restore an appointment
[**appointment_restoreanyway**](AppointmentApi.md#appointment_restoreanyway) | **GET** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
[**appointment_save**](AppointmentApi.md#appointment_save) | **POST** /appointment/{id} | Schedule an appointment
[**appointment_setasvalid**](AppointmentApi.md#appointment_setasvalid) | **GET** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
[**appointment_suggestlocations**](AppointmentApi.md#appointment_suggestlocations) | **GET** /appointment/suggestlocations | View the locations with most appointments
[**appointment_suggestservices**](AppointmentApi.md#appointment_suggestservices) | **GET** /appointment/suggestservices | View the services with most appointments
[**appointment_void**](AppointmentApi.md#appointment_void) | **GET** /appointment/void | Void an appointment



## appointment_cancel

> appointment_cancel(id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to cancel.

begin
  #Cancel an appointment
  api_instance.appointment_cancel(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_cancel: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_checkisvalid

> appointment_checkisvalid(id, opts)

Check if an appointment is valid or not

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to check.
opts = {
  editing: true # Boolean | Specifies whether the check is for a new appointment or an existing one.
}

begin
  #Check if an appointment is valid or not
  api_instance.appointment_checkisvalid(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_checkisvalid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to check. | 
 **editing** | **Boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_editanyway

> appointment_editanyway(id, attendee, staff, location, start, _end, opts)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to edit.
attendee = 'attendee_example' # String | The id of the attendee involved in the appointment.
staff = 'staff_example' # String | The id of the staff member involved in the appointment.
location = 'location_example' # String | The id of the location where the appointment will take place.
start = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's start date & time.
_end = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's end date & time.
opts = {
  term: 'term_example', # String | The id of the term when the appointment takes place.
  event: 'event_example', # String | The id of the event of the appointment.
  services: 'services_example', # String | Comma-separated string containing the ids of the services of the appointment.
  notes: 'notes_example' # String | The notes of the appointment.
}

begin
  #Edit an appointment even if it breaks activated rules
  api_instance.appointment_editanyway(id, attendee, staff, location, start, _end, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_editanyway: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to edit. | 
 **attendee** | [**String**](.md)| The id of the attendee involved in the appointment. | 
 **staff** | [**String**](.md)| The id of the staff member involved in the appointment. | 
 **location** | [**String**](.md)| The id of the location where the appointment will take place. | 
 **start** | **DateTime**| The appointment&#39;s start date &amp; time. | 
 **_end** | **DateTime**| The appointment&#39;s end date &amp; time. | 
 **term** | [**String**](.md)| The id of the term when the appointment takes place. | [optional] 
 **event** | [**String**](.md)| The id of the event of the appointment. | [optional] 
 **services** | **String**| Comma-separated string containing the ids of the services of the appointment. | [optional] 
 **notes** | **String**| The notes of the appointment. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_editpresence

> appointment_editpresence(id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to edit its presence.
showedup = true # Boolean | Specifies whether the attendee was showed-up or not in the appointment.

begin
  #Edit the no-show status of an appointment
  api_instance.appointment_editpresence(id, showedup)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_editpresence: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **Boolean**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_findallstaffslots

> appointment_findallstaffslots(starttime, endtime, serviceids, locationid, opts)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # String | CSV list of the service Ids to filter by.
locationid = 'locationid_example' # String | The id of the service to filter by.
opts = {
  eventid: 'eventid_example', # String | The id of the event to filter by.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Finds all staff available slots filtered by service, date, etc
  api_instance.appointment_findallstaffslots(starttime, endtime, serviceids, locationid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_findallstaffslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **locationid** | [**String**](.md)| The id of the service to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_findslots

> appointment_findslots(staffid, starttime, endtime, serviceids, opts)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
staffid = 'staffid_example' # String | The id of the staff to filter by.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # String | CSV list of the service Ids to filter by.
opts = {
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example' # String | The id of the service to filter by.
}

begin
  #Finds available slots filtered by service, date, staff, etc
  api_instance.appointment_findslots(staffid, starttime, endtime, serviceids, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_findslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**String**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_findstaff

> appointment_findstaff(serviceids, starttime, endtime, opts)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
serviceids = 'serviceids_example' # String | CSV list of the service ids to filter by.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the service to filter by.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Finds staff available by service, date, event, etc
  api_instance.appointment_findstaff(serviceids, starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_findstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceids** | **String**| CSV list of the service ids to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_get

> appointment_get(id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to get.

begin
  #Search and view details of an appointment
  api_instance.appointment_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_getcurrent

> appointment_getcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::AppointmentApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location where the user wants to sign-in.

begin
  #Get the current appointments for the user that is about to sign-in via the specified sign-in station.
  api_instance.appointment_getcurrent(station, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_getcurrent: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_getlocations

> appointment_getlocations(serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
serviceid = 'serviceid_example' # String | The id of the service to get its locations.

begin
  #Find locations where a service is available
  api_instance.appointment_getlocations(serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_getlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_list

> appointment_list(from, count, opts)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the appointments.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The end date of the period to filter the appointments.
  userid: 'userid_example' # String | The attendee id to filter the appointments.
}

begin
  #View a list of appointments
  api_instance.appointment_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **startdate** | **DateTime**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**String**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_listmine

> appointment_listmine(opts)

View all my upcoming appointments

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
opts = {
  start: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | If specified, only appointments that start after the specified date will be returned.
  modifiedafter: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | If specified, only appointments modified after the specified date will be returned.
}

begin
  #View all my upcoming appointments
  api_instance.appointment_listmine(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_listmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_listupcoming

> appointment_listupcoming(opts)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
opts = {
  start: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | If specified, only appointments that start after the specified date will be returned.
  modifiedafter: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | If specified, only appointments modified after the specified date will be returned.
}

begin
  #Search and view details of all my upcoming appointments
  api_instance.appointment_listupcoming(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_listupcoming: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_rescheduleoutlook

> appointment_rescheduleoutlook(id, start, _end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to edit.
start = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's start date & time.
_end = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's end date & time.

begin
  #Reschedule an appointment from MS Outlook.
  api_instance.appointment_rescheduleoutlook(id, start, _end)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_rescheduleoutlook: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to edit. | 
 **start** | **DateTime**| The appointment&#39;s start date &amp; time. | 
 **_end** | **DateTime**| The appointment&#39;s end date &amp; time. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_restore

> appointment_restore(id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to restore.

begin
  #Restore an appointment
  api_instance.appointment_restore(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_restore: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_restoreanyway

> appointment_restoreanyway(id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to restore.

begin
  #Restore an appointment even if it breaks activated rules
  api_instance.appointment_restoreanyway(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_restoreanyway: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_save

> appointment_save(id, opts)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Schedule an appointment
  api_instance.appointment_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## appointment_setasvalid

> appointment_setasvalid(id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to set as valid.

begin
  #Schedule an appointment even if it breaks activated rules
  api_instance.appointment_setasvalid(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_setasvalid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to set as valid. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointment_suggestlocations

> appointment_suggestlocations

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new

begin
  #View the locations with most appointments
  api_instance.appointment_suggestlocations
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_suggestlocations: #{e}"
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


## appointment_suggestservices

> appointment_suggestservices

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new

begin
  #View the services with most appointments
  api_instance.appointment_suggestservices
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_suggestservices: #{e}"
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


## appointment_void

> appointment_void(id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppointmentApi.new
id = 'id_example' # String | The id of the appointment to cancel.

begin
  #Void an appointment
  api_instance.appointment_void(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppointmentApi->appointment_void: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

