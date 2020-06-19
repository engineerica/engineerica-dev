# openapi_client.AppointmentApi

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


# **appointment_cancel**
> appointment_cancel(id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to cancel.

    try:
        # Cancel an appointment
        api_instance.appointment_cancel(id)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_cancel: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_checkisvalid**
> appointment_checkisvalid(id, editing=editing)

Check if an appointment is valid or not

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to check.
editing = True # bool | Specifies whether the check is for a new appointment or an existing one. (optional)

    try:
        # Check if an appointment is valid or not
        api_instance.appointment_checkisvalid(id, editing=editing)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_checkisvalid: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to check. | 
 **editing** | **bool**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_editanyway**
> appointment_editanyway(id, attendee, staff, location, start, end, term=term, event=event, services=services, notes=notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to edit.
attendee = 'attendee_example' # str | The id of the attendee involved in the appointment.
staff = 'staff_example' # str | The id of the staff member involved in the appointment.
location = 'location_example' # str | The id of the location where the appointment will take place.
start = '2013-10-20T19:20:30+01:00' # datetime | The appointment's start date & time.
end = '2013-10-20T19:20:30+01:00' # datetime | The appointment's end date & time.
term = 'term_example' # str | The id of the term when the appointment takes place. (optional)
event = 'event_example' # str | The id of the event of the appointment. (optional)
services = 'services_example' # str | Comma-separated string containing the ids of the services of the appointment. (optional)
notes = 'notes_example' # str | The notes of the appointment. (optional)

    try:
        # Edit an appointment even if it breaks activated rules
        api_instance.appointment_editanyway(id, attendee, staff, location, start, end, term=term, event=event, services=services, notes=notes)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_editanyway: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to edit. | 
 **attendee** | [**str**](.md)| The id of the attendee involved in the appointment. | 
 **staff** | [**str**](.md)| The id of the staff member involved in the appointment. | 
 **location** | [**str**](.md)| The id of the location where the appointment will take place. | 
 **start** | **datetime**| The appointment&#39;s start date &amp; time. | 
 **end** | **datetime**| The appointment&#39;s end date &amp; time. | 
 **term** | [**str**](.md)| The id of the term when the appointment takes place. | [optional] 
 **event** | [**str**](.md)| The id of the event of the appointment. | [optional] 
 **services** | **str**| Comma-separated string containing the ids of the services of the appointment. | [optional] 
 **notes** | **str**| The notes of the appointment. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_editpresence**
> appointment_editpresence(id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to edit its presence.
showedup = True # bool | Specifies whether the attendee was showed-up or not in the appointment.

    try:
        # Edit the no-show status of an appointment
        api_instance.appointment_editpresence(id, showedup)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_editpresence: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **bool**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_findallstaffslots**
> appointment_findallstaffslots(starttime, endtime, serviceids, locationid, eventid=eventid, photosize=photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    starttime = '2013-10-20T19:20:30+01:00' # datetime | The start time of the range to look for slots.
endtime = '2013-10-20T19:20:30+01:00' # datetime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # str | CSV list of the service Ids to filter by.
locationid = 'locationid_example' # str | The id of the service to filter by.
eventid = 'eventid_example' # str | The id of the event to filter by. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Finds all staff available slots filtered by service, date, etc
        api_instance.appointment_findallstaffslots(starttime, endtime, serviceids, locationid, eventid=eventid, photosize=photosize)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_findallstaffslots: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **datetime**| The start time of the range to look for slots. | 
 **endtime** | **datetime**| The end time of the range to look for slots. | 
 **serviceids** | **str**| CSV list of the service Ids to filter by. | 
 **locationid** | [**str**](.md)| The id of the service to filter by. | 
 **eventid** | [**str**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_findslots**
> appointment_findslots(staffid, starttime, endtime, serviceids, eventid=eventid, locationid=locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    staffid = 'staffid_example' # str | The id of the staff to filter by.
starttime = '2013-10-20T19:20:30+01:00' # datetime | The start time of the range to look for slots.
endtime = '2013-10-20T19:20:30+01:00' # datetime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # str | CSV list of the service Ids to filter by.
eventid = 'eventid_example' # str | The id of the event to filter by. (optional)
locationid = 'locationid_example' # str | The id of the service to filter by. (optional)

    try:
        # Finds available slots filtered by service, date, staff, etc
        api_instance.appointment_findslots(staffid, starttime, endtime, serviceids, eventid=eventid, locationid=locationid)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_findslots: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**str**](.md)| The id of the staff to filter by. | 
 **starttime** | **datetime**| The start time of the range to look for slots. | 
 **endtime** | **datetime**| The end time of the range to look for slots. | 
 **serviceids** | **str**| CSV list of the service Ids to filter by. | 
 **eventid** | [**str**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**str**](.md)| The id of the service to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_findstaff**
> appointment_findstaff(serviceids, starttime, endtime, eventid=eventid, locationid=locationid, photosize=photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    serviceids = 'serviceids_example' # str | CSV list of the service ids to filter by.
starttime = '2013-10-20T19:20:30+01:00' # datetime | The start time of the range to look for slots.
endtime = '2013-10-20T19:20:30+01:00' # datetime | The end time of the range to look for slots.
eventid = 'eventid_example' # str | The id of the event to filter by. (optional)
locationid = 'locationid_example' # str | The id of the service to filter by. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Finds staff available by service, date, event, etc
        api_instance.appointment_findstaff(serviceids, starttime, endtime, eventid=eventid, locationid=locationid, photosize=photosize)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_findstaff: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceids** | **str**| CSV list of the service ids to filter by. | 
 **starttime** | **datetime**| The start time of the range to look for slots. | 
 **endtime** | **datetime**| The end time of the range to look for slots. | 
 **eventid** | [**str**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**str**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_get**
> appointment_get(id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to get.

    try:
        # Search and view details of an appointment
        api_instance.appointment_get(id)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_getcurrent**
> appointment_getcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
user = 'user_example' # str | The card of the user.
location = 'location_example' # str | The id of the location where the user wants to sign-in.

    try:
        # Get the current appointments for the user that is about to sign-in via the specified sign-in station.
        api_instance.appointment_getcurrent(station, user, location)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_getcurrent: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **user** | **str**| The card of the user. | 
 **location** | [**str**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_getlocations**
> appointment_getlocations(serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    serviceid = 'serviceid_example' # str | The id of the service to get its locations.

    try:
        # Find locations where a service is available
        api_instance.appointment_getlocations(serviceid)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_getlocations: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**str**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_list**
> appointment_list(_from, count, startdate=startdate, enddate=enddate, userid=userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the appointments. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the appointments. (optional)
userid = 'userid_example' # str | The attendee id to filter the appointments. (optional)

    try:
        # View a list of appointments
        api_instance.appointment_list(_from, count, startdate=startdate, enddate=enddate, userid=userid)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **startdate** | **datetime**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**str**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_listmine**
> appointment_listmine(start=start, modifiedafter=modifiedafter)

View all my upcoming appointments

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    start = '2013-10-20T19:20:30+01:00' # datetime | If specified, only appointments that start after the specified date will be returned. (optional)
modifiedafter = '2013-10-20T19:20:30+01:00' # datetime | If specified, only appointments modified after the specified date will be returned. (optional)

    try:
        # View all my upcoming appointments
        api_instance.appointment_listmine(start=start, modifiedafter=modifiedafter)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_listmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **datetime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **datetime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_listupcoming**
> appointment_listupcoming(start=start, modifiedafter=modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    start = '2013-10-20T19:20:30+01:00' # datetime | If specified, only appointments that start after the specified date will be returned. (optional)
modifiedafter = '2013-10-20T19:20:30+01:00' # datetime | If specified, only appointments modified after the specified date will be returned. (optional)

    try:
        # Search and view details of all my upcoming appointments
        api_instance.appointment_listupcoming(start=start, modifiedafter=modifiedafter)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_listupcoming: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **datetime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **datetime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_rescheduleoutlook**
> appointment_rescheduleoutlook(id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to edit.
start = '2013-10-20T19:20:30+01:00' # datetime | The appointment's start date & time.
end = '2013-10-20T19:20:30+01:00' # datetime | The appointment's end date & time.

    try:
        # Reschedule an appointment from MS Outlook.
        api_instance.appointment_rescheduleoutlook(id, start, end)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_rescheduleoutlook: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to edit. | 
 **start** | **datetime**| The appointment&#39;s start date &amp; time. | 
 **end** | **datetime**| The appointment&#39;s end date &amp; time. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_restore**
> appointment_restore(id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to restore.

    try:
        # Restore an appointment
        api_instance.appointment_restore(id)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_restore: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_restoreanyway**
> appointment_restoreanyway(id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to restore.

    try:
        # Restore an appointment even if it breaks activated rules
        api_instance.appointment_restoreanyway(id)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_restoreanyway: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_save**
> appointment_save(id, unknown_base_type=unknown_base_type)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to save (leave empty to create a new one).
unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Schedule an appointment
        api_instance.appointment_save(id, unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_save: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_setasvalid**
> appointment_setasvalid(id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to set as valid.

    try:
        # Schedule an appointment even if it breaks activated rules
        api_instance.appointment_setasvalid(id)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_setasvalid: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to set as valid. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_suggestlocations**
> appointment_suggestlocations()

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    
    try:
        # View the locations with most appointments
        api_instance.appointment_suggestlocations()
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_suggestlocations: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_suggestservices**
> appointment_suggestservices()

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    
    try:
        # View the services with most appointments
        api_instance.appointment_suggestservices()
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_suggestservices: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_void**
> appointment_void(id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.AppointmentApi(api_client)
    id = 'id_example' # str | The id of the appointment to cancel.

    try:
        # Void an appointment
        api_instance.appointment_void(id)
    except ApiException as e:
        print("Exception when calling AppointmentApi->appointment_void: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

