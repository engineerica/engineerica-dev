# WWW::OpenAPIClient::RoleApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::RoleApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**role_list**](RoleApi.md#role_list) | **GET** /role/list | Show a list of roles


# **role_list**
> role_list(name => $name)

Show a list of roles

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RoleApi;
my $api_instance = WWW::OpenAPIClient::RoleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $name = "name_example"; # string | Filter by name of the role.

eval { 
    $api_instance->role_list(name => $name);
};
if ($@) {
    warn "Exception when calling RoleApi->role_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

