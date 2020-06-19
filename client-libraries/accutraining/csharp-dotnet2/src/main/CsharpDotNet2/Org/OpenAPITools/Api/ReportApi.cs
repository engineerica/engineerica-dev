using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApi
    {
        /// <summary>
        /// View a list of available reports Allows the user to view the complete list of available, canned reports.
        /// </summary>
        /// <returns></returns>
        void ReportList ();
        /// <summary>
        /// Permissions by user report Lists all the users in the system including their corresponding permissions.
        /// </summary>
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param>
        /// <returns></returns>
        void ReportPermissionsbyuser (string _params);
        /// <summary>
        /// Queries and loads the specified report, in background. Allows the user to run reports, in background, with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="reportname">The name of the report to execute</param>
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param>
        /// <param name="repformat">The format of the resulting report. Json, pdf, csv, ...</param>
        /// <param name="fillgroupid">If specified, the result is used to fill the group with the given ID</param>
        /// <param name="groupby">How to group the records. In the format &#39;col1+col2|col3+col4</param>
        /// <param name="refreshgroup">The ID of the group to check (and refresh) before processing the report.</param>
        /// <param name="filtertext">The user friendly text of the applied filters.</param>
        /// <returns></returns>
        void ReportPrepare (string reportname, string _params, string repformat, Guid? fillgroupid, string groupby, Guid? refreshgroup, string filtertext);
        /// <summary>
        /// Query and load a specified report Allows the user to run reports with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="reportname">The name of the report to execute</param>
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param>
        /// <returns></returns>
        void ReportQuery (string reportname, string _params);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportApi : IReportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportApi(String basePath)
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
        /// View a list of available reports Allows the user to view the complete list of available, canned reports.
        /// </summary>
        /// <returns></returns>            
        public void ReportList ()
        {
            
    
            var path = "/report/list";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Permissions by user report Lists all the users in the system including their corresponding permissions.
        /// </summary>
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param> 
        /// <returns></returns>            
        public void ReportPermissionsbyuser (string _params)
        {
            
    
            var path = "/report/permissionsbyuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (_params != null) queryParams.Add("params", ApiClient.ParameterToString(_params)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportPermissionsbyuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportPermissionsbyuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Queries and loads the specified report, in background. Allows the user to run reports, in background, with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="reportname">The name of the report to execute</param> 
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param> 
        /// <param name="repformat">The format of the resulting report. Json, pdf, csv, ...</param> 
        /// <param name="fillgroupid">If specified, the result is used to fill the group with the given ID</param> 
        /// <param name="groupby">How to group the records. In the format &#39;col1+col2|col3+col4</param> 
        /// <param name="refreshgroup">The ID of the group to check (and refresh) before processing the report.</param> 
        /// <param name="filtertext">The user friendly text of the applied filters.</param> 
        /// <returns></returns>            
        public void ReportPrepare (string reportname, string _params, string repformat, Guid? fillgroupid, string groupby, Guid? refreshgroup, string filtertext)
        {
            
            // verify the required parameter 'reportname' is set
            if (reportname == null) throw new ApiException(400, "Missing required parameter 'reportname' when calling ReportPrepare");
            
    
            var path = "/report/prepare";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (reportname != null) queryParams.Add("reportname", ApiClient.ParameterToString(reportname)); // query parameter
 if (_params != null) queryParams.Add("params", ApiClient.ParameterToString(_params)); // query parameter
 if (repformat != null) queryParams.Add("repformat", ApiClient.ParameterToString(repformat)); // query parameter
 if (fillgroupid != null) queryParams.Add("fillgroupid", ApiClient.ParameterToString(fillgroupid)); // query parameter
 if (groupby != null) queryParams.Add("groupby", ApiClient.ParameterToString(groupby)); // query parameter
 if (refreshgroup != null) queryParams.Add("refreshgroup", ApiClient.ParameterToString(refreshgroup)); // query parameter
 if (filtertext != null) queryParams.Add("filtertext", ApiClient.ParameterToString(filtertext)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportPrepare: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportPrepare: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Query and load a specified report Allows the user to run reports with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="reportname">The name of the report to execute</param> 
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param> 
        /// <returns></returns>            
        public void ReportQuery (string reportname, string _params)
        {
            
            // verify the required parameter 'reportname' is set
            if (reportname == null) throw new ApiException(400, "Missing required parameter 'reportname' when calling ReportQuery");
            
    
            var path = "/report/query";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (reportname != null) queryParams.Add("reportname", ApiClient.ParameterToString(reportname)); // query parameter
 if (_params != null) queryParams.Add("params", ApiClient.ParameterToString(_params)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportQuery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
