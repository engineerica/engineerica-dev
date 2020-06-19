# openapi_client.AttendancelogcommentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogcomment_delete**](AttendancelogcommentApi.md#attendancelogcomment_delete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**attendancelogcomment_get**](AttendancelogcommentApi.md#attendancelogcomment_get) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
[**attendancelogcomment_list**](AttendancelogcommentApi.md#attendancelogcomment_list) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
[**attendancelogcomment_save**](AttendancelogcommentApi.md#attendancelogcomment_save) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log


# **attendancelogcomment_delete**
> attendancelogcomment_delete(id, body=body)

Delete a comment on an attendance log

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
    api_instance = openapi_client.AttendancelogcommentApi(api_client)
    id = 'id_example' # str | The id of the attendance log comment to delete.
body = None # object |  (optional)

    try:
        # Delete a comment on an attendance log
        api_instance.attendancelogcomment_delete(id, body=body)
    except ApiException as e:
        print("Exception when calling AttendancelogcommentApi->attendancelogcomment_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the attendance log comment to delete. | 
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

# **attendancelogcomment_get**
> attendancelogcomment_get(id)

View a comment on an attendance log

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
    api_instance = openapi_client.AttendancelogcommentApi(api_client)
    id = 'id_example' # str | The id of the comment to get.

    try:
        # View a comment on an attendance log
        api_instance.attendancelogcomment_get(id)
    except ApiException as e:
        print("Exception when calling AttendancelogcommentApi->attendancelogcomment_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the comment to get. | 

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

# **attendancelogcomment_list**
> attendancelogcomment_list(attendancelog)

View all the comments on a specific attendance log

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
    api_instance = openapi_client.AttendancelogcommentApi(api_client)
    attendancelog = 'attendancelog_example' # str | The id of the attendance log whose comments have to be retrieved.

    try:
        # View all the comments on a specific attendance log
        api_instance.attendancelogcomment_list(attendancelog)
    except ApiException as e:
        print("Exception when calling AttendancelogcommentApi->attendancelogcomment_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**str**](.md)| The id of the attendance log whose comments have to be retrieved. | 

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

# **attendancelogcomment_save**
> attendancelogcomment_save(id, unknown_base_type=unknown_base_type)

Save a comment on an attendance log

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
    api_instance = openapi_client.AttendancelogcommentApi(api_client)
    id = 'id_example' # str | The id of the comment to edit (leave empty to create a new one)
unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save a comment on an attendance log
        api_instance.attendancelogcomment_save(id, unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling AttendancelogcommentApi->attendancelogcomment_save: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the comment to edit (leave empty to create a new one) | 
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

