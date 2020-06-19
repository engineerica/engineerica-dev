# WWW::OpenAPIClient::MenuApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::MenuApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**menu_getitems**](MenuApi.md#menu_getitems) | **GET** /menu/getitems | Gets the items on the menu


# **menu_getitems**
> menu_getitems(menuid => $menuid)

Gets the items on the menu

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MenuApi;
my $api_instance = WWW::OpenAPIClient::MenuApi->new(
);

my $menuid = "menuid_example"; # string | The Id of the menu to get.

eval { 
    $api_instance->menu_getitems(menuid => $menuid);
};
if ($@) {
    warn "Exception when calling MenuApi->menu_getitems: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **string**| The Id of the menu to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

