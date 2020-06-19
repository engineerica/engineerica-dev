# openapi_client.NotificationApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notification_delete**](NotificationApi.md#notification_delete) | **DELETE** /notification/{id} | Delete a notification
[**notification_get**](NotificationApi.md#notification_get) | **GET** /notification/{id} | View a notification
[**notification_getforstation**](NotificationApi.md#notification_getforstation) | **GET** /notification/getforstation | Gets all public (in station) notifications for the specific user
[**notification_getunreadcount**](NotificationApi.md#notification_getunreadcount) | **GET** /notification/getunreadcount | Get the number of unread notifications
[**notification_list**](NotificationApi.md#notification_list) | **GET** /notification/list | View a list of all sent notifications
[**notification_listmine**](NotificationApi.md#notification_listmine) | **GET** /notification/listmine | View all the notifications sent to the current user
[**notification_markasread**](NotificationApi.md#notification_markasread) | **GET** /notification/markasread | Mark a notification as read
[**notification_markasunread**](NotificationApi.md#notification_markasunread) | **GET** /notification/markasunread | Mark a notification as unread
[**notification_send**](NotificationApi.md#notification_send) | **GET** /notification/send | Send notifications on screen, via email or text to users
[**notification_sendonscreen**](NotificationApi.md#notification_sendonscreen) | **GET** /notification/sendonscreen | Send on-screen notifications


# **notification_delete**
> notification_delete(id, body=body)

Delete a notification

Allows the user to delete an existing notification.

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
    api_instance = openapi_client.NotificationApi(api_client)
    id = 'id_example' # str | The id of the notification to delete.
body = None # object |  (optional)

    try:
        # Delete a notification
        api_instance.notification_delete(id, body=body)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the notification to delete. | 
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

# **notification_get**
> notification_get(id)

View a notification

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
    api_instance = openapi_client.NotificationApi(api_client)
    id = 'id_example' # str | The id of the notification to get.

    try:
        # View a notification
        api_instance.notification_get(id)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the notification to get. | 

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

# **notification_getforstation**
> notification_getforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example

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


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.NotificationApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
user = 'user_example' # str | The card of the user.

    try:
        # Gets all public (in station) notifications for the specific user
        api_instance.notification_getforstation(station, user)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_getforstation: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **user** | **str**| The card of the user. | 

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

# **notification_getunreadcount**
> notification_getunreadcount()

Get the number of unread notifications

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
    api_instance = openapi_client.NotificationApi(api_client)
    
    try:
        # Get the number of unread notifications
        api_instance.notification_getunreadcount()
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_getunreadcount: %s\n" % e)
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

# **notification_list**
> notification_list(_from, count, recipient=recipient, status=status, startdate=startdate, enddate=enddate, sentonscreen=sentonscreen, sentemail=sentemail, sentsms=sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

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
    api_instance = openapi_client.NotificationApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
recipient = 'recipient_example' # str | The recipient whose notifications have to be listed. (optional)
status = 56 # int | The status of the notifications to list. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)
sentonscreen = True # bool | Specifies whether to list the notifications that were sent on-screen or not. (optional)
sentemail = True # bool | Specifies whether to list the notifications that were sent via e-mail or not. (optional)
sentsms = True # bool | Specifies whether to list the notifications that were sent via sms or not. (optional)

    try:
        # View a list of all sent notifications
        api_instance.notification_list(_from, count, recipient=recipient, status=status, startdate=startdate, enddate=enddate, sentonscreen=sentonscreen, sentemail=sentemail, sentsms=sentsms)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **recipient** | [**str**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **int**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **bool**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **bool**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **bool**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

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

# **notification_listmine**
> notification_listmine(_from, count, status=status, startdate=startdate, enddate=enddate)

View all the notifications sent to the current user

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
    api_instance = openapi_client.NotificationApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
status = 56 # int | Specifies the status of the notifications to list. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)

    try:
        # View all the notifications sent to the current user
        api_instance.notification_listmine(_from, count, status=status, startdate=startdate, enddate=enddate)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_listmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 

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

# **notification_markasread**
> notification_markasread(id=id, status=status, startdate=startdate, enddate=enddate)

Mark a notification as read

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
    api_instance = openapi_client.NotificationApi(api_client)
    id = 'id_example' # str | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. (optional)
status = 56 # int | Specifies the status to filter the notifications. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)

    try:
        # Mark a notification as read
        api_instance.notification_markasread(id=id, status=status, startdate=startdate, enddate=enddate)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_markasread: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 

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

# **notification_markasunread**
> notification_markasunread(id=id, status=status, startdate=startdate, enddate=enddate)

Mark a notification as unread

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
    api_instance = openapi_client.NotificationApi(api_client)
    id = 'id_example' # str | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. (optional)
status = 56 # int | Specifies the status to filter the notifications. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)

    try:
        # Mark a notification as unread
        api_instance.notification_markasunread(id=id, status=status, startdate=startdate, enddate=enddate)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_markasunread: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 

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

# **notification_send**
> notification_send(emailenabled, onscreenenabled, smsenabled, title, tousers=tousers, togroups=togroups, onscreenbody=onscreenbody, onscreenclick=onscreenclick, onscreenurl=onscreenurl, onscreenclass=onscreenclass, onscreenduration=onscreenduration, showonstation=showonstation, emailfromname=emailfromname, emailfrom=emailfrom, emailsubject=emailsubject, emailbody=emailbody, textmessagebody=textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

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
    api_instance = openapi_client.NotificationApi(api_client)
    emailenabled = True # bool | Whether send the notification via email.
onscreenenabled = True # bool | Whether to display the notification on screen.
smsenabled = True # bool | Whether to send the notification via text message.
title = 'title_example' # str | Notification title.
tousers = 'tousers_example' # str | Comma-separated Ids of users to send the notification. (optional)
togroups = 'togroups_example' # str | Comma-separated Ids of user groups to send the notification. (optional)
onscreenbody = 'onscreenbody_example' # str | Body of the message for on-screen display. (optional)
onscreenclick = 'onscreenclick_example' # str | What to do when the notification is clicked. Valid values: hide, view, url. (optional)
onscreenurl = 'onscreenurl_example' # str | Url to redirect the user, if onscreenclick=url. (optional)
onscreenclass = 'onscreenclass_example' # str | How to display the notification. Valid values: info, success, warning, error (optional)
onscreenduration = 56 # int | Time in seconds to display the notification. (optional)
showonstation = 56 # int | Whether to show the notification in the sign-in station. (optional)
emailfromname = 'emailfromname_example' # str | Name of the email sender. (optional)
emailfrom = 'emailfrom_example' # str | Reply-to email. (optional)
emailsubject = 'emailsubject_example' # str | Subject of the email. (optional)
emailbody = 'emailbody_example' # str | Body of the email. (optional)
textmessagebody = 'textmessagebody_example' # str | Message for SMS. Max 160 characters. (optional)

    try:
        # Send notifications on screen, via email or text to users
        api_instance.notification_send(emailenabled, onscreenenabled, smsenabled, title, tousers=tousers, togroups=togroups, onscreenbody=onscreenbody, onscreenclick=onscreenclick, onscreenurl=onscreenurl, onscreenclass=onscreenclass, onscreenduration=onscreenduration, showonstation=showonstation, emailfromname=emailfromname, emailfrom=emailfrom, emailsubject=emailsubject, emailbody=emailbody, textmessagebody=textmessagebody)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_send: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailenabled** | **bool**| Whether send the notification via email. | 
 **onscreenenabled** | **bool**| Whether to display the notification on screen. | 
 **smsenabled** | **bool**| Whether to send the notification via text message. | 
 **title** | **str**| Notification title. | 
 **tousers** | **str**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **str**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **str**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **str**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **str**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **str**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **int**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **int**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **str**| Name of the email sender. | [optional] 
 **emailfrom** | **str**| Reply-to email. | [optional] 
 **emailsubject** | **str**| Subject of the email. | [optional] 
 **emailbody** | **str**| Body of the email. | [optional] 
 **textmessagebody** | **str**| Message for SMS. Max 160 characters. | [optional] 

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

# **notification_sendonscreen**
> notification_sendonscreen(notification)

Send on-screen notifications

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
    api_instance = openapi_client.NotificationApi(api_client)
    notification = 'notification_example' # str | The ID of the notification to send.

    try:
        # Send on-screen notifications
        api_instance.notification_sendonscreen(notification)
    except ApiException as e:
        print("Exception when calling NotificationApi->notification_sendonscreen: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**str**](.md)| The ID of the notification to send. | 

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

