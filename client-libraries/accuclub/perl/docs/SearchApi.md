# WWW::OpenAPIClient::SearchApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SearchApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**search_getentities**](SearchApi.md#search_getentities) | **GET** /search/getentities | Get the information of the entities that can be searched


# **search_getentities**
> search_getentities()

Get the information of the entities that can be searched

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SearchApi;
my $api_instance = WWW::OpenAPIClient::SearchApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->search_getentities();
};
if ($@) {
    warn "Exception when calling SearchApi->search_getentities: $@\n";
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

