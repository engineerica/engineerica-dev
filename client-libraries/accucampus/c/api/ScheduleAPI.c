#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ScheduleAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Delete a schedule slot
//
// Allows the user to delete a schedule slot from another user.
//
void
ScheduleAPI_scheduleDelete(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/delete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/delete");




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

// Delete a specific block from a user's own schedule
//
// Allows the user to delete a schedule block from their own availability.
//
void
ScheduleAPI_scheduleDeletemine(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/deletemine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/deletemine");




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

// Enable or disable the schedule for a specific person
//
// Allows the user to enable or disable a schedule for another user.
//
void
ScheduleAPI_scheduleEnable(apiClient_t *apiClient, char * userid , int enable )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/enable")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/enable");




    // query parameters
    char *keyQuery_userid = NULL;
    char * valueQuery_userid ;
    keyValuePair_t *keyPairQuery_userid = 0;
    if (userid)
    {
        keyQuery_userid = strdup("userid");
        valueQuery_userid = (userid);
        keyPairQuery_userid = keyValuePair_create(keyQuery_userid, &valueQuery_userid);
        list_addElement(localVarQueryParameters,keyPairQuery_userid);
    }

    // query parameters
    char *keyQuery_enable = NULL;
    int valueQuery_enable ;
    keyValuePair_t *keyPairQuery_enable = 0;
    if (enable)
    {
        keyQuery_enable = strdup("enable");
        valueQuery_enable = (enable);
        keyPairQuery_enable = keyValuePair_create(keyQuery_enable, &valueQuery_enable);
        list_addElement(localVarQueryParameters,keyPairQuery_enable);
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

// Enable or disable current user's schedule
//
// Allows the user to enable or disable a schedule for himself.
//
void
ScheduleAPI_scheduleEnablemine(apiClient_t *apiClient, int enable )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/enablemine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/enablemine");




    // query parameters
    char *keyQuery_enable = NULL;
    int valueQuery_enable ;
    keyValuePair_t *keyPairQuery_enable = 0;
    if (enable)
    {
        keyQuery_enable = strdup("enable");
        valueQuery_enable = (enable);
        keyPairQuery_enable = keyValuePair_create(keyQuery_enable, &valueQuery_enable);
        list_addElement(localVarQueryParameters,keyPairQuery_enable);
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

// Search available schedule slots by service, event, date
//
// Allows users to search available slots.
//
void
ScheduleAPI_scheduleFindallstaffslots(apiClient_t *apiClient, char starttime , char endtime , char * staffid , char * serviceids , char * eventid , char * locationid , char * staffroleids , char * availablefor )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/findallstaffslots")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/findallstaffslots");




    // query parameters
    char *keyQuery_starttime = NULL;
    char valueQuery_starttime ;
    keyValuePair_t *keyPairQuery_starttime = 0;
    if (starttime)
    {
        keyQuery_starttime = strdup("starttime");
        valueQuery_starttime = (starttime);
        keyPairQuery_starttime = keyValuePair_create(keyQuery_starttime, &valueQuery_starttime);
        list_addElement(localVarQueryParameters,keyPairQuery_starttime);
    }

    // query parameters
    char *keyQuery_endtime = NULL;
    char valueQuery_endtime ;
    keyValuePair_t *keyPairQuery_endtime = 0;
    if (endtime)
    {
        keyQuery_endtime = strdup("endtime");
        valueQuery_endtime = (endtime);
        keyPairQuery_endtime = keyValuePair_create(keyQuery_endtime, &valueQuery_endtime);
        list_addElement(localVarQueryParameters,keyPairQuery_endtime);
    }

    // query parameters
    char *keyQuery_staffid = NULL;
    char * valueQuery_staffid ;
    keyValuePair_t *keyPairQuery_staffid = 0;
    if (staffid)
    {
        keyQuery_staffid = strdup("staffid");
        valueQuery_staffid = (staffid);
        keyPairQuery_staffid = keyValuePair_create(keyQuery_staffid, &valueQuery_staffid);
        list_addElement(localVarQueryParameters,keyPairQuery_staffid);
    }

    // query parameters
    char *keyQuery_serviceids = NULL;
    char * valueQuery_serviceids = NULL;
    keyValuePair_t *keyPairQuery_serviceids = 0;
    if (serviceids)
    {
        keyQuery_serviceids = strdup("serviceids");
        valueQuery_serviceids = strdup((serviceids));
        keyPairQuery_serviceids = keyValuePair_create(keyQuery_serviceids, valueQuery_serviceids);
        list_addElement(localVarQueryParameters,keyPairQuery_serviceids);
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
    char *keyQuery_staffroleids = NULL;
    char * valueQuery_staffroleids = NULL;
    keyValuePair_t *keyPairQuery_staffroleids = 0;
    if (staffroleids)
    {
        keyQuery_staffroleids = strdup("staffroleids");
        valueQuery_staffroleids = strdup((staffroleids));
        keyPairQuery_staffroleids = keyValuePair_create(keyQuery_staffroleids, valueQuery_staffroleids);
        list_addElement(localVarQueryParameters,keyPairQuery_staffroleids);
    }

    // query parameters
    char *keyQuery_availablefor = NULL;
    char * valueQuery_availablefor = NULL;
    keyValuePair_t *keyPairQuery_availablefor = 0;
    if (availablefor)
    {
        keyQuery_availablefor = strdup("availablefor");
        valueQuery_availablefor = strdup((availablefor));
        keyPairQuery_availablefor = keyValuePair_create(keyQuery_availablefor, valueQuery_availablefor);
        list_addElement(localVarQueryParameters,keyPairQuery_availablefor);
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
    if(keyQuery_serviceids){
        free(keyQuery_serviceids);
        keyQuery_serviceids = NULL;
    }
    if(valueQuery_serviceids){
        free(valueQuery_serviceids);
        valueQuery_serviceids = NULL;
    }
    if(keyPairQuery_serviceids){
        keyValuePair_free(keyPairQuery_serviceids);
        keyPairQuery_serviceids = NULL;
    }
    if(keyQuery_serviceids){
        free(keyQuery_serviceids);
        keyQuery_serviceids = NULL;
    }
    if(keyPairQuery_serviceids){
        keyValuePair_free(keyPairQuery_serviceids);
        keyPairQuery_serviceids = NULL;
    }
    if(keyQuery_staffroleids){
        free(keyQuery_staffroleids);
        keyQuery_staffroleids = NULL;
    }
    if(valueQuery_staffroleids){
        free(valueQuery_staffroleids);
        valueQuery_staffroleids = NULL;
    }
    if(keyPairQuery_staffroleids){
        keyValuePair_free(keyPairQuery_staffroleids);
        keyPairQuery_staffroleids = NULL;
    }
    if(keyQuery_staffroleids){
        free(keyQuery_staffroleids);
        keyQuery_staffroleids = NULL;
    }
    if(keyPairQuery_staffroleids){
        keyValuePair_free(keyPairQuery_staffroleids);
        keyPairQuery_staffroleids = NULL;
    }
    if(keyQuery_availablefor){
        free(keyQuery_availablefor);
        keyQuery_availablefor = NULL;
    }
    if(valueQuery_availablefor){
        free(valueQuery_availablefor);
        valueQuery_availablefor = NULL;
    }
    if(keyPairQuery_availablefor){
        keyValuePair_free(keyPairQuery_availablefor);
        keyPairQuery_availablefor = NULL;
    }
    if(keyQuery_availablefor){
        free(keyQuery_availablefor);
        keyQuery_availablefor = NULL;
    }
    if(keyPairQuery_availablefor){
        keyValuePair_free(keyPairQuery_availablefor);
        keyPairQuery_availablefor = NULL;
    }

}

// Search available schedule slots by service, event, date and/or staff
//
// Allows users to search available slots when making appointments.
//
void
ScheduleAPI_scheduleFindslots(apiClient_t *apiClient, char * staffid , char starttime , char endtime , char * serviceids , char * eventid , char * locationid , char * availablefor )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/findslots")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/findslots");




    // query parameters
    char *keyQuery_staffid = NULL;
    char * valueQuery_staffid ;
    keyValuePair_t *keyPairQuery_staffid = 0;
    if (staffid)
    {
        keyQuery_staffid = strdup("staffid");
        valueQuery_staffid = (staffid);
        keyPairQuery_staffid = keyValuePair_create(keyQuery_staffid, &valueQuery_staffid);
        list_addElement(localVarQueryParameters,keyPairQuery_staffid);
    }

    // query parameters
    char *keyQuery_starttime = NULL;
    char valueQuery_starttime ;
    keyValuePair_t *keyPairQuery_starttime = 0;
    if (starttime)
    {
        keyQuery_starttime = strdup("starttime");
        valueQuery_starttime = (starttime);
        keyPairQuery_starttime = keyValuePair_create(keyQuery_starttime, &valueQuery_starttime);
        list_addElement(localVarQueryParameters,keyPairQuery_starttime);
    }

    // query parameters
    char *keyQuery_endtime = NULL;
    char valueQuery_endtime ;
    keyValuePair_t *keyPairQuery_endtime = 0;
    if (endtime)
    {
        keyQuery_endtime = strdup("endtime");
        valueQuery_endtime = (endtime);
        keyPairQuery_endtime = keyValuePair_create(keyQuery_endtime, &valueQuery_endtime);
        list_addElement(localVarQueryParameters,keyPairQuery_endtime);
    }

    // query parameters
    char *keyQuery_serviceids = NULL;
    char * valueQuery_serviceids = NULL;
    keyValuePair_t *keyPairQuery_serviceids = 0;
    if (serviceids)
    {
        keyQuery_serviceids = strdup("serviceids");
        valueQuery_serviceids = strdup((serviceids));
        keyPairQuery_serviceids = keyValuePair_create(keyQuery_serviceids, valueQuery_serviceids);
        list_addElement(localVarQueryParameters,keyPairQuery_serviceids);
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
    char *keyQuery_availablefor = NULL;
    char * valueQuery_availablefor = NULL;
    keyValuePair_t *keyPairQuery_availablefor = 0;
    if (availablefor)
    {
        keyQuery_availablefor = strdup("availablefor");
        valueQuery_availablefor = strdup((availablefor));
        keyPairQuery_availablefor = keyValuePair_create(keyQuery_availablefor, valueQuery_availablefor);
        list_addElement(localVarQueryParameters,keyPairQuery_availablefor);
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
    if(keyQuery_serviceids){
        free(keyQuery_serviceids);
        keyQuery_serviceids = NULL;
    }
    if(valueQuery_serviceids){
        free(valueQuery_serviceids);
        valueQuery_serviceids = NULL;
    }
    if(keyPairQuery_serviceids){
        keyValuePair_free(keyPairQuery_serviceids);
        keyPairQuery_serviceids = NULL;
    }
    if(keyQuery_serviceids){
        free(keyQuery_serviceids);
        keyQuery_serviceids = NULL;
    }
    if(keyPairQuery_serviceids){
        keyValuePair_free(keyPairQuery_serviceids);
        keyPairQuery_serviceids = NULL;
    }
    if(keyQuery_availablefor){
        free(keyQuery_availablefor);
        keyQuery_availablefor = NULL;
    }
    if(valueQuery_availablefor){
        free(valueQuery_availablefor);
        valueQuery_availablefor = NULL;
    }
    if(keyPairQuery_availablefor){
        keyValuePair_free(keyPairQuery_availablefor);
        keyPairQuery_availablefor = NULL;
    }
    if(keyQuery_availablefor){
        free(keyQuery_availablefor);
        keyQuery_availablefor = NULL;
    }
    if(keyPairQuery_availablefor){
        keyValuePair_free(keyPairQuery_availablefor);
        keyPairQuery_availablefor = NULL;
    }

}

// Search available staff members slots by service, event, and/or date
//
// Allows users to search available staff.
//
void
ScheduleAPI_scheduleFindstaffavail(apiClient_t *apiClient, char starttime , char endtime , char * serviceids , char * eventid , char * locationid , char * staffroleids , char * availablefor , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/findstaffavail")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/findstaffavail");




    // query parameters
    char *keyQuery_serviceids = NULL;
    char * valueQuery_serviceids = NULL;
    keyValuePair_t *keyPairQuery_serviceids = 0;
    if (serviceids)
    {
        keyQuery_serviceids = strdup("serviceids");
        valueQuery_serviceids = strdup((serviceids));
        keyPairQuery_serviceids = keyValuePair_create(keyQuery_serviceids, valueQuery_serviceids);
        list_addElement(localVarQueryParameters,keyPairQuery_serviceids);
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
    char *keyQuery_starttime = NULL;
    char valueQuery_starttime ;
    keyValuePair_t *keyPairQuery_starttime = 0;
    if (starttime)
    {
        keyQuery_starttime = strdup("starttime");
        valueQuery_starttime = (starttime);
        keyPairQuery_starttime = keyValuePair_create(keyQuery_starttime, &valueQuery_starttime);
        list_addElement(localVarQueryParameters,keyPairQuery_starttime);
    }

    // query parameters
    char *keyQuery_endtime = NULL;
    char valueQuery_endtime ;
    keyValuePair_t *keyPairQuery_endtime = 0;
    if (endtime)
    {
        keyQuery_endtime = strdup("endtime");
        valueQuery_endtime = (endtime);
        keyPairQuery_endtime = keyValuePair_create(keyQuery_endtime, &valueQuery_endtime);
        list_addElement(localVarQueryParameters,keyPairQuery_endtime);
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
    char *keyQuery_staffroleids = NULL;
    char * valueQuery_staffroleids = NULL;
    keyValuePair_t *keyPairQuery_staffroleids = 0;
    if (staffroleids)
    {
        keyQuery_staffroleids = strdup("staffroleids");
        valueQuery_staffroleids = strdup((staffroleids));
        keyPairQuery_staffroleids = keyValuePair_create(keyQuery_staffroleids, valueQuery_staffroleids);
        list_addElement(localVarQueryParameters,keyPairQuery_staffroleids);
    }

    // query parameters
    char *keyQuery_availablefor = NULL;
    char * valueQuery_availablefor = NULL;
    keyValuePair_t *keyPairQuery_availablefor = 0;
    if (availablefor)
    {
        keyQuery_availablefor = strdup("availablefor");
        valueQuery_availablefor = strdup((availablefor));
        keyPairQuery_availablefor = keyValuePair_create(keyQuery_availablefor, valueQuery_availablefor);
        list_addElement(localVarQueryParameters,keyPairQuery_availablefor);
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
    if(keyQuery_serviceids){
        free(keyQuery_serviceids);
        keyQuery_serviceids = NULL;
    }
    if(valueQuery_serviceids){
        free(valueQuery_serviceids);
        valueQuery_serviceids = NULL;
    }
    if(keyPairQuery_serviceids){
        keyValuePair_free(keyPairQuery_serviceids);
        keyPairQuery_serviceids = NULL;
    }
    if(keyQuery_serviceids){
        free(keyQuery_serviceids);
        keyQuery_serviceids = NULL;
    }
    if(keyPairQuery_serviceids){
        keyValuePair_free(keyPairQuery_serviceids);
        keyPairQuery_serviceids = NULL;
    }
    if(keyQuery_staffroleids){
        free(keyQuery_staffroleids);
        keyQuery_staffroleids = NULL;
    }
    if(valueQuery_staffroleids){
        free(valueQuery_staffroleids);
        valueQuery_staffroleids = NULL;
    }
    if(keyPairQuery_staffroleids){
        keyValuePair_free(keyPairQuery_staffroleids);
        keyPairQuery_staffroleids = NULL;
    }
    if(keyQuery_staffroleids){
        free(keyQuery_staffroleids);
        keyQuery_staffroleids = NULL;
    }
    if(keyPairQuery_staffroleids){
        keyValuePair_free(keyPairQuery_staffroleids);
        keyPairQuery_staffroleids = NULL;
    }
    if(keyQuery_availablefor){
        free(keyQuery_availablefor);
        keyQuery_availablefor = NULL;
    }
    if(valueQuery_availablefor){
        free(valueQuery_availablefor);
        valueQuery_availablefor = NULL;
    }
    if(keyPairQuery_availablefor){
        keyValuePair_free(keyPairQuery_availablefor);
        keyPairQuery_availablefor = NULL;
    }
    if(keyQuery_availablefor){
        free(keyQuery_availablefor);
        keyQuery_availablefor = NULL;
    }
    if(keyPairQuery_availablefor){
        keyValuePair_free(keyPairQuery_availablefor);
        keyPairQuery_availablefor = NULL;
    }

}

// Search and view details of a specific schedule slot
//
// Allows the user to view the details of schedule shifts for any user role that the user has permission to view.
//
void
ScheduleAPI_scheduleGet(apiClient_t *apiClient, char * scheduleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/get")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/get");




    // query parameters
    char *keyQuery_scheduleid = NULL;
    char * valueQuery_scheduleid ;
    keyValuePair_t *keyPairQuery_scheduleid = 0;
    if (scheduleid)
    {
        keyQuery_scheduleid = strdup("scheduleid");
        valueQuery_scheduleid = (scheduleid);
        keyPairQuery_scheduleid = keyValuePair_create(keyQuery_scheduleid, &valueQuery_scheduleid);
        list_addElement(localVarQueryParameters,keyPairQuery_scheduleid);
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

// View details of a specific schedule block, for current user
//
// Allows the user to view the details of their own schedule shifts.
//
void
ScheduleAPI_scheduleGetmine(apiClient_t *apiClient, char * scheduleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/getmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/getmine");




    // query parameters
    char *keyQuery_scheduleid = NULL;
    char * valueQuery_scheduleid ;
    keyValuePair_t *keyPairQuery_scheduleid = 0;
    if (scheduleid)
    {
        keyQuery_scheduleid = strdup("scheduleid");
        valueQuery_scheduleid = (scheduleid);
        keyPairQuery_scheduleid = keyValuePair_create(keyQuery_scheduleid, &valueQuery_scheduleid);
        list_addElement(localVarQueryParameters,keyPairQuery_scheduleid);
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

// View a list of schedule information of a specified person
//
// Allows the user to view the schedule shifts for user roles that the user has permission to access.
//
void
ScheduleAPI_scheduleGetstaff(apiClient_t *apiClient, char * userid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/getstaff")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/getstaff");




    // query parameters
    char *keyQuery_userid = NULL;
    char * valueQuery_userid ;
    keyValuePair_t *keyPairQuery_userid = 0;
    if (userid)
    {
        keyQuery_userid = strdup("userid");
        valueQuery_userid = (userid);
        keyPairQuery_userid = keyValuePair_create(keyQuery_userid, &valueQuery_userid);
        list_addElement(localVarQueryParameters,keyPairQuery_userid);
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

// View current user's schedule information
//
// Allows the user to view their own schedule.
//
void
ScheduleAPI_scheduleGetstaffmine(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/getstaffmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/getstaffmine");



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

}

// View current user's schedule exceptions
//
// Allows the user to view their own schedule exceptions.
//
void
ScheduleAPI_scheduleMyofftimes(apiClient_t *apiClient, int includedeleted , int onlyupcoming , char modifiedafter )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/myofftimes")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/myofftimes");




    // query parameters
    char *keyQuery_includedeleted = NULL;
    int valueQuery_includedeleted ;
    keyValuePair_t *keyPairQuery_includedeleted = 0;
    if (includedeleted)
    {
        keyQuery_includedeleted = strdup("includedeleted");
        valueQuery_includedeleted = (includedeleted);
        keyPairQuery_includedeleted = keyValuePair_create(keyQuery_includedeleted, &valueQuery_includedeleted);
        list_addElement(localVarQueryParameters,keyPairQuery_includedeleted);
    }

    // query parameters
    char *keyQuery_onlyupcoming = NULL;
    int valueQuery_onlyupcoming ;
    keyValuePair_t *keyPairQuery_onlyupcoming = 0;
    if (onlyupcoming)
    {
        keyQuery_onlyupcoming = strdup("onlyupcoming");
        valueQuery_onlyupcoming = (onlyupcoming);
        keyPairQuery_onlyupcoming = keyValuePair_create(keyQuery_onlyupcoming, &valueQuery_onlyupcoming);
        list_addElement(localVarQueryParameters,keyPairQuery_onlyupcoming);
    }

    // query parameters
    char *keyQuery_modifiedafter = NULL;
    char valueQuery_modifiedafter ;
    keyValuePair_t *keyPairQuery_modifiedafter = 0;
    if (modifiedafter)
    {
        keyQuery_modifiedafter = strdup("modifiedafter");
        valueQuery_modifiedafter = (modifiedafter);
        keyPairQuery_modifiedafter = keyValuePair_create(keyQuery_modifiedafter, &valueQuery_modifiedafter);
        list_addElement(localVarQueryParameters,keyPairQuery_modifiedafter);
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

// Create or edit a schedule slot
//
// Allows the user to create or edit a schedule slot of another user.
//
void
ScheduleAPI_scheduleSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/save")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/save");




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

// Create or edit a block in current user's schedule
//
// Allows the user to create or edit a schedule shift in their own availability.
//
void
ScheduleAPI_scheduleSavemine(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/schedule/savemine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/schedule/savemine");




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

