using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventregApi
    {
        /// <summary>
        /// Register current user to a course Allows the user to make themselves available for individual courses.
        /// </summary>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="listname">The name of the list where the user has to be registered.</param>
        /// <returns></returns>
        void EventregAddme (Guid? eventid, string listname);
        /// <summary>
        /// Register current user to all courses Allows the user to make themselves available for all courses.
        /// </summary>
        /// <param name="listname">The name of the list where the user has to be registered.</param>
        /// <returns></returns>
        void EventregAddmetoall (string listname);
        /// <summary>
        /// Register current user to a course group Allows the user to make themselves available for a course group.
        /// </summary>
        /// <param name="codegroup">The code used to group events.</param>
        /// <param name="listname">The name of the list where the user has to be registered.</param>
        /// <returns></returns>
        void EventregAddmetogroup (string codegroup, string listname);
        /// <summary>
        /// Register a user to a course for attendance Allows the user to register a user to a course.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="listname">The name of the list where the user has to be registered.</param>
        /// <returns></returns>
        void EventregAdduser (Guid? userid, Guid? eventid, string listname);
        /// <summary>
        /// Register a user to assist with all courses Allows the user to make a staff member available to assist with all courses.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="listname">The name of the list where the user has to be registered.</param>
        /// <returns></returns>
        void EventregAddusertoall (Guid? userid, string listname);
        /// <summary>
        /// Register a user to an course group Allows the user to make a staff member available for a course group.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="codegroup">The code used to group events.</param>
        /// <param name="listname">The name of the list where the user has to be registered.</param>
        /// <returns></returns>
        void EventregAddusertogroup (Guid? userid, string codegroup, string listname);
        /// <summary>
        /// View course registration by user Allows the user to view all courses a given user is registered to, provided they have permission to view that user.
        /// </summary>
        /// <param name="userid">The user id to list events.</param>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <param name="termid">The term id to list events.</param>
        /// <param name="namefilter">The value used to filter the events by name.</param>
        /// <returns></returns>
        void EventregGetevents (Guid? userid, string listname, Guid? termid, string namefilter);
        /// <summary>
        /// Lists the course group registrations of a user Allows the user to view the course groups a staff member is available for.
        /// </summary>
        /// <param name="userid">The user id to list events.</param>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregGetgroups (Guid? userid, string listname);
        /// <summary>
        /// View the event registrations of the current user 
        /// </summary>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <param name="termid">The term id to list events.</param>
        /// <param name="namefilter">The value used to filter the events by name.</param>
        /// <returns></returns>
        void EventregGetmyevents (string listname, Guid? termid, string namefilter);
        /// <summary>
        /// View all current user registrations to course groups Allows the user to view all his registrations to course groups.
        /// </summary>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregGetmygroups (string listname);
        /// <summary>
        /// View course registration Allows the user to view all users registered for an individual course.
        /// </summary>
        /// <param name="eventid">The event id to list users.</param>
        /// <param name="listname">The name of the list to get.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void EventregGetusers (Guid? eventid, string listname, int? photosize);
        /// <summary>
        /// Lists the registrations for a course group Allows the user the get the staff members registered to a specific course group
        /// </summary>
        /// <param name="codegroup">The code group to list users.</param>
        /// <param name="listname">The name of the list to get.</param>
        /// <returns></returns>
        void EventregGetusersfromgroup (Guid? codegroup, string listname);
        /// <summary>
        /// View the users that are registered to all courses Allows the user to view all staff members available for all courses.
        /// </summary>
        /// <param name="listname">The name of the list to get.</param>
        /// <returns></returns>
        void EventregGetuserstoall (string listname);
        /// <summary>
        /// Unregister current user from a course Allows the user to remove themselves from registration to a course.
        /// </summary>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregRemoveme (Guid? eventid, string listname);
        /// <summary>
        /// Remove current user from the registration to all courses Allows the user to remove themselves from availability to all courses.
        /// </summary>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregRemovemefromall (string listname);
        /// <summary>
        /// Remove current user from a course group Allows the user to remove themselves from availability to a course group.
        /// </summary>
        /// <param name="codegroup">The code group of the events/courses.</param>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregRemovemefromgroup (Guid? codegroup, string listname);
        /// <summary>
        /// Remove a user from a course Allows the user to remove a user from a course&#39;s registration.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregRemoveuser (Guid? userid, Guid? eventid, string listname);
        /// <summary>
        /// Remove a user from the registration to all courses Allows the user to remove a staff member from availability to all courses.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregRemoveuserfromall (Guid? userid, string listname);
        /// <summary>
        /// Remove a user from a course group Allows the user to remove a staff member from availability to a course group.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="codegroup">The code group of the events/courses.</param>
        /// <param name="listname">The name of the list where the user is registered.</param>
        /// <returns></returns>
        void EventregRemoveuserfromgroup (Guid? userid, Guid? codegroup, string listname);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventregApi : IEventregApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventregApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EventregApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventregApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventregApi(String basePath)
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
        /// Register current user to a course Allows the user to make themselves available for individual courses.
        /// </summary>
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="listname">The name of the list where the user has to be registered.</param> 
        /// <returns></returns>            
        public void EventregAddme (Guid? eventid, string listname)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling EventregAddme");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregAddme");
            
    
            var path = "/eventreg/addme";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddme: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddme: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register current user to all courses Allows the user to make themselves available for all courses.
        /// </summary>
        /// <param name="listname">The name of the list where the user has to be registered.</param> 
        /// <returns></returns>            
        public void EventregAddmetoall (string listname)
        {
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregAddmetoall");
            
    
            var path = "/eventreg/addmetoall";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddmetoall: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddmetoall: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register current user to a course group Allows the user to make themselves available for a course group.
        /// </summary>
        /// <param name="codegroup">The code used to group events.</param> 
        /// <param name="listname">The name of the list where the user has to be registered.</param> 
        /// <returns></returns>            
        public void EventregAddmetogroup (string codegroup, string listname)
        {
            
            // verify the required parameter 'codegroup' is set
            if (codegroup == null) throw new ApiException(400, "Missing required parameter 'codegroup' when calling EventregAddmetogroup");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregAddmetogroup");
            
    
            var path = "/eventreg/addmetogroup";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (codegroup != null) queryParams.Add("codegroup", ApiClient.ParameterToString(codegroup)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddmetogroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddmetogroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register a user to a course for attendance Allows the user to register a user to a course.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="listname">The name of the list where the user has to be registered.</param> 
        /// <returns></returns>            
        public void EventregAdduser (Guid? userid, Guid? eventid, string listname)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregAdduser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling EventregAdduser");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregAdduser");
            
    
            var path = "/eventreg/adduser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAdduser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAdduser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register a user to assist with all courses Allows the user to make a staff member available to assist with all courses.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="listname">The name of the list where the user has to be registered.</param> 
        /// <returns></returns>            
        public void EventregAddusertoall (Guid? userid, string listname)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregAddusertoall");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregAddusertoall");
            
    
            var path = "/eventreg/addusertoall";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddusertoall: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddusertoall: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register a user to an course group Allows the user to make a staff member available for a course group.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="codegroup">The code used to group events.</param> 
        /// <param name="listname">The name of the list where the user has to be registered.</param> 
        /// <returns></returns>            
        public void EventregAddusertogroup (Guid? userid, string codegroup, string listname)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregAddusertogroup");
            
            // verify the required parameter 'codegroup' is set
            if (codegroup == null) throw new ApiException(400, "Missing required parameter 'codegroup' when calling EventregAddusertogroup");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregAddusertogroup");
            
    
            var path = "/eventreg/addusertogroup";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (codegroup != null) queryParams.Add("codegroup", ApiClient.ParameterToString(codegroup)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddusertogroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregAddusertogroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View course registration by user Allows the user to view all courses a given user is registered to, provided they have permission to view that user.
        /// </summary>
        /// <param name="userid">The user id to list events.</param> 
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <param name="termid">The term id to list events.</param> 
        /// <param name="namefilter">The value used to filter the events by name.</param> 
        /// <returns></returns>            
        public void EventregGetevents (Guid? userid, string listname, Guid? termid, string namefilter)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregGetevents");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregGetevents");
            
    
            var path = "/eventreg/getevents";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
 if (termid != null) queryParams.Add("termid", ApiClient.ParameterToString(termid)); // query parameter
 if (namefilter != null) queryParams.Add("namefilter", ApiClient.ParameterToString(namefilter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetevents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetevents: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the course group registrations of a user Allows the user to view the course groups a staff member is available for.
        /// </summary>
        /// <param name="userid">The user id to list events.</param> 
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregGetgroups (Guid? userid, string listname)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregGetgroups");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregGetgroups");
            
    
            var path = "/eventreg/getgroups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetgroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetgroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the event registrations of the current user 
        /// </summary>
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <param name="termid">The term id to list events.</param> 
        /// <param name="namefilter">The value used to filter the events by name.</param> 
        /// <returns></returns>            
        public void EventregGetmyevents (string listname, Guid? termid, string namefilter)
        {
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregGetmyevents");
            
    
            var path = "/eventreg/getmyevents";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
 if (termid != null) queryParams.Add("termid", ApiClient.ParameterToString(termid)); // query parameter
 if (namefilter != null) queryParams.Add("namefilter", ApiClient.ParameterToString(namefilter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetmyevents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetmyevents: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all current user registrations to course groups Allows the user to view all his registrations to course groups.
        /// </summary>
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregGetmygroups (string listname)
        {
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregGetmygroups");
            
    
            var path = "/eventreg/getmygroups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetmygroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetmygroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View course registration Allows the user to view all users registered for an individual course.
        /// </summary>
        /// <param name="eventid">The event id to list users.</param> 
        /// <param name="listname">The name of the list to get.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void EventregGetusers (Guid? eventid, string listname, int? photosize)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling EventregGetusers");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregGetusers");
            
    
            var path = "/eventreg/getusers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetusers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetusers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the registrations for a course group Allows the user the get the staff members registered to a specific course group
        /// </summary>
        /// <param name="codegroup">The code group to list users.</param> 
        /// <param name="listname">The name of the list to get.</param> 
        /// <returns></returns>            
        public void EventregGetusersfromgroup (Guid? codegroup, string listname)
        {
            
            // verify the required parameter 'codegroup' is set
            if (codegroup == null) throw new ApiException(400, "Missing required parameter 'codegroup' when calling EventregGetusersfromgroup");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregGetusersfromgroup");
            
    
            var path = "/eventreg/getusersfromgroup";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (codegroup != null) queryParams.Add("codegroup", ApiClient.ParameterToString(codegroup)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetusersfromgroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetusersfromgroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the users that are registered to all courses Allows the user to view all staff members available for all courses.
        /// </summary>
        /// <param name="listname">The name of the list to get.</param> 
        /// <returns></returns>            
        public void EventregGetuserstoall (string listname)
        {
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregGetuserstoall");
            
    
            var path = "/eventreg/getuserstoall";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetuserstoall: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregGetuserstoall: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Unregister current user from a course Allows the user to remove themselves from registration to a course.
        /// </summary>
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregRemoveme (Guid? eventid, string listname)
        {
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling EventregRemoveme");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregRemoveme");
            
    
            var path = "/eventreg/removeme";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveme: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveme: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove current user from the registration to all courses Allows the user to remove themselves from availability to all courses.
        /// </summary>
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregRemovemefromall (string listname)
        {
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregRemovemefromall");
            
    
            var path = "/eventreg/removemefromall";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemovemefromall: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemovemefromall: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove current user from a course group Allows the user to remove themselves from availability to a course group.
        /// </summary>
        /// <param name="codegroup">The code group of the events/courses.</param> 
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregRemovemefromgroup (Guid? codegroup, string listname)
        {
            
            // verify the required parameter 'codegroup' is set
            if (codegroup == null) throw new ApiException(400, "Missing required parameter 'codegroup' when calling EventregRemovemefromgroup");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregRemovemefromgroup");
            
    
            var path = "/eventreg/removemefromgroup";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (codegroup != null) queryParams.Add("codegroup", ApiClient.ParameterToString(codegroup)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemovemefromgroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemovemefromgroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a user from a course Allows the user to remove a user from a course&#39;s registration.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregRemoveuser (Guid? userid, Guid? eventid, string listname)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregRemoveuser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling EventregRemoveuser");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregRemoveuser");
            
    
            var path = "/eventreg/removeuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a user from the registration to all courses Allows the user to remove a staff member from availability to all courses.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregRemoveuserfromall (Guid? userid, string listname)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregRemoveuserfromall");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregRemoveuserfromall");
            
    
            var path = "/eventreg/removeuserfromall";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveuserfromall: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveuserfromall: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a user from a course group Allows the user to remove a staff member from availability to a course group.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="codegroup">The code group of the events/courses.</param> 
        /// <param name="listname">The name of the list where the user is registered.</param> 
        /// <returns></returns>            
        public void EventregRemoveuserfromgroup (Guid? userid, Guid? codegroup, string listname)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling EventregRemoveuserfromgroup");
            
            // verify the required parameter 'codegroup' is set
            if (codegroup == null) throw new ApiException(400, "Missing required parameter 'codegroup' when calling EventregRemoveuserfromgroup");
            
            // verify the required parameter 'listname' is set
            if (listname == null) throw new ApiException(400, "Missing required parameter 'listname' when calling EventregRemoveuserfromgroup");
            
    
            var path = "/eventreg/removeuserfromgroup";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (codegroup != null) queryParams.Add("codegroup", ApiClient.ParameterToString(codegroup)); // query parameter
 if (listname != null) queryParams.Add("listname", ApiClient.ParameterToString(listname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveuserfromgroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventregRemoveuserfromgroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
