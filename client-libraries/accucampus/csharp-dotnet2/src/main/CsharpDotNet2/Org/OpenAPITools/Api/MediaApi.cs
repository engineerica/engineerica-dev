using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMediaApi
    {
        /// <summary>
        /// Check in media item Allows the user to check in a media item.
        /// </summary>
        /// <param name="media">The id of the media item to checkin.</param>
        /// <param name="checkindate">The checkout date.</param>
        /// <param name="notes">The notes of the checkout.</param>
        /// <returns></returns>
        void MediaCheckin (Guid? media, DateTime? checkindate, string notes);
        /// <summary>
        /// Check out media item Allows the user to check out a media item.
        /// </summary>
        /// <param name="media">The id of the media item to checkout.</param>
        /// <param name="user">The id of the user that is checking the item out.</param>
        /// <param name="checkoutdate">The checkout date.</param>
        /// <param name="duedate">The date when the checkout is due.</param>
        /// <param name="staff">The id of the staff member related to the checkout.</param>
        /// <param name="_event">The id of the event related to the checkout.</param>
        /// <param name="notes">The notes of the checkout.</param>
        /// <returns></returns>
        void MediaCheckout (Guid? media, Guid? user, DateTime? checkoutdate, DateTime? duedate, Guid? staff, Guid? _event, string notes);
        /// <summary>
        /// View a list of past media checkouts Allows the user to view a list of all past checkouts
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="media">Used to filter the checkouts of a specific media item.</param>
        /// <param name="user">Used to filter the checkouts made by a specific user.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void MediaCheckoutlist (int? from, int? count, Guid? media, Guid? user, int? photosize);
        /// <summary>
        /// Delete a media item Allows the user to delete an existing media item.
        /// </summary>
        /// <param name="id">The id of the media item to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void MediaDelete (Guid? id, AnyType body);
        /// <summary>
        /// Delete a media checkout log Allows the user to delete a media item&#39;s checkout log.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void MediaDeletecheckoutlog (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Search and view details of a media item Allows the user to view an individual media item and its details.
        /// </summary>
        /// <param name="id">The id of the media item to get.</param>
        /// <returns></returns>
        void MediaGet (Guid? id);
        /// <summary>
        /// Search media item by unique code Allows the user to search for media items by their unique code.
        /// </summary>
        /// <param name="code">The code of the media item to get.</param>
        /// <param name="location">The location where to look for the media item.</param>
        /// <returns></returns>
        void MediaGetbycode (string code, Guid? location);
        /// <summary>
        /// View details of a media item checkout information Allows the user to view a media item&#39;s checkout information.
        /// </summary>
        /// <param name="id">The id of the media item whose checkout information has to be retrieved.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void MediaGetcheckout (Guid? id, int? photosize);
        /// <summary>
        /// View details of a media checkout log Allows the user to view a media item&#39;s checkout history.
        /// </summary>
        /// <param name="id">The id of the media item whose checkout information has to be retrieved.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void MediaGetcheckoutlog (Guid? id, int? photosize);
        /// <summary>
        /// View a list of media items Allows the user to view the list of all media items tied to locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="status">Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All).</param>
        /// <param name="user">Used to filter the media items that are checked-out by a specific user.</param>
        /// <returns></returns>
        void MediaList (int? from, int? count, int? status, Guid? user);
        /// <summary>
        /// Create or edit a media item Allows the user to create or edit a media item.
        /// </summary>
        /// <param name="id">The id of the media item save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void MediaSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MediaApi : IMediaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MediaApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MediaApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Check in media item Allows the user to check in a media item.
        /// </summary>
        /// <param name="media">The id of the media item to checkin.</param> 
        /// <param name="checkindate">The checkout date.</param> 
        /// <param name="notes">The notes of the checkout.</param> 
        /// <returns></returns>            
        public void MediaCheckin (Guid? media, DateTime? checkindate, string notes)
        {
            
            // verify the required parameter 'media' is set
            if (media == null) throw new ApiException(400, "Missing required parameter 'media' when calling MediaCheckin");
            
            // verify the required parameter 'checkindate' is set
            if (checkindate == null) throw new ApiException(400, "Missing required parameter 'checkindate' when calling MediaCheckin");
            
    
            var path = "/media/checkin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (media != null) queryParams.Add("media", ApiClient.ParameterToString(media)); // query parameter
 if (checkindate != null) queryParams.Add("checkindate", ApiClient.ParameterToString(checkindate)); // query parameter
 if (notes != null) queryParams.Add("notes", ApiClient.ParameterToString(notes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaCheckin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaCheckin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Check out media item Allows the user to check out a media item.
        /// </summary>
        /// <param name="media">The id of the media item to checkout.</param> 
        /// <param name="user">The id of the user that is checking the item out.</param> 
        /// <param name="checkoutdate">The checkout date.</param> 
        /// <param name="duedate">The date when the checkout is due.</param> 
        /// <param name="staff">The id of the staff member related to the checkout.</param> 
        /// <param name="_event">The id of the event related to the checkout.</param> 
        /// <param name="notes">The notes of the checkout.</param> 
        /// <returns></returns>            
        public void MediaCheckout (Guid? media, Guid? user, DateTime? checkoutdate, DateTime? duedate, Guid? staff, Guid? _event, string notes)
        {
            
            // verify the required parameter 'media' is set
            if (media == null) throw new ApiException(400, "Missing required parameter 'media' when calling MediaCheckout");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling MediaCheckout");
            
            // verify the required parameter 'checkoutdate' is set
            if (checkoutdate == null) throw new ApiException(400, "Missing required parameter 'checkoutdate' when calling MediaCheckout");
            
            // verify the required parameter 'duedate' is set
            if (duedate == null) throw new ApiException(400, "Missing required parameter 'duedate' when calling MediaCheckout");
            
    
            var path = "/media/checkout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (media != null) queryParams.Add("media", ApiClient.ParameterToString(media)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (staff != null) queryParams.Add("staff", ApiClient.ParameterToString(staff)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (checkoutdate != null) queryParams.Add("checkoutdate", ApiClient.ParameterToString(checkoutdate)); // query parameter
 if (duedate != null) queryParams.Add("duedate", ApiClient.ParameterToString(duedate)); // query parameter
 if (notes != null) queryParams.Add("notes", ApiClient.ParameterToString(notes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaCheckout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaCheckout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of past media checkouts Allows the user to view a list of all past checkouts
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="media">Used to filter the checkouts of a specific media item.</param> 
        /// <param name="user">Used to filter the checkouts made by a specific user.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void MediaCheckoutlist (int? from, int? count, Guid? media, Guid? user, int? photosize)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling MediaCheckoutlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling MediaCheckoutlist");
            
    
            var path = "/media/checkoutlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (media != null) queryParams.Add("media", ApiClient.ParameterToString(media)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaCheckoutlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaCheckoutlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a media item Allows the user to delete an existing media item.
        /// </summary>
        /// <param name="id">The id of the media item to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void MediaDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MediaDelete");
            
    
            var path = "/media/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a media checkout log Allows the user to delete a media item&#39;s checkout log.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void MediaDeletecheckoutlog (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/media/deletecheckoutlog";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaDeletecheckoutlog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaDeletecheckoutlog: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a media item Allows the user to view an individual media item and its details.
        /// </summary>
        /// <param name="id">The id of the media item to get.</param> 
        /// <returns></returns>            
        public void MediaGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MediaGet");
            
    
            var path = "/media/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search media item by unique code Allows the user to search for media items by their unique code.
        /// </summary>
        /// <param name="code">The code of the media item to get.</param> 
        /// <param name="location">The location where to look for the media item.</param> 
        /// <returns></returns>            
        public void MediaGetbycode (string code, Guid? location)
        {
            
            // verify the required parameter 'code' is set
            if (code == null) throw new ApiException(400, "Missing required parameter 'code' when calling MediaGetbycode");
            
    
            var path = "/media/getbycode";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (code != null) queryParams.Add("code", ApiClient.ParameterToString(code)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGetbycode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGetbycode: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a media item checkout information Allows the user to view a media item&#39;s checkout information.
        /// </summary>
        /// <param name="id">The id of the media item whose checkout information has to be retrieved.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void MediaGetcheckout (Guid? id, int? photosize)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MediaGetcheckout");
            
    
            var path = "/media/getcheckout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGetcheckout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGetcheckout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a media checkout log Allows the user to view a media item&#39;s checkout history.
        /// </summary>
        /// <param name="id">The id of the media item whose checkout information has to be retrieved.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void MediaGetcheckoutlog (Guid? id, int? photosize)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MediaGetcheckoutlog");
            
    
            var path = "/media/getcheckoutlog";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGetcheckoutlog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaGetcheckoutlog: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of media items Allows the user to view the list of all media items tied to locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="status">Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All).</param> 
        /// <param name="user">Used to filter the media items that are checked-out by a specific user.</param> 
        /// <returns></returns>            
        public void MediaList (int? from, int? count, int? status, Guid? user)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling MediaList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling MediaList");
            
    
            var path = "/media/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a media item Allows the user to create or edit a media item.
        /// </summary>
        /// <param name="id">The id of the media item save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void MediaSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MediaSave");
            
    
            var path = "/media/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MediaSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
