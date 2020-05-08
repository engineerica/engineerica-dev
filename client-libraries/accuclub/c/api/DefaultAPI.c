#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "DefaultAPI.h"


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
DefaultAPI_actionloglist(apiClient_t *apiClient, char * token , int from , int count , char * user , char startdate , char enddate , char * resource , char * actionfilter , char * argument )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/actionloglist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/actionloglist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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

// Adds the missing permissions to a role. Requires access to advrole.save
//
void
DefaultAPI_advroleaddmissing(apiClient_t *apiClient, char * token , char * roles , char * permissions )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advroleaddmissing")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advroleaddmissing");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_permissions = NULL;
    char * valueQuery_permissions = NULL;
    keyValuePair_t *keyPairQuery_permissions = 0;
    if (permissions)
    {
        keyQuery_permissions = strdup("permissions");
        valueQuery_permissions = strdup((permissions));
        keyPairQuery_permissions = keyValuePair_create(keyQuery_permissions, valueQuery_permissions);
        list_addElement(localVarQueryParameters,keyPairQuery_permissions);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
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
    if(keyQuery_permissions){
        free(keyQuery_permissions);
        keyQuery_permissions = NULL;
    }
    if(valueQuery_permissions){
        free(valueQuery_permissions);
        valueQuery_permissions = NULL;
    }
    if(keyPairQuery_permissions){
        keyValuePair_free(keyPairQuery_permissions);
        keyPairQuery_permissions = NULL;
    }
    if(keyQuery_permissions){
        free(keyQuery_permissions);
        keyQuery_permissions = NULL;
    }
    if(keyPairQuery_permissions){
        keyValuePair_free(keyPairQuery_permissions);
        keyPairQuery_permissions = NULL;
    }

}

// Checks the permissions are assigned for the given roles
//
void
DefaultAPI_advrolecheckperm(apiClient_t *apiClient, char * token , char * roles , char * permissions )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolecheckperm")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolecheckperm");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_permissions = NULL;
    char * valueQuery_permissions = NULL;
    keyValuePair_t *keyPairQuery_permissions = 0;
    if (permissions)
    {
        keyQuery_permissions = strdup("permissions");
        valueQuery_permissions = strdup((permissions));
        keyPairQuery_permissions = keyValuePair_create(keyQuery_permissions, valueQuery_permissions);
        list_addElement(localVarQueryParameters,keyPairQuery_permissions);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
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
    if(keyQuery_permissions){
        free(keyQuery_permissions);
        keyQuery_permissions = NULL;
    }
    if(valueQuery_permissions){
        free(valueQuery_permissions);
        valueQuery_permissions = NULL;
    }
    if(keyPairQuery_permissions){
        keyValuePair_free(keyPairQuery_permissions);
        keyPairQuery_permissions = NULL;
    }
    if(keyQuery_permissions){
        free(keyQuery_permissions);
        keyQuery_permissions = NULL;
    }
    if(keyPairQuery_permissions){
        keyValuePair_free(keyPairQuery_permissions);
        keyPairQuery_permissions = NULL;
    }

}

// Delete a role
//
// Allows the user to delete a role from the list of available roles.
//
void
DefaultAPI_advroledelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advroledelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advroledelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Delete a role mapping
//
// Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.
//
void
DefaultAPI_advroledeletemapping(apiClient_t *apiClient, char * token , char * map , char * roleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advroledeletemapping")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advroledeletemapping");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_map = NULL;
    char * valueQuery_map = NULL;
    keyValuePair_t *keyPairQuery_map = 0;
    if (map)
    {
        keyQuery_map = strdup("map");
        valueQuery_map = strdup((map));
        keyPairQuery_map = keyValuePair_create(keyQuery_map, valueQuery_map);
        list_addElement(localVarQueryParameters,keyPairQuery_map);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_map){
        free(keyQuery_map);
        keyQuery_map = NULL;
    }
    if(valueQuery_map){
        free(valueQuery_map);
        valueQuery_map = NULL;
    }
    if(keyPairQuery_map){
        keyValuePair_free(keyPairQuery_map);
        keyPairQuery_map = NULL;
    }
    if(keyQuery_map){
        free(keyQuery_map);
        keyQuery_map = NULL;
    }
    if(keyPairQuery_map){
        keyValuePair_free(keyPairQuery_map);
        keyPairQuery_map = NULL;
    }

}

// View details of a role
//
// Allows the user to view a role and its details.
//
void
DefaultAPI_advroleget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advroleget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advroleget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Lists the roles for the current account
//
void
DefaultAPI_advrolelist(apiClient_t *apiClient, char * token , int includepolicies , int includeinternal , char * name )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolelist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolelist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_includepolicies = NULL;
    int valueQuery_includepolicies ;
    keyValuePair_t *keyPairQuery_includepolicies = 0;
    if (includepolicies)
    {
        keyQuery_includepolicies = strdup("includepolicies");
        valueQuery_includepolicies = (includepolicies);
        keyPairQuery_includepolicies = keyValuePair_create(keyQuery_includepolicies, &valueQuery_includepolicies);
        list_addElement(localVarQueryParameters,keyPairQuery_includepolicies);
    }

    // query parameters
    char *keyQuery_includeinternal = NULL;
    int valueQuery_includeinternal ;
    keyValuePair_t *keyPairQuery_includeinternal = 0;
    if (includeinternal)
    {
        keyQuery_includeinternal = strdup("includeinternal");
        valueQuery_includeinternal = (includeinternal);
        keyPairQuery_includeinternal = keyValuePair_create(keyQuery_includeinternal, &valueQuery_includeinternal);
        list_addElement(localVarQueryParameters,keyPairQuery_includeinternal);
    }

    // query parameters
    char *keyQuery_name = NULL;
    char * valueQuery_name = NULL;
    keyValuePair_t *keyPairQuery_name = 0;
    if (name)
    {
        keyQuery_name = strdup("name");
        valueQuery_name = strdup((name));
        keyPairQuery_name = keyValuePair_create(keyQuery_name, valueQuery_name);
        list_addElement(localVarQueryParameters,keyPairQuery_name);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_name){
        free(keyQuery_name);
        keyQuery_name = NULL;
    }
    if(valueQuery_name){
        free(valueQuery_name);
        valueQuery_name = NULL;
    }
    if(keyPairQuery_name){
        keyValuePair_free(keyPairQuery_name);
        keyPairQuery_name = NULL;
    }
    if(keyQuery_name){
        free(keyQuery_name);
        keyQuery_name = NULL;
    }
    if(keyPairQuery_name){
        keyValuePair_free(keyPairQuery_name);
        keyPairQuery_name = NULL;
    }

}

// Lists the maps a roles is mapped to
//
void
DefaultAPI_advrolelistmaps(apiClient_t *apiClient, char * token , char * roleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolelistmaps")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolelistmaps");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Lists the roles mappings
//
void
DefaultAPI_advrolelistrolesmapped(apiClient_t *apiClient, char * token , char * map )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolelistrolesmapped")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolelistrolesmapped");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_map = NULL;
    char * valueQuery_map = NULL;
    keyValuePair_t *keyPairQuery_map = 0;
    if (map)
    {
        keyQuery_map = strdup("map");
        valueQuery_map = strdup((map));
        keyPairQuery_map = keyValuePair_create(keyQuery_map, valueQuery_map);
        list_addElement(localVarQueryParameters,keyPairQuery_map);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_map){
        free(keyQuery_map);
        keyQuery_map = NULL;
    }
    if(valueQuery_map){
        free(valueQuery_map);
        valueQuery_map = NULL;
    }
    if(keyPairQuery_map){
        keyValuePair_free(keyPairQuery_map);
        keyPairQuery_map = NULL;
    }
    if(keyQuery_map){
        free(keyQuery_map);
        keyQuery_map = NULL;
    }
    if(keyPairQuery_map){
        keyValuePair_free(keyPairQuery_map);
        keyPairQuery_map = NULL;
    }

}

// View a list of role templates
//
// Allows the user to view the full list of available role templates.
//
void
DefaultAPI_advrolelisttemplates(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolelisttemplates")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolelisttemplates");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a role
//
// Allows the user to create or edit a role's permissions.
//
void
DefaultAPI_advrolesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolesave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolesave");




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

// Saves a role mapping
//
// Allows the user to add a role to a mapped category on the 'Role Mapping' page.
//
void
DefaultAPI_advrolesavemapping(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolesavemapping")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolesavemapping");




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

// List users. Alias to user.list, use that one instead.
//
void
DefaultAPI_advrolesuserlist(apiClient_t *apiClient, char * token , int from , int count , char * roleid , char * onlywithoutcard , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrolesuserlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrolesuserlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_onlywithoutcard = NULL;
    char * valueQuery_onlywithoutcard = NULL;
    keyValuePair_t *keyPairQuery_onlywithoutcard = 0;
    if (onlywithoutcard)
    {
        keyQuery_onlywithoutcard = strdup("onlywithoutcard");
        valueQuery_onlywithoutcard = strdup((onlywithoutcard));
        keyPairQuery_onlywithoutcard = keyValuePair_create(keyQuery_onlywithoutcard, valueQuery_onlywithoutcard);
        list_addElement(localVarQueryParameters,keyPairQuery_onlywithoutcard);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_onlywithoutcard){
        free(keyQuery_onlywithoutcard);
        keyQuery_onlywithoutcard = NULL;
    }
    if(valueQuery_onlywithoutcard){
        free(valueQuery_onlywithoutcard);
        valueQuery_onlywithoutcard = NULL;
    }
    if(keyPairQuery_onlywithoutcard){
        keyValuePair_free(keyPairQuery_onlywithoutcard);
        keyPairQuery_onlywithoutcard = NULL;
    }
    if(keyQuery_onlywithoutcard){
        free(keyQuery_onlywithoutcard);
        keyQuery_onlywithoutcard = NULL;
    }
    if(keyPairQuery_onlywithoutcard){
        keyValuePair_free(keyPairQuery_onlywithoutcard);
        keyPairQuery_onlywithoutcard = NULL;
    }

}

// Upgrade a user to another role (requires permission to edit those roles)
//
// Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
//
void
DefaultAPI_advroleuserupgrade(apiClient_t *apiClient, char * token , char * userid , char * roleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advroleuserupgrade")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advroleuserupgrade");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the phone number of the current user
//
void
DefaultAPI_appsharegetphone(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appsharegetphone")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appsharegetphone");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Sends an SMS with the link to the app
//
void
DefaultAPI_appsharesendtext(apiClient_t *apiClient, char * token , char * phonenumber )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appsharesendtext")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appsharesendtext");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_phonenumber = NULL;
    char * valueQuery_phonenumber = NULL;
    keyValuePair_t *keyPairQuery_phonenumber = 0;
    if (phonenumber)
    {
        keyQuery_phonenumber = strdup("phonenumber");
        valueQuery_phonenumber = strdup((phonenumber));
        keyPairQuery_phonenumber = keyValuePair_create(keyQuery_phonenumber, valueQuery_phonenumber);
        list_addElement(localVarQueryParameters,keyPairQuery_phonenumber);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(valueQuery_phonenumber){
        free(valueQuery_phonenumber);
        valueQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }

}

// Delete a comment on an attendance log
//
void
DefaultAPI_attendancelogcommentdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogcommentdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogcommentdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a comment on an attendance log
//
void
DefaultAPI_attendancelogcommentget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogcommentget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogcommentget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View all the comments on a specific attendance log
//
void
DefaultAPI_attendancelogcommentlist(apiClient_t *apiClient, char * attendancelog , char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogcommentlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogcommentlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_attendancelog = NULL;
    char * valueQuery_attendancelog ;
    keyValuePair_t *keyPairQuery_attendancelog = 0;
    if (attendancelog)
    {
        keyQuery_attendancelog = strdup("attendancelog");
        valueQuery_attendancelog = (attendancelog);
        keyPairQuery_attendancelog = keyValuePair_create(keyQuery_attendancelog, &valueQuery_attendancelog);
        list_addElement(localVarQueryParameters,keyPairQuery_attendancelog);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Save a comment on an attendance log
//
void
DefaultAPI_attendancelogcommentsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogcommentsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogcommentsave");




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

// Delete an attendance log
//
// Allows the user to delete an existing attendance log.
//
void
DefaultAPI_attendancelogdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of an attendance log
//
// Allows the user to view an individual attendance log and its details.
//
void
DefaultAPI_attendancelogget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of an attendance log's swipe history
//
// Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
//
void
DefaultAPI_attendanceloggetchangehistory(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendanceloggetchangehistory")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendanceloggetchangehistory");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of attendance logs
//
// Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
//
void
DefaultAPI_attendanceloglist(apiClient_t *apiClient, int from , int count , char * token , char * filter , char * userid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendanceloglist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendanceloglist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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
DefaultAPI_attendanceloglistmine(apiClient_t *apiClient, int from , int count , char * token , char * filter )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendanceloglistmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendanceloglistmine");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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
DefaultAPI_attendancelogsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogsave");




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

// Sign out an attendance log
//
// Allows the user to sign out am attendance log from the Who's In page.
//
void
DefaultAPI_attendancelogsignout(apiClient_t *apiClient, char * token , char * id , char * location , char * event , char datetime )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogsignout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogsignout");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View who's in a location
//
// Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.
//
void
DefaultAPI_attendancelogwhosin(apiClient_t *apiClient, int from , int count , char * token , char * location , char * event , char * sorting , char * roles , int photosize , char * extensions , int export )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/attendancelogwhosin")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/attendancelogwhosin");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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

// Get background job status
//
void
DefaultAPI_bgjobgetstatus(apiClient_t *apiClient, char * token , char * jobid , char * jobtype )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/bgjobgetstatus")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/bgjobgetstatus");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_jobid = NULL;
    char * valueQuery_jobid ;
    keyValuePair_t *keyPairQuery_jobid = 0;
    if (jobid)
    {
        keyQuery_jobid = strdup("jobid");
        valueQuery_jobid = (jobid);
        keyPairQuery_jobid = keyValuePair_create(keyQuery_jobid, &valueQuery_jobid);
        list_addElement(localVarQueryParameters,keyPairQuery_jobid);
    }

    // query parameters
    char *keyQuery_jobtype = NULL;
    char * valueQuery_jobtype = NULL;
    keyValuePair_t *keyPairQuery_jobtype = 0;
    if (jobtype)
    {
        keyQuery_jobtype = strdup("jobtype");
        valueQuery_jobtype = strdup((jobtype));
        keyPairQuery_jobtype = keyValuePair_create(keyQuery_jobtype, valueQuery_jobtype);
        list_addElement(localVarQueryParameters,keyPairQuery_jobtype);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_jobtype){
        free(keyQuery_jobtype);
        keyQuery_jobtype = NULL;
    }
    if(valueQuery_jobtype){
        free(valueQuery_jobtype);
        valueQuery_jobtype = NULL;
    }
    if(keyPairQuery_jobtype){
        keyValuePair_free(keyPairQuery_jobtype);
        keyPairQuery_jobtype = NULL;
    }
    if(keyQuery_jobtype){
        free(keyQuery_jobtype);
        keyQuery_jobtype = NULL;
    }
    if(keyPairQuery_jobtype){
        keyValuePair_free(keyPairQuery_jobtype);
        keyPairQuery_jobtype = NULL;
    }

}

// Gets a captcha challenge that the user must complete to do certain requests.
//
void
DefaultAPI_captchagetchallenge(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/captchagetchallenge")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/captchagetchallenge");



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

// Gets a captcha image that the user must complete to do certain requests.
//
void
DefaultAPI_captchagetimage(apiClient_t *apiClient, char * captchatoken )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/captchagetimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/captchagetimage");




    // query parameters
    char *keyQuery_captchatoken = NULL;
    char * valueQuery_captchatoken = NULL;
    keyValuePair_t *keyPairQuery_captchatoken = 0;
    if (captchatoken)
    {
        keyQuery_captchatoken = strdup("captchatoken");
        valueQuery_captchatoken = strdup((captchatoken));
        keyPairQuery_captchatoken = keyValuePair_create(keyQuery_captchatoken, valueQuery_captchatoken);
        list_addElement(localVarQueryParameters,keyPairQuery_captchatoken);
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
    if(keyQuery_captchatoken){
        free(keyQuery_captchatoken);
        keyQuery_captchatoken = NULL;
    }
    if(valueQuery_captchatoken){
        free(valueQuery_captchatoken);
        valueQuery_captchatoken = NULL;
    }
    if(keyPairQuery_captchatoken){
        keyValuePair_free(keyPairQuery_captchatoken);
        keyPairQuery_captchatoken = NULL;
    }
    if(keyQuery_captchatoken){
        free(keyQuery_captchatoken);
        keyQuery_captchatoken = NULL;
    }
    if(keyPairQuery_captchatoken){
        keyValuePair_free(keyPairQuery_captchatoken);
        keyPairQuery_captchatoken = NULL;
    }

}

// Get the application change log
//
void
DefaultAPI_changelog(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/changelog")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/changelog");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Get client
//
void
DefaultAPI_clientget(apiClient_t *apiClient, char * token , char * client , char * clientname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/clientget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/clientget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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
DefaultAPI_clientlist(apiClient_t *apiClient, char * token , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/clientlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/clientlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Saves a client
//
void
DefaultAPI_clientsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/clientsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/clientsave");




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
DefaultAPI_clientsendmessage(apiClient_t *apiClient, char * token , char * uniqueclientid , char * message )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/clientsendmessage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/clientsendmessage");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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

// Delete a credit
//
// Allows the user to delete credits.
//
void
DefaultAPI_creditdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the valid discount methods.
//
void
DefaultAPI_creditdiscountmethods(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditdiscountmethods")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditdiscountmethods");



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

// View details of assigned credit
//
// Allows the user to view an credit and its details.
//
void
DefaultAPI_creditget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Get the total amount of credits of the specified user
//
// Allows the user to view the total amount of credits of a specified user.
//
void
DefaultAPI_creditgetuserbalance(apiClient_t *apiClient, char * token , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditgetuserbalance")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditgetuserbalance");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of credits for a specific user
//
// Allows the user to view the full list of credits for a user.
//
void
DefaultAPI_creditlist(apiClient_t *apiClient, char * token , char * user , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the credit usage details
//
void
DefaultAPI_creditlistdetails(apiClient_t *apiClient, char * token , char * credit , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditlistdetails")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditlistdetails");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_credit = NULL;
    char * valueQuery_credit ;
    keyValuePair_t *keyPairQuery_credit = 0;
    if (credit)
    {
        keyQuery_credit = strdup("credit");
        valueQuery_credit = (credit);
        keyPairQuery_credit = keyValuePair_create(keyQuery_credit, &valueQuery_credit);
        list_addElement(localVarQueryParameters,keyPairQuery_credit);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View the list of credits of the current user
//
// Allows the current user to view his full list of credits.
//
void
DefaultAPI_creditlistmine(apiClient_t *apiClient, char * token , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditlistmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditlistmine");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Deletes a credit plan
//
void
DefaultAPI_creditplandelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditplandelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditplandelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets a credit plan
//
void
DefaultAPI_creditplanget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditplanget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditplanget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the credit plans available
//
void
DefaultAPI_creditplanlist(apiClient_t *apiClient, char * token , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditplanlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditplanlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Saves a credit plan
//
void
DefaultAPI_creditplansave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditplansave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditplansave");




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

// Create or edit credit for a user
//
// Allows the user to create or edit credit for a user
//
void
DefaultAPI_creditsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditsave");




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

// Create or edit credit details
//
void
DefaultAPI_creditsavedetails(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/creditsavedetails")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/creditsavedetails");




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

// Get the documentation
//
// Retrieves the list of actions available in the system.
//
void
DefaultAPI_doc(apiClient_t *apiClient, int excludeanonymous )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/doc")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/doc");




    // query parameters
    char *keyQuery_excludeanonymous = NULL;
    int valueQuery_excludeanonymous ;
    keyValuePair_t *keyPairQuery_excludeanonymous = 0;
    if (excludeanonymous)
    {
        keyQuery_excludeanonymous = strdup("excludeanonymous");
        valueQuery_excludeanonymous = (excludeanonymous);
        keyPairQuery_excludeanonymous = keyValuePair_create(keyQuery_excludeanonymous, &valueQuery_excludeanonymous);
        list_addElement(localVarQueryParameters,keyPairQuery_excludeanonymous);
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

// Adds background image for the login
//
// Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.
//
void
DefaultAPI_easyloginaddbgimage(apiClient_t *apiClient, char * token , char * upload , char * filename )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/easyloginaddbgimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/easyloginaddbgimage");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_upload = NULL;
    char * valueQuery_upload = NULL;
    keyValuePair_t *keyPairQuery_upload = 0;
    if (upload)
    {
        keyQuery_upload = strdup("upload");
        valueQuery_upload = strdup((upload));
        keyPairQuery_upload = keyValuePair_create(keyQuery_upload, valueQuery_upload);
        list_addElement(localVarQueryParameters,keyPairQuery_upload);
    }

    // query parameters
    char *keyQuery_filename = NULL;
    char * valueQuery_filename = NULL;
    keyValuePair_t *keyPairQuery_filename = 0;
    if (filename)
    {
        keyQuery_filename = strdup("filename");
        valueQuery_filename = strdup((filename));
        keyPairQuery_filename = keyValuePair_create(keyQuery_filename, valueQuery_filename);
        list_addElement(localVarQueryParameters,keyPairQuery_filename);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(valueQuery_upload){
        free(valueQuery_upload);
        valueQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(valueQuery_filename){
        free(valueQuery_filename);
        valueQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }

}

// Delete a course
//
// Allows the user to delete an existing course.
//
void
DefaultAPI_eventdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of a course
//
// Allows the user to view an individual course and its details.
//
void
DefaultAPI_eventget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of courses by date
//
// Allows the user to view a list of courses by date.
//
void
DefaultAPI_eventgetsessionsbydate(apiClient_t *apiClient, char * token , char * location , char date , char * type )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventgetsessionsbydate")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventgetsessionsbydate");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_date = NULL;
    char valueQuery_date ;
    keyValuePair_t *keyPairQuery_date = 0;
    if (date)
    {
        keyQuery_date = strdup("date");
        valueQuery_date = (date);
        keyPairQuery_date = keyValuePair_create(keyQuery_date, &valueQuery_date);
        list_addElement(localVarQueryParameters,keyPairQuery_date);
    }

    // query parameters
    char *keyQuery_type = NULL;
    char * valueQuery_type = NULL;
    keyValuePair_t *keyPairQuery_type = 0;
    if (type)
    {
        keyQuery_type = strdup("type");
        valueQuery_type = strdup((type));
        keyPairQuery_type = keyValuePair_create(keyQuery_type, valueQuery_type);
        list_addElement(localVarQueryParameters,keyPairQuery_type);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(valueQuery_type){
        free(valueQuery_type);
        valueQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }

}

// View a list of courses
//
// Allows the user to view the full list of courses.
//
void
DefaultAPI_eventlist(apiClient_t *apiClient, char * token , char * from , char * count , int summaryonly , char * termid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_from = NULL;
    char * valueQuery_from = NULL;
    keyValuePair_t *keyPairQuery_from = 0;
    if (from)
    {
        keyQuery_from = strdup("from");
        valueQuery_from = strdup((from));
        keyPairQuery_from = keyValuePair_create(keyQuery_from, valueQuery_from);
        list_addElement(localVarQueryParameters,keyPairQuery_from);
    }

    // query parameters
    char *keyQuery_count = NULL;
    char * valueQuery_count = NULL;
    keyValuePair_t *keyPairQuery_count = 0;
    if (count)
    {
        keyQuery_count = strdup("count");
        valueQuery_count = strdup((count));
        keyPairQuery_count = keyValuePair_create(keyQuery_count, valueQuery_count);
        list_addElement(localVarQueryParameters,keyPairQuery_count);
    }

    // query parameters
    char *keyQuery_summaryonly = NULL;
    int valueQuery_summaryonly ;
    keyValuePair_t *keyPairQuery_summaryonly = 0;
    if (summaryonly)
    {
        keyQuery_summaryonly = strdup("summaryonly");
        valueQuery_summaryonly = (summaryonly);
        keyPairQuery_summaryonly = keyValuePair_create(keyQuery_summaryonly, &valueQuery_summaryonly);
        list_addElement(localVarQueryParameters,keyPairQuery_summaryonly);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_from){
        free(keyQuery_from);
        keyQuery_from = NULL;
    }
    if(valueQuery_from){
        free(valueQuery_from);
        valueQuery_from = NULL;
    }
    if(keyPairQuery_from){
        keyValuePair_free(keyPairQuery_from);
        keyPairQuery_from = NULL;
    }
    if(keyQuery_from){
        free(keyQuery_from);
        keyQuery_from = NULL;
    }
    if(keyPairQuery_from){
        keyValuePair_free(keyPairQuery_from);
        keyPairQuery_from = NULL;
    }
    if(keyQuery_count){
        free(keyQuery_count);
        keyQuery_count = NULL;
    }
    if(valueQuery_count){
        free(valueQuery_count);
        valueQuery_count = NULL;
    }
    if(keyPairQuery_count){
        keyValuePair_free(keyPairQuery_count);
        keyPairQuery_count = NULL;
    }
    if(keyQuery_count){
        free(keyQuery_count);
        keyQuery_count = NULL;
    }
    if(keyPairQuery_count){
        keyValuePair_free(keyPairQuery_count);
        keyPairQuery_count = NULL;
    }

}

// Create or edit a course
//
// Allows the user to create or edit a course.
//
void
DefaultAPI_eventsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventsave");




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

// Searches for the available event groups
//
void
DefaultAPI_eventsearchgroup(apiClient_t *apiClient, char * token , char * query )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/eventsearchgroup")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/eventsearchgroup");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_query = NULL;
    char * valueQuery_query ;
    keyValuePair_t *keyPairQuery_query = 0;
    if (query)
    {
        keyQuery_query = strdup("query");
        valueQuery_query = (query);
        keyPairQuery_query = keyValuePair_create(keyQuery_query, &valueQuery_query);
        list_addElement(localVarQueryParameters,keyPairQuery_query);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Export AccuCampus data
//
// Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.
//
void
DefaultAPI_export(apiClient_t *apiClient, char * token , char * exporttype , char * exportformat , char * filters )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/export")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/export");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_exporttype = NULL;
    char * valueQuery_exporttype = NULL;
    keyValuePair_t *keyPairQuery_exporttype = 0;
    if (exporttype)
    {
        keyQuery_exporttype = strdup("exporttype");
        valueQuery_exporttype = strdup((exporttype));
        keyPairQuery_exporttype = keyValuePair_create(keyQuery_exporttype, valueQuery_exporttype);
        list_addElement(localVarQueryParameters,keyPairQuery_exporttype);
    }

    // query parameters
    char *keyQuery_exportformat = NULL;
    char * valueQuery_exportformat = NULL;
    keyValuePair_t *keyPairQuery_exportformat = 0;
    if (exportformat)
    {
        keyQuery_exportformat = strdup("exportformat");
        valueQuery_exportformat = strdup((exportformat));
        keyPairQuery_exportformat = keyValuePair_create(keyQuery_exportformat, valueQuery_exportformat);
        list_addElement(localVarQueryParameters,keyPairQuery_exportformat);
    }

    // query parameters
    char *keyQuery_filters = NULL;
    char * valueQuery_filters = NULL;
    keyValuePair_t *keyPairQuery_filters = 0;
    if (filters)
    {
        keyQuery_filters = strdup("filters");
        valueQuery_filters = strdup((filters));
        keyPairQuery_filters = keyValuePair_create(keyQuery_filters, valueQuery_filters);
        list_addElement(localVarQueryParameters,keyPairQuery_filters);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_exporttype){
        free(keyQuery_exporttype);
        keyQuery_exporttype = NULL;
    }
    if(valueQuery_exporttype){
        free(valueQuery_exporttype);
        valueQuery_exporttype = NULL;
    }
    if(keyPairQuery_exporttype){
        keyValuePair_free(keyPairQuery_exporttype);
        keyPairQuery_exporttype = NULL;
    }
    if(keyQuery_exporttype){
        free(keyQuery_exporttype);
        keyQuery_exporttype = NULL;
    }
    if(keyPairQuery_exporttype){
        keyValuePair_free(keyPairQuery_exporttype);
        keyPairQuery_exporttype = NULL;
    }
    if(keyQuery_exportformat){
        free(keyQuery_exportformat);
        keyQuery_exportformat = NULL;
    }
    if(valueQuery_exportformat){
        free(valueQuery_exportformat);
        valueQuery_exportformat = NULL;
    }
    if(keyPairQuery_exportformat){
        keyValuePair_free(keyPairQuery_exportformat);
        keyPairQuery_exportformat = NULL;
    }
    if(keyQuery_exportformat){
        free(keyQuery_exportformat);
        keyQuery_exportformat = NULL;
    }
    if(keyPairQuery_exportformat){
        keyValuePair_free(keyPairQuery_exportformat);
        keyPairQuery_exportformat = NULL;
    }
    if(keyQuery_filters){
        free(keyQuery_filters);
        keyQuery_filters = NULL;
    }
    if(valueQuery_filters){
        free(valueQuery_filters);
        valueQuery_filters = NULL;
    }
    if(keyPairQuery_filters){
        keyValuePair_free(keyPairQuery_filters);
        keyPairQuery_filters = NULL;
    }
    if(keyQuery_filters){
        free(keyQuery_filters);
        keyQuery_filters = NULL;
    }
    if(keyPairQuery_filters){
        keyValuePair_free(keyPairQuery_filters);
        keyPairQuery_filters = NULL;
    }

}

// Lists available export types
//
void
DefaultAPI_exportlisttypes(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/exportlisttypes")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/exportlisttypes");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Lists the available features.
//
void
DefaultAPI_featurelist(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/featurelist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/featurelist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of entered holidays
//
// Allows the user to view all holidays entered.
//
void
DefaultAPI_holidaylist(apiClient_t *apiClient, char * token , char * term )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/holidaylist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/holidaylist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_term = NULL;
    char * valueQuery_term ;
    keyValuePair_t *keyPairQuery_term = 0;
    if (term)
    {
        keyQuery_term = strdup("term");
        valueQuery_term = (term);
        keyPairQuery_term = keyValuePair_create(keyQuery_term, &valueQuery_term);
        list_addElement(localVarQueryParameters,keyPairQuery_term);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a list of holidays
//
// Allows the user to create or edit holidays.
//
void
DefaultAPI_holidaysave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/holidaysave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/holidaysave");




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

// View the holiday suggestions in the given term
//
// Allows the user to view the holiday suggestions for each term.
//
void
DefaultAPI_holidaysuggest(apiClient_t *apiClient, char * token , char * term )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/holidaysuggest")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/holidaysuggest");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_term = NULL;
    char * valueQuery_term ;
    keyValuePair_t *keyPairQuery_term = 0;
    if (term)
    {
        keyQuery_term = strdup("term");
        valueQuery_term = (term);
        keyPairQuery_term = keyValuePair_create(keyQuery_term, &valueQuery_term);
        list_addElement(localVarQueryParameters,keyPairQuery_term);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Import data into AccuCampus
//
// Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.
//
void
DefaultAPI_import(apiClient_t *apiClient, char * token , char * importtype , char * upload , char * filename , char * parameters )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/import")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/import");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_importtype = NULL;
    char * valueQuery_importtype = NULL;
    keyValuePair_t *keyPairQuery_importtype = 0;
    if (importtype)
    {
        keyQuery_importtype = strdup("importtype");
        valueQuery_importtype = strdup((importtype));
        keyPairQuery_importtype = keyValuePair_create(keyQuery_importtype, valueQuery_importtype);
        list_addElement(localVarQueryParameters,keyPairQuery_importtype);
    }

    // query parameters
    char *keyQuery_upload = NULL;
    char * valueQuery_upload = NULL;
    keyValuePair_t *keyPairQuery_upload = 0;
    if (upload)
    {
        keyQuery_upload = strdup("upload");
        valueQuery_upload = strdup((upload));
        keyPairQuery_upload = keyValuePair_create(keyQuery_upload, valueQuery_upload);
        list_addElement(localVarQueryParameters,keyPairQuery_upload);
    }

    // query parameters
    char *keyQuery_filename = NULL;
    char * valueQuery_filename = NULL;
    keyValuePair_t *keyPairQuery_filename = 0;
    if (filename)
    {
        keyQuery_filename = strdup("filename");
        valueQuery_filename = strdup((filename));
        keyPairQuery_filename = keyValuePair_create(keyQuery_filename, valueQuery_filename);
        list_addElement(localVarQueryParameters,keyPairQuery_filename);
    }

    // query parameters
    char *keyQuery_parameters = NULL;
    char * valueQuery_parameters = NULL;
    keyValuePair_t *keyPairQuery_parameters = 0;
    if (parameters)
    {
        keyQuery_parameters = strdup("parameters");
        valueQuery_parameters = strdup((parameters));
        keyPairQuery_parameters = keyValuePair_create(keyQuery_parameters, valueQuery_parameters);
        list_addElement(localVarQueryParameters,keyPairQuery_parameters);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_importtype){
        free(keyQuery_importtype);
        keyQuery_importtype = NULL;
    }
    if(valueQuery_importtype){
        free(valueQuery_importtype);
        valueQuery_importtype = NULL;
    }
    if(keyPairQuery_importtype){
        keyValuePair_free(keyPairQuery_importtype);
        keyPairQuery_importtype = NULL;
    }
    if(keyQuery_importtype){
        free(keyQuery_importtype);
        keyQuery_importtype = NULL;
    }
    if(keyPairQuery_importtype){
        keyValuePair_free(keyPairQuery_importtype);
        keyPairQuery_importtype = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(valueQuery_upload){
        free(valueQuery_upload);
        valueQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(valueQuery_filename){
        free(valueQuery_filename);
        valueQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }
    if(keyQuery_parameters){
        free(keyQuery_parameters);
        keyQuery_parameters = NULL;
    }
    if(valueQuery_parameters){
        free(valueQuery_parameters);
        valueQuery_parameters = NULL;
    }
    if(keyPairQuery_parameters){
        keyValuePair_free(keyPairQuery_parameters);
        keyPairQuery_parameters = NULL;
    }
    if(keyQuery_parameters){
        free(keyQuery_parameters);
        keyQuery_parameters = NULL;
    }
    if(keyPairQuery_parameters){
        keyValuePair_free(keyPairQuery_parameters);
        keyPairQuery_parameters = NULL;
    }

}

// Lists available import types
//
void
DefaultAPI_importlisttypes(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/importlisttypes")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/importlisttypes");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Accept the license agreement
//
void
DefaultAPI_licenseacceptagreement(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/licenseacceptagreement")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/licenseacceptagreement");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Check if license agreement has been accepted
//
void
DefaultAPI_licensegetagreementstatus(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/licensegetagreementstatus")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/licensegetagreementstatus");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the current license information
//
void
DefaultAPI_licensegetcurrent(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/licensegetcurrent")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/licensegetcurrent");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Contact Engineerica in order to renew the AccuCampus subscription
//
// Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.
//
void
DefaultAPI_licenserenew(apiClient_t *apiClient, char * token , char * email , char * phonenumber , char * jobtitle , char * institution , char * comments )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/licenserenew")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/licenserenew");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_email = NULL;
    char * valueQuery_email = NULL;
    keyValuePair_t *keyPairQuery_email = 0;
    if (email)
    {
        keyQuery_email = strdup("email");
        valueQuery_email = strdup((email));
        keyPairQuery_email = keyValuePair_create(keyQuery_email, valueQuery_email);
        list_addElement(localVarQueryParameters,keyPairQuery_email);
    }

    // query parameters
    char *keyQuery_phonenumber = NULL;
    char * valueQuery_phonenumber = NULL;
    keyValuePair_t *keyPairQuery_phonenumber = 0;
    if (phonenumber)
    {
        keyQuery_phonenumber = strdup("phonenumber");
        valueQuery_phonenumber = strdup((phonenumber));
        keyPairQuery_phonenumber = keyValuePair_create(keyQuery_phonenumber, valueQuery_phonenumber);
        list_addElement(localVarQueryParameters,keyPairQuery_phonenumber);
    }

    // query parameters
    char *keyQuery_jobtitle = NULL;
    char * valueQuery_jobtitle = NULL;
    keyValuePair_t *keyPairQuery_jobtitle = 0;
    if (jobtitle)
    {
        keyQuery_jobtitle = strdup("jobtitle");
        valueQuery_jobtitle = strdup((jobtitle));
        keyPairQuery_jobtitle = keyValuePair_create(keyQuery_jobtitle, valueQuery_jobtitle);
        list_addElement(localVarQueryParameters,keyPairQuery_jobtitle);
    }

    // query parameters
    char *keyQuery_institution = NULL;
    char * valueQuery_institution = NULL;
    keyValuePair_t *keyPairQuery_institution = 0;
    if (institution)
    {
        keyQuery_institution = strdup("institution");
        valueQuery_institution = strdup((institution));
        keyPairQuery_institution = keyValuePair_create(keyQuery_institution, valueQuery_institution);
        list_addElement(localVarQueryParameters,keyPairQuery_institution);
    }

    // query parameters
    char *keyQuery_comments = NULL;
    char * valueQuery_comments = NULL;
    keyValuePair_t *keyPairQuery_comments = 0;
    if (comments)
    {
        keyQuery_comments = strdup("comments");
        valueQuery_comments = strdup((comments));
        keyPairQuery_comments = keyValuePair_create(keyQuery_comments, valueQuery_comments);
        list_addElement(localVarQueryParameters,keyPairQuery_comments);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_email){
        free(keyQuery_email);
        keyQuery_email = NULL;
    }
    if(valueQuery_email){
        free(valueQuery_email);
        valueQuery_email = NULL;
    }
    if(keyPairQuery_email){
        keyValuePair_free(keyPairQuery_email);
        keyPairQuery_email = NULL;
    }
    if(keyQuery_email){
        free(keyQuery_email);
        keyQuery_email = NULL;
    }
    if(keyPairQuery_email){
        keyValuePair_free(keyPairQuery_email);
        keyPairQuery_email = NULL;
    }
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(valueQuery_phonenumber){
        free(valueQuery_phonenumber);
        valueQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }
    if(keyQuery_jobtitle){
        free(keyQuery_jobtitle);
        keyQuery_jobtitle = NULL;
    }
    if(valueQuery_jobtitle){
        free(valueQuery_jobtitle);
        valueQuery_jobtitle = NULL;
    }
    if(keyPairQuery_jobtitle){
        keyValuePair_free(keyPairQuery_jobtitle);
        keyPairQuery_jobtitle = NULL;
    }
    if(keyQuery_jobtitle){
        free(keyQuery_jobtitle);
        keyQuery_jobtitle = NULL;
    }
    if(keyPairQuery_jobtitle){
        keyValuePair_free(keyPairQuery_jobtitle);
        keyPairQuery_jobtitle = NULL;
    }
    if(keyQuery_institution){
        free(keyQuery_institution);
        keyQuery_institution = NULL;
    }
    if(valueQuery_institution){
        free(valueQuery_institution);
        valueQuery_institution = NULL;
    }
    if(keyPairQuery_institution){
        keyValuePair_free(keyPairQuery_institution);
        keyPairQuery_institution = NULL;
    }
    if(keyQuery_institution){
        free(keyQuery_institution);
        keyQuery_institution = NULL;
    }
    if(keyPairQuery_institution){
        keyValuePair_free(keyPairQuery_institution);
        keyPairQuery_institution = NULL;
    }
    if(keyQuery_comments){
        free(keyQuery_comments);
        keyQuery_comments = NULL;
    }
    if(valueQuery_comments){
        free(valueQuery_comments);
        valueQuery_comments = NULL;
    }
    if(keyPairQuery_comments){
        keyValuePair_free(keyPairQuery_comments);
        keyPairQuery_comments = NULL;
    }
    if(keyQuery_comments){
        free(keyQuery_comments);
        keyQuery_comments = NULL;
    }
    if(keyPairQuery_comments){
        keyValuePair_free(keyPairQuery_comments);
        keyPairQuery_comments = NULL;
    }

}

// Lists the available timezones
//
void
DefaultAPI_listtimezones(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/listtimezones")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/listtimezones");



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

// Delete a location
//
// Allows the user to delete an existing location.
//
void
DefaultAPI_locationdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/locationdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/locationdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of a location
//
// Allows the user to search and view an individual location and its details.
//
void
DefaultAPI_locationget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/locationget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/locationget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of locations
//
// Allows the user to view the list of all locations to which they are scoped.
//
void
DefaultAPI_locationlist(apiClient_t *apiClient, char * token , int from , int count , char * locations , int sortbygroup )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/locationlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/locationlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_locations = NULL;
    char * valueQuery_locations = NULL;
    keyValuePair_t *keyPairQuery_locations = 0;
    if (locations)
    {
        keyQuery_locations = strdup("locations");
        valueQuery_locations = strdup((locations));
        keyPairQuery_locations = keyValuePair_create(keyQuery_locations, valueQuery_locations);
        list_addElement(localVarQueryParameters,keyPairQuery_locations);
    }

    // query parameters
    char *keyQuery_sortbygroup = NULL;
    int valueQuery_sortbygroup ;
    keyValuePair_t *keyPairQuery_sortbygroup = 0;
    if (sortbygroup)
    {
        keyQuery_sortbygroup = strdup("sortbygroup");
        valueQuery_sortbygroup = (sortbygroup);
        keyPairQuery_sortbygroup = keyValuePair_create(keyQuery_sortbygroup, &valueQuery_sortbygroup);
        list_addElement(localVarQueryParameters,keyPairQuery_sortbygroup);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_locations){
        free(keyQuery_locations);
        keyQuery_locations = NULL;
    }
    if(valueQuery_locations){
        free(valueQuery_locations);
        valueQuery_locations = NULL;
    }
    if(keyPairQuery_locations){
        keyValuePair_free(keyPairQuery_locations);
        keyPairQuery_locations = NULL;
    }
    if(keyQuery_locations){
        free(keyQuery_locations);
        keyQuery_locations = NULL;
    }
    if(keyPairQuery_locations){
        keyValuePair_free(keyPairQuery_locations);
        keyPairQuery_locations = NULL;
    }

}

// Create or edit a location
//
// Allows the user to create or edit a location.
//
void
DefaultAPI_locationsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/locationsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/locationsave");




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

// Login
//
void
DefaultAPI_login(apiClient_t *apiClient, char * domain , char * username , char * password , char * method , int rememberme )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/login")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/login");




    // query parameters
    char *keyQuery_domain = NULL;
    char * valueQuery_domain = NULL;
    keyValuePair_t *keyPairQuery_domain = 0;
    if (domain)
    {
        keyQuery_domain = strdup("domain");
        valueQuery_domain = strdup((domain));
        keyPairQuery_domain = keyValuePair_create(keyQuery_domain, valueQuery_domain);
        list_addElement(localVarQueryParameters,keyPairQuery_domain);
    }

    // query parameters
    char *keyQuery_username = NULL;
    char * valueQuery_username = NULL;
    keyValuePair_t *keyPairQuery_username = 0;
    if (username)
    {
        keyQuery_username = strdup("username");
        valueQuery_username = strdup((username));
        keyPairQuery_username = keyValuePair_create(keyQuery_username, valueQuery_username);
        list_addElement(localVarQueryParameters,keyPairQuery_username);
    }

    // query parameters
    char *keyQuery_password = NULL;
    char * valueQuery_password = NULL;
    keyValuePair_t *keyPairQuery_password = 0;
    if (password)
    {
        keyQuery_password = strdup("password");
        valueQuery_password = strdup((password));
        keyPairQuery_password = keyValuePair_create(keyQuery_password, valueQuery_password);
        list_addElement(localVarQueryParameters,keyPairQuery_password);
    }

    // query parameters
    char *keyQuery_method = NULL;
    char * valueQuery_method = NULL;
    keyValuePair_t *keyPairQuery_method = 0;
    if (method)
    {
        keyQuery_method = strdup("method");
        valueQuery_method = strdup((method));
        keyPairQuery_method = keyValuePair_create(keyQuery_method, valueQuery_method);
        list_addElement(localVarQueryParameters,keyPairQuery_method);
    }

    // query parameters
    char *keyQuery_rememberme = NULL;
    int valueQuery_rememberme ;
    keyValuePair_t *keyPairQuery_rememberme = 0;
    if (rememberme)
    {
        keyQuery_rememberme = strdup("rememberme");
        valueQuery_rememberme = (rememberme);
        keyPairQuery_rememberme = keyValuePair_create(keyQuery_rememberme, &valueQuery_rememberme);
        list_addElement(localVarQueryParameters,keyPairQuery_rememberme);
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
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(valueQuery_domain){
        free(valueQuery_domain);
        valueQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_username){
        free(keyQuery_username);
        keyQuery_username = NULL;
    }
    if(valueQuery_username){
        free(valueQuery_username);
        valueQuery_username = NULL;
    }
    if(keyPairQuery_username){
        keyValuePair_free(keyPairQuery_username);
        keyPairQuery_username = NULL;
    }
    if(keyQuery_username){
        free(keyQuery_username);
        keyQuery_username = NULL;
    }
    if(keyPairQuery_username){
        keyValuePair_free(keyPairQuery_username);
        keyPairQuery_username = NULL;
    }
    if(keyQuery_password){
        free(keyQuery_password);
        keyQuery_password = NULL;
    }
    if(valueQuery_password){
        free(valueQuery_password);
        valueQuery_password = NULL;
    }
    if(keyPairQuery_password){
        keyValuePair_free(keyPairQuery_password);
        keyPairQuery_password = NULL;
    }
    if(keyQuery_password){
        free(keyQuery_password);
        keyQuery_password = NULL;
    }
    if(keyPairQuery_password){
        keyValuePair_free(keyPairQuery_password);
        keyPairQuery_password = NULL;
    }
    if(keyQuery_method){
        free(keyQuery_method);
        keyQuery_method = NULL;
    }
    if(valueQuery_method){
        free(valueQuery_method);
        valueQuery_method = NULL;
    }
    if(keyPairQuery_method){
        keyValuePair_free(keyPairQuery_method);
        keyPairQuery_method = NULL;
    }
    if(keyQuery_method){
        free(keyQuery_method);
        keyQuery_method = NULL;
    }
    if(keyPairQuery_method){
        keyValuePair_free(keyPairQuery_method);
        keyPairQuery_method = NULL;
    }

}

// Logout
//
void
DefaultAPI_logout(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/logout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/logout");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Delete memorized report
//
// Allows the user to delete a memorized report that they have created.
//
void
DefaultAPI_memorizedreportdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/memorizedreportdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/memorizedreportdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View details of a memorized report
//
// Allows the user to view an individual memorized report and its details.
//
void
DefaultAPI_memorizedreportget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/memorizedreportget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/memorizedreportget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of all his memorized reports
//
// Allows the user to view the list of all memorized reports that they have created.
//
void
DefaultAPI_memorizedreportlist(apiClient_t *apiClient, char * token , int from , int count , char * customname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/memorizedreportlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/memorizedreportlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_customname = NULL;
    char * valueQuery_customname = NULL;
    keyValuePair_t *keyPairQuery_customname = 0;
    if (customname)
    {
        keyQuery_customname = strdup("customname");
        valueQuery_customname = strdup((customname));
        keyPairQuery_customname = keyValuePair_create(keyQuery_customname, valueQuery_customname);
        list_addElement(localVarQueryParameters,keyPairQuery_customname);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_customname){
        free(keyQuery_customname);
        keyQuery_customname = NULL;
    }
    if(valueQuery_customname){
        free(valueQuery_customname);
        valueQuery_customname = NULL;
    }
    if(keyPairQuery_customname){
        keyValuePair_free(keyPairQuery_customname);
        keyPairQuery_customname = NULL;
    }
    if(keyQuery_customname){
        free(keyQuery_customname);
        keyQuery_customname = NULL;
    }
    if(keyPairQuery_customname){
        keyValuePair_free(keyPairQuery_customname);
        keyPairQuery_customname = NULL;
    }

}

// Create or edit a memorized report
//
// Allows the user to create or edit a memorized report for themselves.
//
void
DefaultAPI_memorizedreportsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/memorizedreportsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/memorizedreportsave");




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

// Gets the items on the menu
//
void
DefaultAPI_menugetitems(apiClient_t *apiClient, char * menuid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/menugetitems")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/menugetitems");




    // query parameters
    char *keyQuery_menuid = NULL;
    char * valueQuery_menuid = NULL;
    keyValuePair_t *keyPairQuery_menuid = 0;
    if (menuid)
    {
        keyQuery_menuid = strdup("menuid");
        valueQuery_menuid = strdup((menuid));
        keyPairQuery_menuid = keyValuePair_create(keyQuery_menuid, valueQuery_menuid);
        list_addElement(localVarQueryParameters,keyPairQuery_menuid);
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
    if(keyQuery_menuid){
        free(keyQuery_menuid);
        keyQuery_menuid = NULL;
    }
    if(valueQuery_menuid){
        free(valueQuery_menuid);
        valueQuery_menuid = NULL;
    }
    if(keyPairQuery_menuid){
        keyValuePair_free(keyPairQuery_menuid);
        keyPairQuery_menuid = NULL;
    }
    if(keyQuery_menuid){
        free(keyQuery_menuid);
        keyQuery_menuid = NULL;
    }
    if(keyPairQuery_menuid){
        keyValuePair_free(keyPairQuery_menuid);
        keyPairQuery_menuid = NULL;
    }

}

// Gets the logged in user account.
//
void
DefaultAPI_myaccount(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/myaccount")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/myaccount");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the current time zone's iana name
//
void
DefaultAPI_myianatimezone(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/myianatimezone")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/myianatimezone");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the logged in user information.
//
void
DefaultAPI_myprofile(apiClient_t *apiClient, char * token , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/myprofile")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/myprofile");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets the list of actions the user can execute.
//
void
DefaultAPI_myrights(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/myrights")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/myrights");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Updates logged user's profile information
//
void
DefaultAPI_mysaveprofile(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/mysaveprofile")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/mysaveprofile");




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

// Delete a notification
//
// Allows the user to delete an existing notification.
//
void
DefaultAPI_notificationdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a notification
//
void
DefaultAPI_notificationget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets all public (in station) notifications for the specific user
//
void
DefaultAPI_notificationgetforstation(apiClient_t *apiClient, char * station , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationgetforstation")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationgetforstation");




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

// Get the number of unread notifications
//
void
DefaultAPI_notificationgetunreadcount(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationgetunreadcount")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationgetunreadcount");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of all sent notifications
//
// Allows the user to view the list of all sent notifications.
//
void
DefaultAPI_notificationlist(apiClient_t *apiClient, char * token , int from , int count , char * recipient , int status , char startdate , char enddate , int sentonscreen , int sentemail , int sentsms )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_recipient = NULL;
    char * valueQuery_recipient ;
    keyValuePair_t *keyPairQuery_recipient = 0;
    if (recipient)
    {
        keyQuery_recipient = strdup("recipient");
        valueQuery_recipient = (recipient);
        keyPairQuery_recipient = keyValuePair_create(keyQuery_recipient, &valueQuery_recipient);
        list_addElement(localVarQueryParameters,keyPairQuery_recipient);
    }

    // query parameters
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
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
    char *keyQuery_sentonscreen = NULL;
    int valueQuery_sentonscreen ;
    keyValuePair_t *keyPairQuery_sentonscreen = 0;
    if (sentonscreen)
    {
        keyQuery_sentonscreen = strdup("sentonscreen");
        valueQuery_sentonscreen = (sentonscreen);
        keyPairQuery_sentonscreen = keyValuePair_create(keyQuery_sentonscreen, &valueQuery_sentonscreen);
        list_addElement(localVarQueryParameters,keyPairQuery_sentonscreen);
    }

    // query parameters
    char *keyQuery_sentemail = NULL;
    int valueQuery_sentemail ;
    keyValuePair_t *keyPairQuery_sentemail = 0;
    if (sentemail)
    {
        keyQuery_sentemail = strdup("sentemail");
        valueQuery_sentemail = (sentemail);
        keyPairQuery_sentemail = keyValuePair_create(keyQuery_sentemail, &valueQuery_sentemail);
        list_addElement(localVarQueryParameters,keyPairQuery_sentemail);
    }

    // query parameters
    char *keyQuery_sentsms = NULL;
    int valueQuery_sentsms ;
    keyValuePair_t *keyPairQuery_sentsms = 0;
    if (sentsms)
    {
        keyQuery_sentsms = strdup("sentsms");
        valueQuery_sentsms = (sentsms);
        keyPairQuery_sentsms = keyValuePair_create(keyQuery_sentsms, &valueQuery_sentsms);
        list_addElement(localVarQueryParameters,keyPairQuery_sentsms);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View all the notifications sent to the current user
//
void
DefaultAPI_notificationlistmine(apiClient_t *apiClient, char * token , int from , int count , int status , char startdate , char enddate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationlistmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationlistmine");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Mark a notification as read
//
void
DefaultAPI_notificationmarkasread(apiClient_t *apiClient, char * token , char * id , int status , char startdate , char enddate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationmarkasread")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationmarkasread");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Mark a notification as unread
//
void
DefaultAPI_notificationmarkasunread(apiClient_t *apiClient, char * token , char * id , int status , char startdate , char enddate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationmarkasunread")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationmarkasunread");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Send notifications on screen, via email or text to users
//
// Allows the user to send notifications to other users through the Send Message link.
//
void
DefaultAPI_notificationsend(apiClient_t *apiClient, char * token , int emailenabled , int onscreenenabled , int smsenabled , char * title , char * tousers , char * togroups , char * onscreenbody , char * onscreenclick , char * onscreenurl , char * onscreenclass , int onscreenduration , int showonstation , char * emailfromname , char * emailfrom , char * emailsubject , char * emailbody , char * textmessagebody )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationsend")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationsend");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_tousers = NULL;
    char * valueQuery_tousers = NULL;
    keyValuePair_t *keyPairQuery_tousers = 0;
    if (tousers)
    {
        keyQuery_tousers = strdup("tousers");
        valueQuery_tousers = strdup((tousers));
        keyPairQuery_tousers = keyValuePair_create(keyQuery_tousers, valueQuery_tousers);
        list_addElement(localVarQueryParameters,keyPairQuery_tousers);
    }

    // query parameters
    char *keyQuery_togroups = NULL;
    char * valueQuery_togroups = NULL;
    keyValuePair_t *keyPairQuery_togroups = 0;
    if (togroups)
    {
        keyQuery_togroups = strdup("togroups");
        valueQuery_togroups = strdup((togroups));
        keyPairQuery_togroups = keyValuePair_create(keyQuery_togroups, valueQuery_togroups);
        list_addElement(localVarQueryParameters,keyPairQuery_togroups);
    }

    // query parameters
    char *keyQuery_emailenabled = NULL;
    int valueQuery_emailenabled ;
    keyValuePair_t *keyPairQuery_emailenabled = 0;
    if (emailenabled)
    {
        keyQuery_emailenabled = strdup("emailenabled");
        valueQuery_emailenabled = (emailenabled);
        keyPairQuery_emailenabled = keyValuePair_create(keyQuery_emailenabled, &valueQuery_emailenabled);
        list_addElement(localVarQueryParameters,keyPairQuery_emailenabled);
    }

    // query parameters
    char *keyQuery_onscreenenabled = NULL;
    int valueQuery_onscreenenabled ;
    keyValuePair_t *keyPairQuery_onscreenenabled = 0;
    if (onscreenenabled)
    {
        keyQuery_onscreenenabled = strdup("onscreenenabled");
        valueQuery_onscreenenabled = (onscreenenabled);
        keyPairQuery_onscreenenabled = keyValuePair_create(keyQuery_onscreenenabled, &valueQuery_onscreenenabled);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenenabled);
    }

    // query parameters
    char *keyQuery_smsenabled = NULL;
    int valueQuery_smsenabled ;
    keyValuePair_t *keyPairQuery_smsenabled = 0;
    if (smsenabled)
    {
        keyQuery_smsenabled = strdup("smsenabled");
        valueQuery_smsenabled = (smsenabled);
        keyPairQuery_smsenabled = keyValuePair_create(keyQuery_smsenabled, &valueQuery_smsenabled);
        list_addElement(localVarQueryParameters,keyPairQuery_smsenabled);
    }

    // query parameters
    char *keyQuery_title = NULL;
    char * valueQuery_title = NULL;
    keyValuePair_t *keyPairQuery_title = 0;
    if (title)
    {
        keyQuery_title = strdup("title");
        valueQuery_title = strdup((title));
        keyPairQuery_title = keyValuePair_create(keyQuery_title, valueQuery_title);
        list_addElement(localVarQueryParameters,keyPairQuery_title);
    }

    // query parameters
    char *keyQuery_onscreenbody = NULL;
    char * valueQuery_onscreenbody = NULL;
    keyValuePair_t *keyPairQuery_onscreenbody = 0;
    if (onscreenbody)
    {
        keyQuery_onscreenbody = strdup("onscreenbody");
        valueQuery_onscreenbody = strdup((onscreenbody));
        keyPairQuery_onscreenbody = keyValuePair_create(keyQuery_onscreenbody, valueQuery_onscreenbody);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenbody);
    }

    // query parameters
    char *keyQuery_onscreenclick = NULL;
    char * valueQuery_onscreenclick = NULL;
    keyValuePair_t *keyPairQuery_onscreenclick = 0;
    if (onscreenclick)
    {
        keyQuery_onscreenclick = strdup("onscreenclick");
        valueQuery_onscreenclick = strdup((onscreenclick));
        keyPairQuery_onscreenclick = keyValuePair_create(keyQuery_onscreenclick, valueQuery_onscreenclick);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenclick);
    }

    // query parameters
    char *keyQuery_onscreenurl = NULL;
    char * valueQuery_onscreenurl = NULL;
    keyValuePair_t *keyPairQuery_onscreenurl = 0;
    if (onscreenurl)
    {
        keyQuery_onscreenurl = strdup("onscreenurl");
        valueQuery_onscreenurl = strdup((onscreenurl));
        keyPairQuery_onscreenurl = keyValuePair_create(keyQuery_onscreenurl, valueQuery_onscreenurl);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenurl);
    }

    // query parameters
    char *keyQuery_onscreenclass = NULL;
    char * valueQuery_onscreenclass = NULL;
    keyValuePair_t *keyPairQuery_onscreenclass = 0;
    if (onscreenclass)
    {
        keyQuery_onscreenclass = strdup("onscreenclass");
        valueQuery_onscreenclass = strdup((onscreenclass));
        keyPairQuery_onscreenclass = keyValuePair_create(keyQuery_onscreenclass, valueQuery_onscreenclass);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenclass);
    }

    // query parameters
    char *keyQuery_onscreenduration = NULL;
    int valueQuery_onscreenduration ;
    keyValuePair_t *keyPairQuery_onscreenduration = 0;
    if (onscreenduration)
    {
        keyQuery_onscreenduration = strdup("onscreenduration");
        valueQuery_onscreenduration = (onscreenduration);
        keyPairQuery_onscreenduration = keyValuePair_create(keyQuery_onscreenduration, &valueQuery_onscreenduration);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenduration);
    }

    // query parameters
    char *keyQuery_showonstation = NULL;
    int valueQuery_showonstation ;
    keyValuePair_t *keyPairQuery_showonstation = 0;
    if (showonstation)
    {
        keyQuery_showonstation = strdup("showonstation");
        valueQuery_showonstation = (showonstation);
        keyPairQuery_showonstation = keyValuePair_create(keyQuery_showonstation, &valueQuery_showonstation);
        list_addElement(localVarQueryParameters,keyPairQuery_showonstation);
    }

    // query parameters
    char *keyQuery_emailfromname = NULL;
    char * valueQuery_emailfromname = NULL;
    keyValuePair_t *keyPairQuery_emailfromname = 0;
    if (emailfromname)
    {
        keyQuery_emailfromname = strdup("emailfromname");
        valueQuery_emailfromname = strdup((emailfromname));
        keyPairQuery_emailfromname = keyValuePair_create(keyQuery_emailfromname, valueQuery_emailfromname);
        list_addElement(localVarQueryParameters,keyPairQuery_emailfromname);
    }

    // query parameters
    char *keyQuery_emailfrom = NULL;
    char * valueQuery_emailfrom = NULL;
    keyValuePair_t *keyPairQuery_emailfrom = 0;
    if (emailfrom)
    {
        keyQuery_emailfrom = strdup("emailfrom");
        valueQuery_emailfrom = strdup((emailfrom));
        keyPairQuery_emailfrom = keyValuePair_create(keyQuery_emailfrom, valueQuery_emailfrom);
        list_addElement(localVarQueryParameters,keyPairQuery_emailfrom);
    }

    // query parameters
    char *keyQuery_emailsubject = NULL;
    char * valueQuery_emailsubject = NULL;
    keyValuePair_t *keyPairQuery_emailsubject = 0;
    if (emailsubject)
    {
        keyQuery_emailsubject = strdup("emailsubject");
        valueQuery_emailsubject = strdup((emailsubject));
        keyPairQuery_emailsubject = keyValuePair_create(keyQuery_emailsubject, valueQuery_emailsubject);
        list_addElement(localVarQueryParameters,keyPairQuery_emailsubject);
    }

    // query parameters
    char *keyQuery_emailbody = NULL;
    char * valueQuery_emailbody = NULL;
    keyValuePair_t *keyPairQuery_emailbody = 0;
    if (emailbody)
    {
        keyQuery_emailbody = strdup("emailbody");
        valueQuery_emailbody = strdup((emailbody));
        keyPairQuery_emailbody = keyValuePair_create(keyQuery_emailbody, valueQuery_emailbody);
        list_addElement(localVarQueryParameters,keyPairQuery_emailbody);
    }

    // query parameters
    char *keyQuery_textmessagebody = NULL;
    char * valueQuery_textmessagebody = NULL;
    keyValuePair_t *keyPairQuery_textmessagebody = 0;
    if (textmessagebody)
    {
        keyQuery_textmessagebody = strdup("textmessagebody");
        valueQuery_textmessagebody = strdup((textmessagebody));
        keyPairQuery_textmessagebody = keyValuePair_create(keyQuery_textmessagebody, valueQuery_textmessagebody);
        list_addElement(localVarQueryParameters,keyPairQuery_textmessagebody);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_tousers){
        free(keyQuery_tousers);
        keyQuery_tousers = NULL;
    }
    if(valueQuery_tousers){
        free(valueQuery_tousers);
        valueQuery_tousers = NULL;
    }
    if(keyPairQuery_tousers){
        keyValuePair_free(keyPairQuery_tousers);
        keyPairQuery_tousers = NULL;
    }
    if(keyQuery_tousers){
        free(keyQuery_tousers);
        keyQuery_tousers = NULL;
    }
    if(keyPairQuery_tousers){
        keyValuePair_free(keyPairQuery_tousers);
        keyPairQuery_tousers = NULL;
    }
    if(keyQuery_togroups){
        free(keyQuery_togroups);
        keyQuery_togroups = NULL;
    }
    if(valueQuery_togroups){
        free(valueQuery_togroups);
        valueQuery_togroups = NULL;
    }
    if(keyPairQuery_togroups){
        keyValuePair_free(keyPairQuery_togroups);
        keyPairQuery_togroups = NULL;
    }
    if(keyQuery_togroups){
        free(keyQuery_togroups);
        keyQuery_togroups = NULL;
    }
    if(keyPairQuery_togroups){
        keyValuePair_free(keyPairQuery_togroups);
        keyPairQuery_togroups = NULL;
    }
    if(keyQuery_title){
        free(keyQuery_title);
        keyQuery_title = NULL;
    }
    if(valueQuery_title){
        free(valueQuery_title);
        valueQuery_title = NULL;
    }
    if(keyPairQuery_title){
        keyValuePair_free(keyPairQuery_title);
        keyPairQuery_title = NULL;
    }
    if(keyQuery_title){
        free(keyQuery_title);
        keyQuery_title = NULL;
    }
    if(keyPairQuery_title){
        keyValuePair_free(keyPairQuery_title);
        keyPairQuery_title = NULL;
    }
    if(keyQuery_onscreenbody){
        free(keyQuery_onscreenbody);
        keyQuery_onscreenbody = NULL;
    }
    if(valueQuery_onscreenbody){
        free(valueQuery_onscreenbody);
        valueQuery_onscreenbody = NULL;
    }
    if(keyPairQuery_onscreenbody){
        keyValuePair_free(keyPairQuery_onscreenbody);
        keyPairQuery_onscreenbody = NULL;
    }
    if(keyQuery_onscreenbody){
        free(keyQuery_onscreenbody);
        keyQuery_onscreenbody = NULL;
    }
    if(keyPairQuery_onscreenbody){
        keyValuePair_free(keyPairQuery_onscreenbody);
        keyPairQuery_onscreenbody = NULL;
    }
    if(keyQuery_onscreenclick){
        free(keyQuery_onscreenclick);
        keyQuery_onscreenclick = NULL;
    }
    if(valueQuery_onscreenclick){
        free(valueQuery_onscreenclick);
        valueQuery_onscreenclick = NULL;
    }
    if(keyPairQuery_onscreenclick){
        keyValuePair_free(keyPairQuery_onscreenclick);
        keyPairQuery_onscreenclick = NULL;
    }
    if(keyQuery_onscreenclick){
        free(keyQuery_onscreenclick);
        keyQuery_onscreenclick = NULL;
    }
    if(keyPairQuery_onscreenclick){
        keyValuePair_free(keyPairQuery_onscreenclick);
        keyPairQuery_onscreenclick = NULL;
    }
    if(keyQuery_onscreenurl){
        free(keyQuery_onscreenurl);
        keyQuery_onscreenurl = NULL;
    }
    if(valueQuery_onscreenurl){
        free(valueQuery_onscreenurl);
        valueQuery_onscreenurl = NULL;
    }
    if(keyPairQuery_onscreenurl){
        keyValuePair_free(keyPairQuery_onscreenurl);
        keyPairQuery_onscreenurl = NULL;
    }
    if(keyQuery_onscreenurl){
        free(keyQuery_onscreenurl);
        keyQuery_onscreenurl = NULL;
    }
    if(keyPairQuery_onscreenurl){
        keyValuePair_free(keyPairQuery_onscreenurl);
        keyPairQuery_onscreenurl = NULL;
    }
    if(keyQuery_onscreenclass){
        free(keyQuery_onscreenclass);
        keyQuery_onscreenclass = NULL;
    }
    if(valueQuery_onscreenclass){
        free(valueQuery_onscreenclass);
        valueQuery_onscreenclass = NULL;
    }
    if(keyPairQuery_onscreenclass){
        keyValuePair_free(keyPairQuery_onscreenclass);
        keyPairQuery_onscreenclass = NULL;
    }
    if(keyQuery_onscreenclass){
        free(keyQuery_onscreenclass);
        keyQuery_onscreenclass = NULL;
    }
    if(keyPairQuery_onscreenclass){
        keyValuePair_free(keyPairQuery_onscreenclass);
        keyPairQuery_onscreenclass = NULL;
    }
    if(keyQuery_emailfromname){
        free(keyQuery_emailfromname);
        keyQuery_emailfromname = NULL;
    }
    if(valueQuery_emailfromname){
        free(valueQuery_emailfromname);
        valueQuery_emailfromname = NULL;
    }
    if(keyPairQuery_emailfromname){
        keyValuePair_free(keyPairQuery_emailfromname);
        keyPairQuery_emailfromname = NULL;
    }
    if(keyQuery_emailfromname){
        free(keyQuery_emailfromname);
        keyQuery_emailfromname = NULL;
    }
    if(keyPairQuery_emailfromname){
        keyValuePair_free(keyPairQuery_emailfromname);
        keyPairQuery_emailfromname = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(valueQuery_emailfrom){
        free(valueQuery_emailfrom);
        valueQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(valueQuery_emailsubject){
        free(valueQuery_emailsubject);
        valueQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(valueQuery_emailbody){
        free(valueQuery_emailbody);
        valueQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }
    if(keyQuery_textmessagebody){
        free(keyQuery_textmessagebody);
        keyQuery_textmessagebody = NULL;
    }
    if(valueQuery_textmessagebody){
        free(valueQuery_textmessagebody);
        valueQuery_textmessagebody = NULL;
    }
    if(keyPairQuery_textmessagebody){
        keyValuePair_free(keyPairQuery_textmessagebody);
        keyPairQuery_textmessagebody = NULL;
    }
    if(keyQuery_textmessagebody){
        free(keyQuery_textmessagebody);
        keyQuery_textmessagebody = NULL;
    }
    if(keyPairQuery_textmessagebody){
        keyValuePair_free(keyPairQuery_textmessagebody);
        keyPairQuery_textmessagebody = NULL;
    }

}

// Send on-screen notifications
//
void
DefaultAPI_notificationsendonscreen(apiClient_t *apiClient, char * token , char * notification )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationsendonscreen")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationsendonscreen");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_notification = NULL;
    char * valueQuery_notification ;
    keyValuePair_t *keyPairQuery_notification = 0;
    if (notification)
    {
        keyQuery_notification = strdup("notification");
        valueQuery_notification = (notification);
        keyPairQuery_notification = keyValuePair_create(keyQuery_notification, &valueQuery_notification);
        list_addElement(localVarQueryParameters,keyPairQuery_notification);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Delete a notification topic
//
// Allows the user to delete an existing notification topic.
//
void
DefaultAPI_notificationtopicdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationtopicdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationtopicdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of a notification topic
//
// Allows the user to view an individual notification topic and its details.
//
void
DefaultAPI_notificationtopicget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationtopicget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationtopicget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// List all the notification topics
//
// Allows the user to view the list of all notification topics.
//
void
DefaultAPI_notificationtopiclist(apiClient_t *apiClient, char * token , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationtopiclist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationtopiclist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// List all the notification topics available to subscribe
//
void
DefaultAPI_notificationtopiclistsubscribe(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationtopiclistsubscribe")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationtopiclistsubscribe");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a notification topic
//
// Allows the user to create and edit a notification topic.
//
void
DefaultAPI_notificationtopicsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notificationtopicsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notificationtopicsave");




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

// Deregisters the current device to receive push notifications
//
void
DefaultAPI_pushderegister(apiClient_t *apiClient, char * devicetoken , char * platform )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/pushderegister")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/pushderegister");




    // query parameters
    char *keyQuery_devicetoken = NULL;
    char * valueQuery_devicetoken = NULL;
    keyValuePair_t *keyPairQuery_devicetoken = 0;
    if (devicetoken)
    {
        keyQuery_devicetoken = strdup("devicetoken");
        valueQuery_devicetoken = strdup((devicetoken));
        keyPairQuery_devicetoken = keyValuePair_create(keyQuery_devicetoken, valueQuery_devicetoken);
        list_addElement(localVarQueryParameters,keyPairQuery_devicetoken);
    }

    // query parameters
    char *keyQuery_platform = NULL;
    char * valueQuery_platform = NULL;
    keyValuePair_t *keyPairQuery_platform = 0;
    if (platform)
    {
        keyQuery_platform = strdup("platform");
        valueQuery_platform = strdup((platform));
        keyPairQuery_platform = keyValuePair_create(keyQuery_platform, valueQuery_platform);
        list_addElement(localVarQueryParameters,keyPairQuery_platform);
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
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(valueQuery_devicetoken){
        free(valueQuery_devicetoken);
        valueQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(valueQuery_platform){
        free(valueQuery_platform);
        valueQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }

}

// Registers the current device to receive push notifications
//
void
DefaultAPI_pushregister(apiClient_t *apiClient, char * devicetoken , char * platform )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/pushregister")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/pushregister");




    // query parameters
    char *keyQuery_devicetoken = NULL;
    char * valueQuery_devicetoken = NULL;
    keyValuePair_t *keyPairQuery_devicetoken = 0;
    if (devicetoken)
    {
        keyQuery_devicetoken = strdup("devicetoken");
        valueQuery_devicetoken = strdup((devicetoken));
        keyPairQuery_devicetoken = keyValuePair_create(keyQuery_devicetoken, valueQuery_devicetoken);
        list_addElement(localVarQueryParameters,keyPairQuery_devicetoken);
    }

    // query parameters
    char *keyQuery_platform = NULL;
    char * valueQuery_platform = NULL;
    keyValuePair_t *keyPairQuery_platform = 0;
    if (platform)
    {
        keyQuery_platform = strdup("platform");
        valueQuery_platform = strdup((platform));
        keyPairQuery_platform = keyValuePair_create(keyQuery_platform, valueQuery_platform);
        list_addElement(localVarQueryParameters,keyPairQuery_platform);
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
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(valueQuery_devicetoken){
        free(valueQuery_devicetoken);
        valueQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(valueQuery_platform){
        free(valueQuery_platform);
        valueQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }

}

// Print and email QR labels
//
// Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
//
void
DefaultAPI_qrlabelsprint(apiClient_t *apiClient, char * token , char * user , char * group )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/qrlabelsprint")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/qrlabelsprint");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    char *keyQuery_group = NULL;
    char * valueQuery_group ;
    keyValuePair_t *keyPairQuery_group = 0;
    if (group)
    {
        keyQuery_group = strdup("group");
        valueQuery_group = (group);
        keyPairQuery_group = keyValuePair_create(keyQuery_group, &valueQuery_group);
        list_addElement(localVarQueryParameters,keyPairQuery_group);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Gets an image of a QR token
//
void
DefaultAPI_qrloginget(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/qrloginget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/qrloginget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Login
//
void
DefaultAPI_qrloginlogin(apiClient_t *apiClient, char * onetimetoken )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/qrloginlogin")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/qrloginlogin");




    // query parameters
    char *keyQuery_onetimetoken = NULL;
    char * valueQuery_onetimetoken = NULL;
    keyValuePair_t *keyPairQuery_onetimetoken = 0;
    if (onetimetoken)
    {
        keyQuery_onetimetoken = strdup("onetimetoken");
        valueQuery_onetimetoken = strdup((onetimetoken));
        keyPairQuery_onetimetoken = keyValuePair_create(keyQuery_onetimetoken, valueQuery_onetimetoken);
        list_addElement(localVarQueryParameters,keyPairQuery_onetimetoken);
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
    if(keyQuery_onetimetoken){
        free(keyQuery_onetimetoken);
        keyQuery_onetimetoken = NULL;
    }
    if(valueQuery_onetimetoken){
        free(valueQuery_onetimetoken);
        valueQuery_onetimetoken = NULL;
    }
    if(keyPairQuery_onetimetoken){
        keyValuePair_free(keyPairQuery_onetimetoken);
        keyPairQuery_onetimetoken = NULL;
    }
    if(keyQuery_onetimetoken){
        free(keyQuery_onetimetoken);
        keyQuery_onetimetoken = NULL;
    }
    if(keyPairQuery_onetimetoken){
        keyValuePair_free(keyPairQuery_onetimetoken);
        keyPairQuery_onetimetoken = NULL;
    }

}

// Deletes a widget from the Quick Panel
//
// Allows the user to delete a widget that has been added to the Quick Panel.
//
void
DefaultAPI_quickpaneldeletewidget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpaneldeletewidget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpaneldeletewidget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Fetches the information for a specific widget.
//
void
DefaultAPI_quickpanelfetchwidget(apiClient_t *apiClient, char * token , char * widgetid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpanelfetchwidget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpanelfetchwidget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_widgetid = NULL;
    char * valueQuery_widgetid ;
    keyValuePair_t *keyPairQuery_widgetid = 0;
    if (widgetid)
    {
        keyQuery_widgetid = strdup("widgetid");
        valueQuery_widgetid = (widgetid);
        keyPairQuery_widgetid = keyValuePair_create(keyQuery_widgetid, &valueQuery_widgetid);
        list_addElement(localVarQueryParameters,keyPairQuery_widgetid);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View details of a widget included in the Quick Panel
//
// Allows the user to view a widget added in as Quick Panel.
//
void
DefaultAPI_quickpanelgetwidget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpanelgetwidget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpanelgetwidget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Returns the initial information required to show the quick panels
//
void
DefaultAPI_quickpanelinit(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpanelinit")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpanelinit");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Lists all the widgets that are added in the Quick Panel
//
// Allows the user to view the widgets that have been added to the Quick Panel.
//
void
DefaultAPI_quickpanellistwidgets(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpanellistwidgets")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpanellistwidgets");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Lists all the widget types available in the system
//
void
DefaultAPI_quickpanellistwidgettypes(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpanellistwidgettypes")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpanellistwidgettypes");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Reorders the widgets and moves them to a specific column
//
void
DefaultAPI_quickpanelreorderwidgets(apiClient_t *apiClient, char * token , char * sectionname , char * orderids )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpanelreorderwidgets")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpanelreorderwidgets");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_sectionname = NULL;
    char * valueQuery_sectionname = NULL;
    keyValuePair_t *keyPairQuery_sectionname = 0;
    if (sectionname)
    {
        keyQuery_sectionname = strdup("sectionname");
        valueQuery_sectionname = strdup((sectionname));
        keyPairQuery_sectionname = keyValuePair_create(keyQuery_sectionname, valueQuery_sectionname);
        list_addElement(localVarQueryParameters,keyPairQuery_sectionname);
    }

    // query parameters
    char *keyQuery_orderids = NULL;
    char * valueQuery_orderids = NULL;
    keyValuePair_t *keyPairQuery_orderids = 0;
    if (orderids)
    {
        keyQuery_orderids = strdup("orderids");
        valueQuery_orderids = strdup((orderids));
        keyPairQuery_orderids = keyValuePair_create(keyQuery_orderids, valueQuery_orderids);
        list_addElement(localVarQueryParameters,keyPairQuery_orderids);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_sectionname){
        free(keyQuery_sectionname);
        keyQuery_sectionname = NULL;
    }
    if(valueQuery_sectionname){
        free(valueQuery_sectionname);
        valueQuery_sectionname = NULL;
    }
    if(keyPairQuery_sectionname){
        keyValuePair_free(keyPairQuery_sectionname);
        keyPairQuery_sectionname = NULL;
    }
    if(keyQuery_sectionname){
        free(keyQuery_sectionname);
        keyQuery_sectionname = NULL;
    }
    if(keyPairQuery_sectionname){
        keyValuePair_free(keyPairQuery_sectionname);
        keyPairQuery_sectionname = NULL;
    }
    if(keyQuery_orderids){
        free(keyQuery_orderids);
        keyQuery_orderids = NULL;
    }
    if(valueQuery_orderids){
        free(valueQuery_orderids);
        valueQuery_orderids = NULL;
    }
    if(keyPairQuery_orderids){
        keyValuePair_free(keyPairQuery_orderids);
        keyPairQuery_orderids = NULL;
    }
    if(keyQuery_orderids){
        free(keyQuery_orderids);
        keyQuery_orderids = NULL;
    }
    if(keyPairQuery_orderids){
        keyValuePair_free(keyPairQuery_orderids);
        keyPairQuery_orderids = NULL;
    }

}

// Saves a widget for the Quick Panel
//
// Allows the user to save a widget to the Quick Panel.
//
void
DefaultAPI_quickpanelsavewidget(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/quickpanelsavewidget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/quickpanelsavewidget");




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

// View a list of available reports
//
// Allows the user to view the complete list of available, canned reports.
//
void
DefaultAPI_reportlist(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/reportlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/reportlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Permissions by user report
//
// Lists all the users in the system including their corresponding permissions.
//
void
DefaultAPI_reportpermissionsbyuser(apiClient_t *apiClient, char * token , char * params )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/reportpermissionsbyuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/reportpermissionsbyuser");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_params = NULL;
    char * valueQuery_params = NULL;
    keyValuePair_t *keyPairQuery_params = 0;
    if (params)
    {
        keyQuery_params = strdup("params");
        valueQuery_params = strdup((params));
        keyPairQuery_params = keyValuePair_create(keyQuery_params, valueQuery_params);
        list_addElement(localVarQueryParameters,keyPairQuery_params);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_params){
        free(keyQuery_params);
        keyQuery_params = NULL;
    }
    if(valueQuery_params){
        free(valueQuery_params);
        valueQuery_params = NULL;
    }
    if(keyPairQuery_params){
        keyValuePair_free(keyPairQuery_params);
        keyPairQuery_params = NULL;
    }
    if(keyQuery_params){
        free(keyQuery_params);
        keyQuery_params = NULL;
    }
    if(keyPairQuery_params){
        keyValuePair_free(keyPairQuery_params);
        keyPairQuery_params = NULL;
    }

}

// Queries and loads the specified report, in background.
//
// Allows the user to run reports, in background, with the exception of attendance analytics reports.
//
void
DefaultAPI_reportprepare(apiClient_t *apiClient, char * token , char * reportname , char * params , char * repformat , char * fillgroupid , char * groupby , char * refreshgroup , char * filtertext )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/reportprepare")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/reportprepare");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_reportname = NULL;
    char * valueQuery_reportname = NULL;
    keyValuePair_t *keyPairQuery_reportname = 0;
    if (reportname)
    {
        keyQuery_reportname = strdup("reportname");
        valueQuery_reportname = strdup((reportname));
        keyPairQuery_reportname = keyValuePair_create(keyQuery_reportname, valueQuery_reportname);
        list_addElement(localVarQueryParameters,keyPairQuery_reportname);
    }

    // query parameters
    char *keyQuery_params = NULL;
    char * valueQuery_params = NULL;
    keyValuePair_t *keyPairQuery_params = 0;
    if (params)
    {
        keyQuery_params = strdup("params");
        valueQuery_params = strdup((params));
        keyPairQuery_params = keyValuePair_create(keyQuery_params, valueQuery_params);
        list_addElement(localVarQueryParameters,keyPairQuery_params);
    }

    // query parameters
    char *keyQuery_repformat = NULL;
    char * valueQuery_repformat = NULL;
    keyValuePair_t *keyPairQuery_repformat = 0;
    if (repformat)
    {
        keyQuery_repformat = strdup("repformat");
        valueQuery_repformat = strdup((repformat));
        keyPairQuery_repformat = keyValuePair_create(keyQuery_repformat, valueQuery_repformat);
        list_addElement(localVarQueryParameters,keyPairQuery_repformat);
    }

    // query parameters
    char *keyQuery_fillgroupid = NULL;
    char * valueQuery_fillgroupid ;
    keyValuePair_t *keyPairQuery_fillgroupid = 0;
    if (fillgroupid)
    {
        keyQuery_fillgroupid = strdup("fillgroupid");
        valueQuery_fillgroupid = (fillgroupid);
        keyPairQuery_fillgroupid = keyValuePair_create(keyQuery_fillgroupid, &valueQuery_fillgroupid);
        list_addElement(localVarQueryParameters,keyPairQuery_fillgroupid);
    }

    // query parameters
    char *keyQuery_groupby = NULL;
    char * valueQuery_groupby = NULL;
    keyValuePair_t *keyPairQuery_groupby = 0;
    if (groupby)
    {
        keyQuery_groupby = strdup("groupby");
        valueQuery_groupby = strdup((groupby));
        keyPairQuery_groupby = keyValuePair_create(keyQuery_groupby, valueQuery_groupby);
        list_addElement(localVarQueryParameters,keyPairQuery_groupby);
    }

    // query parameters
    char *keyQuery_refreshgroup = NULL;
    char * valueQuery_refreshgroup ;
    keyValuePair_t *keyPairQuery_refreshgroup = 0;
    if (refreshgroup)
    {
        keyQuery_refreshgroup = strdup("refreshgroup");
        valueQuery_refreshgroup = (refreshgroup);
        keyPairQuery_refreshgroup = keyValuePair_create(keyQuery_refreshgroup, &valueQuery_refreshgroup);
        list_addElement(localVarQueryParameters,keyPairQuery_refreshgroup);
    }

    // query parameters
    char *keyQuery_filtertext = NULL;
    char * valueQuery_filtertext = NULL;
    keyValuePair_t *keyPairQuery_filtertext = 0;
    if (filtertext)
    {
        keyQuery_filtertext = strdup("filtertext");
        valueQuery_filtertext = strdup((filtertext));
        keyPairQuery_filtertext = keyValuePair_create(keyQuery_filtertext, valueQuery_filtertext);
        list_addElement(localVarQueryParameters,keyPairQuery_filtertext);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_reportname){
        free(keyQuery_reportname);
        keyQuery_reportname = NULL;
    }
    if(valueQuery_reportname){
        free(valueQuery_reportname);
        valueQuery_reportname = NULL;
    }
    if(keyPairQuery_reportname){
        keyValuePair_free(keyPairQuery_reportname);
        keyPairQuery_reportname = NULL;
    }
    if(keyQuery_reportname){
        free(keyQuery_reportname);
        keyQuery_reportname = NULL;
    }
    if(keyPairQuery_reportname){
        keyValuePair_free(keyPairQuery_reportname);
        keyPairQuery_reportname = NULL;
    }
    if(keyQuery_params){
        free(keyQuery_params);
        keyQuery_params = NULL;
    }
    if(valueQuery_params){
        free(valueQuery_params);
        valueQuery_params = NULL;
    }
    if(keyPairQuery_params){
        keyValuePair_free(keyPairQuery_params);
        keyPairQuery_params = NULL;
    }
    if(keyQuery_params){
        free(keyQuery_params);
        keyQuery_params = NULL;
    }
    if(keyPairQuery_params){
        keyValuePair_free(keyPairQuery_params);
        keyPairQuery_params = NULL;
    }
    if(keyQuery_repformat){
        free(keyQuery_repformat);
        keyQuery_repformat = NULL;
    }
    if(valueQuery_repformat){
        free(valueQuery_repformat);
        valueQuery_repformat = NULL;
    }
    if(keyPairQuery_repformat){
        keyValuePair_free(keyPairQuery_repformat);
        keyPairQuery_repformat = NULL;
    }
    if(keyQuery_repformat){
        free(keyQuery_repformat);
        keyQuery_repformat = NULL;
    }
    if(keyPairQuery_repformat){
        keyValuePair_free(keyPairQuery_repformat);
        keyPairQuery_repformat = NULL;
    }
    if(keyQuery_groupby){
        free(keyQuery_groupby);
        keyQuery_groupby = NULL;
    }
    if(valueQuery_groupby){
        free(valueQuery_groupby);
        valueQuery_groupby = NULL;
    }
    if(keyPairQuery_groupby){
        keyValuePair_free(keyPairQuery_groupby);
        keyPairQuery_groupby = NULL;
    }
    if(keyQuery_groupby){
        free(keyQuery_groupby);
        keyQuery_groupby = NULL;
    }
    if(keyPairQuery_groupby){
        keyValuePair_free(keyPairQuery_groupby);
        keyPairQuery_groupby = NULL;
    }
    if(keyQuery_filtertext){
        free(keyQuery_filtertext);
        keyQuery_filtertext = NULL;
    }
    if(valueQuery_filtertext){
        free(valueQuery_filtertext);
        valueQuery_filtertext = NULL;
    }
    if(keyPairQuery_filtertext){
        keyValuePair_free(keyPairQuery_filtertext);
        keyPairQuery_filtertext = NULL;
    }
    if(keyQuery_filtertext){
        free(keyQuery_filtertext);
        keyQuery_filtertext = NULL;
    }
    if(keyPairQuery_filtertext){
        keyValuePair_free(keyPairQuery_filtertext);
        keyPairQuery_filtertext = NULL;
    }

}

// Query and load a specified report
//
// Allows the user to run reports with the exception of attendance analytics reports.
//
void
DefaultAPI_reportquery(apiClient_t *apiClient, char * token , char * reportname , char * params )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/reportquery")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/reportquery");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_reportname = NULL;
    char * valueQuery_reportname = NULL;
    keyValuePair_t *keyPairQuery_reportname = 0;
    if (reportname)
    {
        keyQuery_reportname = strdup("reportname");
        valueQuery_reportname = strdup((reportname));
        keyPairQuery_reportname = keyValuePair_create(keyQuery_reportname, valueQuery_reportname);
        list_addElement(localVarQueryParameters,keyPairQuery_reportname);
    }

    // query parameters
    char *keyQuery_params = NULL;
    char * valueQuery_params = NULL;
    keyValuePair_t *keyPairQuery_params = 0;
    if (params)
    {
        keyQuery_params = strdup("params");
        valueQuery_params = strdup((params));
        keyPairQuery_params = keyValuePair_create(keyQuery_params, valueQuery_params);
        list_addElement(localVarQueryParameters,keyPairQuery_params);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_reportname){
        free(keyQuery_reportname);
        keyQuery_reportname = NULL;
    }
    if(valueQuery_reportname){
        free(valueQuery_reportname);
        valueQuery_reportname = NULL;
    }
    if(keyPairQuery_reportname){
        keyValuePair_free(keyPairQuery_reportname);
        keyPairQuery_reportname = NULL;
    }
    if(keyQuery_reportname){
        free(keyQuery_reportname);
        keyQuery_reportname = NULL;
    }
    if(keyPairQuery_reportname){
        keyValuePair_free(keyPairQuery_reportname);
        keyPairQuery_reportname = NULL;
    }
    if(keyQuery_params){
        free(keyQuery_params);
        keyQuery_params = NULL;
    }
    if(valueQuery_params){
        free(valueQuery_params);
        valueQuery_params = NULL;
    }
    if(keyPairQuery_params){
        keyValuePair_free(keyPairQuery_params);
        keyPairQuery_params = NULL;
    }
    if(keyQuery_params){
        free(keyQuery_params);
        keyQuery_params = NULL;
    }
    if(keyPairQuery_params){
        keyValuePair_free(keyPairQuery_params);
        keyPairQuery_params = NULL;
    }

}

// Show a list of roles
//
void
DefaultAPI_rolelist(apiClient_t *apiClient, char * token , char * name )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rolelist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rolelist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_name = NULL;
    char * valueQuery_name = NULL;
    keyValuePair_t *keyPairQuery_name = 0;
    if (name)
    {
        keyQuery_name = strdup("name");
        valueQuery_name = strdup((name));
        keyPairQuery_name = keyValuePair_create(keyQuery_name, valueQuery_name);
        list_addElement(localVarQueryParameters,keyPairQuery_name);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_name){
        free(keyQuery_name);
        keyQuery_name = NULL;
    }
    if(valueQuery_name){
        free(valueQuery_name);
        valueQuery_name = NULL;
    }
    if(keyPairQuery_name){
        keyValuePair_free(keyPairQuery_name);
        keyPairQuery_name = NULL;
    }
    if(keyQuery_name){
        free(keyQuery_name);
        keyQuery_name = NULL;
    }
    if(keyPairQuery_name){
        keyValuePair_free(keyPairQuery_name);
        keyPairQuery_name = NULL;
    }

}

// Delete a rule
//
// Allows the user to delete an existing rule.
//
void
DefaultAPI_ruledelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/ruledelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/ruledelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View details of a rule
//
// Allows the user to view an individual rule and its details.
//
void
DefaultAPI_ruleget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/ruleget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/ruleget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View details of a rule event type
//
// Allows the user to view the trigger and its available conditions for the rule.
//
void
DefaultAPI_rulegeteventtype(apiClient_t *apiClient, char * token , char * event )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rulegeteventtype")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rulegeteventtype");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_event = NULL;
    char * valueQuery_event = NULL;
    keyValuePair_t *keyPairQuery_event = 0;
    if (event)
    {
        keyQuery_event = strdup("event");
        valueQuery_event = strdup((event));
        keyPairQuery_event = keyValuePair_create(keyQuery_event, valueQuery_event);
        list_addElement(localVarQueryParameters,keyPairQuery_event);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_event){
        free(keyQuery_event);
        keyQuery_event = NULL;
    }
    if(valueQuery_event){
        free(valueQuery_event);
        valueQuery_event = NULL;
    }
    if(keyPairQuery_event){
        keyValuePair_free(keyPairQuery_event);
        keyPairQuery_event = NULL;
    }
    if(keyQuery_event){
        free(keyQuery_event);
        keyQuery_event = NULL;
    }
    if(keyPairQuery_event){
        keyValuePair_free(keyPairQuery_event);
        keyPairQuery_event = NULL;
    }

}

// View a list of user rules
//
// Allows the user to view the list of all rules.
//
void
DefaultAPI_rulelist(apiClient_t *apiClient, char * token , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rulelist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rulelist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of rule actions available
//
// Allows the user to view all the available rule actions.
//
void
DefaultAPI_rulelistactions(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rulelistactions")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rulelistactions");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of rule event types
//
// Allows the user to view a list of available triggers for rules.
//
void
DefaultAPI_rulelisteventtypes(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rulelisteventtypes")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rulelisteventtypes");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View all the http requests sent as a result of a rule
//
void
DefaultAPI_rulelisthttprequests(apiClient_t *apiClient, char * token , int from , int count , int failed , int status )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rulelisthttprequests")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rulelisthttprequests");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_failed = NULL;
    int valueQuery_failed ;
    keyValuePair_t *keyPairQuery_failed = 0;
    if (failed)
    {
        keyQuery_failed = strdup("failed");
        valueQuery_failed = (failed);
        keyPairQuery_failed = keyValuePair_create(keyQuery_failed, &valueQuery_failed);
        list_addElement(localVarQueryParameters,keyPairQuery_failed);
    }

    // query parameters
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a rule
//
// Allows the user to create or edit a rule.
//
void
DefaultAPI_rulesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rulesave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rulesave");




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

// Search
//
void
DefaultAPI_search(apiClient_t *apiClient, char * token , char * query , int page )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/search")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/search");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_query = NULL;
    char * valueQuery_query = NULL;
    keyValuePair_t *keyPairQuery_query = 0;
    if (query)
    {
        keyQuery_query = strdup("query");
        valueQuery_query = strdup((query));
        keyPairQuery_query = keyValuePair_create(keyQuery_query, valueQuery_query);
        list_addElement(localVarQueryParameters,keyPairQuery_query);
    }

    // query parameters
    char *keyQuery_page = NULL;
    int valueQuery_page ;
    keyValuePair_t *keyPairQuery_page = 0;
    if (page)
    {
        keyQuery_page = strdup("page");
        valueQuery_page = (page);
        keyPairQuery_page = keyValuePair_create(keyQuery_page, &valueQuery_page);
        list_addElement(localVarQueryParameters,keyPairQuery_page);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_query){
        free(keyQuery_query);
        keyQuery_query = NULL;
    }
    if(valueQuery_query){
        free(valueQuery_query);
        valueQuery_query = NULL;
    }
    if(keyPairQuery_query){
        keyValuePair_free(keyPairQuery_query);
        keyPairQuery_query = NULL;
    }
    if(keyQuery_query){
        free(keyQuery_query);
        keyQuery_query = NULL;
    }
    if(keyPairQuery_query){
        keyValuePair_free(keyPairQuery_query);
        keyPairQuery_query = NULL;
    }

}

// Get the information of the entities that can be searched
//
void
DefaultAPI_searchgetentities(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/searchgetentities")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/searchgetentities");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Returns the list of users for a specific permission
//
void
DefaultAPI_securityassesspermission(apiClient_t *apiClient, char * token , char * commandname )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/securityassesspermission")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/securityassesspermission");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_commandname = NULL;
    char * valueQuery_commandname = NULL;
    keyValuePair_t *keyPairQuery_commandname = 0;
    if (commandname)
    {
        keyQuery_commandname = strdup("commandname");
        valueQuery_commandname = strdup((commandname));
        keyPairQuery_commandname = keyValuePair_create(keyQuery_commandname, valueQuery_commandname);
        list_addElement(localVarQueryParameters,keyPairQuery_commandname);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_commandname){
        free(keyQuery_commandname);
        keyQuery_commandname = NULL;
    }
    if(valueQuery_commandname){
        free(valueQuery_commandname);
        valueQuery_commandname = NULL;
    }
    if(keyPairQuery_commandname){
        keyValuePair_free(keyPairQuery_commandname);
        keyPairQuery_commandname = NULL;
    }
    if(keyQuery_commandname){
        free(keyQuery_commandname);
        keyQuery_commandname = NULL;
    }
    if(keyPairQuery_commandname){
        keyValuePair_free(keyPairQuery_commandname);
        keyPairQuery_commandname = NULL;
    }

}

// Returns the list of permissions for a specific role
//
void
DefaultAPI_securityassessrole(apiClient_t *apiClient, char * token , char * roleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/securityassessrole")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/securityassessrole");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Returns the list of users for a specific user
//
void
DefaultAPI_securityassessscope(apiClient_t *apiClient, char * token , char * locationid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/securityassessscope")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/securityassessscope");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Returns the list of permissions for a specific user
//
void
DefaultAPI_securityassessuser(apiClient_t *apiClient, char * token , char * userid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/securityassessuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/securityassessuser");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Register current user to an event session
//
// Allows the user to register themselves for an event.
//
void
DefaultAPI_sessionregaddcurrentuser(apiClient_t *apiClient, char * token , char * eventid , char sessiondate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionregaddcurrentuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionregaddcurrentuser");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_sessiondate = NULL;
    char valueQuery_sessiondate ;
    keyValuePair_t *keyPairQuery_sessiondate = 0;
    if (sessiondate)
    {
        keyQuery_sessiondate = strdup("sessiondate");
        valueQuery_sessiondate = (sessiondate);
        keyPairQuery_sessiondate = keyValuePair_create(keyQuery_sessiondate, &valueQuery_sessiondate);
        list_addElement(localVarQueryParameters,keyPairQuery_sessiondate);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Register users for events
//
// Allows the user to register another user for an upcoming event.
//
void
DefaultAPI_sessionregadduser(apiClient_t *apiClient, char * token , char * userid , char * eventid , char sessiondate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionregadduser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionregadduser");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_sessiondate = NULL;
    char valueQuery_sessiondate ;
    keyValuePair_t *keyPairQuery_sessiondate = 0;
    if (sessiondate)
    {
        keyQuery_sessiondate = strdup("sessiondate");
        valueQuery_sessiondate = (sessiondate);
        keyPairQuery_sessiondate = keyValuePair_create(keyQuery_sessiondate, &valueQuery_sessiondate);
        list_addElement(localVarQueryParameters,keyPairQuery_sessiondate);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View all the sessions the logged user is registered to
//
void
DefaultAPI_sessionreggetmysessions(apiClient_t *apiClient, char * token , char date )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionreggetmysessions")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionreggetmysessions");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_date = NULL;
    char valueQuery_date ;
    keyValuePair_t *keyPairQuery_date = 0;
    if (date)
    {
        keyQuery_date = strdup("date");
        valueQuery_date = (date);
        keyPairQuery_date = keyValuePair_create(keyQuery_date, &valueQuery_date);
        list_addElement(localVarQueryParameters,keyPairQuery_date);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Lists the registrations for a specific user
//
// Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.
//
void
DefaultAPI_sessionreggetsessions(apiClient_t *apiClient, char * token , char * userid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionreggetsessions")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionreggetsessions");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Get the settings for session registration
//
// Allows the user to view a event's session registration settings.
//
void
DefaultAPI_sessionreggetsettings(apiClient_t *apiClient, char * token , char * locationid , char * eventid , char sessiondate , int noinherit )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionreggetsettings")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionreggetsettings");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_sessiondate = NULL;
    char valueQuery_sessiondate ;
    keyValuePair_t *keyPairQuery_sessiondate = 0;
    if (sessiondate)
    {
        keyQuery_sessiondate = strdup("sessiondate");
        valueQuery_sessiondate = (sessiondate);
        keyPairQuery_sessiondate = keyValuePair_create(keyQuery_sessiondate, &valueQuery_sessiondate);
        list_addElement(localVarQueryParameters,keyPairQuery_sessiondate);
    }

    // query parameters
    char *keyQuery_noinherit = NULL;
    int valueQuery_noinherit ;
    keyValuePair_t *keyPairQuery_noinherit = 0;
    if (noinherit)
    {
        keyQuery_noinherit = strdup("noinherit");
        valueQuery_noinherit = (noinherit);
        keyPairQuery_noinherit = keyValuePair_create(keyQuery_noinherit, &valueQuery_noinherit);
        list_addElement(localVarQueryParameters,keyPairQuery_noinherit);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Lists the registrations for a specific session
//
// Allows the user to view the registration for a specified event session.
//
void
DefaultAPI_sessionreggetusers(apiClient_t *apiClient, char * token , char * eventid , char sessiondate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionreggetusers")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionreggetusers");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_sessiondate = NULL;
    char valueQuery_sessiondate ;
    keyValuePair_t *keyPairQuery_sessiondate = 0;
    if (sessiondate)
    {
        keyQuery_sessiondate = strdup("sessiondate");
        valueQuery_sessiondate = (sessiondate);
        keyPairQuery_sessiondate = keyValuePair_create(keyQuery_sessiondate, &valueQuery_sessiondate);
        list_addElement(localVarQueryParameters,keyPairQuery_sessiondate);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// List the sessions available for a specific event
//
// Allows the user to view all the sessions available for a recurring event.
//
void
DefaultAPI_sessionreglistsessions(apiClient_t *apiClient, char * token , char * eventid , char sessiondate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionreglistsessions")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionreglistsessions");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_sessiondate = NULL;
    char valueQuery_sessiondate ;
    keyValuePair_t *keyPairQuery_sessiondate = 0;
    if (sessiondate)
    {
        keyQuery_sessiondate = strdup("sessiondate");
        valueQuery_sessiondate = (sessiondate);
        keyPairQuery_sessiondate = keyValuePair_create(keyQuery_sessiondate, &valueQuery_sessiondate);
        list_addElement(localVarQueryParameters,keyPairQuery_sessiondate);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of upcoming event sessions
//
// Allows the user to view the full list of upcoming events.
//
void
DefaultAPI_sessionreglistupcoming(apiClient_t *apiClient, char * token , char date )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionreglistupcoming")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionreglistupcoming");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_date = NULL;
    char valueQuery_date ;
    keyValuePair_t *keyPairQuery_date = 0;
    if (date)
    {
        keyQuery_date = strdup("date");
        valueQuery_date = (date);
        keyPairQuery_date = keyValuePair_create(keyQuery_date, &valueQuery_date);
        list_addElement(localVarQueryParameters,keyPairQuery_date);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of upcoming sessions of a particular event
//
// Allows the user to view the upcoming recurring sessions of a specified event.
//
void
DefaultAPI_sessionreglistupcomingevent(apiClient_t *apiClient, char * token , char date , char * event )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionreglistupcomingevent")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionreglistupcomingevent");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_date = NULL;
    char valueQuery_date ;
    keyValuePair_t *keyPairQuery_date = 0;
    if (date)
    {
        keyQuery_date = strdup("date");
        valueQuery_date = (date);
        keyPairQuery_date = keyValuePair_create(keyQuery_date, &valueQuery_date);
        list_addElement(localVarQueryParameters,keyPairQuery_date);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Unregister current user from an event session
//
// Allows the user to un-register themselves from an event.
//
void
DefaultAPI_sessionregremovecurrentuser(apiClient_t *apiClient, char * token , char * eventid , char sessiondate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionregremovecurrentuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionregremovecurrentuser");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_sessiondate = NULL;
    char valueQuery_sessiondate ;
    keyValuePair_t *keyPairQuery_sessiondate = 0;
    if (sessiondate)
    {
        keyQuery_sessiondate = strdup("sessiondate");
        valueQuery_sessiondate = (sessiondate);
        keyPairQuery_sessiondate = keyValuePair_create(keyQuery_sessiondate, &valueQuery_sessiondate);
        list_addElement(localVarQueryParameters,keyPairQuery_sessiondate);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Removes a user from an event session
//
// Allows the user to un-register another user from an event.
//
void
DefaultAPI_sessionregremoveuser(apiClient_t *apiClient, char * token , char * userid , char * eventid , char sessiondate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionregremoveuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionregremoveuser");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_sessiondate = NULL;
    char valueQuery_sessiondate ;
    keyValuePair_t *keyPairQuery_sessiondate = 0;
    if (sessiondate)
    {
        keyQuery_sessiondate = strdup("sessiondate");
        valueQuery_sessiondate = (sessiondate);
        keyPairQuery_sessiondate = keyValuePair_create(keyQuery_sessiondate, &valueQuery_sessiondate);
        list_addElement(localVarQueryParameters,keyPairQuery_sessiondate);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Save the settings for an event's session registration
//
// Allows the user to save the settings for an event.
//
void
DefaultAPI_sessionregsavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sessionregsavesettings")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sessionregsavesettings");




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

// Add a logo to the account
//
// Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.
//
void
DefaultAPI_settingaddlogo(apiClient_t *apiClient, char * token , char * upload , char * filename )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/settingaddlogo")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/settingaddlogo");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_upload = NULL;
    char * valueQuery_upload = NULL;
    keyValuePair_t *keyPairQuery_upload = 0;
    if (upload)
    {
        keyQuery_upload = strdup("upload");
        valueQuery_upload = strdup((upload));
        keyPairQuery_upload = keyValuePair_create(keyQuery_upload, valueQuery_upload);
        list_addElement(localVarQueryParameters,keyPairQuery_upload);
    }

    // query parameters
    char *keyQuery_filename = NULL;
    char * valueQuery_filename = NULL;
    keyValuePair_t *keyPairQuery_filename = 0;
    if (filename)
    {
        keyQuery_filename = strdup("filename");
        valueQuery_filename = strdup((filename));
        keyPairQuery_filename = keyValuePair_create(keyQuery_filename, valueQuery_filename);
        list_addElement(localVarQueryParameters,keyPairQuery_filename);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(valueQuery_upload){
        free(valueQuery_upload);
        valueQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(valueQuery_filename){
        free(valueQuery_filename);
        valueQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }

}

// Get settings for the account or the specified scope
//
void
DefaultAPI_settingget(apiClient_t *apiClient, char * keys , char * token , char * domain , char * scope )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/settingget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/settingget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_domain = NULL;
    char * valueQuery_domain = NULL;
    keyValuePair_t *keyPairQuery_domain = 0;
    if (domain)
    {
        keyQuery_domain = strdup("domain");
        valueQuery_domain = strdup((domain));
        keyPairQuery_domain = keyValuePair_create(keyQuery_domain, valueQuery_domain);
        list_addElement(localVarQueryParameters,keyPairQuery_domain);
    }

    // query parameters
    char *keyQuery_keys = NULL;
    char * valueQuery_keys = NULL;
    keyValuePair_t *keyPairQuery_keys = 0;
    if (keys)
    {
        keyQuery_keys = strdup("keys");
        valueQuery_keys = strdup((keys));
        keyPairQuery_keys = keyValuePair_create(keyQuery_keys, valueQuery_keys);
        list_addElement(localVarQueryParameters,keyPairQuery_keys);
    }

    // query parameters
    char *keyQuery_scope = NULL;
    char * valueQuery_scope = NULL;
    keyValuePair_t *keyPairQuery_scope = 0;
    if (scope)
    {
        keyQuery_scope = strdup("scope");
        valueQuery_scope = strdup((scope));
        keyPairQuery_scope = keyValuePair_create(keyQuery_scope, valueQuery_scope);
        list_addElement(localVarQueryParameters,keyPairQuery_scope);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(valueQuery_domain){
        free(valueQuery_domain);
        valueQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(valueQuery_keys){
        free(valueQuery_keys);
        valueQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }
    if(keyQuery_scope){
        free(keyQuery_scope);
        keyQuery_scope = NULL;
    }
    if(valueQuery_scope){
        free(valueQuery_scope);
        valueQuery_scope = NULL;
    }
    if(keyPairQuery_scope){
        keyValuePair_free(keyPairQuery_scope);
        keyPairQuery_scope = NULL;
    }
    if(keyQuery_scope){
        free(keyQuery_scope);
        keyQuery_scope = NULL;
    }
    if(keyPairQuery_scope){
        keyValuePair_free(keyPairQuery_scope);
        keyPairQuery_scope = NULL;
    }

}

// Save settings for the account or the specified scope
//
// Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.
//
void
DefaultAPI_settingsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/settingsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/settingsave");




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

// View general settings for the account
//
// Allows the user to view the settings' general section.
//
void
DefaultAPI_settingviewgeneral(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/settingviewgeneral")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/settingviewgeneral");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Generate/reset single sign on access key.
//
// Allows the user to generate or reset the access key for single sign-on.
//
void
DefaultAPI_ssogeneratekey(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/ssogeneratekey")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/ssogeneratekey");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View single sign on settings.
//
// Allows the user to view settings for single sign-on.
//
void
DefaultAPI_ssogetsettings(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/ssogetsettings")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/ssogetsettings");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Issue single sign-on token
//
void
DefaultAPI_ssoissuetoken(apiClient_t *apiClient, char * key , char * username , int expires )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/ssoissuetoken")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/ssoissuetoken");




    // query parameters
    char *keyQuery_key = NULL;
    char * valueQuery_key = NULL;
    keyValuePair_t *keyPairQuery_key = 0;
    if (key)
    {
        keyQuery_key = strdup("key");
        valueQuery_key = strdup((key));
        keyPairQuery_key = keyValuePair_create(keyQuery_key, valueQuery_key);
        list_addElement(localVarQueryParameters,keyPairQuery_key);
    }

    // query parameters
    char *keyQuery_username = NULL;
    char * valueQuery_username = NULL;
    keyValuePair_t *keyPairQuery_username = 0;
    if (username)
    {
        keyQuery_username = strdup("username");
        valueQuery_username = strdup((username));
        keyPairQuery_username = keyValuePair_create(keyQuery_username, valueQuery_username);
        list_addElement(localVarQueryParameters,keyPairQuery_username);
    }

    // query parameters
    char *keyQuery_expires = NULL;
    int valueQuery_expires ;
    keyValuePair_t *keyPairQuery_expires = 0;
    if (expires)
    {
        keyQuery_expires = strdup("expires");
        valueQuery_expires = (expires);
        keyPairQuery_expires = keyValuePair_create(keyQuery_expires, &valueQuery_expires);
        list_addElement(localVarQueryParameters,keyPairQuery_expires);
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
    if(keyQuery_key){
        free(keyQuery_key);
        keyQuery_key = NULL;
    }
    if(valueQuery_key){
        free(valueQuery_key);
        valueQuery_key = NULL;
    }
    if(keyPairQuery_key){
        keyValuePair_free(keyPairQuery_key);
        keyPairQuery_key = NULL;
    }
    if(keyQuery_key){
        free(keyQuery_key);
        keyQuery_key = NULL;
    }
    if(keyPairQuery_key){
        keyValuePair_free(keyPairQuery_key);
        keyPairQuery_key = NULL;
    }
    if(keyQuery_username){
        free(keyQuery_username);
        keyQuery_username = NULL;
    }
    if(valueQuery_username){
        free(valueQuery_username);
        valueQuery_username = NULL;
    }
    if(keyPairQuery_username){
        keyValuePair_free(keyPairQuery_username);
        keyPairQuery_username = NULL;
    }
    if(keyQuery_username){
        free(keyQuery_username);
        keyQuery_username = NULL;
    }
    if(keyPairQuery_username){
        keyValuePair_free(keyPairQuery_username);
        keyPairQuery_username = NULL;
    }

}

// Edit single sign-on settings.
//
// Allows the user to edit settings for single sign-on.
//
void
DefaultAPI_ssosavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/ssosavesettings")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/ssosavesettings");




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

// Delete a sign-in station
//
// Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.
//
void
DefaultAPI_stationdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View details of a sign-in station
//
// Allows the user to view an individual sign-in station and its details.
//
void
DefaultAPI_stationget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Get all the current terms
//
void
DefaultAPI_stationgetcurrentterms(apiClient_t *apiClient, char * station )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationgetcurrentterms")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationgetcurrentterms");




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

// Gets a the info to display in the sign-in station by it's ID.
//
void
DefaultAPI_stationgetinfo(apiClient_t *apiClient, char * id , char * event )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationgetinfo")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationgetinfo");




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

// Gets the current license information
//
void
DefaultAPI_stationgetlicense(apiClient_t *apiClient, char * station )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationgetlicense")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationgetlicense");




    // query parameters
    char *keyQuery_station = NULL;
    char * valueQuery_station = NULL;
    keyValuePair_t *keyPairQuery_station = 0;
    if (station)
    {
        keyQuery_station = strdup("station");
        valueQuery_station = strdup((station));
        keyPairQuery_station = keyValuePair_create(keyQuery_station, valueQuery_station);
        list_addElement(localVarQueryParameters,keyPairQuery_station);
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
    if(keyQuery_station){
        free(keyQuery_station);
        keyQuery_station = NULL;
    }
    if(valueQuery_station){
        free(valueQuery_station);
        valueQuery_station = NULL;
    }
    if(keyPairQuery_station){
        keyValuePair_free(keyPairQuery_station);
        keyPairQuery_station = NULL;
    }
    if(keyQuery_station){
        free(keyQuery_station);
        keyQuery_station = NULL;
    }
    if(keyPairQuery_station){
        keyValuePair_free(keyPairQuery_station);
        keyPairQuery_station = NULL;
    }

}

// View a list of sign-in stations
//
// Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.
//
void
DefaultAPI_stationlist(apiClient_t *apiClient, char * token , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a sign-in station
//
// Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.
//
void
DefaultAPI_stationsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationsave");




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

// Unlocks the sign-in station.
//
void
DefaultAPI_stationunlock(apiClient_t *apiClient, char * id , char * passcode , char * method )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/stationunlock")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/stationunlock");




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
    char *keyQuery_passcode = NULL;
    char * valueQuery_passcode = NULL;
    keyValuePair_t *keyPairQuery_passcode = 0;
    if (passcode)
    {
        keyQuery_passcode = strdup("passcode");
        valueQuery_passcode = strdup((passcode));
        keyPairQuery_passcode = keyValuePair_create(keyQuery_passcode, valueQuery_passcode);
        list_addElement(localVarQueryParameters,keyPairQuery_passcode);
    }

    // query parameters
    char *keyQuery_method = NULL;
    char * valueQuery_method = NULL;
    keyValuePair_t *keyPairQuery_method = 0;
    if (method)
    {
        keyQuery_method = strdup("method");
        valueQuery_method = strdup((method));
        keyPairQuery_method = keyValuePair_create(keyQuery_method, valueQuery_method);
        list_addElement(localVarQueryParameters,keyPairQuery_method);
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
    if(keyQuery_passcode){
        free(keyQuery_passcode);
        keyQuery_passcode = NULL;
    }
    if(valueQuery_passcode){
        free(valueQuery_passcode);
        valueQuery_passcode = NULL;
    }
    if(keyPairQuery_passcode){
        keyValuePair_free(keyPairQuery_passcode);
        keyPairQuery_passcode = NULL;
    }
    if(keyQuery_passcode){
        free(keyQuery_passcode);
        keyQuery_passcode = NULL;
    }
    if(keyPairQuery_passcode){
        keyValuePair_free(keyPairQuery_passcode);
        keyPairQuery_passcode = NULL;
    }
    if(keyQuery_method){
        free(keyQuery_method);
        keyQuery_method = NULL;
    }
    if(valueQuery_method){
        free(valueQuery_method);
        valueQuery_method = NULL;
    }
    if(keyPairQuery_method){
        keyValuePair_free(keyPairQuery_method);
        keyPairQuery_method = NULL;
    }
    if(keyQuery_method){
        free(keyQuery_method);
        keyQuery_method = NULL;
    }
    if(keyPairQuery_method){
        keyValuePair_free(keyPairQuery_method);
        keyPairQuery_method = NULL;
    }

}

// Delete a swipe
//
// Allows the user to delete an existing attendance swipe.
//
void
DefaultAPI_swipedelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/swipedelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/swipedelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of a swipe
//
// Allows the user to view an individual attendance swipe.
//
void
DefaultAPI_swipeget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/swipeget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/swipeget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of swipes
//
// Allows the user to view a list of all swipes for the location or locations in which the user is scoped.
//
void
DefaultAPI_swipelist(apiClient_t *apiClient, int from , int count , char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/swipelist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/swipelist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a swipe, and if possible, save the related attendance log
//
// Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.
//
void
DefaultAPI_swipesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/swipesave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/swipesave");




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

// Creates a new swipe from a sign-in station, and if possible, creates the attendance log
//
void
DefaultAPI_swipesaveanonym(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/swipesaveanonym")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/swipesaveanonym");




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

// Delete a tag
//
// Allows the user to delete an existing tag.
//
void
DefaultAPI_tagdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/tagdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/tagdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View details of a specified tag
//
// Allows the user to click on and view the settings for a tag.
//
void
DefaultAPI_tagget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/tagget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/tagget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of tags
//
// Allows the user to view the list of tags.
//
void
DefaultAPI_taglist(apiClient_t *apiClient, char * token , char * group , int from , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/taglist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/taglist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_group = NULL;
    char * valueQuery_group = NULL;
    keyValuePair_t *keyPairQuery_group = 0;
    if (group)
    {
        keyQuery_group = strdup("group");
        valueQuery_group = strdup((group));
        keyPairQuery_group = keyValuePair_create(keyQuery_group, valueQuery_group);
        list_addElement(localVarQueryParameters,keyPairQuery_group);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_group){
        free(keyQuery_group);
        keyQuery_group = NULL;
    }
    if(valueQuery_group){
        free(valueQuery_group);
        valueQuery_group = NULL;
    }
    if(keyPairQuery_group){
        keyValuePair_free(keyPairQuery_group);
        keyPairQuery_group = NULL;
    }
    if(keyQuery_group){
        free(keyQuery_group);
        keyQuery_group = NULL;
    }
    if(keyPairQuery_group){
        keyValuePair_free(keyPairQuery_group);
        keyPairQuery_group = NULL;
    }

}

// View a list of entities that can be tagged
//
// Allows the user to view the list of user roles that can be tagged, according to that tag's settings.
//
void
DefaultAPI_taglistgroups(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/taglistgroups")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/taglistgroups");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a tag
//
// Allows the user to create or edit a tag.
//
void
DefaultAPI_tagsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/tagsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/tagsave");




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

// Search for tags in the account
//
// Allows the user to search for tags.
//
void
DefaultAPI_tagsearch(apiClient_t *apiClient, char * token , char * query , int allowcreatingnew )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/tagsearch")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/tagsearch");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_query = NULL;
    char * valueQuery_query = NULL;
    keyValuePair_t *keyPairQuery_query = 0;
    if (query)
    {
        keyQuery_query = strdup("query");
        valueQuery_query = strdup((query));
        keyPairQuery_query = keyValuePair_create(keyQuery_query, valueQuery_query);
        list_addElement(localVarQueryParameters,keyPairQuery_query);
    }

    // query parameters
    char *keyQuery_allowcreatingnew = NULL;
    int valueQuery_allowcreatingnew ;
    keyValuePair_t *keyPairQuery_allowcreatingnew = 0;
    if (allowcreatingnew)
    {
        keyQuery_allowcreatingnew = strdup("allowcreatingnew");
        valueQuery_allowcreatingnew = (allowcreatingnew);
        keyPairQuery_allowcreatingnew = keyValuePair_create(keyQuery_allowcreatingnew, &valueQuery_allowcreatingnew);
        list_addElement(localVarQueryParameters,keyPairQuery_allowcreatingnew);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_query){
        free(keyQuery_query);
        keyQuery_query = NULL;
    }
    if(valueQuery_query){
        free(valueQuery_query);
        valueQuery_query = NULL;
    }
    if(keyPairQuery_query){
        keyValuePair_free(keyPairQuery_query);
        keyPairQuery_query = NULL;
    }
    if(keyQuery_query){
        free(keyQuery_query);
        keyQuery_query = NULL;
    }
    if(keyPairQuery_query){
        keyValuePair_free(keyPairQuery_query);
        keyPairQuery_query = NULL;
    }

}

// Add an image to a template
//
// Allows the user to add an image to a badge or certificate template.
//
void
DefaultAPI_templateaddimage(apiClient_t *apiClient, char * token , char * template , char * upload , char * filename )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templateaddimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templateaddimage");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_template = NULL;
    char * valueQuery_template ;
    keyValuePair_t *keyPairQuery_template = 0;
    if (template)
    {
        keyQuery_template = strdup("template");
        valueQuery_template = (template);
        keyPairQuery_template = keyValuePair_create(keyQuery_template, &valueQuery_template);
        list_addElement(localVarQueryParameters,keyPairQuery_template);
    }

    // query parameters
    char *keyQuery_upload = NULL;
    char * valueQuery_upload = NULL;
    keyValuePair_t *keyPairQuery_upload = 0;
    if (upload)
    {
        keyQuery_upload = strdup("upload");
        valueQuery_upload = strdup((upload));
        keyPairQuery_upload = keyValuePair_create(keyQuery_upload, valueQuery_upload);
        list_addElement(localVarQueryParameters,keyPairQuery_upload);
    }

    // query parameters
    char *keyQuery_filename = NULL;
    char * valueQuery_filename = NULL;
    keyValuePair_t *keyPairQuery_filename = 0;
    if (filename)
    {
        keyQuery_filename = strdup("filename");
        valueQuery_filename = strdup((filename));
        keyPairQuery_filename = keyValuePair_create(keyQuery_filename, valueQuery_filename);
        list_addElement(localVarQueryParameters,keyPairQuery_filename);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(valueQuery_upload){
        free(valueQuery_upload);
        valueQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(valueQuery_filename){
        free(valueQuery_filename);
        valueQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }

}

// Delete a template
//
// Allows the user to delete an existing template.
//
void
DefaultAPI_templatedelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templatedelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templatedelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Send generated templates by email
//
// Allows the user to send generated templates via email through AccuCampus.
//
void
DefaultAPI_templateemail(apiClient_t *apiClient, char * token , char * jobid , char * emailsubject , char * emailbody , char * templatekind , char * emailfrom , char * emailreplyto )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templateemail")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templateemail");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_jobid = NULL;
    char * valueQuery_jobid = NULL;
    keyValuePair_t *keyPairQuery_jobid = 0;
    if (jobid)
    {
        keyQuery_jobid = strdup("jobid");
        valueQuery_jobid = strdup((jobid));
        keyPairQuery_jobid = keyValuePair_create(keyQuery_jobid, valueQuery_jobid);
        list_addElement(localVarQueryParameters,keyPairQuery_jobid);
    }

    // query parameters
    char *keyQuery_templatekind = NULL;
    char * valueQuery_templatekind = NULL;
    keyValuePair_t *keyPairQuery_templatekind = 0;
    if (templatekind)
    {
        keyQuery_templatekind = strdup("templatekind");
        valueQuery_templatekind = strdup((templatekind));
        keyPairQuery_templatekind = keyValuePair_create(keyQuery_templatekind, valueQuery_templatekind);
        list_addElement(localVarQueryParameters,keyPairQuery_templatekind);
    }

    // query parameters
    char *keyQuery_emailfrom = NULL;
    char * valueQuery_emailfrom = NULL;
    keyValuePair_t *keyPairQuery_emailfrom = 0;
    if (emailfrom)
    {
        keyQuery_emailfrom = strdup("emailfrom");
        valueQuery_emailfrom = strdup((emailfrom));
        keyPairQuery_emailfrom = keyValuePair_create(keyQuery_emailfrom, valueQuery_emailfrom);
        list_addElement(localVarQueryParameters,keyPairQuery_emailfrom);
    }

    // query parameters
    char *keyQuery_emailreplyto = NULL;
    char * valueQuery_emailreplyto = NULL;
    keyValuePair_t *keyPairQuery_emailreplyto = 0;
    if (emailreplyto)
    {
        keyQuery_emailreplyto = strdup("emailreplyto");
        valueQuery_emailreplyto = strdup((emailreplyto));
        keyPairQuery_emailreplyto = keyValuePair_create(keyQuery_emailreplyto, valueQuery_emailreplyto);
        list_addElement(localVarQueryParameters,keyPairQuery_emailreplyto);
    }

    // query parameters
    char *keyQuery_emailsubject = NULL;
    char * valueQuery_emailsubject = NULL;
    keyValuePair_t *keyPairQuery_emailsubject = 0;
    if (emailsubject)
    {
        keyQuery_emailsubject = strdup("emailsubject");
        valueQuery_emailsubject = strdup((emailsubject));
        keyPairQuery_emailsubject = keyValuePair_create(keyQuery_emailsubject, valueQuery_emailsubject);
        list_addElement(localVarQueryParameters,keyPairQuery_emailsubject);
    }

    // query parameters
    char *keyQuery_emailbody = NULL;
    char * valueQuery_emailbody = NULL;
    keyValuePair_t *keyPairQuery_emailbody = 0;
    if (emailbody)
    {
        keyQuery_emailbody = strdup("emailbody");
        valueQuery_emailbody = strdup((emailbody));
        keyPairQuery_emailbody = keyValuePair_create(keyQuery_emailbody, valueQuery_emailbody);
        list_addElement(localVarQueryParameters,keyPairQuery_emailbody);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(valueQuery_jobid){
        free(valueQuery_jobid);
        valueQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }
    if(keyQuery_templatekind){
        free(keyQuery_templatekind);
        keyQuery_templatekind = NULL;
    }
    if(valueQuery_templatekind){
        free(valueQuery_templatekind);
        valueQuery_templatekind = NULL;
    }
    if(keyPairQuery_templatekind){
        keyValuePair_free(keyPairQuery_templatekind);
        keyPairQuery_templatekind = NULL;
    }
    if(keyQuery_templatekind){
        free(keyQuery_templatekind);
        keyQuery_templatekind = NULL;
    }
    if(keyPairQuery_templatekind){
        keyValuePair_free(keyPairQuery_templatekind);
        keyPairQuery_templatekind = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(valueQuery_emailfrom){
        free(valueQuery_emailfrom);
        valueQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailreplyto){
        free(keyQuery_emailreplyto);
        keyQuery_emailreplyto = NULL;
    }
    if(valueQuery_emailreplyto){
        free(valueQuery_emailreplyto);
        valueQuery_emailreplyto = NULL;
    }
    if(keyPairQuery_emailreplyto){
        keyValuePair_free(keyPairQuery_emailreplyto);
        keyPairQuery_emailreplyto = NULL;
    }
    if(keyQuery_emailreplyto){
        free(keyQuery_emailreplyto);
        keyQuery_emailreplyto = NULL;
    }
    if(keyPairQuery_emailreplyto){
        keyValuePair_free(keyPairQuery_emailreplyto);
        keyPairQuery_emailreplyto = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(valueQuery_emailsubject){
        free(valueQuery_emailsubject);
        valueQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(valueQuery_emailbody){
        free(valueQuery_emailbody);
        valueQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }

}

// Generate specified templates
//
// Allows the user to generate an existing template as badges or certificates.
//
void
DefaultAPI_templategenerate(apiClient_t *apiClient, char * token , char * template , char * source , int singlefile , char * userid , int forsending , char * role , char * filters )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templategenerate")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templategenerate");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_template = NULL;
    char * valueQuery_template ;
    keyValuePair_t *keyPairQuery_template = 0;
    if (template)
    {
        keyQuery_template = strdup("template");
        valueQuery_template = (template);
        keyPairQuery_template = keyValuePair_create(keyQuery_template, &valueQuery_template);
        list_addElement(localVarQueryParameters,keyPairQuery_template);
    }

    // query parameters
    char *keyQuery_source = NULL;
    char * valueQuery_source ;
    keyValuePair_t *keyPairQuery_source = 0;
    if (source)
    {
        keyQuery_source = strdup("source");
        valueQuery_source = (source);
        keyPairQuery_source = keyValuePair_create(keyQuery_source, &valueQuery_source);
        list_addElement(localVarQueryParameters,keyPairQuery_source);
    }

    // query parameters
    char *keyQuery_singlefile = NULL;
    int valueQuery_singlefile ;
    keyValuePair_t *keyPairQuery_singlefile = 0;
    if (singlefile)
    {
        keyQuery_singlefile = strdup("singlefile");
        valueQuery_singlefile = (singlefile);
        keyPairQuery_singlefile = keyValuePair_create(keyQuery_singlefile, &valueQuery_singlefile);
        list_addElement(localVarQueryParameters,keyPairQuery_singlefile);
    }

    // query parameters
    char *keyQuery_userid = NULL;
    char * valueQuery_userid = NULL;
    keyValuePair_t *keyPairQuery_userid = 0;
    if (userid)
    {
        keyQuery_userid = strdup("userid");
        valueQuery_userid = strdup((userid));
        keyPairQuery_userid = keyValuePair_create(keyQuery_userid, valueQuery_userid);
        list_addElement(localVarQueryParameters,keyPairQuery_userid);
    }

    // query parameters
    char *keyQuery_forsending = NULL;
    int valueQuery_forsending ;
    keyValuePair_t *keyPairQuery_forsending = 0;
    if (forsending)
    {
        keyQuery_forsending = strdup("forsending");
        valueQuery_forsending = (forsending);
        keyPairQuery_forsending = keyValuePair_create(keyQuery_forsending, &valueQuery_forsending);
        list_addElement(localVarQueryParameters,keyPairQuery_forsending);
    }

    // query parameters
    char *keyQuery_role = NULL;
    char * valueQuery_role ;
    keyValuePair_t *keyPairQuery_role = 0;
    if (role)
    {
        keyQuery_role = strdup("role");
        valueQuery_role = (role);
        keyPairQuery_role = keyValuePair_create(keyQuery_role, &valueQuery_role);
        list_addElement(localVarQueryParameters,keyPairQuery_role);
    }

    // query parameters
    char *keyQuery_filters = NULL;
    char * valueQuery_filters = NULL;
    keyValuePair_t *keyPairQuery_filters = 0;
    if (filters)
    {
        keyQuery_filters = strdup("filters");
        valueQuery_filters = strdup((filters));
        keyPairQuery_filters = keyValuePair_create(keyQuery_filters, valueQuery_filters);
        list_addElement(localVarQueryParameters,keyPairQuery_filters);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_userid){
        free(keyQuery_userid);
        keyQuery_userid = NULL;
    }
    if(valueQuery_userid){
        free(valueQuery_userid);
        valueQuery_userid = NULL;
    }
    if(keyPairQuery_userid){
        keyValuePair_free(keyPairQuery_userid);
        keyPairQuery_userid = NULL;
    }
    if(keyQuery_userid){
        free(keyQuery_userid);
        keyQuery_userid = NULL;
    }
    if(keyPairQuery_userid){
        keyValuePair_free(keyPairQuery_userid);
        keyPairQuery_userid = NULL;
    }
    if(keyQuery_filters){
        free(keyQuery_filters);
        keyQuery_filters = NULL;
    }
    if(valueQuery_filters){
        free(valueQuery_filters);
        valueQuery_filters = NULL;
    }
    if(keyPairQuery_filters){
        keyValuePair_free(keyPairQuery_filters);
        keyPairQuery_filters = NULL;
    }
    if(keyQuery_filters){
        free(keyQuery_filters);
        keyQuery_filters = NULL;
    }
    if(keyPairQuery_filters){
        keyValuePair_free(keyPairQuery_filters);
        keyPairQuery_filters = NULL;
    }

}

// View details of a template
//
// Allows the user to view a template and its details.
//
void
DefaultAPI_templateget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templateget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templateget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View generated templates
//
// Allows the user to view templates which have been generated as badges or certificates.
//
void
DefaultAPI_templategetgenerated(apiClient_t *apiClient, char * token , char * jobid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templategetgenerated")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templategetgenerated");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_jobid = NULL;
    char * valueQuery_jobid = NULL;
    keyValuePair_t *keyPairQuery_jobid = 0;
    if (jobid)
    {
        keyQuery_jobid = strdup("jobid");
        valueQuery_jobid = strdup((jobid));
        keyPairQuery_jobid = keyValuePair_create(keyQuery_jobid, valueQuery_jobid);
        list_addElement(localVarQueryParameters,keyPairQuery_jobid);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(valueQuery_jobid){
        free(valueQuery_jobid);
        valueQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }

}

// View a list of defined templates
//
// Allows the user to view the full list of created templates.
//
void
DefaultAPI_templatelist(apiClient_t *apiClient, char * token , int from , int count , char * kind , int designedonly )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templatelist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templatelist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_kind = NULL;
    char * valueQuery_kind = NULL;
    keyValuePair_t *keyPairQuery_kind = 0;
    if (kind)
    {
        keyQuery_kind = strdup("kind");
        valueQuery_kind = strdup((kind));
        keyPairQuery_kind = keyValuePair_create(keyQuery_kind, valueQuery_kind);
        list_addElement(localVarQueryParameters,keyPairQuery_kind);
    }

    // query parameters
    char *keyQuery_designedonly = NULL;
    int valueQuery_designedonly ;
    keyValuePair_t *keyPairQuery_designedonly = 0;
    if (designedonly)
    {
        keyQuery_designedonly = strdup("designedonly");
        valueQuery_designedonly = (designedonly);
        keyPairQuery_designedonly = keyValuePair_create(keyQuery_designedonly, &valueQuery_designedonly);
        list_addElement(localVarQueryParameters,keyPairQuery_designedonly);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(valueQuery_kind){
        free(valueQuery_kind);
        valueQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }

}

// View a list of templates' data sources
//
// Allows the user to see tokens to be used in the template
//
void
DefaultAPI_templatelistsources(apiClient_t *apiClient, char * token , char * kind )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templatelistsources")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templatelistsources");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_kind = NULL;
    char * valueQuery_kind = NULL;
    keyValuePair_t *keyPairQuery_kind = 0;
    if (kind)
    {
        keyQuery_kind = strdup("kind");
        valueQuery_kind = strdup((kind));
        keyPairQuery_kind = keyValuePair_create(keyQuery_kind, valueQuery_kind);
        list_addElement(localVarQueryParameters,keyPairQuery_kind);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(valueQuery_kind){
        free(valueQuery_kind);
        valueQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }

}

// Create or edit a template
//
// Allows the user to create or edit a template.
//
void
DefaultAPI_templatesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templatesave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templatesave");




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

// Save the layout of a template
//
// Allows the user to edit a template's layout.
//
void
DefaultAPI_templatesavelayout(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/templatesavelayout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/templatesavelayout");




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

// Delete a term
//
// Allows the user to delete a term from the existing list.
//
void
DefaultAPI_termdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/termdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/termdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of a term
//
// Allows the user to view a term and its details.
//
void
DefaultAPI_termget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/termget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/termget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of all terms
//
// Allows the user to view the full list of existing term.
//
void
DefaultAPI_termlist(apiClient_t *apiClient, char * token , int from , int count , int notpast )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/termlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/termlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_notpast = NULL;
    int valueQuery_notpast ;
    keyValuePair_t *keyPairQuery_notpast = 0;
    if (notpast)
    {
        keyQuery_notpast = strdup("notpast");
        valueQuery_notpast = (notpast);
        keyPairQuery_notpast = keyValuePair_create(keyQuery_notpast, &valueQuery_notpast);
        list_addElement(localVarQueryParameters,keyPairQuery_notpast);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create and edit terms
//
// Allows the user to create and edit terms.
//
void
DefaultAPI_termsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/termsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/termsave");




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

// Gets the remaining text credits for the account
//
void
DefaultAPI_textcreditremaining(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/textcreditremaining")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/textcreditremaining");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Generates a dynamic image from text
//
void
DefaultAPI_texttoimage(apiClient_t *apiClient, char * token , char * text , char * fontcolor , int fontsize , char * direction , int width )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/texttoimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/texttoimage");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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

    // query parameters
    char *keyQuery_fontcolor = NULL;
    char * valueQuery_fontcolor = NULL;
    keyValuePair_t *keyPairQuery_fontcolor = 0;
    if (fontcolor)
    {
        keyQuery_fontcolor = strdup("fontcolor");
        valueQuery_fontcolor = strdup((fontcolor));
        keyPairQuery_fontcolor = keyValuePair_create(keyQuery_fontcolor, valueQuery_fontcolor);
        list_addElement(localVarQueryParameters,keyPairQuery_fontcolor);
    }

    // query parameters
    char *keyQuery_fontsize = NULL;
    int valueQuery_fontsize ;
    keyValuePair_t *keyPairQuery_fontsize = 0;
    if (fontsize)
    {
        keyQuery_fontsize = strdup("fontsize");
        valueQuery_fontsize = (fontsize);
        keyPairQuery_fontsize = keyValuePair_create(keyQuery_fontsize, &valueQuery_fontsize);
        list_addElement(localVarQueryParameters,keyPairQuery_fontsize);
    }

    // query parameters
    char *keyQuery_direction = NULL;
    char * valueQuery_direction = NULL;
    keyValuePair_t *keyPairQuery_direction = 0;
    if (direction)
    {
        keyQuery_direction = strdup("direction");
        valueQuery_direction = strdup((direction));
        keyPairQuery_direction = keyValuePair_create(keyQuery_direction, valueQuery_direction);
        list_addElement(localVarQueryParameters,keyPairQuery_direction);
    }

    // query parameters
    char *keyQuery_width = NULL;
    int valueQuery_width ;
    keyValuePair_t *keyPairQuery_width = 0;
    if (width)
    {
        keyQuery_width = strdup("width");
        valueQuery_width = (width);
        keyPairQuery_width = keyValuePair_create(keyQuery_width, &valueQuery_width);
        list_addElement(localVarQueryParameters,keyPairQuery_width);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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
    if(keyQuery_fontcolor){
        free(keyQuery_fontcolor);
        keyQuery_fontcolor = NULL;
    }
    if(valueQuery_fontcolor){
        free(valueQuery_fontcolor);
        valueQuery_fontcolor = NULL;
    }
    if(keyPairQuery_fontcolor){
        keyValuePair_free(keyPairQuery_fontcolor);
        keyPairQuery_fontcolor = NULL;
    }
    if(keyQuery_fontcolor){
        free(keyQuery_fontcolor);
        keyQuery_fontcolor = NULL;
    }
    if(keyPairQuery_fontcolor){
        keyValuePair_free(keyPairQuery_fontcolor);
        keyPairQuery_fontcolor = NULL;
    }
    if(keyQuery_direction){
        free(keyQuery_direction);
        keyQuery_direction = NULL;
    }
    if(valueQuery_direction){
        free(valueQuery_direction);
        valueQuery_direction = NULL;
    }
    if(keyPairQuery_direction){
        keyValuePair_free(keyPairQuery_direction);
        keyPairQuery_direction = NULL;
    }
    if(keyQuery_direction){
        free(keyQuery_direction);
        keyQuery_direction = NULL;
    }
    if(keyPairQuery_direction){
        keyValuePair_free(keyPairQuery_direction);
        keyPairQuery_direction = NULL;
    }

}

// Gets the translations of the specified values
//
void
DefaultAPI_translationget(apiClient_t *apiClient, char * token , char * universal )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translationget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translationget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_universal = NULL;
    char * valueQuery_universal = NULL;
    keyValuePair_t *keyPairQuery_universal = 0;
    if (universal)
    {
        keyQuery_universal = strdup("universal");
        valueQuery_universal = strdup((universal));
        keyPairQuery_universal = keyValuePair_create(keyQuery_universal, valueQuery_universal);
        list_addElement(localVarQueryParameters,keyPairQuery_universal);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_universal){
        free(keyQuery_universal);
        keyQuery_universal = NULL;
    }
    if(valueQuery_universal){
        free(valueQuery_universal);
        valueQuery_universal = NULL;
    }
    if(keyPairQuery_universal){
        keyValuePair_free(keyPairQuery_universal);
        keyPairQuery_universal = NULL;
    }
    if(keyQuery_universal){
        free(keyQuery_universal);
        keyQuery_universal = NULL;
    }
    if(keyPairQuery_universal){
        keyValuePair_free(keyPairQuery_universal);
        keyPairQuery_universal = NULL;
    }

}

// Get the file containing the translations
//
void
DefaultAPI_translationgetcachefile(apiClient_t *apiClient, char * token , char * account )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translationgetcachefile")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translationgetcachefile");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_account = NULL;
    char * valueQuery_account = NULL;
    keyValuePair_t *keyPairQuery_account = 0;
    if (account)
    {
        keyQuery_account = strdup("account");
        valueQuery_account = strdup((account));
        keyPairQuery_account = keyValuePair_create(keyQuery_account, valueQuery_account);
        list_addElement(localVarQueryParameters,keyPairQuery_account);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_account){
        free(keyQuery_account);
        keyQuery_account = NULL;
    }
    if(valueQuery_account){
        free(valueQuery_account);
        valueQuery_account = NULL;
    }
    if(keyPairQuery_account){
        keyValuePair_free(keyPairQuery_account);
        keyPairQuery_account = NULL;
    }
    if(keyQuery_account){
        free(keyQuery_account);
        keyQuery_account = NULL;
    }
    if(keyPairQuery_account){
        keyValuePair_free(keyPairQuery_account);
        keyPairQuery_account = NULL;
    }

}

// Lists all the available translations in the system
//
void
DefaultAPI_translationlist(apiClient_t *apiClient, char * token , char * filter , int nondefaultonly , int appdefaultasuniversal )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translationlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translationlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_nondefaultonly = NULL;
    int valueQuery_nondefaultonly ;
    keyValuePair_t *keyPairQuery_nondefaultonly = 0;
    if (nondefaultonly)
    {
        keyQuery_nondefaultonly = strdup("nondefaultonly");
        valueQuery_nondefaultonly = (nondefaultonly);
        keyPairQuery_nondefaultonly = keyValuePair_create(keyQuery_nondefaultonly, &valueQuery_nondefaultonly);
        list_addElement(localVarQueryParameters,keyPairQuery_nondefaultonly);
    }

    // query parameters
    char *keyQuery_appdefaultasuniversal = NULL;
    int valueQuery_appdefaultasuniversal ;
    keyValuePair_t *keyPairQuery_appdefaultasuniversal = 0;
    if (appdefaultasuniversal)
    {
        keyQuery_appdefaultasuniversal = strdup("appdefaultasuniversal");
        valueQuery_appdefaultasuniversal = (appdefaultasuniversal);
        keyPairQuery_appdefaultasuniversal = keyValuePair_create(keyQuery_appdefaultasuniversal, &valueQuery_appdefaultasuniversal);
        list_addElement(localVarQueryParameters,keyPairQuery_appdefaultasuniversal);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
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

// Edit a translation
//
// Allows the user to edit a translation for the entire account.
//
void
DefaultAPI_translationsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translationsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translationsave");




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

// Change user's own password
//
// Allows the user to change their own password.
//
void
DefaultAPI_userchangepwd(apiClient_t *apiClient, char * token , char * oldpass , char * newpass )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userchangepwd")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userchangepwd");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_oldpass = NULL;
    char * valueQuery_oldpass ;
    keyValuePair_t *keyPairQuery_oldpass = 0;
    if (oldpass)
    {
        keyQuery_oldpass = strdup("oldpass");
        valueQuery_oldpass = (oldpass);
        keyPairQuery_oldpass = keyValuePair_create(keyQuery_oldpass, &valueQuery_oldpass);
        list_addElement(localVarQueryParameters,keyPairQuery_oldpass);
    }

    // query parameters
    char *keyQuery_newpass = NULL;
    char * valueQuery_newpass ;
    keyValuePair_t *keyPairQuery_newpass = 0;
    if (newpass)
    {
        keyQuery_newpass = strdup("newpass");
        valueQuery_newpass = (newpass);
        keyPairQuery_newpass = keyValuePair_create(keyQuery_newpass, &valueQuery_newpass);
        list_addElement(localVarQueryParameters,keyPairQuery_newpass);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Changes the user password using a change password request id
//
void
DefaultAPI_userchangepwdbyreq(apiClient_t *apiClient, char * changereq , char * newpass )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userchangepwdbyreq")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userchangepwdbyreq");




    // query parameters
    char *keyQuery_changereq = NULL;
    char * valueQuery_changereq = NULL;
    keyValuePair_t *keyPairQuery_changereq = 0;
    if (changereq)
    {
        keyQuery_changereq = strdup("changereq");
        valueQuery_changereq = strdup((changereq));
        keyPairQuery_changereq = keyValuePair_create(keyQuery_changereq, valueQuery_changereq);
        list_addElement(localVarQueryParameters,keyPairQuery_changereq);
    }

    // query parameters
    char *keyQuery_newpass = NULL;
    char * valueQuery_newpass = NULL;
    keyValuePair_t *keyPairQuery_newpass = 0;
    if (newpass)
    {
        keyQuery_newpass = strdup("newpass");
        valueQuery_newpass = strdup((newpass));
        keyPairQuery_newpass = keyValuePair_create(keyQuery_newpass, valueQuery_newpass);
        list_addElement(localVarQueryParameters,keyPairQuery_newpass);
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
    if(keyQuery_changereq){
        free(keyQuery_changereq);
        keyQuery_changereq = NULL;
    }
    if(valueQuery_changereq){
        free(valueQuery_changereq);
        valueQuery_changereq = NULL;
    }
    if(keyPairQuery_changereq){
        keyValuePair_free(keyPairQuery_changereq);
        keyPairQuery_changereq = NULL;
    }
    if(keyQuery_changereq){
        free(keyQuery_changereq);
        keyQuery_changereq = NULL;
    }
    if(keyPairQuery_changereq){
        keyValuePair_free(keyPairQuery_changereq);
        keyPairQuery_changereq = NULL;
    }
    if(keyQuery_newpass){
        free(keyQuery_newpass);
        keyQuery_newpass = NULL;
    }
    if(valueQuery_newpass){
        free(valueQuery_newpass);
        valueQuery_newpass = NULL;
    }
    if(keyPairQuery_newpass){
        keyValuePair_free(keyPairQuery_newpass);
        keyPairQuery_newpass = NULL;
    }
    if(keyQuery_newpass){
        free(keyQuery_newpass);
        keyQuery_newpass = NULL;
    }
    if(keyPairQuery_newpass){
        keyValuePair_free(keyPairQuery_newpass);
        keyPairQuery_newpass = NULL;
    }

}

// Delete a user
//
// Allows the user to delete a user.
//
void
DefaultAPI_userdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Finds similar users to prevent duplicates
//
// Allows the user to be warned if a user they are creating has the same card number as another user.
//
void
DefaultAPI_userfindsimilar(apiClient_t *apiClient, char * token , char * currentid , char * phonenumber , char * cardnumber )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userfindsimilar")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userfindsimilar");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_currentid = NULL;
    char * valueQuery_currentid ;
    keyValuePair_t *keyPairQuery_currentid = 0;
    if (currentid)
    {
        keyQuery_currentid = strdup("currentid");
        valueQuery_currentid = (currentid);
        keyPairQuery_currentid = keyValuePair_create(keyQuery_currentid, &valueQuery_currentid);
        list_addElement(localVarQueryParameters,keyPairQuery_currentid);
    }

    // query parameters
    char *keyQuery_phonenumber = NULL;
    char * valueQuery_phonenumber = NULL;
    keyValuePair_t *keyPairQuery_phonenumber = 0;
    if (phonenumber)
    {
        keyQuery_phonenumber = strdup("phonenumber");
        valueQuery_phonenumber = strdup((phonenumber));
        keyPairQuery_phonenumber = keyValuePair_create(keyQuery_phonenumber, valueQuery_phonenumber);
        list_addElement(localVarQueryParameters,keyPairQuery_phonenumber);
    }

    // query parameters
    char *keyQuery_cardnumber = NULL;
    char * valueQuery_cardnumber = NULL;
    keyValuePair_t *keyPairQuery_cardnumber = 0;
    if (cardnumber)
    {
        keyQuery_cardnumber = strdup("cardnumber");
        valueQuery_cardnumber = strdup((cardnumber));
        keyPairQuery_cardnumber = keyValuePair_create(keyQuery_cardnumber, valueQuery_cardnumber);
        list_addElement(localVarQueryParameters,keyPairQuery_cardnumber);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(valueQuery_phonenumber){
        free(valueQuery_phonenumber);
        valueQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }
    if(keyQuery_cardnumber){
        free(keyQuery_cardnumber);
        keyQuery_cardnumber = NULL;
    }
    if(valueQuery_cardnumber){
        free(valueQuery_cardnumber);
        valueQuery_cardnumber = NULL;
    }
    if(keyPairQuery_cardnumber){
        keyValuePair_free(keyPairQuery_cardnumber);
        keyPairQuery_cardnumber = NULL;
    }
    if(keyQuery_cardnumber){
        free(keyQuery_cardnumber);
        keyQuery_cardnumber = NULL;
    }
    if(keyPairQuery_cardnumber){
        keyValuePair_free(keyPairQuery_cardnumber);
        keyPairQuery_cardnumber = NULL;
    }

}

// Search and view details of a user
//
// Allows the user to search and view a user and their details.
//
void
DefaultAPI_userget(apiClient_t *apiClient, char * token , char * id , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search user by card number
//
// Allows the user to search for a user by their card number.
//
void
DefaultAPI_usergetbycard(apiClient_t *apiClient, char * token , char * card , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergetbycard")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergetbycard");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_card = NULL;
    char * valueQuery_card = NULL;
    keyValuePair_t *keyPairQuery_card = 0;
    if (card)
    {
        keyQuery_card = strdup("card");
        valueQuery_card = strdup((card));
        keyPairQuery_card = keyValuePair_create(keyQuery_card, valueQuery_card);
        list_addElement(localVarQueryParameters,keyPairQuery_card);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_card){
        free(keyQuery_card);
        keyQuery_card = NULL;
    }
    if(valueQuery_card){
        free(valueQuery_card);
        valueQuery_card = NULL;
    }
    if(keyPairQuery_card){
        keyValuePair_free(keyPairQuery_card);
        keyPairQuery_card = NULL;
    }
    if(keyQuery_card){
        free(keyQuery_card);
        keyQuery_card = NULL;
    }
    if(keyPairQuery_card){
        keyValuePair_free(keyPairQuery_card);
        keyPairQuery_card = NULL;
    }

}

// Add a user to a group
//
// Allows the user to add a user to a group that they have permission to edit.
//
void
DefaultAPI_usergroupaddmember(apiClient_t *apiClient, char * token , char * userid , char * groupid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergroupaddmember")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergroupaddmember");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Delete a group
//
// Allows the user to delete a group that they have permission to edit.
//
void
DefaultAPI_usergroupdelete(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergroupdelete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergroupdelete");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Search and view details of a user group
//
// Allows the user to view a user group and its details.
//
void
DefaultAPI_usergroupget(apiClient_t *apiClient, char * token , char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergroupget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergroupget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View the members of a user group
//
// Allows the user to view the list of users in a group that they have permission to view.
//
void
DefaultAPI_usergroupgetmembers(apiClient_t *apiClient, char * token , char * groupid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergroupgetmembers")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergroupgetmembers");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View the groups which a user is registered to
//
// Allows the user to view the groups an individual user is registered to, based on group and user permissions.
//
void
DefaultAPI_usergroupgetuser(apiClient_t *apiClient, char * token , char * userid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergroupgetuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergroupgetuser");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// View a list of user groups
//
// Allows the user to view the list of groups that they have permission to view.
//
void
DefaultAPI_usergrouplist(apiClient_t *apiClient, char * token , int from , int count , char * type )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergrouplist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergrouplist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_type = NULL;
    char * valueQuery_type = NULL;
    keyValuePair_t *keyPairQuery_type = 0;
    if (type)
    {
        keyQuery_type = strdup("type");
        valueQuery_type = strdup((type));
        keyPairQuery_type = keyValuePair_create(keyQuery_type, valueQuery_type);
        list_addElement(localVarQueryParameters,keyPairQuery_type);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(valueQuery_type){
        free(valueQuery_type);
        valueQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }

}

// Refresh the dynamic group
//
// Allows the user to refresh a dynamic group that they have permission to edit.
//
void
DefaultAPI_usergrouprefresh(apiClient_t *apiClient, char * token , char * group )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergrouprefresh")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergrouprefresh");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_group = NULL;
    char * valueQuery_group ;
    keyValuePair_t *keyPairQuery_group = 0;
    if (group)
    {
        keyQuery_group = strdup("group");
        valueQuery_group = (group);
        keyPairQuery_group = keyValuePair_create(keyQuery_group, &valueQuery_group);
        list_addElement(localVarQueryParameters,keyPairQuery_group);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Remove a user from a group
//
// Allows the user to remove a user from a group that they have permission to edit.
//
void
DefaultAPI_usergroupremovemember(apiClient_t *apiClient, char * token , char * userid , char * groupid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergroupremovemember")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergroupremovemember");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Create or edit a group
//
// Allows the user to create a new group or edit a group that they have permission to edit.
//
void
DefaultAPI_usergroupsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usergroupsave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usergroupsave");




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

// View a list of users
//
// Allows the user to view the full list of users and is based on role permissions.
//
void
DefaultAPI_userlist(apiClient_t *apiClient, char * token , int from , int count , char * roleid , char * onlywithoutcard , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userlist");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    char *keyQuery_onlywithoutcard = NULL;
    char * valueQuery_onlywithoutcard = NULL;
    keyValuePair_t *keyPairQuery_onlywithoutcard = 0;
    if (onlywithoutcard)
    {
        keyQuery_onlywithoutcard = strdup("onlywithoutcard");
        valueQuery_onlywithoutcard = strdup((onlywithoutcard));
        keyPairQuery_onlywithoutcard = keyValuePair_create(keyQuery_onlywithoutcard, valueQuery_onlywithoutcard);
        list_addElement(localVarQueryParameters,keyPairQuery_onlywithoutcard);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_onlywithoutcard){
        free(keyQuery_onlywithoutcard);
        keyQuery_onlywithoutcard = NULL;
    }
    if(valueQuery_onlywithoutcard){
        free(valueQuery_onlywithoutcard);
        valueQuery_onlywithoutcard = NULL;
    }
    if(keyPairQuery_onlywithoutcard){
        keyValuePair_free(keyPairQuery_onlywithoutcard);
        keyPairQuery_onlywithoutcard = NULL;
    }
    if(keyQuery_onlywithoutcard){
        free(keyQuery_onlywithoutcard);
        keyQuery_onlywithoutcard = NULL;
    }
    if(keyPairQuery_onlywithoutcard){
        keyValuePair_free(keyPairQuery_onlywithoutcard);
        keyPairQuery_onlywithoutcard = NULL;
    }

}

// Upload a photo for a specific user
//
// Allows the user to upload a photo for a user.
//
void
DefaultAPI_userloadphoto(apiClient_t *apiClient, char * token , char * upload , char * filename , char * userid , int automatch )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userloadphoto")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userloadphoto");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_upload = NULL;
    char * valueQuery_upload = NULL;
    keyValuePair_t *keyPairQuery_upload = 0;
    if (upload)
    {
        keyQuery_upload = strdup("upload");
        valueQuery_upload = strdup((upload));
        keyPairQuery_upload = keyValuePair_create(keyQuery_upload, valueQuery_upload);
        list_addElement(localVarQueryParameters,keyPairQuery_upload);
    }

    // query parameters
    char *keyQuery_filename = NULL;
    char * valueQuery_filename = NULL;
    keyValuePair_t *keyPairQuery_filename = 0;
    if (filename)
    {
        keyQuery_filename = strdup("filename");
        valueQuery_filename = strdup((filename));
        keyPairQuery_filename = keyValuePair_create(keyQuery_filename, valueQuery_filename);
        list_addElement(localVarQueryParameters,keyPairQuery_filename);
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

    // query parameters
    char *keyQuery_automatch = NULL;
    int valueQuery_automatch ;
    keyValuePair_t *keyPairQuery_automatch = 0;
    if (automatch)
    {
        keyQuery_automatch = strdup("automatch");
        valueQuery_automatch = (automatch);
        keyPairQuery_automatch = keyValuePair_create(keyQuery_automatch, &valueQuery_automatch);
        list_addElement(localVarQueryParameters,keyPairQuery_automatch);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(valueQuery_upload){
        free(valueQuery_upload);
        valueQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(valueQuery_filename){
        free(valueQuery_filename);
        valueQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }

}

// Move data between users
//
// Allows administrators to move data between users.
//
void
DefaultAPI_usermovedata(apiClient_t *apiClient, char * token , char * source , char * destination )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usermovedata")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usermovedata");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_source = NULL;
    char * valueQuery_source ;
    keyValuePair_t *keyPairQuery_source = 0;
    if (source)
    {
        keyQuery_source = strdup("source");
        valueQuery_source = (source);
        keyPairQuery_source = keyValuePair_create(keyQuery_source, &valueQuery_source);
        list_addElement(localVarQueryParameters,keyPairQuery_source);
    }

    // query parameters
    char *keyQuery_destination = NULL;
    char * valueQuery_destination ;
    keyValuePair_t *keyPairQuery_destination = 0;
    if (destination)
    {
        keyQuery_destination = strdup("destination");
        valueQuery_destination = (destination);
        keyPairQuery_destination = keyValuePair_create(keyQuery_destination, &valueQuery_destination);
        list_addElement(localVarQueryParameters,keyPairQuery_destination);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

// Requests a password change
//
void
DefaultAPI_userrequestpwdchange(apiClient_t *apiClient, char * domain , char * email )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/userrequestpwdchange")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/userrequestpwdchange");




    // query parameters
    char *keyQuery_domain = NULL;
    char * valueQuery_domain = NULL;
    keyValuePair_t *keyPairQuery_domain = 0;
    if (domain)
    {
        keyQuery_domain = strdup("domain");
        valueQuery_domain = strdup((domain));
        keyPairQuery_domain = keyValuePair_create(keyQuery_domain, valueQuery_domain);
        list_addElement(localVarQueryParameters,keyPairQuery_domain);
    }

    // query parameters
    char *keyQuery_email = NULL;
    char * valueQuery_email = NULL;
    keyValuePair_t *keyPairQuery_email = 0;
    if (email)
    {
        keyQuery_email = strdup("email");
        valueQuery_email = strdup((email));
        keyPairQuery_email = keyValuePair_create(keyQuery_email, valueQuery_email);
        list_addElement(localVarQueryParameters,keyPairQuery_email);
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
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(valueQuery_domain){
        free(valueQuery_domain);
        valueQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_email){
        free(keyQuery_email);
        keyQuery_email = NULL;
    }
    if(valueQuery_email){
        free(valueQuery_email);
        valueQuery_email = NULL;
    }
    if(keyPairQuery_email){
        keyValuePair_free(keyPairQuery_email);
        keyPairQuery_email = NULL;
    }
    if(keyQuery_email){
        free(keyQuery_email);
        keyQuery_email = NULL;
    }
    if(keyPairQuery_email){
        keyValuePair_free(keyPairQuery_email);
        keyPairQuery_email = NULL;
    }

}

// Create or edit a user
//
// Allows the user to create or edit a user.
//
void
DefaultAPI_usersave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersave");




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

// Send email to the specified user(s) to set/change their passwords
//
// Allows the user to trigger an email to another user asking them to set or change their password.
//
void
DefaultAPI_usersavepwdchange(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersavepwdchange")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersavepwdchange");




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

// Lists available user settings
//
void
DefaultAPI_usersettingsget(apiClient_t *apiClient, char * token , char * keys , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettingsget")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettingsget");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_keys = NULL;
    char * valueQuery_keys = NULL;
    keyValuePair_t *keyPairQuery_keys = 0;
    if (keys)
    {
        keyQuery_keys = strdup("keys");
        valueQuery_keys = strdup((keys));
        keyPairQuery_keys = keyValuePair_create(keyQuery_keys, valueQuery_keys);
        list_addElement(localVarQueryParameters,keyPairQuery_keys);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(valueQuery_keys){
        free(valueQuery_keys);
        valueQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }

}

// Get multiple user settings
//
void
DefaultAPI_usersettingsgetmultiple(apiClient_t *apiClient, char * token , char * keys , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettingsgetmultiple")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettingsgetmultiple");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
    }

    // query parameters
    char *keyQuery_keys = NULL;
    char * valueQuery_keys = NULL;
    keyValuePair_t *keyPairQuery_keys = 0;
    if (keys)
    {
        keyQuery_keys = strdup("keys");
        valueQuery_keys = strdup((keys));
        keyPairQuery_keys = keyValuePair_create(keyQuery_keys, valueQuery_keys);
        list_addElement(localVarQueryParameters,keyPairQuery_keys);
    }

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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(valueQuery_keys){
        free(valueQuery_keys);
        valueQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }

}

// Saves a user setting
//
void
DefaultAPI_usersettingssave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettingssave")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettingssave");




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

// Save multiple user settings at once
//
void
DefaultAPI_usersettingssavemultiple(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettingssavemultiple")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettingssavemultiple");




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

// Get current version information
//
void
DefaultAPI_version(apiClient_t *apiClient, char * token )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/version")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/version");




    // query parameters
    char *keyQuery_token = NULL;
    char * valueQuery_token = NULL;
    keyValuePair_t *keyPairQuery_token = 0;
    if (token)
    {
        keyQuery_token = strdup("token");
        valueQuery_token = strdup((token));
        keyPairQuery_token = keyValuePair_create(keyQuery_token, valueQuery_token);
        list_addElement(localVarQueryParameters,keyPairQuery_token);
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
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(valueQuery_token){
        free(valueQuery_token);
        valueQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }
    if(keyQuery_token){
        free(keyQuery_token);
        keyQuery_token = NULL;
    }
    if(keyPairQuery_token){
        keyValuePair_free(keyPairQuery_token);
        keyPairQuery_token = NULL;
    }

}

