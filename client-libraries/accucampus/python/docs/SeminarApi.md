# openapi_client.SeminarApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**seminar_delete**](SeminarApi.md#seminar_delete) | **DELETE** /seminar/{id} | Delete an event
[**seminar_get**](SeminarApi.md#seminar_get) | **GET** /seminar/{id} | Search and view details of a event
[**seminar_list**](SeminarApi.md#seminar_list) | **GET** /seminar/list | View a list of events
[**seminar_save**](SeminarApi.md#seminar_save) | **POST** /seminar/{id} | Create or edit a event


# **seminar_delete**
> seminar_delete(id, body=body)

Delete an event

Allows the user to delete an existing event.

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
    api_instance = openapi_client.SeminarApi(api_client)
    id = 'id_example' # str | The id of the seminar to delete.
body = None # object |  (optional)

    try:
        # Delete an event
        api_instance.seminar_delete(id, body=body)
    except ApiException as e:
        print("Exception when calling SeminarApi->seminar_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the seminar to delete. | 
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

# **seminar_get**
> seminar_get(id)

Search and view details of a event

Allows the user to view a event and its details.

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
    api_instance = openapi_client.SeminarApi(api_client)
    id = 'id_example' # str | The id of the seminar to get.

    try:
        # Search and view details of a event
        api_instance.seminar_get(id)
    except ApiException as e:
        print("Exception when calling SeminarApi->seminar_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the seminar to get. | 

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

# **seminar_list**
> seminar_list(_from, count, summaryonly=summaryonly, termid=termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

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
    api_instance = openapi_client.SeminarApi(api_client)
    _from = '_from_example' # str | The first record to return.
count = 'count_example' # str | The max number of records to return.
summaryonly = True # bool | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional)
termid = 'termid_example' # str | Id of the term to list the events. Null to list all events. (optional)

    try:
        # View a list of events
        api_instance.seminar_list(_from, count, summaryonly=summaryonly, termid=termid)
    except ApiException as e:
        print("Exception when calling SeminarApi->seminar_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **str**| The first record to return. | 
 **count** | **str**| The max number of records to return. | 
 **summaryonly** | **bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**str**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

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

# **seminar_save**
> seminar_save(id, unknown_base_type=unknown_base_type)

Create or edit a event

Allows the user to create or edit a event.

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
    api_instance = openapi_client.SeminarApi(api_client)
    id = 'id_example' # str | The id of the event to save (leave empty to create a new one).
unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a event
        api_instance.seminar_save(id, unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling SeminarApi->seminar_save: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the event to save (leave empty to create a new one). | 
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

