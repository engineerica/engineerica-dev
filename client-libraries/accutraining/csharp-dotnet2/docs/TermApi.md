# Org.OpenAPITools.Api.TermApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TermDelete**](TermApi.md#termdelete) | **DELETE** /term/{id} | Delete a term
[**TermGet**](TermApi.md#termget) | **GET** /term/{id} | Search and view details of a term
[**TermList**](TermApi.md#termlist) | **GET** /term/list | Search and view details of all terms
[**TermSave**](TermApi.md#termsave) | **POST** /term/{id} | Create and edit terms


<a name="termdelete"></a>
# **TermDelete**
> void TermDelete (Guid? id, AnyType body)

Delete a term

Allows the user to delete a term from the existing list.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TermApi();
            var id = new Guid?(); // Guid? | The id of the term to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a term
                apiInstance.TermDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TermApi.TermDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the term to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termget"></a>
# **TermGet**
> void TermGet (Guid? id)

Search and view details of a term

Allows the user to view a term and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TermApi();
            var id = new Guid?(); // Guid? | The id of the term to get.

            try
            {
                // Search and view details of a term
                apiInstance.TermGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TermApi.TermGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the term to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termlist"></a>
# **TermList**
> void TermList (int? from, int? count, bool? notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TermApi();
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var notpast = true;  // bool? | Specifies whether the terms in the past should be returned or not. (optional) 

            try
            {
                // Search and view details of all terms
                apiInstance.TermList(from, count, notpast);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TermApi.TermList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 
 **notpast** | **bool?**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termsave"></a>
# **TermSave**
> void TermSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create and edit terms

Allows the user to create and edit terms.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TermApi();
            var id = new Guid?(); // Guid? | The id of the term to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create and edit terms
                apiInstance.TermSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TermApi.TermSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the term to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

