# openapi_client.EasyloginApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**easylogin_addbgimage**](EasyloginApi.md#easylogin_addbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login


# **easylogin_addbgimage**
> easylogin_addbgimage(upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

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
    api_instance = openapi_client.EasyloginApi(api_client)
    upload = 'upload_example' # str | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # str | The original filename, needed to process the file.

    try:
        # Adds background image for the login
        api_instance.easylogin_addbgimage(upload, filename)
    except ApiException as e:
        print("Exception when calling EasyloginApi->easylogin_addbgimage: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **str**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **str**| The original filename, needed to process the file. | 

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

