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
    public interface IQuickpanelApi
    {
        /// <summary>
        /// Deletes a widget from the Quick Panel Allows the user to delete a widget that has been added to the Quick Panel.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void QuickpanelDeletewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Fetches the information for a specific widget. 
        /// </summary>
        /// <param name="widgetid">The ID of the data to fetch it&#39;s data.</param>
        /// <returns></returns>
        void QuickpanelFetchwidget (Guid? widgetid);
        /// <summary>
        /// View details of a widget included in the Quick Panel Allows the user to view a widget added in as Quick Panel.
        /// </summary>
        /// <param name="id">The id of the widget to get.</param>
        /// <returns></returns>
        void QuickpanelGetwidget (Guid? id);
        /// <summary>
        /// Returns the initial information required to show the quick panels 
        /// </summary>
        /// <returns></returns>
        void QuickpanelInit ();
        /// <summary>
        /// Lists all the widgets that are added in the Quick Panel Allows the user to view the widgets that have been added to the Quick Panel.
        /// </summary>
        /// <returns></returns>
        void QuickpanelListwidgets ();
        /// <summary>
        /// Lists all the widget types available in the system 
        /// </summary>
        /// <returns></returns>
        void QuickpanelListwidgettypes ();
        /// <summary>
        /// Reorders the widgets and moves them to a specific column 
        /// </summary>
        /// <param name="sectionname">The section name where to sort the widgets.</param>
        /// <param name="orderids">CSV list of the widgets to reorder.</param>
        /// <returns></returns>
        void QuickpanelReorderwidgets (string sectionname, string orderids);
        /// <summary>
        /// Saves a widget for the Quick Panel Allows the user to save a widget to the Quick Panel.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void QuickpanelSavewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QuickpanelApi : IQuickpanelApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickpanelApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public QuickpanelApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickpanelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QuickpanelApi(String basePath)
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
        /// Deletes a widget from the Quick Panel Allows the user to delete a widget that has been added to the Quick Panel.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void QuickpanelDeletewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/quickpanel/deletewidget";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelDeletewidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelDeletewidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Fetches the information for a specific widget. 
        /// </summary>
        /// <param name="widgetid">The ID of the data to fetch it&#39;s data.</param> 
        /// <returns></returns>            
        public void QuickpanelFetchwidget (Guid? widgetid)
        {
            
            // verify the required parameter 'widgetid' is set
            if (widgetid == null) throw new ApiException(400, "Missing required parameter 'widgetid' when calling QuickpanelFetchwidget");
            
    
            var path = "/quickpanel/fetchwidget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (widgetid != null) queryParams.Add("widgetid", ApiClient.ParameterToString(widgetid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelFetchwidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelFetchwidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a widget included in the Quick Panel Allows the user to view a widget added in as Quick Panel.
        /// </summary>
        /// <param name="id">The id of the widget to get.</param> 
        /// <returns></returns>            
        public void QuickpanelGetwidget (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling QuickpanelGetwidget");
            
    
            var path = "/quickpanel/getwidget";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelGetwidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelGetwidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the initial information required to show the quick panels 
        /// </summary>
        /// <returns></returns>            
        public void QuickpanelInit ()
        {
            
    
            var path = "/quickpanel/init";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelInit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelInit: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists all the widgets that are added in the Quick Panel Allows the user to view the widgets that have been added to the Quick Panel.
        /// </summary>
        /// <returns></returns>            
        public void QuickpanelListwidgets ()
        {
            
    
            var path = "/quickpanel/listwidgets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelListwidgets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelListwidgets: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists all the widget types available in the system 
        /// </summary>
        /// <returns></returns>            
        public void QuickpanelListwidgettypes ()
        {
            
    
            var path = "/quickpanel/listwidgettypes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelListwidgettypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelListwidgettypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Reorders the widgets and moves them to a specific column 
        /// </summary>
        /// <param name="sectionname">The section name where to sort the widgets.</param> 
        /// <param name="orderids">CSV list of the widgets to reorder.</param> 
        /// <returns></returns>            
        public void QuickpanelReorderwidgets (string sectionname, string orderids)
        {
            
            // verify the required parameter 'sectionname' is set
            if (sectionname == null) throw new ApiException(400, "Missing required parameter 'sectionname' when calling QuickpanelReorderwidgets");
            
            // verify the required parameter 'orderids' is set
            if (orderids == null) throw new ApiException(400, "Missing required parameter 'orderids' when calling QuickpanelReorderwidgets");
            
    
            var path = "/quickpanel/reorderwidgets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sectionname != null) queryParams.Add("sectionname", ApiClient.ParameterToString(sectionname)); // query parameter
 if (orderids != null) queryParams.Add("orderids", ApiClient.ParameterToString(orderids)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelReorderwidgets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelReorderwidgets: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a widget for the Quick Panel Allows the user to save a widget to the Quick Panel.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void QuickpanelSavewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/quickpanel/savewidget";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelSavewidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickpanelSavewidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
