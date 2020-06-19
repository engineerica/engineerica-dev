# openapi_client.LicenseApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**license_acceptagreement**](LicenseApi.md#license_acceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**license_getagreementstatus**](LicenseApi.md#license_getagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**license_getcurrent**](LicenseApi.md#license_getcurrent) | **GET** /license/getcurrent | Gets the current license information
[**license_renew**](LicenseApi.md#license_renew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuClub subscription


# **license_acceptagreement**
> license_acceptagreement()

Accept the license agreement

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
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
    api_instance = openapi_client.LicenseApi(api_client)
    
    try:
        # Accept the license agreement
        api_instance.license_acceptagreement()
    except ApiException as e:
        print("Exception when calling LicenseApi->license_acceptagreement: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

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

# **license_getagreementstatus**
> license_getagreementstatus()

Check if license agreement has been accepted

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
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
    api_instance = openapi_client.LicenseApi(api_client)
    
    try:
        # Check if license agreement has been accepted
        api_instance.license_getagreementstatus()
    except ApiException as e:
        print("Exception when calling LicenseApi->license_getagreementstatus: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

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

# **license_getcurrent**
> license_getcurrent()

Gets the current license information

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
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
    api_instance = openapi_client.LicenseApi(api_client)
    
    try:
        # Gets the current license information
        api_instance.license_getcurrent()
    except ApiException as e:
        print("Exception when calling LicenseApi->license_getcurrent: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

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

# **license_renew**
> license_renew(email, phonenumber, jobtitle=jobtitle, institution=institution, comments=comments)

Contact Engineerica in order to renew the AccuClub subscription

Allows the user to select the option to contact Engineerica when the AccuClub account is nearing its renewal date.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
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
    api_instance = openapi_client.LicenseApi(api_client)
    email = 'email_example' # str | The e-mail of the user sending the request.
phonenumber = 'phonenumber_example' # str | The phone number of the user sending the request.
jobtitle = 'jobtitle_example' # str | The job title of the user sending the request. (optional)
institution = 'institution_example' # str | The institution of the user sending the request. (optional)
comments = 'comments_example' # str | Comments entered by the user sending the request. (optional)

    try:
        # Contact Engineerica in order to renew the AccuClub subscription
        api_instance.license_renew(email, phonenumber, jobtitle=jobtitle, institution=institution, comments=comments)
    except ApiException as e:
        print("Exception when calling LicenseApi->license_renew: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **str**| The e-mail of the user sending the request. | 
 **phonenumber** | **str**| The phone number of the user sending the request. | 
 **jobtitle** | **str**| The job title of the user sending the request. | [optional] 
 **institution** | **str**| The institution of the user sending the request. | [optional] 
 **comments** | **str**| Comments entered by the user sending the request. | [optional] 

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

