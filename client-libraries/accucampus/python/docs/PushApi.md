# openapi_client.PushApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**push_deregister**](PushApi.md#push_deregister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
[**push_register**](PushApi.md#push_register) | **GET** /push/register | Registers the current device to receive push notifications


# **push_deregister**
> push_deregister(devicetoken, platform)

Deregisters the current device to receive push notifications

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
    api_instance = openapi_client.PushApi(api_client)
    devicetoken = 'devicetoken_example' # str | The device token where to send the notification.
platform = 'platform_example' # str | Either ios or android

    try:
        # Deregisters the current device to receive push notifications
        api_instance.push_deregister(devicetoken, platform)
    except ApiException as e:
        print("Exception when calling PushApi->push_deregister: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **str**| The device token where to send the notification. | 
 **platform** | **str**| Either ios or android | 

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

# **push_register**
> push_register(devicetoken, platform)

Registers the current device to receive push notifications

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
    api_instance = openapi_client.PushApi(api_client)
    devicetoken = 'devicetoken_example' # str | The device token where to send the notification.
platform = 'platform_example' # str | Either ios or android

    try:
        # Registers the current device to receive push notifications
        api_instance.push_register(devicetoken, platform)
    except ApiException as e:
        print("Exception when calling PushApi->push_register: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **str**| The device token where to send the notification. | 
 **platform** | **str**| Either ios or android | 

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

