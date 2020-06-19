# openapi_client.SessionregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

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


# **sessionreg_addcurrentuser**
> sessionreg_addcurrentuser(eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

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
    api_instance = openapi_client.SessionregApi(api_client)
    eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Register current user to an event session
        api_instance.sessionreg_addcurrentuser(eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_addcurrentuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

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

# **sessionreg_adduser**
> sessionreg_adduser(userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

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
    api_instance = openapi_client.SessionregApi(api_client)
    userid = 'userid_example' # str | The id of the user to add.
eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Register users for events
        api_instance.sessionreg_adduser(userid, eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_adduser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to add. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

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

# **sessionreg_getmysessions**
> sessionreg_getmysessions(date=date)

View all the sessions the logged user is registered to

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
    api_instance = openapi_client.SessionregApi(api_client)
    date = '2013-10-20T19:20:30+01:00' # datetime | Start date to filter the sessions. (optional)

    try:
        # View all the sessions the logged user is registered to
        api_instance.sessionreg_getmysessions(date=date)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_getmysessions: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **datetime**| Start date to filter the sessions. | [optional] 

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

# **sessionreg_getsessions**
> sessionreg_getsessions(userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

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
    api_instance = openapi_client.SessionregApi(api_client)
    userid = 'userid_example' # str | The user id to list sessions.

    try:
        # Lists the registrations for a specific user
        api_instance.sessionreg_getsessions(userid)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_getsessions: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The user id to list sessions. | 

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

# **sessionreg_getsettings**
> sessionreg_getsettings(locationid=locationid, eventid=eventid, sessiondate=sessiondate, noinherit=noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

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
    api_instance = openapi_client.SessionregApi(api_client)
    locationid = 'locationid_example' # str | The id of the location to save settings. (optional)
eventid = 'eventid_example' # str | The id of the event to save settings. (optional)
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts. (optional)
noinherit = True # bool | True to get the location/event/session specific settings without looking for the more global settings. (optional)

    try:
        # Get the settings for session registration
        api_instance.sessionreg_getsettings(locationid=locationid, eventid=eventid, sessiondate=sessiondate, noinherit=noinherit)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_getsettings: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**str**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**str**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **datetime**| The date and time when the session starts. | [optional] 
 **noinherit** | **bool**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

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

# **sessionreg_getusers**
> sessionreg_getusers(eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

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
    api_instance = openapi_client.SessionregApi(api_client)
    eventid = 'eventid_example' # str | The event id to list sessions.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date of the session to find.

    try:
        # Lists the registrations for a specific session
        api_instance.sessionreg_getusers(eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_getusers: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The event id to list sessions. | 
 **sessiondate** | **datetime**| The date of the session to find. | 

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

# **sessionreg_listsessions**
> sessionreg_listsessions(eventid, sessiondate=sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

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
    api_instance = openapi_client.SessionregApi(api_client)
    eventid = 'eventid_example' # str | The event id to list sessions.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date of the session to find. (optional)

    try:
        # List the sessions available for a specific event
        api_instance.sessionreg_listsessions(eventid, sessiondate=sessiondate)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_listsessions: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The event id to list sessions. | 
 **sessiondate** | **datetime**| The date of the session to find. | [optional] 

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

# **sessionreg_listupcoming**
> sessionreg_listupcoming(date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

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
    api_instance = openapi_client.SessionregApi(api_client)
    date = '2013-10-20T19:20:30+01:00' # datetime | Only sessions in the week of the specified date will be returned.

    try:
        # View a list of upcoming event sessions
        api_instance.sessionreg_listupcoming(date)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_listupcoming: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **datetime**| Only sessions in the week of the specified date will be returned. | 

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

# **sessionreg_listupcomingevent**
> sessionreg_listupcomingevent(date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

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
    api_instance = openapi_client.SessionregApi(api_client)
    date = '2013-10-20T19:20:30+01:00' # datetime | Start date to filter the returned sessions.
event = 'event_example' # str | The id of the event whose sessions will be returned

    try:
        # View a list of upcoming sessions of a particular event
        api_instance.sessionreg_listupcomingevent(date, event)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_listupcomingevent: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **datetime**| Start date to filter the returned sessions. | 
 **event** | [**str**](.md)| The id of the event whose sessions will be returned | 

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

# **sessionreg_removecurrentuser**
> sessionreg_removecurrentuser(eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

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
    api_instance = openapi_client.SessionregApi(api_client)
    eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Unregister current user from an event session
        api_instance.sessionreg_removecurrentuser(eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_removecurrentuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

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

# **sessionreg_removeuser**
> sessionreg_removeuser(userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

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
    api_instance = openapi_client.SessionregApi(api_client)
    userid = 'userid_example' # str | The id of the user to remove.
eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Removes a user from an event session
        api_instance.sessionreg_removeuser(userid, eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_removeuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to remove. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

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

# **sessionreg_savesettings**
> sessionreg_savesettings(unknown_base_type=unknown_base_type)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

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
    api_instance = openapi_client.SessionregApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save the settings for an event's session registration
        api_instance.sessionreg_savesettings(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling SessionregApi->sessionreg_savesettings: %s\n" % e)
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

