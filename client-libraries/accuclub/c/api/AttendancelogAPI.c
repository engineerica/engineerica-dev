#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "AttendancelogAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Delete an attendance log
//
// Allows the user to delete an existing attendance log.
//
void
AttendancelogAPI_attendancelogDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/{id}");


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

// Search and view details of an attendance log
//
// Allows the user to view an individual attendance log and its details.
//
void
AttendancelogAPI_attendancelogGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/{id}");


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

// Search and view details of an attendance log's swipe history
//
// Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
//
void
AttendancelogAPI_attendancelogGetchangehistory(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/getchangehistory")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/getchangehistory");




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

// View a list of attendance logs
//
// Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
//
void
AttendancelogAPI_attendancelogList(apiClient_t *apiClient, int from , int count , char * filter , char * userid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/list");




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
    char *keyQuery_filter = NULL;
    char * valueQuery_filter = NULL;
    keyValuePair_t *keyPairQuery_filter = 0;
    if (filter)
    {
        keyQuery_filter = strdup("filter");
        valueQuery_filter = strdup((filter));
        keyPairQuery_filter = keyValuePair_create(keyQuery_filter, valueQuery_filter);
        list_addElement(localVarQueryParameters,keyPairQuery_filter);
    }

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
    if(keyQuery_filter){
        free(keyQuery_filter);
        keyQuery_filter = NULL;
    }
    if(valueQuery_filter){
        free(valueQuery_filter);
        valueQuery_filter = NULL;
    }
    if(keyPairQuery_filter){
        keyValuePair_free(keyPairQuery_filter);
        keyPairQuery_filter = NULL;
    }
    if(keyQuery_filter){
        free(keyQuery_filter);
        keyQuery_filter = NULL;
    }
    if(keyPairQuery_filter){
        keyValuePair_free(keyPairQuery_filter);
        keyPairQuery_filter = NULL;
    }

}

// Gets the attendance logs of the current user
//
void
AttendancelogAPI_attendancelogListmine(apiClient_t *apiClient, int from , int count , char * filter )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/listmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/listmine");




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
    char *keyQuery_filter = NULL;
    char * valueQuery_filter = NULL;
    keyValuePair_t *keyPairQuery_filter = 0;
    if (filter)
    {
        keyQuery_filter = strdup("filter");
        valueQuery_filter = strdup((filter));
        keyPairQuery_filter = keyValuePair_create(keyQuery_filter, valueQuery_filter);
        list_addElement(localVarQueryParameters,keyPairQuery_filter);
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
    if(keyQuery_filter){
        free(keyQuery_filter);
        keyQuery_filter = NULL;
    }
    if(valueQuery_filter){
        free(valueQuery_filter);
        valueQuery_filter = NULL;
    }
    if(keyPairQuery_filter){
        keyValuePair_free(keyPairQuery_filter);
        keyPairQuery_filter = NULL;
    }
    if(keyQuery_filter){
        free(keyQuery_filter);
        keyQuery_filter = NULL;
    }
    if(keyPairQuery_filter){
        keyValuePair_free(keyPairQuery_filter);
        keyPairQuery_filter = NULL;
    }

}

// Create or edit an attendance log
//
// Allows the user to create or edit an attendance log.
//
void
AttendancelogAPI_attendancelogSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/{id}");


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

// Sign out an attendance log
//
// Allows the user to sign out am attendance log from the Who's In page.
//
void
AttendancelogAPI_attendancelogSignout(apiClient_t *apiClient, char * id , char * location , char * event , char datetime )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/signout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/signout");




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
    char *keyQuery_event = NULL;
    char * valueQuery_event ;
    keyValuePair_t *keyPairQuery_event = 0;
    if (event)
    {
        keyQuery_event = strdup("event");
        valueQuery_event = (event);
        keyPairQuery_event = keyValuePair_create(keyQuery_event, &valueQuery_event);
        list_addElement(localVarQueryParameters,keyPairQuery_event);
    }

    // query parameters
    char *keyQuery_datetime = NULL;
    char valueQuery_datetime ;
    keyValuePair_t *keyPairQuery_datetime = 0;
    if (datetime)
    {
        keyQuery_datetime = strdup("datetime");
        valueQuery_datetime = (datetime);
        keyPairQuery_datetime = keyValuePair_create(keyQuery_datetime, &valueQuery_datetime);
        list_addElement(localVarQueryParameters,keyPairQuery_datetime);
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

// View who's in a location
//
// Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.
//
void
AttendancelogAPI_attendancelogWhosin(apiClient_t *apiClient, int from , int count , char * location , char * event , char * sorting , char * roles , int photosize , char * extensions , int export )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelog/whosin")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelog/whosin");




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
    char *keyQuery_event = NULL;
    char * valueQuery_event ;
    keyValuePair_t *keyPairQuery_event = 0;
    if (event)
    {
        keyQuery_event = strdup("event");
        valueQuery_event = (event);
        keyPairQuery_event = keyValuePair_create(keyQuery_event, &valueQuery_event);
        list_addElement(localVarQueryParameters,keyPairQuery_event);
    }

    // query parameters
    char *keyQuery_sorting = NULL;
    char * valueQuery_sorting = NULL;
    keyValuePair_t *keyPairQuery_sorting = 0;
    if (sorting)
    {
        keyQuery_sorting = strdup("sorting");
        valueQuery_sorting = strdup((sorting));
        keyPairQuery_sorting = keyValuePair_create(keyQuery_sorting, valueQuery_sorting);
        list_addElement(localVarQueryParameters,keyPairQuery_sorting);
    }

    // query parameters
    char *keyQuery_roles = NULL;
    char * valueQuery_roles = NULL;
    keyValuePair_t *keyPairQuery_roles = 0;
    if (roles)
    {
        keyQuery_roles = strdup("roles");
        valueQuery_roles = strdup((roles));
        keyPairQuery_roles = keyValuePair_create(keyQuery_roles, valueQuery_roles);
        list_addElement(localVarQueryParameters,keyPairQuery_roles);
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
    char *keyQuery_extensions = NULL;
    char * valueQuery_extensions = NULL;
    keyValuePair_t *keyPairQuery_extensions = 0;
    if (extensions)
    {
        keyQuery_extensions = strdup("extensions");
        valueQuery_extensions = strdup((extensions));
        keyPairQuery_extensions = keyValuePair_create(keyQuery_extensions, valueQuery_extensions);
        list_addElement(localVarQueryParameters,keyPairQuery_extensions);
    }

    // query parameters
    char *keyQuery_export = NULL;
    int valueQuery_export ;
    keyValuePair_t *keyPairQuery_export = 0;
    if (export)
    {
        keyQuery_export = strdup("export");
        valueQuery_export = (export);
        keyPairQuery_export = keyValuePair_create(keyQuery_export, &valueQuery_export);
        list_addElement(localVarQueryParameters,keyPairQuery_export);
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
    if(keyQuery_sorting){
        free(keyQuery_sorting);
        keyQuery_sorting = NULL;
    }
    if(valueQuery_sorting){
        free(valueQuery_sorting);
        valueQuery_sorting = NULL;
    }
    if(keyPairQuery_sorting){
        keyValuePair_free(keyPairQuery_sorting);
        keyPairQuery_sorting = NULL;
    }
    if(keyQuery_sorting){
        free(keyQuery_sorting);
        keyQuery_sorting = NULL;
    }
    if(keyPairQuery_sorting){
        keyValuePair_free(keyPairQuery_sorting);
        keyPairQuery_sorting = NULL;
    }
    if(keyQuery_roles){
        free(keyQuery_roles);
        keyQuery_roles = NULL;
    }
    if(valueQuery_roles){
        free(valueQuery_roles);
        valueQuery_roles = NULL;
    }
    if(keyPairQuery_roles){
        keyValuePair_free(keyPairQuery_roles);
        keyPairQuery_roles = NULL;
    }
    if(keyQuery_roles){
        free(keyQuery_roles);
        keyQuery_roles = NULL;
    }
    if(keyPairQuery_roles){
        keyValuePair_free(keyPairQuery_roles);
        keyPairQuery_roles = NULL;
    }
    if(keyQuery_extensions){
        free(keyQuery_extensions);
        keyQuery_extensions = NULL;
    }
    if(valueQuery_extensions){
        free(valueQuery_extensions);
        valueQuery_extensions = NULL;
    }
    if(keyPairQuery_extensions){
        keyValuePair_free(keyPairQuery_extensions);
        keyPairQuery_extensions = NULL;
    }
    if(keyQuery_extensions){
        free(keyQuery_extensions);
        keyQuery_extensions = NULL;
    }
    if(keyPairQuery_extensions){
        keyValuePair_free(keyPairQuery_extensions);
        keyPairQuery_extensions = NULL;
    }

}

