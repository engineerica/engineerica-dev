#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ActionassignmentAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Remove an action item from an action plan
//
// Allows a user to remove an action item from a user's action plan.
//
void
ActionassignmentAPI_actionassignmentDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // Body Param
    cJSON *localVarSingleItemJSON_body;
    if (body != NULL)
    {
        //string
        localVarSingleItemJSON_body = any_type_convertToJSON(body);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_body);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "DELETE");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_body);
    free(localVarBodyParameters);

}

// Search and view details of an action item assigned to a user
//
// Allows the user to view an individual action item and its details, minus all the action item's updates.
//
void
ActionassignmentAPI_actionassignmentGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);


    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    
    free(localVarPath);
    free(localVarToReplace_id);

}

// View a list of action items in a user's plan
//
// Allows the user to view the list of all action items for a specified user.
//
void
ActionassignmentAPI_actionassignmentList(apiClient_t *apiClient, int from , int count , int assignee , int status )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/list");




    // query parameters
    char *keyQuery_from = NULL;
    int valueQuery_from ;
    keyValuePair_t *keyPairQuery_from = 0;
    if (from)
    {
        keyQuery_from = strdup("from");
        valueQuery_from = (from);
        keyPairQuery_from = keyValuePair_create(keyQuery_from, &valueQuery_from);
        list_addElement(localVarQueryParameters,keyPairQuery_from);
    }

    // query parameters
    char *keyQuery_count = NULL;
    int valueQuery_count ;
    keyValuePair_t *keyPairQuery_count = 0;
    if (count)
    {
        keyQuery_count = strdup("count");
        valueQuery_count = (count);
        keyPairQuery_count = keyValuePair_create(keyQuery_count, &valueQuery_count);
        list_addElement(localVarQueryParameters,keyPairQuery_count);
    }

    // query parameters
    char *keyQuery_assignee = NULL;
    int valueQuery_assignee ;
    keyValuePair_t *keyPairQuery_assignee = 0;
    if (assignee)
    {
        keyQuery_assignee = strdup("assignee");
        valueQuery_assignee = (assignee);
        keyPairQuery_assignee = keyValuePair_create(keyQuery_assignee, &valueQuery_assignee);
        list_addElement(localVarQueryParameters,keyPairQuery_assignee);
    }

    // query parameters
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);

}

// View the history of an action item assigned to a user
//
// Allows the user to view an individual action plan and its details, including all the action plan's updates.
//
void
ActionassignmentAPI_actionassignmentListhistory(apiClient_t *apiClient, char * actionassignment )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/listhistory")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/listhistory");




    // query parameters
    char *keyQuery_actionassignment = NULL;
    char * valueQuery_actionassignment ;
    keyValuePair_t *keyPairQuery_actionassignment = 0;
    if (actionassignment)
    {
        keyQuery_actionassignment = strdup("actionassignment");
        valueQuery_actionassignment = (actionassignment);
        keyPairQuery_actionassignment = keyValuePair_create(keyQuery_actionassignment, &valueQuery_actionassignment);
        list_addElement(localVarQueryParameters,keyPairQuery_actionassignment);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);

}

// List public action assignments assigned to the logged user
//
void
ActionassignmentAPI_actionassignmentListmine(apiClient_t *apiClient, int from , int count , int status )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/listmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/listmine");




    // query parameters
    char *keyQuery_from = NULL;
    int valueQuery_from ;
    keyValuePair_t *keyPairQuery_from = 0;
    if (from)
    {
        keyQuery_from = strdup("from");
        valueQuery_from = (from);
        keyPairQuery_from = keyValuePair_create(keyQuery_from, &valueQuery_from);
        list_addElement(localVarQueryParameters,keyPairQuery_from);
    }

    // query parameters
    char *keyQuery_count = NULL;
    int valueQuery_count ;
    keyValuePair_t *keyPairQuery_count = 0;
    if (count)
    {
        keyQuery_count = strdup("count");
        valueQuery_count = (count);
        keyPairQuery_count = keyValuePair_create(keyQuery_count, &valueQuery_count);
        list_addElement(localVarQueryParameters,keyPairQuery_count);
    }

    // query parameters
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);

}

// List public action assignment history
//
void
ActionassignmentAPI_actionassignmentListpublichistory(apiClient_t *apiClient, char * actionassignment )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/listpublichistory")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/listpublichistory");




    // query parameters
    char *keyQuery_actionassignment = NULL;
    char * valueQuery_actionassignment ;
    keyValuePair_t *keyPairQuery_actionassignment = 0;
    if (actionassignment)
    {
        keyQuery_actionassignment = strdup("actionassignment");
        valueQuery_actionassignment = (actionassignment);
        keyPairQuery_actionassignment = keyValuePair_create(keyQuery_actionassignment, &valueQuery_actionassignment);
        list_addElement(localVarQueryParameters,keyPairQuery_actionassignment);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);

}

// Bulk complete action items
//
// Allows the user to bulk complete action items.
//
void
ActionassignmentAPI_actionassignmentMarkcomplete(apiClient_t *apiClient, char * item , char * assignee , char * group , char * notes )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/markcomplete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/markcomplete");




    // query parameters
    char *keyQuery_assignee = NULL;
    char * valueQuery_assignee ;
    keyValuePair_t *keyPairQuery_assignee = 0;
    if (assignee)
    {
        keyQuery_assignee = strdup("assignee");
        valueQuery_assignee = (assignee);
        keyPairQuery_assignee = keyValuePair_create(keyQuery_assignee, &valueQuery_assignee);
        list_addElement(localVarQueryParameters,keyPairQuery_assignee);
    }

    // query parameters
    char *keyQuery_group = NULL;
    char * valueQuery_group ;
    keyValuePair_t *keyPairQuery_group = 0;
    if (group)
    {
        keyQuery_group = strdup("group");
        valueQuery_group = (group);
        keyPairQuery_group = keyValuePair_create(keyQuery_group, &valueQuery_group);
        list_addElement(localVarQueryParameters,keyPairQuery_group);
    }

    // query parameters
    char *keyQuery_item = NULL;
    char * valueQuery_item = NULL;
    keyValuePair_t *keyPairQuery_item = 0;
    if (item)
    {
        keyQuery_item = strdup("item");
        valueQuery_item = strdup((item));
        keyPairQuery_item = keyValuePair_create(keyQuery_item, valueQuery_item);
        list_addElement(localVarQueryParameters,keyPairQuery_item);
    }

    // query parameters
    char *keyQuery_notes = NULL;
    char * valueQuery_notes = NULL;
    keyValuePair_t *keyPairQuery_notes = 0;
    if (notes)
    {
        keyQuery_notes = strdup("notes");
        valueQuery_notes = strdup((notes));
        keyPairQuery_notes = keyValuePair_create(keyQuery_notes, valueQuery_notes);
        list_addElement(localVarQueryParameters,keyPairQuery_notes);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_item){
        free(keyQuery_item);
        keyQuery_item = NULL;
    }
    if(valueQuery_item){
        free(valueQuery_item);
        valueQuery_item = NULL;
    }
    if(keyPairQuery_item){
        keyValuePair_free(keyPairQuery_item);
        keyPairQuery_item = NULL;
    }
    if(keyQuery_item){
        free(keyQuery_item);
        keyQuery_item = NULL;
    }
    if(keyPairQuery_item){
        keyValuePair_free(keyPairQuery_item);
        keyPairQuery_item = NULL;
    }
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(valueQuery_notes){
        free(valueQuery_notes);
        valueQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }

}

// Add an action item to a user's action plan
//
// Allows the user to edit or assign an action item to a user
//
void
ActionassignmentAPI_actionassignmentSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/save")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/save");




    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "POST");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

// Update an action item assigned to a user
//
// Allows the user to update or mark an action item as complete.
//
void
ActionassignmentAPI_actionassignmentSavehistory(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionassignment/savehistory")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionassignment/savehistory");




    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "POST");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

