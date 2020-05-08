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
    public interface IDefaultApi
    {
        /// <summary>
        /// Remove an action item from an action plan Allows a user to remove an action item from a user&#39;s action plan.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action assignment to delete.</param>
        /// <returns></returns>
        void Actionassignmentdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of an action item assigned to a user Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action assignment to get.</param>
        /// <returns></returns>
        void Actionassignmentget (string token, Guid? id);
        /// <summary>
        /// View a list of action items in a user&#39;s plan Allows the user to view the list of all action items for a specified user.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="assignee">The assignee&#39;s id to filter the assignments.</param>
        /// <param name="status">The status to filter the assignments.</param>
        /// <returns></returns>
        void Actionassignmentlist (string token, int? from, int? count, int? assignee, int? status);
        /// <summary>
        /// View the history of an action item assigned to a user Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param>
        /// <returns></returns>
        void Actionassignmentlisthistory (string token, Guid? actionassignment);
        /// <summary>
        /// List public action assignments assigned to the logged user 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="status">The status to filter the assignments.</param>
        /// <returns></returns>
        void Actionassignmentlistmine (string token, int? from, int? count, int? status);
        /// <summary>
        /// List public action assignment history 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param>
        /// <returns></returns>
        void Actionassignmentlistpublichistory (string token, Guid? actionassignment);
        /// <summary>
        /// Bulk complete action items Allows the user to bulk complete action items.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="item">The action item to assign.</param>
        /// <param name="assignee">The assignee of the item.</param>
        /// <param name="group">The group to assing the item.</param>
        /// <param name="notes">The assignment&#39;s notes.</param>
        /// <returns></returns>
        void Actionassignmentmarkcomplete (string token, string item, Guid? assignee, Guid? group, string notes);
        /// <summary>
        /// Add an action item to a user&#39;s action plan Allows the user to edit or assign an action item to a user
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Actionassignmentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Update an action item assigned to a user Allows the user to update or mark an action item as complete.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Actionassignmentsavehistory (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete an action item Allows the user to delete an action item.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action item to delete.</param>
        /// <returns></returns>
        void Actionitemdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of an action item Allows the user to view an individual action item and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action item to get.</param>
        /// <returns></returns>
        void Actionitemget (string token, Guid? id);
        /// <summary>
        /// View a list of action items Allows the user to view a list of action items
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Actionitemlist (string token, int? from, int? count);
        /// <summary>
        /// Create or edit an action item Allows the user to edit an action item.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Actionitemsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// View a list of users action logs Allows the user to view the audit logs for the account.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="user">The id of the user whose action logs have to be returned.</param>
        /// <param name="startdate">The start date of the period to filter the logs.</param>
        /// <param name="enddate">The end date of the period to filter the logs.</param>
        /// <param name="resource">The resource to filter the action logs.</param>
        /// <param name="actionfilter">The action to filter the action logs.</param>
        /// <param name="argument">The id of the entity that was the argument of the executed action.</param>
        /// <returns></returns>
        void Actionloglist (string token, int? from, int? count, Guid? user, DateTime? startdate, DateTime? enddate, string resource, string actionfilter, string argument);
        /// <summary>
        /// Assign an action item pack to a user Allows the user to assign an action pack to a user or group of users.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="pack">The id of the action pack to assign.</param>
        /// <param name="itemsdata">A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).</param>
        /// <param name="assignee">The assignee of the pack.</param>
        /// <param name="group">The group to assign the pack.</param>
        /// <param name="notes">The assignment&#39;s notes.</param>
        /// <returns></returns>
        void Actionpackassign (string token, Guid? pack, bool? itemsdata, Guid? assignee, Guid? group, string notes);
        /// <summary>
        /// Delete an action item pack Allows the user to delete an action item pack.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action pack to delete.</param>
        /// <returns></returns>
        void Actionpackdelete (string token, Guid? id);
        /// <summary>
        /// View details of an action item pack Allows the user to view an individual action pack and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action pack to get.</param>
        /// <returns></returns>
        void Actionpackget (string token, Guid? id);
        /// <summary>
        /// View a list of action item packs Allows the user to view the full list of action item packs.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Actionpacklist (string token, int? from, int? count);
        /// <summary>
        /// Create or edit an action item pack Allows the user to edit an action item pack.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Actionpacksave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete an action item type Allows the user to delete an action item type.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action type to delete.</param>
        /// <returns></returns>
        void Actiontypedelete (string token, Guid? id);
        /// <summary>
        /// View details of an action item type Allows the user to view an individual action item type and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the action type to get.</param>
        /// <returns></returns>
        void Actiontypeget (string token, Guid? id);
        /// <summary>
        /// View a list of action item types Allows the user to view the full list of action item types.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Actiontypelist (string token, int? from, int? count);
        /// <summary>
        /// Create or edit an action item type Allows the user to dit an action item type.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Actiontypesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Adds the missing permissions to a role. Requires access to advrole.save 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="roles">CSV list of the role ids to check</param>
        /// <param name="permissions">CSV list of the permissions to check</param>
        /// <returns></returns>
        void Advroleaddmissing (string token, string roles, string permissions);
        /// <summary>
        /// Checks the permissions are assigned for the given roles 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="roles">CSV list of the role ids to check</param>
        /// <param name="permissions">CSV list of the permissions to check</param>
        /// <returns></returns>
        void Advrolecheckperm (string token, string roles, string permissions);
        /// <summary>
        /// Delete a role Allows the user to delete a role from the list of available roles.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the location to delete.</param>
        /// <returns></returns>
        void Advroledelete (string token, Guid? id);
        /// <summary>
        /// Delete a role mapping Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="map">The map name to save the role.</param>
        /// <param name="roleid">The id of the role.</param>
        /// <returns></returns>
        void Advroledeletemapping (string token, string map, Guid? roleid);
        /// <summary>
        /// View details of a role Allows the user to view a role and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the location to get.</param>
        /// <returns></returns>
        void Advroleget (string token, Guid? id);
        /// <summary>
        /// Lists the roles for the current account 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="includepolicies">True to include the policies, defaults to false.</param>
        /// <param name="includeinternal">True to include the internal roles too.</param>
        /// <param name="name">Filter by name of the role.</param>
        /// <returns></returns>
        void Advrolelist (string token, bool? includepolicies, bool? includeinternal, string name);
        /// <summary>
        /// Lists the maps a roles is mapped to 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="roleid">The id of the role to list the maps.</param>
        /// <returns></returns>
        void Advrolelistmaps (string token, Guid? roleid);
        /// <summary>
        /// Lists the roles mappings 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="map">List only the roles in the specified map.</param>
        /// <returns></returns>
        void Advrolelistrolesmapped (string token, string map);
        /// <summary>
        /// View a list of role templates Allows the user to view the full list of available role templates.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Advrolelisttemplates (string token);
        /// <summary>
        /// Create or edit a role Allows the user to create or edit a role&#39;s permissions.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Advrolesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Saves a role mapping Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Advrolesavemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// List users. Alias to user.list, use that one instead. 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param>
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void Advrolesuserlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize);
        /// <summary>
        /// Upgrade a user to another role (requires permission to edit those roles) Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">Id of the user to upgrade</param>
        /// <param name="roleid">Id of the role to add</param>
        /// <returns></returns>
        void Advroleuserupgrade (string token, Guid? userid, Guid? roleid);
        /// <summary>
        /// Gets the phone number of the current user 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Appsharegetphone (string token);
        /// <summary>
        /// Sends an SMS with the link to the app 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="phonenumber">Phone number to where to send the link. Leave empty to the number on file.</param>
        /// <returns></returns>
        void Appsharesendtext (string token, string phonenumber);
        /// <summary>
        /// Delete a comment on an attendance log 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the attendance log comment to delete.</param>
        /// <returns></returns>
        void Attendancelogcommentdelete (string token, Guid? id);
        /// <summary>
        /// View a comment on an attendance log 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the comment to get.</param>
        /// <returns></returns>
        void Attendancelogcommentget (string token, Guid? id);
        /// <summary>
        /// View all the comments on a specific attendance log 
        /// </summary>
        /// <param name="attendancelog">The id of the attendance log whose comments have to be retrieved.</param>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Attendancelogcommentlist (Guid? attendancelog, string token);
        /// <summary>
        /// Save a comment on an attendance log 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Attendancelogcommentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete an attendance log Allows the user to delete an existing attendance log.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the attendance log to delete.</param>
        /// <returns></returns>
        void Attendancelogdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of an attendance log Allows the user to view an individual attendance log and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the attendance log to get.</param>
        /// <returns></returns>
        void Attendancelogget (string token, Guid? id);
        /// <summary>
        /// Search and view details of an attendance log&#39;s swipe history Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the attendance log to get.</param>
        /// <returns></returns>
        void Attendanceloggetchangehistory (string token, Guid? id);
        /// <summary>
        /// View a list of attendance logs Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="token">The authentication token.</param>
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param>
        /// <param name="userid">The user ID of the user to get the logs.</param>
        /// <returns></returns>
        void Attendanceloglist (int? from, int? count, string token, string filter, Guid? userid);
        /// <summary>
        /// Gets the attendance logs of the current user 
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="token">The authentication token.</param>
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param>
        /// <returns></returns>
        void Attendanceloglistmine (int? from, int? count, string token, string filter);
        /// <summary>
        /// Create or edit an attendance log Allows the user to create or edit an attendance log.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Attendancelogsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Sign out an attendance log Allows the user to sign out am attendance log from the Who&#39;s In page.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the attendance log to sign-out.</param>
        /// <param name="location">The id of the location to filter the users to sign out.</param>
        /// <param name="_event">The id of the event to filter the users to sign out.</param>
        /// <param name="datetime">Specifies the date and time when the specified logs have to be signed out.</param>
        /// <returns></returns>
        void Attendancelogsignout (string token, Guid? id, Guid? location, Guid? _event, DateTime? datetime);
        /// <summary>
        /// View who&#39;s in a location Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="token">The authentication token.</param>
        /// <param name="location">The id of the location to search for users that are in.</param>
        /// <param name="_event">The id of the event to search for users that are in.</param>
        /// <param name="sorting">Field to sort by. Either first-name, last-name or sign-in-time.</param>
        /// <param name="roles">The comma-separated list of ids of the roles to search for users that are in.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <param name="extensions">A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]).</param>
        /// <param name="export">True to export the results as CSV</param>
        /// <returns></returns>
        void Attendancelogwhosin (int? from, int? count, string token, Guid? location, Guid? _event, string sorting, string roles, int? photosize, string extensions, bool? export);
        /// <summary>
        /// Get background job status 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="jobid">The ID of the job to get the status. 10 most recent will be returned if not specified.</param>
        /// <param name="jobtype">The job type to filter by.</param>
        /// <returns></returns>
        void Bgjobgetstatus (string token, Guid? jobid, string jobtype);
        /// <summary>
        /// Gets a captcha challenge that the user must complete to do certain requests. 
        /// </summary>
        /// <returns></returns>
        void Captchagetchallenge ();
        /// <summary>
        /// Gets a captcha image that the user must complete to do certain requests. 
        /// </summary>
        /// <param name="captchatoken">The captcha token or ID returned by the captcha.getchallenge action</param>
        /// <returns></returns>
        void Captchagetimage (string captchatoken);
        /// <summary>
        /// Get the application change log 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Changelog (string token);
        /// <summary>
        /// Get client 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="_client">The unique id of the client.</param>
        /// <param name="clientname">The custom name of the client.</param>
        /// <returns></returns>
        void Clientget (string token, string _client, string clientname);
        /// <summary>
        /// Gets the clients of the specified conference 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Clientlist (string token, int? from, int? count);
        /// <summary>
        /// Saves a client 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Clientsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Send a message to a client 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="uniqueclientid">The unique id of the client.</param>
        /// <param name="message">The body of the message to send.</param>
        /// <returns></returns>
        void Clientsendmessage (string token, Guid? uniqueclientid, string message);
        /// <summary>
        /// Delete a college department Allows the user to delete an existing college department.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the department to delete.</param>
        /// <returns></returns>
        void Departmentdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of a college department Allows the user to view an individual college department and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the department to get.</param>
        /// <returns></returns>
        void Departmentget (string token, Guid? id);
        /// <summary>
        /// View a list of college departments Allows the user to view the full list of college departments.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Departmentlist (string token, int? from, int? count);
        /// <summary>
        /// Create or edit a college department Allows the user to create or edit a college department.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Departmentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Get the documentation Retrieves the list of actions available in the system.
        /// </summary>
        /// <param name="excludeanonymous">If true it excludes the anonymous actions from the returned list.</param>
        /// <returns></returns>
        void Doc (bool? excludeanonymous);
        /// <summary>
        /// Adds background image for the login Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The original filename, needed to process the file.</param>
        /// <returns></returns>
        void Easyloginaddbgimage (string token, string upload, string filename);
        /// <summary>
        /// Delete a course Allows the user to delete an existing course.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the event to delete.</param>
        /// <returns></returns>
        void Eventdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of a course Allows the user to view an individual course and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the event to get.</param>
        /// <returns></returns>
        void Eventget (string token, Guid? id);
        /// <summary>
        /// View a list of courses by date Allows the user to view a list of courses by date.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="location">The location to filter the events.</param>
        /// <param name="date">The date to filter the events. Today will be used if this parameter is omitted.</param>
        /// <param name="type">Type of event to list.</param>
        /// <returns></returns>
        void Eventgetsessionsbydate (string token, Guid? location, DateTime? date, string type);
        /// <summary>
        /// View a list of courses Allows the user to view the full list of courses.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="summaryonly">True to return only the event information and not the associated schedule, dept, etc. Defaults to false.</param>
        /// <param name="termid">Id of the term to list the events. Null to list all events.</param>
        /// <returns></returns>
        void Eventlist (string token, string from, string count, bool? summaryonly, Guid? termid);
        /// <summary>
        /// Create or edit a course Allows the user to create or edit a course.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Eventsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Searches for the available event groups 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="query">Query to search event groups.</param>
        /// <returns></returns>
        void Eventsearchgroup (string token, Guid? query);
        /// <summary>
        /// Export AccuCampus data Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="exporttype">What to export.</param>
        /// <param name="exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>
        /// <param name="filters">Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|...</param>
        /// <returns></returns>
        void Export (string token, string exporttype, string exportformat, string filters);
        /// <summary>
        /// Lists available export types 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Exportlisttypes (string token);
        /// <summary>
        /// Lists the available features. 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Featurelist (string token);
        /// <summary>
        /// View a list of entered holidays Allows the user to view all holidays entered.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="term">The term to get holidays from.</param>
        /// <returns></returns>
        void Holidaylist (string token, Guid? term);
        /// <summary>
        /// Create or edit a list of holidays Allows the user to create or edit holidays.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Holidaysave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// View the holiday suggestions in the given term Allows the user to view the holiday suggestions for each term.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="term">The term to get holidays from.</param>
        /// <returns></returns>
        void Holidaysuggest (string token, Guid? term);
        /// <summary>
        /// Import data into AccuCampus Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="importtype">The kind of data that is being uploaded.</param>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The local name of the uploaded file. For later reference.</param>
        /// <param name="parameters">Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}.</param>
        /// <returns></returns>
        void Import (string token, string importtype, string upload, string filename, string parameters);
        /// <summary>
        /// Lists available import types 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Importlisttypes (string token);
        /// <summary>
        /// Accept the license agreement 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Licenseacceptagreement (string token);
        /// <summary>
        /// Check if license agreement has been accepted 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Licensegetagreementstatus (string token);
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Licensegetcurrent (string token);
        /// <summary>
        /// Contact Engineerica in order to renew the AccuCampus subscription Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="email">The e-mail of the user sending the request.</param>
        /// <param name="phonenumber">The phone number of the user sending the request.</param>
        /// <param name="jobtitle">The job title of the user sending the request.</param>
        /// <param name="institution">The institution of the user sending the request.</param>
        /// <param name="comments">Comments entered by the user sending the request.</param>
        /// <returns></returns>
        void Licenserenew (string token, string email, string phonenumber, string jobtitle, string institution, string comments);
        /// <summary>
        /// Lists the available timezones 
        /// </summary>
        /// <returns></returns>
        void Listtimezones ();
        /// <summary>
        /// Delete a location Allows the user to delete an existing location.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the location to delete.</param>
        /// <returns></returns>
        void Locationdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of a location Allows the user to search and view an individual location and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the location to get.</param>
        /// <returns></returns>
        void Locationget (string token, Guid? id);
        /// <summary>
        /// View a list of locations Allows the user to view the list of all locations to which they are scoped.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="locations">The comma-separated list containing the ids of the locations to list.</param>
        /// <param name="sortbygroup">True to list locations sorted by the &#39;Located In&#39; property. Defaults to false.</param>
        /// <returns></returns>
        void Locationlist (string token, int? from, int? count, string locations, bool? sortbygroup);
        /// <summary>
        /// Create or edit a location Allows the user to create or edit a location.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Locationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="domain">The account domain to login.</param>
        /// <param name="username">The username (email) of the user to login as.</param>
        /// <param name="password">The password of the user to login as.</param>
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param>
        /// <param name="rememberme">If true then the session will not expire.</param>
        /// <returns></returns>
        void Login (string domain, string username, string password, string method, bool? rememberme);
        /// <summary>
        /// Logout 
        /// </summary>
        /// <param name="token">The authentication token used to login.</param>
        /// <returns></returns>
        void Logout (string token);
        /// <summary>
        /// Delete memorized report Allows the user to delete a memorized report that they have created.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the report settings to delete.</param>
        /// <returns></returns>
        void Memorizedreportdelete (string token, Guid? id);
        /// <summary>
        /// View details of a memorized report Allows the user to view an individual memorized report and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the report configuration to get.</param>
        /// <returns></returns>
        void Memorizedreportget (string token, Guid? id);
        /// <summary>
        /// View a list of all his memorized reports Allows the user to view the list of all memorized reports that they have created.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="customname">If specified filters the memorized reports by custom name.</param>
        /// <returns></returns>
        void Memorizedreportlist (string token, int? from, int? count, string customname);
        /// <summary>
        /// Create or edit a memorized report Allows the user to create or edit a memorized report for themselves.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Memorizedreportsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Gets the items on the menu 
        /// </summary>
        /// <param name="menuid">The Id of the menu to get.</param>
        /// <returns></returns>
        void Menugetitems (string menuid);
        /// <summary>
        /// Gets the logged in user account. 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Myaccount (string token);
        /// <summary>
        /// Gets the current time zone&#39;s iana name 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Myianatimezone (string token);
        /// <summary>
        /// Gets the logged in user information. 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void Myprofile (string token, int? photosize);
        /// <summary>
        /// Gets the list of actions the user can execute. 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Myrights (string token);
        /// <summary>
        /// Updates logged user&#39;s profile information 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Mysaveprofile (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete a notification Allows the user to delete an existing notification.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the notification to delete.</param>
        /// <returns></returns>
        void Notificationdelete (string token, Guid? id);
        /// <summary>
        /// View a notification 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the notification to get.</param>
        /// <returns></returns>
        void Notificationget (string token, Guid? id);
        /// <summary>
        /// Gets all public (in station) notifications for the specific user 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="user">The card of the user.</param>
        /// <returns></returns>
        void Notificationgetforstation (Guid? station, string user);
        /// <summary>
        /// Get the number of unread notifications 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Notificationgetunreadcount (string token);
        /// <summary>
        /// View a list of all sent notifications Allows the user to view the list of all sent notifications.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="recipient">The recipient whose notifications have to be listed.</param>
        /// <param name="status">The status of the notifications to list. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <param name="sentonscreen">Specifies whether to list the notifications that were sent on-screen or not.</param>
        /// <param name="sentemail">Specifies whether to list the notifications that were sent via e-mail or not.</param>
        /// <param name="sentsms">Specifies whether to list the notifications that were sent via sms or not.</param>
        /// <returns></returns>
        void Notificationlist (string token, int? from, int? count, Guid? recipient, int? status, DateTime? startdate, DateTime? enddate, bool? sentonscreen, bool? sentemail, bool? sentsms);
        /// <summary>
        /// View all the notifications sent to the current user 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="status">Specifies the status of the notifications to list. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <returns></returns>
        void Notificationlistmine (string token, int? from, int? count, int? status, DateTime? startdate, DateTime? enddate);
        /// <summary>
        /// Mark a notification as read 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.</param>
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <returns></returns>
        void Notificationmarkasread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate);
        /// <summary>
        /// Mark a notification as unread 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.</param>
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <returns></returns>
        void Notificationmarkasunread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate);
        /// <summary>
        /// Send notifications on screen, via email or text to users Allows the user to send notifications to other users through the Send Message link.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="emailenabled">Whether send the notification via email.</param>
        /// <param name="onscreenenabled">Whether to display the notification on screen.</param>
        /// <param name="smsenabled">Whether to send the notification via text message.</param>
        /// <param name="title">Notification title.</param>
        /// <param name="tousers">Comma-separated Ids of users to send the notification.</param>
        /// <param name="togroups">Comma-separated Ids of user groups to send the notification.</param>
        /// <param name="onscreenbody">Body of the message for on-screen display.</param>
        /// <param name="onscreenclick">What to do when the notification is clicked. Valid values: hide, view, url.</param>
        /// <param name="onscreenurl">Url to redirect the user, if onscreenclick&#x3D;url.</param>
        /// <param name="onscreenclass">How to display the notification. Valid values: info, success, warning, error</param>
        /// <param name="onscreenduration">Time in seconds to display the notification.</param>
        /// <param name="showonstation">Whether to show the notification in the sign-in station.</param>
        /// <param name="emailfromname">Name of the email sender.</param>
        /// <param name="emailfrom">Reply-to email.</param>
        /// <param name="emailsubject">Subject of the email.</param>
        /// <param name="emailbody">Body of the email.</param>
        /// <param name="textmessagebody">Message for SMS. Max 160 characters.</param>
        /// <returns></returns>
        void Notificationsend (string token, bool? emailenabled, bool? onscreenenabled, bool? smsenabled, string title, string tousers, string togroups, string onscreenbody, string onscreenclick, string onscreenurl, string onscreenclass, int? onscreenduration, int? showonstation, string emailfromname, string emailfrom, string emailsubject, string emailbody, string textmessagebody);
        /// <summary>
        /// Send on-screen notifications 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="notification">The ID of the notification to send.</param>
        /// <returns></returns>
        void Notificationsendonscreen (string token, Guid? notification);
        /// <summary>
        /// Delete a notification topic Allows the user to delete an existing notification topic.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the notification topic to delete.</param>
        /// <returns></returns>
        void Notificationtopicdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of a notification topic Allows the user to view an individual notification topic and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the notification topic to get.</param>
        /// <returns></returns>
        void Notificationtopicget (string token, Guid? id);
        /// <summary>
        /// List all the notification topics Allows the user to view the list of all notification topics.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Notificationtopiclist (string token, int? from, int? count);
        /// <summary>
        /// List all the notification topics available to subscribe 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Notificationtopiclistsubscribe (string token);
        /// <summary>
        /// Create or edit a notification topic Allows the user to create and edit a notification topic.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Notificationtopicsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Deregisters the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param>
        /// <param name="platform">Either ios or android</param>
        /// <returns></returns>
        void Pushderegister (string devicetoken, string platform);
        /// <summary>
        /// Registers the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param>
        /// <param name="platform">Either ios or android</param>
        /// <returns></returns>
        void Pushregister (string devicetoken, string platform);
        /// <summary>
        /// Print and email QR labels Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="user">The id of the user whose label needs to be printed.</param>
        /// <param name="group">The id of the group whose members&#39; labels need to be printed.</param>
        /// <returns></returns>
        void Qrlabelsprint (string token, Guid? user, Guid? group);
        /// <summary>
        /// Gets an image of a QR token 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Qrloginget (string token);
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="onetimetoken">The token read from the QR code.</param>
        /// <returns></returns>
        void Qrloginlogin (string onetimetoken);
        /// <summary>
        /// Deletes a widget from the Quick Panel Allows the user to delete a widget that has been added to the Quick Panel.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the widget.</param>
        /// <returns></returns>
        void Quickpaneldeletewidget (string token, Guid? id);
        /// <summary>
        /// Fetches the information for a specific widget. 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="widgetid">The ID of the data to fetch it&#39;s data.</param>
        /// <returns></returns>
        void Quickpanelfetchwidget (string token, Guid? widgetid);
        /// <summary>
        /// View details of a widget included in the Quick Panel Allows the user to view a widget added in as Quick Panel.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the widget to get.</param>
        /// <returns></returns>
        void Quickpanelgetwidget (string token, Guid? id);
        /// <summary>
        /// Returns the initial information required to show the quick panels 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Quickpanelinit (string token);
        /// <summary>
        /// Lists all the widgets that are added in the Quick Panel Allows the user to view the widgets that have been added to the Quick Panel.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Quickpanellistwidgets (string token);
        /// <summary>
        /// Lists all the widget types available in the system 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Quickpanellistwidgettypes (string token);
        /// <summary>
        /// Reorders the widgets and moves them to a specific column 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="sectionname">The section name where to sort the widgets.</param>
        /// <param name="orderids">CSV list of the widgets to reorder.</param>
        /// <returns></returns>
        void Quickpanelreorderwidgets (string token, string sectionname, string orderids);
        /// <summary>
        /// Saves a widget for the Quick Panel Allows the user to save a widget to the Quick Panel.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Quickpanelsavewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// View a list of available reports Allows the user to view the complete list of available, canned reports.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Reportlist (string token);
        /// <summary>
        /// Permissions by user report Lists all the users in the system including their corresponding permissions.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param>
        /// <returns></returns>
        void Reportpermissionsbyuser (string token, string _params);
        /// <summary>
        /// Queries and loads the specified report, in background. Allows the user to run reports, in background, with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="reportname">The name of the report to execute</param>
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param>
        /// <param name="repformat">The format of the resulting report. Json, pdf, csv, ...</param>
        /// <param name="fillgroupid">If specified, the result is used to fill the group with the given ID</param>
        /// <param name="groupby">How to group the records. In the format &#39;col1+col2|col3+col4</param>
        /// <param name="refreshgroup">The ID of the group to check (and refresh) before processing the report.</param>
        /// <param name="filtertext">The user friendly text of the applied filters.</param>
        /// <returns></returns>
        void Reportprepare (string token, string reportname, string _params, string repformat, Guid? fillgroupid, string groupby, Guid? refreshgroup, string filtertext);
        /// <summary>
        /// Query and load a specified report Allows the user to run reports with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="reportname">The name of the report to execute</param>
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param>
        /// <returns></returns>
        void Reportquery (string token, string reportname, string _params);
        /// <summary>
        /// Show a list of roles 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="name">Filter by name of the role.</param>
        /// <returns></returns>
        void Rolelist (string token, string name);
        /// <summary>
        /// Delete a rule Allows the user to delete an existing rule.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the rule to delete.</param>
        /// <returns></returns>
        void Ruledelete (string token, Guid? id);
        /// <summary>
        /// View details of a rule Allows the user to view an individual rule and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the rule to get.</param>
        /// <returns></returns>
        void Ruleget (string token, Guid? id);
        /// <summary>
        /// View details of a rule event type Allows the user to view the trigger and its available conditions for the rule.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="_event">The name of the event to refresh.</param>
        /// <returns></returns>
        void Rulegeteventtype (string token, string _event);
        /// <summary>
        /// View a list of user rules Allows the user to view the list of all rules.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Rulelist (string token, int? from, int? count);
        /// <summary>
        /// View a list of rule actions available Allows the user to view all the available rule actions.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Rulelistactions (string token);
        /// <summary>
        /// View a list of rule event types Allows the user to view a list of available triggers for rules.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Rulelisteventtypes (string token);
        /// <summary>
        /// View all the http requests sent as a result of a rule 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="failed">If true only failed requests will be returned</param>
        /// <param name="status">The http status to filter the requests</param>
        /// <returns></returns>
        void Rulelisthttprequests (string token, int? from, int? count, bool? failed, int? status);
        /// <summary>
        /// Create or edit a rule Allows the user to create or edit a rule.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Rulesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Search 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="query">The query to search for.</param>
        /// <param name="page">Current page to show, zero-based.</param>
        /// <returns></returns>
        void Search (string token, string query, int? page);
        /// <summary>
        /// Get the information of the entities that can be searched 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Searchgetentities (string token);
        /// <summary>
        /// Returns the list of users for a specific permission 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="commandname">Name of the action or command to get the roles.</param>
        /// <returns></returns>
        void Securityassesspermission (string token, string commandname);
        /// <summary>
        /// Returns the list of permissions for a specific role 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="roleid">Role ID to list the effective permissions.</param>
        /// <returns></returns>
        void Securityassessrole (string token, Guid? roleid);
        /// <summary>
        /// Returns the list of users for a specific user 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="locationid">Location ID to list the users with that scope.</param>
        /// <returns></returns>
        void Securityassessscope (string token, Guid? locationid);
        /// <summary>
        /// Returns the list of permissions for a specific user 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">User ID to list the effective permissions.</param>
        /// <returns></returns>
        void Securityassessuser (string token, Guid? userid);
        /// <summary>
        /// Register current user to an event session Allows the user to register themselves for an event.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void Sessionregaddcurrentuser (string token, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// Register users for events Allows the user to register another user for an upcoming event.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void Sessionregadduser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// View all the sessions the logged user is registered to 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="date">Start date to filter the sessions.</param>
        /// <returns></returns>
        void Sessionreggetmysessions (string token, DateTime? date);
        /// <summary>
        /// Lists the registrations for a specific user Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">The user id to list sessions.</param>
        /// <returns></returns>
        void Sessionreggetsessions (string token, Guid? userid);
        /// <summary>
        /// Get the settings for session registration Allows the user to view a event&#39;s session registration settings.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="locationid">The id of the location to save settings.</param>
        /// <param name="eventid">The id of the event to save settings.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <param name="noinherit">True to get the location/event/session specific settings without looking for the more global settings.</param>
        /// <returns></returns>
        void Sessionreggetsettings (string token, Guid? locationid, Guid? eventid, DateTime? sessiondate, bool? noinherit);
        /// <summary>
        /// Lists the registrations for a specific session Allows the user to view the registration for a specified event session.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="eventid">The event id to list sessions.</param>
        /// <param name="sessiondate">The date of the session to find.</param>
        /// <returns></returns>
        void Sessionreggetusers (string token, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// List the sessions available for a specific event Allows the user to view all the sessions available for a recurring event.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="eventid">The event id to list sessions.</param>
        /// <param name="sessiondate">The date of the session to find.</param>
        /// <returns></returns>
        void Sessionreglistsessions (string token, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// View a list of upcoming event sessions Allows the user to view the full list of upcoming events.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="date">Only sessions in the week of the specified date will be returned.</param>
        /// <returns></returns>
        void Sessionreglistupcoming (string token, DateTime? date);
        /// <summary>
        /// View a list of upcoming sessions of a particular event Allows the user to view the upcoming recurring sessions of a specified event.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="date">Start date to filter the returned sessions.</param>
        /// <param name="_event">The id of the event whose sessions will be returned</param>
        /// <returns></returns>
        void Sessionreglistupcomingevent (string token, DateTime? date, Guid? _event);
        /// <summary>
        /// Unregister current user from an event session Allows the user to un-register themselves from an event.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void Sessionregremovecurrentuser (string token, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// Removes a user from an event session Allows the user to un-register another user from an event.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="eventid">The id of the event.</param>
        /// <param name="sessiondate">The date and time when the session starts.</param>
        /// <returns></returns>
        void Sessionregremoveuser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate);
        /// <summary>
        /// Save the settings for an event&#39;s session registration Allows the user to save the settings for an event.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Sessionregsavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Add a logo to the account Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The original filename, needed to process the file.</param>
        /// <returns></returns>
        void Settingaddlogo (string token, string upload, string filename);
        /// <summary>
        /// Get settings for the account or the specified scope 
        /// </summary>
        /// <param name="keys">The option keys to get values for. Enter multiple separated by comma.</param>
        /// <param name="token">The authentication token.</param>
        /// <param name="domain">The account domain, in case of reading settings annonymously.</param>
        /// <param name="scope">The scope of the settings to get.</param>
        /// <returns></returns>
        void Settingget (string keys, string token, string domain, string scope);
        /// <summary>
        /// Save settings for the account or the specified scope Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Settingsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// View general settings for the account Allows the user to view the settings&#39; general section.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Settingviewgeneral (string token);
        /// <summary>
        /// Generate/reset single sign on access key. Allows the user to generate or reset the access key for single sign-on.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Ssogeneratekey (string token);
        /// <summary>
        /// View single sign on settings. Allows the user to view settings for single sign-on.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Ssogetsettings (string token);
        /// <summary>
        /// Issue single sign-on token 
        /// </summary>
        /// <param name="key">The single sign-on key of the account.</param>
        /// <param name="username">The email of the user to sign-on.</param>
        /// <param name="expires">Specifies whether the session should expire when inactive.</param>
        /// <returns></returns>
        void Ssoissuetoken (string key, string username, bool? expires);
        /// <summary>
        /// Edit single sign-on settings. Allows the user to edit settings for single sign-on.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Ssosavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete a sign-in station Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the sign-in station to delete.</param>
        /// <returns></returns>
        void Stationdelete (string token, Guid? id);
        /// <summary>
        /// View details of a sign-in station Allows the user to view an individual sign-in station and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the sign-in station to get.</param>
        /// <returns></returns>
        void Stationget (string token, Guid? id);
        /// <summary>
        /// Get all the current terms 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s current terms have to be retrieved.</param>
        /// <returns></returns>
        void Stationgetcurrentterms (Guid? station);
        /// <summary>
        /// Gets a the info to display in the sign-in station by it&#39;s ID. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param>
        /// <param name="_event">The id of the event, to override the one by schedule.</param>
        /// <returns></returns>
        void Stationgetinfo (Guid? id, Guid? _event);
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s license has to be retrieved.</param>
        /// <returns></returns>
        void Stationgetlicense (string station);
        /// <summary>
        /// View a list of sign-in stations Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Stationlist (string token, int? from, int? count);
        /// <summary>
        /// Create or edit a sign-in station Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Stationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Unlocks the sign-in station. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to unlock.</param>
        /// <param name="passcode">The passcode to unlock the station.</param>
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param>
        /// <returns></returns>
        void Stationunlock (Guid? id, string passcode, string method);
        /// <summary>
        /// Delete a swipe Allows the user to delete an existing attendance swipe.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the swipe to delete.</param>
        /// <returns></returns>
        void Swipedelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of a swipe Allows the user to view an individual attendance swipe.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the swipe to get.</param>
        /// <returns></returns>
        void Swipeget (string token, Guid? id);
        /// <summary>
        /// View a list of swipes Allows the user to view a list of all swipes for the location or locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Swipelist (int? from, int? count, string token);
        /// <summary>
        /// Create or edit a swipe, and if possible, save the related attendance log Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Swipesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Creates a new swipe from a sign-in station, and if possible, creates the attendance log 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Swipesaveanonym (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete a tag Allows the user to delete an existing tag.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the tag to delete.</param>
        /// <returns></returns>
        void Tagdelete (string token, Guid? id);
        /// <summary>
        /// View details of a specified tag Allows the user to click on and view the settings for a tag.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the tag to get.</param>
        /// <returns></returns>
        void Tagget (string token, Guid? id);
        /// <summary>
        /// View a list of tags Allows the user to view the list of tags.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="group">The group of the tags to return.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Taglist (string token, string group, int? from, int? count);
        /// <summary>
        /// View a list of entities that can be tagged Allows the user to view the list of user roles that can be tagged, according to that tag&#39;s settings.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Taglistgroups (string token);
        /// <summary>
        /// Create or edit a tag Allows the user to create or edit a tag.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Tagsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Search for tags in the account Allows the user to search for tags.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="query">The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory).</param>
        /// <param name="allowcreatingnew">Specifies whether an option to create a new tag should be retrieved.</param>
        /// <returns></returns>
        void Tagsearch (string token, string query, bool? allowcreatingnew);
        /// <summary>
        /// Add an image to a template Allows the user to add an image to a badge or certificate template.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="template">The id of the template where the image has to be added</param>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The local name of the uploaded file. For later reference.</param>
        /// <returns></returns>
        void Templateaddimage (string token, Guid? template, string upload, string filename);
        /// <summary>
        /// Delete a template Allows the user to delete an existing template.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the template to delete.</param>
        /// <returns></returns>
        void Templatedelete (string token, Guid? id);
        /// <summary>
        /// Send generated templates by email Allows the user to send generated templates via email through AccuCampus.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="jobid">The id of the job that is creating the templates.</param>
        /// <param name="emailsubject">Args depending on the send-to flag.</param>
        /// <param name="emailbody">Args depending on the send-to flag.</param>
        /// <param name="templatekind">The kind of the template you&#39;re sending. It must be included in (badge, certificate).</param>
        /// <param name="emailfrom">The name of the sender to be displayed in the receipients inbox</param>
        /// <param name="emailreplyto">The reply-to field for the emails.</param>
        /// <returns></returns>
        void Templateemail (string token, string jobid, string emailsubject, string emailbody, string templatekind, string emailfrom, string emailreplyto);
        /// <summary>
        /// Generate specified templates Allows the user to generate an existing template as badges or certificates.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="template">The id of the template to generate.</param>
        /// <param name="source">The source key of the selected template data source.</param>
        /// <param name="singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param>
        /// <param name="userid">Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas.</param>
        /// <param name="forsending">It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading</param>
        /// <param name="role">When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor</param>
        /// <param name="filters">Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|...</param>
        /// <returns></returns>
        void Templategenerate (string token, Guid? template, Guid? source, bool? singlefile, string userid, bool? forsending, Guid? role, string filters);
        /// <summary>
        /// View details of a template Allows the user to view a template and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the template to get.</param>
        /// <returns></returns>
        void Templateget (string token, Guid? id);
        /// <summary>
        /// View generated templates Allows the user to view templates which have been generated as badges or certificates.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="jobid">The id of the job that is creating the templates.</param>
        /// <returns></returns>
        void Templategetgenerated (string token, string jobid);
        /// <summary>
        /// View a list of defined templates Allows the user to view the full list of created templates.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param>
        /// <param name="designedonly">If true then it only returns the templates that were designed. Otherwise, it returns all.</param>
        /// <returns></returns>
        void Templatelist (string token, int? from, int? count, string kind, bool? designedonly);
        /// <summary>
        /// View a list of templates&#39; data sources Allows the user to see tokens to be used in the template
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param>
        /// <returns></returns>
        void Templatelistsources (string token, string kind);
        /// <summary>
        /// Create or edit a template Allows the user to create or edit a template.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Templatesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Save the layout of a template Allows the user to edit a template&#39;s layout.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Templatesavelayout (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete a term Allows the user to delete a term from the existing list.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the term to delete.</param>
        /// <returns></returns>
        void Termdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of a term Allows the user to view a term and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the term to get.</param>
        /// <returns></returns>
        void Termget (string token, Guid? id);
        /// <summary>
        /// Search and view details of all terms Allows the user to view the full list of existing term.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="notpast">Specifies whether the terms in the past should be returned or not.</param>
        /// <returns></returns>
        void Termlist (string token, int? from, int? count, bool? notpast);
        /// <summary>
        /// Create and edit terms Allows the user to create and edit terms.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Termsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Gets the remaining text credits for the account 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Textcreditremaining (string token);
        /// <summary>
        /// Generates a dynamic image from text 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="text">The text to convert to an image, use double pipes (||) as a new line.</param>
        /// <param name="fontcolor">The color of the text, in hex format, without the #.</param>
        /// <param name="fontsize">The size of the text, in points.</param>
        /// <param name="direction">Either vertical or horizontal, default horizontal.</param>
        /// <param name="width">The image width in pixels (or height if the direction is vertical).</param>
        /// <returns></returns>
        void Texttoimage (string token, string text, string fontcolor, int? fontsize, string direction, int? width);
        /// <summary>
        /// Gets the translations of the specified values 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="universal">Pipe separated list of universal text to be translated.</param>
        /// <returns></returns>
        void Translationget (string token, string universal);
        /// <summary>
        /// Get the file containing the translations 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="account">The id of the account whose translations file has to be retrieved.</param>
        /// <returns></returns>
        void Translationgetcachefile (string token, string account);
        /// <summary>
        /// Lists all the available translations in the system 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="filter">Text to search/filter translations.</param>
        /// <param name="nondefaultonly">If true then it returns only the terms translated. Otherwise, it returns all.</param>
        /// <param name="appdefaultasuniversal">If true then it uses the app default translation as the universal term.</param>
        /// <returns></returns>
        void Translationlist (string token, string filter, bool? nondefaultonly, bool? appdefaultasuniversal);
        /// <summary>
        /// Edit a translation Allows the user to edit a translation for the entire account.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Translationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Change user&#39;s own password Allows the user to change their own password.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="oldpass">The old password of the authenticated user.</param>
        /// <param name="newpass">The new password of the authenticated user.</param>
        /// <returns></returns>
        void Userchangepwd (string token, Guid? oldpass, Guid? newpass);
        /// <summary>
        /// Changes the user password using a change password request id 
        /// </summary>
        /// <param name="changereq">The change password request ID sent by email to the user.</param>
        /// <param name="newpass">The new password of the user.</param>
        /// <returns></returns>
        void Userchangepwdbyreq (string changereq, string newpass);
        /// <summary>
        /// Delete a user Allows the user to delete a user.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the user to delete.</param>
        /// <returns></returns>
        void Userdelete (string token, Guid? id);
        /// <summary>
        /// Finds similar users to prevent duplicates Allows the user to be warned if a user they are creating has the same card number as another user.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="currentid">The id of the current user.</param>
        /// <param name="phonenumber">A phone number to search for similar users.</param>
        /// <param name="cardnumber">A card number to search for similar users.</param>
        /// <returns></returns>
        void Userfindsimilar (string token, Guid? currentid, string phonenumber, string cardnumber);
        /// <summary>
        /// Search and view details of a user Allows the user to search and view a user and their details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the user to get.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void Userget (string token, Guid? id, int? photosize);
        /// <summary>
        /// Search user by card number Allows the user to search for a user by their card number.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="card">The card number of the user to get.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void Usergetbycard (string token, string card, int? photosize);
        /// <summary>
        /// Add a user to a group Allows the user to add a user to a group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="groupid">The id of the group.</param>
        /// <returns></returns>
        void Usergroupaddmember (string token, Guid? userid, Guid? groupid);
        /// <summary>
        /// Delete a group Allows the user to delete a group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the group to delete.</param>
        /// <returns></returns>
        void Usergroupdelete (string token, Guid? id);
        /// <summary>
        /// Search and view details of a user group Allows the user to view a user group and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the user group to get.</param>
        /// <returns></returns>
        void Usergroupget (string token, Guid? id);
        /// <summary>
        /// View the members of a user group Allows the user to view the list of users in a group that they have permission to view.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="groupid">The id of the user group to get.</param>
        /// <returns></returns>
        void Usergroupgetmembers (string token, Guid? groupid);
        /// <summary>
        /// View the groups which a user is registered to Allows the user to view the groups an individual user is registered to, based on group and user permissions.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">The id of the user to get his groups.</param>
        /// <returns></returns>
        void Usergroupgetuser (string token, Guid? userid);
        /// <summary>
        /// View a list of user groups Allows the user to view the list of groups that they have permission to view.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="type">The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group.</param>
        /// <returns></returns>
        void Usergrouplist (string token, int? from, int? count, string type);
        /// <summary>
        /// Refresh the dynamic group Allows the user to refresh a dynamic group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="group">The ID of the group to refresh.</param>
        /// <returns></returns>
        void Usergrouprefresh (string token, Guid? group);
        /// <summary>
        /// Remove a user from a group Allows the user to remove a user from a group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="groupid">The id of the group.</param>
        /// <returns></returns>
        void Usergroupremovemember (string token, Guid? userid, Guid? groupid);
        /// <summary>
        /// Create or edit a group Allows the user to create a new group or edit a group that they have permission to edit.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Usergroupsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// View a list of users Allows the user to view the full list of users and is based on role permissions.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param>
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void Userlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize);
        /// <summary>
        /// Upload a photo for a specific user Allows the user to upload a photo for a user.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The local name of the uploaded file. For later reference.</param>
        /// <param name="userid">The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;.</param>
        /// <param name="automatch">Set this to true to find the specific user based on the file name. </param>
        /// <returns></returns>
        void Userloadphoto (string token, string upload, string filename, Guid? userid, bool? automatch);
        /// <summary>
        /// Move data between users Allows administrators to move data between users.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="source">The id of the user that is the source of the data.</param>
        /// <param name="destination">The id of the user that is the destination of the data.</param>
        /// <returns></returns>
        void Usermovedata (string token, Guid? source, Guid? destination);
        /// <summary>
        /// Requests a password change 
        /// </summary>
        /// <param name="domain">The domain of the account where the user exists.</param>
        /// <param name="email">The email of the user.</param>
        /// <returns></returns>
        void Userrequestpwdchange (string domain, string email);
        /// <summary>
        /// Create or edit a user Allows the user to create or edit a user.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Usersave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Send email to the specified user(s) to set/change their passwords Allows the user to trigger an email to another user asking them to set or change their password.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Usersavepwdchange (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Lists available user settings 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param>
        /// <param name="user">The user id whose settings have to be returned.</param>
        /// <returns></returns>
        void Usersettingsget (string token, string keys, Guid? user);
        /// <summary>
        /// Get multiple user settings 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param>
        /// <param name="user">The user id whose settings have to be returned.</param>
        /// <returns></returns>
        void Usersettingsgetmultiple (string token, string keys, Guid? user);
        /// <summary>
        /// Saves a user setting 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Usersettingssave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Save multiple user settings at once 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Usersettingssavemultiple (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Deletes a task plan 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the task plan to delete.</param>
        /// <returns></returns>
        void Usertaskdeleteplan (string token, Guid? id);
        /// <summary>
        /// Lists the task plans of the logged user 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Usertaskgetmine (string token);
        /// <summary>
        /// Gets a task plan by Id 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="id">The id of the task plan to get.</param>
        /// <returns></returns>
        void Usertaskgetplan (string token, Guid? id);
        /// <summary>
        /// Lists task types or definitions 
        /// </summary>
        /// <returns></returns>
        void Usertasklistdefs ();
        /// <summary>
        /// Lists task plans 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void Usertasklistplan (string token, int? from, int? count);
        /// <summary>
        /// Saves a task plan 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void Usertasksaveplan (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Get current version information 
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <returns></returns>
        void Version (string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
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
        /// Remove an action item from an action plan Allows a user to remove an action item from a user&#39;s action plan.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action assignment to delete.</param> 
        /// <returns></returns>            
        public void Actionassignmentdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionassignmentdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actionassignmentdelete");
            
    
            var path = "/actionassignmentdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an action item assigned to a user Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action assignment to get.</param> 
        /// <returns></returns>            
        public void Actionassignmentget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionassignmentget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actionassignmentget");
            
    
            var path = "/actionassignmentget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of action items in a user&#39;s plan Allows the user to view the list of all action items for a specified user.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="assignee">The assignee&#39;s id to filter the assignments.</param> 
        /// <param name="status">The status to filter the assignments.</param> 
        /// <returns></returns>            
        public void Actionassignmentlist (string token, int? from, int? count, int? assignee, int? status)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionassignmentlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Actionassignmentlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Actionassignmentlist");
            
    
            var path = "/actionassignmentlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the history of an action item assigned to a user Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param> 
        /// <returns></returns>            
        public void Actionassignmentlisthistory (string token, Guid? actionassignment)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionassignmentlisthistory");
            
            // verify the required parameter 'actionassignment' is set
            if (actionassignment == null) throw new ApiException(400, "Missing required parameter 'actionassignment' when calling Actionassignmentlisthistory");
            
    
            var path = "/actionassignmentlisthistory";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (actionassignment != null) queryParams.Add("actionassignment", ApiClient.ParameterToString(actionassignment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlisthistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlisthistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List public action assignments assigned to the logged user 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="status">The status to filter the assignments.</param> 
        /// <returns></returns>            
        public void Actionassignmentlistmine (string token, int? from, int? count, int? status)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionassignmentlistmine");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Actionassignmentlistmine");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Actionassignmentlistmine");
            
    
            var path = "/actionassignmentlistmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlistmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlistmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List public action assignment history 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param> 
        /// <returns></returns>            
        public void Actionassignmentlistpublichistory (string token, Guid? actionassignment)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionassignmentlistpublichistory");
            
            // verify the required parameter 'actionassignment' is set
            if (actionassignment == null) throw new ApiException(400, "Missing required parameter 'actionassignment' when calling Actionassignmentlistpublichistory");
            
    
            var path = "/actionassignmentlistpublichistory";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (actionassignment != null) queryParams.Add("actionassignment", ApiClient.ParameterToString(actionassignment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlistpublichistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentlistpublichistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Bulk complete action items Allows the user to bulk complete action items.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="item">The action item to assign.</param> 
        /// <param name="assignee">The assignee of the item.</param> 
        /// <param name="group">The group to assing the item.</param> 
        /// <param name="notes">The assignment&#39;s notes.</param> 
        /// <returns></returns>            
        public void Actionassignmentmarkcomplete (string token, string item, Guid? assignee, Guid? group, string notes)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionassignmentmarkcomplete");
            
            // verify the required parameter 'item' is set
            if (item == null) throw new ApiException(400, "Missing required parameter 'item' when calling Actionassignmentmarkcomplete");
            
    
            var path = "/actionassignmentmarkcomplete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
 if (item != null) queryParams.Add("item", ApiClient.ParameterToString(item)); // query parameter
 if (notes != null) queryParams.Add("notes", ApiClient.ParameterToString(notes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentmarkcomplete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentmarkcomplete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add an action item to a user&#39;s action plan Allows the user to edit or assign an action item to a user
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Actionassignmentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/actionassignmentsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an action item assigned to a user Allows the user to update or mark an action item as complete.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Actionassignmentsavehistory (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/actionassignmentsavehistory";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentsavehistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionassignmentsavehistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an action item Allows the user to delete an action item.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action item to delete.</param> 
        /// <returns></returns>            
        public void Actionitemdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionitemdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actionitemdelete");
            
    
            var path = "/actionitemdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an action item Allows the user to view an individual action item and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action item to get.</param> 
        /// <returns></returns>            
        public void Actionitemget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionitemget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actionitemget");
            
    
            var path = "/actionitemget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of action items Allows the user to view a list of action items
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Actionitemlist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionitemlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Actionitemlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Actionitemlist");
            
    
            var path = "/actionitemlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit an action item Allows the user to edit an action item.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Actionitemsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/actionitemsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionitemsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of users action logs Allows the user to view the audit logs for the account.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="user">The id of the user whose action logs have to be returned.</param> 
        /// <param name="startdate">The start date of the period to filter the logs.</param> 
        /// <param name="enddate">The end date of the period to filter the logs.</param> 
        /// <param name="resource">The resource to filter the action logs.</param> 
        /// <param name="actionfilter">The action to filter the action logs.</param> 
        /// <param name="argument">The id of the entity that was the argument of the executed action.</param> 
        /// <returns></returns>            
        public void Actionloglist (string token, int? from, int? count, Guid? user, DateTime? startdate, DateTime? enddate, string resource, string actionfilter, string argument)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionloglist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Actionloglist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Actionloglist");
            
    
            var path = "/actionloglist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
 if (resource != null) queryParams.Add("resource", ApiClient.ParameterToString(resource)); // query parameter
 if (actionfilter != null) queryParams.Add("actionfilter", ApiClient.ParameterToString(actionfilter)); // query parameter
 if (argument != null) queryParams.Add("argument", ApiClient.ParameterToString(argument)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionloglist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionloglist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Assign an action item pack to a user Allows the user to assign an action pack to a user or group of users.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="pack">The id of the action pack to assign.</param> 
        /// <param name="itemsdata">A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).</param> 
        /// <param name="assignee">The assignee of the pack.</param> 
        /// <param name="group">The group to assign the pack.</param> 
        /// <param name="notes">The assignment&#39;s notes.</param> 
        /// <returns></returns>            
        public void Actionpackassign (string token, Guid? pack, bool? itemsdata, Guid? assignee, Guid? group, string notes)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionpackassign");
            
            // verify the required parameter 'pack' is set
            if (pack == null) throw new ApiException(400, "Missing required parameter 'pack' when calling Actionpackassign");
            
            // verify the required parameter 'itemsdata' is set
            if (itemsdata == null) throw new ApiException(400, "Missing required parameter 'itemsdata' when calling Actionpackassign");
            
    
            var path = "/actionpackassign";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (pack != null) queryParams.Add("pack", ApiClient.ParameterToString(pack)); // query parameter
 if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
 if (itemsdata != null) queryParams.Add("itemsdata", ApiClient.ParameterToString(itemsdata)); // query parameter
 if (notes != null) queryParams.Add("notes", ApiClient.ParameterToString(notes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpackassign: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpackassign: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an action item pack Allows the user to delete an action item pack.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action pack to delete.</param> 
        /// <returns></returns>            
        public void Actionpackdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionpackdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actionpackdelete");
            
    
            var path = "/actionpackdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpackdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpackdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of an action item pack Allows the user to view an individual action pack and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action pack to get.</param> 
        /// <returns></returns>            
        public void Actionpackget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionpackget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actionpackget");
            
    
            var path = "/actionpackget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpackget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpackget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of action item packs Allows the user to view the full list of action item packs.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Actionpacklist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actionpacklist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Actionpacklist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Actionpacklist");
            
    
            var path = "/actionpacklist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpacklist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpacklist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit an action item pack Allows the user to edit an action item pack.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Actionpacksave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/actionpacksave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpacksave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actionpacksave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an action item type Allows the user to delete an action item type.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action type to delete.</param> 
        /// <returns></returns>            
        public void Actiontypedelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actiontypedelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actiontypedelete");
            
    
            var path = "/actiontypedelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypedelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypedelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of an action item type Allows the user to view an individual action item type and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the action type to get.</param> 
        /// <returns></returns>            
        public void Actiontypeget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actiontypeget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Actiontypeget");
            
    
            var path = "/actiontypeget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypeget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypeget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of action item types Allows the user to view the full list of action item types.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Actiontypelist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Actiontypelist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Actiontypelist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Actiontypelist");
            
    
            var path = "/actiontypelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit an action item type Allows the user to dit an action item type.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Actiontypesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/actiontypesave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypesave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Actiontypesave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Adds the missing permissions to a role. Requires access to advrole.save 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="roles">CSV list of the role ids to check</param> 
        /// <param name="permissions">CSV list of the permissions to check</param> 
        /// <returns></returns>            
        public void Advroleaddmissing (string token, string roles, string permissions)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advroleaddmissing");
            
            // verify the required parameter 'roles' is set
            if (roles == null) throw new ApiException(400, "Missing required parameter 'roles' when calling Advroleaddmissing");
            
            // verify the required parameter 'permissions' is set
            if (permissions == null) throw new ApiException(400, "Missing required parameter 'permissions' when calling Advroleaddmissing");
            
    
            var path = "/advroleaddmissing";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (roles != null) queryParams.Add("roles", ApiClient.ParameterToString(roles)); // query parameter
 if (permissions != null) queryParams.Add("permissions", ApiClient.ParameterToString(permissions)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroleaddmissing: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroleaddmissing: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Checks the permissions are assigned for the given roles 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="roles">CSV list of the role ids to check</param> 
        /// <param name="permissions">CSV list of the permissions to check</param> 
        /// <returns></returns>            
        public void Advrolecheckperm (string token, string roles, string permissions)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advrolecheckperm");
            
            // verify the required parameter 'roles' is set
            if (roles == null) throw new ApiException(400, "Missing required parameter 'roles' when calling Advrolecheckperm");
            
            // verify the required parameter 'permissions' is set
            if (permissions == null) throw new ApiException(400, "Missing required parameter 'permissions' when calling Advrolecheckperm");
            
    
            var path = "/advrolecheckperm";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (roles != null) queryParams.Add("roles", ApiClient.ParameterToString(roles)); // query parameter
 if (permissions != null) queryParams.Add("permissions", ApiClient.ParameterToString(permissions)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolecheckperm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolecheckperm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a role Allows the user to delete a role from the list of available roles.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the location to delete.</param> 
        /// <returns></returns>            
        public void Advroledelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advroledelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Advroledelete");
            
    
            var path = "/advroledelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroledelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroledelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a role mapping Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="map">The map name to save the role.</param> 
        /// <param name="roleid">The id of the role.</param> 
        /// <returns></returns>            
        public void Advroledeletemapping (string token, string map, Guid? roleid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advroledeletemapping");
            
            // verify the required parameter 'map' is set
            if (map == null) throw new ApiException(400, "Missing required parameter 'map' when calling Advroledeletemapping");
            
            // verify the required parameter 'roleid' is set
            if (roleid == null) throw new ApiException(400, "Missing required parameter 'roleid' when calling Advroledeletemapping");
            
    
            var path = "/advroledeletemapping";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroledeletemapping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroledeletemapping: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a role Allows the user to view a role and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the location to get.</param> 
        /// <returns></returns>            
        public void Advroleget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advroleget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Advroleget");
            
    
            var path = "/advroleget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroleget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroleget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the roles for the current account 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="includepolicies">True to include the policies, defaults to false.</param> 
        /// <param name="includeinternal">True to include the internal roles too.</param> 
        /// <param name="name">Filter by name of the role.</param> 
        /// <returns></returns>            
        public void Advrolelist (string token, bool? includepolicies, bool? includeinternal, string name)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advrolelist");
            
    
            var path = "/advrolelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (includepolicies != null) queryParams.Add("includepolicies", ApiClient.ParameterToString(includepolicies)); // query parameter
 if (includeinternal != null) queryParams.Add("includeinternal", ApiClient.ParameterToString(includeinternal)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the maps a roles is mapped to 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="roleid">The id of the role to list the maps.</param> 
        /// <returns></returns>            
        public void Advrolelistmaps (string token, Guid? roleid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advrolelistmaps");
            
            // verify the required parameter 'roleid' is set
            if (roleid == null) throw new ApiException(400, "Missing required parameter 'roleid' when calling Advrolelistmaps");
            
    
            var path = "/advrolelistmaps";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelistmaps: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelistmaps: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the roles mappings 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="map">List only the roles in the specified map.</param> 
        /// <returns></returns>            
        public void Advrolelistrolesmapped (string token, string map)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advrolelistrolesmapped");
            
    
            var path = "/advrolelistrolesmapped";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelistrolesmapped: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelistrolesmapped: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of role templates Allows the user to view the full list of available role templates.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Advrolelisttemplates (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advrolelisttemplates");
            
    
            var path = "/advrolelisttemplates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelisttemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolelisttemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a role Allows the user to create or edit a role&#39;s permissions.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Advrolesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/advrolesave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolesave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolesave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a role mapping Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Advrolesavemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/advrolesavemapping";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolesavemapping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolesavemapping: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List users. Alias to user.list, use that one instead. 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param> 
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void Advrolesuserlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advrolesuserlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Advrolesuserlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Advrolesuserlist");
            
    
            var path = "/advrolesuserlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
 if (onlywithoutcard != null) queryParams.Add("onlywithoutcard", ApiClient.ParameterToString(onlywithoutcard)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolesuserlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advrolesuserlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Upgrade a user to another role (requires permission to edit those roles) Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">Id of the user to upgrade</param> 
        /// <param name="roleid">Id of the role to add</param> 
        /// <returns></returns>            
        public void Advroleuserupgrade (string token, Guid? userid, Guid? roleid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Advroleuserupgrade");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Advroleuserupgrade");
            
            // verify the required parameter 'roleid' is set
            if (roleid == null) throw new ApiException(400, "Missing required parameter 'roleid' when calling Advroleuserupgrade");
            
    
            var path = "/advroleuserupgrade";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroleuserupgrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Advroleuserupgrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the phone number of the current user 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Appsharegetphone (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Appsharegetphone");
            
    
            var path = "/appsharegetphone";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Appsharegetphone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Appsharegetphone: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sends an SMS with the link to the app 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="phonenumber">Phone number to where to send the link. Leave empty to the number on file.</param> 
        /// <returns></returns>            
        public void Appsharesendtext (string token, string phonenumber)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Appsharesendtext");
            
    
            var path = "/appsharesendtext";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (phonenumber != null) queryParams.Add("phonenumber", ApiClient.ParameterToString(phonenumber)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Appsharesendtext: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Appsharesendtext: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a comment on an attendance log 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the attendance log comment to delete.</param> 
        /// <returns></returns>            
        public void Attendancelogcommentdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Attendancelogcommentdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Attendancelogcommentdelete");
            
    
            var path = "/attendancelogcommentdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a comment on an attendance log 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the comment to get.</param> 
        /// <returns></returns>            
        public void Attendancelogcommentget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Attendancelogcommentget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Attendancelogcommentget");
            
    
            var path = "/attendancelogcommentget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the comments on a specific attendance log 
        /// </summary>
        /// <param name="attendancelog">The id of the attendance log whose comments have to be retrieved.</param> 
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Attendancelogcommentlist (Guid? attendancelog, string token)
        {
            
            // verify the required parameter 'attendancelog' is set
            if (attendancelog == null) throw new ApiException(400, "Missing required parameter 'attendancelog' when calling Attendancelogcommentlist");
            
    
            var path = "/attendancelogcommentlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (attendancelog != null) queryParams.Add("attendancelog", ApiClient.ParameterToString(attendancelog)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save a comment on an attendance log 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Attendancelogcommentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/attendancelogcommentsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogcommentsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an attendance log Allows the user to delete an existing attendance log.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the attendance log to delete.</param> 
        /// <returns></returns>            
        public void Attendancelogdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Attendancelogdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Attendancelogdelete");
            
    
            var path = "/attendancelogdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an attendance log Allows the user to view an individual attendance log and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the attendance log to get.</param> 
        /// <returns></returns>            
        public void Attendancelogget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Attendancelogget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Attendancelogget");
            
    
            var path = "/attendancelogget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an attendance log&#39;s swipe history Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the attendance log to get.</param> 
        /// <returns></returns>            
        public void Attendanceloggetchangehistory (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Attendanceloggetchangehistory");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Attendanceloggetchangehistory");
            
    
            var path = "/attendanceloggetchangehistory";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendanceloggetchangehistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendanceloggetchangehistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of attendance logs Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="token">The authentication token.</param> 
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param> 
        /// <param name="userid">The user ID of the user to get the logs.</param> 
        /// <returns></returns>            
        public void Attendanceloglist (int? from, int? count, string token, string filter, Guid? userid)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Attendanceloglist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Attendanceloglist");
            
    
            var path = "/attendanceloglist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendanceloglist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendanceloglist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the attendance logs of the current user 
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="token">The authentication token.</param> 
        /// <param name="filter">Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.</param> 
        /// <returns></returns>            
        public void Attendanceloglistmine (int? from, int? count, string token, string filter)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Attendanceloglistmine");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Attendanceloglistmine");
            
    
            var path = "/attendanceloglistmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendanceloglistmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendanceloglistmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit an attendance log Allows the user to create or edit an attendance log.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Attendancelogsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/attendancelogsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sign out an attendance log Allows the user to sign out am attendance log from the Who&#39;s In page.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the attendance log to sign-out.</param> 
        /// <param name="location">The id of the location to filter the users to sign out.</param> 
        /// <param name="_event">The id of the event to filter the users to sign out.</param> 
        /// <param name="datetime">Specifies the date and time when the specified logs have to be signed out.</param> 
        /// <returns></returns>            
        public void Attendancelogsignout (string token, Guid? id, Guid? location, Guid? _event, DateTime? datetime)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Attendancelogsignout");
            
    
            var path = "/attendancelogsignout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (datetime != null) queryParams.Add("datetime", ApiClient.ParameterToString(datetime)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogsignout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogsignout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View who&#39;s in a location Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="token">The authentication token.</param> 
        /// <param name="location">The id of the location to search for users that are in.</param> 
        /// <param name="_event">The id of the event to search for users that are in.</param> 
        /// <param name="sorting">Field to sort by. Either first-name, last-name or sign-in-time.</param> 
        /// <param name="roles">The comma-separated list of ids of the roles to search for users that are in.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <param name="extensions">A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]).</param> 
        /// <param name="export">True to export the results as CSV</param> 
        /// <returns></returns>            
        public void Attendancelogwhosin (int? from, int? count, string token, Guid? location, Guid? _event, string sorting, string roles, int? photosize, string extensions, bool? export)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Attendancelogwhosin");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Attendancelogwhosin");
            
    
            var path = "/attendancelogwhosin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (sorting != null) queryParams.Add("sorting", ApiClient.ParameterToString(sorting)); // query parameter
 if (roles != null) queryParams.Add("roles", ApiClient.ParameterToString(roles)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
 if (extensions != null) queryParams.Add("extensions", ApiClient.ParameterToString(extensions)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogwhosin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Attendancelogwhosin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get background job status 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="jobid">The ID of the job to get the status. 10 most recent will be returned if not specified.</param> 
        /// <param name="jobtype">The job type to filter by.</param> 
        /// <returns></returns>            
        public void Bgjobgetstatus (string token, Guid? jobid, string jobtype)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Bgjobgetstatus");
            
    
            var path = "/bgjobgetstatus";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (jobid != null) queryParams.Add("jobid", ApiClient.ParameterToString(jobid)); // query parameter
 if (jobtype != null) queryParams.Add("jobtype", ApiClient.ParameterToString(jobtype)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Bgjobgetstatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Bgjobgetstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a captcha challenge that the user must complete to do certain requests. 
        /// </summary>
        /// <returns></returns>            
        public void Captchagetchallenge ()
        {
            
    
            var path = "/captchagetchallenge";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Captchagetchallenge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Captchagetchallenge: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a captcha image that the user must complete to do certain requests. 
        /// </summary>
        /// <param name="captchatoken">The captcha token or ID returned by the captcha.getchallenge action</param> 
        /// <returns></returns>            
        public void Captchagetimage (string captchatoken)
        {
            
            // verify the required parameter 'captchatoken' is set
            if (captchatoken == null) throw new ApiException(400, "Missing required parameter 'captchatoken' when calling Captchagetimage");
            
    
            var path = "/captchagetimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (captchatoken != null) queryParams.Add("captchatoken", ApiClient.ParameterToString(captchatoken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Captchagetimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Captchagetimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the application change log 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Changelog (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Changelog");
            
    
            var path = "/changelog";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Changelog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Changelog: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get client 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="_client">The unique id of the client.</param> 
        /// <param name="clientname">The custom name of the client.</param> 
        /// <returns></returns>            
        public void Clientget (string token, string _client, string clientname)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Clientget");
            
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling Clientget");
            
    
            var path = "/clientget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (_client != null) queryParams.Add("client", ApiClient.ParameterToString(_client)); // query parameter
 if (clientname != null) queryParams.Add("clientname", ApiClient.ParameterToString(clientname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Clientget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Clientget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the clients of the specified conference 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Clientlist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Clientlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Clientlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Clientlist");
            
    
            var path = "/clientlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Clientlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Clientlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a client 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Clientsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/clientsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Clientsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Clientsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a message to a client 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="uniqueclientid">The unique id of the client.</param> 
        /// <param name="message">The body of the message to send.</param> 
        /// <returns></returns>            
        public void Clientsendmessage (string token, Guid? uniqueclientid, string message)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Clientsendmessage");
            
            // verify the required parameter 'uniqueclientid' is set
            if (uniqueclientid == null) throw new ApiException(400, "Missing required parameter 'uniqueclientid' when calling Clientsendmessage");
            
            // verify the required parameter 'message' is set
            if (message == null) throw new ApiException(400, "Missing required parameter 'message' when calling Clientsendmessage");
            
    
            var path = "/clientsendmessage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (uniqueclientid != null) queryParams.Add("uniqueclientid", ApiClient.ParameterToString(uniqueclientid)); // query parameter
 if (message != null) queryParams.Add("message", ApiClient.ParameterToString(message)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Clientsendmessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Clientsendmessage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a college department Allows the user to delete an existing college department.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the department to delete.</param> 
        /// <returns></returns>            
        public void Departmentdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Departmentdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Departmentdelete");
            
    
            var path = "/departmentdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a college department Allows the user to view an individual college department and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the department to get.</param> 
        /// <returns></returns>            
        public void Departmentget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Departmentget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Departmentget");
            
    
            var path = "/departmentget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of college departments Allows the user to view the full list of college departments.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Departmentlist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Departmentlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Departmentlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Departmentlist");
            
    
            var path = "/departmentlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a college department Allows the user to create or edit a college department.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Departmentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/departmentsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Departmentsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the documentation Retrieves the list of actions available in the system.
        /// </summary>
        /// <param name="excludeanonymous">If true it excludes the anonymous actions from the returned list.</param> 
        /// <returns></returns>            
        public void Doc (bool? excludeanonymous)
        {
            
    
            var path = "/doc";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (excludeanonymous != null) queryParams.Add("excludeanonymous", ApiClient.ParameterToString(excludeanonymous)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Doc: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Doc: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Adds background image for the login Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The original filename, needed to process the file.</param> 
        /// <returns></returns>            
        public void Easyloginaddbgimage (string token, string upload, string filename)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Easyloginaddbgimage");
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling Easyloginaddbgimage");
            
            // verify the required parameter 'filename' is set
            if (filename == null) throw new ApiException(400, "Missing required parameter 'filename' when calling Easyloginaddbgimage");
            
    
            var path = "/easyloginaddbgimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Easyloginaddbgimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Easyloginaddbgimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a course Allows the user to delete an existing course.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the event to delete.</param> 
        /// <returns></returns>            
        public void Eventdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Eventdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Eventdelete");
            
    
            var path = "/eventdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a course Allows the user to view an individual course and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the event to get.</param> 
        /// <returns></returns>            
        public void Eventget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Eventget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Eventget");
            
    
            var path = "/eventget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of courses by date Allows the user to view a list of courses by date.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="location">The location to filter the events.</param> 
        /// <param name="date">The date to filter the events. Today will be used if this parameter is omitted.</param> 
        /// <param name="type">Type of event to list.</param> 
        /// <returns></returns>            
        public void Eventgetsessionsbydate (string token, Guid? location, DateTime? date, string type)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Eventgetsessionsbydate");
            
    
            var path = "/eventgetsessionsbydate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventgetsessionsbydate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventgetsessionsbydate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of courses Allows the user to view the full list of courses.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="summaryonly">True to return only the event information and not the associated schedule, dept, etc. Defaults to false.</param> 
        /// <param name="termid">Id of the term to list the events. Null to list all events.</param> 
        /// <returns></returns>            
        public void Eventlist (string token, string from, string count, bool? summaryonly, Guid? termid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Eventlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Eventlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Eventlist");
            
    
            var path = "/eventlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (summaryonly != null) queryParams.Add("summaryonly", ApiClient.ParameterToString(summaryonly)); // query parameter
 if (termid != null) queryParams.Add("termid", ApiClient.ParameterToString(termid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a course Allows the user to create or edit a course.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Eventsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/eventsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Eventsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Searches for the available event groups 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="query">Query to search event groups.</param> 
        /// <returns></returns>            
        public void Eventsearchgroup (string token, Guid? query)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Eventsearchgroup");
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling Eventsearchgroup");
            
    
            var path = "/eventsearchgroup";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventsearchgroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Eventsearchgroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Export AccuCampus data Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="exporttype">What to export.</param> 
        /// <param name="exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param> 
        /// <param name="filters">Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|...</param> 
        /// <returns></returns>            
        public void Export (string token, string exporttype, string exportformat, string filters)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Export");
            
            // verify the required parameter 'exporttype' is set
            if (exporttype == null) throw new ApiException(400, "Missing required parameter 'exporttype' when calling Export");
            
            // verify the required parameter 'exportformat' is set
            if (exportformat == null) throw new ApiException(400, "Missing required parameter 'exportformat' when calling Export");
            
    
            var path = "/export";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (exporttype != null) queryParams.Add("exporttype", ApiClient.ParameterToString(exporttype)); // query parameter
 if (exportformat != null) queryParams.Add("exportformat", ApiClient.ParameterToString(exportformat)); // query parameter
 if (filters != null) queryParams.Add("filters", ApiClient.ParameterToString(filters)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Export: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Export: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists available export types 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Exportlisttypes (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Exportlisttypes");
            
    
            var path = "/exportlisttypes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Exportlisttypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Exportlisttypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the available features. 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Featurelist (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Featurelist");
            
    
            var path = "/featurelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Featurelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Featurelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of entered holidays Allows the user to view all holidays entered.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="term">The term to get holidays from.</param> 
        /// <returns></returns>            
        public void Holidaylist (string token, Guid? term)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Holidaylist");
            
            // verify the required parameter 'term' is set
            if (term == null) throw new ApiException(400, "Missing required parameter 'term' when calling Holidaylist");
            
    
            var path = "/holidaylist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (term != null) queryParams.Add("term", ApiClient.ParameterToString(term)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Holidaylist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Holidaylist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a list of holidays Allows the user to create or edit holidays.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Holidaysave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/holidaysave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Holidaysave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Holidaysave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the holiday suggestions in the given term Allows the user to view the holiday suggestions for each term.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="term">The term to get holidays from.</param> 
        /// <returns></returns>            
        public void Holidaysuggest (string token, Guid? term)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Holidaysuggest");
            
            // verify the required parameter 'term' is set
            if (term == null) throw new ApiException(400, "Missing required parameter 'term' when calling Holidaysuggest");
            
    
            var path = "/holidaysuggest";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (term != null) queryParams.Add("term", ApiClient.ParameterToString(term)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Holidaysuggest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Holidaysuggest: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Import data into AccuCampus Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="importtype">The kind of data that is being uploaded.</param> 
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The local name of the uploaded file. For later reference.</param> 
        /// <param name="parameters">Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}.</param> 
        /// <returns></returns>            
        public void Import (string token, string importtype, string upload, string filename, string parameters)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Import");
            
            // verify the required parameter 'importtype' is set
            if (importtype == null) throw new ApiException(400, "Missing required parameter 'importtype' when calling Import");
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling Import");
            
    
            var path = "/import";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (importtype != null) queryParams.Add("importtype", ApiClient.ParameterToString(importtype)); // query parameter
 if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
 if (parameters != null) queryParams.Add("parameters", ApiClient.ParameterToString(parameters)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Import: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Import: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists available import types 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Importlisttypes (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Importlisttypes");
            
    
            var path = "/importlisttypes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Importlisttypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Importlisttypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Accept the license agreement 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Licenseacceptagreement (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Licenseacceptagreement");
            
    
            var path = "/licenseacceptagreement";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Licenseacceptagreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Licenseacceptagreement: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Check if license agreement has been accepted 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Licensegetagreementstatus (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Licensegetagreementstatus");
            
    
            var path = "/licensegetagreementstatus";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Licensegetagreementstatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Licensegetagreementstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Licensegetcurrent (string token)
        {
            
    
            var path = "/licensegetcurrent";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Licensegetcurrent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Licensegetcurrent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Contact Engineerica in order to renew the AccuCampus subscription Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="email">The e-mail of the user sending the request.</param> 
        /// <param name="phonenumber">The phone number of the user sending the request.</param> 
        /// <param name="jobtitle">The job title of the user sending the request.</param> 
        /// <param name="institution">The institution of the user sending the request.</param> 
        /// <param name="comments">Comments entered by the user sending the request.</param> 
        /// <returns></returns>            
        public void Licenserenew (string token, string email, string phonenumber, string jobtitle, string institution, string comments)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Licenserenew");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Licenserenew");
            
            // verify the required parameter 'phonenumber' is set
            if (phonenumber == null) throw new ApiException(400, "Missing required parameter 'phonenumber' when calling Licenserenew");
            
    
            var path = "/licenserenew";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
 if (phonenumber != null) queryParams.Add("phonenumber", ApiClient.ParameterToString(phonenumber)); // query parameter
 if (jobtitle != null) queryParams.Add("jobtitle", ApiClient.ParameterToString(jobtitle)); // query parameter
 if (institution != null) queryParams.Add("institution", ApiClient.ParameterToString(institution)); // query parameter
 if (comments != null) queryParams.Add("comments", ApiClient.ParameterToString(comments)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Licenserenew: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Licenserenew: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the available timezones 
        /// </summary>
        /// <returns></returns>            
        public void Listtimezones ()
        {
            
    
            var path = "/listtimezones";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Listtimezones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Listtimezones: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a location Allows the user to delete an existing location.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the location to delete.</param> 
        /// <returns></returns>            
        public void Locationdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Locationdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Locationdelete");
            
    
            var path = "/locationdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Locationdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Locationdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a location Allows the user to search and view an individual location and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the location to get.</param> 
        /// <returns></returns>            
        public void Locationget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Locationget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Locationget");
            
    
            var path = "/locationget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Locationget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Locationget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of locations Allows the user to view the list of all locations to which they are scoped.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="locations">The comma-separated list containing the ids of the locations to list.</param> 
        /// <param name="sortbygroup">True to list locations sorted by the &#39;Located In&#39; property. Defaults to false.</param> 
        /// <returns></returns>            
        public void Locationlist (string token, int? from, int? count, string locations, bool? sortbygroup)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Locationlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Locationlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Locationlist");
            
    
            var path = "/locationlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (locations != null) queryParams.Add("locations", ApiClient.ParameterToString(locations)); // query parameter
 if (sortbygroup != null) queryParams.Add("sortbygroup", ApiClient.ParameterToString(sortbygroup)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Locationlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Locationlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a location Allows the user to create or edit a location.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Locationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/locationsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Locationsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Locationsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="domain">The account domain to login.</param> 
        /// <param name="username">The username (email) of the user to login as.</param> 
        /// <param name="password">The password of the user to login as.</param> 
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param> 
        /// <param name="rememberme">If true then the session will not expire.</param> 
        /// <returns></returns>            
        public void Login (string domain, string username, string password, string method, bool? rememberme)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling Login");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling Login");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Login");
            
            // verify the required parameter 'method' is set
            if (method == null) throw new ApiException(400, "Missing required parameter 'method' when calling Login");
            
    
            var path = "/login";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
 if (username != null) queryParams.Add("username", ApiClient.ParameterToString(username)); // query parameter
 if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
 if (rememberme != null) queryParams.Add("rememberme", ApiClient.ParameterToString(rememberme)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Logout 
        /// </summary>
        /// <param name="token">The authentication token used to login.</param> 
        /// <returns></returns>            
        public void Logout (string token)
        {
            
    
            var path = "/logout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Logout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Logout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete memorized report Allows the user to delete a memorized report that they have created.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the report settings to delete.</param> 
        /// <returns></returns>            
        public void Memorizedreportdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Memorizedreportdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Memorizedreportdelete");
            
    
            var path = "/memorizedreportdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a memorized report Allows the user to view an individual memorized report and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the report configuration to get.</param> 
        /// <returns></returns>            
        public void Memorizedreportget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Memorizedreportget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Memorizedreportget");
            
    
            var path = "/memorizedreportget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of all his memorized reports Allows the user to view the list of all memorized reports that they have created.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="customname">If specified filters the memorized reports by custom name.</param> 
        /// <returns></returns>            
        public void Memorizedreportlist (string token, int? from, int? count, string customname)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Memorizedreportlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Memorizedreportlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Memorizedreportlist");
            
    
            var path = "/memorizedreportlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (customname != null) queryParams.Add("customname", ApiClient.ParameterToString(customname)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a memorized report Allows the user to create or edit a memorized report for themselves.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Memorizedreportsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/memorizedreportsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Memorizedreportsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the items on the menu 
        /// </summary>
        /// <param name="menuid">The Id of the menu to get.</param> 
        /// <returns></returns>            
        public void Menugetitems (string menuid)
        {
            
            // verify the required parameter 'menuid' is set
            if (menuid == null) throw new ApiException(400, "Missing required parameter 'menuid' when calling Menugetitems");
            
    
            var path = "/menugetitems";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (menuid != null) queryParams.Add("menuid", ApiClient.ParameterToString(menuid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Menugetitems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Menugetitems: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the logged in user account. 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Myaccount (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Myaccount");
            
    
            var path = "/myaccount";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Myaccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Myaccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the current time zone&#39;s iana name 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Myianatimezone (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Myianatimezone");
            
    
            var path = "/myianatimezone";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Myianatimezone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Myianatimezone: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the logged in user information. 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void Myprofile (string token, int? photosize)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Myprofile");
            
    
            var path = "/myprofile";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Myprofile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Myprofile: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the list of actions the user can execute. 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Myrights (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Myrights");
            
    
            var path = "/myrights";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Myrights: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Myrights: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates logged user&#39;s profile information 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Mysaveprofile (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/mysaveprofile";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Mysaveprofile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Mysaveprofile: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a notification Allows the user to delete an existing notification.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the notification to delete.</param> 
        /// <returns></returns>            
        public void Notificationdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Notificationdelete");
            
    
            var path = "/notificationdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a notification 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the notification to get.</param> 
        /// <returns></returns>            
        public void Notificationget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Notificationget");
            
    
            var path = "/notificationget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets all public (in station) notifications for the specific user 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <returns></returns>            
        public void Notificationgetforstation (Guid? station, string user)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling Notificationgetforstation");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling Notificationgetforstation");
            
    
            var path = "/notificationgetforstation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationgetforstation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationgetforstation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the number of unread notifications 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Notificationgetunreadcount (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationgetunreadcount");
            
    
            var path = "/notificationgetunreadcount";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationgetunreadcount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationgetunreadcount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of all sent notifications Allows the user to view the list of all sent notifications.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="recipient">The recipient whose notifications have to be listed.</param> 
        /// <param name="status">The status of the notifications to list. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <param name="sentonscreen">Specifies whether to list the notifications that were sent on-screen or not.</param> 
        /// <param name="sentemail">Specifies whether to list the notifications that were sent via e-mail or not.</param> 
        /// <param name="sentsms">Specifies whether to list the notifications that were sent via sms or not.</param> 
        /// <returns></returns>            
        public void Notificationlist (string token, int? from, int? count, Guid? recipient, int? status, DateTime? startdate, DateTime? enddate, bool? sentonscreen, bool? sentemail, bool? sentsms)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Notificationlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Notificationlist");
            
    
            var path = "/notificationlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (recipient != null) queryParams.Add("recipient", ApiClient.ParameterToString(recipient)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
 if (sentonscreen != null) queryParams.Add("sentonscreen", ApiClient.ParameterToString(sentonscreen)); // query parameter
 if (sentemail != null) queryParams.Add("sentemail", ApiClient.ParameterToString(sentemail)); // query parameter
 if (sentsms != null) queryParams.Add("sentsms", ApiClient.ParameterToString(sentsms)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the notifications sent to the current user 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="status">Specifies the status of the notifications to list. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <returns></returns>            
        public void Notificationlistmine (string token, int? from, int? count, int? status, DateTime? startdate, DateTime? enddate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationlistmine");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Notificationlistmine");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Notificationlistmine");
            
    
            var path = "/notificationlistmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationlistmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationlistmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Mark a notification as read 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.</param> 
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <returns></returns>            
        public void Notificationmarkasread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationmarkasread");
            
    
            var path = "/notificationmarkasread";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationmarkasread: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationmarkasread: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Mark a notification as unread 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.</param> 
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <returns></returns>            
        public void Notificationmarkasunread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationmarkasunread");
            
    
            var path = "/notificationmarkasunread";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationmarkasunread: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationmarkasunread: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send notifications on screen, via email or text to users Allows the user to send notifications to other users through the Send Message link.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="emailenabled">Whether send the notification via email.</param> 
        /// <param name="onscreenenabled">Whether to display the notification on screen.</param> 
        /// <param name="smsenabled">Whether to send the notification via text message.</param> 
        /// <param name="title">Notification title.</param> 
        /// <param name="tousers">Comma-separated Ids of users to send the notification.</param> 
        /// <param name="togroups">Comma-separated Ids of user groups to send the notification.</param> 
        /// <param name="onscreenbody">Body of the message for on-screen display.</param> 
        /// <param name="onscreenclick">What to do when the notification is clicked. Valid values: hide, view, url.</param> 
        /// <param name="onscreenurl">Url to redirect the user, if onscreenclick&#x3D;url.</param> 
        /// <param name="onscreenclass">How to display the notification. Valid values: info, success, warning, error</param> 
        /// <param name="onscreenduration">Time in seconds to display the notification.</param> 
        /// <param name="showonstation">Whether to show the notification in the sign-in station.</param> 
        /// <param name="emailfromname">Name of the email sender.</param> 
        /// <param name="emailfrom">Reply-to email.</param> 
        /// <param name="emailsubject">Subject of the email.</param> 
        /// <param name="emailbody">Body of the email.</param> 
        /// <param name="textmessagebody">Message for SMS. Max 160 characters.</param> 
        /// <returns></returns>            
        public void Notificationsend (string token, bool? emailenabled, bool? onscreenenabled, bool? smsenabled, string title, string tousers, string togroups, string onscreenbody, string onscreenclick, string onscreenurl, string onscreenclass, int? onscreenduration, int? showonstation, string emailfromname, string emailfrom, string emailsubject, string emailbody, string textmessagebody)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationsend");
            
            // verify the required parameter 'emailenabled' is set
            if (emailenabled == null) throw new ApiException(400, "Missing required parameter 'emailenabled' when calling Notificationsend");
            
            // verify the required parameter 'onscreenenabled' is set
            if (onscreenenabled == null) throw new ApiException(400, "Missing required parameter 'onscreenenabled' when calling Notificationsend");
            
            // verify the required parameter 'smsenabled' is set
            if (smsenabled == null) throw new ApiException(400, "Missing required parameter 'smsenabled' when calling Notificationsend");
            
            // verify the required parameter 'title' is set
            if (title == null) throw new ApiException(400, "Missing required parameter 'title' when calling Notificationsend");
            
    
            var path = "/notificationsend";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (tousers != null) queryParams.Add("tousers", ApiClient.ParameterToString(tousers)); // query parameter
 if (togroups != null) queryParams.Add("togroups", ApiClient.ParameterToString(togroups)); // query parameter
 if (emailenabled != null) queryParams.Add("emailenabled", ApiClient.ParameterToString(emailenabled)); // query parameter
 if (onscreenenabled != null) queryParams.Add("onscreenenabled", ApiClient.ParameterToString(onscreenenabled)); // query parameter
 if (smsenabled != null) queryParams.Add("smsenabled", ApiClient.ParameterToString(smsenabled)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (onscreenbody != null) queryParams.Add("onscreenbody", ApiClient.ParameterToString(onscreenbody)); // query parameter
 if (onscreenclick != null) queryParams.Add("onscreenclick", ApiClient.ParameterToString(onscreenclick)); // query parameter
 if (onscreenurl != null) queryParams.Add("onscreenurl", ApiClient.ParameterToString(onscreenurl)); // query parameter
 if (onscreenclass != null) queryParams.Add("onscreenclass", ApiClient.ParameterToString(onscreenclass)); // query parameter
 if (onscreenduration != null) queryParams.Add("onscreenduration", ApiClient.ParameterToString(onscreenduration)); // query parameter
 if (showonstation != null) queryParams.Add("showonstation", ApiClient.ParameterToString(showonstation)); // query parameter
 if (emailfromname != null) queryParams.Add("emailfromname", ApiClient.ParameterToString(emailfromname)); // query parameter
 if (emailfrom != null) queryParams.Add("emailfrom", ApiClient.ParameterToString(emailfrom)); // query parameter
 if (emailsubject != null) queryParams.Add("emailsubject", ApiClient.ParameterToString(emailsubject)); // query parameter
 if (emailbody != null) queryParams.Add("emailbody", ApiClient.ParameterToString(emailbody)); // query parameter
 if (textmessagebody != null) queryParams.Add("textmessagebody", ApiClient.ParameterToString(textmessagebody)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationsend: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationsend: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send on-screen notifications 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="notification">The ID of the notification to send.</param> 
        /// <returns></returns>            
        public void Notificationsendonscreen (string token, Guid? notification)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationsendonscreen");
            
            // verify the required parameter 'notification' is set
            if (notification == null) throw new ApiException(400, "Missing required parameter 'notification' when calling Notificationsendonscreen");
            
    
            var path = "/notificationsendonscreen";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (notification != null) queryParams.Add("notification", ApiClient.ParameterToString(notification)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationsendonscreen: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationsendonscreen: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a notification topic Allows the user to delete an existing notification topic.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the notification topic to delete.</param> 
        /// <returns></returns>            
        public void Notificationtopicdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationtopicdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Notificationtopicdelete");
            
    
            var path = "/notificationtopicdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopicdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopicdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a notification topic Allows the user to view an individual notification topic and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the notification topic to get.</param> 
        /// <returns></returns>            
        public void Notificationtopicget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationtopicget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Notificationtopicget");
            
    
            var path = "/notificationtopicget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopicget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopicget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List all the notification topics Allows the user to view the list of all notification topics.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Notificationtopiclist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationtopiclist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Notificationtopiclist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Notificationtopiclist");
            
    
            var path = "/notificationtopiclist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopiclist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopiclist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List all the notification topics available to subscribe 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Notificationtopiclistsubscribe (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Notificationtopiclistsubscribe");
            
    
            var path = "/notificationtopiclistsubscribe";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopiclistsubscribe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopiclistsubscribe: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a notification topic Allows the user to create and edit a notification topic.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Notificationtopicsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/notificationtopicsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopicsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Notificationtopicsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deregisters the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param> 
        /// <param name="platform">Either ios or android</param> 
        /// <returns></returns>            
        public void Pushderegister (string devicetoken, string platform)
        {
            
            // verify the required parameter 'devicetoken' is set
            if (devicetoken == null) throw new ApiException(400, "Missing required parameter 'devicetoken' when calling Pushderegister");
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling Pushderegister");
            
    
            var path = "/pushderegister";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (devicetoken != null) queryParams.Add("devicetoken", ApiClient.ParameterToString(devicetoken)); // query parameter
 if (platform != null) queryParams.Add("platform", ApiClient.ParameterToString(platform)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Pushderegister: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Pushderegister: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Registers the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param> 
        /// <param name="platform">Either ios or android</param> 
        /// <returns></returns>            
        public void Pushregister (string devicetoken, string platform)
        {
            
            // verify the required parameter 'devicetoken' is set
            if (devicetoken == null) throw new ApiException(400, "Missing required parameter 'devicetoken' when calling Pushregister");
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling Pushregister");
            
    
            var path = "/pushregister";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (devicetoken != null) queryParams.Add("devicetoken", ApiClient.ParameterToString(devicetoken)); // query parameter
 if (platform != null) queryParams.Add("platform", ApiClient.ParameterToString(platform)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Pushregister: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Pushregister: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Print and email QR labels Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="user">The id of the user whose label needs to be printed.</param> 
        /// <param name="group">The id of the group whose members&#39; labels need to be printed.</param> 
        /// <returns></returns>            
        public void Qrlabelsprint (string token, Guid? user, Guid? group)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Qrlabelsprint");
            
    
            var path = "/qrlabelsprint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Qrlabelsprint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Qrlabelsprint: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets an image of a QR token 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Qrloginget (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Qrloginget");
            
    
            var path = "/qrloginget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Qrloginget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Qrloginget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="onetimetoken">The token read from the QR code.</param> 
        /// <returns></returns>            
        public void Qrloginlogin (string onetimetoken)
        {
            
            // verify the required parameter 'onetimetoken' is set
            if (onetimetoken == null) throw new ApiException(400, "Missing required parameter 'onetimetoken' when calling Qrloginlogin");
            
    
            var path = "/qrloginlogin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (onetimetoken != null) queryParams.Add("onetimetoken", ApiClient.ParameterToString(onetimetoken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Qrloginlogin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Qrloginlogin: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a widget from the Quick Panel Allows the user to delete a widget that has been added to the Quick Panel.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the widget.</param> 
        /// <returns></returns>            
        public void Quickpaneldeletewidget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Quickpaneldeletewidget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Quickpaneldeletewidget");
            
    
            var path = "/quickpaneldeletewidget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpaneldeletewidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpaneldeletewidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Fetches the information for a specific widget. 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="widgetid">The ID of the data to fetch it&#39;s data.</param> 
        /// <returns></returns>            
        public void Quickpanelfetchwidget (string token, Guid? widgetid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Quickpanelfetchwidget");
            
            // verify the required parameter 'widgetid' is set
            if (widgetid == null) throw new ApiException(400, "Missing required parameter 'widgetid' when calling Quickpanelfetchwidget");
            
    
            var path = "/quickpanelfetchwidget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (widgetid != null) queryParams.Add("widgetid", ApiClient.ParameterToString(widgetid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelfetchwidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelfetchwidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a widget included in the Quick Panel Allows the user to view a widget added in as Quick Panel.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the widget to get.</param> 
        /// <returns></returns>            
        public void Quickpanelgetwidget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Quickpanelgetwidget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Quickpanelgetwidget");
            
    
            var path = "/quickpanelgetwidget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelgetwidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelgetwidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the initial information required to show the quick panels 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Quickpanelinit (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Quickpanelinit");
            
    
            var path = "/quickpanelinit";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelinit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelinit: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists all the widgets that are added in the Quick Panel Allows the user to view the widgets that have been added to the Quick Panel.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Quickpanellistwidgets (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Quickpanellistwidgets");
            
    
            var path = "/quickpanellistwidgets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanellistwidgets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanellistwidgets: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists all the widget types available in the system 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Quickpanellistwidgettypes (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Quickpanellistwidgettypes");
            
    
            var path = "/quickpanellistwidgettypes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanellistwidgettypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanellistwidgettypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Reorders the widgets and moves them to a specific column 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="sectionname">The section name where to sort the widgets.</param> 
        /// <param name="orderids">CSV list of the widgets to reorder.</param> 
        /// <returns></returns>            
        public void Quickpanelreorderwidgets (string token, string sectionname, string orderids)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Quickpanelreorderwidgets");
            
            // verify the required parameter 'sectionname' is set
            if (sectionname == null) throw new ApiException(400, "Missing required parameter 'sectionname' when calling Quickpanelreorderwidgets");
            
            // verify the required parameter 'orderids' is set
            if (orderids == null) throw new ApiException(400, "Missing required parameter 'orderids' when calling Quickpanelreorderwidgets");
            
    
            var path = "/quickpanelreorderwidgets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (sectionname != null) queryParams.Add("sectionname", ApiClient.ParameterToString(sectionname)); // query parameter
 if (orderids != null) queryParams.Add("orderids", ApiClient.ParameterToString(orderids)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelreorderwidgets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelreorderwidgets: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a widget for the Quick Panel Allows the user to save a widget to the Quick Panel.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Quickpanelsavewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/quickpanelsavewidget";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelsavewidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Quickpanelsavewidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of available reports Allows the user to view the complete list of available, canned reports.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Reportlist (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Reportlist");
            
    
            var path = "/reportlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Permissions by user report Lists all the users in the system including their corresponding permissions.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param> 
        /// <returns></returns>            
        public void Reportpermissionsbyuser (string token, string _params)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Reportpermissionsbyuser");
            
    
            var path = "/reportpermissionsbyuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (_params != null) queryParams.Add("params", ApiClient.ParameterToString(_params)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportpermissionsbyuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportpermissionsbyuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Queries and loads the specified report, in background. Allows the user to run reports, in background, with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="reportname">The name of the report to execute</param> 
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param> 
        /// <param name="repformat">The format of the resulting report. Json, pdf, csv, ...</param> 
        /// <param name="fillgroupid">If specified, the result is used to fill the group with the given ID</param> 
        /// <param name="groupby">How to group the records. In the format &#39;col1+col2|col3+col4</param> 
        /// <param name="refreshgroup">The ID of the group to check (and refresh) before processing the report.</param> 
        /// <param name="filtertext">The user friendly text of the applied filters.</param> 
        /// <returns></returns>            
        public void Reportprepare (string token, string reportname, string _params, string repformat, Guid? fillgroupid, string groupby, Guid? refreshgroup, string filtertext)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Reportprepare");
            
            // verify the required parameter 'reportname' is set
            if (reportname == null) throw new ApiException(400, "Missing required parameter 'reportname' when calling Reportprepare");
            
    
            var path = "/reportprepare";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (reportname != null) queryParams.Add("reportname", ApiClient.ParameterToString(reportname)); // query parameter
 if (_params != null) queryParams.Add("params", ApiClient.ParameterToString(_params)); // query parameter
 if (repformat != null) queryParams.Add("repformat", ApiClient.ParameterToString(repformat)); // query parameter
 if (fillgroupid != null) queryParams.Add("fillgroupid", ApiClient.ParameterToString(fillgroupid)); // query parameter
 if (groupby != null) queryParams.Add("groupby", ApiClient.ParameterToString(groupby)); // query parameter
 if (refreshgroup != null) queryParams.Add("refreshgroup", ApiClient.ParameterToString(refreshgroup)); // query parameter
 if (filtertext != null) queryParams.Add("filtertext", ApiClient.ParameterToString(filtertext)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportprepare: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportprepare: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Query and load a specified report Allows the user to run reports with the exception of attendance analytics reports.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="reportname">The name of the report to execute</param> 
        /// <param name="_params">A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3</param> 
        /// <returns></returns>            
        public void Reportquery (string token, string reportname, string _params)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Reportquery");
            
            // verify the required parameter 'reportname' is set
            if (reportname == null) throw new ApiException(400, "Missing required parameter 'reportname' when calling Reportquery");
            
    
            var path = "/reportquery";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (reportname != null) queryParams.Add("reportname", ApiClient.ParameterToString(reportname)); // query parameter
 if (_params != null) queryParams.Add("params", ApiClient.ParameterToString(_params)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportquery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Reportquery: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Show a list of roles 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="name">Filter by name of the role.</param> 
        /// <returns></returns>            
        public void Rolelist (string token, string name)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Rolelist");
            
    
            var path = "/rolelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Rolelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Rolelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a rule Allows the user to delete an existing rule.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the rule to delete.</param> 
        /// <returns></returns>            
        public void Ruledelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Ruledelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Ruledelete");
            
    
            var path = "/ruledelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Ruledelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ruledelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a rule Allows the user to view an individual rule and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the rule to get.</param> 
        /// <returns></returns>            
        public void Ruleget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Ruleget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Ruleget");
            
    
            var path = "/ruleget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Ruleget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ruleget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a rule event type Allows the user to view the trigger and its available conditions for the rule.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="_event">The name of the event to refresh.</param> 
        /// <returns></returns>            
        public void Rulegeteventtype (string token, string _event)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Rulegeteventtype");
            
            // verify the required parameter '_event' is set
            if (_event == null) throw new ApiException(400, "Missing required parameter '_event' when calling Rulegeteventtype");
            
    
            var path = "/rulegeteventtype";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulegeteventtype: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulegeteventtype: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of user rules Allows the user to view the list of all rules.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Rulelist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Rulelist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Rulelist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Rulelist");
            
    
            var path = "/rulelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of rule actions available Allows the user to view all the available rule actions.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Rulelistactions (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Rulelistactions");
            
    
            var path = "/rulelistactions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelistactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelistactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of rule event types Allows the user to view a list of available triggers for rules.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Rulelisteventtypes (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Rulelisteventtypes");
            
    
            var path = "/rulelisteventtypes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelisteventtypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelisteventtypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the http requests sent as a result of a rule 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="failed">If true only failed requests will be returned</param> 
        /// <param name="status">The http status to filter the requests</param> 
        /// <returns></returns>            
        public void Rulelisthttprequests (string token, int? from, int? count, bool? failed, int? status)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Rulelisthttprequests");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Rulelisthttprequests");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Rulelisthttprequests");
            
    
            var path = "/rulelisthttprequests";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (failed != null) queryParams.Add("failed", ApiClient.ParameterToString(failed)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelisthttprequests: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulelisthttprequests: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a rule Allows the user to create or edit a rule.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Rulesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/rulesave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Rulesave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Rulesave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="query">The query to search for.</param> 
        /// <param name="page">Current page to show, zero-based.</param> 
        /// <returns></returns>            
        public void Search (string token, string query, int? page)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Search");
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling Search");
            
    
            var path = "/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the information of the entities that can be searched 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Searchgetentities (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Searchgetentities");
            
    
            var path = "/searchgetentities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Searchgetentities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Searchgetentities: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the list of users for a specific permission 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="commandname">Name of the action or command to get the roles.</param> 
        /// <returns></returns>            
        public void Securityassesspermission (string token, string commandname)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Securityassesspermission");
            
            // verify the required parameter 'commandname' is set
            if (commandname == null) throw new ApiException(400, "Missing required parameter 'commandname' when calling Securityassesspermission");
            
    
            var path = "/securityassesspermission";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (commandname != null) queryParams.Add("commandname", ApiClient.ParameterToString(commandname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassesspermission: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassesspermission: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the list of permissions for a specific role 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="roleid">Role ID to list the effective permissions.</param> 
        /// <returns></returns>            
        public void Securityassessrole (string token, Guid? roleid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Securityassessrole");
            
            // verify the required parameter 'roleid' is set
            if (roleid == null) throw new ApiException(400, "Missing required parameter 'roleid' when calling Securityassessrole");
            
    
            var path = "/securityassessrole";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassessrole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassessrole: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the list of users for a specific user 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="locationid">Location ID to list the users with that scope.</param> 
        /// <returns></returns>            
        public void Securityassessscope (string token, Guid? locationid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Securityassessscope");
            
    
            var path = "/securityassessscope";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassessscope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassessscope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the list of permissions for a specific user 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">User ID to list the effective permissions.</param> 
        /// <returns></returns>            
        public void Securityassessuser (string token, Guid? userid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Securityassessuser");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Securityassessuser");
            
    
            var path = "/securityassessuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassessuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Securityassessuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register current user to an event session Allows the user to register themselves for an event.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void Sessionregaddcurrentuser (string token, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionregaddcurrentuser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling Sessionregaddcurrentuser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling Sessionregaddcurrentuser");
            
    
            var path = "/sessionregaddcurrentuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregaddcurrentuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregaddcurrentuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register users for events Allows the user to register another user for an upcoming event.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void Sessionregadduser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionregadduser");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Sessionregadduser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling Sessionregadduser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling Sessionregadduser");
            
    
            var path = "/sessionregadduser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregadduser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregadduser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the sessions the logged user is registered to 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="date">Start date to filter the sessions.</param> 
        /// <returns></returns>            
        public void Sessionreggetmysessions (string token, DateTime? date)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionreggetmysessions");
            
    
            var path = "/sessionreggetmysessions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetmysessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetmysessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the registrations for a specific user Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">The user id to list sessions.</param> 
        /// <returns></returns>            
        public void Sessionreggetsessions (string token, Guid? userid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionreggetsessions");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Sessionreggetsessions");
            
    
            var path = "/sessionreggetsessions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetsessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetsessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the settings for session registration Allows the user to view a event&#39;s session registration settings.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="locationid">The id of the location to save settings.</param> 
        /// <param name="eventid">The id of the event to save settings.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <param name="noinherit">True to get the location/event/session specific settings without looking for the more global settings.</param> 
        /// <returns></returns>            
        public void Sessionreggetsettings (string token, Guid? locationid, Guid? eventid, DateTime? sessiondate, bool? noinherit)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionreggetsettings");
            
    
            var path = "/sessionreggetsettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
 if (noinherit != null) queryParams.Add("noinherit", ApiClient.ParameterToString(noinherit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetsettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetsettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the registrations for a specific session Allows the user to view the registration for a specified event session.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="eventid">The event id to list sessions.</param> 
        /// <param name="sessiondate">The date of the session to find.</param> 
        /// <returns></returns>            
        public void Sessionreggetusers (string token, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionreggetusers");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling Sessionreggetusers");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling Sessionreggetusers");
            
    
            var path = "/sessionreggetusers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetusers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreggetusers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List the sessions available for a specific event Allows the user to view all the sessions available for a recurring event.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="eventid">The event id to list sessions.</param> 
        /// <param name="sessiondate">The date of the session to find.</param> 
        /// <returns></returns>            
        public void Sessionreglistsessions (string token, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionreglistsessions");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling Sessionreglistsessions");
            
    
            var path = "/sessionreglistsessions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreglistsessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreglistsessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of upcoming event sessions Allows the user to view the full list of upcoming events.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="date">Only sessions in the week of the specified date will be returned.</param> 
        /// <returns></returns>            
        public void Sessionreglistupcoming (string token, DateTime? date)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionreglistupcoming");
            
            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling Sessionreglistupcoming");
            
    
            var path = "/sessionreglistupcoming";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreglistupcoming: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreglistupcoming: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of upcoming sessions of a particular event Allows the user to view the upcoming recurring sessions of a specified event.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="date">Start date to filter the returned sessions.</param> 
        /// <param name="_event">The id of the event whose sessions will be returned</param> 
        /// <returns></returns>            
        public void Sessionreglistupcomingevent (string token, DateTime? date, Guid? _event)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionreglistupcomingevent");
            
            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling Sessionreglistupcomingevent");
            
            // verify the required parameter '_event' is set
            if (_event == null) throw new ApiException(400, "Missing required parameter '_event' when calling Sessionreglistupcomingevent");
            
    
            var path = "/sessionreglistupcomingevent";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreglistupcomingevent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionreglistupcomingevent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Unregister current user from an event session Allows the user to un-register themselves from an event.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void Sessionregremovecurrentuser (string token, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionregremovecurrentuser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling Sessionregremovecurrentuser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling Sessionregremovecurrentuser");
            
    
            var path = "/sessionregremovecurrentuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregremovecurrentuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregremovecurrentuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a user from an event session Allows the user to un-register another user from an event.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="eventid">The id of the event.</param> 
        /// <param name="sessiondate">The date and time when the session starts.</param> 
        /// <returns></returns>            
        public void Sessionregremoveuser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Sessionregremoveuser");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Sessionregremoveuser");
            
            // verify the required parameter 'eventid' is set
            if (eventid == null) throw new ApiException(400, "Missing required parameter 'eventid' when calling Sessionregremoveuser");
            
            // verify the required parameter 'sessiondate' is set
            if (sessiondate == null) throw new ApiException(400, "Missing required parameter 'sessiondate' when calling Sessionregremoveuser");
            
    
            var path = "/sessionregremoveuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (sessiondate != null) queryParams.Add("sessiondate", ApiClient.ParameterToString(sessiondate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregremoveuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregremoveuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save the settings for an event&#39;s session registration Allows the user to save the settings for an event.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Sessionregsavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/sessionregsavesettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregsavesettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Sessionregsavesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a logo to the account Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The original filename, needed to process the file.</param> 
        /// <returns></returns>            
        public void Settingaddlogo (string token, string upload, string filename)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Settingaddlogo");
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling Settingaddlogo");
            
            // verify the required parameter 'filename' is set
            if (filename == null) throw new ApiException(400, "Missing required parameter 'filename' when calling Settingaddlogo");
            
    
            var path = "/settingaddlogo";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Settingaddlogo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Settingaddlogo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get settings for the account or the specified scope 
        /// </summary>
        /// <param name="keys">The option keys to get values for. Enter multiple separated by comma.</param> 
        /// <param name="token">The authentication token.</param> 
        /// <param name="domain">The account domain, in case of reading settings annonymously.</param> 
        /// <param name="scope">The scope of the settings to get.</param> 
        /// <returns></returns>            
        public void Settingget (string keys, string token, string domain, string scope)
        {
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling Settingget");
            
    
            var path = "/settingget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
 if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Settingget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Settingget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save settings for the account or the specified scope Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Settingsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/settingsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Settingsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Settingsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View general settings for the account Allows the user to view the settings&#39; general section.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Settingviewgeneral (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Settingviewgeneral");
            
    
            var path = "/settingviewgeneral";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Settingviewgeneral: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Settingviewgeneral: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Generate/reset single sign on access key. Allows the user to generate or reset the access key for single sign-on.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Ssogeneratekey (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Ssogeneratekey");
            
    
            var path = "/ssogeneratekey";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Ssogeneratekey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ssogeneratekey: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View single sign on settings. Allows the user to view settings for single sign-on.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Ssogetsettings (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Ssogetsettings");
            
    
            var path = "/ssogetsettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Ssogetsettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ssogetsettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Issue single sign-on token 
        /// </summary>
        /// <param name="key">The single sign-on key of the account.</param> 
        /// <param name="username">The email of the user to sign-on.</param> 
        /// <param name="expires">Specifies whether the session should expire when inactive.</param> 
        /// <returns></returns>            
        public void Ssoissuetoken (string key, string username, bool? expires)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling Ssoissuetoken");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling Ssoissuetoken");
            
    
            var path = "/ssoissuetoken";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (username != null) queryParams.Add("username", ApiClient.ParameterToString(username)); // query parameter
 if (expires != null) queryParams.Add("expires", ApiClient.ParameterToString(expires)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Ssoissuetoken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ssoissuetoken: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit single sign-on settings. Allows the user to edit settings for single sign-on.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Ssosavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/ssosavesettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Ssosavesettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Ssosavesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a sign-in station Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the sign-in station to delete.</param> 
        /// <returns></returns>            
        public void Stationdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Stationdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Stationdelete");
            
    
            var path = "/stationdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a sign-in station Allows the user to view an individual sign-in station and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the sign-in station to get.</param> 
        /// <returns></returns>            
        public void Stationget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Stationget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Stationget");
            
    
            var path = "/stationget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all the current terms 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s current terms have to be retrieved.</param> 
        /// <returns></returns>            
        public void Stationgetcurrentterms (Guid? station)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling Stationgetcurrentterms");
            
    
            var path = "/stationgetcurrentterms";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Stationgetcurrentterms: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationgetcurrentterms: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a the info to display in the sign-in station by it&#39;s ID. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to get.</param> 
        /// <param name="_event">The id of the event, to override the one by schedule.</param> 
        /// <returns></returns>            
        public void Stationgetinfo (Guid? id, Guid? _event)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Stationgetinfo");
            
    
            var path = "/stationgetinfo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Stationgetinfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationgetinfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <param name="station">The id of the sign-in station whose account&#39;s license has to be retrieved.</param> 
        /// <returns></returns>            
        public void Stationgetlicense (string station)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling Stationgetlicense");
            
    
            var path = "/stationgetlicense";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Stationgetlicense: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationgetlicense: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of sign-in stations Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Stationlist (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Stationlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Stationlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Stationlist");
            
    
            var path = "/stationlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a sign-in station Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Stationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/stationsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Stationsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Unlocks the sign-in station. 
        /// </summary>
        /// <param name="id">The id of the sign-in station to unlock.</param> 
        /// <param name="passcode">The passcode to unlock the station.</param> 
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param> 
        /// <returns></returns>            
        public void Stationunlock (Guid? id, string passcode, string method)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Stationunlock");
            
            // verify the required parameter 'passcode' is set
            if (passcode == null) throw new ApiException(400, "Missing required parameter 'passcode' when calling Stationunlock");
            
            // verify the required parameter 'method' is set
            if (method == null) throw new ApiException(400, "Missing required parameter 'method' when calling Stationunlock");
            
    
            var path = "/stationunlock";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Stationunlock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Stationunlock: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a swipe Allows the user to delete an existing attendance swipe.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the swipe to delete.</param> 
        /// <returns></returns>            
        public void Swipedelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Swipedelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Swipedelete");
            
    
            var path = "/swipedelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipedelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipedelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a swipe Allows the user to view an individual attendance swipe.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the swipe to get.</param> 
        /// <returns></returns>            
        public void Swipeget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Swipeget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Swipeget");
            
    
            var path = "/swipeget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipeget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipeget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of swipes Allows the user to view a list of all swipes for the location or locations in which the user is scoped.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Swipelist (int? from, int? count, string token)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Swipelist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Swipelist");
            
    
            var path = "/swipelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a swipe, and if possible, save the related attendance log Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Swipesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/swipesave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Swipesave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipesave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Creates a new swipe from a sign-in station, and if possible, creates the attendance log 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Swipesaveanonym (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/swipesaveanonym";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Swipesaveanonym: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Swipesaveanonym: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a tag Allows the user to delete an existing tag.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the tag to delete.</param> 
        /// <returns></returns>            
        public void Tagdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Tagdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Tagdelete");
            
    
            var path = "/tagdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Tagdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Tagdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a specified tag Allows the user to click on and view the settings for a tag.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the tag to get.</param> 
        /// <returns></returns>            
        public void Tagget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Tagget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Tagget");
            
    
            var path = "/tagget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Tagget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Tagget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of tags Allows the user to view the list of tags.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="group">The group of the tags to return.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Taglist (string token, string group, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Taglist");
            
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling Taglist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Taglist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Taglist");
            
    
            var path = "/taglist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Taglist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Taglist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of entities that can be tagged Allows the user to view the list of user roles that can be tagged, according to that tag&#39;s settings.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Taglistgroups (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Taglistgroups");
            
    
            var path = "/taglistgroups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Taglistgroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Taglistgroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a tag Allows the user to create or edit a tag.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Tagsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/tagsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Tagsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Tagsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search for tags in the account Allows the user to search for tags.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="query">The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory).</param> 
        /// <param name="allowcreatingnew">Specifies whether an option to create a new tag should be retrieved.</param> 
        /// <returns></returns>            
        public void Tagsearch (string token, string query, bool? allowcreatingnew)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Tagsearch");
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling Tagsearch");
            
    
            var path = "/tagsearch";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (allowcreatingnew != null) queryParams.Add("allowcreatingnew", ApiClient.ParameterToString(allowcreatingnew)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Tagsearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Tagsearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add an image to a template Allows the user to add an image to a badge or certificate template.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="template">The id of the template where the image has to be added</param> 
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The local name of the uploaded file. For later reference.</param> 
        /// <returns></returns>            
        public void Templateaddimage (string token, Guid? template, string upload, string filename)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templateaddimage");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling Templateaddimage");
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling Templateaddimage");
            
    
            var path = "/templateaddimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (template != null) queryParams.Add("template", ApiClient.ParameterToString(template)); // query parameter
 if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templateaddimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templateaddimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a template Allows the user to delete an existing template.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the template to delete.</param> 
        /// <returns></returns>            
        public void Templatedelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templatedelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Templatedelete");
            
    
            var path = "/templatedelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatedelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatedelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send generated templates by email Allows the user to send generated templates via email through AccuCampus.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="jobid">The id of the job that is creating the templates.</param> 
        /// <param name="emailsubject">Args depending on the send-to flag.</param> 
        /// <param name="emailbody">Args depending on the send-to flag.</param> 
        /// <param name="templatekind">The kind of the template you&#39;re sending. It must be included in (badge, certificate).</param> 
        /// <param name="emailfrom">The name of the sender to be displayed in the receipients inbox</param> 
        /// <param name="emailreplyto">The reply-to field for the emails.</param> 
        /// <returns></returns>            
        public void Templateemail (string token, string jobid, string emailsubject, string emailbody, string templatekind, string emailfrom, string emailreplyto)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templateemail");
            
            // verify the required parameter 'jobid' is set
            if (jobid == null) throw new ApiException(400, "Missing required parameter 'jobid' when calling Templateemail");
            
            // verify the required parameter 'emailsubject' is set
            if (emailsubject == null) throw new ApiException(400, "Missing required parameter 'emailsubject' when calling Templateemail");
            
            // verify the required parameter 'emailbody' is set
            if (emailbody == null) throw new ApiException(400, "Missing required parameter 'emailbody' when calling Templateemail");
            
    
            var path = "/templateemail";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (jobid != null) queryParams.Add("jobid", ApiClient.ParameterToString(jobid)); // query parameter
 if (templatekind != null) queryParams.Add("templatekind", ApiClient.ParameterToString(templatekind)); // query parameter
 if (emailfrom != null) queryParams.Add("emailfrom", ApiClient.ParameterToString(emailfrom)); // query parameter
 if (emailreplyto != null) queryParams.Add("emailreplyto", ApiClient.ParameterToString(emailreplyto)); // query parameter
 if (emailsubject != null) queryParams.Add("emailsubject", ApiClient.ParameterToString(emailsubject)); // query parameter
 if (emailbody != null) queryParams.Add("emailbody", ApiClient.ParameterToString(emailbody)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templateemail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templateemail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Generate specified templates Allows the user to generate an existing template as badges or certificates.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="template">The id of the template to generate.</param> 
        /// <param name="source">The source key of the selected template data source.</param> 
        /// <param name="singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param> 
        /// <param name="userid">Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas.</param> 
        /// <param name="forsending">It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading</param> 
        /// <param name="role">When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor</param> 
        /// <param name="filters">Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|...</param> 
        /// <returns></returns>            
        public void Templategenerate (string token, Guid? template, Guid? source, bool? singlefile, string userid, bool? forsending, Guid? role, string filters)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templategenerate");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling Templategenerate");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling Templategenerate");
            
            // verify the required parameter 'singlefile' is set
            if (singlefile == null) throw new ApiException(400, "Missing required parameter 'singlefile' when calling Templategenerate");
            
    
            var path = "/templategenerate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (template != null) queryParams.Add("template", ApiClient.ParameterToString(template)); // query parameter
 if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
 if (singlefile != null) queryParams.Add("singlefile", ApiClient.ParameterToString(singlefile)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (forsending != null) queryParams.Add("forsending", ApiClient.ParameterToString(forsending)); // query parameter
 if (role != null) queryParams.Add("role", ApiClient.ParameterToString(role)); // query parameter
 if (filters != null) queryParams.Add("filters", ApiClient.ParameterToString(filters)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templategenerate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templategenerate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a template Allows the user to view a template and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the template to get.</param> 
        /// <returns></returns>            
        public void Templateget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templateget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Templateget");
            
    
            var path = "/templateget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templateget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templateget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View generated templates Allows the user to view templates which have been generated as badges or certificates.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="jobid">The id of the job that is creating the templates.</param> 
        /// <returns></returns>            
        public void Templategetgenerated (string token, string jobid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templategetgenerated");
            
            // verify the required parameter 'jobid' is set
            if (jobid == null) throw new ApiException(400, "Missing required parameter 'jobid' when calling Templategetgenerated");
            
    
            var path = "/templategetgenerated";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (jobid != null) queryParams.Add("jobid", ApiClient.ParameterToString(jobid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templategetgenerated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templategetgenerated: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of defined templates Allows the user to view the full list of created templates.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param> 
        /// <param name="designedonly">If true then it only returns the templates that were designed. Otherwise, it returns all.</param> 
        /// <returns></returns>            
        public void Templatelist (string token, int? from, int? count, string kind, bool? designedonly)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templatelist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Templatelist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Templatelist");
            
            // verify the required parameter 'kind' is set
            if (kind == null) throw new ApiException(400, "Missing required parameter 'kind' when calling Templatelist");
            
    
            var path = "/templatelist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
 if (designedonly != null) queryParams.Add("designedonly", ApiClient.ParameterToString(designedonly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of templates&#39; data sources Allows the user to see tokens to be used in the template
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param> 
        /// <returns></returns>            
        public void Templatelistsources (string token, string kind)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Templatelistsources");
            
            // verify the required parameter 'kind' is set
            if (kind == null) throw new ApiException(400, "Missing required parameter 'kind' when calling Templatelistsources");
            
    
            var path = "/templatelistsources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatelistsources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatelistsources: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a template Allows the user to create or edit a template.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Templatesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/templatesave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Templatesave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatesave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save the layout of a template Allows the user to edit a template&#39;s layout.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Templatesavelayout (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/templatesavelayout";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Templatesavelayout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Templatesavelayout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a term Allows the user to delete a term from the existing list.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the term to delete.</param> 
        /// <returns></returns>            
        public void Termdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Termdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Termdelete");
            
    
            var path = "/termdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Termdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Termdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a term Allows the user to view a term and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the term to get.</param> 
        /// <returns></returns>            
        public void Termget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Termget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Termget");
            
    
            var path = "/termget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Termget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Termget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of all terms Allows the user to view the full list of existing term.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="notpast">Specifies whether the terms in the past should be returned or not.</param> 
        /// <returns></returns>            
        public void Termlist (string token, int? from, int? count, bool? notpast)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Termlist");
            
    
            var path = "/termlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (notpast != null) queryParams.Add("notpast", ApiClient.ParameterToString(notpast)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Termlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Termlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create and edit terms Allows the user to create and edit terms.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Termsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/termsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Termsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Termsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the remaining text credits for the account 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Textcreditremaining (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Textcreditremaining");
            
    
            var path = "/textcreditremaining";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Textcreditremaining: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Textcreditremaining: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Generates a dynamic image from text 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="text">The text to convert to an image, use double pipes (||) as a new line.</param> 
        /// <param name="fontcolor">The color of the text, in hex format, without the #.</param> 
        /// <param name="fontsize">The size of the text, in points.</param> 
        /// <param name="direction">Either vertical or horizontal, default horizontal.</param> 
        /// <param name="width">The image width in pixels (or height if the direction is vertical).</param> 
        /// <returns></returns>            
        public void Texttoimage (string token, string text, string fontcolor, int? fontsize, string direction, int? width)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Texttoimage");
            
            // verify the required parameter 'text' is set
            if (text == null) throw new ApiException(400, "Missing required parameter 'text' when calling Texttoimage");
            
    
            var path = "/texttoimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (text != null) queryParams.Add("text", ApiClient.ParameterToString(text)); // query parameter
 if (fontcolor != null) queryParams.Add("fontcolor", ApiClient.ParameterToString(fontcolor)); // query parameter
 if (fontsize != null) queryParams.Add("fontsize", ApiClient.ParameterToString(fontsize)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (width != null) queryParams.Add("width", ApiClient.ParameterToString(width)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Texttoimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Texttoimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the translations of the specified values 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="universal">Pipe separated list of universal text to be translated.</param> 
        /// <returns></returns>            
        public void Translationget (string token, string universal)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Translationget");
            
            // verify the required parameter 'universal' is set
            if (universal == null) throw new ApiException(400, "Missing required parameter 'universal' when calling Translationget");
            
    
            var path = "/translationget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (universal != null) queryParams.Add("universal", ApiClient.ParameterToString(universal)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Translationget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Translationget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the file containing the translations 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="account">The id of the account whose translations file has to be retrieved.</param> 
        /// <returns></returns>            
        public void Translationgetcachefile (string token, string account)
        {
            
    
            var path = "/translationgetcachefile";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (account != null) queryParams.Add("account", ApiClient.ParameterToString(account)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Translationgetcachefile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Translationgetcachefile: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists all the available translations in the system 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="filter">Text to search/filter translations.</param> 
        /// <param name="nondefaultonly">If true then it returns only the terms translated. Otherwise, it returns all.</param> 
        /// <param name="appdefaultasuniversal">If true then it uses the app default translation as the universal term.</param> 
        /// <returns></returns>            
        public void Translationlist (string token, string filter, bool? nondefaultonly, bool? appdefaultasuniversal)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Translationlist");
            
    
            var path = "/translationlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (nondefaultonly != null) queryParams.Add("nondefaultonly", ApiClient.ParameterToString(nondefaultonly)); // query parameter
 if (appdefaultasuniversal != null) queryParams.Add("appdefaultasuniversal", ApiClient.ParameterToString(appdefaultasuniversal)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Translationlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Translationlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit a translation Allows the user to edit a translation for the entire account.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Translationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/translationsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Translationsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Translationsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Change user&#39;s own password Allows the user to change their own password.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="oldpass">The old password of the authenticated user.</param> 
        /// <param name="newpass">The new password of the authenticated user.</param> 
        /// <returns></returns>            
        public void Userchangepwd (string token, Guid? oldpass, Guid? newpass)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Userchangepwd");
            
            // verify the required parameter 'oldpass' is set
            if (oldpass == null) throw new ApiException(400, "Missing required parameter 'oldpass' when calling Userchangepwd");
            
            // verify the required parameter 'newpass' is set
            if (newpass == null) throw new ApiException(400, "Missing required parameter 'newpass' when calling Userchangepwd");
            
    
            var path = "/userchangepwd";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (oldpass != null) queryParams.Add("oldpass", ApiClient.ParameterToString(oldpass)); // query parameter
 if (newpass != null) queryParams.Add("newpass", ApiClient.ParameterToString(newpass)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userchangepwd: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userchangepwd: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Changes the user password using a change password request id 
        /// </summary>
        /// <param name="changereq">The change password request ID sent by email to the user.</param> 
        /// <param name="newpass">The new password of the user.</param> 
        /// <returns></returns>            
        public void Userchangepwdbyreq (string changereq, string newpass)
        {
            
            // verify the required parameter 'changereq' is set
            if (changereq == null) throw new ApiException(400, "Missing required parameter 'changereq' when calling Userchangepwdbyreq");
            
            // verify the required parameter 'newpass' is set
            if (newpass == null) throw new ApiException(400, "Missing required parameter 'newpass' when calling Userchangepwdbyreq");
            
    
            var path = "/userchangepwdbyreq";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (changereq != null) queryParams.Add("changereq", ApiClient.ParameterToString(changereq)); // query parameter
 if (newpass != null) queryParams.Add("newpass", ApiClient.ParameterToString(newpass)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userchangepwdbyreq: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userchangepwdbyreq: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a user Allows the user to delete a user.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the user to delete.</param> 
        /// <returns></returns>            
        public void Userdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Userdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Userdelete");
            
    
            var path = "/userdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Finds similar users to prevent duplicates Allows the user to be warned if a user they are creating has the same card number as another user.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="currentid">The id of the current user.</param> 
        /// <param name="phonenumber">A phone number to search for similar users.</param> 
        /// <param name="cardnumber">A card number to search for similar users.</param> 
        /// <returns></returns>            
        public void Userfindsimilar (string token, Guid? currentid, string phonenumber, string cardnumber)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Userfindsimilar");
            
    
            var path = "/userfindsimilar";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (currentid != null) queryParams.Add("currentid", ApiClient.ParameterToString(currentid)); // query parameter
 if (phonenumber != null) queryParams.Add("phonenumber", ApiClient.ParameterToString(phonenumber)); // query parameter
 if (cardnumber != null) queryParams.Add("cardnumber", ApiClient.ParameterToString(cardnumber)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userfindsimilar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userfindsimilar: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a user Allows the user to search and view a user and their details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the user to get.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void Userget (string token, Guid? id, int? photosize)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Userget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Userget");
            
    
            var path = "/userget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search user by card number Allows the user to search for a user by their card number.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="card">The card number of the user to get.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void Usergetbycard (string token, string card, int? photosize)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergetbycard");
            
            // verify the required parameter 'card' is set
            if (card == null) throw new ApiException(400, "Missing required parameter 'card' when calling Usergetbycard");
            
    
            var path = "/usergetbycard";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (card != null) queryParams.Add("card", ApiClient.ParameterToString(card)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergetbycard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergetbycard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a user to a group Allows the user to add a user to a group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="groupid">The id of the group.</param> 
        /// <returns></returns>            
        public void Usergroupaddmember (string token, Guid? userid, Guid? groupid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergroupaddmember");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Usergroupaddmember");
            
            // verify the required parameter 'groupid' is set
            if (groupid == null) throw new ApiException(400, "Missing required parameter 'groupid' when calling Usergroupaddmember");
            
    
            var path = "/usergroupaddmember";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupaddmember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupaddmember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a group Allows the user to delete a group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the group to delete.</param> 
        /// <returns></returns>            
        public void Usergroupdelete (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergroupdelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Usergroupdelete");
            
    
            var path = "/usergroupdelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupdelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupdelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a user group Allows the user to view a user group and its details.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the user group to get.</param> 
        /// <returns></returns>            
        public void Usergroupget (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergroupget");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Usergroupget");
            
    
            var path = "/usergroupget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the members of a user group Allows the user to view the list of users in a group that they have permission to view.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="groupid">The id of the user group to get.</param> 
        /// <returns></returns>            
        public void Usergroupgetmembers (string token, Guid? groupid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergroupgetmembers");
            
            // verify the required parameter 'groupid' is set
            if (groupid == null) throw new ApiException(400, "Missing required parameter 'groupid' when calling Usergroupgetmembers");
            
    
            var path = "/usergroupgetmembers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupgetmembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupgetmembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the groups which a user is registered to Allows the user to view the groups an individual user is registered to, based on group and user permissions.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">The id of the user to get his groups.</param> 
        /// <returns></returns>            
        public void Usergroupgetuser (string token, Guid? userid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergroupgetuser");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Usergroupgetuser");
            
    
            var path = "/usergroupgetuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupgetuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupgetuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of user groups Allows the user to view the list of groups that they have permission to view.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="type">The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group.</param> 
        /// <returns></returns>            
        public void Usergrouplist (string token, int? from, int? count, string type)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergrouplist");
            
    
            var path = "/usergrouplist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergrouplist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergrouplist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Refresh the dynamic group Allows the user to refresh a dynamic group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="group">The ID of the group to refresh.</param> 
        /// <returns></returns>            
        public void Usergrouprefresh (string token, Guid? group)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergrouprefresh");
            
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling Usergrouprefresh");
            
    
            var path = "/usergrouprefresh";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergrouprefresh: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergrouprefresh: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a user from a group Allows the user to remove a user from a group that they have permission to edit.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="groupid">The id of the group.</param> 
        /// <returns></returns>            
        public void Usergroupremovemember (string token, Guid? userid, Guid? groupid)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usergroupremovemember");
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling Usergroupremovemember");
            
            // verify the required parameter 'groupid' is set
            if (groupid == null) throw new ApiException(400, "Missing required parameter 'groupid' when calling Usergroupremovemember");
            
    
            var path = "/usergroupremovemember";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupremovemember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupremovemember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a group Allows the user to create a new group or edit a group that they have permission to edit.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Usergroupsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usergroupsave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupsave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usergroupsave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of users Allows the user to view the full list of users and is based on role permissions.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param> 
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void Userlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Userlist");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Userlist");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Userlist");
            
    
            var path = "/userlist";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
 if (onlywithoutcard != null) queryParams.Add("onlywithoutcard", ApiClient.ParameterToString(onlywithoutcard)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userlist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userlist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Upload a photo for a specific user Allows the user to upload a photo for a user.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The local name of the uploaded file. For later reference.</param> 
        /// <param name="userid">The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;.</param> 
        /// <param name="automatch">Set this to true to find the specific user based on the file name. </param> 
        /// <returns></returns>            
        public void Userloadphoto (string token, string upload, string filename, Guid? userid, bool? automatch)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Userloadphoto");
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling Userloadphoto");
            
    
            var path = "/userloadphoto";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (automatch != null) queryParams.Add("automatch", ApiClient.ParameterToString(automatch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userloadphoto: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userloadphoto: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Move data between users Allows administrators to move data between users.
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="source">The id of the user that is the source of the data.</param> 
        /// <param name="destination">The id of the user that is the destination of the data.</param> 
        /// <returns></returns>            
        public void Usermovedata (string token, Guid? source, Guid? destination)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usermovedata");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling Usermovedata");
            
            // verify the required parameter 'destination' is set
            if (destination == null) throw new ApiException(400, "Missing required parameter 'destination' when calling Usermovedata");
            
    
            var path = "/usermovedata";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
 if (destination != null) queryParams.Add("destination", ApiClient.ParameterToString(destination)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usermovedata: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usermovedata: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Requests a password change 
        /// </summary>
        /// <param name="domain">The domain of the account where the user exists.</param> 
        /// <param name="email">The email of the user.</param> 
        /// <returns></returns>            
        public void Userrequestpwdchange (string domain, string email)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling Userrequestpwdchange");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling Userrequestpwdchange");
            
    
            var path = "/userrequestpwdchange";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
 if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Userrequestpwdchange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Userrequestpwdchange: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a user Allows the user to create or edit a user.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Usersave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usersave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Usersave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send email to the specified user(s) to set/change their passwords Allows the user to trigger an email to another user asking them to set or change their password.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Usersavepwdchange (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usersavepwdchange";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Usersavepwdchange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersavepwdchange: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists available user settings 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param> 
        /// <param name="user">The user id whose settings have to be returned.</param> 
        /// <returns></returns>            
        public void Usersettingsget (string token, string keys, Guid? user)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usersettingsget");
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling Usersettingsget");
            
    
            var path = "/usersettingsget";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingsget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingsget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get multiple user settings 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param> 
        /// <param name="user">The user id whose settings have to be returned.</param> 
        /// <returns></returns>            
        public void Usersettingsgetmultiple (string token, string keys, Guid? user)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usersettingsgetmultiple");
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling Usersettingsgetmultiple");
            
    
            var path = "/usersettingsgetmultiple";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingsgetmultiple: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingsgetmultiple: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a user setting 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Usersettingssave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usersettingssave";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingssave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingssave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save multiple user settings at once 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Usersettingssavemultiple (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usersettingssavemultiple";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingssavemultiple: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usersettingssavemultiple: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a task plan 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the task plan to delete.</param> 
        /// <returns></returns>            
        public void Usertaskdeleteplan (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usertaskdeleteplan");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Usertaskdeleteplan");
            
    
            var path = "/usertaskdeleteplan";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertaskdeleteplan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertaskdeleteplan: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the task plans of the logged user 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Usertaskgetmine (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usertaskgetmine");
            
    
            var path = "/usertaskgetmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertaskgetmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertaskgetmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a task plan by Id 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="id">The id of the task plan to get.</param> 
        /// <returns></returns>            
        public void Usertaskgetplan (string token, Guid? id)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usertaskgetplan");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Usertaskgetplan");
            
    
            var path = "/usertaskgetplan";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertaskgetplan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertaskgetplan: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists task types or definitions 
        /// </summary>
        /// <returns></returns>            
        public void Usertasklistdefs ()
        {
            
    
            var path = "/usertasklistdefs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertasklistdefs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertasklistdefs: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists task plans 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void Usertasklistplan (string token, int? from, int? count)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Usertasklistplan");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Usertasklistplan");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling Usertasklistplan");
            
    
            var path = "/usertasklistplan";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertasklistplan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertasklistplan: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a task plan 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void Usertasksaveplan (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usertasksaveplan";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Usertasksaveplan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Usertasksaveplan: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get current version information 
        /// </summary>
        /// <param name="token">The authentication token.</param> 
        /// <returns></returns>            
        public void Version (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling Version");
            
    
            var path = "/version";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Version: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Version: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
