# WWW::OpenAPIClient::ImportApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ImportApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**import_listtypes**](ImportApi.md#import_listtypes) | **GET** /import/listtypes | Lists available import types


# **import_listtypes**
> import_listtypes()

Lists available import types

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ImportApi;
my $api_instance = WWW::OpenAPIClient::ImportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->import_listtypes();
};
if ($@) {
    warn "Exception when calling ImportApi->import_listtypes: $@\n";
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

