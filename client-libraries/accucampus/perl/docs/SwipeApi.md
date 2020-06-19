# WWW::OpenAPIClient::SwipeApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SwipeApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**swipe_delete**](SwipeApi.md#swipe_delete) | **DELETE** /swipe/{id} | Delete a swipe
[**swipe_get**](SwipeApi.md#swipe_get) | **GET** /swipe/{id} | Search and view details of a swipe
[**swipe_list**](SwipeApi.md#swipe_list) | **GET** /swipe/list | View a list of swipes
[**swipe_save**](SwipeApi.md#swipe_save) | **POST** /swipe/save | Create or edit a swipe, and if possible, save the related attendance log
[**swipe_saveanonym**](SwipeApi.md#swipe_saveanonym) | **POST** /swipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log


# **swipe_delete**
> swipe_delete(id => $id, body => $body)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SwipeApi;
my $api_instance = WWW::OpenAPIClient::SwipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the swipe to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->swipe_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling SwipeApi->swipe_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the swipe to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipe_get**
> swipe_get(id => $id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SwipeApi;
my $api_instance = WWW::OpenAPIClient::SwipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the swipe to get.

eval { 
    $api_instance->swipe_get(id => $id);
};
if ($@) {
    warn "Exception when calling SwipeApi->swipe_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipe_list**
> swipe_list(from => $from, count => $count)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SwipeApi;
my $api_instance = WWW::OpenAPIClient::SwipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->swipe_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling SwipeApi->swipe_list: $@\n";
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

# **swipe_save**
> swipe_save(unknown_base_type => $unknown_base_type)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SwipeApi;
my $api_instance = WWW::OpenAPIClient::SwipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->swipe_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SwipeApi->swipe_save: $@\n";
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

# **swipe_saveanonym**
> swipe_saveanonym(unknown_base_type => $unknown_base_type)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SwipeApi;
my $api_instance = WWW::OpenAPIClient::SwipeApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->swipe_saveanonym(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SwipeApi->swipe_saveanonym: $@\n";
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

