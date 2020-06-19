# openapi_client.AdvancedstationApi

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


# **advancedstation_checkunknownuser**
> advancedstation_checkunknownuser(station, user, location)

Check whether the user is known by the system.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
user = 'user_example' # str | The card of the user.
location = 'location_example' # str | The id of the location the user picked.

    try:
        # Check whether the user is known by the system.
        api_instance.advancedstation_checkunknownuser(station, user, location)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_checkunknownuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **user** | **str**| The card of the user. | 
 **location** | [**str**](.md)| The id of the location the user picked. | 

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

# **advancedstation_checkuserrole**
> advancedstation_checkuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
user = 'user_example' # str | The card of the user.
location = 'location_example' # str | The id of the location the user picked.

    try:
        # Check whether the user is a staff member, an attendee or both.
        api_instance.advancedstation_checkuserrole(station, user, location)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_checkuserrole: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **user** | **str**| The card of the user. | 
 **location** | [**str**](.md)| The id of the location the user picked. | 

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

# **advancedstation_createuser**
> advancedstation_createuser(station, user, location, firstname, lastname, email, middlename=middlename)

Creates a user via a sign-in station.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
user = 'user_example' # str | The card of the user to create.
location = 'location_example' # str | The id of the location the user picked.
firstname = 'firstname_example' # str | The first name of the user to create.
lastname = 'lastname_example' # str | The last name of the user to create.
email = 'email_example' # str | The email of the user to create.
middlename = 'middlename_example' # str | The middle name of the user to create. (optional)

    try:
        # Creates a user via a sign-in station.
        api_instance.advancedstation_createuser(station, user, location, firstname, lastname, email, middlename=middlename)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_createuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **user** | **str**| The card of the user to create. | 
 **location** | [**str**](.md)| The id of the location the user picked. | 
 **firstname** | **str**| The first name of the user to create. | 
 **lastname** | **str**| The last name of the user to create. | 
 **email** | **str**| The email of the user to create. | 
 **middlename** | **str**| The middle name of the user to create. | [optional] 

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

# **advancedstation_getevents**
> advancedstation_getevents(station, location, user)

Gets the courses available for a specific location and a specific student.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
location = 'location_example' # str | The id of the location the student picked.
user = 'user_example' # str | The card of the user.

    try:
        # Gets the courses available for a specific location and a specific student.
        api_instance.advancedstation_getevents(station, location, user)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_getevents: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **location** | [**str**](.md)| The id of the location the student picked. | 
 **user** | **str**| The card of the user. | 

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

# **advancedstation_getinfo**
> advancedstation_getinfo(id, event=event)

Gets the info to display in the sign-in station by it's ID.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    id = 'id_example' # str | The id of the sign-in station to get.
event = 'event_example' # str | The id of the event (or session), to override the scheduled one. (optional)

    try:
        # Gets the info to display in the sign-in station by it's ID.
        api_instance.advancedstation_getinfo(id, event=event)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_getinfo: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the sign-in station to get. | 
 **event** | [**str**](.md)| The id of the event (or session), to override the scheduled one. | [optional] 

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

# **advancedstation_getlocations**
> advancedstation_getlocations(station, user)

Gets the locations available in a sign-in station.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station whose locations have to be returned.
user = 'user_example' # str | The card of the user.

    try:
        # Gets the locations available in a sign-in station.
        api_instance.advancedstation_getlocations(station, user)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_getlocations: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station whose locations have to be returned. | 
 **user** | **str**| The card of the user. | 

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

# **advancedstation_getlogstaff**
> advancedstation_getlogstaff(station, attendancelog, photosize=photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
attendancelog = 'attendancelog_example' # str | The id of the attendance log to filter the staff members.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
        api_instance.advancedstation_getlogstaff(station, attendancelog, photosize=photosize)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_getlogstaff: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **attendancelog** | [**str**](.md)| The id of the attendance log to filter the staff members. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

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

# **advancedstation_getroles**
> advancedstation_getroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
signinrole = 'signinrole_example' # str | Specifies how the user is signing-in.
user = 'user_example' # str | The card of the user.
location = 'location_example' # str | The id of the location the user picked.

    try:
        # Gets the user roles of the user trying to sign-in.
        api_instance.advancedstation_getroles(station, signinrole, user, location)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_getroles: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **signinrole** | **str**| Specifies how the user is signing-in. | 
 **user** | **str**| The card of the user. | 
 **location** | [**str**](.md)| The id of the location the user picked. | 

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

# **advancedstation_getservices**
> advancedstation_getservices(station, location, user)

Gets the services available for a specific location.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
location = 'location_example' # str | The id of the location the student picked.
user = 'user_example' # str | The card of the user.

    try:
        # Gets the services available for a specific location.
        api_instance.advancedstation_getservices(station, location, user)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_getservices: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **location** | [**str**](.md)| The id of the location the student picked. | 
 **user** | **str**| The card of the user. | 

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

# **advancedstation_getstaff**
> advancedstation_getstaff(station, locationid, user, services=services, eventid=eventid, photosize=photosize)

Gets the staff/tutors available for a specific location, course and service.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
locationid = 'locationid_example' # str | The id of the location the student picked.
user = 'user_example' # str | The card of the user.
services = 'services_example' # str | The list of services selected by the user, in JSON format. (optional)
eventid = 'eventid_example' # str | The ID of the event selected. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Gets the staff/tutors available for a specific location, course and service.
        api_instance.advancedstation_getstaff(station, locationid, user, services=services, eventid=eventid, photosize=photosize)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_getstaff: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **locationid** | [**str**](.md)| The id of the location the student picked. | 
 **user** | **str**| The card of the user. | 
 **services** | **str**| The list of services selected by the user, in JSON format. | [optional] 
 **eventid** | [**str**](.md)| The ID of the event selected. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

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

# **advancedstation_issignedin**
> advancedstation_issignedin(station, time, user, location=location)

Gets whether a user is signed-in or not.

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
    api_instance = openapi_client.AdvancedstationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
time = '2013-10-20T19:20:30+01:00' # datetime | The date and time of the swipe.
user = 'user_example' # str | The card of the user.
location = 'location_example' # str | The id of the location the user picked. (optional)

    try:
        # Gets whether a user is signed-in or not.
        api_instance.advancedstation_issignedin(station, time, user, location=location)
    except ApiException as e:
        print("Exception when calling AdvancedstationApi->advancedstation_issignedin: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **time** | **datetime**| The date and time of the swipe. | 
 **user** | **str**| The card of the user. | 
 **location** | [**str**](.md)| The id of the location the user picked. | [optional] 

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

