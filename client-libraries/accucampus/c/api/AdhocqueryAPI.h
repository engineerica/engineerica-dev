#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Check the status of an ad hoc query execution
//
// Allows the user to check whether a query has executed, viewable on the query's execution page.
//
void
AdhocqueryAPI_adhocqueryCheckexecution(apiClient_t *apiClient, char * id );


// Delete an ad hoc query
//
// Allows the user to delete a previously created ad hoc query.
//
void
AdhocqueryAPI_adhocqueryDelete(apiClient_t *apiClient, char * id ,  body );


// Execute an ad hoc query
//
// Allows the user to execute an ad hoc query.
//
void
AdhocqueryAPI_adhocqueryExecute(apiClient_t *apiClient, char * id , char * query );


// View details of an ad hoc query
//
// Allows the user to view an individual ad hoc query with its settings.
//
void
AdhocqueryAPI_adhocqueryGet(apiClient_t *apiClient, char * id );


// View the database schema for making ad hoc queries
//
// Allows the user to view the list of schema for ad hoc queries.
//
void
AdhocqueryAPI_adhocqueryGetschema(apiClient_t *apiClient);


// View a list of saved ad hoc queries
//
// Allows the user to view the full list of saved queries.
//
void
AdhocqueryAPI_adhocqueryList(apiClient_t *apiClient, int from , int count );


// View a list of ad hoc queries executions
//
// Allows the user to view the full list of past query executions.
//
void
AdhocqueryAPI_adhocqueryListexecutions(apiClient_t *apiClient, int from , int count , char * query );


// Create or edit an ad hoc query
//
// Allows the user to edit an ad hoc query.
//
void
AdhocqueryAPI_adhocquerySave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Stops the execution of an ad hoc query
//
// Allows the user to halt the execution of a query that is currently being executed.
//
void
AdhocqueryAPI_adhocqueryStopexecution(apiClient_t *apiClient, char * id );


