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
    public interface IBeaconApi
    {
        /// <summary>
        /// Delete a beacon profile Allows the user to delete an existing beacon profile.
        /// </summary>
        /// <param name="id">The id of the beacon to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void BeaconDelete (Guid? id, AnyType body);
        /// <summary>
        /// Disable beacon support account wide Allows the user to enable or disable beacon usage account wide.
        /// </summary>
        /// <returns></returns>
        void BeaconDisable ();
        /// <summary>
        /// View details of a beacon profile Allows the user to view an individual beacon profile and its details.
        /// </summary>
        /// <param name="id">The id of the beacon to get.</param>
        /// <returns></returns>
        void BeaconGet (Guid? id);
        /// <summary>
        /// Get the sign-in stations assigned to specific beacons. 
        /// </summary>
        /// <param name="beacons">A JSON array containg the beacons data (region, minor and major) values.</param>
        /// <returns></returns>
        void BeaconGetlocations (string beacons);
        /// <summary>
        /// Get the location settings in the specified sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose location information has to be retrieved.</param>
        /// <param name="location">The id of the location whose information has to be retrieved.</param>
        /// <returns></returns>
        void BeaconGetstationlocation (Guid? station, Guid? location);
        /// <summary>
        /// View the identifier for the account&#39;s beacon region (for sign-in stations). 
        /// </summary>
        /// <returns></returns>
        void BeaconGetuuid ();
        /// <summary>
        /// View a list of beacon profiles Allows the user to view the list of all beacon profiles without their basic details.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void BeaconList (int? from, int? count);
        /// <summary>
        /// View a list of beacon profiles with their characteristics Allows the user to view the list of all beacon profiles with their basic details.
        /// </summary>
        /// <returns></returns>
        void BeaconListprofiles ();
        /// <summary>
        /// Generate or reset the identifier for the account&#39;s beacon region. Allows the user to reset the identifier for the beacon region, generally not necessary.
        /// </summary>
        /// <returns></returns>
        void BeaconResetuuid ();
        /// <summary>
        /// Create or edit a beacon profile Allows the user to create or edit a beacon profile.
        /// </summary>
        /// <param name="id">The id of the beacon save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void BeaconSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Check if there&#39;s location available to sign-in / out. 
        /// </summary>
        /// <param name="beacons">A JSON array containg the beacons data (region, minor and major) values.</param>
        /// <returns></returns>
        void BeaconScanlocations (string beacons);
        /// <summary>
        /// Set the identifier for the account&#39;s beacon region (for sign-in stations). Allows the user to set the identifier for the account&#39;s beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.
        /// </summary>
        /// <param name="id">The custom region UUID.</param>
        /// <returns></returns>
        void BeaconSetuuid (Guid? id);
        /// <summary>
        /// View all the beacon regions defined for silent tracking 
        /// </summary>
        /// <returns></returns>
        void BeaconSilentregions ();
        /// <summary>
        /// Sign-in silently from the location specified by a beacon 
        /// </summary>
        /// <param name="uuid">The id of the region the user is in.</param>
        /// <returns></returns>
        void BeaconSilentsignin (Guid? uuid);
        /// <summary>
        /// Sign-out silently from the location specified by a beacon 
        /// </summary>
        /// <param name="uuid">The id of the region the user has left.</param>
        /// <returns></returns>
        void BeaconSilentsignout (Guid? uuid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BeaconApi : IBeaconApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeaconApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BeaconApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BeaconApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BeaconApi(String basePath)
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
        /// Delete a beacon profile Allows the user to delete an existing beacon profile.
        /// </summary>
        /// <param name="id">The id of the beacon to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void BeaconDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BeaconDelete");
            
    
            var path = "/beacon/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Disable beacon support account wide Allows the user to enable or disable beacon usage account wide.
        /// </summary>
        /// <returns></returns>            
        public void BeaconDisable ()
        {
            
    
            var path = "/beacon/disable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconDisable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconDisable: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a beacon profile Allows the user to view an individual beacon profile and its details.
        /// </summary>
        /// <param name="id">The id of the beacon to get.</param> 
        /// <returns></returns>            
        public void BeaconGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BeaconGet");
            
    
            var path = "/beacon/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the sign-in stations assigned to specific beacons. 
        /// </summary>
        /// <param name="beacons">A JSON array containg the beacons data (region, minor and major) values.</param> 
        /// <returns></returns>            
        public void BeaconGetlocations (string beacons)
        {
            
            // verify the required parameter 'beacons' is set
            if (beacons == null) throw new ApiException(400, "Missing required parameter 'beacons' when calling BeaconGetlocations");
            
    
            var path = "/beacon/getlocations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (beacons != null) queryParams.Add("beacons", ApiClient.ParameterToString(beacons)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGetlocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGetlocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the location settings in the specified sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose location information has to be retrieved.</param> 
        /// <param name="location">The id of the location whose information has to be retrieved.</param> 
        /// <returns></returns>            
        public void BeaconGetstationlocation (Guid? station, Guid? location)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling BeaconGetstationlocation");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling BeaconGetstationlocation");
            
    
            var path = "/beacon/getstationlocation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGetstationlocation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGetstationlocation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the identifier for the account&#39;s beacon region (for sign-in stations). 
        /// </summary>
        /// <returns></returns>            
        public void BeaconGetuuid ()
        {
            
    
            var path = "/beacon/getuuid";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGetuuid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconGetuuid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of beacon profiles Allows the user to view the list of all beacon profiles without their basic details.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void BeaconList (int? from, int? count)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling BeaconList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling BeaconList");
            
    
            var path = "/beacon/list";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of beacon profiles with their characteristics Allows the user to view the list of all beacon profiles with their basic details.
        /// </summary>
        /// <returns></returns>            
        public void BeaconListprofiles ()
        {
            
    
            var path = "/beacon/listprofiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconListprofiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconListprofiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Generate or reset the identifier for the account&#39;s beacon region. Allows the user to reset the identifier for the beacon region, generally not necessary.
        /// </summary>
        /// <returns></returns>            
        public void BeaconResetuuid ()
        {
            
    
            var path = "/beacon/resetuuid";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconResetuuid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconResetuuid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a beacon profile Allows the user to create or edit a beacon profile.
        /// </summary>
        /// <param name="id">The id of the beacon save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void BeaconSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BeaconSave");
            
    
            var path = "/beacon/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Check if there&#39;s location available to sign-in / out. 
        /// </summary>
        /// <param name="beacons">A JSON array containg the beacons data (region, minor and major) values.</param> 
        /// <returns></returns>            
        public void BeaconScanlocations (string beacons)
        {
            
            // verify the required parameter 'beacons' is set
            if (beacons == null) throw new ApiException(400, "Missing required parameter 'beacons' when calling BeaconScanlocations");
            
    
            var path = "/beacon/scanlocations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (beacons != null) queryParams.Add("beacons", ApiClient.ParameterToString(beacons)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconScanlocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconScanlocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the identifier for the account&#39;s beacon region (for sign-in stations). Allows the user to set the identifier for the account&#39;s beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.
        /// </summary>
        /// <param name="id">The custom region UUID.</param> 
        /// <returns></returns>            
        public void BeaconSetuuid (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BeaconSetuuid");
            
    
            var path = "/beacon/setuuid";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSetuuid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSetuuid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the beacon regions defined for silent tracking 
        /// </summary>
        /// <returns></returns>            
        public void BeaconSilentregions ()
        {
            
    
            var path = "/beacon/silentregions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSilentregions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSilentregions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sign-in silently from the location specified by a beacon 
        /// </summary>
        /// <param name="uuid">The id of the region the user is in.</param> 
        /// <returns></returns>            
        public void BeaconSilentsignin (Guid? uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling BeaconSilentsignin");
            
    
            var path = "/beacon/silentsignin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (uuid != null) queryParams.Add("uuid", ApiClient.ParameterToString(uuid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSilentsignin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSilentsignin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sign-out silently from the location specified by a beacon 
        /// </summary>
        /// <param name="uuid">The id of the region the user has left.</param> 
        /// <returns></returns>            
        public void BeaconSilentsignout (Guid? uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling BeaconSilentsignout");
            
    
            var path = "/beacon/silentsignout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (uuid != null) queryParams.Add("uuid", ApiClient.ParameterToString(uuid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSilentsignout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BeaconSilentsignout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
