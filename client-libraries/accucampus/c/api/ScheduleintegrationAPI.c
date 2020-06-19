#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ScheduleintegrationAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Clear all third party IDs from specified staff member's schedule items.
//
void
ScheduleintegrationAPI_scheduleintegrationClearids(apiClient_t *apiClient, char * staff )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/scheduleintegration/clearids")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/scheduleintegration/clearids");




    // query parameters
    char *keyQuery_staff = NULL;
    char * valueQuery_staff ;
    keyValuePair_t *keyPairQuery_staff = 0;
    if (staff)
    {
        keyQuery_staff = strdup("staff");
        valueQuery_staff = (staff);
        keyPairQuery_staff = keyValuePair_create(keyQuery_staff, &valueQuery_staff);
        list_addElement(localVarQueryParameters,keyPairQuery_staff);
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

// Delete a schedule item looking up by a third party ID
//
void
ScheduleintegrationAPI_scheduleintegrationDeleteitem(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/scheduleintegration/deleteitem")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/scheduleintegration/deleteitem");




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
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

// Delete multiple schedule items looking up by a third party master ID
//
void
ScheduleintegrationAPI_scheduleintegrationDeleteitemsbymasterid(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/scheduleintegration/deleteitemsbymasterid")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/scheduleintegration/deleteitemsbymasterid");




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
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

// Get a schedule item looking up by a third party ID
//
void
ScheduleintegrationAPI_scheduleintegrationGetitem(apiClient_t *apiClient, char * thirdpartyid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/scheduleintegration/getitem")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/scheduleintegration/getitem");




    // query parameters
    char *keyQuery_thirdpartyid = NULL;
    char * valueQuery_thirdpartyid = NULL;
    keyValuePair_t *keyPairQuery_thirdpartyid = 0;
    if (thirdpartyid)
    {
        keyQuery_thirdpartyid = strdup("thirdpartyid");
        valueQuery_thirdpartyid = strdup((thirdpartyid));
        keyPairQuery_thirdpartyid = keyValuePair_create(keyQuery_thirdpartyid, valueQuery_thirdpartyid);
        list_addElement(localVarQueryParameters,keyPairQuery_thirdpartyid);
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
    if(keyQuery_thirdpartyid){
        free(keyQuery_thirdpartyid);
        keyQuery_thirdpartyid = NULL;
    }
    if(valueQuery_thirdpartyid){
        free(valueQuery_thirdpartyid);
        valueQuery_thirdpartyid = NULL;
    }
    if(keyPairQuery_thirdpartyid){
        keyValuePair_free(keyPairQuery_thirdpartyid);
        keyPairQuery_thirdpartyid = NULL;
    }
    if(keyQuery_thirdpartyid){
        free(keyQuery_thirdpartyid);
        keyQuery_thirdpartyid = NULL;
    }
    if(keyPairQuery_thirdpartyid){
        keyValuePair_free(keyPairQuery_thirdpartyid);
        keyPairQuery_thirdpartyid = NULL;
    }

}

// Save a schedule item looking up by a third party ID
//
void
ScheduleintegrationAPI_scheduleintegrationSaveitem(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/scheduleintegration/saveitem")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/scheduleintegration/saveitem");




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

// Set a 3rd party ID on a specific schedule item
//
void
ScheduleintegrationAPI_scheduleintegrationSetid(apiClient_t *apiClient, char * id , char * thirdpartyid , char * thirdpartymasterid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/scheduleintegration/setid")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/scheduleintegration/setid");




    // query parameters
    char *keyQuery_id = NULL;
    char * valueQuery_id ;
    keyValuePair_t *keyPairQuery_id = 0;
    if (id)
    {
        keyQuery_id = strdup("id");
        valueQuery_id = (id);
        keyPairQuery_id = keyValuePair_create(keyQuery_id, &valueQuery_id);
        list_addElement(localVarQueryParameters,keyPairQuery_id);
    }

    // query parameters
    char *keyQuery_thirdpartyid = NULL;
    char * valueQuery_thirdpartyid = NULL;
    keyValuePair_t *keyPairQuery_thirdpartyid = 0;
    if (thirdpartyid)
    {
        keyQuery_thirdpartyid = strdup("thirdpartyid");
        valueQuery_thirdpartyid = strdup((thirdpartyid));
        keyPairQuery_thirdpartyid = keyValuePair_create(keyQuery_thirdpartyid, valueQuery_thirdpartyid);
        list_addElement(localVarQueryParameters,keyPairQuery_thirdpartyid);
    }

    // query parameters
    char *keyQuery_thirdpartymasterid = NULL;
    char * valueQuery_thirdpartymasterid = NULL;
    keyValuePair_t *keyPairQuery_thirdpartymasterid = 0;
    if (thirdpartymasterid)
    {
        keyQuery_thirdpartymasterid = strdup("thirdpartymasterid");
        valueQuery_thirdpartymasterid = strdup((thirdpartymasterid));
        keyPairQuery_thirdpartymasterid = keyValuePair_create(keyQuery_thirdpartymasterid, valueQuery_thirdpartymasterid);
        list_addElement(localVarQueryParameters,keyPairQuery_thirdpartymasterid);
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
    if(keyQuery_thirdpartyid){
        free(keyQuery_thirdpartyid);
        keyQuery_thirdpartyid = NULL;
    }
    if(valueQuery_thirdpartyid){
        free(valueQuery_thirdpartyid);
        valueQuery_thirdpartyid = NULL;
    }
    if(keyPairQuery_thirdpartyid){
        keyValuePair_free(keyPairQuery_thirdpartyid);
        keyPairQuery_thirdpartyid = NULL;
    }
    if(keyQuery_thirdpartyid){
        free(keyQuery_thirdpartyid);
        keyQuery_thirdpartyid = NULL;
    }
    if(keyPairQuery_thirdpartyid){
        keyValuePair_free(keyPairQuery_thirdpartyid);
        keyPairQuery_thirdpartyid = NULL;
    }
    if(keyQuery_thirdpartymasterid){
        free(keyQuery_thirdpartymasterid);
        keyQuery_thirdpartymasterid = NULL;
    }
    if(valueQuery_thirdpartymasterid){
        free(valueQuery_thirdpartymasterid);
        valueQuery_thirdpartymasterid = NULL;
    }
    if(keyPairQuery_thirdpartymasterid){
        keyValuePair_free(keyPairQuery_thirdpartymasterid);
        keyPairQuery_thirdpartymasterid = NULL;
    }
    if(keyQuery_thirdpartymasterid){
        free(keyQuery_thirdpartymasterid);
        keyQuery_thirdpartymasterid = NULL;
    }
    if(keyPairQuery_thirdpartymasterid){
        keyValuePair_free(keyPairQuery_thirdpartymasterid);
        keyPairQuery_thirdpartymasterid = NULL;
    }

}

