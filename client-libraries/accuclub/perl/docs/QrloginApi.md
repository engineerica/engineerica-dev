# WWW::OpenAPIClient::QrloginApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::QrloginApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrlogin_get**](QrloginApi.md#qrlogin_get) | **GET** /qrlogin/get | Gets an image of a QR token
[**qrlogin_login**](QrloginApi.md#qrlogin_login) | **GET** /qrlogin/login | Login


# **qrlogin_get**
> qrlogin_get()

Gets an image of a QR token

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QrloginApi;
my $api_instance = WWW::OpenAPIClient::QrloginApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->qrlogin_get();
};
if ($@) {
    warn "Exception when calling QrloginApi->qrlogin_get: $@\n";
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

# **qrlogin_login**
> qrlogin_login(onetimetoken => $onetimetoken)

Login

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QrloginApi;
my $api_instance = WWW::OpenAPIClient::QrloginApi->new(
);

my $onetimetoken = "onetimetoken_example"; # string | The token read from the QR code.

eval { 
    $api_instance->qrlogin_login(onetimetoken => $onetimetoken);
};
if ($@) {
    warn "Exception when calling QrloginApi->qrlogin_login: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **string**| The token read from the QR code. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

