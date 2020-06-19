#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ActionpackAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Assign an action item pack to a user
//
// Allows the user to assign an action pack to a user or group of users.
//
void
ActionpackAPI_actionpackAssign(apiClient_t *apiClient, char * pack , int itemsdata , char * assignee , char * group , char * notes )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionpack/assign")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionpack/assign");




    // query parameters
    char *keyQuery_pack = NULL;
    char * valueQuery_pack ;
    keyValuePair_t *keyPairQuery_pack = 0;
    if (pack)
    {
        keyQuery_pack = strdup("pack");
        valueQuery_pack = (pack);
        keyPairQuery_pack = keyValuePair_create(keyQuery_pack, &valueQuery_pack);
        list_addElement(localVarQueryParameters,keyPairQuery_pack);
    }

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
    char *keyQuery_itemsdata = NULL;
    int valueQuery_itemsdata ;
    keyValuePair_t *keyPairQuery_itemsdata = 0;
    if (itemsdata)
    {
        keyQuery_itemsdata = strdup("itemsdata");
        valueQuery_itemsdata = (itemsdata);
        keyPairQuery_itemsdata = keyValuePair_create(keyQuery_itemsdata, &valueQuery_itemsdata);
        list_addElement(localVarQueryParameters,keyPairQuery_itemsdata);
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

// Delete an action item pack
//
// Allows the user to delete an action item pack.
//
void
ActionpackAPI_actionpackDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionpack/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionpack/{id}");


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

// View details of an action item pack
//
// Allows the user to view an individual action pack and its details.
//
void
ActionpackAPI_actionpackGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionpack/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionpack/{id}");


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

// View a list of action item packs
//
// Allows the user to view the full list of action item packs.
//
void
ActionpackAPI_actionpackList(apiClient_t *apiClient, int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionpack/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionpack/list");




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

// Create or edit an action item pack
//
// Allows the user to edit an action item pack.
//
void
ActionpackAPI_actionpackSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionpack/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionpack/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



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
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

