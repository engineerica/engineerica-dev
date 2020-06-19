# WWW::OpenAPIClient::TranslationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::TranslationApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**translation_get**](TranslationApi.md#translation_get) | **GET** /translation/get | Gets the translations of the specified values
[**translation_getcachefile**](TranslationApi.md#translation_getcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
[**translation_list**](TranslationApi.md#translation_list) | **GET** /translation/list | Lists all the available translations in the system
[**translation_save**](TranslationApi.md#translation_save) | **POST** /translation/{id} | Edit a translation


# **translation_get**
> translation_get(universal => $universal)

Gets the translations of the specified values

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TranslationApi;
my $api_instance = WWW::OpenAPIClient::TranslationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $universal = "universal_example"; # string | Pipe separated list of universal text to be translated.

eval { 
    $api_instance->translation_get(universal => $universal);
};
if ($@) {
    warn "Exception when calling TranslationApi->translation_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **universal** | **string**| Pipe separated list of universal text to be translated. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translation_getcachefile**
> translation_getcachefile(account => $account)

Get the file containing the translations

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TranslationApi;
my $api_instance = WWW::OpenAPIClient::TranslationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $account = "account_example"; # string | The id of the account whose translations file has to be retrieved.

eval { 
    $api_instance->translation_getcachefile(account => $account);
};
if ($@) {
    warn "Exception when calling TranslationApi->translation_getcachefile: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| The id of the account whose translations file has to be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translation_list**
> translation_list(filter => $filter, nondefaultonly => $nondefaultonly, appdefaultasuniversal => $appdefaultasuniversal)

Lists all the available translations in the system

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TranslationApi;
my $api_instance = WWW::OpenAPIClient::TranslationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $filter = "filter_example"; # string | Text to search/filter translations.
my $nondefaultonly = null; # boolean | If true then it returns only the terms translated. Otherwise, it returns all.
my $appdefaultasuniversal = null; # boolean | If true then it uses the app default translation as the universal term.

eval { 
    $api_instance->translation_list(filter => $filter, nondefaultonly => $nondefaultonly, appdefaultasuniversal => $appdefaultasuniversal);
};
if ($@) {
    warn "Exception when calling TranslationApi->translation_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **boolean**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translation_save**
> translation_save(id => $id, unknown_base_type => $unknown_base_type)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TranslationApi;
my $api_instance = WWW::OpenAPIClient::TranslationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = "id_example"; # string | The id of the translation as returned by translation.list.
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->translation_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling TranslationApi->translation_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the translation as returned by translation.list. | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

