# openapi_client.ActionlogApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionlog_list**](ActionlogApi.md#actionlog_list) | **GET** /actionlog/list | View a list of users action logs


# **actionlog_list**
> actionlog_list(_from, count, user=user, startdate=startdate, enddate=enddate, resource=resource, actionfilter=actionfilter, argument=argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

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
    api_instance = openapi_client.ActionlogApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
user = 'user_example' # str | The id of the user whose action logs have to be returned. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the logs. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the logs. (optional)
resource = 'resource_example' # str | The resource to filter the action logs. (optional)
actionfilter = 'actionfilter_example' # str | The action to filter the action logs. (optional)
argument = 'argument_example' # str | The id of the entity that was the argument of the executed action. (optional)

    try:
        # View a list of users action logs
        api_instance.actionlog_list(_from, count, user=user, startdate=startdate, enddate=enddate, resource=resource, actionfilter=actionfilter, argument=argument)
    except ApiException as e:
        print("Exception when calling ActionlogApi->actionlog_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **user** | [**str**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the logs. | [optional] 
 **resource** | **str**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **str**| The action to filter the action logs. | [optional] 
 **argument** | **str**| The id of the entity that was the argument of the executed action. | [optional] 

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

