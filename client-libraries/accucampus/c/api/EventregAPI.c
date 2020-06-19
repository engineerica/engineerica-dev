#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "EventregAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Register current user to a course
//
// Allows the user to make themselves available for individual courses.
//
void
EventregAPI_eventregAddme(apiClient_t *apiClient, char * eventid , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/addme")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/addme");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Register current user to all courses
//
// Allows the user to make themselves available for all courses.
//
void
EventregAPI_eventregAddmetoall(apiClient_t *apiClient, char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/addmetoall")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/addmetoall");




    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Register current user to a course group
//
// Allows the user to make themselves available for a course group.
//
void
EventregAPI_eventregAddmetogroup(apiClient_t *apiClient, char * codegroup , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/addmetogroup")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/addmetogroup");




    // query parameters
    char *keyQuery_codegroup = NULL;
    char * valueQuery_codegroup = NULL;
    keyValuePair_t *keyPairQuery_codegroup = 0;
    if (codegroup)
    {
        keyQuery_codegroup = strdup("codegroup");
        valueQuery_codegroup = strdup((codegroup));
        keyPairQuery_codegroup = keyValuePair_create(keyQuery_codegroup, valueQuery_codegroup);
        list_addElement(localVarQueryParameters,keyPairQuery_codegroup);
    }

    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_codegroup){
        free(keyQuery_codegroup);
        keyQuery_codegroup = NULL;
    }
    if(valueQuery_codegroup){
        free(valueQuery_codegroup);
        valueQuery_codegroup = NULL;
    }
    if(keyPairQuery_codegroup){
        keyValuePair_free(keyPairQuery_codegroup);
        keyPairQuery_codegroup = NULL;
    }
    if(keyQuery_codegroup){
        free(keyQuery_codegroup);
        keyQuery_codegroup = NULL;
    }
    if(keyPairQuery_codegroup){
        keyValuePair_free(keyPairQuery_codegroup);
        keyPairQuery_codegroup = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Register a user to a course for attendance
//
// Allows the user to register a user to a course.
//
void
EventregAPI_eventregAdduser(apiClient_t *apiClient, char * userid , char * eventid , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/adduser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/adduser");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Register a user to assist with all courses
//
// Allows the user to make a staff member available to assist with all courses.
//
void
EventregAPI_eventregAddusertoall(apiClient_t *apiClient, char * userid , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/addusertoall")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/addusertoall");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Register a user to an course group
//
// Allows the user to make a staff member available for a course group.
//
void
EventregAPI_eventregAddusertogroup(apiClient_t *apiClient, char * userid , char * codegroup , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/addusertogroup")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/addusertogroup");




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
    char *keyQuery_codegroup = NULL;
    char * valueQuery_codegroup = NULL;
    keyValuePair_t *keyPairQuery_codegroup = 0;
    if (codegroup)
    {
        keyQuery_codegroup = strdup("codegroup");
        valueQuery_codegroup = strdup((codegroup));
        keyPairQuery_codegroup = keyValuePair_create(keyQuery_codegroup, valueQuery_codegroup);
        list_addElement(localVarQueryParameters,keyPairQuery_codegroup);
    }

    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_codegroup){
        free(keyQuery_codegroup);
        keyQuery_codegroup = NULL;
    }
    if(valueQuery_codegroup){
        free(valueQuery_codegroup);
        valueQuery_codegroup = NULL;
    }
    if(keyPairQuery_codegroup){
        keyValuePair_free(keyPairQuery_codegroup);
        keyPairQuery_codegroup = NULL;
    }
    if(keyQuery_codegroup){
        free(keyQuery_codegroup);
        keyQuery_codegroup = NULL;
    }
    if(keyPairQuery_codegroup){
        keyValuePair_free(keyPairQuery_codegroup);
        keyPairQuery_codegroup = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// View course registration by user
//
// Allows the user to view all courses a given user is registered to, provided they have permission to view that user.
//
void
EventregAPI_eventregGetevents(apiClient_t *apiClient, char * userid , char * listname , char * termid , char * namefilter )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/getevents")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/getevents");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
    }

    // query parameters
    char *keyQuery_termid = NULL;
    char * valueQuery_termid ;
    keyValuePair_t *keyPairQuery_termid = 0;
    if (termid)
    {
        keyQuery_termid = strdup("termid");
        valueQuery_termid = (termid);
        keyPairQuery_termid = keyValuePair_create(keyQuery_termid, &valueQuery_termid);
        list_addElement(localVarQueryParameters,keyPairQuery_termid);
    }

    // query parameters
    char *keyQuery_namefilter = NULL;
    char * valueQuery_namefilter = NULL;
    keyValuePair_t *keyPairQuery_namefilter = 0;
    if (namefilter)
    {
        keyQuery_namefilter = strdup("namefilter");
        valueQuery_namefilter = strdup((namefilter));
        keyPairQuery_namefilter = keyValuePair_create(keyQuery_namefilter, valueQuery_namefilter);
        list_addElement(localVarQueryParameters,keyPairQuery_namefilter);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_namefilter){
        free(keyQuery_namefilter);
        keyQuery_namefilter = NULL;
    }
    if(valueQuery_namefilter){
        free(valueQuery_namefilter);
        valueQuery_namefilter = NULL;
    }
    if(keyPairQuery_namefilter){
        keyValuePair_free(keyPairQuery_namefilter);
        keyPairQuery_namefilter = NULL;
    }
    if(keyQuery_namefilter){
        free(keyQuery_namefilter);
        keyQuery_namefilter = NULL;
    }
    if(keyPairQuery_namefilter){
        keyValuePair_free(keyPairQuery_namefilter);
        keyPairQuery_namefilter = NULL;
    }

}

// Lists the course group registrations of a user
//
// Allows the user to view the course groups a staff member is available for.
//
void
EventregAPI_eventregGetgroups(apiClient_t *apiClient, char * userid , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/getgroups")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/getgroups");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// View the event registrations of the current user
//
void
EventregAPI_eventregGetmyevents(apiClient_t *apiClient, char * listname , char * termid , char * namefilter )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/getmyevents")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/getmyevents");




    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
    }

    // query parameters
    char *keyQuery_termid = NULL;
    char * valueQuery_termid ;
    keyValuePair_t *keyPairQuery_termid = 0;
    if (termid)
    {
        keyQuery_termid = strdup("termid");
        valueQuery_termid = (termid);
        keyPairQuery_termid = keyValuePair_create(keyQuery_termid, &valueQuery_termid);
        list_addElement(localVarQueryParameters,keyPairQuery_termid);
    }

    // query parameters
    char *keyQuery_namefilter = NULL;
    char * valueQuery_namefilter = NULL;
    keyValuePair_t *keyPairQuery_namefilter = 0;
    if (namefilter)
    {
        keyQuery_namefilter = strdup("namefilter");
        valueQuery_namefilter = strdup((namefilter));
        keyPairQuery_namefilter = keyValuePair_create(keyQuery_namefilter, valueQuery_namefilter);
        list_addElement(localVarQueryParameters,keyPairQuery_namefilter);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_namefilter){
        free(keyQuery_namefilter);
        keyQuery_namefilter = NULL;
    }
    if(valueQuery_namefilter){
        free(valueQuery_namefilter);
        valueQuery_namefilter = NULL;
    }
    if(keyPairQuery_namefilter){
        keyValuePair_free(keyPairQuery_namefilter);
        keyPairQuery_namefilter = NULL;
    }
    if(keyQuery_namefilter){
        free(keyQuery_namefilter);
        keyQuery_namefilter = NULL;
    }
    if(keyPairQuery_namefilter){
        keyValuePair_free(keyPairQuery_namefilter);
        keyPairQuery_namefilter = NULL;
    }

}

// View all current user registrations to course groups
//
// Allows the user to view all his registrations to course groups.
//
void
EventregAPI_eventregGetmygroups(apiClient_t *apiClient, char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/getmygroups")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/getmygroups");




    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// View course registration
//
// Allows the user to view all users registered for an individual course.
//
void
EventregAPI_eventregGetusers(apiClient_t *apiClient, char * eventid , char * listname , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/getusers")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/getusers");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Lists the registrations for a course group
//
// Allows the user the get the staff members registered to a specific course group
//
void
EventregAPI_eventregGetusersfromgroup(apiClient_t *apiClient, char * codegroup , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/getusersfromgroup")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/getusersfromgroup");




    // query parameters
    char *keyQuery_codegroup = NULL;
    char * valueQuery_codegroup ;
    keyValuePair_t *keyPairQuery_codegroup = 0;
    if (codegroup)
    {
        keyQuery_codegroup = strdup("codegroup");
        valueQuery_codegroup = (codegroup);
        keyPairQuery_codegroup = keyValuePair_create(keyQuery_codegroup, &valueQuery_codegroup);
        list_addElement(localVarQueryParameters,keyPairQuery_codegroup);
    }

    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// View the users that are registered to all courses
//
// Allows the user to view all staff members available for all courses.
//
void
EventregAPI_eventregGetuserstoall(apiClient_t *apiClient, char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/getuserstoall")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/getuserstoall");




    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Unregister current user from a course
//
// Allows the user to remove themselves from registration to a course.
//
void
EventregAPI_eventregRemoveme(apiClient_t *apiClient, char * eventid , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/removeme")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/removeme");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Remove current user from the registration to all courses
//
// Allows the user to remove themselves from availability to all courses.
//
void
EventregAPI_eventregRemovemefromall(apiClient_t *apiClient, char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/removemefromall")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/removemefromall");




    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Remove current user from a course group
//
// Allows the user to remove themselves from availability to a course group.
//
void
EventregAPI_eventregRemovemefromgroup(apiClient_t *apiClient, char * codegroup , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/removemefromgroup")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/removemefromgroup");




    // query parameters
    char *keyQuery_codegroup = NULL;
    char * valueQuery_codegroup ;
    keyValuePair_t *keyPairQuery_codegroup = 0;
    if (codegroup)
    {
        keyQuery_codegroup = strdup("codegroup");
        valueQuery_codegroup = (codegroup);
        keyPairQuery_codegroup = keyValuePair_create(keyQuery_codegroup, &valueQuery_codegroup);
        list_addElement(localVarQueryParameters,keyPairQuery_codegroup);
    }

    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Remove a user from a course
//
// Allows the user to remove a user from a course's registration.
//
void
EventregAPI_eventregRemoveuser(apiClient_t *apiClient, char * userid , char * eventid , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/removeuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/removeuser");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Remove a user from the registration to all courses
//
// Allows the user to remove a staff member from availability to all courses.
//
void
EventregAPI_eventregRemoveuserfromall(apiClient_t *apiClient, char * userid , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/removeuserfromall")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/removeuserfromall");




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
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

// Remove a user from a course group
//
// Allows the user to remove a staff member from availability to a course group.
//
void
EventregAPI_eventregRemoveuserfromgroup(apiClient_t *apiClient, char * userid , char * codegroup , char * listname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventreg/removeuserfromgroup")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventreg/removeuserfromgroup");




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
    char *keyQuery_codegroup = NULL;
    char * valueQuery_codegroup ;
    keyValuePair_t *keyPairQuery_codegroup = 0;
    if (codegroup)
    {
        keyQuery_codegroup = strdup("codegroup");
        valueQuery_codegroup = (codegroup);
        keyPairQuery_codegroup = keyValuePair_create(keyQuery_codegroup, &valueQuery_codegroup);
        list_addElement(localVarQueryParameters,keyPairQuery_codegroup);
    }

    // query parameters
    char *keyQuery_listname = NULL;
    char * valueQuery_listname = NULL;
    keyValuePair_t *keyPairQuery_listname = 0;
    if (listname)
    {
        keyQuery_listname = strdup("listname");
        valueQuery_listname = strdup((listname));
        keyPairQuery_listname = keyValuePair_create(keyQuery_listname, valueQuery_listname);
        list_addElement(localVarQueryParameters,keyPairQuery_listname);
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
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(valueQuery_listname){
        free(valueQuery_listname);
        valueQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }
    if(keyQuery_listname){
        free(keyQuery_listname);
        keyQuery_listname = NULL;
    }
    if(keyPairQuery_listname){
        keyValuePair_free(keyPairQuery_listname);
        keyPairQuery_listname = NULL;
    }

}

