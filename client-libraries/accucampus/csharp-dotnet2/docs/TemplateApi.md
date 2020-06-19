# Org.OpenAPITools.Api.TemplateApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplateAddimage**](TemplateApi.md#templateaddimage) | **GET** /template/addimage | Add an image to a template
[**TemplateDelete**](TemplateApi.md#templatedelete) | **DELETE** /template/{id} | Delete a template
[**TemplateEmail**](TemplateApi.md#templateemail) | **GET** /template/email | Send generated templates by email
[**TemplateGenerate**](TemplateApi.md#templategenerate) | **GET** /template/generate | Generate specified templates
[**TemplateGet**](TemplateApi.md#templateget) | **GET** /template/{id} | View details of a template
[**TemplateGetgenerated**](TemplateApi.md#templategetgenerated) | **GET** /template/getgenerated | View generated templates
[**TemplateList**](TemplateApi.md#templatelist) | **GET** /template/list | View a list of defined templates
[**TemplateListsources**](TemplateApi.md#templatelistsources) | **GET** /template/listsources | View a list of templates&#39; data sources
[**TemplateSave**](TemplateApi.md#templatesave) | **POST** /template/{id} | Create or edit a template
[**TemplateSavelayout**](TemplateApi.md#templatesavelayout) | **POST** /template/savelayout | Save the layout of a template


<a name="templateaddimage"></a>
# **TemplateAddimage**
> void TemplateAddimage (Guid? template, string upload, string filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateAddimageExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var template = new Guid?(); // Guid? | The id of the template where the image has to be added
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 

            try
            {
                // Add an image to a template
                apiInstance.TemplateAddimage(template, upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateAddimage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**Guid?**](.md)| The id of the template where the image has to be added | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatedelete"></a>
# **TemplateDelete**
> void TemplateDelete (Guid? id, AnyType body)

Delete a template

Allows the user to delete an existing template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var id = new Guid?(); // Guid? | The id of the template to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a template
                apiInstance.TemplateDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the template to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateemail"></a>
# **TemplateEmail**
> void TemplateEmail (string jobid, string emailsubject, string emailbody, string templatekind, string emailfrom, string emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateEmailExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var jobid = jobid_example;  // string | The id of the job that is creating the templates.
            var emailsubject = emailsubject_example;  // string | Args depending on the send-to flag.
            var emailbody = emailbody_example;  // string | Args depending on the send-to flag.
            var templatekind = templatekind_example;  // string | The kind of the template you're sending. It must be included in (badge, certificate). (optional) 
            var emailfrom = emailfrom_example;  // string | The name of the sender to be displayed in the receipients inbox (optional) 
            var emailreplyto = emailreplyto_example;  // string | The reply-to field for the emails. (optional) 

            try
            {
                // Send generated templates by email
                apiInstance.TemplateEmail(jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| The id of the job that is creating the templates. | 
 **emailsubject** | **string**| Args depending on the send-to flag. | 
 **emailbody** | **string**| Args depending on the send-to flag. | 
 **templatekind** | **string**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional] 
 **emailfrom** | **string**| The name of the sender to be displayed in the receipients inbox | [optional] 
 **emailreplyto** | **string**| The reply-to field for the emails. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templategenerate"></a>
# **TemplateGenerate**
> void TemplateGenerate (Guid? template, Guid? source, bool? singlefile, string userid, bool? forsending, Guid? role, string filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateGenerateExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var template = new Guid?(); // Guid? | The id of the template to generate.
            var source = new Guid?(); // Guid? | The source key of the selected template data source.
            var singlefile = true;  // bool? | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
            var userid = userid_example;  // string | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas. (optional) 
            var forsending = true;  // bool? | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading (optional) 
            var role = new Guid?(); // Guid? | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor (optional) 
            var filters = filters_example;  // string | Pipe separated filters for the generation, eg: aaa=val|bbb=val|... (optional) 

            try
            {
                // Generate specified templates
                apiInstance.TemplateGenerate(template, source, singlefile, userid, forsending, role, filters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateGenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**Guid?**](.md)| The id of the template to generate. | 
 **source** | [**Guid?**](.md)| The source key of the selected template data source. | 
 **singlefile** | **bool?**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **string**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **bool?**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**Guid?**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **string**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateget"></a>
# **TemplateGet**
> void TemplateGet (Guid? id)

View details of a template

Allows the user to view a template and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var id = new Guid?(); // Guid? | The id of the template to get.

            try
            {
                // View details of a template
                apiInstance.TemplateGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the template to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templategetgenerated"></a>
# **TemplateGetgenerated**
> void TemplateGetgenerated (string jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateGetgeneratedExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var jobid = jobid_example;  // string | The id of the job that is creating the templates.

            try
            {
                // View generated templates
                apiInstance.TemplateGetgenerated(jobid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateGetgenerated: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| The id of the job that is creating the templates. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatelist"></a>
# **TemplateList**
> void TemplateList (int? from, int? count, string kind, bool? designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var kind = kind_example;  // string | The kind of the templates to return. It must be included in (badge, certificate).
            var designedonly = true;  // bool? | If true then it only returns the templates that were designed. Otherwise, it returns all. (optional) 

            try
            {
                // View a list of defined templates
                apiInstance.TemplateList(from, count, kind, designedonly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateList: " + e.Message );
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
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **bool?**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatelistsources"></a>
# **TemplateListsources**
> void TemplateListsources (string kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateListsourcesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var kind = kind_example;  // string | The kind of the templates to return. It must be included in (badge, certificate).

            try
            {
                // View a list of templates' data sources
                apiInstance.TemplateListsources(kind);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateListsources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesave"></a>
# **TemplateSave**
> void TemplateSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a template

Allows the user to create or edit a template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var id = new Guid?(); // Guid? | The id of the template to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a template
                apiInstance.TemplateSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the template to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesavelayout"></a>
# **TemplateSavelayout**
> void TemplateSavelayout (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save the layout of a template

Allows the user to edit a template's layout.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateSavelayoutExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save the layout of a template
                apiInstance.TemplateSavelayout(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.TemplateSavelayout: " + e.Message );
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

