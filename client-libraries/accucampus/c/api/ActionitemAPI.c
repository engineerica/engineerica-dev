#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ActionitemAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Delete an action item
//
// Allows the user to delete an action item.
//
void
ActionitemAPI_actionitemDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionitem/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionitem/{id}");


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

// Search and view details of an action item
//
// Allows the user to view an individual action item and its details.
//
void
ActionitemAPI_actionitemGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionitem/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionitem/{id}");


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

// View a list of action items
//
// Allows the user to view a list of action items
//
void
ActionitemAPI_actionitemList(apiClient_t *apiClient, int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionitem/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionitem/list");




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

// Create or edit an action item
//
// Allows the user to edit an action item.
//
void
ActionitemAPI_actionitemSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionitem/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionitem/{id}");


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

