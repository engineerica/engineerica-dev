# openapi_client.WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**waitingline_adduser**](WaitinglineApi.md#waitingline_adduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**waitingline_delete**](WaitinglineApi.md#waitingline_delete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**waitingline_get**](WaitinglineApi.md#waitingline_get) | **GET** /waitingline/{id} | View details of a waiting line
[**waitingline_isuserin**](WaitinglineApi.md#waitingline_isuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitingline_list**](WaitinglineApi.md#waitingline_list) | **GET** /waitingline/list | View a list of waiting lines
[**waitingline_removeuser**](WaitinglineApi.md#waitingline_removeuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**waitingline_save**](WaitinglineApi.md#waitingline_save) | **POST** /waitingline/{id} | Create or edit a waiting line
[**waitingline_signinuser**](WaitinglineApi.md#waitingline_signinuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line


# **waitingline_adduser**
> waitingline_adduser(station, user, locationid=locationid, time=time, signinrole=signinrole, roleid=roleid, services=services, eventid=eventid, staff=staff, photosize=photosize)

Put user in a waiting line

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    station = 'station_example' # str | The id of the sign-in station.
user = 'user_example' # str | The user's card number.
locationid = 'locationid_example' # str | The location's id where the swipe must be saved. (optional)
time = '2013-10-20T19:20:30+01:00' # datetime | The date and time of the swipe. (optional)
signinrole = 'signinrole_example' # str | Specifies if the sign-in is for an attendee or a staff member (optional)
roleid = 'roleid_example' # str | Specifies the role the user has selected in order to sign-in (optional)
services = 'services_example' # str | The services ids the user has selected. (optional)
eventid = 'eventid_example' # str | The id of the event the user selected. (optional)
staff = 'staff_example' # str | The id of the staff member the user selected. (optional)
photosize = 56 # int | The swiping user's photo size. (optional)

    try:
        # Put user in a waiting line
        api_instance.waitingline_adduser(station, user, locationid=locationid, time=time, signinrole=signinrole, roleid=roleid, services=services, eventid=eventid, staff=staff, photosize=photosize)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_adduser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station. | 
 **user** | **str**| The user&#39;s card number. | 
 **locationid** | [**str**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **datetime**| The date and time of the swipe. | [optional] 
 **signinrole** | **str**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**str**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **str**| The services ids the user has selected. | [optional] 
 **eventid** | [**str**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**str**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional] 

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

# **waitingline_delete**
> waitingline_delete(id, body=body)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    id = 'id_example' # str | The id of the line to delete.
body = None # object |  (optional)

    try:
        # Delete a waiting line
        api_instance.waitingline_delete(id, body=body)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the line to delete. | 
 **body** | **object**|  | [optional] 

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

# **waitingline_get**
> waitingline_get(id, photosize=photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    id = 'id_example' # str | The id of the waiting line to get.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # View details of a waiting line
        api_instance.waitingline_get(id, photosize=photosize)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the waiting line to get. | 
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

# **waitingline_isuserin**
> waitingline_isuserin(station, time, user, location=location)

Check whether a user is in a waiting line, signed-in or is not in the area

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    station = 'station_example' # str | The id of the sign-in station.
time = '2013-10-20T19:20:30+01:00' # datetime | The date and time of the swipe.
user = 'user_example' # str | The card number of the user.
location = 'location_example' # str | The id of the location the user picked. (optional)

    try:
        # Check whether a user is in a waiting line, signed-in or is not in the area
        api_instance.waitingline_isuserin(station, time, user, location=location)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_isuserin: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station. | 
 **time** | **datetime**| The date and time of the swipe. | 
 **user** | **str**| The card number of the user. | 
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

# **waitingline_list**
> waitingline_list(_from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of waiting lines
        api_instance.waitingline_list(_from, count)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

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

# **waitingline_removeuser**
> waitingline_removeuser(waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    waitingline = 'waitingline_example' # str | The id of the waiting line whose item has to be removed.
itemid = 'itemid_example' # str | The ID of the item that has to be removed.

    try:
        # Remove a user from a waiting line
        api_instance.waitingline_removeuser(waitingline, itemid)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_removeuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**str**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**str**](.md)| The ID of the item that has to be removed. | 

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

# **waitingline_save**
> waitingline_save(id, unknown_base_type=unknown_base_type)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    id = 'id_example' # str | The id of the waiting line save (leave empty to create a new one).
unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a waiting line
        api_instance.waitingline_save(id, unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_save: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the waiting line save (leave empty to create a new one). | 
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

# **waitingline_signinuser**
> waitingline_signinuser(waitingline, itemid, staff, photosize=photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

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
    api_instance = openapi_client.WaitinglineApi(api_client)
    waitingline = 'waitingline_example' # str | The id of the waiting line whose item needs to be signed-in.
itemid = 'itemid_example' # str | The ID of the item that has to be signed-in.
staff = 'staff_example' # str | The id of the staff member selected to sign-in.
photosize = 56 # int | The swiping user's photo size. (optional)

    try:
        # Sign a user in from a waiting line
        api_instance.waitingline_signinuser(waitingline, itemid, staff, photosize=photosize)
    except ApiException as e:
        print("Exception when calling WaitinglineApi->waitingline_signinuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**str**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**str**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**str**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional] 

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

