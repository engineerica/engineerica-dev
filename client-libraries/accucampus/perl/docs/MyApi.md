# WWW::OpenAPIClient::MyApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::MyApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**my_account**](MyApi.md#my_account) | **GET** /my/account | Gets the logged in user account.
[**my_ianatimezone**](MyApi.md#my_ianatimezone) | **GET** /my/ianatimezone | Gets the current time zone&#39;s iana name
[**my_profile**](MyApi.md#my_profile) | **GET** /my/profile | Gets the logged in user information.
[**my_rights**](MyApi.md#my_rights) | **GET** /my/rights | Gets the list of actions the user can execute.
[**my_saveprofile**](MyApi.md#my_saveprofile) | **POST** /my/saveprofile | Updates logged user&#39;s profile information


# **my_account**
> my_account()

Gets the logged in user account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MyApi;
my $api_instance = WWW::OpenAPIClient::MyApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->my_account();
};
if ($@) {
    warn "Exception when calling MyApi->my_account: $@\n";
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

# **my_ianatimezone**
> my_ianatimezone()

Gets the current time zone's iana name

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MyApi;
my $api_instance = WWW::OpenAPIClient::MyApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->my_ianatimezone();
};
if ($@) {
    warn "Exception when calling MyApi->my_ianatimezone: $@\n";
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

# **my_profile**
> my_profile(photosize => $photosize)

Gets the logged in user information.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MyApi;
my $api_instance = WWW::OpenAPIClient::MyApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->my_profile(photosize => $photosize);
};
if ($@) {
    warn "Exception when calling MyApi->my_profile: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **my_rights**
> my_rights()

Gets the list of actions the user can execute.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MyApi;
my $api_instance = WWW::OpenAPIClient::MyApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->my_rights();
};
if ($@) {
    warn "Exception when calling MyApi->my_rights: $@\n";
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

# **my_saveprofile**
> my_saveprofile(unknown_base_type => $unknown_base_type)

Updates logged user's profile information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MyApi;
my $api_instance = WWW::OpenAPIClient::MyApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->my_saveprofile(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling MyApi->my_saveprofile: $@\n";
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

