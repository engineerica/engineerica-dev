# WWW::OpenAPIClient::EventApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::EventApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**event_checksessions**](EventApi.md#event_checksessions) | **GET** /event/checksessions | Edit an event&#39;s sessions according to their schedule
[**event_delete**](EventApi.md#event_delete) | **DELETE** /event/{id} | Delete a course
[**event_get**](EventApi.md#event_get) | **GET** /event/{id} | Search and view details of a course
[**event_getsessionsbydate**](EventApi.md#event_getsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
[**event_list**](EventApi.md#event_list) | **GET** /event/list | View a list of courses
[**event_listregistered**](EventApi.md#event_listregistered) | **GET** /event/listregistered | View a list of courses I am registered to
[**event_save**](EventApi.md#event_save) | **POST** /event/{id} | Create or edit a course
[**event_searchgroup**](EventApi.md#event_searchgroup) | **GET** /event/searchgroup | Searches for the available event groups


# **event_checksessions**
> event_checksessions(eventid => $eventid, autorepair => $autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event to check.
my $autorepair = null; # boolean | True to automatically fix the invalid sessions.

eval { 
    $api_instance->event_checksessions(eventid => $eventid, autorepair => $autorepair);
};
if ($@) {
    warn "Exception when calling EventApi->event_checksessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event to check. | 
 **autorepair** | **boolean**| True to automatically fix the invalid sessions. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **event_delete**
> event_delete(id => $id, body => $body)

Delete a course

Allows the user to delete an existing course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the event to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->event_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling EventApi->event_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the event to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **event_get**
> event_get(id => $id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the event to get.

eval { 
    $api_instance->event_get(id => $id);
};
if ($@) {
    warn "Exception when calling EventApi->event_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the event to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **event_getsessionsbydate**
> event_getsessionsbydate(location => $location, date => $date, type => $type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $location = null; # string | The location to filter the events.
my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date to filter the events. Today will be used if this parameter is omitted.
my $type = "type_example"; # string | Type of event to list.

eval { 
    $api_instance->event_getsessionsbydate(location => $location, date => $date, type => $type);
};
if ($@) {
    warn "Exception when calling EventApi->event_getsessionsbydate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**string**](.md)| The location to filter the events. | [optional] 
 **date** | **DateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **string**| Type of event to list. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **event_list**
> event_list(from => $from, count => $count, summaryonly => $summaryonly, termid => $termid)

View a list of courses

Allows the user to view the full list of courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = "from_example"; # string | The first record to return.
my $count = "count_example"; # string | The max number of records to return.
my $summaryonly = null; # boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
my $termid = null; # string | Id of the term to list the events. Null to list all events.

eval { 
    $api_instance->event_list(from => $from, count => $count, summaryonly => $summaryonly, termid => $termid);
};
if ($@) {
    warn "Exception when calling EventApi->event_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**string**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **event_listregistered**
> event_listregistered(from => $from, count => $count, summaryonly => $summaryonly, termid => $termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = "from_example"; # string | The first record to return.
my $count = "count_example"; # string | The max number of records to return.
my $summaryonly = null; # boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
my $termid = null; # string | Id of the term to list the events. Null to list all events.

eval { 
    $api_instance->event_listregistered(from => $from, count => $count, summaryonly => $summaryonly, termid => $termid);
};
if ($@) {
    warn "Exception when calling EventApi->event_listregistered: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**string**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **event_save**
> event_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a course

Allows the user to create or edit a course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the event to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->event_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling EventApi->event_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the event to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **event_searchgroup**
> event_searchgroup(query => $query)

Searches for the available event groups

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventApi;
my $api_instance = WWW::OpenAPIClient::EventApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $query = null; # string | Query to search event groups.

eval { 
    $api_instance->event_searchgroup(query => $query);
};
if ($@) {
    warn "Exception when calling EventApi->event_searchgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**string**](.md)| Query to search event groups. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

