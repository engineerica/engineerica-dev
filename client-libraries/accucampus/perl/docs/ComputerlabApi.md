# WWW::OpenAPIClient::ComputerlabApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ComputerlabApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**computerlab_deletecomputer**](ComputerlabApi.md#computerlab_deletecomputer) | **DELETE** /computerlab/deletecomputer | Delete a computer
[**computerlab_getcomputer**](ComputerlabApi.md#computerlab_getcomputer) | **GET** /computerlab/getcomputer | Search and view details of a computer
[**computerlab_getsettings**](ComputerlabApi.md#computerlab_getsettings) | **GET** /computerlab/getsettings | Loads the settings for a computer lab
[**computerlab_issignedin**](ComputerlabApi.md#computerlab_issignedin) | **GET** /computerlab/issignedin | Gets whether a user is signed-in or not.
[**computerlab_listcomputers**](ComputerlabApi.md#computerlab_listcomputers) | **GET** /computerlab/listcomputers | View a list of computers
[**computerlab_listlabs**](ComputerlabApi.md#computerlab_listlabs) | **GET** /computerlab/listlabs | View a list of the locations that use the Computer Lab add-on
[**computerlab_liststations**](ComputerlabApi.md#computerlab_liststations) | **GET** /computerlab/liststations | View a list of sign-in stations available for computer labs.
[**computerlab_savecomputer**](ComputerlabApi.md#computerlab_savecomputer) | **POST** /computerlab/savecomputer | Create or edit a computer
[**computerlab_savesettings**](ComputerlabApi.md#computerlab_savesettings) | **POST** /computerlab/savesettings | Saves the settings for a computer lab
[**computerlab_saveswipe**](ComputerlabApi.md#computerlab_saveswipe) | **POST** /computerlab/saveswipe | Save a new swipe from a computer in a computer lab.


# **computerlab_deletecomputer**
> computerlab_deletecomputer(unknown_base_type => $unknown_base_type)

Delete a computer

Allows the user to delete an existing computer.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->computerlab_deletecomputer(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_deletecomputer: $@\n";
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

# **computerlab_getcomputer**
> computerlab_getcomputer(id => $id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = "id_example"; # string | The unique device id of the computer to get.

eval { 
    $api_instance->computerlab_getcomputer(id => $id);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_getcomputer: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The unique device id of the computer to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlab_getsettings**
> computerlab_getsettings(id => $id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(
);

my $id = null; # string | The id of the computer lab/location.

eval { 
    $api_instance->computerlab_getsettings(id => $id);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_getsettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the computer lab/location. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlab_issignedin**
> computerlab_issignedin(station => $station, user => $user)

Gets whether a user is signed-in or not.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->computerlab_issignedin(station => $station, user => $user);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_issignedin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlab_listcomputers**
> computerlab_listcomputers(from => $from, count => $count, location => $location, freeonly => $freeonly)

View a list of computers

Allows the user to view the list of all computers.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $location = null; # string | The id of the location whose computers have to be returned.
my $freeonly = null; # boolean | If true, only free computers will be returned.

eval { 
    $api_instance->computerlab_listcomputers(from => $from, count => $count, location => $location, freeonly => $freeonly);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_listcomputers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **location** | [**string**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **boolean**| If true, only free computers will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlab_listlabs**
> computerlab_listlabs()

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->computerlab_listlabs();
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_listlabs: $@\n";
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

# **computerlab_liststations**
> computerlab_liststations()

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->computerlab_liststations();
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_liststations: $@\n";
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

# **computerlab_savecomputer**
> computerlab_savecomputer(unknown_base_type => $unknown_base_type)

Create or edit a computer

Allows the user to create or edit a computer.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->computerlab_savecomputer(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_savecomputer: $@\n";
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

# **computerlab_savesettings**
> computerlab_savesettings(unknown_base_type => $unknown_base_type)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->computerlab_savesettings(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_savesettings: $@\n";
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

# **computerlab_saveswipe**
> computerlab_saveswipe(unknown_base_type => $unknown_base_type)

Save a new swipe from a computer in a computer lab.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ComputerlabApi;
my $api_instance = WWW::OpenAPIClient::ComputerlabApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->computerlab_saveswipe(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ComputerlabApi->computerlab_saveswipe: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

