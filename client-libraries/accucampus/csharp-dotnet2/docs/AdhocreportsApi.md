# Org.OpenAPITools.Api.AdhocreportsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdhocreportsReqaccess**](AdhocreportsApi.md#adhocreportsreqaccess) | **GET** /adhocreports/reqaccess | Request access to the ad-hoc reports


<a name="adhocreportsreqaccess"></a>
# **AdhocreportsReqaccess**
> void AdhocreportsReqaccess ()

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocreportsReqaccessExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocreportsApi();

            try
            {
                // Request access to the ad-hoc reports
                apiInstance.AdhocreportsReqaccess();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocreportsApi.AdhocreportsReqaccess: " + e.Message );
            }
        }
    }
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

