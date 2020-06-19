# WWW::OpenAPIClient::DeadendrecordingApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::DeadendrecordingApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deadendrecording_delete**](DeadendrecordingApi.md#deadendrecording_delete) | **DELETE** /deadendrecording/delete | Deletes a dead-end record group
[**deadendrecording_list**](DeadendrecordingApi.md#deadendrecording_list) | **GET** /deadendrecording/list | Lists the recorded dead ends, if enabled
[**deadendrecording_listcomments**](DeadendrecordingApi.md#deadendrecording_listcomments) | **GET** /deadendrecording/listcomments | Lists the comments for a specific dead end
[**deadendrecording_save**](DeadendrecordingApi.md#deadendrecording_save) | **POST** /deadendrecording/save | Saves a dead-end record


# **deadendrecording_delete**
> deadendrecording_delete(unknown_base_type => $unknown_base_type)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DeadendrecordingApi;
my $api_instance = WWW::OpenAPIClient::DeadendrecordingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->deadendrecording_delete(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DeadendrecordingApi->deadendrecording_delete: $@\n";
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

# **deadendrecording_list**
> deadendrecording_list()

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DeadendrecordingApi;
my $api_instance = WWW::OpenAPIClient::DeadendrecordingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->deadendrecording_list();
};
if ($@) {
    warn "Exception when calling DeadendrecordingApi->deadendrecording_list: $@\n";
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

# **deadendrecording_listcomments**
> deadendrecording_listcomments(hierarchykey => $hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DeadendrecordingApi;
my $api_instance = WWW::OpenAPIClient::DeadendrecordingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $hierarchykey = "hierarchykey_example"; # string | The hierarchy key of the record to get the feedback.

eval { 
    $api_instance->deadendrecording_listcomments(hierarchykey => $hierarchykey);
};
if ($@) {
    warn "Exception when calling DeadendrecordingApi->deadendrecording_listcomments: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hierarchykey** | **string**| The hierarchy key of the record to get the feedback. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadendrecording_save**
> deadendrecording_save(unknown_base_type => $unknown_base_type)

Saves a dead-end record

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DeadendrecordingApi;
my $api_instance = WWW::OpenAPIClient::DeadendrecordingApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->deadendrecording_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DeadendrecordingApi->deadendrecording_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

