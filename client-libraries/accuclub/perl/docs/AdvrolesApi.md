# WWW::OpenAPIClient::AdvrolesApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AdvrolesApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advroles_userlist**](AdvrolesApi.md#advroles_userlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.


# **advroles_userlist**
> advroles_userlist(from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize)

List users. Alias to user.list, use that one instead.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvrolesApi;
my $api_instance = WWW::OpenAPIClient::AdvrolesApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $roleid = null; # string | The id of the role to filter users by, or empty to return all users.
my $onlywithoutcard = "onlywithoutcard_example"; # string | If is 1 then only the users without a card are returned, otherwise all users are returned.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->advroles_userlist(from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling AdvrolesApi->advroles_userlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **roleid** | [**string**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

