# openapi_client.SessionattendancelogApi

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


# **sessionattendancelog_addnote**
> sessionattendancelog_addnote(id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    id = 'id_example' # str | The id of the attendance log.
text = 'text_example' # str | The text of the note to add.

    try:
        # Add a note to a class attendance log
        api_instance.sessionattendancelog_addnote(id, text)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_addnote: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the attendance log. | 
 **text** | **str**| The text of the note to add. | 

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

# **sessionattendancelog_get**
> sessionattendancelog_get(id, photosize=photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    id = 'id_example' # str | The id of the attendance log to get.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # View details of a class attendance log
        api_instance.sessionattendancelog_get(id, photosize=photosize)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the attendance log to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

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

# **sessionattendancelog_getuser**
> sessionattendancelog_getuser(attendee, eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    attendee = 'attendee_example' # str | The id of the attendee to get statistic for.
eventid = 'eventid_example' # str | The id of the event whose attendee statistics have to be returned.

    try:
        # View the class session attendance information for a specific user
        api_instance.sessionattendancelog_getuser(attendee, eventid)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_getuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**str**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**str**](.md)| The id of the event whose attendee statistics have to be returned. | 

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

# **sessionattendancelog_list**
> sessionattendancelog_list(session, _from, count, photosize=photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    session = 'session_example' # str | The id of the session whose attendees logs have to be returned.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # View attendance logs of the specified session
        api_instance.sessionattendancelog_list(session, _from, count, photosize=photosize)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **session** | [**str**](.md)| The id of the session whose attendees logs have to be returned. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
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

# **sessionattendancelog_listevent**
> sessionattendancelog_listevent(eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    eventid = 'eventid_example' # str | The id of the event whose attendance has to be returned.

    try:
        # View the attendance information of an entire class
        api_instance.sessionattendancelog_listevent(eventid)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_listevent: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event whose attendance has to be returned. | 

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

# **sessionattendancelog_listsummary**
> sessionattendancelog_listsummary(eventid=eventid, attendeeid=attendeeid, groupid=groupid, start=start, end=end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    eventid = 'eventid_example' # str | The id of the event whose attendance has to be returned. (optional)
attendeeid = 'attendeeid_example' # str | The id of the attendee whose attendance has to be returned. (optional)
groupid = 'groupid_example' # str | The id of the group whose attendance has to be returned. (optional)
start = 'start_example' # str | The start date to filter (beginning of time by default). (optional)
end = 'end_example' # str | The end date to filter (today by default). (optional)

    try:
        # View the attendance summary for a class and/or a attendee
        api_instance.sessionattendancelog_listsummary(eventid=eventid, attendeeid=attendeeid, groupid=groupid, start=start, end=end)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_listsummary: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**str**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**str**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **str**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **str**| The end date to filter (today by default). | [optional] 

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

# **sessionattendancelog_mylistsummary**
> sessionattendancelog_mylistsummary(eventid=eventid, start=start, end=end)

View my attendance summary

Allows the user to view their own attendance summary.

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    eventid = 'eventid_example' # str | The id of the event whose attendance has to be returned. (optional)
start = 'start_example' # str | The start date to filter (beginning of time by default). (optional)
end = 'end_example' # str | The end date to filter (today by default). (optional)

    try:
        # View my attendance summary
        api_instance.sessionattendancelog_mylistsummary(eventid=eventid, start=start, end=end)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_mylistsummary: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **str**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **str**| The end date to filter (today by default). | [optional] 

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

# **sessionattendancelog_save**
> sessionattendancelog_save(id, unknown_base_type=unknown_base_type)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    id = 'id_example' # str | The id of the att log to save (leave empty to create a new one).
unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a class attendance log
        api_instance.sessionattendancelog_save(id, unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_save: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the att log to save (leave empty to create a new one). | 
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

# **sessionattendancelog_saveswipe**
> sessionattendancelog_saveswipe(unknown_base_type=unknown_base_type)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

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
    api_instance = openapi_client.SessionattendancelogApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a class attendance log swipe
        api_instance.sessionattendancelog_saveswipe(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling SessionattendancelogApi->sessionattendancelog_saveswipe: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

