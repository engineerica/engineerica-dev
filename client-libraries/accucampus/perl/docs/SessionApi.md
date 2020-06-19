# WWW::OpenAPIClient::SessionApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SessionApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**session_bulkupdate**](SessionApi.md#session_bulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**session_get**](SessionApi.md#session_get) | **GET** /session/{id} | View details of a session
[**session_getschedule**](SessionApi.md#session_getschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**session_list**](SessionApi.md#session_list) | **GET** /session/list | Gets all future sessions of the current semester


# **session_bulkupdate**
> session_bulkupdate(eventid => $eventid, sessions => $sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionApi;
my $api_instance = WWW::OpenAPIClient::SessionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event to bulk update.
my $sessions = "sessions_example"; # string | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

eval { 
    $api_instance->session_bulkupdate(eventid => $eventid, sessions => $sessions);
};
if ($@) {
    warn "Exception when calling SessionApi->session_bulkupdate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event to bulk update. | 
 **sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **session_get**
> session_get(id => $id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionApi;
my $api_instance = WWW::OpenAPIClient::SessionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the session to get.

eval { 
    $api_instance->session_get(id => $id);
};
if ($@) {
    warn "Exception when calling SessionApi->session_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the session to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **session_getschedule**
> session_getschedule(day => $day, attendee => $attendee, location => $location, instructor => $instructor)

Gets the schedule for a location, instructor or attendees

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionApi;
my $api_instance = WWW::OpenAPIClient::SessionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $day = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The day to return. It will also return the whole week for that day.
my $attendee = null; # string | The id of the attendee to get the schedule.
my $location = null; # string | The id of the location to get the schedule.
my $instructor = null; # string | The id of the instructor to get the schedule.

eval { 
    $api_instance->session_getschedule(day => $day, attendee => $attendee, location => $location, instructor => $instructor);
};
if ($@) {
    warn "Exception when calling SessionApi->session_getschedule: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **day** | **DateTime**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**string**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**string**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**string**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **session_list**
> session_list(from => $from, count => $count, startdate => $startdate, enddate => $enddate)

Gets all future sessions of the current semester

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionApi;
my $api_instance = WWW::OpenAPIClient::SessionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date to filter the sessions
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date to filter the sessions.

eval { 
    $api_instance->session_list(from => $from, count => $count, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling SessionApi->session_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **startdate** | **DateTime**| The start date to filter the sessions | [optional] 
 **enddate** | **DateTime**| The end date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

