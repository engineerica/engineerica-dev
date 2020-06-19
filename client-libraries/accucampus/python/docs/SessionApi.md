# openapi_client.SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**session_bulkupdate**](SessionApi.md#session_bulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**session_get**](SessionApi.md#session_get) | **GET** /session/{id} | View details of a session
[**session_getschedule**](SessionApi.md#session_getschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**session_list**](SessionApi.md#session_list) | **GET** /session/list | Gets all future sessions of the current semester


# **session_bulkupdate**
> session_bulkupdate(eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

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
    api_instance = openapi_client.SessionApi(api_client)
    eventid = 'eventid_example' # str | The id of the event to bulk update.
sessions = 'sessions_example' # str | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

    try:
        # Bulk update event sessions
        api_instance.session_bulkupdate(eventid, sessions)
    except ApiException as e:
        print("Exception when calling SessionApi->session_bulkupdate: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event to bulk update. | 
 **sessions** | **str**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

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

# **session_get**
> session_get(id)

View details of a session

Allows the user to view a session in order to take attendance.

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
    api_instance = openapi_client.SessionApi(api_client)
    id = 'id_example' # str | The id of the session to get.

    try:
        # View details of a session
        api_instance.session_get(id)
    except ApiException as e:
        print("Exception when calling SessionApi->session_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the session to get. | 

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

# **session_getschedule**
> session_getschedule(day=day, attendee=attendee, location=location, instructor=instructor)

Gets the schedule for a location, instructor or attendees

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
    api_instance = openapi_client.SessionApi(api_client)
    day = '2013-10-20T19:20:30+01:00' # datetime | The day to return. It will also return the whole week for that day. (optional)
attendee = 'attendee_example' # str | The id of the attendee to get the schedule. (optional)
location = 'location_example' # str | The id of the location to get the schedule. (optional)
instructor = 'instructor_example' # str | The id of the instructor to get the schedule. (optional)

    try:
        # Gets the schedule for a location, instructor or attendees
        api_instance.session_getschedule(day=day, attendee=attendee, location=location, instructor=instructor)
    except ApiException as e:
        print("Exception when calling SessionApi->session_getschedule: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **day** | **datetime**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**str**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**str**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**str**](.md)| The id of the instructor to get the schedule. | [optional] 

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

# **session_list**
> session_list(_from, count, startdate=startdate, enddate=enddate)

Gets all future sessions of the current semester

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
    api_instance = openapi_client.SessionApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date to filter the sessions (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date to filter the sessions. (optional)

    try:
        # Gets all future sessions of the current semester
        api_instance.session_list(_from, count, startdate=startdate, enddate=enddate)
    except ApiException as e:
        print("Exception when calling SessionApi->session_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **startdate** | **datetime**| The start date to filter the sessions | [optional] 
 **enddate** | **datetime**| The end date to filter the sessions. | [optional] 

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

