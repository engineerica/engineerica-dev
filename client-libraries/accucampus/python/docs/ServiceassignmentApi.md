# openapi_client.ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceassignment_addservice**](ServiceassignmentApi.md#serviceassignment_addservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**serviceassignment_getlocation**](ServiceassignmentApi.md#serviceassignment_getlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**serviceassignment_getservice**](ServiceassignmentApi.md#serviceassignment_getservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**serviceassignment_removeservice**](ServiceassignmentApi.md#serviceassignment_removeservice) | **GET** /serviceassignment/removeservice | Remove a service from a location


# **serviceassignment_addservice**
> serviceassignment_addservice(serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

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
    api_instance = openapi_client.ServiceassignmentApi(api_client)
    serviceid = 'serviceid_example' # str | The id of the service to add.
locationid = 'locationid_example' # str | The id of the location.

    try:
        # Enable a service in a specific location
        api_instance.serviceassignment_addservice(serviceid, locationid)
    except ApiException as e:
        print("Exception when calling ServiceassignmentApi->serviceassignment_addservice: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**str**](.md)| The id of the service to add. | 
 **locationid** | [**str**](.md)| The id of the location. | 

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

# **serviceassignment_getlocation**
> serviceassignment_getlocation(locationid, includegloballyavailable=includegloballyavailable, namefilter=namefilter, count=count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

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
    api_instance = openapi_client.ServiceassignmentApi(api_client)
    locationid = 'locationid_example' # str | The id of the location to get.
includegloballyavailable = True # bool | Specifies whether the services available globally must be returned or not. (optional)
namefilter = True # bool | Filters the name of the services to return. (optional)
count = 56 # int | The max number of services to return. (optional)

    try:
        # View a list of services enabled for a specific location
        api_instance.serviceassignment_getlocation(locationid, includegloballyavailable=includegloballyavailable, namefilter=namefilter, count=count)
    except ApiException as e:
        print("Exception when calling ServiceassignmentApi->serviceassignment_getlocation: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**str**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **bool**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **bool**| Filters the name of the services to return. | [optional] 
 **count** | **int**| The max number of services to return. | [optional] 

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

# **serviceassignment_getservice**
> serviceassignment_getservice(serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

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
    api_instance = openapi_client.ServiceassignmentApi(api_client)
    serviceid = 'serviceid_example' # str | The id of the service to get its locations.

    try:
        # View a list of locations where a service is available
        api_instance.serviceassignment_getservice(serviceid)
    except ApiException as e:
        print("Exception when calling ServiceassignmentApi->serviceassignment_getservice: %s\n" % e)
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

# **serviceassignment_removeservice**
> serviceassignment_removeservice(serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

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
    api_instance = openapi_client.ServiceassignmentApi(api_client)
    serviceid = 'serviceid_example' # str | The id of the service to remove.
locationid = 'locationid_example' # str | The id of the location to remove the service from.

    try:
        # Remove a service from a location
        api_instance.serviceassignment_removeservice(serviceid, locationid)
    except ApiException as e:
        print("Exception when calling ServiceassignmentApi->serviceassignment_removeservice: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**str**](.md)| The id of the service to remove. | 
 **locationid** | [**str**](.md)| The id of the location to remove the service from. | 

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

