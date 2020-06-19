# WWW::OpenAPIClient::CompassserviceApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CompassserviceApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**compassservice_list**](CompassserviceApi.md#compassservice_list) | **GET** /compassservice/list | View all the services added to the compass
[**compassservice_listlocations**](CompassserviceApi.md#compassservice_listlocations) | **GET** /compassservice/listlocations | View all the locations where a service added to the compass is available


# **compassservice_list**
> compassservice_list(category => $category)

View all the services added to the compass

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CompassserviceApi;
my $api_instance = WWW::OpenAPIClient::CompassserviceApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $category = null; # string | The id of the category to filter the services.

eval { 
    $api_instance->compassservice_list(category => $category);
};
if ($@) {
    warn "Exception when calling CompassserviceApi->compassservice_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**string**](.md)| The id of the category to filter the services. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compassservice_listlocations**
> compassservice_listlocations(serviceid => $serviceid)

View all the locations where a service added to the compass is available

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CompassserviceApi;
my $api_instance = WWW::OpenAPIClient::CompassserviceApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The id of the service to get its locations.

eval { 
    $api_instance->compassservice_listlocations(serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling CompassserviceApi->compassservice_listlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

