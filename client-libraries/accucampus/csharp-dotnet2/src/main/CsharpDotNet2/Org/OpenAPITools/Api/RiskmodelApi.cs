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
    public interface IRiskmodelApi
    {
        /// <summary>
        /// Check the status of the analysis of a specified risk assessment model Allows the user to check the status of a risk assessment model as it is being processed.
        /// </summary>
        /// <param name="id">The id of the risk assessment model whose analysis status has to be returned.</param>
        /// <returns></returns>
        void RiskmodelCheckanalysis (Guid? id);
        /// <summary>
        /// Delete a risk assessment model Allows the user to delete a previously created risk assessment model.
        /// </summary>
        /// <param name="id">The id of the risk assessment model to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void RiskmodelDelete (Guid? id, AnyType body);
        /// <summary>
        /// View details of a risk assessment model Allows the user to view an individual risk assessment model and its details.
        /// </summary>
        /// <param name="id">The id of the risk assessment model to get.</param>
        /// <returns></returns>
        void RiskmodelGet (Guid? id);
        /// <summary>
        /// View the risk score for a specific user Allows the user to view the risk score of another user.
        /// </summary>
        /// <param name="userid">The id of the user to get the risk score.</param>
        /// <returns></returns>
        void RiskmodelGetscore (Guid? userid);
        /// <summary>
        /// View a list of risk assessment models Allows the user to view the full list of risk assessment models.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void RiskmodelList (int? from, int? count);
        /// <summary>
        /// Predict risk based on an assessment model Allows a user to process a risk prediction from a risk assessment model that has processed.
        /// </summary>
        /// <param name="id">The id of the assessment model to use in order to predict risk.</param>
        /// <returns></returns>
        void RiskmodelPredict (Guid? id);
        /// <summary>
        /// Process a risk assessment model Allows the user to process a risk assessment model once it has been created.
        /// </summary>
        /// <param name="id">The id of the risk assessment model to process.</param>
        /// <returns></returns>
        void RiskmodelProcess (Guid? id);
        /// <summary>
        /// Refresh the information used in a risk assessment model Allows the user to refresh a risk assessment model.
        /// </summary>
        /// <param name="id">The id of the risk assessment model whose information has to be refreshed.</param>
        /// <returns></returns>
        void RiskmodelRefresh (Guid? id);
        /// <summary>
        /// Create or edit a risk assessment model Allows the user to create or edit a risk assessment model.
        /// </summary>
        /// <param name="id">The id of the department save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void RiskmodelSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// View all default term precedences Allows the user to view the default term precedences used in a model.
        /// </summary>
        /// <returns></returns>
        void RiskmodelTermprecedences ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RiskmodelApi : IRiskmodelApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskmodelApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RiskmodelApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskmodelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RiskmodelApi(String basePath)
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
        /// Check the status of the analysis of a specified risk assessment model Allows the user to check the status of a risk assessment model as it is being processed.
        /// </summary>
        /// <param name="id">The id of the risk assessment model whose analysis status has to be returned.</param> 
        /// <returns></returns>            
        public void RiskmodelCheckanalysis (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RiskmodelCheckanalysis");
            
    
            var path = "/riskmodel/checkanalysis";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelCheckanalysis: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelCheckanalysis: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a risk assessment model Allows the user to delete a previously created risk assessment model.
        /// </summary>
        /// <param name="id">The id of the risk assessment model to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void RiskmodelDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RiskmodelDelete");
            
    
            var path = "/riskmodel/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a risk assessment model Allows the user to view an individual risk assessment model and its details.
        /// </summary>
        /// <param name="id">The id of the risk assessment model to get.</param> 
        /// <returns></returns>            
        public void RiskmodelGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RiskmodelGet");
            
    
            var path = "/riskmodel/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the risk score for a specific user Allows the user to view the risk score of another user.
        /// </summary>
        /// <param name="userid">The id of the user to get the risk score.</param> 
        /// <returns></returns>            
        public void RiskmodelGetscore (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling RiskmodelGetscore");
            
    
            var path = "/riskmodel/getscore";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelGetscore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelGetscore: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of risk assessment models Allows the user to view the full list of risk assessment models.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void RiskmodelList (int? from, int? count)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling RiskmodelList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling RiskmodelList");
            
    
            var path = "/riskmodel/list";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Predict risk based on an assessment model Allows a user to process a risk prediction from a risk assessment model that has processed.
        /// </summary>
        /// <param name="id">The id of the assessment model to use in order to predict risk.</param> 
        /// <returns></returns>            
        public void RiskmodelPredict (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RiskmodelPredict");
            
    
            var path = "/riskmodel/predict";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelPredict: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelPredict: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Process a risk assessment model Allows the user to process a risk assessment model once it has been created.
        /// </summary>
        /// <param name="id">The id of the risk assessment model to process.</param> 
        /// <returns></returns>            
        public void RiskmodelProcess (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RiskmodelProcess");
            
    
            var path = "/riskmodel/process";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelProcess: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelProcess: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Refresh the information used in a risk assessment model Allows the user to refresh a risk assessment model.
        /// </summary>
        /// <param name="id">The id of the risk assessment model whose information has to be refreshed.</param> 
        /// <returns></returns>            
        public void RiskmodelRefresh (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RiskmodelRefresh");
            
    
            var path = "/riskmodel/refresh";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelRefresh: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelRefresh: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a risk assessment model Allows the user to create or edit a risk assessment model.
        /// </summary>
        /// <param name="id">The id of the department save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void RiskmodelSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RiskmodelSave");
            
    
            var path = "/riskmodel/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all default term precedences Allows the user to view the default term precedences used in a model.
        /// </summary>
        /// <returns></returns>            
        public void RiskmodelTermprecedences ()
        {
            
    
            var path = "/riskmodel/termprecedences";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelTermprecedences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RiskmodelTermprecedences: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
