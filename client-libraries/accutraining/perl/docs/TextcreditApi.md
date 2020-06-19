# WWW::OpenAPIClient::TextcreditApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::TextcreditApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**textcredit_remaining**](TextcreditApi.md#textcredit_remaining) | **GET** /textcredit/remaining | Gets the remaining text credits for the account


# **textcredit_remaining**
> textcredit_remaining()

Gets the remaining text credits for the account

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TextcreditApi;
my $api_instance = WWW::OpenAPIClient::TextcreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->textcredit_remaining();
};
if ($@) {
    warn "Exception when calling TextcreditApi->textcredit_remaining: $@\n";
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

