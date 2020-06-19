# WWW::OpenAPIClient::SessionattendancelogApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SessionattendancelogApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionattendancelog_addnote**](SessionattendancelogApi.md#sessionattendancelog_addnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
[**sessionattendancelog_get**](SessionattendancelogApi.md#sessionattendancelog_get) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
[**sessionattendancelog_getuser**](SessionattendancelogApi.md#sessionattendancelog_getuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**sessionattendancelog_list**](SessionattendancelogApi.md#sessionattendancelog_list) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
[**sessionattendancelog_listevent**](SessionattendancelogApi.md#sessionattendancelog_listevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
[**sessionattendancelog_listsummary**](SessionattendancelogApi.md#sessionattendancelog_listsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**sessionattendancelog_mylistsummary**](SessionattendancelogApi.md#sessionattendancelog_mylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
[**sessionattendancelog_save**](SessionattendancelogApi.md#sessionattendancelog_save) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
[**sessionattendancelog_saveswipe**](SessionattendancelogApi.md#sessionattendancelog_saveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe


# **sessionattendancelog_addnote**
> sessionattendancelog_addnote(id => $id, text => $text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the attendance log.
my $text = "text_example"; # string | The text of the note to add.

eval { 
    $api_instance->sessionattendancelog_addnote(id => $id, text => $text);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_addnote: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the attendance log. | 
 **text** | **string**| The text of the note to add. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_get**
> sessionattendancelog_get(id => $id, photosize => $photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the attendance log to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->sessionattendancelog_get(id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the attendance log to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_getuser**
> sessionattendancelog_getuser(attendee => $attendee, eventid => $eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $attendee = null; # string | The id of the attendee to get statistic for.
my $eventid = null; # string | The id of the event whose attendee statistics have to be returned.

eval { 
    $api_instance->sessionattendancelog_getuser(attendee => $attendee, eventid => $eventid);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_getuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**string**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**string**](.md)| The id of the event whose attendee statistics have to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_list**
> sessionattendancelog_list(session => $session, from => $from, count => $count, photosize => $photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $session = null; # string | The id of the session whose attendees logs have to be returned.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->sessionattendancelog_list(session => $session, from => $from, count => $count, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **session** | [**string**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_listevent**
> sessionattendancelog_listevent(eventid => $eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event whose attendance has to be returned.

eval { 
    $api_instance->sessionattendancelog_listevent(eventid => $eventid);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_listevent: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_listsummary**
> sessionattendancelog_listsummary(eventid => $eventid, attendeeid => $attendeeid, groupid => $groupid, start => $start, end => $end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event whose attendance has to be returned.
my $attendeeid = null; # string | The id of the attendee whose attendance has to be returned.
my $groupid = null; # string | The id of the group whose attendance has to be returned.
my $start = "start_example"; # string | The start date to filter (beginning of time by default).
my $end = "end_example"; # string | The end date to filter (today by default).

eval { 
    $api_instance->sessionattendancelog_listsummary(eventid => $eventid, attendeeid => $attendeeid, groupid => $groupid, start => $start, end => $end);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_listsummary: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**string**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**string**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **string**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **string**| The end date to filter (today by default). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_mylistsummary**
> sessionattendancelog_mylistsummary(eventid => $eventid, start => $start, end => $end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event whose attendance has to be returned.
my $start = "start_example"; # string | The start date to filter (beginning of time by default).
my $end = "end_example"; # string | The end date to filter (today by default).

eval { 
    $api_instance->sessionattendancelog_mylistsummary(eventid => $eventid, start => $start, end => $end);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_mylistsummary: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **string**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **string**| The end date to filter (today by default). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_save**
> sessionattendancelog_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the att log to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionattendancelog_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the att log to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelog_saveswipe**
> sessionattendancelog_saveswipe(unknown_base_type => $unknown_base_type)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionattendancelogApi;
my $api_instance = WWW::OpenAPIClient::SessionattendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionattendancelog_saveswipe(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SessionattendancelogApi->sessionattendancelog_saveswipe: $@\n";
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

