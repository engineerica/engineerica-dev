# Org.OpenAPITools.Api.GeneralApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Changelog**](GeneralApi.md#changelog) | **GET** /changelog | Get the application change log
[**Doc**](GeneralApi.md#doc) | **GET** /doc | Get the documentation
[**Export**](GeneralApi.md#export) | **GET** /export | Export AccuCampus data
[**Import**](GeneralApi.md#import) | **GET** /import | Import data into AccuCampus
[**Listtimezones**](GeneralApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**Login**](GeneralApi.md#login) | **GET** /login | Login
[**Logout**](GeneralApi.md#logout) | **GET** /logout | Logout
[**Search**](GeneralApi.md#search) | **GET** /search | Search
[**Texttoimage**](GeneralApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**Version**](GeneralApi.md#version) | **GET** /version | Get current version information


<a name="changelog"></a>
# **Changelog**
> void Changelog ()

Get the application change log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChangelogExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralApi();

            try
            {
                // Get the application change log
                apiInstance.Changelog();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Changelog: " + e.Message );
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

<a name="doc"></a>
# **Doc**
> void Doc (bool? excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DocExample
    {
        public void main()
        {
            var apiInstance = new GeneralApi();
            var excludeanonymous = true;  // bool? | If true it excludes the anonymous actions from the returned list. (optional) 

            try
            {
                // Get the documentation
                apiInstance.Doc(excludeanonymous);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Doc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **bool?**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="export"></a>
# **Export**
> void Export (string exporttype, string exportformat, string filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExportExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralApi();
            var exporttype = exporttype_example;  // string | What to export.
            var exportformat = exportformat_example;  // string | The format of the resulting file. Valid types are CSV, HTML, XLS.
            var filters = filters_example;  // string | Pipe separated filters for the export, eg: aaa=val|bbb=val|... (optional) 

            try
            {
                // Export AccuCampus data
                apiInstance.Export(exporttype, exportformat, filters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Export: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exporttype** | **string**| What to export. | 
 **exportformat** | **string**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **string**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> void Import (string importtype, string upload, string filename, string parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ImportExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralApi();
            var importtype = importtype_example;  // string | The kind of data that is being uploaded.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 
            var parameters = parameters_example;  // string | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}. (optional) 

            try
            {
                // Import data into AccuCampus
                apiInstance.Import(importtype, upload, filename, parameters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **importtype** | **string**| The kind of data that is being uploaded. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **parameters** | **string**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtimezones"></a>
# **Listtimezones**
> void Listtimezones ()

Lists the available timezones

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListtimezonesExample
    {
        public void main()
        {
            var apiInstance = new GeneralApi();

            try
            {
                // Lists the available timezones
                apiInstance.Listtimezones();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Listtimezones: " + e.Message );
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

<a name="login"></a>
# **Login**
> void Login (string domain, string username, string password, string method, bool? rememberme)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            var apiInstance = new GeneralApi();
            var domain = domain_example;  // string | The account domain to login.
            var username = username_example;  // string | The username (email) of the user to login as.
            var password = password_example;  // string | The password of the user to login as.
            var method = method_example;  // string | The authentication method. Valid values are 'token' and 'cookie'.
            var rememberme = true;  // bool? | If true then the session will not expire. (optional) 

            try
            {
                // Login
                apiInstance.Login(domain, username, password, method, rememberme);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The account domain to login. | 
 **username** | **string**| The username (email) of the user to login as. | 
 **password** | **string**| The password of the user to login as. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **bool?**| If true then the session will not expire. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout ()

Logout

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralApi();

            try
            {
                // Logout
                apiInstance.Logout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Logout: " + e.Message );
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

<a name="search"></a>
# **Search**
> void Search (string query, int? page)

Search

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralApi();
            var query = query_example;  // string | The query to search for.
            var page = 56;  // int? | Current page to show, zero-based. (optional) 

            try
            {
                // Search
                apiInstance.Search(query, page);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| The query to search for. | 
 **page** | **int?**| Current page to show, zero-based. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="texttoimage"></a>
# **Texttoimage**
> void Texttoimage (string text, string fontcolor, int? fontsize, string direction, int? width)

Generates a dynamic image from text

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TexttoimageExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralApi();
            var text = text_example;  // string | The text to convert to an image, use double pipes (||) as a new line.
            var fontcolor = fontcolor_example;  // string | The color of the text, in hex format, without the #. (optional) 
            var fontsize = 56;  // int? | The size of the text, in points. (optional) 
            var direction = direction_example;  // string | Either vertical or horizontal, default horizontal. (optional) 
            var width = 56;  // int? | The image width in pixels (or height if the direction is vertical). (optional) 

            try
            {
                // Generates a dynamic image from text
                apiInstance.Texttoimage(text, fontcolor, fontsize, direction, width);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Texttoimage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **string**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **int?**| The size of the text, in points. | [optional] 
 **direction** | **string**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **int?**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="version"></a>
# **Version**
> void Version ()

Get current version information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VersionExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralApi();

            try
            {
                // Get current version information
                apiInstance.Version();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.Version: " + e.Message );
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

