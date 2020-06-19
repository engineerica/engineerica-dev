# openapi_client.ReportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**report_list**](ReportApi.md#report_list) | **GET** /report/list | View a list of available reports
[**report_permissionsbyuser**](ReportApi.md#report_permissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**report_prepare**](ReportApi.md#report_prepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**report_query**](ReportApi.md#report_query) | **GET** /report/query | Query and load a specified report


# **report_list**
> report_list()

View a list of available reports

Allows the user to view the complete list of available, canned reports.

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
    api_instance = openapi_client.ReportApi(api_client)
    
    try:
        # View a list of available reports
        api_instance.report_list()
    except ApiException as e:
        print("Exception when calling ReportApi->report_list: %s\n" % e)
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

# **report_permissionsbyuser**
> report_permissionsbyuser(params=params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

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
    api_instance = openapi_client.ReportApi(api_client)
    params = 'params_example' # str | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional)

    try:
        # Permissions by user report
        api_instance.report_permissionsbyuser(params=params)
    except ApiException as e:
        print("Exception when calling ReportApi->report_permissionsbyuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **str**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

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

# **report_prepare**
> report_prepare(reportname, params=params, repformat=repformat, fillgroupid=fillgroupid, groupby=groupby, refreshgroup=refreshgroup, filtertext=filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

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
    api_instance = openapi_client.ReportApi(api_client)
    reportname = 'reportname_example' # str | The name of the report to execute
params = 'params_example' # str | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional)
repformat = 'repformat_example' # str | The format of the resulting report. Json, pdf, csv, ... (optional)
fillgroupid = 'fillgroupid_example' # str | If specified, the result is used to fill the group with the given ID (optional)
groupby = 'groupby_example' # str | How to group the records. In the format 'col1+col2|col3+col4 (optional)
refreshgroup = 'refreshgroup_example' # str | The ID of the group to check (and refresh) before processing the report. (optional)
filtertext = 'filtertext_example' # str | The user friendly text of the applied filters. (optional)

    try:
        # Queries and loads the specified report, in background.
        api_instance.report_prepare(reportname, params=params, repformat=repformat, fillgroupid=fillgroupid, groupby=groupby, refreshgroup=refreshgroup, filtertext=filtertext)
    except ApiException as e:
        print("Exception when calling ReportApi->report_prepare: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **str**| The name of the report to execute | 
 **params** | **str**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **str**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**str**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **str**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**str**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **str**| The user friendly text of the applied filters. | [optional] 

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

# **report_query**
> report_query(reportname, params=params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

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
    api_instance = openapi_client.ReportApi(api_client)
    reportname = 'reportname_example' # str | The name of the report to execute
params = 'params_example' # str | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional)

    try:
        # Query and load a specified report
        api_instance.report_query(reportname, params=params)
    except ApiException as e:
        print("Exception when calling ReportApi->report_query: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **str**| The name of the report to execute | 
 **params** | **str**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

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

