# openapi_client.ActionassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionassignment_delete**](ActionassignmentApi.md#actionassignment_delete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
[**actionassignment_get**](ActionassignmentApi.md#actionassignment_get) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**actionassignment_list**](ActionassignmentApi.md#actionassignment_list) | **GET** /actionassignment/list | View a list of action items in a user&#39;s plan
[**actionassignment_listhistory**](ActionassignmentApi.md#actionassignment_listhistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
[**actionassignment_listmine**](ActionassignmentApi.md#actionassignment_listmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
[**actionassignment_listpublichistory**](ActionassignmentApi.md#actionassignment_listpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
[**actionassignment_markcomplete**](ActionassignmentApi.md#actionassignment_markcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
[**actionassignment_save**](ActionassignmentApi.md#actionassignment_save) | **POST** /actionassignment/save | Add an action item to a user&#39;s action plan
[**actionassignment_savehistory**](ActionassignmentApi.md#actionassignment_savehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user


# **actionassignment_delete**
> actionassignment_delete(id, body=body)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    id = 'id_example' # str | The id of the action assignment to delete.
body = None # object |  (optional)

    try:
        # Remove an action item from an action plan
        api_instance.actionassignment_delete(id, body=body)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the action assignment to delete. | 
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

# **actionassignment_get**
> actionassignment_get(id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    id = 'id_example' # str | The id of the action assignment to get.

    try:
        # Search and view details of an action item assigned to a user
        api_instance.actionassignment_get(id)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the action assignment to get. | 

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

# **actionassignment_list**
> actionassignment_list(_from, count, assignee=assignee, status=status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
assignee = 56 # int | The assignee's id to filter the assignments. (optional)
status = 56 # int | The status to filter the assignments. (optional)

    try:
        # View a list of action items in a user's plan
        api_instance.actionassignment_list(_from, count, assignee=assignee, status=status)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **assignee** | **int**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **int**| The status to filter the assignments. | [optional] 

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

# **actionassignment_listhistory**
> actionassignment_listhistory(actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    actionassignment = 'actionassignment_example' # str | The action assignment's id whose history the user wants to get.

    try:
        # View the history of an action item assigned to a user
        api_instance.actionassignment_listhistory(actionassignment)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_listhistory: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**str**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

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

# **actionassignment_listmine**
> actionassignment_listmine(_from, count, status=status)

List public action assignments assigned to the logged user

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
status = 56 # int | The status to filter the assignments. (optional)

    try:
        # List public action assignments assigned to the logged user
        api_instance.actionassignment_listmine(_from, count, status=status)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_listmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| The status to filter the assignments. | [optional] 

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

# **actionassignment_listpublichistory**
> actionassignment_listpublichistory(actionassignment)

List public action assignment history

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    actionassignment = 'actionassignment_example' # str | The action assignment's id whose history the user wants to get.

    try:
        # List public action assignment history
        api_instance.actionassignment_listpublichistory(actionassignment)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_listpublichistory: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**str**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

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

# **actionassignment_markcomplete**
> actionassignment_markcomplete(item, assignee=assignee, group=group, notes=notes)

Bulk complete action items

Allows the user to bulk complete action items.

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    item = 'item_example' # str | The action item to assign.
assignee = 'assignee_example' # str | The assignee of the item. (optional)
group = 'group_example' # str | The group to assing the item. (optional)
notes = 'notes_example' # str | The assignment's notes. (optional)

    try:
        # Bulk complete action items
        api_instance.actionassignment_markcomplete(item, assignee=assignee, group=group, notes=notes)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_markcomplete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | **str**| The action item to assign. | 
 **assignee** | [**str**](.md)| The assignee of the item. | [optional] 
 **group** | [**str**](.md)| The group to assing the item. | [optional] 
 **notes** | **str**| The assignment&#39;s notes. | [optional] 

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

# **actionassignment_save**
> actionassignment_save(unknown_base_type=unknown_base_type)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Add an action item to a user's action plan
        api_instance.actionassignment_save(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_save: %s\n" % e)
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

# **actionassignment_savehistory**
> actionassignment_savehistory(unknown_base_type=unknown_base_type)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

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
    api_instance = openapi_client.ActionassignmentApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Update an action item assigned to a user
        api_instance.actionassignment_savehistory(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ActionassignmentApi->actionassignment_savehistory: %s\n" % e)
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

