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
    public interface IComputerlabApi
    {
        /// <summary>
        /// Delete a computer Allows the user to delete an existing computer.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ComputerlabDeletecomputer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Search and view details of a computer Allows the user to search and view an individual computer and its details.
        /// </summary>
        /// <param name="id">The unique device id of the computer to get.</param>
        /// <returns></returns>
        void ComputerlabGetcomputer (string id);
        /// <summary>
        /// Loads the settings for a computer lab Loads the settings for a computer lab.
        /// </summary>
        /// <param name="id">The id of the computer lab/location.</param>
        /// <returns></returns>
        void ComputerlabGetsettings (Guid? id);
        /// <summary>
        /// Gets whether a user is signed-in or not. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="user">The card of the user.</param>
        /// <returns></returns>
        void ComputerlabIssignedin (Guid? station, string user);
        /// <summary>
        /// View a list of computers Allows the user to view the list of all computers.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="location">The id of the location whose computers have to be returned.</param>
        /// <param name="freeonly">If true, only free computers will be returned.</param>
        /// <returns></returns>
        void ComputerlabListcomputers (int? from, int? count, Guid? location, bool? freeonly);
        /// <summary>
        /// View a list of the locations that use the Computer Lab add-on Allows the user to view the list of all labs.
        /// </summary>
        /// <returns></returns>
        void ComputerlabListlabs ();
        /// <summary>
        /// View a list of sign-in stations available for computer labs. Allows the user to view the list of sign-in stations that are available for computer labs.
        /// </summary>
        /// <returns></returns>
        void ComputerlabListstations ();
        /// <summary>
        /// Create or edit a computer Allows the user to create or edit a computer.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ComputerlabSavecomputer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Saves the settings for a computer lab Saves the settings for a computer lab.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ComputerlabSavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Save a new swipe from a computer in a computer lab. 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ComputerlabSaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ComputerlabApi : IComputerlabApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerlabApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ComputerlabApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerlabApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ComputerlabApi(String basePath)
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
        /// Delete a computer Allows the user to delete an existing computer.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ComputerlabDeletecomputer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/computerlab/deletecomputer";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabDeletecomputer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabDeletecomputer: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a computer Allows the user to search and view an individual computer and its details.
        /// </summary>
        /// <param name="id">The unique device id of the computer to get.</param> 
        /// <returns></returns>            
        public void ComputerlabGetcomputer (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ComputerlabGetcomputer");
            
    
            var path = "/computerlab/getcomputer";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabGetcomputer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabGetcomputer: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Loads the settings for a computer lab Loads the settings for a computer lab.
        /// </summary>
        /// <param name="id">The id of the computer lab/location.</param> 
        /// <returns></returns>            
        public void ComputerlabGetsettings (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ComputerlabGetsettings");
            
    
            var path = "/computerlab/getsettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabGetsettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabGetsettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets whether a user is signed-in or not. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <returns></returns>            
        public void ComputerlabIssignedin (Guid? station, string user)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling ComputerlabIssignedin");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling ComputerlabIssignedin");
            
    
            var path = "/computerlab/issignedin";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabIssignedin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabIssignedin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of computers Allows the user to view the list of all computers.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="location">The id of the location whose computers have to be returned.</param> 
        /// <param name="freeonly">If true, only free computers will be returned.</param> 
        /// <returns></returns>            
        public void ComputerlabListcomputers (int? from, int? count, Guid? location, bool? freeonly)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling ComputerlabListcomputers");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling ComputerlabListcomputers");
            
    
            var path = "/computerlab/listcomputers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (freeonly != null) queryParams.Add("freeonly", ApiClient.ParameterToString(freeonly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabListcomputers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabListcomputers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of the locations that use the Computer Lab add-on Allows the user to view the list of all labs.
        /// </summary>
        /// <returns></returns>            
        public void ComputerlabListlabs ()
        {
            
    
            var path = "/computerlab/listlabs";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabListlabs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabListlabs: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of sign-in stations available for computer labs. Allows the user to view the list of sign-in stations that are available for computer labs.
        /// </summary>
        /// <returns></returns>            
        public void ComputerlabListstations ()
        {
            
    
            var path = "/computerlab/liststations";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabListstations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabListstations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a computer Allows the user to create or edit a computer.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ComputerlabSavecomputer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/computerlab/savecomputer";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabSavecomputer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabSavecomputer: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves the settings for a computer lab Saves the settings for a computer lab.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ComputerlabSavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/computerlab/savesettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabSavesettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabSavesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save a new swipe from a computer in a computer lab. 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ComputerlabSaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/computerlab/saveswipe";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabSaveswipe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComputerlabSaveswipe: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
