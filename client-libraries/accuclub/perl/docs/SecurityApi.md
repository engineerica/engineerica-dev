# WWW::OpenAPIClient::SecurityApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SecurityApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**security_assesspermission**](SecurityApi.md#security_assesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
[**security_assessrole**](SecurityApi.md#security_assessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
[**security_assessscope**](SecurityApi.md#security_assessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
[**security_assessuser**](SecurityApi.md#security_assessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user


# **security_assesspermission**
> security_assesspermission(commandname => $commandname)

Returns the list of users for a specific permission

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SecurityApi;
my $api_instance = WWW::OpenAPIClient::SecurityApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $commandname = "commandname_example"; # string | Name of the action or command to get the roles.

eval { 
    $api_instance->security_assesspermission(commandname => $commandname);
};
if ($@) {
    warn "Exception when calling SecurityApi->security_assesspermission: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commandname** | **string**| Name of the action or command to get the roles. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **security_assessrole**
> security_assessrole(roleid => $roleid)

Returns the list of permissions for a specific role

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SecurityApi;
my $api_instance = WWW::OpenAPIClient::SecurityApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $roleid = null; # string | Role ID to list the effective permissions.

eval { 
    $api_instance->security_assessrole(roleid => $roleid);
};
if ($@) {
    warn "Exception when calling SecurityApi->security_assessrole: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**string**](.md)| Role ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **security_assessscope**
> security_assessscope(locationid => $locationid)

Returns the list of users for a specific user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SecurityApi;
my $api_instance = WWW::OpenAPIClient::SecurityApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $locationid = null; # string | Location ID to list the users with that scope.

eval { 
    $api_instance->security_assessscope(locationid => $locationid);
};
if ($@) {
    warn "Exception when calling SecurityApi->security_assessscope: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**string**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **security_assessuser**
> security_assessuser(userid => $userid)

Returns the list of permissions for a specific user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SecurityApi;
my $api_instance = WWW::OpenAPIClient::SecurityApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | User ID to list the effective permissions.

eval { 
    $api_instance->security_assessuser(userid => $userid);
};
if ($@) {
    warn "Exception when calling SecurityApi->security_assessuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| User ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

