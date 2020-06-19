# WWW::OpenAPIClient::SettingApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SettingApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**setting_addlogo**](SettingApi.md#setting_addlogo) | **GET** /setting/addlogo | Add a logo to the account
[**setting_get**](SettingApi.md#setting_get) | **GET** /setting/get | Get settings for the account or the specified scope
[**setting_save**](SettingApi.md#setting_save) | **POST** /setting/save | Save settings for the account or the specified scope
[**setting_viewgeneral**](SettingApi.md#setting_viewgeneral) | **GET** /setting/viewgeneral | View general settings for the account


# **setting_addlogo**
> setting_addlogo(upload => $upload, filename => $filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuTraining browser version.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SettingApi;
my $api_instance = WWW::OpenAPIClient::SettingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The original filename, needed to process the file.

eval { 
    $api_instance->setting_addlogo(upload => $upload, filename => $filename);
};
if ($@) {
    warn "Exception when calling SettingApi->setting_addlogo: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The original filename, needed to process the file. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **setting_get**
> setting_get(keys => $keys, domain => $domain, scope => $scope)

Get settings for the account or the specified scope

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SettingApi;
my $api_instance = WWW::OpenAPIClient::SettingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $keys = "keys_example"; # string | The option keys to get values for. Enter multiple separated by comma.
my $domain = "domain_example"; # string | The account domain, in case of reading settings annonymously.
my $scope = "scope_example"; # string | The scope of the settings to get.

eval { 
    $api_instance->setting_get(keys => $keys, domain => $domain, scope => $scope);
};
if ($@) {
    warn "Exception when calling SettingApi->setting_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **string**| The option keys to get values for. Enter multiple separated by comma. | 
 **domain** | **string**| The account domain, in case of reading settings annonymously. | [optional] 
 **scope** | **string**| The scope of the settings to get. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **setting_save**
> setting_save(unknown_base_type => $unknown_base_type)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SettingApi;
my $api_instance = WWW::OpenAPIClient::SettingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->setting_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SettingApi->setting_save: $@\n";
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

# **setting_viewgeneral**
> setting_viewgeneral()

View general settings for the account

Allows the user to view the settings' general section.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SettingApi;
my $api_instance = WWW::OpenAPIClient::SettingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->setting_viewgeneral();
};
if ($@) {
    warn "Exception when calling SettingApi->setting_viewgeneral: $@\n";
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

