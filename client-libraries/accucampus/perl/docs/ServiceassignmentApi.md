# WWW::OpenAPIClient::ServiceassignmentApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ServiceassignmentApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceassignment_addservice**](ServiceassignmentApi.md#serviceassignment_addservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**serviceassignment_getlocation**](ServiceassignmentApi.md#serviceassignment_getlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**serviceassignment_getservice**](ServiceassignmentApi.md#serviceassignment_getservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**serviceassignment_removeservice**](ServiceassignmentApi.md#serviceassignment_removeservice) | **GET** /serviceassignment/removeservice | Remove a service from a location


# **serviceassignment_addservice**
> serviceassignment_addservice(serviceid => $serviceid, locationid => $locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceassignmentApi;
my $api_instance = WWW::OpenAPIClient::ServiceassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The id of the service to add.
my $locationid = null; # string | The id of the location.

eval { 
    $api_instance->serviceassignment_addservice(serviceid => $serviceid, locationid => $locationid);
};
if ($@) {
    warn "Exception when calling ServiceassignmentApi->serviceassignment_addservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](.md)| The id of the service to add. | 
 **locationid** | [**string**](.md)| The id of the location. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **serviceassignment_getlocation**
> serviceassignment_getlocation(locationid => $locationid, includegloballyavailable => $includegloballyavailable, namefilter => $namefilter, count => $count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceassignmentApi;
my $api_instance = WWW::OpenAPIClient::ServiceassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $locationid = null; # string | The id of the location to get.
my $includegloballyavailable = null; # boolean | Specifies whether the services available globally must be returned or not.
my $namefilter = null; # boolean | Filters the name of the services to return.
my $count = 56; # int | The max number of services to return.

eval { 
    $api_instance->serviceassignment_getlocation(locationid => $locationid, includegloballyavailable => $includegloballyavailable, namefilter => $namefilter, count => $count);
};
if ($@) {
    warn "Exception when calling ServiceassignmentApi->serviceassignment_getlocation: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**string**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **boolean**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **boolean**| Filters the name of the services to return. | [optional] 
 **count** | **int**| The max number of services to return. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **serviceassignment_getservice**
> serviceassignment_getservice(serviceid => $serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceassignmentApi;
my $api_instance = WWW::OpenAPIClient::ServiceassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The id of the service to get its locations.

eval { 
    $api_instance->serviceassignment_getservice(serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling ServiceassignmentApi->serviceassignment_getservice: $@\n";
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

# **serviceassignment_removeservice**
> serviceassignment_removeservice(serviceid => $serviceid, locationid => $locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceassignmentApi;
my $api_instance = WWW::OpenAPIClient::ServiceassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The id of the service to remove.
my $locationid = null; # string | The id of the location to remove the service from.

eval { 
    $api_instance->serviceassignment_removeservice(serviceid => $serviceid, locationid => $locationid);
};
if ($@) {
    warn "Exception when calling ServiceassignmentApi->serviceassignment_removeservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](.md)| The id of the service to remove. | 
 **locationid** | [**string**](.md)| The id of the location to remove the service from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

