# openapi_client.CaptchaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**captcha_getchallenge**](CaptchaApi.md#captcha_getchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captcha_getimage**](CaptchaApi.md#captcha_getimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.


# **captcha_getchallenge**
> captcha_getchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

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
    api_instance = openapi_client.CaptchaApi(api_client)
    
    try:
        # Gets a captcha challenge that the user must complete to do certain requests.
        api_instance.captcha_getchallenge()
    except ApiException as e:
        print("Exception when calling CaptchaApi->captcha_getchallenge: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

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

# **captcha_getimage**
> captcha_getimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

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
    api_instance = openapi_client.CaptchaApi(api_client)
    captchatoken = 'captchatoken_example' # str | The captcha token or ID returned by the captcha.getchallenge action

    try:
        # Gets a captcha image that the user must complete to do certain requests.
        api_instance.captcha_getimage(captchatoken)
    except ApiException as e:
        print("Exception when calling CaptchaApi->captcha_getimage: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **str**| The captcha token or ID returned by the captcha.getchallenge action | 

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

