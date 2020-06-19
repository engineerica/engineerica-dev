# WWW::OpenAPIClient::AdhocreportsApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AdhocreportsApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocreports_reqaccess**](AdhocreportsApi.md#adhocreports_reqaccess) | **GET** /adhocreports/reqaccess | Request access to the ad-hoc reports


# **adhocreports_reqaccess**
> adhocreports_reqaccess()

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocreportsApi;
my $api_instance = WWW::OpenAPIClient::AdhocreportsApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->adhocreports_reqaccess();
};
if ($@) {
    warn "Exception when calling AdhocreportsApi->adhocreports_reqaccess: $@\n";
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

