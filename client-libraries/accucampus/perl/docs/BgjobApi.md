# WWW::OpenAPIClient::BgjobApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::BgjobApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bgjob_getstatus**](BgjobApi.md#bgjob_getstatus) | **GET** /bgjob/getstatus | Get background job status


# **bgjob_getstatus**
> bgjob_getstatus(jobid => $jobid, jobtype => $jobtype)

Get background job status

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::BgjobApi;
my $api_instance = WWW::OpenAPIClient::BgjobApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $jobid = null; # string | The ID of the job to get the status. 10 most recent will be returned if not specified.
my $jobtype = "jobtype_example"; # string | The job type to filter by.

eval { 
    $api_instance->bgjob_getstatus(jobid => $jobid, jobtype => $jobtype);
};
if ($@) {
    warn "Exception when calling BgjobApi->bgjob_getstatus: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | [**string**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **string**| The job type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

