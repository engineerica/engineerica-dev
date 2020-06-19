using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdvancedstationApi
    {
        /// <summary>
        /// Check whether the user is known by the system. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="user">The card of the user.</param>
        /// <param name="location">The id of the location the user picked.</param>
        /// <returns></returns>
        void AdvancedstationCheckunknownuser (Guid? station, string user, Guid? location);
        /// <summary>
        /// Check whether the user is a staff member, an attendee or both. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="user">The card of the user.</param>
        /// <param name="location">The id of the location the user picked.</param>
        /// <returns></returns>
        void AdvancedstationCheckuserrole (Guid? station, string user, Guid? location);
        /// <summary>
        /// Creates a user via a sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="user">The card of the user to create.</param>
        /// <param name="location">The id of the location the user picked.</param>
        /// <param name="firstname">The first name of the user to create.</param>
        /// <param name="lastname">The last name of the user to create.</param>
        /// <param name="email">The email of the user to create.</param>
        /// <param name="middlename">The middle name of the user to create.</param>
        /// <returns></returns>
        void AdvancedstationCreateuser (Guid? station, string user, Guid? location, string firstname, string lastname, string email, string middlename);
        /// <summary>
        /// Gets the courses available for a specific location and a specific student. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="location">The id of the location the student picked.</param>
        /// <param name="user">The card of the user.</param>
        /// <returns></returns>
        void AdvancedstationGetevents (Guid? station, Guid? location, string user);
        /// <summary>
        /// Gets the info to display in the sign-in station by it&#39;s ID. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param>
        /// <param name="_event">The id of the event (or session), to override the scheduled one.</param>
        /// <returns></returns>
        void AdvancedstationGetinfo (Guid? id, Guid? _event);
        /// <summary>
        /// Gets the locations available in a sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose locations have to be returned.</param>
        /// <param name="user">The card of the user.</param>
        /// <returns></returns>
        void AdvancedstationGetlocations (Guid? station, string user);
        /// <summary>
        /// Gets the staff/tutors available filtered by the location, course and services of the given attendance log. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="attendancelog">The id of the attendance log to filter the staff members.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void AdvancedstationGetlogstaff (Guid? station, Guid? attendancelog, int? photosize);
        /// <summary>
        /// Gets the user roles of the user trying to sign-in. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="signinrole">Specifies how the user is signing-in.</param>
        /// <param name="user">The card of the user.</param>
        /// <param name="location">The id of the location the user picked.</param>
        /// <returns></returns>
        void AdvancedstationGetroles (Guid? station, string signinrole, string user, Guid? location);
        /// <summary>
        /// Gets the services available for a specific location. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="location">The id of the location the student picked.</param>
        /// <param name="user">The card of the user.</param>
        /// <returns></returns>
        void AdvancedstationGetservices (Guid? station, Guid? location, string user);
        /// <summary>
        /// Gets the staff/tutors available for a specific location, course and service. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="locationid">The id of the location the student picked.</param>
        /// <param name="user">The card of the user.</param>
        /// <param name="services">The list of services selected by the user, in JSON format.</param>
        /// <param name="eventid">The ID of the event selected.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void AdvancedstationGetstaff (Guid? station, Guid? locationid, string user, string services, Guid? eventid, int? photosize);
        /// <summary>
        /// Gets whether a user is signed-in or not. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="time">The date and time of the swipe.</param>
        /// <param name="user">The card of the user.</param>
        /// <param name="location">The id of the location the user picked.</param>
        /// <returns></returns>
        void AdvancedstationIssignedin (Guid? station, DateTime? time, string user, Guid? location);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdvancedstationApi : IAdvancedstationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedstationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AdvancedstationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedstationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdvancedstationApi(String basePath)
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
        /// Check whether the user is known by the system. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <param name="location">The id of the location the user picked.</param> 
        /// <returns></returns>            
        public void AdvancedstationCheckunknownuser (Guid? station, string user, Guid? location)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationCheckunknownuser");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationCheckunknownuser");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AdvancedstationCheckunknownuser");
            
    
            var path = "/advancedstation/checkunknownuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationCheckunknownuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationCheckunknownuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Check whether the user is a staff member, an attendee or both. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <param name="location">The id of the location the user picked.</param> 
        /// <returns></returns>            
        public void AdvancedstationCheckuserrole (Guid? station, string user, Guid? location)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationCheckuserrole");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationCheckuserrole");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AdvancedstationCheckuserrole");
            
    
            var path = "/advancedstation/checkuserrole";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationCheckuserrole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationCheckuserrole: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Creates a user via a sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="user">The card of the user to create.</param> 
        /// <param name="location">The id of the location the user picked.</param> 
        /// <param name="firstname">The first name of the user to create.</param> 
        /// <param name="lastname">The last name of the user to create.</param> 
        /// <param name="email">The email of the user to create.</param> 
        /// <param name="middlename">The middle name of the user to create.</param> 
        /// <returns></returns>            
        public void AdvancedstationCreateuser (Guid? station, string user, Guid? location, string firstname, string lastname, string email, string middlename)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationCreateuser");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationCreateuser");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AdvancedstationCreateuser");
            
            // verify the required parameter 'firstname' is set
            if (firstname == null) throw new ApiException(400, "Missing required parameter 'firstname' when calling AdvancedstationCreateuser");
            
            // verify the required parameter 'lastname' is set
            if (lastname == null) throw new ApiException(400, "Missing required parameter 'lastname' when calling AdvancedstationCreateuser");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling AdvancedstationCreateuser");
            
    
            var path = "/advancedstation/createuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (firstname != null) queryParams.Add("firstname", ApiClient.ParameterToString(firstname)); // query parameter
 if (middlename != null) queryParams.Add("middlename", ApiClient.ParameterToString(middlename)); // query parameter
 if (lastname != null) queryParams.Add("lastname", ApiClient.ParameterToString(lastname)); // query parameter
 if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationCreateuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationCreateuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the courses available for a specific location and a specific student. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="location">The id of the location the student picked.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <returns></returns>            
        public void AdvancedstationGetevents (Guid? station, Guid? location, string user)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationGetevents");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AdvancedstationGetevents");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationGetevents");
            
    
            var path = "/advancedstation/getevents";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetevents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetevents: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the info to display in the sign-in station by it&#39;s ID. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param> 
        /// <param name="_event">The id of the event (or session), to override the scheduled one.</param> 
        /// <returns></returns>            
        public void AdvancedstationGetinfo (Guid? id, Guid? _event)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AdvancedstationGetinfo");
            
    
            var path = "/advancedstation/getinfo";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetinfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetinfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the locations available in a sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose locations have to be returned.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <returns></returns>            
        public void AdvancedstationGetlocations (Guid? station, string user)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationGetlocations");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationGetlocations");
            
    
            var path = "/advancedstation/getlocations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetlocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetlocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the staff/tutors available filtered by the location, course and services of the given attendance log. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="attendancelog">The id of the attendance log to filter the staff members.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void AdvancedstationGetlogstaff (Guid? station, Guid? attendancelog, int? photosize)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationGetlogstaff");
            
            // verify the required parameter 'attendancelog' is set
            if (attendancelog == null) throw new ApiException(400, "Missing required parameter 'attendancelog' when calling AdvancedstationGetlogstaff");
            
    
            var path = "/advancedstation/getlogstaff";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (attendancelog != null) queryParams.Add("attendancelog", ApiClient.ParameterToString(attendancelog)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetlogstaff: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetlogstaff: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the user roles of the user trying to sign-in. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="signinrole">Specifies how the user is signing-in.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <param name="location">The id of the location the user picked.</param> 
        /// <returns></returns>            
        public void AdvancedstationGetroles (Guid? station, string signinrole, string user, Guid? location)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationGetroles");
            
            // verify the required parameter 'signinrole' is set
            if (signinrole == null) throw new ApiException(400, "Missing required parameter 'signinrole' when calling AdvancedstationGetroles");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationGetroles");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AdvancedstationGetroles");
            
    
            var path = "/advancedstation/getroles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (signinrole != null) queryParams.Add("signinrole", ApiClient.ParameterToString(signinrole)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetroles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetroles: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the services available for a specific location. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="location">The id of the location the student picked.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <returns></returns>            
        public void AdvancedstationGetservices (Guid? station, Guid? location, string user)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationGetservices");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AdvancedstationGetservices");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationGetservices");
            
    
            var path = "/advancedstation/getservices";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the staff/tutors available for a specific location, course and service. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="locationid">The id of the location the student picked.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <param name="services">The list of services selected by the user, in JSON format.</param> 
        /// <param name="eventid">The ID of the event selected.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void AdvancedstationGetstaff (Guid? station, Guid? locationid, string user, string services, Guid? eventid, int? photosize)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationGetstaff");
            
            // verify the required parameter 'locationid' is set
            if (locationid == null) throw new ApiException(400, "Missing required parameter 'locationid' when calling AdvancedstationGetstaff");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationGetstaff");
            
    
            var path = "/advancedstation/getstaff";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (services != null) queryParams.Add("services", ApiClient.ParameterToString(services)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetstaff: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationGetstaff: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets whether a user is signed-in or not. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="time">The date and time of the swipe.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <param name="location">The id of the location the user picked.</param> 
        /// <returns></returns>            
        public void AdvancedstationIssignedin (Guid? station, DateTime? time, string user, Guid? location)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AdvancedstationIssignedin");
            
            // verify the required parameter 'time' is set
            if (time == null) throw new ApiException(400, "Missing required parameter 'time' when calling AdvancedstationIssignedin");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AdvancedstationIssignedin");
            
    
            var path = "/advancedstation/issignedin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (time != null) queryParams.Add("time", ApiClient.ParameterToString(time)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationIssignedin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvancedstationIssignedin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
