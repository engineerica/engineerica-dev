# WWW::OpenAPIClient::ScheduleintegrationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ScheduleintegrationApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleintegration_clearids**](ScheduleintegrationApi.md#scheduleintegration_clearids) | **GET** /scheduleintegration/clearids | Clear all third party IDs from specified staff member&#39;s schedule items.
[**scheduleintegration_deleteitem**](ScheduleintegrationApi.md#scheduleintegration_deleteitem) | **DELETE** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
[**scheduleintegration_deleteitemsbymasterid**](ScheduleintegrationApi.md#scheduleintegration_deleteitemsbymasterid) | **DELETE** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**scheduleintegration_getitem**](ScheduleintegrationApi.md#scheduleintegration_getitem) | **GET** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
[**scheduleintegration_saveitem**](ScheduleintegrationApi.md#scheduleintegration_saveitem) | **POST** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
[**scheduleintegration_setid**](ScheduleintegrationApi.md#scheduleintegration_setid) | **GET** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item


# **scheduleintegration_clearids**
> scheduleintegration_clearids(staff => $staff)

Clear all third party IDs from specified staff member's schedule items.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleintegrationApi;
my $api_instance = WWW::OpenAPIClient::ScheduleintegrationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $staff = null; # string | The ID of the staff member whose schedule items third party IDs must be cleared.

eval { 
    $api_instance->scheduleintegration_clearids(staff => $staff);
};
if ($@) {
    warn "Exception when calling ScheduleintegrationApi->scheduleintegration_clearids: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staff** | [**string**](.md)| The ID of the staff member whose schedule items third party IDs must be cleared. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegration_deleteitem**
> scheduleintegration_deleteitem(unknown_base_type => $unknown_base_type)

Delete a schedule item looking up by a third party ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleintegrationApi;
my $api_instance = WWW::OpenAPIClient::ScheduleintegrationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->scheduleintegration_deleteitem(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ScheduleintegrationApi->scheduleintegration_deleteitem: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegration_deleteitemsbymasterid**
> scheduleintegration_deleteitemsbymasterid(unknown_base_type => $unknown_base_type)

Delete multiple schedule items looking up by a third party master ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleintegrationApi;
my $api_instance = WWW::OpenAPIClient::ScheduleintegrationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->scheduleintegration_deleteitemsbymasterid(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ScheduleintegrationApi->scheduleintegration_deleteitemsbymasterid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegration_getitem**
> scheduleintegration_getitem(thirdpartyid => $thirdpartyid)

Get a schedule item looking up by a third party ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleintegrationApi;
my $api_instance = WWW::OpenAPIClient::ScheduleintegrationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $thirdpartyid = "thirdpartyid_example"; # string | The third party id to search for the schedule item.

eval { 
    $api_instance->scheduleintegration_getitem(thirdpartyid => $thirdpartyid);
};
if ($@) {
    warn "Exception when calling ScheduleintegrationApi->scheduleintegration_getitem: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdpartyid** | **string**| The third party id to search for the schedule item. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegration_saveitem**
> scheduleintegration_saveitem(unknown_base_type => $unknown_base_type)

Save a schedule item looking up by a third party ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleintegrationApi;
my $api_instance = WWW::OpenAPIClient::ScheduleintegrationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->scheduleintegration_saveitem(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ScheduleintegrationApi->scheduleintegration_saveitem: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegration_setid**
> scheduleintegration_setid(id => $id, thirdpartyid => $thirdpartyid, thirdpartymasterid => $thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleintegrationApi;
my $api_instance = WWW::OpenAPIClient::ScheduleintegrationApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the schedule block / appointment.
my $thirdpartyid = "thirdpartyid_example"; # string | The 3rd party ID to set.
my $thirdpartymasterid = "thirdpartymasterid_example"; # string | The 3rd party master ID to set (useful to handle recurring items).

eval { 
    $api_instance->scheduleintegration_setid(id => $id, thirdpartyid => $thirdpartyid, thirdpartymasterid => $thirdpartymasterid);
};
if ($@) {
    warn "Exception when calling ScheduleintegrationApi->scheduleintegration_setid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the schedule block / appointment. | 
 **thirdpartyid** | **string**| The 3rd party ID to set. | 
 **thirdpartymasterid** | **string**| The 3rd party master ID to set (useful to handle recurring items). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

