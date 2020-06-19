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
    public interface ISessionregApi
    {
        /// <summary>
        /// Register current user to an event session Allows the user to register themselves for an event.
        /// </summary>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void SessionregAddcurrentuser (Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// Register users for events Allows the user to register another user for an upcoming event.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void SessionregAdduser (Guid? userid, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// View all the sessions the logged user is registered to 
        /// </summary>
        /// <param name="date">Start date to filter the sessions.</param>
        /// <returns></returns>
        void SessionregGetmysessions (DateTime? date);
        /// <summary>
        /// Lists the registrations for a specific user Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.
        /// </summary>
        /// <param name="userid">The user id to list sessions.</param>
        /// <returns></returns>
        void SessionregGetsessions (Guid? userid);
        /// <summary>
        /// Get the settings for session registration Allows the user to view a event&#39;s session registration settings.
        /// </summary>
        /// <param name="locationid">The id of the location to save settings.</param>
        /// <param name="eventid">The id of the event to save settings.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <param name="noinherit">True to get the location/event/session specific settings without looking for the more global settings.</param>
        /// <returns></returns>
        void SessionregGetsettings (Guid? locationid, Guid? eventid, DateTime? sessiondate, bool? noinherit);
        /// <summary>
        /// Lists the registrations for a specific session Allows the user to view the registration for a specified event session.
        /// </summary>
        /// <param name="eventid">The event id to list sessions.</param>
        /// <param name="sessiondate">The date of the session to find.</param>
        /// <returns></returns>
        void SessionregGetusers (Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// List the sessions available for a specific event Allows the user to view all the sessions available for a recurring event.
        /// </summary>
        /// <param name="eventid">The event id to list sessions.</param>
        /// <param name="sessiondate">The date of the session to find.</param>
        /// <returns></returns>
        void SessionregListsessions (Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// View a list of upcoming event sessions Allows the user to view the full list of upcoming events.
        /// </summary>
        /// <param name="date">Only sessions in the week of the specified date will be returned.</param>
        /// <returns></returns>
        void SessionregListupcoming (DateTime? date);
        /// <summary>
        /// View a list of upcoming sessions of a particular event Allows the user to view the upcoming recurring sessions of a specified event.
        /// </summary>
        /// <param name="date">Start date to filter the returned sessions.</param>
        /// <param name="_event">The id of the event whose sessions will be returned</param>
        /// <returns></returns>
        void SessionregListupcomingevent (DateTime? date, Guid? _event);
        /// <summary>
        /// Unregister current user from an event session Allows the user to un-register themselves from an event.
        /// </summary>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void SessionregRemovecurrentuser (Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// Removes a user from an event session Allows the user to un-register another user from an event.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void SessionregRemoveuser (Guid? userid, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// Save the settings for an event&#39;s session registration Allows the user to save the settings for an event.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void SessionregSavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SessionregApi : ISessionregApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionregApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SessionregApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionregApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionregApi(String basePath)
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
        /// Register current user to an event session Allows the user to register themselves for an event.
        /// </summary>
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void SessionregAddcurrentuser (Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionregAddcurrentuser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling SessionregAddcurrentuser");
            
    
            var path = "/sessionreg/addcurrentuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregAddcurrentuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregAddcurrentuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register users for events Allows the user to register another user for an upcoming event.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void SessionregAdduser (Guid? userid, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling SessionregAdduser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionregAdduser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling SessionregAdduser");
            
    
            var path = "/sessionreg/adduser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregAdduser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregAdduser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the sessions the logged user is registered to 
        /// </summary>
        /// <param name="date">Start date to filter the sessions.</param> 
        /// <returns></returns>            
        public void SessionregGetmysessions (DateTime? date)
        {
            
    
            var path = "/sessionreg/getmysessions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetmysessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetmysessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the registrations for a specific user Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.
        /// </summary>
        /// <param name="userid">The user id to list sessions.</param> 
        /// <returns></returns>            
        public void SessionregGetsessions (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling SessionregGetsessions");
            
    
            var path = "/sessionreg/getsessions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetsessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetsessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the settings for session registration Allows the user to view a event&#39;s session registration settings.
        /// </summary>
        /// <param name="locationid">The id of the location to save settings.</param> 
        /// <param name="eventid">The id of the event to save settings.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <param name="noinherit">True to get the location/event/session specific settings without looking for the more global settings.</param> 
        /// <returns></returns>            
        public void SessionregGetsettings (Guid? locationid, Guid? eventid, DateTime? sessiondate, bool? noinherit)
        {
            
    
            var path = "/sessionreg/getsettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
 if (noinherit != null) queryParams.Add("noinherit", ApiClient.ParameterToString(noinherit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetsettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetsettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the registrations for a specific session Allows the user to view the registration for a specified event session.
        /// </summary>
        /// <param name="eventid">The event id to list sessions.</param> 
        /// <param name="sessiondate">The date of the session to find.</param> 
        /// <returns></returns>            
        public void SessionregGetusers (Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionregGetusers");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling SessionregGetusers");
            
    
            var path = "/sessionreg/getusers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetusers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregGetusers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List the sessions available for a specific event Allows the user to view all the sessions available for a recurring event.
        /// </summary>
        /// <param name="eventid">The event id to list sessions.</param> 
        /// <param name="sessiondate">The date of the session to find.</param> 
        /// <returns></returns>            
        public void SessionregListsessions (Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionregListsessions");
            
    
            var path = "/sessionreg/listsessions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregListsessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregListsessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of upcoming event sessions Allows the user to view the full list of upcoming events.
        /// </summary>
        /// <param name="date">Only sessions in the week of the specified date will be returned.</param> 
        /// <returns></returns>            
        public void SessionregListupcoming (DateTime? date)
        {
            
            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling SessionregListupcoming");
            
    
            var path = "/sessionreg/listupcoming";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregListupcoming: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregListupcoming: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of upcoming sessions of a particular event Allows the user to view the upcoming recurring sessions of a specified event.
        /// </summary>
        /// <param name="date">Start date to filter the returned sessions.</param> 
        /// <param name="_event">The id of the event whose sessions will be returned</param> 
        /// <returns></returns>            
        public void SessionregListupcomingevent (DateTime? date, Guid? _event)
        {
            
            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling SessionregListupcomingevent");
            
            // verify the required parameter '_event' is set
            if (_event == null) throw new ApiException(400, "Missing required parameter '_event' when calling SessionregListupcomingevent");
            
    
            var path = "/sessionreg/listupcomingevent";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregListupcomingevent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregListupcomingevent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Unregister current user from an event session Allows the user to un-register themselves from an event.
        /// </summary>
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void SessionregRemovecurrentuser (Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionregRemovecurrentuser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling SessionregRemovecurrentuser");
            
    
            var path = "/sessionreg/removecurrentuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregRemovecurrentuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregRemovecurrentuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a user from an event session Allows the user to un-register another user from an event.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void SessionregRemoveuser (Guid? userid, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling SessionregRemoveuser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling SessionregRemoveuser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling SessionregRemoveuser");
            
    
            var path = "/sessionreg/removeuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregRemoveuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregRemoveuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save the settings for an event&#39;s session registration Allows the user to save the settings for an event.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void SessionregSavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/sessionreg/savesettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregSavesettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SessionregSavesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
