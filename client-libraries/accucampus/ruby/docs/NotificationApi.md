# OpenapiClient::NotificationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

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



## notification_delete

> notification_delete(id, opts)

Delete a notification

Allows the user to delete an existing notification.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
id = 'id_example' # String | The id of the notification to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a notification
  api_instance.notification_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## notification_get

> notification_get(id)

View a notification

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
id = 'id_example' # String | The id of the notification to get.

begin
  #View a notification
  api_instance.notification_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_getforstation

> notification_getforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::NotificationApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.

begin
  #Gets all public (in station) notifications for the specific user
  api_instance.notification_getforstation(station, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_getforstation: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_getunreadcount

> notification_getunreadcount

Get the number of unread notifications

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new

begin
  #Get the number of unread notifications
  api_instance.notification_getunreadcount
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_getunreadcount: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_list

> notification_list(from, count, opts)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  recipient: 'recipient_example', # String | The recipient whose notifications have to be listed.
  status: 56, # Integer | The status of the notifications to list. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The end date of the period to filter the notifications.
  sentonscreen: true, # Boolean | Specifies whether to list the notifications that were sent on-screen or not.
  sentemail: true, # Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
  sentsms: true # Boolean | Specifies whether to list the notifications that were sent via sms or not.
}

begin
  #View a list of all sent notifications
  api_instance.notification_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **recipient** | [**String**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **Integer**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **Boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **Boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **Boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_listmine

> notification_listmine(from, count, opts)

View all the notifications sent to the current user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  status: 56, # Integer | Specifies the status of the notifications to list. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date of the period to filter the notifications.
}

begin
  #View all the notifications sent to the current user
  api_instance.notification_listmine(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_listmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **status** | **Integer**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_markasread

> notification_markasread(opts)

Mark a notification as read

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
opts = {
  id: 'id_example', # String | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
  status: 56, # Integer | Specifies the status to filter the notifications. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date of the period to filter the notifications.
}

begin
  #Mark a notification as read
  api_instance.notification_markasread(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_markasread: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_markasunread

> notification_markasunread(opts)

Mark a notification as unread

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
opts = {
  id: 'id_example', # String | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
  status: 56, # Integer | Specifies the status to filter the notifications. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date of the period to filter the notifications.
}

begin
  #Mark a notification as unread
  api_instance.notification_markasunread(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_markasunread: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_send

> notification_send(emailenabled, onscreenenabled, smsenabled, title, opts)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
emailenabled = true # Boolean | Whether send the notification via email.
onscreenenabled = true # Boolean | Whether to display the notification on screen.
smsenabled = true # Boolean | Whether to send the notification via text message.
title = 'title_example' # String | Notification title.
opts = {
  tousers: 'tousers_example', # String | Comma-separated Ids of users to send the notification.
  togroups: 'togroups_example', # String | Comma-separated Ids of user groups to send the notification.
  onscreenbody: 'onscreenbody_example', # String | Body of the message for on-screen display.
  onscreenclick: 'onscreenclick_example', # String | What to do when the notification is clicked. Valid values: hide, view, url.
  onscreenurl: 'onscreenurl_example', # String | Url to redirect the user, if onscreenclick=url.
  onscreenclass: 'onscreenclass_example', # String | How to display the notification. Valid values: info, success, warning, error
  onscreenduration: 56, # Integer | Time in seconds to display the notification.
  showonstation: 56, # Integer | Whether to show the notification in the sign-in station.
  emailfromname: 'emailfromname_example', # String | Name of the email sender.
  emailfrom: 'emailfrom_example', # String | Reply-to email.
  emailsubject: 'emailsubject_example', # String | Subject of the email.
  emailbody: 'emailbody_example', # String | Body of the email.
  textmessagebody: 'textmessagebody_example' # String | Message for SMS. Max 160 characters.
}

begin
  #Send notifications on screen, via email or text to users
  api_instance.notification_send(emailenabled, onscreenenabled, smsenabled, title, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_send: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailenabled** | **Boolean**| Whether send the notification via email. | 
 **onscreenenabled** | **Boolean**| Whether to display the notification on screen. | 
 **smsenabled** | **Boolean**| Whether to send the notification via text message. | 
 **title** | **String**| Notification title. | 
 **tousers** | **String**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **String**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **String**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **String**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **String**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **String**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **Integer**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **Integer**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **String**| Name of the email sender. | [optional] 
 **emailfrom** | **String**| Reply-to email. | [optional] 
 **emailsubject** | **String**| Subject of the email. | [optional] 
 **emailbody** | **String**| Body of the email. | [optional] 
 **textmessagebody** | **String**| Message for SMS. Max 160 characters. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notification_sendonscreen

> notification_sendonscreen(notification)

Send on-screen notifications

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationApi.new
notification = 'notification_example' # String | The ID of the notification to send.

begin
  #Send on-screen notifications
  api_instance.notification_sendonscreen(notification)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationApi->notification_sendonscreen: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**String**](.md)| The ID of the notification to send. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

