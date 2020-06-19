#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ReportAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// View a list of available reports
//
// Allows the user to view the complete list of available, canned reports.
//
void
ReportAPI_reportList(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/report/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/report/list");



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

// Permissions by user report
//
// Lists all the users in the system including their corresponding permissions.
//
void
ReportAPI_reportPermissionsbyuser(apiClient_t *apiClient, char * params )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/report/permissionsbyuser")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/report/permissionsbyuser");




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
ReportAPI_reportPrepare(apiClient_t *apiClient, char * reportname , char * params , char * repformat , char * fillgroupid , char * groupby , char * refreshgroup , char * filtertext )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/report/prepare")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/report/prepare");




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
ReportAPI_reportQuery(apiClient_t *apiClient, char * reportname , char * params )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/report/query")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/report/query");




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

