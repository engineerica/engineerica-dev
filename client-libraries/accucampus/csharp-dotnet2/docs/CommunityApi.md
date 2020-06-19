# Org.OpenAPITools.Api.CommunityApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommunityInvite**](CommunityApi.md#communityinvite) | **GET** /community/invite | Sends an invitation to everyone to AccuCampus Communities
[**CommunityJoin**](CommunityApi.md#communityjoin) | **GET** /community/join | Sends an invitation for myself to AccuCampus Communities


<a name="communityinvite"></a>
# **CommunityInvite**
> void CommunityInvite ()

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CommunityInviteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityApi();

            try
            {
                // Sends an invitation to everyone to AccuCampus Communities
                apiInstance.CommunityInvite();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityApi.CommunityInvite: " + e.Message );
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

<a name="communityjoin"></a>
# **CommunityJoin**
> void CommunityJoin ()

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CommunityJoinExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityApi();

            try
            {
                // Sends an invitation for myself to AccuCampus Communities
                apiInstance.CommunityJoin();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityApi.CommunityJoin: " + e.Message );
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

