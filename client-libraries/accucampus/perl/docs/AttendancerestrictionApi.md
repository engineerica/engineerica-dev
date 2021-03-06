# WWW::OpenAPIClient::AttendancerestrictionApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AttendancerestrictionApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancerestriction_delete**](AttendancerestrictionApi.md#attendancerestriction_delete) | **DELETE** /attendancerestriction/{id} | Delete an attendance restriction
[**attendancerestriction_get**](AttendancerestrictionApi.md#attendancerestriction_get) | **GET** /attendancerestriction/{id} | View details of an attendance restriction
[**attendancerestriction_list**](AttendancerestrictionApi.md#attendancerestriction_list) | **GET** /attendancerestriction/list | View a list of attendance restrictions
[**attendancerestriction_save**](AttendancerestrictionApi.md#attendancerestriction_save) | **POST** /attendancerestriction/{id} | Create or edit an attendance restriction


# **attendancerestriction_delete**
> attendancerestriction_delete(id => $id, body => $body)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancerestrictionApi;
my $api_instance = WWW::OpenAPIClient::AttendancerestrictionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the restriction to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->attendancerestriction_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling AttendancerestrictionApi->attendancerestriction_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the restriction to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancerestriction_get**
> attendancerestriction_get(id => $id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancerestrictionApi;
my $api_instance = WWW::OpenAPIClient::AttendancerestrictionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the restriction to get.

eval { 
    $api_instance->attendancerestriction_get(id => $id);
};
if ($@) {
    warn "Exception when calling AttendancerestrictionApi->attendancerestriction_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the restriction to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancerestriction_list**
> attendancerestriction_list(from => $from, count => $count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancerestrictionApi;
my $api_instance = WWW::OpenAPIClient::AttendancerestrictionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->attendancerestriction_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling AttendancerestrictionApi->attendancerestriction_list: $@\n";
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

# **attendancerestriction_save**
> attendancerestriction_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancerestrictionApi;
my $api_instance = WWW::OpenAPIClient::AttendancerestrictionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the restriction save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->attendancerestriction_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AttendancerestrictionApi->attendancerestriction_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the restriction save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

