# WWW::OpenAPIClient::TermApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::TermApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**term_delete**](TermApi.md#term_delete) | **DELETE** /term/{id} | Delete a term
[**term_get**](TermApi.md#term_get) | **GET** /term/{id} | Search and view details of a term
[**term_list**](TermApi.md#term_list) | **GET** /term/list | Search and view details of all terms
[**term_save**](TermApi.md#term_save) | **POST** /term/{id} | Create and edit terms


# **term_delete**
> term_delete(id => $id, body => $body)

Delete a term

Allows the user to delete a term from the existing list.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TermApi;
my $api_instance = WWW::OpenAPIClient::TermApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the term to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->term_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling TermApi->term_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the term to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **term_get**
> term_get(id => $id)

Search and view details of a term

Allows the user to view a term and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TermApi;
my $api_instance = WWW::OpenAPIClient::TermApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the term to get.

eval { 
    $api_instance->term_get(id => $id);
};
if ($@) {
    warn "Exception when calling TermApi->term_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the term to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **term_list**
> term_list(from => $from, count => $count, notpast => $notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TermApi;
my $api_instance = WWW::OpenAPIClient::TermApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $notpast = null; # boolean | Specifies whether the terms in the past should be returned or not.

eval { 
    $api_instance->term_list(from => $from, count => $count, notpast => $notpast);
};
if ($@) {
    warn "Exception when calling TermApi->term_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **notpast** | **boolean**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **term_save**
> term_save(id => $id, unknown_base_type => $unknown_base_type)

Create and edit terms

Allows the user to create and edit terms.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TermApi;
my $api_instance = WWW::OpenAPIClient::TermApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the term to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->term_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling TermApi->term_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the term to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

