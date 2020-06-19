# WWW::OpenAPIClient::LikeApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::LikeApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**like_delete**](LikeApi.md#like_delete) | **DELETE** /like/delete | Delete a like
[**like_list**](LikeApi.md#like_list) | **GET** /like/list | View all the likes associated to a target
[**like_save**](LikeApi.md#like_save) | **POST** /like/save | Save a like


# **like_delete**
> like_delete(unknown_base_type => $unknown_base_type)

Delete a like

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LikeApi;
my $api_instance = WWW::OpenAPIClient::LikeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->like_delete(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling LikeApi->like_delete: $@\n";
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

# **like_list**
> like_list(interactionid => $interactionid, photosize => $photosize)

View all the likes associated to a target

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LikeApi;
my $api_instance = WWW::OpenAPIClient::LikeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $interactionid = null; # string | The id of the interaction to unlike.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->like_list(interactionid => $interactionid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling LikeApi->like_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionid** | [**string**](.md)| The id of the interaction to unlike. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **like_save**
> like_save(unknown_base_type => $unknown_base_type)

Save a like

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LikeApi;
my $api_instance = WWW::OpenAPIClient::LikeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->like_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling LikeApi->like_save: $@\n";
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

