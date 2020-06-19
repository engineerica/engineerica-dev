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
    public interface ISessionattendancelogApi
    {
        /// <summary>
        /// Add a note to a class attendance log Allows the user to add a note to a class attendance log.
        /// </summary>
        /// <param name="id">The id of the attendance log.</param>
        /// <param name="text">The text of the note to add.</param>
        /// <returns></returns>
        void SessionattendancelogAddnote (Guid? id, string text);
        /// <summary>
        /// View details of a class attendance log Allows the user to view an individual class attendance log and its details.
        /// </summary>
        /// <param name="id">The id of the attendance log to get.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void SessionattendancelogGet (Guid? id, int? photosize);
        /// <summary>
        /// View the class session attendance information for a specific user Allows the user to view the attendance for a specified student.
        /// </summary>
        /// <param name="attendee">The id of the attendee to get statistic for.</param>
        /// <param name="eventid">The id of the event whose attendee statistics have to be returned.</param>
        /// <returns></returns>
        void SessionattendancelogGetuser (Guid? attendee, Guid? eventid);
        /// <summary>
        /// View attendance logs of the specified session Allows the user to view the full list of logs from a specified session
        /// </summary>
        /// <param name="session">The id of the session whose attendees logs have to be returned.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void SessionattendancelogList (Guid? session, int? from, int? count, int? photosize);
        /// <summary>
        /// View the attendance information of an entire class Allows the user to view the attendance information for an entire class
        /// </summary>
        /// <param name="eventid">The id of the event whose attendance has to be returned.</param>
        /// <returns></returns>
        void SessionattendancelogListevent (Guid? eventid);
        /// <summary>
        /// View the attendance summary for a class and/or a attendee Allows the user to view the attendance summary for a given class and/or attendee.
        /// </summary>
        /// <param name="eventid">The id of the event whose attendance has to be returned.</param>
        /// <param name="attendeeid">The id of the attendee whose attendance has to be returned.</param>
        /// <param name="groupid">The id of the group whose attendance has to be returned.</param>
        /// <param name="start">The start date to filter (beginning of time by default).</param>
        /// <param name="end">The end date to filter (today by default).</param>
        /// <returns></returns>
        void SessionattendancelogListsummary (Guid? eventid, Guid? attendeeid, Guid? groupid, string start, string end);
        /// <summary>
        /// View my attendance summary Allows the user to view their own attendance summary.
        /// </summary>
        /// <param name="eventid">The id of the event whose attendance has to be returned.</param>
        /// <param name="start">The start date to filter (beginning of time by default).</param>
        /// <param name="end">The end date to filter (today by default).</param>
        /// <returns></returns>
        void SessionattendancelogMylistsummary (Guid? eventid, string start, string end);
        /// <summary>
        /// Create or edit a class attendance log Allows the user to create or edit a class attendance log.
        /// </summary>
        /// <param name="id">The id of the att log to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void SessionattendancelogSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Create or edit a class attendance log swipe Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void SessionattendancelogSaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SessionattendancelogApi : ISessionattendancelogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionattendancelogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SessionattendancelogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionattendancelogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionattendancelogApi(String basePath)
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
        /// Add a note to a class attendance log Allows the user to add a note to a class attendance log.
        /// </summary>
        /// <param name="id">The id of the attendance log.</param> 
        /// <param name="text">The text of the note to add.</param> 
        /// <returns></returns>            
        public void SessionattendancelogAddnote (Guid? id, string text)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SessionattendancelogAddnote");
            
            // verify the required parameter 'text' is set
            if (text == null) throw new ApiException(400, "Missing required parameter 'text' when calling SessionattendancelogAddnote");
            
    
            var path = "/sessionattendancelog/addnote";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (text != null) queryParams.Add("text", ApiClient.ParameterToString(text)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogAddnote: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogAddnote: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a class attendance log Allows the user to view an individual class attendance log and its details.
        /// </summary>
        /// <param name="id">The id of the attendance log to get.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void SessionattendancelogGet (Guid? id, int? photosize)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SessionattendancelogGet");
            
    
            var path = "/sessionattendancelog/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the class session attendance information for a specific user Allows the user to view the attendance for a specified student.
        /// </summary>
        /// <param name="attendee">The id of the attendee to get statistic for.</param> 
        /// <param name="eventid">The id of the event whose attendee statistics have to be returned.</param> 
        /// <returns></returns>            
        public void SessionattendancelogGetuser (Guid? attendee, Guid? eventid)
        {
            
            // verify the required parameter 'attendee' is set
            if (attendee == null) throw new ApiException(400, "Missing required parameter 'attendee' when calling SessionattendancelogGetuser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionattendancelogGetuser");
            
    
            var path = "/sessionattendancelog/getuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (attendee != null) queryParams.Add("attendee", ApiClient.ParameterToString(attendee)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogGetuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogGetuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View attendance logs of the specified session Allows the user to view the full list of logs from a specified session
        /// </summary>
        /// <param name="session">The id of the session whose attendees logs have to be returned.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void SessionattendancelogList (Guid? session, int? from, int? count, int? photosize)
        {
            
            // verify the required parameter 'session' is set
            if (session == null) throw new ApiException(400, "Missing required parameter 'session' when calling SessionattendancelogList");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling SessionattendancelogList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling SessionattendancelogList");
            
    
            var path = "/sessionattendancelog/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (session != null) queryParams.Add("session", ApiClient.ParameterToString(session)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the attendance information of an entire class Allows the user to view the attendance information for an entire class
        /// </summary>
        /// <param name="eventid">The id of the event whose attendance has to be returned.</param> 
        /// <returns></returns>            
        public void SessionattendancelogListevent (Guid? eventid)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionattendancelogListevent");
            
    
            var path = "/sessionattendancelog/listevent";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogListevent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogListevent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the attendance summary for a class and/or a attendee Allows the user to view the attendance summary for a given class and/or attendee.
        /// </summary>
        /// <param name="eventid">The id of the event whose attendance has to be returned.</param> 
        /// <param name="attendeeid">The id of the attendee whose attendance has to be returned.</param> 
        /// <param name="groupid">The id of the group whose attendance has to be returned.</param> 
        /// <param name="start">The start date to filter (beginning of time by default).</param> 
        /// <param name="end">The end date to filter (today by default).</param> 
        /// <returns></returns>            
        public void SessionattendancelogListsummary (Guid? eventid, Guid? attendeeid, Guid? groupid, string start, string end)
        {
            
    
            var path = "/sessionattendancelog/listsummary";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (attendeeid != null) queryParams.Add("attendeeid", ApiClient.ParameterToString(attendeeid)); // query parameter
 if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogListsummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogListsummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View my attendance summary Allows the user to view their own attendance summary.
        /// </summary>
        /// <param name="eventid">The id of the event whose attendance has to be returned.</param> 
        /// <param name="start">The start date to filter (beginning of time by default).</param> 
        /// <param name="end">The end date to filter (today by default).</param> 
        /// <returns></returns>            
        public void SessionattendancelogMylistsummary (Guid? eventid, string start, string end)
        {
            
    
            var path = "/sessionattendancelog/mylistsummary";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogMylistsummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogMylistsummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a class attendance log Allows the user to create or edit a class attendance log.
        /// </summary>
        /// <param name="id">The id of the att log to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void SessionattendancelogSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SessionattendancelogSave");
            
    
            var path = "/sessionattendancelog/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a class attendance log swipe Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void SessionattendancelogSaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/sessionattendancelog/saveswipe";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogSaveswipe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionattendancelogSaveswipe: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
