#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "SessionAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Bulk update event sessions
//
// Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
//
void
SessionAPI_sessionBulkupdate(apiClient_t *apiClient, char * eventid , char * sessions )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/session/bulkupdate")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/session/bulkupdate");




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
    char *keyQuery_sessions = NULL;
    char * valueQuery_sessions = NULL;
    keyValuePair_t *keyPairQuery_sessions = 0;
    if (sessions)
    {
        keyQuery_sessions = strdup("sessions");
        valueQuery_sessions = strdup((sessions));
        keyPairQuery_sessions = keyValuePair_create(keyQuery_sessions, valueQuery_sessions);
        list_addElement(localVarQueryParameters,keyPairQuery_sessions);
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
    if(keyQuery_sessions){
        free(keyQuery_sessions);
        keyQuery_sessions = NULL;
    }
    if(valueQuery_sessions){
        free(valueQuery_sessions);
        valueQuery_sessions = NULL;
    }
    if(keyPairQuery_sessions){
        keyValuePair_free(keyPairQuery_sessions);
        keyPairQuery_sessions = NULL;
    }
    if(keyQuery_sessions){
        free(keyQuery_sessions);
        keyQuery_sessions = NULL;
    }
    if(keyPairQuery_sessions){
        keyValuePair_free(keyPairQuery_sessions);
        keyPairQuery_sessions = NULL;
    }

}

// View details of a session
//
// Allows the user to view a session in order to take attendance.
//
void
SessionAPI_sessionGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/session/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/session/{id}");


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

// Gets the schedule for a location, instructor or attendees
//
void
SessionAPI_sessionGetschedule(apiClient_t *apiClient, char day , char * attendee , char * location , char * instructor )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/session/getschedule")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/session/getschedule");




    // query parameters
    char *keyQuery_day = NULL;
    char valueQuery_day ;
    keyValuePair_t *keyPairQuery_day = 0;
    if (day)
    {
        keyQuery_day = strdup("day");
        valueQuery_day = (day);
        keyPairQuery_day = keyValuePair_create(keyQuery_day, &valueQuery_day);
        list_addElement(localVarQueryParameters,keyPairQuery_day);
    }

    // query parameters
    char *keyQuery_attendee = NULL;
    char * valueQuery_attendee ;
    keyValuePair_t *keyPairQuery_attendee = 0;
    if (attendee)
    {
        keyQuery_attendee = strdup("attendee");
        valueQuery_attendee = (attendee);
        keyPairQuery_attendee = keyValuePair_create(keyQuery_attendee, &valueQuery_attendee);
        list_addElement(localVarQueryParameters,keyPairQuery_attendee);
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

    // query parameters
    char *keyQuery_instructor = NULL;
    char * valueQuery_instructor ;
    keyValuePair_t *keyPairQuery_instructor = 0;
    if (instructor)
    {
        keyQuery_instructor = strdup("instructor");
        valueQuery_instructor = (instructor);
        keyPairQuery_instructor = keyValuePair_create(keyQuery_instructor, &valueQuery_instructor);
        list_addElement(localVarQueryParameters,keyPairQuery_instructor);
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

// Gets all future sessions of the current semester
//
void
SessionAPI_sessionList(apiClient_t *apiClient, int from , int count , char startdate , char enddate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/session/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/session/list");




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
    char *keyQuery_enddate = NULL;
    char valueQuery_enddate ;
    keyValuePair_t *keyPairQuery_enddate = 0;
    if (enddate)
    {
        keyQuery_enddate = strdup("enddate");
        valueQuery_enddate = (enddate);
        keyPairQuery_enddate = keyValuePair_create(keyQuery_enddate, &valueQuery_enddate);
        list_addElement(localVarQueryParameters,keyPairQuery_enddate);
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

