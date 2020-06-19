# WWW::OpenAPIClient::ExportApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ExportApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**export_listtypes**](ExportApi.md#export_listtypes) | **GET** /export/listtypes | Lists available export types


# **export_listtypes**
> export_listtypes()

Lists available export types

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ExportApi;
my $api_instance = WWW::OpenAPIClient::ExportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->export_listtypes();
};
if ($@) {
    warn "Exception when calling ExportApi->export_listtypes: $@\n";
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

