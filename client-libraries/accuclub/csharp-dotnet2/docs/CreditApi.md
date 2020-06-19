# Org.OpenAPITools.Api.CreditApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreditDelete**](CreditApi.md#creditdelete) | **DELETE** /credit/{id} | Delete a credit
[**CreditDiscountmethods**](CreditApi.md#creditdiscountmethods) | **GET** /credit/discountmethods | Gets the valid discount methods.
[**CreditGet**](CreditApi.md#creditget) | **GET** /credit/{id} | View details of assigned credit
[**CreditGetuserbalance**](CreditApi.md#creditgetuserbalance) | **GET** /credit/getuserbalance | Get the total amount of credits of the specified user
[**CreditList**](CreditApi.md#creditlist) | **GET** /credit/list | View a list of credits for a specific user
[**CreditListdetails**](CreditApi.md#creditlistdetails) | **GET** /credit/listdetails | Gets the credit usage details
[**CreditListmine**](CreditApi.md#creditlistmine) | **GET** /credit/listmine | View the list of credits of the current user
[**CreditSave**](CreditApi.md#creditsave) | **POST** /credit/{id} | Create or edit credit for a user
[**CreditSavedetails**](CreditApi.md#creditsavedetails) | **POST** /credit/savedetails | Create or edit credit details


<a name="creditdelete"></a>
# **CreditDelete**
> void CreditDelete (Guid? id, AnyType body)

Delete a credit

Allows the user to delete credits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var id = new Guid?(); // Guid? | The id of the credit to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a credit
                apiInstance.CreditDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the credit to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditdiscountmethods"></a>
# **CreditDiscountmethods**
> void CreditDiscountmethods ()

Gets the valid discount methods.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditDiscountmethodsExample
    {
        public void main()
        {
            var apiInstance = new CreditApi();

            try
            {
                // Gets the valid discount methods.
                apiInstance.CreditDiscountmethods();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditDiscountmethods: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditget"></a>
# **CreditGet**
> void CreditGet (Guid? id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var id = new Guid?(); // Guid? | The id of the credit to get.

            try
            {
                // View details of assigned credit
                apiInstance.CreditGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the credit to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditgetuserbalance"></a>
# **CreditGetuserbalance**
> void CreditGetuserbalance (Guid? user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditGetuserbalanceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var user = new Guid?(); // Guid? | The id of the user whose balance has to be returned.

            try
            {
                // Get the total amount of credits of the specified user
                apiInstance.CreditGetuserbalance(user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditGetuserbalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**Guid?**](.md)| The id of the user whose balance has to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditlist"></a>
# **CreditList**
> void CreditList (Guid? user, int? from, int? count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var user = new Guid?(); // Guid? | The id of the user.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of credits for a specific user
                apiInstance.CreditList(user, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**Guid?**](.md)| The id of the user. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditlistdetails"></a>
# **CreditListdetails**
> void CreditListdetails (Guid? credit, int? from, int? count)

Gets the credit usage details

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditListdetailsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var credit = new Guid?(); // Guid? | The id of the credit to look up for details.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // Gets the credit usage details
                apiInstance.CreditListdetails(credit, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditListdetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credit** | [**Guid?**](.md)| The id of the credit to look up for details. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditlistmine"></a>
# **CreditListmine**
> void CreditListmine (int? from, int? count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditListmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View the list of credits of the current user
                apiInstance.CreditListmine(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditListmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditsave"></a>
# **CreditSave**
> void CreditSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var id = new Guid?(); // Guid? | The id of the credit save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit credit for a user
                apiInstance.CreditSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the credit save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditsavedetails"></a>
# **CreditSavedetails**
> void CreditSavedetails (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit credit details

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditSavedetailsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit credit details
                apiInstance.CreditSavedetails(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreditSavedetails: " + e.Message );
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

