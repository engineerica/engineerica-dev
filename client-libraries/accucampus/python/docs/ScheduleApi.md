# openapi_client.ScheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**schedule_delete**](ScheduleApi.md#schedule_delete) | **DELETE** /schedule/delete | Delete a schedule slot
[**schedule_deletemine**](ScheduleApi.md#schedule_deletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**schedule_enable**](ScheduleApi.md#schedule_enable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
[**schedule_enablemine**](ScheduleApi.md#schedule_enablemine) | **GET** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**schedule_findallstaffslots**](ScheduleApi.md#schedule_findallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**schedule_findslots**](ScheduleApi.md#schedule_findslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**schedule_findstaffavail**](ScheduleApi.md#schedule_findstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**schedule_get**](ScheduleApi.md#schedule_get) | **GET** /schedule/get | Search and view details of a specific schedule slot
[**schedule_getmine**](ScheduleApi.md#schedule_getmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
[**schedule_getstaff**](ScheduleApi.md#schedule_getstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
[**schedule_getstaffmine**](ScheduleApi.md#schedule_getstaffmine) | **GET** /schedule/getstaffmine | View current user&#39;s schedule information
[**schedule_myofftimes**](ScheduleApi.md#schedule_myofftimes) | **GET** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**schedule_save**](ScheduleApi.md#schedule_save) | **POST** /schedule/save | Create or edit a schedule slot
[**schedule_savemine**](ScheduleApi.md#schedule_savemine) | **POST** /schedule/savemine | Create or edit a block in current user&#39;s schedule


# **schedule_delete**
> schedule_delete(unknown_base_type=unknown_base_type)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Delete a schedule slot
        api_instance.schedule_delete(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_delete: %s\n" % e)
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

# **schedule_deletemine**
> schedule_deletemine(unknown_base_type=unknown_base_type)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Delete a specific block from a user's own schedule
        api_instance.schedule_deletemine(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_deletemine: %s\n" % e)
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

# **schedule_enable**
> schedule_enable(userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    userid = 'userid_example' # str | The id of the user to enable or disable the schedule.
enable = True # bool | True to enable schedules, false to disable.

    try:
        # Enable or disable the schedule for a specific person
        api_instance.schedule_enable(userid, enable)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_enable: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **bool**| True to enable schedules, false to disable. | 

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

# **schedule_enablemine**
> schedule_enablemine(enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    enable = True # bool | True to enable schedules, false to disable.

    try:
        # Enable or disable current user's schedule
        api_instance.schedule_enablemine(enable)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_enablemine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enable** | **bool**| True to enable schedules, false to disable. | 

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

# **schedule_findallstaffslots**
> schedule_findallstaffslots(starttime, endtime, staffid=staffid, serviceids=serviceids, eventid=eventid, locationid=locationid, staffroleids=staffroleids, availablefor=availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    starttime = '2013-10-20T19:20:30+01:00' # datetime | The start time of the range to look for slots.
endtime = '2013-10-20T19:20:30+01:00' # datetime | The end time of the range to look for slots.
staffid = 'staffid_example' # str | The id of the staff to filter by. (optional)
serviceids = 'serviceids_example' # str | CSV list of the service Ids to filter by. (optional)
eventid = 'eventid_example' # str | The id of the event to filter by. (optional)
locationid = 'locationid_example' # str | The id of the location to filter by. (optional)
staffroleids = 'staffroleids_example' # str | CSV list of the staff member role ids to filter by. (optional)
availablefor = 'availablefor_example' # str | The specific availability type to filter by. (optional)

    try:
        # Search available schedule slots by service, event, date
        api_instance.schedule_findallstaffslots(starttime, endtime, staffid=staffid, serviceids=serviceids, eventid=eventid, locationid=locationid, staffroleids=staffroleids, availablefor=availablefor)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_findallstaffslots: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **datetime**| The start time of the range to look for slots. | 
 **endtime** | **datetime**| The end time of the range to look for slots. | 
 **staffid** | [**str**](.md)| The id of the staff to filter by. | [optional] 
 **serviceids** | **str**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**str**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**str**](.md)| The id of the location to filter by. | [optional] 
 **staffroleids** | **str**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **str**| The specific availability type to filter by. | [optional] 

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

# **schedule_findslots**
> schedule_findslots(staffid, starttime, endtime, serviceids=serviceids, eventid=eventid, locationid=locationid, availablefor=availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    staffid = 'staffid_example' # str | The id of the staff to filter by.
starttime = '2013-10-20T19:20:30+01:00' # datetime | The start time of the range to look for slots.
endtime = '2013-10-20T19:20:30+01:00' # datetime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # str | CSV list of the service Ids to filter by. (optional)
eventid = 'eventid_example' # str | The id of the event to filter by. (optional)
locationid = 'locationid_example' # str | The id of the service to filter by. (optional)
availablefor = 'availablefor_example' # str | The specific availability type to filter by. (optional)

    try:
        # Search available schedule slots by service, event, date and/or staff
        api_instance.schedule_findslots(staffid, starttime, endtime, serviceids=serviceids, eventid=eventid, locationid=locationid, availablefor=availablefor)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_findslots: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**str**](.md)| The id of the staff to filter by. | 
 **starttime** | **datetime**| The start time of the range to look for slots. | 
 **endtime** | **datetime**| The end time of the range to look for slots. | 
 **serviceids** | **str**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**str**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**str**](.md)| The id of the service to filter by. | [optional] 
 **availablefor** | **str**| The specific availability type to filter by. | [optional] 

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

# **schedule_findstaffavail**
> schedule_findstaffavail(starttime, endtime, serviceids=serviceids, eventid=eventid, locationid=locationid, staffroleids=staffroleids, availablefor=availablefor, photosize=photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    starttime = '2013-10-20T19:20:30+01:00' # datetime | The start time of the range to look for slots.
endtime = '2013-10-20T19:20:30+01:00' # datetime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # str | CSV list of the service ids to filter by. (optional)
eventid = 'eventid_example' # str | The id of the event to filter by. (optional)
locationid = 'locationid_example' # str | The id of the service to filter by. (optional)
staffroleids = 'staffroleids_example' # str | CSV list of the staff member role ids to filter by. (optional)
availablefor = 'availablefor_example' # str | Filter slots by a specific availability type. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Search available staff members slots by service, event, and/or date
        api_instance.schedule_findstaffavail(starttime, endtime, serviceids=serviceids, eventid=eventid, locationid=locationid, staffroleids=staffroleids, availablefor=availablefor, photosize=photosize)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_findstaffavail: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **datetime**| The start time of the range to look for slots. | 
 **endtime** | **datetime**| The end time of the range to look for slots. | 
 **serviceids** | **str**| CSV list of the service ids to filter by. | [optional] 
 **eventid** | [**str**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**str**](.md)| The id of the service to filter by. | [optional] 
 **staffroleids** | **str**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **str**| Filter slots by a specific availability type. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

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

# **schedule_get**
> schedule_get(scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    scheduleid = 'scheduleid_example' # str | The id of the schedule.

    try:
        # Search and view details of a specific schedule slot
        api_instance.schedule_get(scheduleid)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**str**](.md)| The id of the schedule. | 

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

# **schedule_getmine**
> schedule_getmine(scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    scheduleid = 'scheduleid_example' # str | The id of the schedule.

    try:
        # View details of a specific schedule block, for current user
        api_instance.schedule_getmine(scheduleid)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_getmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**str**](.md)| The id of the schedule. | 

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

# **schedule_getstaff**
> schedule_getstaff(userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    userid = 'userid_example' # str | The id of the user to get info.

    try:
        # View a list of schedule information of a specified person
        api_instance.schedule_getstaff(userid)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_getstaff: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**str**](.md)| The id of the user to get info. | 

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

# **schedule_getstaffmine**
> schedule_getstaffmine()

View current user's schedule information

Allows the user to view their own schedule.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    
    try:
        # View current user's schedule information
        api_instance.schedule_getstaffmine()
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_getstaffmine: %s\n" % e)
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

# **schedule_myofftimes**
> schedule_myofftimes(includedeleted=includedeleted, onlyupcoming=onlyupcoming, modifiedafter=modifiedafter)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    includedeleted = True # bool | If true the deleted offtimes are also returned. (optional)
onlyupcoming = True # bool | If true then only upcoming offtimes are returned. (optional)
modifiedafter = '2013-10-20T19:20:30+01:00' # datetime | If specified, only offtimes modified after the specified date will be returned. (optional)

    try:
        # View current user's schedule exceptions
        api_instance.schedule_myofftimes(includedeleted=includedeleted, onlyupcoming=onlyupcoming, modifiedafter=modifiedafter)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_myofftimes: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includedeleted** | **bool**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **bool**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **datetime**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

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

# **schedule_save**
> schedule_save(unknown_base_type=unknown_base_type)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a schedule slot
        api_instance.schedule_save(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_save: %s\n" % e)
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

# **schedule_savemine**
> schedule_savemine(unknown_base_type=unknown_base_type)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

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
    api_instance = openapi_client.ScheduleApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a block in current user's schedule
        api_instance.schedule_savemine(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling ScheduleApi->schedule_savemine: %s\n" % e)
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

