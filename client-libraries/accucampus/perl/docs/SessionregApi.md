# WWW::OpenAPIClient::SessionregApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SessionregApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionreg_addcurrentuser**](SessionregApi.md#sessionreg_addcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
[**sessionreg_adduser**](SessionregApi.md#sessionreg_adduser) | **GET** /sessionreg/adduser | Register users for events
[**sessionreg_getmysessions**](SessionregApi.md#sessionreg_getmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
[**sessionreg_getsessions**](SessionregApi.md#sessionreg_getsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
[**sessionreg_getsettings**](SessionregApi.md#sessionreg_getsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
[**sessionreg_getusers**](SessionregApi.md#sessionreg_getusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
[**sessionreg_listsessions**](SessionregApi.md#sessionreg_listsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
[**sessionreg_listupcoming**](SessionregApi.md#sessionreg_listupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
[**sessionreg_listupcomingevent**](SessionregApi.md#sessionreg_listupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
[**sessionreg_removecurrentuser**](SessionregApi.md#sessionreg_removecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
[**sessionreg_removeuser**](SessionregApi.md#sessionreg_removeuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
[**sessionreg_savesettings**](SessionregApi.md#sessionreg_savesettings) | **POST** /sessionreg/savesettings | Save the settings for an event&#39;s session registration


# **sessionreg_addcurrentuser**
> sessionreg_addcurrentuser(eventid => $eventid, sessiondate => $sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionreg_addcurrentuser(eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_addcurrentuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_adduser**
> sessionreg_adduser(userid => $userid, eventid => $eventid, sessiondate => $sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to add.
my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionreg_adduser(userid => $userid, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_adduser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to add. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_getmysessions**
> sessionreg_getmysessions(date => $date)

View all the sessions the logged user is registered to

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Start date to filter the sessions.

eval { 
    $api_instance->sessionreg_getmysessions(date => $date);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_getmysessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime**| Start date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_getsessions**
> sessionreg_getsessions(userid => $userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The user id to list sessions.

eval { 
    $api_instance->sessionreg_getsessions(userid => $userid);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_getsessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The user id to list sessions. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_getsettings**
> sessionreg_getsettings(locationid => $locationid, eventid => $eventid, sessiondate => $sessiondate, noinherit => $noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $locationid = null; # string | The id of the location to save settings.
my $eventid = null; # string | The id of the event to save settings.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.
my $noinherit = null; # boolean | True to get the location/event/session specific settings without looking for the more global settings.

eval { 
    $api_instance->sessionreg_getsettings(locationid => $locationid, eventid => $eventid, sessiondate => $sessiondate, noinherit => $noinherit);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_getsettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**string**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**string**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **DateTime**| The date and time when the session starts. | [optional] 
 **noinherit** | **boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_getusers**
> sessionreg_getusers(eventid => $eventid, sessiondate => $sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The event id to list sessions.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date of the session to find.

eval { 
    $api_instance->sessionreg_getusers(eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_getusers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_listsessions**
> sessionreg_listsessions(eventid => $eventid, sessiondate => $sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The event id to list sessions.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date of the session to find.

eval { 
    $api_instance->sessionreg_listsessions(eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_listsessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_listupcoming**
> sessionreg_listupcoming(date => $date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Only sessions in the week of the specified date will be returned.

eval { 
    $api_instance->sessionreg_listupcoming(date => $date);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_listupcoming: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime**| Only sessions in the week of the specified date will be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_listupcomingevent**
> sessionreg_listupcomingevent(date => $date, event => $event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Start date to filter the returned sessions.
my $event = null; # string | The id of the event whose sessions will be returned

eval { 
    $api_instance->sessionreg_listupcomingevent(date => $date, event => $event);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_listupcomingevent: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime**| Start date to filter the returned sessions. | 
 **event** | [**string**](.md)| The id of the event whose sessions will be returned | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_removecurrentuser**
> sessionreg_removecurrentuser(eventid => $eventid, sessiondate => $sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionreg_removecurrentuser(eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_removecurrentuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_removeuser**
> sessionreg_removeuser(userid => $userid, eventid => $eventid, sessiondate => $sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to remove.
my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionreg_removeuser(userid => $userid, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_removeuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreg_savesettings**
> sessionreg_savesettings(unknown_base_type => $unknown_base_type)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionregApi;
my $api_instance = WWW::OpenAPIClient::SessionregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionreg_savesettings(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SessionregApi->sessionreg_savesettings: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

