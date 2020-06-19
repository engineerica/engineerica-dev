# WWW::OpenAPIClient::ActiontypeApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ActiontypeApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actiontype_delete**](ActiontypeApi.md#actiontype_delete) | **DELETE** /actiontype/{id} | Delete an action item type
[**actiontype_get**](ActiontypeApi.md#actiontype_get) | **GET** /actiontype/{id} | View details of an action item type
[**actiontype_list**](ActiontypeApi.md#actiontype_list) | **GET** /actiontype/list | View a list of action item types
[**actiontype_save**](ActiontypeApi.md#actiontype_save) | **POST** /actiontype/{id} | Create or edit an action item type


# **actiontype_delete**
> actiontype_delete(id => $id, body => $body)

Delete an action item type

Allows the user to delete an action item type.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActiontypeApi;
my $api_instance = WWW::OpenAPIClient::ActiontypeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action type to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->actiontype_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling ActiontypeApi->actiontype_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action type to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontype_get**
> actiontype_get(id => $id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActiontypeApi;
my $api_instance = WWW::OpenAPIClient::ActiontypeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action type to get.

eval { 
    $api_instance->actiontype_get(id => $id);
};
if ($@) {
    warn "Exception when calling ActiontypeApi->actiontype_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action type to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontype_list**
> actiontype_list(from => $from, count => $count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActiontypeApi;
my $api_instance = WWW::OpenAPIClient::ActiontypeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->actiontype_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling ActiontypeApi->actiontype_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontype_save**
> actiontype_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit an action item type

Allows the user to dit an action item type.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActiontypeApi;
my $api_instance = WWW::OpenAPIClient::ActiontypeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action type to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actiontype_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ActiontypeApi->actiontype_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action type to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

