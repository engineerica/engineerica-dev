# WWW::OpenAPIClient::InteractionApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::InteractionApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**interaction_delete**](InteractionApi.md#interaction_delete) | **DELETE** /interaction/{id} | Delete an interaction
[**interaction_feed**](InteractionApi.md#interaction_feed) | **GET** /interaction/feed | Get the interactions feed
[**interaction_get**](InteractionApi.md#interaction_get) | **GET** /interaction/{id} | View an interaction
[**interaction_listprivatesummary**](InteractionApi.md#interaction_listprivatesummary) | **GET** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**interaction_save**](InteractionApi.md#interaction_save) | **POST** /interaction/{id} | Save an interaction


# **interaction_delete**
> interaction_delete(id => $id, body => $body)

Delete an interaction

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::InteractionApi;
my $api_instance = WWW::OpenAPIClient::InteractionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the interaction to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->interaction_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling InteractionApi->interaction_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the interaction to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interaction_feed**
> interaction_feed(from => $from, count => $count, startdate => $startdate, public => $public, contexttype => $contexttype, contextid => $contextid, types => $types, photosize => $photosize, showdefaultphoto => $showdefaultphoto, orderdescending => $orderdescending)

Get the interactions feed

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::InteractionApi;
my $api_instance = WWW::OpenAPIClient::InteractionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If set, only interactions that happened after this date are returned.
my $public = null; # boolean | Specifies whether to return public or private interactions.
my $contexttype = "contexttype_example"; # string | The type of the context of the interactions to return.
my $contextid = null; # string | The id of the context of the interactions to return.
my $types = "types_example"; # string | The  comma separated types of the interactions to return.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
my $showdefaultphoto = null; # boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
my $orderdescending = null; # boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.

eval { 
    $api_instance->interaction_feed(from => $from, count => $count, startdate => $startdate, public => $public, contexttype => $contexttype, contextid => $contextid, types => $types, photosize => $photosize, showdefaultphoto => $showdefaultphoto, orderdescending => $orderdescending);
};
if ($@) {
    warn "Exception when calling InteractionApi->interaction_feed: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **startdate** | **DateTime**| If set, only interactions that happened after this date are returned. | [optional] 
 **public** | **boolean**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **string**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**string**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **string**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interaction_get**
> interaction_get(id => $id, thumbnailmediasize => $thumbnailmediasize, photosize => $photosize)

View an interaction

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::InteractionApi;
my $api_instance = WWW::OpenAPIClient::InteractionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = "id_example"; # string | The id of the interaction.
my $thumbnailmediasize = 56; # int | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->interaction_get(id => $id, thumbnailmediasize => $thumbnailmediasize, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling InteractionApi->interaction_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the interaction. | 
 **thumbnailmediasize** | **int**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interaction_listprivatesummary**
> interaction_listprivatesummary(photosize => $photosize, showdefaultphoto => $showdefaultphoto)

Get current user's latest private interactions

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::InteractionApi;
my $api_instance = WWW::OpenAPIClient::InteractionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
my $showdefaultphoto = null; # boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

eval { 
    $api_instance->interaction_listprivatesummary(photosize => $photosize, showdefaultphoto => $showdefaultphoto);
};
if ($@) {
    warn "Exception when calling InteractionApi->interaction_listprivatesummary: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interaction_save**
> interaction_save(id => $id, unknown_base_type => $unknown_base_type)

Save an interaction

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::InteractionApi;
my $api_instance = WWW::OpenAPIClient::InteractionApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the interaction to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->interaction_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling InteractionApi->interaction_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the interaction to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

