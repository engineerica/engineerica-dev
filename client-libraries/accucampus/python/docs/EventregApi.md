# openapi_client.EventregApi

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


# **eventreg_addme**
> eventreg_addme(eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

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
    api_instance = openapi_client.EventregApi(api_client)
    eventid = 'eventid_example' # str | The id of the event.
listname = 'listname_example' # str | The name of the list where the user has to be registered.

    try:
        # Register current user to a course
        api_instance.eventreg_addme(eventid, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_addme: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event. | 
 **listname** | **str**| The name of the list where the user has to be registered. | 

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

# **eventreg_addmetoall**
> eventreg_addmetoall(listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

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
    api_instance = openapi_client.EventregApi(api_client)
    listname = 'listname_example' # str | The name of the list where the user has to be registered.

    try:
        # Register current user to all courses
        api_instance.eventreg_addmetoall(listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_addmetoall: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **str**| The name of the list where the user has to be registered. | 

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

# **eventreg_addmetogroup**
> eventreg_addmetogroup(codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

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
    api_instance = openapi_client.EventregApi(api_client)
    codegroup = 'codegroup_example' # str | The code used to group events.
listname = 'listname_example' # str | The name of the list where the user has to be registered.

    try:
        # Register current user to a course group
        api_instance.eventreg_addmetogroup(codegroup, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_addmetogroup: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | **str**| The code used to group events. | 
 **listname** | **str**| The name of the list where the user has to be registered. | 

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

# **eventreg_adduser**
> eventreg_adduser(userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The id of the user to add.
eventid = 'eventid_example' # str | The id of the event.
listname = 'listname_example' # str | The name of the list where the user has to be registered.

    try:
        # Register a user to a course for attendance
        api_instance.eventreg_adduser(userid, eventid, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_adduser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to add. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **listname** | **str**| The name of the list where the user has to be registered. | 

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

# **eventreg_addusertoall**
> eventreg_addusertoall(userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The id of the user to add.
listname = 'listname_example' # str | The name of the list where the user has to be registered.

    try:
        # Register a user to assist with all courses
        api_instance.eventreg_addusertoall(userid, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_addusertoall: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to add. | 
 **listname** | **str**| The name of the list where the user has to be registered. | 

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

# **eventreg_addusertogroup**
> eventreg_addusertogroup(userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The id of the user to add.
codegroup = 'codegroup_example' # str | The code used to group events.
listname = 'listname_example' # str | The name of the list where the user has to be registered.

    try:
        # Register a user to an course group
        api_instance.eventreg_addusertogroup(userid, codegroup, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_addusertogroup: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to add. | 
 **codegroup** | **str**| The code used to group events. | 
 **listname** | **str**| The name of the list where the user has to be registered. | 

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

# **eventreg_getevents**
> eventreg_getevents(userid, listname, termid=termid, namefilter=namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The user id to list events.
listname = 'listname_example' # str | The name of the list where the user is registered.
termid = 'termid_example' # str | The term id to list events. (optional)
namefilter = 'namefilter_example' # str | The value used to filter the events by name. (optional)

    try:
        # View course registration by user
        api_instance.eventreg_getevents(userid, listname, termid=termid, namefilter=namefilter)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_getevents: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The user id to list events. | 
 **listname** | **str**| The name of the list where the user is registered. | 
 **termid** | [**str**](.md)| The term id to list events. | [optional] 
 **namefilter** | **str**| The value used to filter the events by name. | [optional] 

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

# **eventreg_getgroups**
> eventreg_getgroups(userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The user id to list events.
listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # Lists the course group registrations of a user
        api_instance.eventreg_getgroups(userid, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_getgroups: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The user id to list events. | 
 **listname** | **str**| The name of the list where the user is registered. | 

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

# **eventreg_getmyevents**
> eventreg_getmyevents(listname, termid=termid, namefilter=namefilter)

View the event registrations of the current user

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
    api_instance = openapi_client.EventregApi(api_client)
    listname = 'listname_example' # str | The name of the list where the user is registered.
termid = 'termid_example' # str | The term id to list events. (optional)
namefilter = 'namefilter_example' # str | The value used to filter the events by name. (optional)

    try:
        # View the event registrations of the current user
        api_instance.eventreg_getmyevents(listname, termid=termid, namefilter=namefilter)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_getmyevents: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **str**| The name of the list where the user is registered. | 
 **termid** | [**str**](.md)| The term id to list events. | [optional] 
 **namefilter** | **str**| The value used to filter the events by name. | [optional] 

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

# **eventreg_getmygroups**
> eventreg_getmygroups(listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

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
    api_instance = openapi_client.EventregApi(api_client)
    listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # View all current user registrations to course groups
        api_instance.eventreg_getmygroups(listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_getmygroups: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **str**| The name of the list where the user is registered. | 

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

# **eventreg_getusers**
> eventreg_getusers(eventid, listname, photosize=photosize)

View course registration

Allows the user to view all users registered for an individual course.

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
    api_instance = openapi_client.EventregApi(api_client)
    eventid = 'eventid_example' # str | The event id to list users.
listname = 'listname_example' # str | The name of the list to get.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # View course registration
        api_instance.eventreg_getusers(eventid, listname, photosize=photosize)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_getusers: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The event id to list users. | 
 **listname** | **str**| The name of the list to get. | 
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

# **eventreg_getusersfromgroup**
> eventreg_getusersfromgroup(codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

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
    api_instance = openapi_client.EventregApi(api_client)
    codegroup = 'codegroup_example' # str | The code group to list users.
listname = 'listname_example' # str | The name of the list to get.

    try:
        # Lists the registrations for a course group
        api_instance.eventreg_getusersfromgroup(codegroup, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_getusersfromgroup: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**str**](.md)| The code group to list users. | 
 **listname** | **str**| The name of the list to get. | 

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

# **eventreg_getuserstoall**
> eventreg_getuserstoall(listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

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
    api_instance = openapi_client.EventregApi(api_client)
    listname = 'listname_example' # str | The name of the list to get.

    try:
        # View the users that are registered to all courses
        api_instance.eventreg_getuserstoall(listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_getuserstoall: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **str**| The name of the list to get. | 

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

# **eventreg_removeme**
> eventreg_removeme(eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

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
    api_instance = openapi_client.EventregApi(api_client)
    eventid = 'eventid_example' # str | The id of the event.
listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # Unregister current user from a course
        api_instance.eventreg_removeme(eventid, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_removeme: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**str**](.md)| The id of the event. | 
 **listname** | **str**| The name of the list where the user is registered. | 

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

# **eventreg_removemefromall**
> eventreg_removemefromall(listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

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
    api_instance = openapi_client.EventregApi(api_client)
    listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # Remove current user from the registration to all courses
        api_instance.eventreg_removemefromall(listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_removemefromall: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **str**| The name of the list where the user is registered. | 

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

# **eventreg_removemefromgroup**
> eventreg_removemefromgroup(codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

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
    api_instance = openapi_client.EventregApi(api_client)
    codegroup = 'codegroup_example' # str | The code group of the events/courses.
listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # Remove current user from a course group
        api_instance.eventreg_removemefromgroup(codegroup, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_removemefromgroup: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**str**](.md)| The code group of the events/courses. | 
 **listname** | **str**| The name of the list where the user is registered. | 

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

# **eventreg_removeuser**
> eventreg_removeuser(userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The id of the user to remove.
eventid = 'eventid_example' # str | The id of the event.
listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # Remove a user from a course
        api_instance.eventreg_removeuser(userid, eventid, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_removeuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to remove. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **listname** | **str**| The name of the list where the user is registered. | 

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

# **eventreg_removeuserfromall**
> eventreg_removeuserfromall(userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The id of the user to remove.
listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # Remove a user from the registration to all courses
        api_instance.eventreg_removeuserfromall(userid, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_removeuserfromall: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to remove. | 
 **listname** | **str**| The name of the list where the user is registered. | 

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

# **eventreg_removeuserfromgroup**
> eventreg_removeuserfromgroup(userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

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
    api_instance = openapi_client.EventregApi(api_client)
    userid = 'userid_example' # str | The id of the user to remove.
codegroup = 'codegroup_example' # str | The code group of the events/courses.
listname = 'listname_example' # str | The name of the list where the user is registered.

    try:
        # Remove a user from a course group
        api_instance.eventreg_removeuserfromgroup(userid, codegroup, listname)
    except ApiException as e:
        print("Exception when calling EventregApi->eventreg_removeuserfromgroup: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to remove. | 
 **codegroup** | [**str**](.md)| The code group of the events/courses. | 
 **listname** | **str**| The name of the list where the user is registered. | 

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

