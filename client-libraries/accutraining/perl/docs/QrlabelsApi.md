# WWW::OpenAPIClient::QrlabelsApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::QrlabelsApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrlabels_print**](QrlabelsApi.md#qrlabels_print) | **GET** /qrlabels/print | Print and email QR labels


# **qrlabels_print**
> qrlabels_print(user => $user, group => $group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QrlabelsApi;
my $api_instance = WWW::OpenAPIClient::QrlabelsApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $user = null; # string | The id of the user whose label needs to be printed.
my $group = null; # string | The id of the group whose members' labels need to be printed.

eval { 
    $api_instance->qrlabels_print(user => $user, group => $group);
};
if ($@) {
    warn "Exception when calling QrlabelsApi->qrlabels_print: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**string**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**string**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

