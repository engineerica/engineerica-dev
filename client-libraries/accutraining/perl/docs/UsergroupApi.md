# WWW::OpenAPIClient::UsergroupApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::UsergroupApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usergroup_addmember**](UsergroupApi.md#usergroup_addmember) | **GET** /usergroup/addmember | Add a user to a group
[**usergroup_delete**](UsergroupApi.md#usergroup_delete) | **DELETE** /usergroup/{id} | Delete a group
[**usergroup_get**](UsergroupApi.md#usergroup_get) | **GET** /usergroup/{id} | Search and view details of a user group
[**usergroup_getmembers**](UsergroupApi.md#usergroup_getmembers) | **GET** /usergroup/getmembers | View the members of a user group
[**usergroup_getuser**](UsergroupApi.md#usergroup_getuser) | **GET** /usergroup/getuser | View the groups which a user is registered to
[**usergroup_list**](UsergroupApi.md#usergroup_list) | **GET** /usergroup/list | View a list of user groups
[**usergroup_refresh**](UsergroupApi.md#usergroup_refresh) | **GET** /usergroup/refresh | Refresh the dynamic group
[**usergroup_removemember**](UsergroupApi.md#usergroup_removemember) | **GET** /usergroup/removemember | Remove a user from a group
[**usergroup_save**](UsergroupApi.md#usergroup_save) | **POST** /usergroup/{id} | Create or edit a group


# **usergroup_addmember**
> usergroup_addmember(userid => $userid, groupid => $groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to add.
my $groupid = null; # string | The id of the group.

eval { 
    $api_instance->usergroup_addmember(userid => $userid, groupid => $groupid);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_addmember: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to add. | 
 **groupid** | [**string**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_delete**
> usergroup_delete(id => $id, body => $body)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the group to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->usergroup_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the group to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_get**
> usergroup_get(id => $id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the user group to get.

eval { 
    $api_instance->usergroup_get(id => $id);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_getmembers**
> usergroup_getmembers(groupid => $groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $groupid = null; # string | The id of the user group to get.

eval { 
    $api_instance->usergroup_getmembers(groupid => $groupid);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_getmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | [**string**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_getuser**
> usergroup_getuser(userid => $userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to get his groups.

eval { 
    $api_instance->usergroup_getuser(userid => $userid);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_getuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to get his groups. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_list**
> usergroup_list(from => $from, count => $count, type => $type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $type = "type_example"; # string | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.

eval { 
    $api_instance->usergroup_list(from => $from, count => $count, type => $type);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **type** | **string**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_refresh**
> usergroup_refresh(group => $group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $group = null; # string | The ID of the group to refresh.

eval { 
    $api_instance->usergroup_refresh(group => $group);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_refresh: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**string**](.md)| The ID of the group to refresh. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_removemember**
> usergroup_removemember(userid => $userid, groupid => $groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to remove.
my $groupid = null; # string | The id of the group.

eval { 
    $api_instance->usergroup_removemember(userid => $userid, groupid => $groupid);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_removemember: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **groupid** | [**string**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroup_save**
> usergroup_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsergroupApi;
my $api_instance = WWW::OpenAPIClient::UsergroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the group to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usergroup_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UsergroupApi->usergroup_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the group to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

