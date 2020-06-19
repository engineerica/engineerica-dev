# Org.OpenAPITools.Api.CompasscategoryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompasscategoryDelete**](CompasscategoryApi.md#compasscategorydelete) | **DELETE** /compasscategory/{id} | Delete a compass category
[**CompasscategoryGet**](CompasscategoryApi.md#compasscategoryget) | **GET** /compasscategory/{id} | View details of a compass category
[**CompasscategoryList**](CompasscategoryApi.md#compasscategorylist) | **GET** /compasscategory/list | View a list of compass categories
[**CompasscategorySave**](CompasscategoryApi.md#compasscategorysave) | **POST** /compasscategory/{id} | Create or edit a compass category


<a name="compasscategorydelete"></a>
# **CompasscategoryDelete**
> void CompasscategoryDelete (Guid? id, AnyType body)

Delete a compass category

Allows the user to delete an existing compass category.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategoryDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompasscategoryApi();
            var id = new Guid?(); // Guid? | The id of the category to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a compass category
                apiInstance.CompasscategoryDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompasscategoryApi.CompasscategoryDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the category to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compasscategoryget"></a>
# **CompasscategoryGet**
> void CompasscategoryGet (Guid? id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategoryGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompasscategoryApi();
            var id = new Guid?(); // Guid? | The id of the category to get.

            try
            {
                // View details of a compass category
                apiInstance.CompasscategoryGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompasscategoryApi.CompasscategoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the category to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compasscategorylist"></a>
# **CompasscategoryList**
> void CompasscategoryList (int? from, int? count, bool? onlywithservices)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategoryListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompasscategoryApi();
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var onlywithservices = true;  // bool? | Specified whether only categories with services are returned or all. (optional) 

            try
            {
                // View a list of compass categories
                apiInstance.CompasscategoryList(from, count, onlywithservices);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompasscategoryApi.CompasscategoryList: " + e.Message );
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
 **onlywithservices** | **bool?**| Specified whether only categories with services are returned or all. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compasscategorysave"></a>
# **CompasscategorySave**
> void CompasscategorySave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategorySaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompasscategoryApi();
            var id = new Guid?(); // Guid? | The id of the category save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a compass category
                apiInstance.CompasscategorySave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompasscategoryApi.CompasscategorySave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the category save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

