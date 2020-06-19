#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "InteractionAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Delete an interaction
//
void
InteractionAPI_interactionDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/interaction/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/interaction/{id}");


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

// Get the interactions feed
//
void
InteractionAPI_interactionFeed(apiClient_t *apiClient, int from , int count , char startdate , int public , char * contexttype , char * contextid , char * types , int photosize , int showdefaultphoto , int orderdescending )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/interaction/feed")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/interaction/feed");




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
    char *keyQuery_startdate = NULL;
    char valueQuery_startdate ;
    keyValuePair_t *keyPairQuery_startdate = 0;
    if (startdate)
    {
        keyQuery_startdate = strdup("startdate");
        valueQuery_startdate = (startdate);
        keyPairQuery_startdate = keyValuePair_create(keyQuery_startdate, &valueQuery_startdate);
        list_addElement(localVarQueryParameters,keyPairQuery_startdate);
    }

    // query parameters
    char *keyQuery_public = NULL;
    int valueQuery_public ;
    keyValuePair_t *keyPairQuery_public = 0;
    if (public)
    {
        keyQuery_public = strdup("public");
        valueQuery_public = (public);
        keyPairQuery_public = keyValuePair_create(keyQuery_public, &valueQuery_public);
        list_addElement(localVarQueryParameters,keyPairQuery_public);
    }

    // query parameters
    char *keyQuery_contexttype = NULL;
    char * valueQuery_contexttype = NULL;
    keyValuePair_t *keyPairQuery_contexttype = 0;
    if (contexttype)
    {
        keyQuery_contexttype = strdup("contexttype");
        valueQuery_contexttype = strdup((contexttype));
        keyPairQuery_contexttype = keyValuePair_create(keyQuery_contexttype, valueQuery_contexttype);
        list_addElement(localVarQueryParameters,keyPairQuery_contexttype);
    }

    // query parameters
    char *keyQuery_contextid = NULL;
    char * valueQuery_contextid ;
    keyValuePair_t *keyPairQuery_contextid = 0;
    if (contextid)
    {
        keyQuery_contextid = strdup("contextid");
        valueQuery_contextid = (contextid);
        keyPairQuery_contextid = keyValuePair_create(keyQuery_contextid, &valueQuery_contextid);
        list_addElement(localVarQueryParameters,keyPairQuery_contextid);
    }

    // query parameters
    char *keyQuery_types = NULL;
    char * valueQuery_types = NULL;
    keyValuePair_t *keyPairQuery_types = 0;
    if (types)
    {
        keyQuery_types = strdup("types");
        valueQuery_types = strdup((types));
        keyPairQuery_types = keyValuePair_create(keyQuery_types, valueQuery_types);
        list_addElement(localVarQueryParameters,keyPairQuery_types);
    }

    // query parameters
    char *keyQuery_photosize = NULL;
    int valueQuery_photosize ;
    keyValuePair_t *keyPairQuery_photosize = 0;
    if (photosize)
    {
        keyQuery_photosize = strdup("photosize");
        valueQuery_photosize = (photosize);
        keyPairQuery_photosize = keyValuePair_create(keyQuery_photosize, &valueQuery_photosize);
        list_addElement(localVarQueryParameters,keyPairQuery_photosize);
    }

    // query parameters
    char *keyQuery_showdefaultphoto = NULL;
    int valueQuery_showdefaultphoto ;
    keyValuePair_t *keyPairQuery_showdefaultphoto = 0;
    if (showdefaultphoto)
    {
        keyQuery_showdefaultphoto = strdup("showdefaultphoto");
        valueQuery_showdefaultphoto = (showdefaultphoto);
        keyPairQuery_showdefaultphoto = keyValuePair_create(keyQuery_showdefaultphoto, &valueQuery_showdefaultphoto);
        list_addElement(localVarQueryParameters,keyPairQuery_showdefaultphoto);
    }

    // query parameters
    char *keyQuery_orderdescending = NULL;
    int valueQuery_orderdescending ;
    keyValuePair_t *keyPairQuery_orderdescending = 0;
    if (orderdescending)
    {
        keyQuery_orderdescending = strdup("orderdescending");
        valueQuery_orderdescending = (orderdescending);
        keyPairQuery_orderdescending = keyValuePair_create(keyQuery_orderdescending, &valueQuery_orderdescending);
        list_addElement(localVarQueryParameters,keyPairQuery_orderdescending);
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
    if(keyQuery_contexttype){
        free(keyQuery_contexttype);
        keyQuery_contexttype = NULL;
    }
    if(valueQuery_contexttype){
        free(valueQuery_contexttype);
        valueQuery_contexttype = NULL;
    }
    if(keyPairQuery_contexttype){
        keyValuePair_free(keyPairQuery_contexttype);
        keyPairQuery_contexttype = NULL;
    }
    if(keyQuery_contexttype){
        free(keyQuery_contexttype);
        keyQuery_contexttype = NULL;
    }
    if(keyPairQuery_contexttype){
        keyValuePair_free(keyPairQuery_contexttype);
        keyPairQuery_contexttype = NULL;
    }
    if(keyQuery_types){
        free(keyQuery_types);
        keyQuery_types = NULL;
    }
    if(valueQuery_types){
        free(valueQuery_types);
        valueQuery_types = NULL;
    }
    if(keyPairQuery_types){
        keyValuePair_free(keyPairQuery_types);
        keyPairQuery_types = NULL;
    }
    if(keyQuery_types){
        free(keyQuery_types);
        keyQuery_types = NULL;
    }
    if(keyPairQuery_types){
        keyValuePair_free(keyPairQuery_types);
        keyPairQuery_types = NULL;
    }

}

// View an interaction
//
void
InteractionAPI_interactionGet(apiClient_t *apiClient, char * id , int thumbnailmediasize , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/interaction/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/interaction/{id}");


    // Path Params
    long sizeOfPathParams_id = strlen(id)+3 + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // query parameters
    char *keyQuery_thumbnailmediasize = NULL;
    int valueQuery_thumbnailmediasize ;
    keyValuePair_t *keyPairQuery_thumbnailmediasize = 0;
    if (thumbnailmediasize)
    {
        keyQuery_thumbnailmediasize = strdup("thumbnailmediasize");
        valueQuery_thumbnailmediasize = (thumbnailmediasize);
        keyPairQuery_thumbnailmediasize = keyValuePair_create(keyQuery_thumbnailmediasize, &valueQuery_thumbnailmediasize);
        list_addElement(localVarQueryParameters,keyPairQuery_thumbnailmediasize);
    }

    // query parameters
    char *keyQuery_photosize = NULL;
    int valueQuery_photosize ;
    keyValuePair_t *keyPairQuery_photosize = 0;
    if (photosize)
    {
        keyQuery_photosize = strdup("photosize");
        valueQuery_photosize = (photosize);
        keyPairQuery_photosize = keyValuePair_create(keyQuery_photosize, &valueQuery_photosize);
        list_addElement(localVarQueryParameters,keyPairQuery_photosize);
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
    free(localVarToReplace_id);

}

// Get current user's latest private interactions
//
void
InteractionAPI_interactionListprivatesummary(apiClient_t *apiClient, int photosize , int showdefaultphoto )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/interaction/listprivatesummary")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/interaction/listprivatesummary");




    // query parameters
    char *keyQuery_photosize = NULL;
    int valueQuery_photosize ;
    keyValuePair_t *keyPairQuery_photosize = 0;
    if (photosize)
    {
        keyQuery_photosize = strdup("photosize");
        valueQuery_photosize = (photosize);
        keyPairQuery_photosize = keyValuePair_create(keyQuery_photosize, &valueQuery_photosize);
        list_addElement(localVarQueryParameters,keyPairQuery_photosize);
    }

    // query parameters
    char *keyQuery_showdefaultphoto = NULL;
    int valueQuery_showdefaultphoto ;
    keyValuePair_t *keyPairQuery_showdefaultphoto = 0;
    if (showdefaultphoto)
    {
        keyQuery_showdefaultphoto = strdup("showdefaultphoto");
        valueQuery_showdefaultphoto = (showdefaultphoto);
        keyPairQuery_showdefaultphoto = keyValuePair_create(keyQuery_showdefaultphoto, &valueQuery_showdefaultphoto);
        list_addElement(localVarQueryParameters,keyPairQuery_showdefaultphoto);
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

// Save an interaction
//
void
InteractionAPI_interactionSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/interaction/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/interaction/{id}");


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

