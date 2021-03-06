/**
 * AccuCampus OpenAPI 3
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */


import ApiClient from "../ApiClient";

/**
* Eventreg service.
* @module api/EventregApi
* @version 1.0.0
*/
export default class EventregApi {

    /**
    * Constructs a new EventregApi. 
    * @alias module:api/EventregApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instance} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }


    /**
     * Callback function to receive the result of the eventregAddme operation.
     * @callback module:api/EventregApi~eventregAddmeCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register current user to a course
     * Allows the user to make themselves available for individual courses.
     * @param {String} eventid The id of the event.
     * @param {String} listname The name of the list where the user has to be registered.
     * @param {module:api/EventregApi~eventregAddmeCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregAddme(eventid, listname, callback) {
      let postBody = null;
      // verify the required parameter 'eventid' is set
      if (eventid === undefined || eventid === null) {
        throw new Error("Missing the required parameter 'eventid' when calling eventregAddme");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregAddme");
      }

      let pathParams = {
      };
      let queryParams = {
        'eventid': eventid,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/addme', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregAddmetoall operation.
     * @callback module:api/EventregApi~eventregAddmetoallCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register current user to all courses
     * Allows the user to make themselves available for all courses.
     * @param {String} listname The name of the list where the user has to be registered.
     * @param {module:api/EventregApi~eventregAddmetoallCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregAddmetoall(listname, callback) {
      let postBody = null;
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregAddmetoall");
      }

      let pathParams = {
      };
      let queryParams = {
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/addmetoall', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregAddmetogroup operation.
     * @callback module:api/EventregApi~eventregAddmetogroupCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register current user to a course group
     * Allows the user to make themselves available for a course group.
     * @param {String} codegroup The code used to group events.
     * @param {String} listname The name of the list where the user has to be registered.
     * @param {module:api/EventregApi~eventregAddmetogroupCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregAddmetogroup(codegroup, listname, callback) {
      let postBody = null;
      // verify the required parameter 'codegroup' is set
      if (codegroup === undefined || codegroup === null) {
        throw new Error("Missing the required parameter 'codegroup' when calling eventregAddmetogroup");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregAddmetogroup");
      }

      let pathParams = {
      };
      let queryParams = {
        'codegroup': codegroup,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/addmetogroup', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregAdduser operation.
     * @callback module:api/EventregApi~eventregAdduserCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register a user to a course for attendance
     * Allows the user to register a user to a course.
     * @param {String} userid The id of the user to add.
     * @param {String} eventid The id of the event.
     * @param {String} listname The name of the list where the user has to be registered.
     * @param {module:api/EventregApi~eventregAdduserCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregAdduser(userid, eventid, listname, callback) {
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregAdduser");
      }
      // verify the required parameter 'eventid' is set
      if (eventid === undefined || eventid === null) {
        throw new Error("Missing the required parameter 'eventid' when calling eventregAdduser");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregAdduser");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'eventid': eventid,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/adduser', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregAddusertoall operation.
     * @callback module:api/EventregApi~eventregAddusertoallCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register a user to assist with all courses
     * Allows the user to make a staff member available to assist with all courses.
     * @param {String} userid The id of the user to add.
     * @param {String} listname The name of the list where the user has to be registered.
     * @param {module:api/EventregApi~eventregAddusertoallCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregAddusertoall(userid, listname, callback) {
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregAddusertoall");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregAddusertoall");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/addusertoall', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregAddusertogroup operation.
     * @callback module:api/EventregApi~eventregAddusertogroupCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register a user to an course group
     * Allows the user to make a staff member available for a course group.
     * @param {String} userid The id of the user to add.
     * @param {String} codegroup The code used to group events.
     * @param {String} listname The name of the list where the user has to be registered.
     * @param {module:api/EventregApi~eventregAddusertogroupCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregAddusertogroup(userid, codegroup, listname, callback) {
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregAddusertogroup");
      }
      // verify the required parameter 'codegroup' is set
      if (codegroup === undefined || codegroup === null) {
        throw new Error("Missing the required parameter 'codegroup' when calling eventregAddusertogroup");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregAddusertogroup");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'codegroup': codegroup,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/addusertogroup', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregGetevents operation.
     * @callback module:api/EventregApi~eventregGeteventsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View course registration by user
     * Allows the user to view all courses a given user is registered to, provided they have permission to view that user.
     * @param {String} userid The user id to list events.
     * @param {String} listname The name of the list where the user is registered.
     * @param {Object} opts Optional parameters
     * @param {String} opts.termid The term id to list events.
     * @param {String} opts.namefilter The value used to filter the events by name.
     * @param {module:api/EventregApi~eventregGeteventsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregGetevents(userid, listname, opts, callback) {
      opts = opts || {};
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregGetevents");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregGetevents");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'listname': listname,
        'termid': opts['termid'],
        'namefilter': opts['namefilter']
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/getevents', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregGetgroups operation.
     * @callback module:api/EventregApi~eventregGetgroupsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Lists the course group registrations of a user
     * Allows the user to view the course groups a staff member is available for.
     * @param {String} userid The user id to list events.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregGetgroupsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregGetgroups(userid, listname, callback) {
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregGetgroups");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregGetgroups");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/getgroups', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregGetmyevents operation.
     * @callback module:api/EventregApi~eventregGetmyeventsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View the event registrations of the current user
     * @param {String} listname The name of the list where the user is registered.
     * @param {Object} opts Optional parameters
     * @param {String} opts.termid The term id to list events.
     * @param {String} opts.namefilter The value used to filter the events by name.
     * @param {module:api/EventregApi~eventregGetmyeventsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregGetmyevents(listname, opts, callback) {
      opts = opts || {};
      let postBody = null;
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregGetmyevents");
      }

      let pathParams = {
      };
      let queryParams = {
        'listname': listname,
        'termid': opts['termid'],
        'namefilter': opts['namefilter']
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/getmyevents', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregGetmygroups operation.
     * @callback module:api/EventregApi~eventregGetmygroupsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View all current user registrations to course groups
     * Allows the user to view all his registrations to course groups.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregGetmygroupsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregGetmygroups(listname, callback) {
      let postBody = null;
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregGetmygroups");
      }

      let pathParams = {
      };
      let queryParams = {
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/getmygroups', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregGetusers operation.
     * @callback module:api/EventregApi~eventregGetusersCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View course registration
     * Allows the user to view all users registered for an individual course.
     * @param {String} eventid The event id to list users.
     * @param {String} listname The name of the list to get.
     * @param {Object} opts Optional parameters
     * @param {Number} opts.photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
     * @param {module:api/EventregApi~eventregGetusersCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregGetusers(eventid, listname, opts, callback) {
      opts = opts || {};
      let postBody = null;
      // verify the required parameter 'eventid' is set
      if (eventid === undefined || eventid === null) {
        throw new Error("Missing the required parameter 'eventid' when calling eventregGetusers");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregGetusers");
      }

      let pathParams = {
      };
      let queryParams = {
        'eventid': eventid,
        'listname': listname,
        'photosize': opts['photosize']
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/getusers', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregGetusersfromgroup operation.
     * @callback module:api/EventregApi~eventregGetusersfromgroupCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Lists the registrations for a course group
     * Allows the user the get the staff members registered to a specific course group
     * @param {String} codegroup The code group to list users.
     * @param {String} listname The name of the list to get.
     * @param {module:api/EventregApi~eventregGetusersfromgroupCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregGetusersfromgroup(codegroup, listname, callback) {
      let postBody = null;
      // verify the required parameter 'codegroup' is set
      if (codegroup === undefined || codegroup === null) {
        throw new Error("Missing the required parameter 'codegroup' when calling eventregGetusersfromgroup");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregGetusersfromgroup");
      }

      let pathParams = {
      };
      let queryParams = {
        'codegroup': codegroup,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/getusersfromgroup', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregGetuserstoall operation.
     * @callback module:api/EventregApi~eventregGetuserstoallCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View the users that are registered to all courses
     * Allows the user to view all staff members available for all courses.
     * @param {String} listname The name of the list to get.
     * @param {module:api/EventregApi~eventregGetuserstoallCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregGetuserstoall(listname, callback) {
      let postBody = null;
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregGetuserstoall");
      }

      let pathParams = {
      };
      let queryParams = {
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/getuserstoall', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregRemoveme operation.
     * @callback module:api/EventregApi~eventregRemovemeCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Unregister current user from a course
     * Allows the user to remove themselves from registration to a course.
     * @param {String} eventid The id of the event.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregRemovemeCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregRemoveme(eventid, listname, callback) {
      let postBody = null;
      // verify the required parameter 'eventid' is set
      if (eventid === undefined || eventid === null) {
        throw new Error("Missing the required parameter 'eventid' when calling eventregRemoveme");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregRemoveme");
      }

      let pathParams = {
      };
      let queryParams = {
        'eventid': eventid,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/removeme', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregRemovemefromall operation.
     * @callback module:api/EventregApi~eventregRemovemefromallCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove current user from the registration to all courses
     * Allows the user to remove themselves from availability to all courses.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregRemovemefromallCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregRemovemefromall(listname, callback) {
      let postBody = null;
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregRemovemefromall");
      }

      let pathParams = {
      };
      let queryParams = {
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/removemefromall', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregRemovemefromgroup operation.
     * @callback module:api/EventregApi~eventregRemovemefromgroupCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove current user from a course group
     * Allows the user to remove themselves from availability to a course group.
     * @param {String} codegroup The code group of the events/courses.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregRemovemefromgroupCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregRemovemefromgroup(codegroup, listname, callback) {
      let postBody = null;
      // verify the required parameter 'codegroup' is set
      if (codegroup === undefined || codegroup === null) {
        throw new Error("Missing the required parameter 'codegroup' when calling eventregRemovemefromgroup");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregRemovemefromgroup");
      }

      let pathParams = {
      };
      let queryParams = {
        'codegroup': codegroup,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/removemefromgroup', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregRemoveuser operation.
     * @callback module:api/EventregApi~eventregRemoveuserCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove a user from a course
     * Allows the user to remove a user from a course's registration.
     * @param {String} userid The id of the user to remove.
     * @param {String} eventid The id of the event.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregRemoveuserCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregRemoveuser(userid, eventid, listname, callback) {
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregRemoveuser");
      }
      // verify the required parameter 'eventid' is set
      if (eventid === undefined || eventid === null) {
        throw new Error("Missing the required parameter 'eventid' when calling eventregRemoveuser");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregRemoveuser");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'eventid': eventid,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/removeuser', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregRemoveuserfromall operation.
     * @callback module:api/EventregApi~eventregRemoveuserfromallCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove a user from the registration to all courses
     * Allows the user to remove a staff member from availability to all courses.
     * @param {String} userid The id of the user to remove.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregRemoveuserfromallCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregRemoveuserfromall(userid, listname, callback) {
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregRemoveuserfromall");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregRemoveuserfromall");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/removeuserfromall', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the eventregRemoveuserfromgroup operation.
     * @callback module:api/EventregApi~eventregRemoveuserfromgroupCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove a user from a course group
     * Allows the user to remove a staff member from availability to a course group.
     * @param {String} userid The id of the user to remove.
     * @param {String} codegroup The code group of the events/courses.
     * @param {String} listname The name of the list where the user is registered.
     * @param {module:api/EventregApi~eventregRemoveuserfromgroupCallback} callback The callback function, accepting three arguments: error, data, response
     */
    eventregRemoveuserfromgroup(userid, codegroup, listname, callback) {
      let postBody = null;
      // verify the required parameter 'userid' is set
      if (userid === undefined || userid === null) {
        throw new Error("Missing the required parameter 'userid' when calling eventregRemoveuserfromgroup");
      }
      // verify the required parameter 'codegroup' is set
      if (codegroup === undefined || codegroup === null) {
        throw new Error("Missing the required parameter 'codegroup' when calling eventregRemoveuserfromgroup");
      }
      // verify the required parameter 'listname' is set
      if (listname === undefined || listname === null) {
        throw new Error("Missing the required parameter 'listname' when calling eventregRemoveuserfromgroup");
      }

      let pathParams = {
      };
      let queryParams = {
        'userid': userid,
        'codegroup': codegroup,
        'listname': listname
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/eventreg/removeuserfromgroup', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }


}
