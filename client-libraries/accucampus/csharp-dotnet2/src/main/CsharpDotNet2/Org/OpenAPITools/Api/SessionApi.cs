using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISessionApi
    {
        /// <summary>
        /// Bulk update event sessions Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
        /// </summary>
        /// <param name="eventid">The id of the event to bulk update.</param>
        /// <param name="sessions">A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.</param>
        /// <returns></returns>
        void SessionBulkupdate (Guid? eventid, string sessions);
        /// <summary>
        /// View details of a session Allows the user to view a session in order to take attendance.
        /// </summary>
        /// <param name="id">The id of the session to get.</param>
        /// <returns></returns>
        void SessionGet (Guid? id);
        /// <summary>
        /// Gets the schedule for a location, instructor or attendees 
        /// </summary>
        /// <param name="day">The day to return. It will also return the whole week for that day.</param>
        /// <param name="attendee">The id of the attendee to get the schedule.</param>
        /// <param name="location">The id of the location to get the schedule.</param>
        /// <param name="instructor">The id of the instructor to get the schedule.</param>
        /// <returns></returns>
        void SessionGetschedule (DateTime? day, Guid? attendee, Guid? location, Guid? instructor);
        /// <summary>
        /// Gets all future sessions of the current semester 
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="startdate">The start date to filter the sessions</param>
        /// <param name="enddate">The end date to filter the sessions.</param>
        /// <returns></returns>
        void SessionList (int? from, int? count, DateTime? startdate, DateTime? enddate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SessionApi : ISessionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SessionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionApi(String basePath)
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
        /// Bulk update event sessions Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
        /// </summary>
        /// <param name="eventid">The id of the event to bulk update.</param> 
        /// <param name="sessions">A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.</param> 
        /// <returns></returns>            
        public void SessionBulkupdate (Guid? eventid, string sessions)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionBulkupdate");
            
            // verify the required parameter 'sessions' is set
            if (sessions == null) throw new ApiException(400, "Missing required parameter 'sessions' when calling SessionBulkupdate");
            
    
            var path = "/session/bulkupdate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessions != null) queryParams.Add("sessions", ApiClient.ParameterToString(sessions)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionBulkupdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionBulkupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a session Allows the user to view a session in order to take attendance.
        /// </summary>
        /// <param name="id">The id of the session to get.</param> 
        /// <returns></returns>            
        public void SessionGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SessionGet");
            
    
            var path = "/session/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SessionGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the schedule for a location, instructor or attendees 
        /// </summary>
        /// <param name="day">The day to return. It will also return the whole week for that day.</param> 
        /// <param name="attendee">The id of the attendee to get the schedule.</param> 
        /// <param name="location">The id of the location to get the schedule.</param> 
        /// <param name="instructor">The id of the instructor to get the schedule.</param> 
        /// <returns></returns>            
        public void SessionGetschedule (DateTime? day, Guid? attendee, Guid? location, Guid? instructor)
        {
            
    
            var path = "/session/getschedule";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (day != null) queryParams.Add("day", ApiClient.ParameterToString(day)); // query parameter
 if (attendee != null) queryParams.Add("attendee", ApiClient.ParameterToString(attendee)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (instructor != null) queryParams.Add("instructor", ApiClient.ParameterToString(instructor)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionGetschedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionGetschedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets all future sessions of the current semester 
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="startdate">The start date to filter the sessions</param> 
        /// <param name="enddate">The end date to filter the sessions.</param> 
        /// <returns></returns>            
        public void SessionList (int? from, int? count, DateTime? startdate, DateTime? enddate)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling SessionList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling SessionList");
            
    
            var path = "/session/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
