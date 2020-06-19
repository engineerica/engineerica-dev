# WWW::OpenAPIClient::SeminarApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SeminarApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**seminar_delete**](SeminarApi.md#seminar_delete) | **DELETE** /seminar/{id} | Delete an event
[**seminar_get**](SeminarApi.md#seminar_get) | **GET** /seminar/{id} | Search and view details of a event
[**seminar_list**](SeminarApi.md#seminar_list) | **GET** /seminar/list | View a list of events
[**seminar_save**](SeminarApi.md#seminar_save) | **POST** /seminar/{id} | Create or edit a event


# **seminar_delete**
> seminar_delete(id => $id, body => $body)

Delete an event

Allows the user to delete an existing event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SeminarApi;
my $api_instance = WWW::OpenAPIClient::SeminarApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the seminar to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->seminar_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling SeminarApi->seminar_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the seminar to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **seminar_get**
> seminar_get(id => $id)

Search and view details of a event

Allows the user to view a event and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SeminarApi;
my $api_instance = WWW::OpenAPIClient::SeminarApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the seminar to get.

eval { 
    $api_instance->seminar_get(id => $id);
};
if ($@) {
    warn "Exception when calling SeminarApi->seminar_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the seminar to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **seminar_list**
> seminar_list(from => $from, count => $count, summaryonly => $summaryonly, termid => $termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SeminarApi;
my $api_instance = WWW::OpenAPIClient::SeminarApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = "from_example"; # string | The first record to return.
my $count = "count_example"; # string | The max number of records to return.
my $summaryonly = null; # boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
my $termid = null; # string | Id of the term to list the events. Null to list all events.

eval { 
    $api_instance->seminar_list(from => $from, count => $count, summaryonly => $summaryonly, termid => $termid);
};
if ($@) {
    warn "Exception when calling SeminarApi->seminar_list: $@\n";
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

# **seminar_save**
> seminar_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a event

Allows the user to create or edit a event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SeminarApi;
my $api_instance = WWW::OpenAPIClient::SeminarApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the event to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->seminar_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SeminarApi->seminar_save: $@\n";
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

