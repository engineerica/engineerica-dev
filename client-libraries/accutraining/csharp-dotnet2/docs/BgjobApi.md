# Org.OpenAPITools.Api.BgjobApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BgjobGetstatus**](BgjobApi.md#bgjobgetstatus) | **GET** /bgjob/getstatus | Get background job status


<a name="bgjobgetstatus"></a>
# **BgjobGetstatus**
> void BgjobGetstatus (Guid? jobid, string jobtype)

Get background job status

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BgjobGetstatusExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BgjobApi();
            var jobid = new Guid?(); // Guid? | The ID of the job to get the status. 10 most recent will be returned if not specified. (optional) 
            var jobtype = jobtype_example;  // string | The job type to filter by. (optional) 

            try
            {
                // Get background job status
                apiInstance.BgjobGetstatus(jobid, jobtype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BgjobApi.BgjobGetstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | [**Guid?**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **string**| The job type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

