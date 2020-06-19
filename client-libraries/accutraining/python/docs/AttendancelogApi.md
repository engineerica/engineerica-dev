# openapi_client.AttendancelogApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelog_delete**](AttendancelogApi.md#attendancelog_delete) | **DELETE** /attendancelog/{id} | Delete an attendance log
[**attendancelog_get**](AttendancelogApi.md#attendancelog_get) | **GET** /attendancelog/{id} | Search and view details of an attendance log
[**attendancelog_getchangehistory**](AttendancelogApi.md#attendancelog_getchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**attendancelog_list**](AttendancelogApi.md#attendancelog_list) | **GET** /attendancelog/list | View a list of attendance logs
[**attendancelog_listmine**](AttendancelogApi.md#attendancelog_listmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
[**attendancelog_save**](AttendancelogApi.md#attendancelog_save) | **POST** /attendancelog/{id} | Create or edit an attendance log
[**attendancelog_signout**](AttendancelogApi.md#attendancelog_signout) | **GET** /attendancelog/signout | Sign out an attendance log
[**attendancelog_whosin**](AttendancelogApi.md#attendancelog_whosin) | **GET** /attendancelog/whosin | View who&#39;s in a location


# **attendancelog_delete**
> attendancelog_delete(id, body=body)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    id = 'id_example' # str | The id of the attendance log to delete.
body = None # object |  (optional)

    try:
        # Delete an attendance log
        api_instance.attendancelog_delete(id, body=body)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the attendance log to delete. | 
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

# **attendancelog_get**
> attendancelog_get(id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    id = 'id_example' # str | The id of the attendance log to get.

    try:
        # Search and view details of an attendance log
        api_instance.attendancelog_get(id)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the attendance log to get. | 

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

# **attendancelog_getchangehistory**
> attendancelog_getchangehistory(id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    id = 'id_example' # str | The id of the attendance log to get.

    try:
        # Search and view details of an attendance log's swipe history
        api_instance.attendancelog_getchangehistory(id)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_getchangehistory: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the attendance log to get. | 

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

# **attendancelog_list**
> attendancelog_list(_from, count, filter=filter, userid=userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
filter = 'filter_example' # str | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional)
userid = 'userid_example' # str | The user ID of the user to get the logs. (optional)

    try:
        # View a list of attendance logs
        api_instance.attendancelog_list(_from, count, filter=filter, userid=userid)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **filter** | **str**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**str**](.md)| The user ID of the user to get the logs. | [optional] 

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

# **attendancelog_listmine**
> attendancelog_listmine(_from, count, filter=filter)

Gets the attendance logs of the current user

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
filter = 'filter_example' # str | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional)

    try:
        # Gets the attendance logs of the current user
        api_instance.attendancelog_listmine(_from, count, filter=filter)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_listmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **filter** | **str**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

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

# **attendancelog_save**
> attendancelog_save(id, unknown_base_type=unknown_base_type)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    id = 'id_example' # str | The id of the room to save (leave empty to create a new one).
unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit an attendance log
        api_instance.attendancelog_save(id, unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_save: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the room to save (leave empty to create a new one). | 
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

# **attendancelog_signout**
> attendancelog_signout(id=id, location=location, event=event, datetime=datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    id = 'id_example' # str | The id of the attendance log to sign-out. (optional)
location = 'location_example' # str | The id of the location to filter the users to sign out. (optional)
event = 'event_example' # str | The id of the event to filter the users to sign out. (optional)
datetime = '2013-10-20T19:20:30+01:00' # datetime | Specifies the date and time when the specified logs have to be signed out. (optional)

    try:
        # Sign out an attendance log
        api_instance.attendancelog_signout(id=id, location=location, event=event, datetime=datetime)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_signout: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**str**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **event** | [**str**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **datetime**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

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

# **attendancelog_whosin**
> attendancelog_whosin(_from, count, location=location, event=event, sorting=sorting, roles=roles, photosize=photosize, extensions=extensions, export=export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accutraining.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accutraining.net:443/api/v1"
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
    api_instance = openapi_client.AttendancelogApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
location = 'location_example' # str | The id of the location to search for users that are in. (optional)
event = 'event_example' # str | The id of the event to search for users that are in. (optional)
sorting = 'sorting_example' # str | Field to sort by. Either first-name, last-name or sign-in-time. (optional)
roles = 'roles_example' # str | The comma-separated list of ids of the roles to search for users that are in. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)
extensions = 'extensions_example' # str | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]). (optional)
export = True # bool | True to export the results as CSV (optional)

    try:
        # View who's in a location
        api_instance.attendancelog_whosin(_from, count, location=location, event=event, sorting=sorting, roles=roles, photosize=photosize, extensions=extensions, export=export)
    except ApiException as e:
        print("Exception when calling AttendancelogApi->attendancelog_whosin: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **location** | [**str**](.md)| The id of the location to search for users that are in. | [optional] 
 **event** | [**str**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **str**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **str**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **str**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **bool**| True to export the results as CSV | [optional] 

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

