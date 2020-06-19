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
    public interface IMemorizedreportApi
    {
        /// <summary>
        /// Delete memorized report Allows the user to delete a memorized report that they have created.
        /// </summary>
        /// <param name="id">The id of the report settings to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void MemorizedreportDelete (Guid? id, AnyType body);
        /// <summary>
        /// View details of a memorized report Allows the user to view an individual memorized report and its details.
        /// </summary>
        /// <param name="id">The id of the report configuration to get.</param>
        /// <returns></returns>
        void MemorizedreportGet (Guid? id);
        /// <summary>
        /// View a list of all his memorized reports Allows the user to view the list of all memorized reports that they have created.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="customname">If specified filters the memorized reports by custom name.</param>
        /// <returns></returns>
        void MemorizedreportList (int? from, int? count, string customname);
        /// <summary>
        /// Create or edit a memorized report Allows the user to create or edit a memorized report for themselves.
        /// </summary>
        /// <param name="id">The id of the report settings to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void MemorizedreportSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MemorizedreportApi : IMemorizedreportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemorizedreportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MemorizedreportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MemorizedreportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MemorizedreportApi(String basePath)
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
        /// Delete memorized report Allows the user to delete a memorized report that they have created.
        /// </summary>
        /// <param name="id">The id of the report settings to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void MemorizedreportDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MemorizedreportDelete");
            
    
            var path = "/memorizedreport/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a memorized report Allows the user to view an individual memorized report and its details.
        /// </summary>
        /// <param name="id">The id of the report configuration to get.</param> 
        /// <returns></returns>            
        public void MemorizedreportGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MemorizedreportGet");
            
    
            var path = "/memorizedreport/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of all his memorized reports Allows the user to view the list of all memorized reports that they have created.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="customname">If specified filters the memorized reports by custom name.</param> 
        /// <returns></returns>            
        public void MemorizedreportList (int? from, int? count, string customname)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling MemorizedreportList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling MemorizedreportList");
            
    
            var path = "/memorizedreport/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (customname != null) queryParams.Add("customname", ApiClient.ParameterToString(customname)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a memorized report Allows the user to create or edit a memorized report for themselves.
        /// </summary>
        /// <param name="id">The id of the report settings to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void MemorizedreportSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MemorizedreportSave");
            
    
            var path = "/memorizedreport/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemorizedreportSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
