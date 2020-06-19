# WWW::OpenAPIClient::NotificationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::NotificationApi;
```

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
> notification_delete(id => $id, body => $body)

Delete a notification

Allows the user to delete an existing notification.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the notification to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->notification_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the notification to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_get**
> notification_get(id => $id)

View a notification

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the notification to get.

eval { 
    $api_instance->notification_get(id => $id);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the notification to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_getforstation**
> notification_getforstation(station => $station, user => $user)

Gets all public (in station) notifications for the specific user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->notification_getforstation(station => $station, user => $user);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_getforstation: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_getunreadcount**
> notification_getunreadcount()

Get the number of unread notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->notification_getunreadcount();
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_getunreadcount: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_list**
> notification_list(from => $from, count => $count, recipient => $recipient, status => $status, startdate => $startdate, enddate => $enddate, sentonscreen => $sentonscreen, sentemail => $sentemail, sentsms => $sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $recipient = null; # string | The recipient whose notifications have to be listed.
my $status = 56; # int | The status of the notifications to list. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.
my $sentonscreen = null; # boolean | Specifies whether to list the notifications that were sent on-screen or not.
my $sentemail = null; # boolean | Specifies whether to list the notifications that were sent via e-mail or not.
my $sentsms = null; # boolean | Specifies whether to list the notifications that were sent via sms or not.

eval { 
    $api_instance->notification_list(from => $from, count => $count, recipient => $recipient, status => $status, startdate => $startdate, enddate => $enddate, sentonscreen => $sentonscreen, sentemail => $sentemail, sentsms => $sentsms);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **recipient** | [**string**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **int**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_listmine**
> notification_listmine(from => $from, count => $count, status => $status, startdate => $startdate, enddate => $enddate)

View all the notifications sent to the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $status = 56; # int | Specifies the status of the notifications to list. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.

eval { 
    $api_instance->notification_listmine(from => $from, count => $count, status => $status, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_listmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_markasread**
> notification_markasread(id => $id, status => $status, startdate => $startdate, enddate => $enddate)

Mark a notification as read

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
my $status = 56; # int | Specifies the status to filter the notifications. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.

eval { 
    $api_instance->notification_markasread(id => $id, status => $status, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_markasread: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_markasunread**
> notification_markasunread(id => $id, status => $status, startdate => $startdate, enddate => $enddate)

Mark a notification as unread

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
my $status = 56; # int | Specifies the status to filter the notifications. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.

eval { 
    $api_instance->notification_markasunread(id => $id, status => $status, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_markasunread: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_send**
> notification_send(emailenabled => $emailenabled, onscreenenabled => $onscreenenabled, smsenabled => $smsenabled, title => $title, tousers => $tousers, togroups => $togroups, onscreenbody => $onscreenbody, onscreenclick => $onscreenclick, onscreenurl => $onscreenurl, onscreenclass => $onscreenclass, onscreenduration => $onscreenduration, showonstation => $showonstation, emailfromname => $emailfromname, emailfrom => $emailfrom, emailsubject => $emailsubject, emailbody => $emailbody, textmessagebody => $textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $emailenabled = null; # boolean | Whether send the notification via email.
my $onscreenenabled = null; # boolean | Whether to display the notification on screen.
my $smsenabled = null; # boolean | Whether to send the notification via text message.
my $title = "title_example"; # string | Notification title.
my $tousers = "tousers_example"; # string | Comma-separated Ids of users to send the notification.
my $togroups = "togroups_example"; # string | Comma-separated Ids of user groups to send the notification.
my $onscreenbody = "onscreenbody_example"; # string | Body of the message for on-screen display.
my $onscreenclick = "onscreenclick_example"; # string | What to do when the notification is clicked. Valid values: hide, view, url.
my $onscreenurl = "onscreenurl_example"; # string | Url to redirect the user, if onscreenclick=url.
my $onscreenclass = "onscreenclass_example"; # string | How to display the notification. Valid values: info, success, warning, error
my $onscreenduration = 56; # int | Time in seconds to display the notification.
my $showonstation = 56; # int | Whether to show the notification in the sign-in station.
my $emailfromname = "emailfromname_example"; # string | Name of the email sender.
my $emailfrom = "emailfrom_example"; # string | Reply-to email.
my $emailsubject = "emailsubject_example"; # string | Subject of the email.
my $emailbody = "emailbody_example"; # string | Body of the email.
my $textmessagebody = "textmessagebody_example"; # string | Message for SMS. Max 160 characters.

eval { 
    $api_instance->notification_send(emailenabled => $emailenabled, onscreenenabled => $onscreenenabled, smsenabled => $smsenabled, title => $title, tousers => $tousers, togroups => $togroups, onscreenbody => $onscreenbody, onscreenclick => $onscreenclick, onscreenurl => $onscreenurl, onscreenclass => $onscreenclass, onscreenduration => $onscreenduration, showonstation => $showonstation, emailfromname => $emailfromname, emailfrom => $emailfrom, emailsubject => $emailsubject, emailbody => $emailbody, textmessagebody => $textmessagebody);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_send: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailenabled** | **boolean**| Whether send the notification via email. | 
 **onscreenenabled** | **boolean**| Whether to display the notification on screen. | 
 **smsenabled** | **boolean**| Whether to send the notification via text message. | 
 **title** | **string**| Notification title. | 
 **tousers** | **string**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **string**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **string**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **string**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **string**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **string**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **int**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **int**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **string**| Name of the email sender. | [optional] 
 **emailfrom** | **string**| Reply-to email. | [optional] 
 **emailsubject** | **string**| Subject of the email. | [optional] 
 **emailbody** | **string**| Body of the email. | [optional] 
 **textmessagebody** | **string**| Message for SMS. Max 160 characters. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notification_sendonscreen**
> notification_sendonscreen(notification => $notification)

Send on-screen notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationApi;
my $api_instance = WWW::OpenAPIClient::NotificationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $notification = null; # string | The ID of the notification to send.

eval { 
    $api_instance->notification_sendonscreen(notification => $notification);
};
if ($@) {
    warn "Exception when calling NotificationApi->notification_sendonscreen: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**string**](.md)| The ID of the notification to send. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

