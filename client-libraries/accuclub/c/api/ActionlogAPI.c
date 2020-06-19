#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ActionlogAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// View a list of users action logs
//
// Allows the user to view the audit logs for the account.
//
void
ActionlogAPI_actionlogList(apiClient_t *apiClient, int from , int count , char * user , char startdate , char enddate , char * resource , char * actionfilter , char * argument )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionlog/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionlog/list");




    // query parameters
    char *keyQuery_user = NULL;
    char * valueQuery_user ;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = (user);
        keyPairQuery_user = keyValuePair_create(keyQuery_user, &valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
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

    // query parameters
    char *keyQuery_resource = NULL;
    char * valueQuery_resource = NULL;
    keyValuePair_t *keyPairQuery_resource = 0;
    if (resource)
    {
        keyQuery_resource = strdup("resource");
        valueQuery_resource = strdup((resource));
        keyPairQuery_resource = keyValuePair_create(keyQuery_resource, valueQuery_resource);
        list_addElement(localVarQueryParameters,keyPairQuery_resource);
    }

    // query parameters
    char *keyQuery_actionfilter = NULL;
    char * valueQuery_actionfilter = NULL;
    keyValuePair_t *keyPairQuery_actionfilter = 0;
    if (actionfilter)
    {
        keyQuery_actionfilter = strdup("actionfilter");
        valueQuery_actionfilter = strdup((actionfilter));
        keyPairQuery_actionfilter = keyValuePair_create(keyQuery_actionfilter, valueQuery_actionfilter);
        list_addElement(localVarQueryParameters,keyPairQuery_actionfilter);
    }

    // query parameters
    char *keyQuery_argument = NULL;
    char * valueQuery_argument = NULL;
    keyValuePair_t *keyPairQuery_argument = 0;
    if (argument)
    {
        keyQuery_argument = strdup("argument");
        valueQuery_argument = strdup((argument));
        keyPairQuery_argument = keyValuePair_create(keyQuery_argument, valueQuery_argument);
        list_addElement(localVarQueryParameters,keyPairQuery_argument);
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
    if(keyQuery_resource){
        free(keyQuery_resource);
        keyQuery_resource = NULL;
    }
    if(valueQuery_resource){
        free(valueQuery_resource);
        valueQuery_resource = NULL;
    }
    if(keyPairQuery_resource){
        keyValuePair_free(keyPairQuery_resource);
        keyPairQuery_resource = NULL;
    }
    if(keyQuery_resource){
        free(keyQuery_resource);
        keyQuery_resource = NULL;
    }
    if(keyPairQuery_resource){
        keyValuePair_free(keyPairQuery_resource);
        keyPairQuery_resource = NULL;
    }
    if(keyQuery_actionfilter){
        free(keyQuery_actionfilter);
        keyQuery_actionfilter = NULL;
    }
    if(valueQuery_actionfilter){
        free(valueQuery_actionfilter);
        valueQuery_actionfilter = NULL;
    }
    if(keyPairQuery_actionfilter){
        keyValuePair_free(keyPairQuery_actionfilter);
        keyPairQuery_actionfilter = NULL;
    }
    if(keyQuery_actionfilter){
        free(keyQuery_actionfilter);
        keyQuery_actionfilter = NULL;
    }
    if(keyPairQuery_actionfilter){
        keyValuePair_free(keyPairQuery_actionfilter);
        keyPairQuery_actionfilter = NULL;
    }
    if(keyQuery_argument){
        free(keyQuery_argument);
        keyQuery_argument = NULL;
    }
    if(valueQuery_argument){
        free(valueQuery_argument);
        valueQuery_argument = NULL;
    }
    if(keyPairQuery_argument){
        keyValuePair_free(keyPairQuery_argument);
        keyPairQuery_argument = NULL;
    }
    if(keyQuery_argument){
        free(keyQuery_argument);
        keyQuery_argument = NULL;
    }
    if(keyPairQuery_argument){
        keyValuePair_free(keyPairQuery_argument);
        keyPairQuery_argument = NULL;
    }

}

