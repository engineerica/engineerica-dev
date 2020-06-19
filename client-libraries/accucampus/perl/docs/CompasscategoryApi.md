# WWW::OpenAPIClient::CompasscategoryApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CompasscategoryApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**compasscategory_delete**](CompasscategoryApi.md#compasscategory_delete) | **DELETE** /compasscategory/{id} | Delete a compass category
[**compasscategory_get**](CompasscategoryApi.md#compasscategory_get) | **GET** /compasscategory/{id} | View details of a compass category
[**compasscategory_list**](CompasscategoryApi.md#compasscategory_list) | **GET** /compasscategory/list | View a list of compass categories
[**compasscategory_save**](CompasscategoryApi.md#compasscategory_save) | **POST** /compasscategory/{id} | Create or edit a compass category


# **compasscategory_delete**
> compasscategory_delete(id => $id, body => $body)

Delete a compass category

Allows the user to delete an existing compass category.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CompasscategoryApi;
my $api_instance = WWW::OpenAPIClient::CompasscategoryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the category to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->compasscategory_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling CompasscategoryApi->compasscategory_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the category to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compasscategory_get**
> compasscategory_get(id => $id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CompasscategoryApi;
my $api_instance = WWW::OpenAPIClient::CompasscategoryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the category to get.

eval { 
    $api_instance->compasscategory_get(id => $id);
};
if ($@) {
    warn "Exception when calling CompasscategoryApi->compasscategory_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the category to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compasscategory_list**
> compasscategory_list(from => $from, count => $count, onlywithservices => $onlywithservices)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CompasscategoryApi;
my $api_instance = WWW::OpenAPIClient::CompasscategoryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $onlywithservices = null; # boolean | Specified whether only categories with services are returned or all.

eval { 
    $api_instance->compasscategory_list(from => $from, count => $count, onlywithservices => $onlywithservices);
};
if ($@) {
    warn "Exception when calling CompasscategoryApi->compasscategory_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **onlywithservices** | **boolean**| Specified whether only categories with services are returned or all. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compasscategory_save**
> compasscategory_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CompasscategoryApi;
my $api_instance = WWW::OpenAPIClient::CompasscategoryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the category save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->compasscategory_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling CompasscategoryApi->compasscategory_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the category save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

