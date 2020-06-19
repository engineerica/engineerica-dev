# \NotificationApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotificationDelete**](NotificationApi.md#NotificationDelete) | **Delete** /notification/{id} | Delete a notification
[**NotificationGet**](NotificationApi.md#NotificationGet) | **Get** /notification/{id} | View a notification
[**NotificationGetforstation**](NotificationApi.md#NotificationGetforstation) | **Get** /notification/getforstation | Gets all public (in station) notifications for the specific user
[**NotificationGetunreadcount**](NotificationApi.md#NotificationGetunreadcount) | **Get** /notification/getunreadcount | Get the number of unread notifications
[**NotificationList**](NotificationApi.md#NotificationList) | **Get** /notification/list | View a list of all sent notifications
[**NotificationListmine**](NotificationApi.md#NotificationListmine) | **Get** /notification/listmine | View all the notifications sent to the current user
[**NotificationMarkasread**](NotificationApi.md#NotificationMarkasread) | **Get** /notification/markasread | Mark a notification as read
[**NotificationMarkasunread**](NotificationApi.md#NotificationMarkasunread) | **Get** /notification/markasunread | Mark a notification as unread
[**NotificationSend**](NotificationApi.md#NotificationSend) | **Get** /notification/send | Send notifications on screen, via email or text to users
[**NotificationSendonscreen**](NotificationApi.md#NotificationSendonscreen) | **Get** /notification/sendonscreen | Send on-screen notifications



## NotificationDelete

> NotificationDelete(ctx, id, optional)

Delete a notification

Allows the user to delete an existing notification.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the notification to delete. | 
 **optional** | ***NotificationDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationDeleteOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **body** | **optional.Interface{}**|  | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationGet

> NotificationGet(ctx, id)

View a notification

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the notification to get. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationGetforstation

> NotificationGetforstation(ctx, station, user)

Gets all public (in station) notifications for the specific user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationGetunreadcount

> NotificationGetunreadcount(ctx, )

Get the number of unread notifications

### Required Parameters

This endpoint does not need any parameter.

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationList

> NotificationList(ctx, from, count, optional)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***NotificationListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **recipient** | [**optional.Interface of string**](.md)| The recipient whose notifications have to be listed. | 
 **status** | **optional.Int32**| The status of the notifications to list. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 
 **sentonscreen** | **optional.Bool**| Specifies whether to list the notifications that were sent on-screen or not. | 
 **sentemail** | **optional.Bool**| Specifies whether to list the notifications that were sent via e-mail or not. | 
 **sentsms** | **optional.Bool**| Specifies whether to list the notifications that were sent via sms or not. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationListmine

> NotificationListmine(ctx, from, count, optional)

View all the notifications sent to the current user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***NotificationListmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationListmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **status** | **optional.Int32**| Specifies the status of the notifications to list. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationMarkasread

> NotificationMarkasread(ctx, optional)

Mark a notification as read

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***NotificationMarkasreadOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationMarkasreadOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**optional.Interface of string**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | 
 **status** | **optional.Int32**| Specifies the status to filter the notifications. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationMarkasunread

> NotificationMarkasunread(ctx, optional)

Mark a notification as unread

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***NotificationMarkasunreadOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationMarkasunreadOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**optional.Interface of string**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | 
 **status** | **optional.Int32**| Specifies the status to filter the notifications. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationSend

> NotificationSend(ctx, emailenabled, onscreenenabled, smsenabled, title, optional)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**emailenabled** | **bool**| Whether send the notification via email. | 
**onscreenenabled** | **bool**| Whether to display the notification on screen. | 
**smsenabled** | **bool**| Whether to send the notification via text message. | 
**title** | **string**| Notification title. | 
 **optional** | ***NotificationSendOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationSendOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **tousers** | **optional.String**| Comma-separated Ids of users to send the notification. | 
 **togroups** | **optional.String**| Comma-separated Ids of user groups to send the notification. | 
 **onscreenbody** | **optional.String**| Body of the message for on-screen display. | 
 **onscreenclick** | **optional.String**| What to do when the notification is clicked. Valid values: hide, view, url. | 
 **onscreenurl** | **optional.String**| Url to redirect the user, if onscreenclick&#x3D;url. | 
 **onscreenclass** | **optional.String**| How to display the notification. Valid values: info, success, warning, error | 
 **onscreenduration** | **optional.Int32**| Time in seconds to display the notification. | 
 **showonstation** | **optional.Int32**| Whether to show the notification in the sign-in station. | 
 **emailfromname** | **optional.String**| Name of the email sender. | 
 **emailfrom** | **optional.String**| Reply-to email. | 
 **emailsubject** | **optional.String**| Subject of the email. | 
 **emailbody** | **optional.String**| Body of the email. | 
 **textmessagebody** | **optional.String**| Message for SMS. Max 160 characters. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotificationSendonscreen

> NotificationSendonscreen(ctx, notification)

Send on-screen notifications

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**notification** | [**string**](.md)| The ID of the notification to send. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

