#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "AdvroleAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Adds the missing permissions to a role. Requires access to advrole.save
//
void
AdvroleAPI_advroleAddmissing(apiClient_t *apiClient, char * roles , char * permissions )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/addmissing")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/addmissing");




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
AdvroleAPI_advroleCheckperm(apiClient_t *apiClient, char * roles , char * permissions )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/checkperm")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/checkperm");




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
AdvroleAPI_advroleDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/{id}");


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

// Delete a role mapping
//
// Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.
//
void
AdvroleAPI_advroleDeletemapping(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/deletemapping")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/deletemapping");




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

// View details of a role
//
// Allows the user to view a role and its details.
//
void
AdvroleAPI_advroleGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/{id}");


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

// Lists the roles for the current account
//
void
AdvroleAPI_advroleList(apiClient_t *apiClient, int includepolicies , int includeinternal , char * name )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/list");




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
AdvroleAPI_advroleListmaps(apiClient_t *apiClient, char * roleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/listmaps")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/listmaps");




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

}

// Lists the roles mappings
//
void
AdvroleAPI_advroleListrolesmapped(apiClient_t *apiClient, char * map )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/listrolesmapped")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/listrolesmapped");




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
AdvroleAPI_advroleListtemplates(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/listtemplates")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/listtemplates");



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

// Create or edit a role
//
// Allows the user to create or edit a role's permissions.
//
void
AdvroleAPI_advroleSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/{id}");


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

// Saves a role mapping
//
// Allows the user to add a role to a mapped category on the 'Role Mapping' page.
//
void
AdvroleAPI_advroleSavemapping(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/savemapping")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/savemapping");




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

// Upgrade a user to another role (requires permission to edit those roles)
//
// Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
//
void
AdvroleAPI_advroleUserupgrade(apiClient_t *apiClient, char * userid , char * roleid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advrole/userupgrade")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advrole/userupgrade");




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

}

