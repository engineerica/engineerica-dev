# WWW::OpenAPIClient::AdvroleApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AdvroleApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advrole_addmissing**](AdvroleApi.md#advrole_addmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**advrole_checkperm**](AdvroleApi.md#advrole_checkperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
[**advrole_delete**](AdvroleApi.md#advrole_delete) | **DELETE** /advrole/{id} | Delete a role
[**advrole_deletemapping**](AdvroleApi.md#advrole_deletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
[**advrole_get**](AdvroleApi.md#advrole_get) | **GET** /advrole/{id} | View details of a role
[**advrole_list**](AdvroleApi.md#advrole_list) | **GET** /advrole/list | Lists the roles for the current account
[**advrole_listmaps**](AdvroleApi.md#advrole_listmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
[**advrole_listrolesmapped**](AdvroleApi.md#advrole_listrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
[**advrole_listtemplates**](AdvroleApi.md#advrole_listtemplates) | **GET** /advrole/listtemplates | View a list of role templates
[**advrole_save**](AdvroleApi.md#advrole_save) | **POST** /advrole/{id} | Create or edit a role
[**advrole_savemapping**](AdvroleApi.md#advrole_savemapping) | **POST** /advrole/savemapping | Saves a role mapping
[**advrole_userupgrade**](AdvroleApi.md#advrole_userupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)


# **advrole_addmissing**
> advrole_addmissing(roles => $roles, permissions => $permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $roles = "roles_example"; # string | CSV list of the role ids to check
my $permissions = "permissions_example"; # string | CSV list of the permissions to check

eval { 
    $api_instance->advrole_addmissing(roles => $roles, permissions => $permissions);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_addmissing: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **string**| CSV list of the role ids to check | 
 **permissions** | **string**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrole_checkperm**
> advrole_checkperm(roles => $roles, permissions => $permissions)

Checks the permissions are assigned for the given roles

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $roles = "roles_example"; # string | CSV list of the role ids to check
my $permissions = "permissions_example"; # string | CSV list of the permissions to check

eval { 
    $api_instance->advrole_checkperm(roles => $roles, permissions => $permissions);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_checkperm: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **string**| CSV list of the role ids to check | 
 **permissions** | **string**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrole_delete**
> advrole_delete(id => $id, body => $body)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the location to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->advrole_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_delete: $@\n";
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

# **advrole_deletemapping**
> advrole_deletemapping(unknown_base_type => $unknown_base_type)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->advrole_deletemapping(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_deletemapping: $@\n";
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

# **advrole_get**
> advrole_get(id => $id)

View details of a role

Allows the user to view a role and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the location to get.

eval { 
    $api_instance->advrole_get(id => $id);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_get: $@\n";
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

# **advrole_list**
> advrole_list(includepolicies => $includepolicies, includeinternal => $includeinternal, name => $name)

Lists the roles for the current account

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $includepolicies = null; # boolean | True to include the policies, defaults to false.
my $includeinternal = null; # boolean | True to include the internal roles too.
my $name = "name_example"; # string | Filter by name of the role.

eval { 
    $api_instance->advrole_list(includepolicies => $includepolicies, includeinternal => $includeinternal, name => $name);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includepolicies** | **boolean**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **boolean**| True to include the internal roles too. | [optional] 
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrole_listmaps**
> advrole_listmaps(roleid => $roleid)

Lists the maps a roles is mapped to

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $roleid = null; # string | The id of the role to list the maps.

eval { 
    $api_instance->advrole_listmaps(roleid => $roleid);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_listmaps: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**string**](.md)| The id of the role to list the maps. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrole_listrolesmapped**
> advrole_listrolesmapped(map => $map)

Lists the roles mappings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $map = "map_example"; # string | List only the roles in the specified map.

eval { 
    $api_instance->advrole_listrolesmapped(map => $map);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_listrolesmapped: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map** | **string**| List only the roles in the specified map. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrole_listtemplates**
> advrole_listtemplates()

View a list of role templates

Allows the user to view the full list of available role templates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->advrole_listtemplates();
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_listtemplates: $@\n";
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

# **advrole_save**
> advrole_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the role to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->advrole_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the role to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrole_savemapping**
> advrole_savemapping(unknown_base_type => $unknown_base_type)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->advrole_savemapping(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_savemapping: $@\n";
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

# **advrole_userupgrade**
> advrole_userupgrade(userid => $userid, roleid => $roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvroleApi;
my $api_instance = WWW::OpenAPIClient::AdvroleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | Id of the user to upgrade
my $roleid = null; # string | Id of the role to add

eval { 
    $api_instance->advrole_userupgrade(userid => $userid, roleid => $roleid);
};
if ($@) {
    warn "Exception when calling AdvroleApi->advrole_userupgrade: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| Id of the user to upgrade | 
 **roleid** | [**string**](.md)| Id of the role to add | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

