# WWW::OpenAPIClient::UsersettingsApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::UsersettingsApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usersettings_get**](UsersettingsApi.md#usersettings_get) | **GET** /usersettings/get | Lists available user settings
[**usersettings_getmultiple**](UsersettingsApi.md#usersettings_getmultiple) | **GET** /usersettings/getmultiple | Get multiple user settings
[**usersettings_save**](UsersettingsApi.md#usersettings_save) | **POST** /usersettings/save | Saves a user setting
[**usersettings_savemultiple**](UsersettingsApi.md#usersettings_savemultiple) | **POST** /usersettings/savemultiple | Save multiple user settings at once


# **usersettings_get**
> usersettings_get(keys => $keys, user => $user)

Lists available user settings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsersettingsApi;
my $api_instance = WWW::OpenAPIClient::UsersettingsApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $keys = "keys_example"; # string | Setting key to get. Can be multiple separated by commas.
my $user = null; # string | The user id whose settings have to be returned.

eval { 
    $api_instance->usersettings_get(keys => $keys, user => $user);
};
if ($@) {
    warn "Exception when calling UsersettingsApi->usersettings_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**string**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettings_getmultiple**
> usersettings_getmultiple(keys => $keys, user => $user)

Get multiple user settings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsersettingsApi;
my $api_instance = WWW::OpenAPIClient::UsersettingsApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $keys = "keys_example"; # string | Setting key to get. Can be multiple separated by commas.
my $user = null; # string | The user id whose settings have to be returned.

eval { 
    $api_instance->usersettings_getmultiple(keys => $keys, user => $user);
};
if ($@) {
    warn "Exception when calling UsersettingsApi->usersettings_getmultiple: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**string**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettings_save**
> usersettings_save(unknown_base_type => $unknown_base_type)

Saves a user setting

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsersettingsApi;
my $api_instance = WWW::OpenAPIClient::UsersettingsApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usersettings_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UsersettingsApi->usersettings_save: $@\n";
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

# **usersettings_savemultiple**
> usersettings_savemultiple(unknown_base_type => $unknown_base_type)

Save multiple user settings at once

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsersettingsApi;
my $api_instance = WWW::OpenAPIClient::UsersettingsApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usersettings_savemultiple(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UsersettingsApi->usersettings_savemultiple: $@\n";
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

