#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "WaitinglineAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Put user in a waiting line
//
void
WaitinglineAPI_waitinglineAdduser(apiClient_t *apiClient, char * station , char * user , char * locationid , char time , char * signinrole , char * roleid , char * services , char * eventid , char * staff , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/adduser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/adduser");




    // query parameters
    char *keyQuery_station = NULL;
    char * valueQuery_station ;
    keyValuePair_t *keyPairQuery_station = 0;
    if (station)
    {
        keyQuery_station = strdup("station");
        valueQuery_station = (station);
        keyPairQuery_station = keyValuePair_create(keyQuery_station, &valueQuery_station);
        list_addElement(localVarQueryParameters,keyPairQuery_station);
    }

    // query parameters
    char *keyQuery_locationid = NULL;
    char * valueQuery_locationid ;
    keyValuePair_t *keyPairQuery_locationid = 0;
    if (locationid)
    {
        keyQuery_locationid = strdup("locationid");
        valueQuery_locationid = (locationid);
        keyPairQuery_locationid = keyValuePair_create(keyQuery_locationid, &valueQuery_locationid);
        list_addElement(localVarQueryParameters,keyPairQuery_locationid);
    }

    // query parameters
    char *keyQuery_time = NULL;
    char valueQuery_time ;
    keyValuePair_t *keyPairQuery_time = 0;
    if (time)
    {
        keyQuery_time = strdup("time");
        valueQuery_time = (time);
        keyPairQuery_time = keyValuePair_create(keyQuery_time, &valueQuery_time);
        list_addElement(localVarQueryParameters,keyPairQuery_time);
    }

    // query parameters
    char *keyQuery_user = NULL;
    char * valueQuery_user = NULL;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = strdup((user));
        keyPairQuery_user = keyValuePair_create(keyQuery_user, valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
    }

    // query parameters
    char *keyQuery_signinrole = NULL;
    char * valueQuery_signinrole = NULL;
    keyValuePair_t *keyPairQuery_signinrole = 0;
    if (signinrole)
    {
        keyQuery_signinrole = strdup("signinrole");
        valueQuery_signinrole = strdup((signinrole));
        keyPairQuery_signinrole = keyValuePair_create(keyQuery_signinrole, valueQuery_signinrole);
        list_addElement(localVarQueryParameters,keyPairQuery_signinrole);
    }

    // query parameters
    char *keyQuery_roleid = NULL;
    char * valueQuery_roleid ;
    keyValuePair_t *keyPairQuery_roleid = 0;
    if (roleid)
    {
        keyQuery_roleid = strdup("roleid");
        valueQuery_roleid = (roleid);
        keyPairQuery_roleid = keyValuePair_create(keyQuery_roleid, &valueQuery_roleid);
        list_addElement(localVarQueryParameters,keyPairQuery_roleid);
    }

    // query parameters
    char *keyQuery_services = NULL;
    char * valueQuery_services = NULL;
    keyValuePair_t *keyPairQuery_services = 0;
    if (services)
    {
        keyQuery_services = strdup("services");
        valueQuery_services = strdup((services));
        keyPairQuery_services = keyValuePair_create(keyQuery_services, valueQuery_services);
        list_addElement(localVarQueryParameters,keyPairQuery_services);
    }

    // query parameters
    char *keyQuery_eventid = NULL;
    char * valueQuery_eventid ;
    keyValuePair_t *keyPairQuery_eventid = 0;
    if (eventid)
    {
        keyQuery_eventid = strdup("eventid");
        valueQuery_eventid = (eventid);
        keyPairQuery_eventid = keyValuePair_create(keyQuery_eventid, &valueQuery_eventid);
        list_addElement(localVarQueryParameters,keyPairQuery_eventid);
    }

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
    if(keyQuery_user){
        free(keyQuery_user);
        keyQuery_user = NULL;
    }
    if(valueQuery_user){
        free(valueQuery_user);
        valueQuery_user = NULL;
    }
    if(keyPairQuery_user){
        keyValuePair_free(keyPairQuery_user);
        keyPairQuery_user = NULL;
    }
    if(keyQuery_user){
        free(keyQuery_user);
        keyQuery_user = NULL;
    }
    if(keyPairQuery_user){
        keyValuePair_free(keyPairQuery_user);
        keyPairQuery_user = NULL;
    }
    if(keyQuery_signinrole){
        free(keyQuery_signinrole);
        keyQuery_signinrole = NULL;
    }
    if(valueQuery_signinrole){
        free(valueQuery_signinrole);
        valueQuery_signinrole = NULL;
    }
    if(keyPairQuery_signinrole){
        keyValuePair_free(keyPairQuery_signinrole);
        keyPairQuery_signinrole = NULL;
    }
    if(keyQuery_signinrole){
        free(keyQuery_signinrole);
        keyQuery_signinrole = NULL;
    }
    if(keyPairQuery_signinrole){
        keyValuePair_free(keyPairQuery_signinrole);
        keyPairQuery_signinrole = NULL;
    }
    if(keyQuery_services){
        free(keyQuery_services);
        keyQuery_services = NULL;
    }
    if(valueQuery_services){
        free(valueQuery_services);
        valueQuery_services = NULL;
    }
    if(keyPairQuery_services){
        keyValuePair_free(keyPairQuery_services);
        keyPairQuery_services = NULL;
    }
    if(keyQuery_services){
        free(keyQuery_services);
        keyQuery_services = NULL;
    }
    if(keyPairQuery_services){
        keyValuePair_free(keyPairQuery_services);
        keyPairQuery_services = NULL;
    }

}

// Delete a waiting line
//
// Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.
//
void
WaitinglineAPI_waitinglineDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/{id}");


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

// View details of a waiting line
//
// Allows the user to view the details of a waiting line in a location to which they are scoped.
//
void
WaitinglineAPI_waitinglineGet(apiClient_t *apiClient, char * id , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



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

// Check whether a user is in a waiting line, signed-in or is not in the area
//
void
WaitinglineAPI_waitinglineIsuserin(apiClient_t *apiClient, char * station , char time , char * user , char * location )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/isuserin")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/isuserin");




    // query parameters
    char *keyQuery_station = NULL;
    char * valueQuery_station ;
    keyValuePair_t *keyPairQuery_station = 0;
    if (station)
    {
        keyQuery_station = strdup("station");
        valueQuery_station = (station);
        keyPairQuery_station = keyValuePair_create(keyQuery_station, &valueQuery_station);
        list_addElement(localVarQueryParameters,keyPairQuery_station);
    }

    // query parameters
    char *keyQuery_time = NULL;
    char valueQuery_time ;
    keyValuePair_t *keyPairQuery_time = 0;
    if (time)
    {
        keyQuery_time = strdup("time");
        valueQuery_time = (time);
        keyPairQuery_time = keyValuePair_create(keyQuery_time, &valueQuery_time);
        list_addElement(localVarQueryParameters,keyPairQuery_time);
    }

    // query parameters
    char *keyQuery_user = NULL;
    char * valueQuery_user = NULL;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = strdup((user));
        keyPairQuery_user = keyValuePair_create(keyQuery_user, valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
    }

    // query parameters
    char *keyQuery_location = NULL;
    char * valueQuery_location ;
    keyValuePair_t *keyPairQuery_location = 0;
    if (location)
    {
        keyQuery_location = strdup("location");
        valueQuery_location = (location);
        keyPairQuery_location = keyValuePair_create(keyQuery_location, &valueQuery_location);
        list_addElement(localVarQueryParameters,keyPairQuery_location);
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
    if(keyQuery_user){
        free(keyQuery_user);
        keyQuery_user = NULL;
    }
    if(valueQuery_user){
        free(valueQuery_user);
        valueQuery_user = NULL;
    }
    if(keyPairQuery_user){
        keyValuePair_free(keyPairQuery_user);
        keyPairQuery_user = NULL;
    }
    if(keyQuery_user){
        free(keyQuery_user);
        keyQuery_user = NULL;
    }
    if(keyPairQuery_user){
        keyValuePair_free(keyPairQuery_user);
        keyPairQuery_user = NULL;
    }

}

// View a list of waiting lines
//
// Allows the user to view the list of waiting lines in locations to which they are scoped.
//
void
WaitinglineAPI_waitinglineList(apiClient_t *apiClient, int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/list");




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

// Remove a user from a waiting line
//
// Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.
//
void
WaitinglineAPI_waitinglineRemoveuser(apiClient_t *apiClient, char * waitingline , char * itemid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/removeuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/removeuser");




    // query parameters
    char *keyQuery_waitingline = NULL;
    char * valueQuery_waitingline ;
    keyValuePair_t *keyPairQuery_waitingline = 0;
    if (waitingline)
    {
        keyQuery_waitingline = strdup("waitingline");
        valueQuery_waitingline = (waitingline);
        keyPairQuery_waitingline = keyValuePair_create(keyQuery_waitingline, &valueQuery_waitingline);
        list_addElement(localVarQueryParameters,keyPairQuery_waitingline);
    }

    // query parameters
    char *keyQuery_itemid = NULL;
    char * valueQuery_itemid ;
    keyValuePair_t *keyPairQuery_itemid = 0;
    if (itemid)
    {
        keyQuery_itemid = strdup("itemid");
        valueQuery_itemid = (itemid);
        keyPairQuery_itemid = keyValuePair_create(keyQuery_itemid, &valueQuery_itemid);
        list_addElement(localVarQueryParameters,keyPairQuery_itemid);
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

// Create or edit a waiting line
//
// Allows the user to create or edit a waiting line in a location to which they are scoped.
//
void
WaitinglineAPI_waitinglineSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/{id}");


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

// Sign a user in from a waiting line
//
// Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.
//
void
WaitinglineAPI_waitinglineSigninuser(apiClient_t *apiClient, char * waitingline , char * itemid , char * staff , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/waitingline/signinuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/waitingline/signinuser");




    // query parameters
    char *keyQuery_waitingline = NULL;
    char * valueQuery_waitingline ;
    keyValuePair_t *keyPairQuery_waitingline = 0;
    if (waitingline)
    {
        keyQuery_waitingline = strdup("waitingline");
        valueQuery_waitingline = (waitingline);
        keyPairQuery_waitingline = keyValuePair_create(keyQuery_waitingline, &valueQuery_waitingline);
        list_addElement(localVarQueryParameters,keyPairQuery_waitingline);
    }

    // query parameters
    char *keyQuery_itemid = NULL;
    char * valueQuery_itemid ;
    keyValuePair_t *keyPairQuery_itemid = 0;
    if (itemid)
    {
        keyQuery_itemid = strdup("itemid");
        valueQuery_itemid = (itemid);
        keyPairQuery_itemid = keyValuePair_create(keyQuery_itemid, &valueQuery_itemid);
        list_addElement(localVarQueryParameters,keyPairQuery_itemid);
    }

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

}

