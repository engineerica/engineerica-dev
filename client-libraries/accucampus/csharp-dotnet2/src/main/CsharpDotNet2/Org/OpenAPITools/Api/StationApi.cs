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
    public interface IStationApi
    {
        /// <summary>
        /// Delete a sign-in station Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.
        /// </summary>
        /// <param name="id">The id of the sign-in station to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void StationDelete (Guid? id, AnyType body);
        /// <summary>
        /// View details of a sign-in station Allows the user to view an individual sign-in station and its details.
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param>
        /// <returns></returns>
        void StationGet (Guid? id);
        /// <summary>
        /// Get all the current terms 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s current terms have to be retrieved.</param>
        /// <returns></returns>
        void StationGetcurrentterms (Guid? station);
        /// <summary>
        /// Gets a the info to display in the sign-in station by it&#39;s ID. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param>
        /// <param name="_event">The id of the event, to override the one by schedule.</param>
        /// <returns></returns>
        void StationGetinfo (Guid? id, Guid? _event);
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s license has to be retrieved.</param>
        /// <returns></returns>
        void StationGetlicense (string station);
        /// <summary>
        /// View the sign-in station settings of a specified location Allows the user to view the location settings of a sign-in station.
        /// </summary>
        /// <param name="location">The id of the location whose station settings have to be returned.</param>
        /// <returns></returns>
        void StationGetlocationsettings (Guid? location);
        /// <summary>
        /// View a list of sign-in stations Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void StationList (int? from, int? count);
        /// <summary>
        /// Create or edit a sign-in station Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.
        /// </summary>
        /// <param name="id">The id of the sign-in station to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void StationSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Create or edit a class attendance sign-in station for myself Allows the user to create a class attendance sign-in station for a course for which they are available as staff.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void StationSavemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Unlocks the sign-in station. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to unlock.</param>
        /// <param name="passcode">The passcode to unlock the station.</param>
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param>
        /// <returns></returns>
        void StationUnlock (Guid? id, string passcode, string method);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StationApi : IStationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StationApi(String basePath)
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
        /// Delete a sign-in station Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.
        /// </summary>
        /// <param name="id">The id of the sign-in station to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void StationDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationDelete");
            
    
            var path = "/station/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StationDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a sign-in station Allows the user to view an individual sign-in station and its details.
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param> 
        /// <returns></returns>            
        public void StationGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationGet");
            
    
            var path = "/station/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StationGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all the current terms 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s current terms have to be retrieved.</param> 
        /// <returns></returns>            
        public void StationGetcurrentterms (Guid? station)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling StationGetcurrentterms");
            
    
            var path = "/station/getcurrentterms";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetcurrentterms: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetcurrentterms: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a the info to display in the sign-in station by it&#39;s ID. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param> 
        /// <param name="_event">The id of the event, to override the one by schedule.</param> 
        /// <returns></returns>            
        public void StationGetinfo (Guid? id, Guid? _event)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationGetinfo");
            
    
            var path = "/station/getinfo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetinfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetinfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s license has to be retrieved.</param> 
        /// <returns></returns>            
        public void StationGetlicense (string station)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling StationGetlicense");
            
    
            var path = "/station/getlicense";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetlicense: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetlicense: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the sign-in station settings of a specified location Allows the user to view the location settings of a sign-in station.
        /// </summary>
        /// <param name="location">The id of the location whose station settings have to be returned.</param> 
        /// <returns></returns>            
        public void StationGetlocationsettings (Guid? location)
        {
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling StationGetlocationsettings");
            
    
            var path = "/station/getlocationsettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetlocationsettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationGetlocationsettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of sign-in stations Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void StationList (int? from, int? count)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling StationList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling StationList");
            
    
            var path = "/station/list";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StationList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a sign-in station Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.
        /// </summary>
        /// <param name="id">The id of the sign-in station to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void StationSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationSave");
            
    
            var path = "/station/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StationSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a class attendance sign-in station for myself Allows the user to create a class attendance sign-in station for a course for which they are available as staff.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void StationSavemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/station/savemine";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StationSavemine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationSavemine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Unlocks the sign-in station. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to unlock.</param> 
        /// <param name="passcode">The passcode to unlock the station.</param> 
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param> 
        /// <returns></returns>            
        public void StationUnlock (Guid? id, string passcode, string method)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StationUnlock");
            
            // verify the required parameter 'passcode' is set
            if (passcode == null) throw new ApiException(400, "Missing required parameter 'passcode' when calling StationUnlock");
            
            // verify the required parameter 'method' is set
            if (method == null) throw new ApiException(400, "Missing required parameter 'method' when calling StationUnlock");
            
    
            var path = "/station/unlock";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (passcode != null) queryParams.Add("passcode", ApiClient.ParameterToString(passcode)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StationUnlock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StationUnlock: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
