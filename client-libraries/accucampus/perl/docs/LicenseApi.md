# WWW::OpenAPIClient::LicenseApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::LicenseApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**license_acceptagreement**](LicenseApi.md#license_acceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**license_getagreementstatus**](LicenseApi.md#license_getagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**license_getcurrent**](LicenseApi.md#license_getcurrent) | **GET** /license/getcurrent | Gets the current license information
[**license_renew**](LicenseApi.md#license_renew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuCampus subscription


# **license_acceptagreement**
> license_acceptagreement()

Accept the license agreement

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LicenseApi;
my $api_instance = WWW::OpenAPIClient::LicenseApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->license_acceptagreement();
};
if ($@) {
    warn "Exception when calling LicenseApi->license_acceptagreement: $@\n";
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

# **license_getagreementstatus**
> license_getagreementstatus()

Check if license agreement has been accepted

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LicenseApi;
my $api_instance = WWW::OpenAPIClient::LicenseApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->license_getagreementstatus();
};
if ($@) {
    warn "Exception when calling LicenseApi->license_getagreementstatus: $@\n";
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

# **license_getcurrent**
> license_getcurrent()

Gets the current license information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LicenseApi;
my $api_instance = WWW::OpenAPIClient::LicenseApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->license_getcurrent();
};
if ($@) {
    warn "Exception when calling LicenseApi->license_getcurrent: $@\n";
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

# **license_renew**
> license_renew(email => $email, phonenumber => $phonenumber, jobtitle => $jobtitle, institution => $institution, comments => $comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::LicenseApi;
my $api_instance = WWW::OpenAPIClient::LicenseApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $email = "email_example"; # string | The e-mail of the user sending the request.
my $phonenumber = "phonenumber_example"; # string | The phone number of the user sending the request.
my $jobtitle = "jobtitle_example"; # string | The job title of the user sending the request.
my $institution = "institution_example"; # string | The institution of the user sending the request.
my $comments = "comments_example"; # string | Comments entered by the user sending the request.

eval { 
    $api_instance->license_renew(email => $email, phonenumber => $phonenumber, jobtitle => $jobtitle, institution => $institution, comments => $comments);
};
if ($@) {
    warn "Exception when calling LicenseApi->license_renew: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The e-mail of the user sending the request. | 
 **phonenumber** | **string**| The phone number of the user sending the request. | 
 **jobtitle** | **string**| The job title of the user sending the request. | [optional] 
 **institution** | **string**| The institution of the user sending the request. | [optional] 
 **comments** | **string**| Comments entered by the user sending the request. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

