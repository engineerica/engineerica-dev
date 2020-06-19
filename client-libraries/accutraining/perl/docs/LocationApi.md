# WWW::OpenAPIClient::LocationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::LocationApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**location_delete**](LocationApi.md#location_delete) | **DELETE** /location/{id} | Delete a location
[**location_get**](LocationApi.md#location_get) | **GET** /location/{id} | Search and view details of a location
[**location_list**](LocationApi.md#location_list) | **GET** /location/list | View a list of locations
[**location_save**](LocationApi.md#location_save) | **POST** /location/{id} | Create or edit a location


# **location_delete**
> location_delete(id => $id, body => $body)

Delete a location

Allows the user to delete an existing location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LocationApi;
my $api_instance = WWW::OpenAPIClient::LocationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the location to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->location_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling LocationApi->location_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the location to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **location_get**
> location_get(id => $id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LocationApi;
my $api_instance = WWW::OpenAPIClient::LocationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the location to get.

eval { 
    $api_instance->location_get(id => $id);
};
if ($@) {
    warn "Exception when calling LocationApi->location_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **location_list**
> location_list(from => $from, count => $count, locations => $locations, sortbygroup => $sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LocationApi;
my $api_instance = WWW::OpenAPIClient::LocationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $locations = "locations_example"; # string | The comma-separated list containing the ids of the locations to list.
my $sortbygroup = null; # boolean | True to list locations sorted by the 'Located In' property. Defaults to false.

eval { 
    $api_instance->location_list(from => $from, count => $count, locations => $locations, sortbygroup => $sortbygroup);
};
if ($@) {
    warn "Exception when calling LocationApi->location_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **locations** | **string**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **boolean**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **location_save**
> location_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a location

Allows the user to create or edit a location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LocationApi;
my $api_instance = WWW::OpenAPIClient::LocationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the location save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->location_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling LocationApi->location_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the location save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

