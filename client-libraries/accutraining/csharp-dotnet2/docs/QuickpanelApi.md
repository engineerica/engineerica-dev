# Org.OpenAPITools.Api.QuickpanelApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QuickpanelDeletewidget**](QuickpanelApi.md#quickpaneldeletewidget) | **DELETE** /quickpanel/deletewidget | Deletes a widget from the Quick Panel
[**QuickpanelFetchwidget**](QuickpanelApi.md#quickpanelfetchwidget) | **GET** /quickpanel/fetchwidget | Fetches the information for a specific widget.
[**QuickpanelGetwidget**](QuickpanelApi.md#quickpanelgetwidget) | **GET** /quickpanel/getwidget | View details of a widget included in the Quick Panel
[**QuickpanelInit**](QuickpanelApi.md#quickpanelinit) | **GET** /quickpanel/init | Returns the initial information required to show the quick panels
[**QuickpanelListwidgets**](QuickpanelApi.md#quickpanellistwidgets) | **GET** /quickpanel/listwidgets | Lists all the widgets that are added in the Quick Panel
[**QuickpanelListwidgettypes**](QuickpanelApi.md#quickpanellistwidgettypes) | **GET** /quickpanel/listwidgettypes | Lists all the widget types available in the system
[**QuickpanelReorderwidgets**](QuickpanelApi.md#quickpanelreorderwidgets) | **GET** /quickpanel/reorderwidgets | Reorders the widgets and moves them to a specific column
[**QuickpanelSavewidget**](QuickpanelApi.md#quickpanelsavewidget) | **POST** /quickpanel/savewidget | Saves a widget for the Quick Panel


<a name="quickpaneldeletewidget"></a>
# **QuickpanelDeletewidget**
> void QuickpanelDeletewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelDeletewidgetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Deletes a widget from the Quick Panel
                apiInstance.QuickpanelDeletewidget(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelDeletewidget: " + e.Message );
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

<a name="quickpanelfetchwidget"></a>
# **QuickpanelFetchwidget**
> void QuickpanelFetchwidget (Guid? widgetid)

Fetches the information for a specific widget.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelFetchwidgetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();
            var widgetid = new Guid?(); // Guid? | The ID of the data to fetch it's data.

            try
            {
                // Fetches the information for a specific widget.
                apiInstance.QuickpanelFetchwidget(widgetid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelFetchwidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **widgetid** | [**Guid?**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelgetwidget"></a>
# **QuickpanelGetwidget**
> void QuickpanelGetwidget (Guid? id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelGetwidgetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();
            var id = new Guid?(); // Guid? | The id of the widget to get.

            try
            {
                // View details of a widget included in the Quick Panel
                apiInstance.QuickpanelGetwidget(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelGetwidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the widget to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelinit"></a>
# **QuickpanelInit**
> void QuickpanelInit ()

Returns the initial information required to show the quick panels

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelInitExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();

            try
            {
                // Returns the initial information required to show the quick panels
                apiInstance.QuickpanelInit();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelInit: " + e.Message );
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

<a name="quickpanellistwidgets"></a>
# **QuickpanelListwidgets**
> void QuickpanelListwidgets ()

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelListwidgetsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();

            try
            {
                // Lists all the widgets that are added in the Quick Panel
                apiInstance.QuickpanelListwidgets();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelListwidgets: " + e.Message );
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

<a name="quickpanellistwidgettypes"></a>
# **QuickpanelListwidgettypes**
> void QuickpanelListwidgettypes ()

Lists all the widget types available in the system

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelListwidgettypesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();

            try
            {
                // Lists all the widget types available in the system
                apiInstance.QuickpanelListwidgettypes();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelListwidgettypes: " + e.Message );
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

<a name="quickpanelreorderwidgets"></a>
# **QuickpanelReorderwidgets**
> void QuickpanelReorderwidgets (string sectionname, string orderids)

Reorders the widgets and moves them to a specific column

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelReorderwidgetsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();
            var sectionname = sectionname_example;  // string | The section name where to sort the widgets.
            var orderids = orderids_example;  // string | CSV list of the widgets to reorder.

            try
            {
                // Reorders the widgets and moves them to a specific column
                apiInstance.QuickpanelReorderwidgets(sectionname, orderids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelReorderwidgets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sectionname** | **string**| The section name where to sort the widgets. | 
 **orderids** | **string**| CSV list of the widgets to reorder. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelsavewidget"></a>
# **QuickpanelSavewidget**
> void QuickpanelSavewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelSavewidgetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickpanelApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a widget for the Quick Panel
                apiInstance.QuickpanelSavewidget(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickpanelApi.QuickpanelSavewidget: " + e.Message );
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

