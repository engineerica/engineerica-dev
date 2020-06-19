#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ClientAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Get client
//
void
ClientAPI_clientGet(apiClient_t *apiClient, char * client , char * clientname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/client/get")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/client/get");




    // query parameters
    char *keyQuery_client = NULL;
    char * valueQuery_client = NULL;
    keyValuePair_t *keyPairQuery_client = 0;
    if (client)
    {
        keyQuery_client = strdup("client");
        valueQuery_client = strdup((client));
        keyPairQuery_client = keyValuePair_create(keyQuery_client, valueQuery_client);
        list_addElement(localVarQueryParameters,keyPairQuery_client);
    }

    // query parameters
    char *keyQuery_clientname = NULL;
    char * valueQuery_clientname = NULL;
    keyValuePair_t *keyPairQuery_clientname = 0;
    if (clientname)
    {
        keyQuery_clientname = strdup("clientname");
        valueQuery_clientname = strdup((clientname));
        keyPairQuery_clientname = keyValuePair_create(keyQuery_clientname, valueQuery_clientname);
        list_addElement(localVarQueryParameters,keyPairQuery_clientname);
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
    if(keyQuery_client){
        free(keyQuery_client);
        keyQuery_client = NULL;
    }
    if(valueQuery_client){
        free(valueQuery_client);
        valueQuery_client = NULL;
    }
    if(keyPairQuery_client){
        keyValuePair_free(keyPairQuery_client);
        keyPairQuery_client = NULL;
    }
    if(keyQuery_client){
        free(keyQuery_client);
        keyQuery_client = NULL;
    }
    if(keyPairQuery_client){
        keyValuePair_free(keyPairQuery_client);
        keyPairQuery_client = NULL;
    }
    if(keyQuery_clientname){
        free(keyQuery_clientname);
        keyQuery_clientname = NULL;
    }
    if(valueQuery_clientname){
        free(valueQuery_clientname);
        valueQuery_clientname = NULL;
    }
    if(keyPairQuery_clientname){
        keyValuePair_free(keyPairQuery_clientname);
        keyPairQuery_clientname = NULL;
    }
    if(keyQuery_clientname){
        free(keyQuery_clientname);
        keyQuery_clientname = NULL;
    }
    if(keyPairQuery_clientname){
        keyValuePair_free(keyPairQuery_clientname);
        keyPairQuery_clientname = NULL;
    }

}

// Gets the clients of the specified conference
//
void
ClientAPI_clientList(apiClient_t *apiClient, int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/client/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/client/list");




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

// Saves a client
//
void
ClientAPI_clientSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/client/save")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/client/save");




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

// Send a message to a client
//
void
ClientAPI_clientSendmessage(apiClient_t *apiClient, char * uniqueclientid , char * message )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/client/sendmessage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/client/sendmessage");




    // query parameters
    char *keyQuery_uniqueclientid = NULL;
    char * valueQuery_uniqueclientid ;
    keyValuePair_t *keyPairQuery_uniqueclientid = 0;
    if (uniqueclientid)
    {
        keyQuery_uniqueclientid = strdup("uniqueclientid");
        valueQuery_uniqueclientid = (uniqueclientid);
        keyPairQuery_uniqueclientid = keyValuePair_create(keyQuery_uniqueclientid, &valueQuery_uniqueclientid);
        list_addElement(localVarQueryParameters,keyPairQuery_uniqueclientid);
    }

    // query parameters
    char *keyQuery_message = NULL;
    char * valueQuery_message = NULL;
    keyValuePair_t *keyPairQuery_message = 0;
    if (message)
    {
        keyQuery_message = strdup("message");
        valueQuery_message = strdup((message));
        keyPairQuery_message = keyValuePair_create(keyQuery_message, valueQuery_message);
        list_addElement(localVarQueryParameters,keyPairQuery_message);
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
    if(keyQuery_message){
        free(keyQuery_message);
        keyQuery_message = NULL;
    }
    if(valueQuery_message){
        free(valueQuery_message);
        valueQuery_message = NULL;
    }
    if(keyPairQuery_message){
        keyValuePair_free(keyPairQuery_message);
        keyPairQuery_message = NULL;
    }
    if(keyQuery_message){
        free(keyQuery_message);
        keyQuery_message = NULL;
    }
    if(keyPairQuery_message){
        keyValuePair_free(keyPairQuery_message);
        keyPairQuery_message = NULL;
    }

}

