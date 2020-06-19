# WWW::OpenAPIClient::MemorizedreportApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::MemorizedreportApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**memorizedreport_delete**](MemorizedreportApi.md#memorizedreport_delete) | **DELETE** /memorizedreport/{id} | Delete memorized report
[**memorizedreport_get**](MemorizedreportApi.md#memorizedreport_get) | **GET** /memorizedreport/{id} | View details of a memorized report
[**memorizedreport_list**](MemorizedreportApi.md#memorizedreport_list) | **GET** /memorizedreport/list | View a list of all his memorized reports
[**memorizedreport_save**](MemorizedreportApi.md#memorizedreport_save) | **POST** /memorizedreport/{id} | Create or edit a memorized report


# **memorizedreport_delete**
> memorizedreport_delete(id => $id, body => $body)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MemorizedreportApi;
my $api_instance = WWW::OpenAPIClient::MemorizedreportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the report settings to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->memorizedreport_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling MemorizedreportApi->memorizedreport_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the report settings to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreport_get**
> memorizedreport_get(id => $id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MemorizedreportApi;
my $api_instance = WWW::OpenAPIClient::MemorizedreportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the report configuration to get.

eval { 
    $api_instance->memorizedreport_get(id => $id);
};
if ($@) {
    warn "Exception when calling MemorizedreportApi->memorizedreport_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the report configuration to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreport_list**
> memorizedreport_list(from => $from, count => $count, customname => $customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MemorizedreportApi;
my $api_instance = WWW::OpenAPIClient::MemorizedreportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $customname = "customname_example"; # string | If specified filters the memorized reports by custom name.

eval { 
    $api_instance->memorizedreport_list(from => $from, count => $count, customname => $customname);
};
if ($@) {
    warn "Exception when calling MemorizedreportApi->memorizedreport_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **customname** | **string**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreport_save**
> memorizedreport_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MemorizedreportApi;
my $api_instance = WWW::OpenAPIClient::MemorizedreportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the report settings to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->memorizedreport_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling MemorizedreportApi->memorizedreport_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the report settings to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

