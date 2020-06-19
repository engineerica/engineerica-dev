#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "SessionattendancelogAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Add a note to a class attendance log
//
// Allows the user to add a note to a class attendance log.
//
void
SessionattendancelogAPI_sessionattendancelogAddnote(apiClient_t *apiClient, char * id , char * text )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/addnote")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/addnote");




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
    char *keyQuery_text = NULL;
    char * valueQuery_text = NULL;
    keyValuePair_t *keyPairQuery_text = 0;
    if (text)
    {
        keyQuery_text = strdup("text");
        valueQuery_text = strdup((text));
        keyPairQuery_text = keyValuePair_create(keyQuery_text, valueQuery_text);
        list_addElement(localVarQueryParameters,keyPairQuery_text);
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
    if(keyQuery_text){
        free(keyQuery_text);
        keyQuery_text = NULL;
    }
    if(valueQuery_text){
        free(valueQuery_text);
        valueQuery_text = NULL;
    }
    if(keyPairQuery_text){
        keyValuePair_free(keyPairQuery_text);
        keyPairQuery_text = NULL;
    }
    if(keyQuery_text){
        free(keyQuery_text);
        keyQuery_text = NULL;
    }
    if(keyPairQuery_text){
        keyValuePair_free(keyPairQuery_text);
        keyPairQuery_text = NULL;
    }

}

// View details of a class attendance log
//
// Allows the user to view an individual class attendance log and its details.
//
void
SessionattendancelogAPI_sessionattendancelogGet(apiClient_t *apiClient, char * id , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/{id}");


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

// View the class session attendance information for a specific user
//
// Allows the user to view the attendance for a specified student.
//
void
SessionattendancelogAPI_sessionattendancelogGetuser(apiClient_t *apiClient, char * attendee , char * eventid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/getuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/getuser");




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

// View attendance logs of the specified session
//
// Allows the user to view the full list of logs from a specified session
//
void
SessionattendancelogAPI_sessionattendancelogList(apiClient_t *apiClient, char * session , int from , int count , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/list");




    // query parameters
    char *keyQuery_session = NULL;
    char * valueQuery_session ;
    keyValuePair_t *keyPairQuery_session = 0;
    if (session)
    {
        keyQuery_session = strdup("session");
        valueQuery_session = (session);
        keyPairQuery_session = keyValuePair_create(keyQuery_session, &valueQuery_session);
        list_addElement(localVarQueryParameters,keyPairQuery_session);
    }

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

// View the attendance information of an entire class
//
// Allows the user to view the attendance information for an entire class
//
void
SessionattendancelogAPI_sessionattendancelogListevent(apiClient_t *apiClient, char * eventid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/listevent")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/listevent");




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

// View the attendance summary for a class and/or a attendee
//
// Allows the user to view the attendance summary for a given class and/or attendee.
//
void
SessionattendancelogAPI_sessionattendancelogListsummary(apiClient_t *apiClient, char * eventid , char * attendeeid , char * groupid , char * start , char * end )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/listsummary")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/listsummary");




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
    char *keyQuery_attendeeid = NULL;
    char * valueQuery_attendeeid ;
    keyValuePair_t *keyPairQuery_attendeeid = 0;
    if (attendeeid)
    {
        keyQuery_attendeeid = strdup("attendeeid");
        valueQuery_attendeeid = (attendeeid);
        keyPairQuery_attendeeid = keyValuePair_create(keyQuery_attendeeid, &valueQuery_attendeeid);
        list_addElement(localVarQueryParameters,keyPairQuery_attendeeid);
    }

    // query parameters
    char *keyQuery_groupid = NULL;
    char * valueQuery_groupid ;
    keyValuePair_t *keyPairQuery_groupid = 0;
    if (groupid)
    {
        keyQuery_groupid = strdup("groupid");
        valueQuery_groupid = (groupid);
        keyPairQuery_groupid = keyValuePair_create(keyQuery_groupid, &valueQuery_groupid);
        list_addElement(localVarQueryParameters,keyPairQuery_groupid);
    }

    // query parameters
    char *keyQuery_start = NULL;
    char * valueQuery_start = NULL;
    keyValuePair_t *keyPairQuery_start = 0;
    if (start)
    {
        keyQuery_start = strdup("start");
        valueQuery_start = strdup((start));
        keyPairQuery_start = keyValuePair_create(keyQuery_start, valueQuery_start);
        list_addElement(localVarQueryParameters,keyPairQuery_start);
    }

    // query parameters
    char *keyQuery_end = NULL;
    char * valueQuery_end = NULL;
    keyValuePair_t *keyPairQuery_end = 0;
    if (end)
    {
        keyQuery_end = strdup("end");
        valueQuery_end = strdup((end));
        keyPairQuery_end = keyValuePair_create(keyQuery_end, valueQuery_end);
        list_addElement(localVarQueryParameters,keyPairQuery_end);
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
    if(keyQuery_start){
        free(keyQuery_start);
        keyQuery_start = NULL;
    }
    if(valueQuery_start){
        free(valueQuery_start);
        valueQuery_start = NULL;
    }
    if(keyPairQuery_start){
        keyValuePair_free(keyPairQuery_start);
        keyPairQuery_start = NULL;
    }
    if(keyQuery_start){
        free(keyQuery_start);
        keyQuery_start = NULL;
    }
    if(keyPairQuery_start){
        keyValuePair_free(keyPairQuery_start);
        keyPairQuery_start = NULL;
    }
    if(keyQuery_end){
        free(keyQuery_end);
        keyQuery_end = NULL;
    }
    if(valueQuery_end){
        free(valueQuery_end);
        valueQuery_end = NULL;
    }
    if(keyPairQuery_end){
        keyValuePair_free(keyPairQuery_end);
        keyPairQuery_end = NULL;
    }
    if(keyQuery_end){
        free(keyQuery_end);
        keyQuery_end = NULL;
    }
    if(keyPairQuery_end){
        keyValuePair_free(keyPairQuery_end);
        keyPairQuery_end = NULL;
    }

}

// View my attendance summary
//
// Allows the user to view their own attendance summary.
//
void
SessionattendancelogAPI_sessionattendancelogMylistsummary(apiClient_t *apiClient, char * eventid , char * start , char * end )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/mylistsummary")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/mylistsummary");




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
    char *keyQuery_start = NULL;
    char * valueQuery_start = NULL;
    keyValuePair_t *keyPairQuery_start = 0;
    if (start)
    {
        keyQuery_start = strdup("start");
        valueQuery_start = strdup((start));
        keyPairQuery_start = keyValuePair_create(keyQuery_start, valueQuery_start);
        list_addElement(localVarQueryParameters,keyPairQuery_start);
    }

    // query parameters
    char *keyQuery_end = NULL;
    char * valueQuery_end = NULL;
    keyValuePair_t *keyPairQuery_end = 0;
    if (end)
    {
        keyQuery_end = strdup("end");
        valueQuery_end = strdup((end));
        keyPairQuery_end = keyValuePair_create(keyQuery_end, valueQuery_end);
        list_addElement(localVarQueryParameters,keyPairQuery_end);
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
    if(keyQuery_start){
        free(keyQuery_start);
        keyQuery_start = NULL;
    }
    if(valueQuery_start){
        free(valueQuery_start);
        valueQuery_start = NULL;
    }
    if(keyPairQuery_start){
        keyValuePair_free(keyPairQuery_start);
        keyPairQuery_start = NULL;
    }
    if(keyQuery_start){
        free(keyQuery_start);
        keyQuery_start = NULL;
    }
    if(keyPairQuery_start){
        keyValuePair_free(keyPairQuery_start);
        keyPairQuery_start = NULL;
    }
    if(keyQuery_end){
        free(keyQuery_end);
        keyQuery_end = NULL;
    }
    if(valueQuery_end){
        free(valueQuery_end);
        valueQuery_end = NULL;
    }
    if(keyPairQuery_end){
        keyValuePair_free(keyPairQuery_end);
        keyPairQuery_end = NULL;
    }
    if(keyQuery_end){
        free(keyQuery_end);
        keyQuery_end = NULL;
    }
    if(keyPairQuery_end){
        keyValuePair_free(keyPairQuery_end);
        keyPairQuery_end = NULL;
    }

}

// Create or edit a class attendance log
//
// Allows the user to create or edit a class attendance log.
//
void
SessionattendancelogAPI_sessionattendancelogSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/{id}");


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

// Create or edit a class attendance log swipe
//
// Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.
//
void
SessionattendancelogAPI_sessionattendancelogSaveswipe(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionattendancelog/saveswipe")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionattendancelog/saveswipe");




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

