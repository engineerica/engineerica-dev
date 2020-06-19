# TemplateApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**templateAddimage**](TemplateApi.md#templateAddimage) | **GET** /template/addimage | Add an image to a template
[**templateDelete**](TemplateApi.md#templateDelete) | **DELETE** /template/{id} | Delete a template
[**templateEmail**](TemplateApi.md#templateEmail) | **GET** /template/email | Send generated templates by email
[**templateGenerate**](TemplateApi.md#templateGenerate) | **GET** /template/generate | Generate specified templates
[**templateGet**](TemplateApi.md#templateGet) | **GET** /template/{id} | View details of a template
[**templateGetgenerated**](TemplateApi.md#templateGetgenerated) | **GET** /template/getgenerated | View generated templates
[**templateList**](TemplateApi.md#templateList) | **GET** /template/list | View a list of defined templates
[**templateListsources**](TemplateApi.md#templateListsources) | **GET** /template/listsources | View a list of templates&#39; data sources
[**templateSave**](TemplateApi.md#templateSave) | **POST** /template/{id} | Create or edit a template
[**templateSavelayout**](TemplateApi.md#templateSavelayout) | **POST** /template/savelayout | Save the layout of a template


<a name="templateAddimage"></a>
# **templateAddimage**
> templateAddimage(template, upload, filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    UUID template = new UUID(); // UUID | The id of the template where the image has to be added
    String upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
    String filename = "filename_example"; // String | The local name of the uploaded file. For later reference.
    try {
      apiInstance.templateAddimage(template, upload, filename);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateAddimage");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**UUID**](.md)| The id of the template where the image has to be added |
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateDelete"></a>
# **templateDelete**
> templateDelete(id, body)

Delete a template

Allows the user to delete an existing template.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the template to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.templateDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateDelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The id of the template to delete. |
 **body** | **oas_any_type_not_mapped**|  | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateEmail"></a>
# **templateEmail**
> templateEmail(jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    String jobid = "jobid_example"; // String | The id of the job that is creating the templates.
    String emailsubject = "emailsubject_example"; // String | Args depending on the send-to flag.
    String emailbody = "emailbody_example"; // String | Args depending on the send-to flag.
    String templatekind = "templatekind_example"; // String | The kind of the template you're sending. It must be included in (badge, certificate).
    String emailfrom = "emailfrom_example"; // String | The name of the sender to be displayed in the receipients inbox
    String emailreplyto = "emailreplyto_example"; // String | The reply-to field for the emails.
    try {
      apiInstance.templateEmail(jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateEmail");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| The id of the job that is creating the templates. |
 **emailsubject** | **String**| Args depending on the send-to flag. |
 **emailbody** | **String**| Args depending on the send-to flag. |
 **templatekind** | **String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional]
 **emailfrom** | **String**| The name of the sender to be displayed in the receipients inbox | [optional]
 **emailreplyto** | **String**| The reply-to field for the emails. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateGenerate"></a>
# **templateGenerate**
> templateGenerate(template, source, singlefile, userid, forsending, role, filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    UUID template = new UUID(); // UUID | The id of the template to generate.
    UUID source = new UUID(); // UUID | The source key of the selected template data source.
    Boolean singlefile = true; // Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
    String userid = "userid_example"; // String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
    Boolean forsending = true; // Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
    UUID role = new UUID(); // UUID | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
    String filters = "filters_example"; // String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
    try {
      apiInstance.templateGenerate(template, source, singlefile, userid, forsending, role, filters);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateGenerate");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**UUID**](.md)| The id of the template to generate. |
 **source** | [**UUID**](.md)| The source key of the selected template data source. |
 **singlefile** | **Boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. |
 **userid** | **String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional]
 **forsending** | **Boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional]
 **role** | [**UUID**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional]
 **filters** | **String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateGet"></a>
# **templateGet**
> templateGet(id)

View details of a template

Allows the user to view a template and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the template to get.
    try {
      apiInstance.templateGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateGet");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The id of the template to get. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateGetgenerated"></a>
# **templateGetgenerated**
> templateGetgenerated(jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    String jobid = "jobid_example"; // String | The id of the job that is creating the templates.
    try {
      apiInstance.templateGetgenerated(jobid);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateGetgenerated");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| The id of the job that is creating the templates. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateList"></a>
# **templateList**
> templateList(from, count, kind, designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
    Boolean designedonly = true; // Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
    try {
      apiInstance.templateList(from, count, kind, designedonly);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateList");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). |
 **designedonly** | **Boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateListsources"></a>
# **templateListsources**
> templateListsources(kind)

View a list of templates&#39; data sources

Allows the user to see tokens to be used in the template

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    String kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
    try {
      apiInstance.templateListsources(kind);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateListsources");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateSave"></a>
# **templateSave**
> templateSave(id, UNKNOWN_BASE_TYPE)

Create or edit a template

Allows the user to create or edit a template.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the template to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.templateSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateSave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The id of the template to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateSavelayout"></a>
# **templateSavelayout**
> templateSavelayout(UNKNOWN_BASE_TYPE)

Save the layout of a template

Allows the user to edit a template&#39;s layout.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TemplateApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TemplateApi apiInstance = new TemplateApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.templateSavelayout(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling TemplateApi#templateSavelayout");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

