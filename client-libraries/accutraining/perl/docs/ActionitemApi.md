# WWW::OpenAPIClient::ActionitemApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ActionitemApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionitem_delete**](ActionitemApi.md#actionitem_delete) | **DELETE** /actionitem/{id} | Delete an action item
[**actionitem_get**](ActionitemApi.md#actionitem_get) | **GET** /actionitem/{id} | Search and view details of an action item
[**actionitem_list**](ActionitemApi.md#actionitem_list) | **GET** /actionitem/list | View a list of action items
[**actionitem_save**](ActionitemApi.md#actionitem_save) | **POST** /actionitem/{id} | Create or edit an action item


# **actionitem_delete**
> actionitem_delete(id => $id, body => $body)

Delete an action item

Allows the user to delete an action item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionitemApi;
my $api_instance = WWW::OpenAPIClient::ActionitemApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action item to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->actionitem_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling ActionitemApi->actionitem_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action item to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitem_get**
> actionitem_get(id => $id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionitemApi;
my $api_instance = WWW::OpenAPIClient::ActionitemApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action item to get.

eval { 
    $api_instance->actionitem_get(id => $id);
};
if ($@) {
    warn "Exception when calling ActionitemApi->actionitem_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action item to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitem_list**
> actionitem_list(from => $from, count => $count)

View a list of action items

Allows the user to view a list of action items

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionitemApi;
my $api_instance = WWW::OpenAPIClient::ActionitemApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->actionitem_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling ActionitemApi->actionitem_list: $@\n";
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

# **actionitem_save**
> actionitem_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit an action item

Allows the user to edit an action item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionitemApi;
my $api_instance = WWW::OpenAPIClient::ActionitemApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action item to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionitem_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ActionitemApi->actionitem_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action item to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

