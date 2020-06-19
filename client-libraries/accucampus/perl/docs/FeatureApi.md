# WWW::OpenAPIClient::FeatureApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::FeatureApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**feature_list**](FeatureApi.md#feature_list) | **GET** /feature/list | Lists the available features.


# **feature_list**
> feature_list()

Lists the available features.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::FeatureApi;
my $api_instance = WWW::OpenAPIClient::FeatureApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->feature_list();
};
if ($@) {
    warn "Exception when calling FeatureApi->feature_list: $@\n";
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

