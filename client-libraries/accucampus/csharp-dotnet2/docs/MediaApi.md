# Org.OpenAPITools.Api.MediaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MediaCheckin**](MediaApi.md#mediacheckin) | **GET** /media/checkin | Check in media item
[**MediaCheckout**](MediaApi.md#mediacheckout) | **GET** /media/checkout | Check out media item
[**MediaCheckoutlist**](MediaApi.md#mediacheckoutlist) | **GET** /media/checkoutlist | View a list of past media checkouts
[**MediaDelete**](MediaApi.md#mediadelete) | **DELETE** /media/{id} | Delete a media item
[**MediaDeletecheckoutlog**](MediaApi.md#mediadeletecheckoutlog) | **DELETE** /media/deletecheckoutlog | Delete a media checkout log
[**MediaGet**](MediaApi.md#mediaget) | **GET** /media/{id} | Search and view details of a media item
[**MediaGetbycode**](MediaApi.md#mediagetbycode) | **GET** /media/getbycode | Search media item by unique code
[**MediaGetcheckout**](MediaApi.md#mediagetcheckout) | **GET** /media/getcheckout | View details of a media item checkout information
[**MediaGetcheckoutlog**](MediaApi.md#mediagetcheckoutlog) | **GET** /media/getcheckoutlog | View details of a media checkout log
[**MediaList**](MediaApi.md#medialist) | **GET** /media/list | View a list of media items
[**MediaSave**](MediaApi.md#mediasave) | **POST** /media/{id} | Create or edit a media item


<a name="mediacheckin"></a>
# **MediaCheckin**
> void MediaCheckin (Guid? media, DateTime? checkindate, string notes)

Check in media item

Allows the user to check in a media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaCheckinExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var media = new Guid?(); // Guid? | The id of the media item to checkin.
            var checkindate = 2013-10-20T19:20:30+01:00;  // DateTime? | The checkout date.
            var notes = notes_example;  // string | The notes of the checkout. (optional) 

            try
            {
                // Check in media item
                apiInstance.MediaCheckin(media, checkindate, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaCheckin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**Guid?**](.md)| The id of the media item to checkin. | 
 **checkindate** | **DateTime?**| The checkout date. | 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediacheckout"></a>
# **MediaCheckout**
> void MediaCheckout (Guid? media, Guid? user, DateTime? checkoutdate, DateTime? duedate, Guid? staff, Guid? _event, string notes)

Check out media item

Allows the user to check out a media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaCheckoutExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var media = new Guid?(); // Guid? | The id of the media item to checkout.
            var user = new Guid?(); // Guid? | The id of the user that is checking the item out.
            var checkoutdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The checkout date.
            var duedate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date when the checkout is due.
            var staff = new Guid?(); // Guid? | The id of the staff member related to the checkout. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event related to the checkout. (optional) 
            var notes = notes_example;  // string | The notes of the checkout. (optional) 

            try
            {
                // Check out media item
                apiInstance.MediaCheckout(media, user, checkoutdate, duedate, staff, _event, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**Guid?**](.md)| The id of the media item to checkout. | 
 **user** | [**Guid?**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **DateTime?**| The checkout date. | 
 **duedate** | **DateTime?**| The date when the checkout is due. | 
 **staff** | [**Guid?**](.md)| The id of the staff member related to the checkout. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediacheckoutlist"></a>
# **MediaCheckoutlist**
> void MediaCheckoutlist (int? from, int? count, Guid? media, Guid? user, int? photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaCheckoutlistExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var media = new Guid?(); // Guid? | Used to filter the checkouts of a specific media item. (optional) 
            var user = new Guid?(); // Guid? | Used to filter the checkouts made by a specific user. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View a list of past media checkouts
                apiInstance.MediaCheckoutlist(from, count, media, user, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaCheckoutlist: " + e.Message );
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
 **media** | [**Guid?**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**Guid?**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediadelete"></a>
# **MediaDelete**
> void MediaDelete (Guid? id, AnyType body)

Delete a media item

Allows the user to delete an existing media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var id = new Guid?(); // Guid? | The id of the media item to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a media item
                apiInstance.MediaDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the media item to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediadeletecheckoutlog"></a>
# **MediaDeletecheckoutlog**
> void MediaDeletecheckoutlog (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaDeletecheckoutlogExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete a media checkout log
                apiInstance.MediaDeletecheckoutlog(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaDeletecheckoutlog: " + e.Message );
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

<a name="mediaget"></a>
# **MediaGet**
> void MediaGet (Guid? id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var id = new Guid?(); // Guid? | The id of the media item to get.

            try
            {
                // Search and view details of a media item
                apiInstance.MediaGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the media item to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediagetbycode"></a>
# **MediaGetbycode**
> void MediaGetbycode (string code, Guid? location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaGetbycodeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var code = code_example;  // string | The code of the media item to get.
            var location = new Guid?(); // Guid? | The location where to look for the media item. (optional) 

            try
            {
                // Search media item by unique code
                apiInstance.MediaGetbycode(code, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaGetbycode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the media item to get. | 
 **location** | [**Guid?**](.md)| The location where to look for the media item. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediagetcheckout"></a>
# **MediaGetcheckout**
> void MediaGetcheckout (Guid? id, int? photosize)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaGetcheckoutExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var id = new Guid?(); // Guid? | The id of the media item whose checkout information has to be retrieved.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a media item checkout information
                apiInstance.MediaGetcheckout(id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaGetcheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediagetcheckoutlog"></a>
# **MediaGetcheckoutlog**
> void MediaGetcheckoutlog (Guid? id, int? photosize)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaGetcheckoutlogExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var id = new Guid?(); // Guid? | The id of the media item whose checkout information has to be retrieved.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a media checkout log
                apiInstance.MediaGetcheckoutlog(id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaGetcheckoutlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="medialist"></a>
# **MediaList**
> void MediaList (int? from, int? count, int? status, Guid? user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var status = 56;  // int? | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All). (optional) 
            var user = new Guid?(); // Guid? | Used to filter the media items that are checked-out by a specific user. (optional) 

            try
            {
                // View a list of media items
                apiInstance.MediaList(from, count, status, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaList: " + e.Message );
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
 **status** | **int?**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**Guid?**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediasave"></a>
# **MediaSave**
> void MediaSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a media item

Allows the user to create or edit a media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediaSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaApi();
            var id = new Guid?(); // Guid? | The id of the media item save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a media item
                apiInstance.MediaSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.MediaSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the media item save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

