# WWW::OpenAPIClient::TemplateApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::TemplateApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**template_addimage**](TemplateApi.md#template_addimage) | **GET** /template/addimage | Add an image to a template
[**template_delete**](TemplateApi.md#template_delete) | **DELETE** /template/{id} | Delete a template
[**template_email**](TemplateApi.md#template_email) | **GET** /template/email | Send generated templates by email
[**template_generate**](TemplateApi.md#template_generate) | **GET** /template/generate | Generate specified templates
[**template_get**](TemplateApi.md#template_get) | **GET** /template/{id} | View details of a template
[**template_getgenerated**](TemplateApi.md#template_getgenerated) | **GET** /template/getgenerated | View generated templates
[**template_list**](TemplateApi.md#template_list) | **GET** /template/list | View a list of defined templates
[**template_listsources**](TemplateApi.md#template_listsources) | **GET** /template/listsources | View a list of templates&#39; data sources
[**template_save**](TemplateApi.md#template_save) | **POST** /template/{id} | Create or edit a template
[**template_savelayout**](TemplateApi.md#template_savelayout) | **POST** /template/savelayout | Save the layout of a template


# **template_addimage**
> template_addimage(template => $template, upload => $upload, filename => $filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $template = null; # string | The id of the template where the image has to be added
my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The local name of the uploaded file. For later reference.

eval { 
    $api_instance->template_addimage(template => $template, upload => $upload, filename => $filename);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_addimage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**string**](.md)| The id of the template where the image has to be added | 
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

# **template_delete**
> template_delete(id => $id, body => $body)

Delete a template

Allows the user to delete an existing template.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the template to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->template_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the template to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **template_email**
> template_email(jobid => $jobid, emailsubject => $emailsubject, emailbody => $emailbody, templatekind => $templatekind, emailfrom => $emailfrom, emailreplyto => $emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuTraining.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $jobid = "jobid_example"; # string | The id of the job that is creating the templates.
my $emailsubject = "emailsubject_example"; # string | Args depending on the send-to flag.
my $emailbody = "emailbody_example"; # string | Args depending on the send-to flag.
my $templatekind = "templatekind_example"; # string | The kind of the template you're sending. It must be included in (badge, certificate).
my $emailfrom = "emailfrom_example"; # string | The name of the sender to be displayed in the receipients inbox
my $emailreplyto = "emailreplyto_example"; # string | The reply-to field for the emails.

eval { 
    $api_instance->template_email(jobid => $jobid, emailsubject => $emailsubject, emailbody => $emailbody, templatekind => $templatekind, emailfrom => $emailfrom, emailreplyto => $emailreplyto);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_email: $@\n";
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

# **template_generate**
> template_generate(template => $template, source => $source, singlefile => $singlefile, userid => $userid, forsending => $forsending, role => $role, filters => $filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $template = null; # string | The id of the template to generate.
my $source = null; # string | The source key of the selected template data source.
my $singlefile = null; # boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
my $userid = "userid_example"; # string | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
my $forsending = null; # boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
my $role = null; # string | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
my $filters = "filters_example"; # string | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...

eval { 
    $api_instance->template_generate(template => $template, source => $source, singlefile => $singlefile, userid => $userid, forsending => $forsending, role => $role, filters => $filters);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_generate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**string**](.md)| The id of the template to generate. | 
 **source** | [**string**](.md)| The source key of the selected template data source. | 
 **singlefile** | **boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **string**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**string**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **string**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **template_get**
> template_get(id => $id)

View details of a template

Allows the user to view a template and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the template to get.

eval { 
    $api_instance->template_get(id => $id);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the template to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **template_getgenerated**
> template_getgenerated(jobid => $jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $jobid = "jobid_example"; # string | The id of the job that is creating the templates.

eval { 
    $api_instance->template_getgenerated(jobid => $jobid);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_getgenerated: $@\n";
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

# **template_list**
> template_list(from => $from, count => $count, kind => $kind, designedonly => $designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $kind = "kind_example"; # string | The kind of the templates to return. It must be included in (badge, certificate).
my $designedonly = null; # boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.

eval { 
    $api_instance->template_list(from => $from, count => $count, kind => $kind, designedonly => $designedonly);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **template_listsources**
> template_listsources(kind => $kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $kind = "kind_example"; # string | The kind of the templates to return. It must be included in (badge, certificate).

eval { 
    $api_instance->template_listsources(kind => $kind);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_listsources: $@\n";
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

# **template_save**
> template_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a template

Allows the user to create or edit a template.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the template to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->template_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the template to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **template_savelayout**
> template_savelayout(unknown_base_type => $unknown_base_type)

Save the layout of a template

Allows the user to edit a template's layout.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::TemplateApi;
my $api_instance = WWW::OpenAPIClient::TemplateApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->template_savelayout(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling TemplateApi->template_savelayout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

