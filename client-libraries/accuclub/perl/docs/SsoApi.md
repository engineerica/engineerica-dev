# WWW::OpenAPIClient::SsoApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SsoApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sso_generatekey**](SsoApi.md#sso_generatekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
[**sso_getsettings**](SsoApi.md#sso_getsettings) | **GET** /sso/getsettings | View single sign on settings.
[**sso_issuetoken**](SsoApi.md#sso_issuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
[**sso_savesettings**](SsoApi.md#sso_savesettings) | **POST** /sso/savesettings | Edit single sign-on settings.


# **sso_generatekey**
> sso_generatekey()

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SsoApi;
my $api_instance = WWW::OpenAPIClient::SsoApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->sso_generatekey();
};
if ($@) {
    warn "Exception when calling SsoApi->sso_generatekey: $@\n";
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

# **sso_getsettings**
> sso_getsettings()

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SsoApi;
my $api_instance = WWW::OpenAPIClient::SsoApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->sso_getsettings();
};
if ($@) {
    warn "Exception when calling SsoApi->sso_getsettings: $@\n";
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

# **sso_issuetoken**
> sso_issuetoken(key => $key, username => $username, expires => $expires)

Issue single sign-on token

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SsoApi;
my $api_instance = WWW::OpenAPIClient::SsoApi->new(
);

my $key = "key_example"; # string | The single sign-on key of the account.
my $username = "username_example"; # string | The email of the user to sign-on.
my $expires = null; # boolean | Specifies whether the session should expire when inactive.

eval { 
    $api_instance->sso_issuetoken(key => $key, username => $username, expires => $expires);
};
if ($@) {
    warn "Exception when calling SsoApi->sso_issuetoken: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The single sign-on key of the account. | 
 **username** | **string**| The email of the user to sign-on. | 
 **expires** | **boolean**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sso_savesettings**
> sso_savesettings(unknown_base_type => $unknown_base_type)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SsoApi;
my $api_instance = WWW::OpenAPIClient::SsoApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sso_savesettings(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SsoApi->sso_savesettings: $@\n";
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

