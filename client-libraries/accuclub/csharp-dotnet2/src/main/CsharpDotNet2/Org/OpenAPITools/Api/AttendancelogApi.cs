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
    public interface IAttendancelogApi
    {
        /// <summary>
        /// Delete an attendance log Allows the user to delete an existing attendance log.
        /// </summary>
        /// <param name="id">The id of the attendance log to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void AttendancelogDelete (Guid? id, AnyType body);
        /// <summary>
        /// Search and view details of an attendance log Allows the user to view an individual attendance log and its details.
        /// </summary>
        /// <param name="id">The id of the attendance log to get.</param>
        /// <returns></returns>
        void AttendancelogGet (Guid? id);
        /// <summary>
        /// Search and view details of an attendance log&#39;s swipe history Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
        /// </summary>
        /// <param name="id">The id of the attendance log to get.</param>
        /// <returns></returns>
        void AttendancelogGetchangehistory (Guid? id);
        /// <summary>
        /// View a list of attendance logs Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param>
        /// <param name="userid">The user ID of the user to get the logs.</param>
        /// <returns></returns>
        void AttendancelogList (int? from, int? count, string filter, Guid? userid);
        /// <summary>
        /// Gets the attendance logs of the current user 
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param>
        /// <returns></returns>
        void AttendancelogListmine (int? from, int? count, string filter);
        /// <summary>
        /// Create or edit an attendance log Allows the user to create or edit an attendance log.
        /// </summary>
        /// <param name="id">The id of the room to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void AttendancelogSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Sign out an attendance log Allows the user to sign out am attendance log from the Who&#39;s In page.
        /// </summary>
        /// <param name="id">The id of the attendance log to sign-out.</param>
        /// <param name="location">The id of the location to filter the users to sign out.</param>
        /// <param name="_event">The id of the event to filter the users to sign out.</param>
        /// <param name="datetime">Specifies the date and time when the specified logs have to be signed out.</param>
        /// <returns></returns>
        void AttendancelogSignout (Guid? id, Guid? location, Guid? _event, DateTime? datetime);
        /// <summary>
        /// View who&#39;s in a location Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="location">The id of the location to search for users that are in.</param>
        /// <param name="_event">The id of the event to search for users that are in.</param>
        /// <param name="sorting">Field to sort by. Either first-name, last-name or sign-in-time.</param>
        /// <param name="roles">The comma-separated list of ids of the roles to search for users that are in.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <param name="extensions">A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]).</param>
        /// <param name="export">True to export the results as CSV</param>
        /// <returns></returns>
        void AttendancelogWhosin (int? from, int? count, Guid? location, Guid? _event, string sorting, string roles, int? photosize, string extensions, bool? export);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttendancelogApi : IAttendancelogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendancelogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AttendancelogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendancelogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttendancelogApi(String basePath)
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
        /// Delete an attendance log Allows the user to delete an existing attendance log.
        /// </summary>
        /// <param name="id">The id of the attendance log to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void AttendancelogDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AttendancelogDelete");
            
    
            var path = "/attendancelog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an attendance log Allows the user to view an individual attendance log and its details.
        /// </summary>
        /// <param name="id">The id of the attendance log to get.</param> 
        /// <returns></returns>            
        public void AttendancelogGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AttendancelogGet");
            
    
            var path = "/attendancelog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an attendance log&#39;s swipe history Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
        /// </summary>
        /// <param name="id">The id of the attendance log to get.</param> 
        /// <returns></returns>            
        public void AttendancelogGetchangehistory (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AttendancelogGetchangehistory");
            
    
            var path = "/attendancelog/getchangehistory";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogGetchangehistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogGetchangehistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of attendance logs Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param> 
        /// <param name="userid">The user ID of the user to get the logs.</param> 
        /// <returns></returns>            
        public void AttendancelogList (int? from, int? count, string filter, Guid? userid)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling AttendancelogList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling AttendancelogList");
            
    
            var path = "/attendancelog/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the attendance logs of the current user 
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param> 
        /// <returns></returns>            
        public void AttendancelogListmine (int? from, int? count, string filter)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling AttendancelogListmine");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling AttendancelogListmine");
            
    
            var path = "/attendancelog/listmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogListmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogListmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit an attendance log Allows the user to create or edit an attendance log.
        /// </summary>
        /// <param name="id">The id of the room to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void AttendancelogSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AttendancelogSave");
            
    
            var path = "/attendancelog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sign out an attendance log Allows the user to sign out am attendance log from the Who&#39;s In page.
        /// </summary>
        /// <param name="id">The id of the attendance log to sign-out.</param> 
        /// <param name="location">The id of the location to filter the users to sign out.</param> 
        /// <param name="_event">The id of the event to filter the users to sign out.</param> 
        /// <param name="datetime">Specifies the date and time when the specified logs have to be signed out.</param> 
        /// <returns></returns>            
        public void AttendancelogSignout (Guid? id, Guid? location, Guid? _event, DateTime? datetime)
        {
            
    
            var path = "/attendancelog/signout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (datetime != null) queryParams.Add("datetime", ApiClient.ParameterToString(datetime)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogSignout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogSignout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View who&#39;s in a location Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="location">The id of the location to search for users that are in.</param> 
        /// <param name="_event">The id of the event to search for users that are in.</param> 
        /// <param name="sorting">Field to sort by. Either first-name, last-name or sign-in-time.</param> 
        /// <param name="roles">The comma-separated list of ids of the roles to search for users that are in.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <param name="extensions">A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]).</param> 
        /// <param name="export">True to export the results as CSV</param> 
        /// <returns></returns>            
        public void AttendancelogWhosin (int? from, int? count, Guid? location, Guid? _event, string sorting, string roles, int? photosize, string extensions, bool? export)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling AttendancelogWhosin");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling AttendancelogWhosin");
            
    
            var path = "/attendancelog/whosin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (sorting != null) queryParams.Add("sorting", ApiClient.ParameterToString(sorting)); // query parameter
 if (roles != null) queryParams.Add("roles", ApiClient.ParameterToString(roles)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
 if (extensions != null) queryParams.Add("extensions", ApiClient.ParameterToString(extensions)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogWhosin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AttendancelogWhosin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
