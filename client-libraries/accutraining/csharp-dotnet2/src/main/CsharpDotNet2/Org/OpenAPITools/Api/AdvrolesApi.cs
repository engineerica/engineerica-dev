using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdvrolesApi
    {
        /// <summary>
        /// List users. Alias to user.list, use that one instead. 
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param>
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void AdvrolesUserlist (int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdvrolesApi : IAdvrolesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvrolesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AdvrolesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvrolesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdvrolesApi(String basePath)
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
        /// List users. Alias to user.list, use that one instead. 
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param> 
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void AdvrolesUserlist (int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling AdvrolesUserlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling AdvrolesUserlist");
            
    
            var path = "/advroles/userlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
 if (onlywithoutcard != null) queryParams.Add("onlywithoutcard", ApiClient.ParameterToString(onlywithoutcard)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvrolesUserlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvrolesUserlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
