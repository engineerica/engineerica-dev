# WWW::OpenAPIClient::UserprofileApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::UserprofileApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userprofile_delete**](UserprofileApi.md#userprofile_delete) | **DELETE** /userprofile/{id} | Delete a user profile
[**userprofile_get**](UserprofileApi.md#userprofile_get) | **GET** /userprofile/{id} | View a specific user profile
[**userprofile_getallview**](UserprofileApi.md#userprofile_getallview) | **GET** /userprofile/getallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**userprofile_list**](UserprofileApi.md#userprofile_list) | **GET** /userprofile/list | View the list of user profiles
[**userprofile_listquestions**](UserprofileApi.md#userprofile_listquestions) | **GET** /userprofile/listquestions | Gets the list of all the available user questions
[**userprofile_preparestats**](UserprofileApi.md#userprofile_preparestats) | **GET** /userprofile/preparestats | Gets the statistics of a user group
[**userprofile_save**](UserprofileApi.md#userprofile_save) | **POST** /userprofile/{id} | Create or edit user profile questions
[**userprofile_saveanswers**](UserprofileApi.md#userprofile_saveanswers) | **POST** /userprofile/saveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.


# **userprofile_delete**
> userprofile_delete(id => $id, body => $body)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the user profile to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->userprofile_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the user profile to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofile_get**
> userprofile_get(id => $id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the profile question set.

eval { 
    $api_instance->userprofile_get(id => $id);
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the profile question set. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofile_getallview**
> userprofile_getallview(id => $id)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the user to view, or empty for current user.

eval { 
    $api_instance->userprofile_getallview(id => $id);
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_getallview: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofile_list**
> userprofile_list(from => $from, count => $count)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->userprofile_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofile_listquestions**
> userprofile_listquestions()

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->userprofile_listquestions();
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_listquestions: $@\n";
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

# **userprofile_preparestats**
> userprofile_preparestats(params => $params)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $params = "params_example"; # string | The ID of the group, specified as 'group=...'

eval { 
    $api_instance->userprofile_preparestats(params => $params);
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_preparestats: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **string**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofile_save**
> userprofile_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the profile question set.
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->userprofile_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the profile question set. | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofile_saveanswers**
> userprofile_saveanswers(unknown_base_type => $unknown_base_type)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserprofileApi;
my $api_instance = WWW::OpenAPIClient::UserprofileApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->userprofile_saveanswers(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UserprofileApi->userprofile_saveanswers: $@\n";
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

