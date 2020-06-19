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
    public interface ITranslationApi
    {
        /// <summary>
        /// Gets the translations of the specified values 
        /// </summary>
        /// <param name="universal">Pipe separated list of universal text to be translated.</param>
        /// <returns></returns>
        void TranslationGet (string universal);
        /// <summary>
        /// Get the file containing the translations 
        /// </summary>
        /// <param name="account">The id of the account whose translations file has to be retrieved.</param>
        /// <returns></returns>
        void TranslationGetcachefile (string account);
        /// <summary>
        /// Lists all the available translations in the system 
        /// </summary>
        /// <param name="filter">Text to search/filter translations.</param>
        /// <param name="nondefaultonly">If true then it returns only the terms translated. Otherwise, it returns all.</param>
        /// <param name="appdefaultasuniversal">If true then it uses the app default translation as the universal term.</param>
        /// <returns></returns>
        void TranslationList (string filter, bool? nondefaultonly, bool? appdefaultasuniversal);
        /// <summary>
        /// Edit a translation Allows the user to edit a translation for the entire account.
        /// </summary>
        /// <param name="id">The id of the translation as returned by translation.list.</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void TranslationSave (string id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TranslationApi : ITranslationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TranslationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TranslationApi(String basePath)
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
        /// Gets the translations of the specified values 
        /// </summary>
        /// <param name="universal">Pipe separated list of universal text to be translated.</param> 
        /// <returns></returns>            
        public void TranslationGet (string universal)
        {
            
            // verify the required parameter 'universal' is set
            if (universal == null) throw new ApiException(400, "Missing required parameter 'universal' when calling TranslationGet");
            
    
            var path = "/translation/get";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (universal != null) queryParams.Add("universal", ApiClient.ParameterToString(universal)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the file containing the translations 
        /// </summary>
        /// <param name="account">The id of the account whose translations file has to be retrieved.</param> 
        /// <returns></returns>            
        public void TranslationGetcachefile (string account)
        {
            
    
            var path = "/translation/getcachefile";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (account != null) queryParams.Add("account", ApiClient.ParameterToString(account)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationGetcachefile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationGetcachefile: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists all the available translations in the system 
        /// </summary>
        /// <param name="filter">Text to search/filter translations.</param> 
        /// <param name="nondefaultonly">If true then it returns only the terms translated. Otherwise, it returns all.</param> 
        /// <param name="appdefaultasuniversal">If true then it uses the app default translation as the universal term.</param> 
        /// <returns></returns>            
        public void TranslationList (string filter, bool? nondefaultonly, bool? appdefaultasuniversal)
        {
            
    
            var path = "/translation/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (nondefaultonly != null) queryParams.Add("nondefaultonly", ApiClient.ParameterToString(nondefaultonly)); // query parameter
 if (appdefaultasuniversal != null) queryParams.Add("appdefaultasuniversal", ApiClient.ParameterToString(appdefaultasuniversal)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit a translation Allows the user to edit a translation for the entire account.
        /// </summary>
        /// <param name="id">The id of the translation as returned by translation.list.</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void TranslationSave (string id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TranslationSave");
            
    
            var path = "/translation/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TranslationSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
