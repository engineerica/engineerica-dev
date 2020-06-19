# openapi_client.ScheduleintegrationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleintegration_clearids**](ScheduleintegrationApi.md#scheduleintegration_clearids) | **GET** /scheduleintegration/clearids | Clear all third party IDs from specified staff member&#39;s schedule items.
[**scheduleintegration_deleteitem**](ScheduleintegrationApi.md#scheduleintegration_deleteitem) | **DELETE** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
[**scheduleintegration_deleteitemsbymasterid**](ScheduleintegrationApi.md#scheduleintegration_deleteitemsbymasterid) | **DELETE** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**scheduleintegration_getitem**](ScheduleintegrationApi.md#scheduleintegration_getitem) | **GET** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
[**scheduleintegration_saveitem**](ScheduleintegrationApi.md#scheduleintegration_saveitem) | **POST** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
[**scheduleintegration_setid**](ScheduleintegrationApi.md#scheduleintegration_setid) | **GET** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item


# **scheduleintegration_clearids**
> scheduleintegration_clearids(staff)

Clear all third party IDs from specified staff member's schedule items.

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
    api_instance = openapi_client.ScheduleintegrationApi(api_client)
    staff = 'staff_example' # str | The ID of the staff member whose schedule items third party IDs must be cleared.

    try:
        # Clear all third party IDs from specified staff member's schedule items.
        api_instance.scheduleintegration_clearids(staff)
    except ApiException as e:
        print("Exception when calling ScheduleintegrationApi->scheduleintegration_clearids: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staff** | [**str**](.md)| The ID of the staff member whose schedule items third party IDs must be cleared. | 

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

# **scheduleintegration_deleteitem**
> scheduleintegration_deleteitem(unknown_base_type=unknown_base_type)

Delete a schedule item looking up by a third party ID

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
    api_instance = openapi_client.ScheduleintegrationApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Delete a schedule item looking up by a third party ID
        api_instance.scheduleintegration_deleteitem(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ScheduleintegrationApi->scheduleintegration_deleteitem: %s\n" % e)
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

# **scheduleintegration_deleteitemsbymasterid**
> scheduleintegration_deleteitemsbymasterid(unknown_base_type=unknown_base_type)

Delete multiple schedule items looking up by a third party master ID

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
    api_instance = openapi_client.ScheduleintegrationApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Delete multiple schedule items looking up by a third party master ID
        api_instance.scheduleintegration_deleteitemsbymasterid(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ScheduleintegrationApi->scheduleintegration_deleteitemsbymasterid: %s\n" % e)
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

# **scheduleintegration_getitem**
> scheduleintegration_getitem(thirdpartyid)

Get a schedule item looking up by a third party ID

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
    api_instance = openapi_client.ScheduleintegrationApi(api_client)
    thirdpartyid = 'thirdpartyid_example' # str | The third party id to search for the schedule item.

    try:
        # Get a schedule item looking up by a third party ID
        api_instance.scheduleintegration_getitem(thirdpartyid)
    except ApiException as e:
        print("Exception when calling ScheduleintegrationApi->scheduleintegration_getitem: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdpartyid** | **str**| The third party id to search for the schedule item. | 

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

# **scheduleintegration_saveitem**
> scheduleintegration_saveitem(unknown_base_type=unknown_base_type)

Save a schedule item looking up by a third party ID

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
    api_instance = openapi_client.ScheduleintegrationApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save a schedule item looking up by a third party ID
        api_instance.scheduleintegration_saveitem(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ScheduleintegrationApi->scheduleintegration_saveitem: %s\n" % e)
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

# **scheduleintegration_setid**
> scheduleintegration_setid(id, thirdpartyid, thirdpartymasterid=thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

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
    api_instance = openapi_client.ScheduleintegrationApi(api_client)
    id = 'id_example' # str | The id of the schedule block / appointment.
thirdpartyid = 'thirdpartyid_example' # str | The 3rd party ID to set.
thirdpartymasterid = 'thirdpartymasterid_example' # str | The 3rd party master ID to set (useful to handle recurring items). (optional)

    try:
        # Set a 3rd party ID on a specific schedule item
        api_instance.scheduleintegration_setid(id, thirdpartyid, thirdpartymasterid=thirdpartymasterid)
    except ApiException as e:
        print("Exception when calling ScheduleintegrationApi->scheduleintegration_setid: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the schedule block / appointment. | 
 **thirdpartyid** | **str**| The 3rd party ID to set. | 
 **thirdpartymasterid** | **str**| The 3rd party master ID to set (useful to handle recurring items). | [optional] 

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

