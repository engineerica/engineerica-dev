# WWW::OpenAPIClient::SocialgroupApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SocialgroupApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**socialgroup_addmembers**](SocialgroupApi.md#socialgroup_addmembers) | **GET** /socialgroup/addmembers | Adds new members to a group (which the user must own already)
[**socialgroup_delete**](SocialgroupApi.md#socialgroup_delete) | **DELETE** /socialgroup/{id} | Deletes a group
[**socialgroup_list**](SocialgroupApi.md#socialgroup_list) | **GET** /socialgroup/list | View all the groups the current user is in
[**socialgroup_listmembers**](SocialgroupApi.md#socialgroup_listmembers) | **GET** /socialgroup/listmembers | Lists the members of a group
[**socialgroup_removemembers**](SocialgroupApi.md#socialgroup_removemembers) | **GET** /socialgroup/removemembers | Removes members from a group (which the user must own already)
[**socialgroup_removemyself**](SocialgroupApi.md#socialgroup_removemyself) | **GET** /socialgroup/removemyself | Removes myself from an existent group
[**socialgroup_save**](SocialgroupApi.md#socialgroup_save) | **POST** /socialgroup/{id} | Saves a new group


# **socialgroup_addmembers**
> socialgroup_addmembers(id => $id, userids => $userids)

Adds new members to a group (which the user must own already)

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialgroupApi;
my $api_instance = WWW::OpenAPIClient::SocialgroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | ID of the group to add members to.
my $userids = "userids_example"; # string | Csv list of user Ids to add.

eval { 
    $api_instance->socialgroup_addmembers(id => $id, userids => $userids);
};
if ($@) {
    warn "Exception when calling SocialgroupApi->socialgroup_addmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| ID of the group to add members to. | 
 **userids** | **string**| Csv list of user Ids to add. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroup_delete**
> socialgroup_delete(id => $id, body => $body)

Deletes a group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialgroupApi;
my $api_instance = WWW::OpenAPIClient::SocialgroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | ID of the group to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->socialgroup_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling SocialgroupApi->socialgroup_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| ID of the group to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroup_list**
> socialgroup_list()

View all the groups the current user is in

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialgroupApi;
my $api_instance = WWW::OpenAPIClient::SocialgroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->socialgroup_list();
};
if ($@) {
    warn "Exception when calling SocialgroupApi->socialgroup_list: $@\n";
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

# **socialgroup_listmembers**
> socialgroup_listmembers(id => $id)

Lists the members of a group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialgroupApi;
my $api_instance = WWW::OpenAPIClient::SocialgroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | ID of the group to list members.

eval { 
    $api_instance->socialgroup_listmembers(id => $id);
};
if ($@) {
    warn "Exception when calling SocialgroupApi->socialgroup_listmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| ID of the group to list members. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroup_removemembers**
> socialgroup_removemembers(id => $id, userids => $userids)

Removes members from a group (which the user must own already)

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialgroupApi;
my $api_instance = WWW::OpenAPIClient::SocialgroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | ID of the group to remove members from.
my $userids = "userids_example"; # string | Csv list of user Ids to remove.

eval { 
    $api_instance->socialgroup_removemembers(id => $id, userids => $userids);
};
if ($@) {
    warn "Exception when calling SocialgroupApi->socialgroup_removemembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| ID of the group to remove members from. | 
 **userids** | **string**| Csv list of user Ids to remove. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroup_removemyself**
> socialgroup_removemyself(id => $id)

Removes myself from an existent group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialgroupApi;
my $api_instance = WWW::OpenAPIClient::SocialgroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | ID of the group to remove me from.

eval { 
    $api_instance->socialgroup_removemyself(id => $id);
};
if ($@) {
    warn "Exception when calling SocialgroupApi->socialgroup_removemyself: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| ID of the group to remove me from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroup_save**
> socialgroup_save(id => $id, unknown_base_type => $unknown_base_type)

Saves a new group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialgroupApi;
my $api_instance = WWW::OpenAPIClient::SocialgroupApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | ID of the group to update. Leave blank to create new.
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->socialgroup_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SocialgroupApi->socialgroup_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| ID of the group to update. Leave blank to create new. | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

