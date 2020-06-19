# WWW::OpenAPIClient::EasyloginApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::EasyloginApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**easylogin_addbgimage**](EasyloginApi.md#easylogin_addbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login


# **easylogin_addbgimage**
> easylogin_addbgimage(upload => $upload, filename => $filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuClub account not using SSO.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EasyloginApi;
my $api_instance = WWW::OpenAPIClient::EasyloginApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The original filename, needed to process the file.

eval { 
    $api_instance->easylogin_addbgimage(upload => $upload, filename => $filename);
};
if ($@) {
    warn "Exception when calling EasyloginApi->easylogin_addbgimage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The original filename, needed to process the file. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

