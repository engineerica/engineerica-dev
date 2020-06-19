# Org.OpenAPITools.Api.ClientApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientGet**](ClientApi.md#clientget) | **GET** /client/get | Get client
[**ClientList**](ClientApi.md#clientlist) | **GET** /client/list | Gets the clients of the specified conference
[**ClientSave**](ClientApi.md#clientsave) | **POST** /client/save | Saves a client
[**ClientSendmessage**](ClientApi.md#clientsendmessage) | **GET** /client/sendmessage | Send a message to a client


<a name="clientget"></a>
# **ClientGet**
> void ClientGet (string _client, string clientname)

Get client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientApi();
            var _client = _client_example;  // string | The unique id of the client.
            var clientname = clientname_example;  // string | The custom name of the client. (optional) 

            try
            {
                // Get client
                apiInstance.ClientGet(_client, clientname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApi.ClientGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_client** | **string**| The unique id of the client. | 
 **clientname** | **string**| The custom name of the client. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientlist"></a>
# **ClientList**
> void ClientList (int? from, int? count)

Gets the clients of the specified conference

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // Gets the clients of the specified conference
                apiInstance.ClientList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApi.ClientList: " + e.Message );
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

<a name="clientsave"></a>
# **ClientSave**
> void ClientSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a client
                apiInstance.ClientSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApi.ClientSave: " + e.Message );
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

<a name="clientsendmessage"></a>
# **ClientSendmessage**
> void ClientSendmessage (Guid? uniqueclientid, string message)

Send a message to a client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientSendmessageExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClientApi();
            var uniqueclientid = new Guid?(); // Guid? | The unique id of the client.
            var message = message_example;  // string | The body of the message to send.

            try
            {
                // Send a message to a client
                apiInstance.ClientSendmessage(uniqueclientid, message);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApi.ClientSendmessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueclientid** | [**Guid?**](.md)| The unique id of the client. | 
 **message** | **string**| The body of the message to send. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

