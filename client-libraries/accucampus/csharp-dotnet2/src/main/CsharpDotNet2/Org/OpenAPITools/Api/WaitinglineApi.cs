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
    public interface IWaitinglineApi
    {
        /// <summary>
        /// Put user in a waiting line 
        /// </summary>
        /// <param name="station">The id of the sign-in station.</param>
        /// <param name="user">The user&#39;s card number.</param>
        /// <param name="locationid">The location&#39;s id where the swipe must be saved.</param>
        /// <param name="time">The date and time of the swipe.</param>
        /// <param name="signinrole">Specifies if the sign-in is for an attendee or a staff member</param>
        /// <param name="roleid">Specifies the role the user has selected in order to sign-in</param>
        /// <param name="services">The services ids the user has selected.</param>
        /// <param name="eventid">The id of the event the user selected.</param>
        /// <param name="staff">The id of the staff member the user selected.</param>
        /// <param name="photosize">The swiping user&#39;s photo size.</param>
        /// <returns></returns>
        void WaitinglineAdduser (Guid? station, string user, Guid? locationid, DateTime? time, string signinrole, Guid? roleid, string services, Guid? eventid, Guid? staff, int? photosize);
        /// <summary>
        /// Delete a waiting line Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.
        /// </summary>
        /// <param name="id">The id of the line to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void WaitinglineDelete (Guid? id, AnyType body);
        /// <summary>
        /// View details of a waiting line Allows the user to view the details of a waiting line in a location to which they are scoped.
        /// </summary>
        /// <param name="id">The id of the waiting line to get.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void WaitinglineGet (Guid? id, int? photosize);
        /// <summary>
        /// Check whether a user is in a waiting line, signed-in or is not in the area 
        /// </summary>
        /// <param name="station">The id of the sign-in station.</param>
        /// <param name="time">The date and time of the swipe.</param>
        /// <param name="user">The card number of the user.</param>
        /// <param name="location">The id of the location the user picked.</param>
        /// <returns></returns>
        void WaitinglineIsuserin (Guid? station, DateTime? time, string user, Guid? location);
        /// <summary>
        /// View a list of waiting lines Allows the user to view the list of waiting lines in locations to which they are scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void WaitinglineList (int? from, int? count);
        /// <summary>
        /// Remove a user from a waiting line Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.
        /// </summary>
        /// <param name="waitingline">The id of the waiting line whose item has to be removed.</param>
        /// <param name="itemid">The ID of the item that has to be removed.</param>
        /// <returns></returns>
        void WaitinglineRemoveuser (Guid? waitingline, Guid? itemid);
        /// <summary>
        /// Create or edit a waiting line Allows the user to create or edit a waiting line in a location to which they are scoped.
        /// </summary>
        /// <param name="id">The id of the waiting line save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void WaitinglineSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Sign a user in from a waiting line Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.
        /// </summary>
        /// <param name="waitingline">The id of the waiting line whose item needs to be signed-in.</param>
        /// <param name="itemid">The ID of the item that has to be signed-in.</param>
        /// <param name="staff">The id of the staff member selected to sign-in.</param>
        /// <param name="photosize">The swiping user&#39;s photo size.</param>
        /// <returns></returns>
        void WaitinglineSigninuser (Guid? waitingline, Guid? itemid, Guid? staff, int? photosize);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WaitinglineApi : IWaitinglineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitinglineApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WaitinglineApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitinglineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WaitinglineApi(String basePath)
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
        /// Put user in a waiting line 
        /// </summary>
        /// <param name="station">The id of the sign-in station.</param> 
        /// <param name="user">The user&#39;s card number.</param> 
        /// <param name="locationid">The location&#39;s id where the swipe must be saved.</param> 
        /// <param name="time">The date and time of the swipe.</param> 
        /// <param name="signinrole">Specifies if the sign-in is for an attendee or a staff member</param> 
        /// <param name="roleid">Specifies the role the user has selected in order to sign-in</param> 
        /// <param name="services">The services ids the user has selected.</param> 
        /// <param name="eventid">The id of the event the user selected.</param> 
        /// <param name="staff">The id of the staff member the user selected.</param> 
        /// <param name="photosize">The swiping user&#39;s photo size.</param> 
        /// <returns></returns>            
        public void WaitinglineAdduser (Guid? station, string user, Guid? locationid, DateTime? time, string signinrole, Guid? roleid, string services, Guid? eventid, Guid? staff, int? photosize)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling WaitinglineAdduser");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling WaitinglineAdduser");
            
    
            var path = "/waitingline/adduser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (time != null) queryParams.Add("time", ApiClient.ParameterToString(time)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (signinrole != null) queryParams.Add("signinrole", ApiClient.ParameterToString(signinrole)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
 if (services != null) queryParams.Add("services", ApiClient.ParameterToString(services)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (staff != null) queryParams.Add("staff", ApiClient.ParameterToString(staff)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineAdduser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineAdduser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a waiting line Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.
        /// </summary>
        /// <param name="id">The id of the line to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void WaitinglineDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WaitinglineDelete");
            
    
            var path = "/waitingline/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a waiting line Allows the user to view the details of a waiting line in a location to which they are scoped.
        /// </summary>
        /// <param name="id">The id of the waiting line to get.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void WaitinglineGet (Guid? id, int? photosize)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WaitinglineGet");
            
    
            var path = "/waitingline/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Check whether a user is in a waiting line, signed-in or is not in the area 
        /// </summary>
        /// <param name="station">The id of the sign-in station.</param> 
        /// <param name="time">The date and time of the swipe.</param> 
        /// <param name="user">The card number of the user.</param> 
        /// <param name="location">The id of the location the user picked.</param> 
        /// <returns></returns>            
        public void WaitinglineIsuserin (Guid? station, DateTime? time, string user, Guid? location)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling WaitinglineIsuserin");
            
            // verify the required parameter 'time' is set
            if (time == null) throw new ApiException(400, "Missing required parameter 'time' when calling WaitinglineIsuserin");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling WaitinglineIsuserin");
            
    
            var path = "/waitingline/isuserin";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineIsuserin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineIsuserin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of waiting lines Allows the user to view the list of waiting lines in locations to which they are scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void WaitinglineList (int? from, int? count)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling WaitinglineList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling WaitinglineList");
            
    
            var path = "/waitingline/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a user from a waiting line Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.
        /// </summary>
        /// <param name="waitingline">The id of the waiting line whose item has to be removed.</param> 
        /// <param name="itemid">The ID of the item that has to be removed.</param> 
        /// <returns></returns>            
        public void WaitinglineRemoveuser (Guid? waitingline, Guid? itemid)
        {
            
            // verify the required parameter 'waitingline' is set
            if (waitingline == null) throw new ApiException(400, "Missing required parameter 'waitingline' when calling WaitinglineRemoveuser");
            
            // verify the required parameter 'itemid' is set
            if (itemid == null) throw new ApiException(400, "Missing required parameter 'itemid' when calling WaitinglineRemoveuser");
            
    
            var path = "/waitingline/removeuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (waitingline != null) queryParams.Add("waitingline", ApiClient.ParameterToString(waitingline)); // query parameter
 if (itemid != null) queryParams.Add("itemid", ApiClient.ParameterToString(itemid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineRemoveuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineRemoveuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a waiting line Allows the user to create or edit a waiting line in a location to which they are scoped.
        /// </summary>
        /// <param name="id">The id of the waiting line save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void WaitinglineSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling WaitinglineSave");
            
    
            var path = "/waitingline/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sign a user in from a waiting line Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.
        /// </summary>
        /// <param name="waitingline">The id of the waiting line whose item needs to be signed-in.</param> 
        /// <param name="itemid">The ID of the item that has to be signed-in.</param> 
        /// <param name="staff">The id of the staff member selected to sign-in.</param> 
        /// <param name="photosize">The swiping user&#39;s photo size.</param> 
        /// <returns></returns>            
        public void WaitinglineSigninuser (Guid? waitingline, Guid? itemid, Guid? staff, int? photosize)
        {
            
            // verify the required parameter 'waitingline' is set
            if (waitingline == null) throw new ApiException(400, "Missing required parameter 'waitingline' when calling WaitinglineSigninuser");
            
            // verify the required parameter 'itemid' is set
            if (itemid == null) throw new ApiException(400, "Missing required parameter 'itemid' when calling WaitinglineSigninuser");
            
            // verify the required parameter 'staff' is set
            if (staff == null) throw new ApiException(400, "Missing required parameter 'staff' when calling WaitinglineSigninuser");
            
    
            var path = "/waitingline/signinuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (waitingline != null) queryParams.Add("waitingline", ApiClient.ParameterToString(waitingline)); // query parameter
 if (itemid != null) queryParams.Add("itemid", ApiClient.ParameterToString(itemid)); // query parameter
 if (staff != null) queryParams.Add("staff", ApiClient.ParameterToString(staff)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineSigninuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WaitinglineSigninuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
