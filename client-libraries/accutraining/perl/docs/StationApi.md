# WWW::OpenAPIClient::StationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::StationApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**station_delete**](StationApi.md#station_delete) | **DELETE** /station/{id} | Delete a sign-in station
[**station_get**](StationApi.md#station_get) | **GET** /station/{id} | View details of a sign-in station
[**station_getcurrentterms**](StationApi.md#station_getcurrentterms) | **GET** /station/getcurrentterms | Get all the current terms
[**station_getinfo**](StationApi.md#station_getinfo) | **GET** /station/getinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**station_getlicense**](StationApi.md#station_getlicense) | **GET** /station/getlicense | Gets the current license information
[**station_list**](StationApi.md#station_list) | **GET** /station/list | View a list of sign-in stations
[**station_save**](StationApi.md#station_save) | **POST** /station/{id} | Create or edit a sign-in station
[**station_unlock**](StationApi.md#station_unlock) | **GET** /station/unlock | Unlocks the sign-in station.


# **station_delete**
> station_delete(id => $id, body => $body)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the sign-in station to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->station_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling StationApi->station_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **station_get**
> station_get(id => $id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the sign-in station to get.

eval { 
    $api_instance->station_get(id => $id);
};
if ($@) {
    warn "Exception when calling StationApi->station_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **station_getcurrentterms**
> station_getcurrentterms(station => $station)

Get all the current terms

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(
);

my $station = null; # string | The id of the sign-in station whose account's current terms have to be retrieved.

eval { 
    $api_instance->station_getcurrentterms(station => $station);
};
if ($@) {
    warn "Exception when calling StationApi->station_getcurrentterms: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **station_getinfo**
> station_getinfo(id => $id, event => $event)

Gets a the info to display in the sign-in station by it's ID.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(
);

my $id = null; # string | The id of the sign-in station to get.
my $event = null; # string | The id of the event, to override the one by schedule.

eval { 
    $api_instance->station_getinfo(id => $id, event => $event);
};
if ($@) {
    warn "Exception when calling StationApi->station_getinfo: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to get. | 
 **event** | [**string**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **station_getlicense**
> station_getlicense(station => $station)

Gets the current license information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(
);

my $station = "station_example"; # string | The id of the sign-in station whose account's license has to be retrieved.

eval { 
    $api_instance->station_getlicense(station => $station);
};
if ($@) {
    warn "Exception when calling StationApi->station_getlicense: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **string**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **station_list**
> station_list(from => $from, count => $count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->station_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling StationApi->station_list: $@\n";
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

# **station_save**
> station_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the sign-in station to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->station_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling StationApi->station_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **station_unlock**
> station_unlock(id => $id, passcode => $passcode, method => $method)

Unlocks the sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StationApi;
my $api_instance = WWW::OpenAPIClient::StationApi->new(
);

my $id = null; # string | The id of the sign-in station to unlock.
my $passcode = "passcode_example"; # string | The passcode to unlock the station.
my $method = "method_example"; # string | The authentication method. Valid values are 'token' and 'cookie'.

eval { 
    $api_instance->station_unlock(id => $id, passcode => $passcode, method => $method);
};
if ($@) {
    warn "Exception when calling StationApi->station_unlock: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **string**| The passcode to unlock the station. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

