# WWW::OpenAPIClient::AppshareApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AppshareApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appshare_getphone**](AppshareApi.md#appshare_getphone) | **GET** /appshare/getphone | Gets the phone number of the current user
[**appshare_sendtext**](AppshareApi.md#appshare_sendtext) | **GET** /appshare/sendtext | Sends an SMS with the link to the app


# **appshare_getphone**
> appshare_getphone()

Gets the phone number of the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppshareApi;
my $api_instance = WWW::OpenAPIClient::AppshareApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->appshare_getphone();
};
if ($@) {
    warn "Exception when calling AppshareApi->appshare_getphone: $@\n";
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

# **appshare_sendtext**
> appshare_sendtext(phonenumber => $phonenumber)

Sends an SMS with the link to the app

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppshareApi;
my $api_instance = WWW::OpenAPIClient::AppshareApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $phonenumber = "phonenumber_example"; # string | Phone number to where to send the link. Leave empty to the number on file.

eval { 
    $api_instance->appshare_sendtext(phonenumber => $phonenumber);
};
if ($@) {
    warn "Exception when calling AppshareApi->appshare_sendtext: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phonenumber** | **string**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

