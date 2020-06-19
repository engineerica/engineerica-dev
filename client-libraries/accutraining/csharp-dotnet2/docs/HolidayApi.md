# Org.OpenAPITools.Api.HolidayApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HolidayList**](HolidayApi.md#holidaylist) | **GET** /holiday/list | View a list of entered holidays
[**HolidaySave**](HolidayApi.md#holidaysave) | **POST** /holiday/save | Create or edit a list of holidays
[**HolidaySuggest**](HolidayApi.md#holidaysuggest) | **GET** /holiday/suggest | View the holiday suggestions in the given term


<a name="holidaylist"></a>
# **HolidayList**
> void HolidayList (Guid? term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidayListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HolidayApi();
            var term = new Guid?(); // Guid? | The term to get holidays from.

            try
            {
                // View a list of entered holidays
                apiInstance.HolidayList(term);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HolidayApi.HolidayList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**Guid?**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="holidaysave"></a>
# **HolidaySave**
> void HolidaySave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaySaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HolidayApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a list of holidays
                apiInstance.HolidaySave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HolidayApi.HolidaySave: " + e.Message );
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

<a name="holidaysuggest"></a>
# **HolidaySuggest**
> void HolidaySuggest (Guid? term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaySuggestExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HolidayApi();
            var term = new Guid?(); // Guid? | The term to get holidays from.

            try
            {
                // View the holiday suggestions in the given term
                apiInstance.HolidaySuggest(term);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HolidayApi.HolidaySuggest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**Guid?**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

