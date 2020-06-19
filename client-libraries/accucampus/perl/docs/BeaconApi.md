# WWW::OpenAPIClient::BeaconApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::BeaconApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**beacon_delete**](BeaconApi.md#beacon_delete) | **DELETE** /beacon/{id} | Delete a beacon profile
[**beacon_disable**](BeaconApi.md#beacon_disable) | **GET** /beacon/disable | Disable beacon support account wide
[**beacon_get**](BeaconApi.md#beacon_get) | **GET** /beacon/{id} | View details of a beacon profile
[**beacon_getlocations**](BeaconApi.md#beacon_getlocations) | **GET** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
[**beacon_getstationlocation**](BeaconApi.md#beacon_getstationlocation) | **GET** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
[**beacon_getuuid**](BeaconApi.md#beacon_getuuid) | **GET** /beacon/getuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**beacon_list**](BeaconApi.md#beacon_list) | **GET** /beacon/list | View a list of beacon profiles
[**beacon_listprofiles**](BeaconApi.md#beacon_listprofiles) | **GET** /beacon/listprofiles | View a list of beacon profiles with their characteristics
[**beacon_resetuuid**](BeaconApi.md#beacon_resetuuid) | **GET** /beacon/resetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**beacon_save**](BeaconApi.md#beacon_save) | **POST** /beacon/{id} | Create or edit a beacon profile
[**beacon_scanlocations**](BeaconApi.md#beacon_scanlocations) | **GET** /beacon/scanlocations | Check if there&#39;s location available to sign-in / out.
[**beacon_setuuid**](BeaconApi.md#beacon_setuuid) | **GET** /beacon/setuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**beacon_silentregions**](BeaconApi.md#beacon_silentregions) | **GET** /beacon/silentregions | View all the beacon regions defined for silent tracking
[**beacon_silentsignin**](BeaconApi.md#beacon_silentsignin) | **GET** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
[**beacon_silentsignout**](BeaconApi.md#beacon_silentsignout) | **GET** /beacon/silentsignout | Sign-out silently from the location specified by a beacon


# **beacon_delete**
> beacon_delete(id => $id, body => $body)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the beacon to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->beacon_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the beacon to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_disable**
> beacon_disable()

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->beacon_disable();
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_disable: $@\n";
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

# **beacon_get**
> beacon_get(id => $id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the beacon to get.

eval { 
    $api_instance->beacon_get(id => $id);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the beacon to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_getlocations**
> beacon_getlocations(beacons => $beacons)

Get the sign-in stations assigned to specific beacons.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $beacons = "beacons_example"; # string | A JSON array containg the beacons data (region, minor and major) values.

eval { 
    $api_instance->beacon_getlocations(beacons => $beacons);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_getlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_getstationlocation**
> beacon_getstationlocation(station => $station, location => $location)

Get the location settings in the specified sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $station = null; # string | The id of the sign-in station whose location information has to be retrieved.
my $location = null; # string | The id of the location whose information has to be retrieved.

eval { 
    $api_instance->beacon_getstationlocation(station => $station, location => $location);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_getstationlocation: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**string**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_getuuid**
> beacon_getuuid()

View the identifier for the account's beacon region (for sign-in stations).

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->beacon_getuuid();
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_getuuid: $@\n";
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

# **beacon_list**
> beacon_list(from => $from, count => $count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->beacon_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_list: $@\n";
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

# **beacon_listprofiles**
> beacon_listprofiles()

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->beacon_listprofiles();
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_listprofiles: $@\n";
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

# **beacon_resetuuid**
> beacon_resetuuid()

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->beacon_resetuuid();
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_resetuuid: $@\n";
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

# **beacon_save**
> beacon_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the beacon save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->beacon_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the beacon save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_scanlocations**
> beacon_scanlocations(beacons => $beacons)

Check if there's location available to sign-in / out.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $beacons = "beacons_example"; # string | A JSON array containg the beacons data (region, minor and major) values.

eval { 
    $api_instance->beacon_scanlocations(beacons => $beacons);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_scanlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_setuuid**
> beacon_setuuid(id => $id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The custom region UUID.

eval { 
    $api_instance->beacon_setuuid(id => $id);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_setuuid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The custom region UUID. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_silentregions**
> beacon_silentregions()

View all the beacon regions defined for silent tracking

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->beacon_silentregions();
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_silentregions: $@\n";
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

# **beacon_silentsignin**
> beacon_silentsignin(uuid => $uuid)

Sign-in silently from the location specified by a beacon

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $uuid = null; # string | The id of the region the user is in.

eval { 
    $api_instance->beacon_silentsignin(uuid => $uuid);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_silentsignin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**string**](.md)| The id of the region the user is in. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacon_silentsignout**
> beacon_silentsignout(uuid => $uuid)

Sign-out silently from the location specified by a beacon

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BeaconApi;
my $api_instance = WWW::OpenAPIClient::BeaconApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $uuid = null; # string | The id of the region the user has left.

eval { 
    $api_instance->beacon_silentsignout(uuid => $uuid);
};
if ($@) {
    warn "Exception when calling BeaconApi->beacon_silentsignout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**string**](.md)| The id of the region the user has left. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

