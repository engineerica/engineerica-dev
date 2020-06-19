# Org.OpenAPITools.Api.DeadendrecordingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeadendrecordingDelete**](DeadendrecordingApi.md#deadendrecordingdelete) | **DELETE** /deadendrecording/delete | Deletes a dead-end record group
[**DeadendrecordingList**](DeadendrecordingApi.md#deadendrecordinglist) | **GET** /deadendrecording/list | Lists the recorded dead ends, if enabled
[**DeadendrecordingListcomments**](DeadendrecordingApi.md#deadendrecordinglistcomments) | **GET** /deadendrecording/listcomments | Lists the comments for a specific dead end
[**DeadendrecordingSave**](DeadendrecordingApi.md#deadendrecordingsave) | **POST** /deadendrecording/save | Saves a dead-end record


<a name="deadendrecordingdelete"></a>
# **DeadendrecordingDelete**
> void DeadendrecordingDelete (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordingDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeadendrecordingApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Deletes a dead-end record group
                apiInstance.DeadendrecordingDelete(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeadendrecordingApi.DeadendrecordingDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deadendrecordinglist"></a>
# **DeadendrecordingList**
> void DeadendrecordingList ()

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordingListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeadendrecordingApi();

            try
            {
                // Lists the recorded dead ends, if enabled
                apiInstance.DeadendrecordingList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeadendrecordingApi.DeadendrecordingList: " + e.Message );
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

<a name="deadendrecordinglistcomments"></a>
# **DeadendrecordingListcomments**
> void DeadendrecordingListcomments (string hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordingListcommentsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeadendrecordingApi();
            var hierarchykey = hierarchykey_example;  // string | The hierarchy key of the record to get the feedback.

            try
            {
                // Lists the comments for a specific dead end
                apiInstance.DeadendrecordingListcomments(hierarchykey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeadendrecordingApi.DeadendrecordingListcomments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hierarchykey** | **string**| The hierarchy key of the record to get the feedback. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deadendrecordingsave"></a>
# **DeadendrecordingSave**
> void DeadendrecordingSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a dead-end record

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordingSaveExample
    {
        public void main()
        {
            var apiInstance = new DeadendrecordingApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a dead-end record
                apiInstance.DeadendrecordingSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeadendrecordingApi.DeadendrecordingSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

