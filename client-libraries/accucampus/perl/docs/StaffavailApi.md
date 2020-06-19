# WWW::OpenAPIClient::StaffavailApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::StaffavailApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**staffavail_addmetoallservices**](StaffavailApi.md#staffavail_addmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
[**staffavail_addmetoservice**](StaffavailApi.md#staffavail_addmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
[**staffavail_addusertoallservices**](StaffavailApi.md#staffavail_addusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
[**staffavail_addusertoservice**](StaffavailApi.md#staffavail_addusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
[**staffavail_getmyservices**](StaffavailApi.md#staffavail_getmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
[**staffavail_getservices**](StaffavailApi.md#staffavail_getservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
[**staffavail_getusersforservice**](StaffavailApi.md#staffavail_getusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**staffavail_listtypes**](StaffavailApi.md#staffavail_listtypes) | **GET** /staffavail/listtypes | View all the availability types
[**staffavail_removemefromallservices**](StaffavailApi.md#staffavail_removemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
[**staffavail_removemefromservice**](StaffavailApi.md#staffavail_removemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
[**staffavail_removeuserfromallservices**](StaffavailApi.md#staffavail_removeuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**staffavail_removeuserfromservice**](StaffavailApi.md#staffavail_removeuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
[**staffavail_setavailability**](StaffavailApi.md#staffavail_setavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
[**staffavail_setmyavailability**](StaffavailApi.md#staffavail_setmyavailability) | **GET** /staffavail/setmyavailability | Change current user&#39;s availability type


# **staffavail_addmetoallservices**
> staffavail_addmetoallservices()

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->staffavail_addmetoallservices();
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_addmetoallservices: $@\n";
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

# **staffavail_addmetoservice**
> staffavail_addmetoservice(serviceid => $serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavail_addmetoservice(serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_addmetoservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_addusertoallservices**
> staffavail_addusertoallservices(userid => $userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to add.

eval { 
    $api_instance->staffavail_addusertoallservices(userid => $userid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_addusertoallservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to add. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_addusertoservice**
> staffavail_addusertoservice(userid => $userid, serviceid => $serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to add.
my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavail_addusertoservice(userid => $userid, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_addusertoservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to add. | 
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_getmyservices**
> staffavail_getmyservices()

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->staffavail_getmyservices();
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_getmyservices: $@\n";
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

# **staffavail_getservices**
> staffavail_getservices(userid => $userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The user id to list services.

eval { 
    $api_instance->staffavail_getservices(userid => $userid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_getservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The user id to list services. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_getusersforservice**
> staffavail_getusersforservice(serviceid => $serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The service id to list users.

eval { 
    $api_instance->staffavail_getusersforservice(serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_getusersforservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](.md)| The service id to list users. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_listtypes**
> staffavail_listtypes()

View all the availability types

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->staffavail_listtypes();
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_listtypes: $@\n";
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

# **staffavail_removemefromallservices**
> staffavail_removemefromallservices()

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->staffavail_removemefromallservices();
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_removemefromallservices: $@\n";
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

# **staffavail_removemefromservice**
> staffavail_removemefromservice(serviceid => $serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavail_removemefromservice(serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_removemefromservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_removeuserfromallservices**
> staffavail_removeuserfromallservices(userid => $userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to remove.

eval { 
    $api_instance->staffavail_removeuserfromallservices(userid => $userid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_removeuserfromallservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to remove. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_removeuserfromservice**
> staffavail_removeuserfromservice(userid => $userid, serviceid => $serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to remove.
my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavail_removeuserfromservice(userid => $userid, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_removeuserfromservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_setavailability**
> staffavail_setavailability(userid => $userid, availablefor => $availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user whose specific availability has to be set.
my $availablefor = "availablefor_example"; # string | Specific availability to set.

eval { 
    $api_instance->staffavail_setavailability(userid => $userid, availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_setavailability: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **string**| Specific availability to set. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavail_setmyavailability**
> staffavail_setmyavailability(availablefor => $availablefor)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::StaffavailApi;
my $api_instance = WWW::OpenAPIClient::StaffavailApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $availablefor = "availablefor_example"; # string | Specific availability to set.

eval { 
    $api_instance->staffavail_setmyavailability(availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling StaffavailApi->staffavail_setmyavailability: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **availablefor** | **string**| Specific availability to set. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

