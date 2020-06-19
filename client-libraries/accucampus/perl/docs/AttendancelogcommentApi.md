# WWW::OpenAPIClient::AttendancelogcommentApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AttendancelogcommentApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogcomment_delete**](AttendancelogcommentApi.md#attendancelogcomment_delete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**attendancelogcomment_get**](AttendancelogcommentApi.md#attendancelogcomment_get) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
[**attendancelogcomment_list**](AttendancelogcommentApi.md#attendancelogcomment_list) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
[**attendancelogcomment_save**](AttendancelogcommentApi.md#attendancelogcomment_save) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log


# **attendancelogcomment_delete**
> attendancelogcomment_delete(id => $id, body => $body)

Delete a comment on an attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogcommentApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogcommentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the attendance log comment to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->attendancelogcomment_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling AttendancelogcommentApi->attendancelogcomment_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the attendance log comment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcomment_get**
> attendancelogcomment_get(id => $id)

View a comment on an attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogcommentApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogcommentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the comment to get.

eval { 
    $api_instance->attendancelogcomment_get(id => $id);
};
if ($@) {
    warn "Exception when calling AttendancelogcommentApi->attendancelogcomment_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the comment to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcomment_list**
> attendancelogcomment_list(attendancelog => $attendancelog)

View all the comments on a specific attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogcommentApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogcommentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $attendancelog = null; # string | The id of the attendance log whose comments have to be retrieved.

eval { 
    $api_instance->attendancelogcomment_list(attendancelog => $attendancelog);
};
if ($@) {
    warn "Exception when calling AttendancelogcommentApi->attendancelogcomment_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**string**](.md)| The id of the attendance log whose comments have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcomment_save**
> attendancelogcomment_save(id => $id, unknown_base_type => $unknown_base_type)

Save a comment on an attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogcommentApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogcommentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the comment to edit (leave empty to create a new one)
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->attendancelogcomment_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AttendancelogcommentApi->attendancelogcomment_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the comment to edit (leave empty to create a new one) | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

