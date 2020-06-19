# WWW::OpenAPIClient::TagApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::TagApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tag_delete**](TagApi.md#tag_delete) | **DELETE** /tag/{id} | Delete a tag
[**tag_get**](TagApi.md#tag_get) | **GET** /tag/{id} | View details of a specified tag
[**tag_list**](TagApi.md#tag_list) | **GET** /tag/list | View a list of tags
[**tag_listgroups**](TagApi.md#tag_listgroups) | **GET** /tag/listgroups | View a list of entities that can be tagged
[**tag_save**](TagApi.md#tag_save) | **POST** /tag/{id} | Create or edit a tag
[**tag_search**](TagApi.md#tag_search) | **GET** /tag/search | Search for tags in the account


# **tag_delete**
> tag_delete(id => $id, body => $body)

Delete a tag

Allows the user to delete an existing tag.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TagApi;
my $api_instance = WWW::OpenAPIClient::TagApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the tag to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->tag_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling TagApi->tag_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the tag to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tag_get**
> tag_get(id => $id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TagApi;
my $api_instance = WWW::OpenAPIClient::TagApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the tag to get.

eval { 
    $api_instance->tag_get(id => $id);
};
if ($@) {
    warn "Exception when calling TagApi->tag_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the tag to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tag_list**
> tag_list(group => $group, from => $from, count => $count)

View a list of tags

Allows the user to view the list of tags.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TagApi;
my $api_instance = WWW::OpenAPIClient::TagApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $group = "group_example"; # string | The group of the tags to return.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->tag_list(group => $group, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling TagApi->tag_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The group of the tags to return. | 
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

# **tag_listgroups**
> tag_listgroups()

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TagApi;
my $api_instance = WWW::OpenAPIClient::TagApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->tag_listgroups();
};
if ($@) {
    warn "Exception when calling TagApi->tag_listgroups: $@\n";
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

# **tag_save**
> tag_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a tag

Allows the user to create or edit a tag.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TagApi;
my $api_instance = WWW::OpenAPIClient::TagApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the tag save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->tag_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling TagApi->tag_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the tag save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tag_search**
> tag_search(query => $query, allowcreatingnew => $allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TagApi;
my $api_instance = WWW::OpenAPIClient::TagApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $query = "query_example"; # string | The query to search tags. Use group:<group> to search in a specific group (mandatory).
my $allowcreatingnew = null; # boolean | Specifies whether an option to create a new tag should be retrieved.

eval { 
    $api_instance->tag_search(query => $query, allowcreatingnew => $allowcreatingnew);
};
if ($@) {
    warn "Exception when calling TagApi->tag_search: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **boolean**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

