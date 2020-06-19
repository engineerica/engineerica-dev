# WWW::OpenAPIClient::ReportscheduleApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ReportscheduleApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportschedule_delete**](ReportscheduleApi.md#reportschedule_delete) | **DELETE** /reportschedule/{id} | Delete a report schedule
[**reportschedule_get**](ReportscheduleApi.md#reportschedule_get) | **GET** /reportschedule/{id} | Get a report schedule
[**reportschedule_list**](ReportscheduleApi.md#reportschedule_list) | **GET** /reportschedule/list | View a list of the scheduled reports
[**reportschedule_save**](ReportscheduleApi.md#reportschedule_save) | **POST** /reportschedule/{id} | Create or edit a report schedule


# **reportschedule_delete**
> reportschedule_delete(id => $id, body => $body)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportscheduleApi;
my $api_instance = WWW::OpenAPIClient::ReportscheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the report schedule to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->reportschedule_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling ReportscheduleApi->reportschedule_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the report schedule to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportschedule_get**
> reportschedule_get(id => $id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportscheduleApi;
my $api_instance = WWW::OpenAPIClient::ReportscheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the schedule to get.

eval { 
    $api_instance->reportschedule_get(id => $id);
};
if ($@) {
    warn "Exception when calling ReportscheduleApi->reportschedule_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the schedule to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportschedule_list**
> reportschedule_list(from => $from, count => $count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportscheduleApi;
my $api_instance = WWW::OpenAPIClient::ReportscheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->reportschedule_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling ReportscheduleApi->reportschedule_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportschedule_save**
> reportschedule_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportscheduleApi;
my $api_instance = WWW::OpenAPIClient::ReportscheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the schedule save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->reportschedule_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ReportscheduleApi->reportschedule_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the schedule save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

