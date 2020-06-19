#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "AppointmentAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Cancel an appointment
//
// Allows the user to cancel an appointment.
//
void
AppointmentAPI_appointmentCancel(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/cancel")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/cancel");




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

// Check if an appointment is valid or not
//
void
AppointmentAPI_appointmentCheckisvalid(apiClient_t *apiClient, char * id , int editing )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/checkisvalid")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/checkisvalid");




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
    char *keyQuery_editing = NULL;
    int valueQuery_editing ;
    keyValuePair_t *keyPairQuery_editing = 0;
    if (editing)
    {
        keyQuery_editing = strdup("editing");
        valueQuery_editing = (editing);
        keyPairQuery_editing = keyValuePair_create(keyQuery_editing, &valueQuery_editing);
        list_addElement(localVarQueryParameters,keyPairQuery_editing);
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

// Edit an appointment even if it breaks activated rules
//
// Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.
//
void
AppointmentAPI_appointmentEditanyway(apiClient_t *apiClient, char * id , char * attendee , char * staff , char * location , char start , char end , char * term , char * event , char * services , char * notes )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/editanyway")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/editanyway");




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
    char *keyQuery_start = NULL;
    char valueQuery_start ;
    keyValuePair_t *keyPairQuery_start = 0;
    if (start)
    {
        keyQuery_start = strdup("start");
        valueQuery_start = (start);
        keyPairQuery_start = keyValuePair_create(keyQuery_start, &valueQuery_start);
        list_addElement(localVarQueryParameters,keyPairQuery_start);
    }

    // query parameters
    char *keyQuery_end = NULL;
    char valueQuery_end ;
    keyValuePair_t *keyPairQuery_end = 0;
    if (end)
    {
        keyQuery_end = strdup("end");
        valueQuery_end = (end);
        keyPairQuery_end = keyValuePair_create(keyQuery_end, &valueQuery_end);
        list_addElement(localVarQueryParameters,keyPairQuery_end);
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
    char *keyQuery_notes = NULL;
    char * valueQuery_notes = NULL;
    keyValuePair_t *keyPairQuery_notes = 0;
    if (notes)
    {
        keyQuery_notes = strdup("notes");
        valueQuery_notes = strdup((notes));
        keyPairQuery_notes = keyValuePair_create(keyQuery_notes, valueQuery_notes);
        list_addElement(localVarQueryParameters,keyPairQuery_notes);
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
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(valueQuery_notes){
        free(valueQuery_notes);
        valueQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }

}

// Edit the no-show status of an appointment
//
// Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.
//
void
AppointmentAPI_appointmentEditpresence(apiClient_t *apiClient, char * id , int showedup )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/editpresence")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/editpresence");




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
    char *keyQuery_showedup = NULL;
    int valueQuery_showedup ;
    keyValuePair_t *keyPairQuery_showedup = 0;
    if (showedup)
    {
        keyQuery_showedup = strdup("showedup");
        valueQuery_showedup = (showedup);
        keyPairQuery_showedup = keyValuePair_create(keyQuery_showedup, &valueQuery_showedup);
        list_addElement(localVarQueryParameters,keyPairQuery_showedup);
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

// Finds all staff available slots filtered by service, date, etc
//
// Allows the user to view available appointment slots when creating an appointment.
//
void
AppointmentAPI_appointmentFindallstaffslots(apiClient_t *apiClient, char starttime , char endtime , char * serviceids , char * locationid , char * eventid , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/findallstaffslots")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/findallstaffslots");




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

}

// Finds available slots filtered by service, date, staff, etc
//
// Allows the user to view available appointment slots when creating an appointment.
//
void
AppointmentAPI_appointmentFindslots(apiClient_t *apiClient, char * staffid , char starttime , char endtime , char * serviceids , char * eventid , char * locationid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/findslots")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/findslots");




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

}

// Finds staff available by service, date, event, etc
//
// Allows the user to view staff availability when creating an appointment.
//
void
AppointmentAPI_appointmentFindstaff(apiClient_t *apiClient, char * serviceids , char starttime , char endtime , char * eventid , char * locationid , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/findstaff")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/findstaff");




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

}

// Search and view details of an appointment
//
// Allows the user to view an individual appointment and its details.
//
void
AppointmentAPI_appointmentGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/{id}");


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

// Get the current appointments for the user that is about to sign-in via the specified sign-in station.
//
void
AppointmentAPI_appointmentGetcurrent(apiClient_t *apiClient, char * station , char * user , char * location )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/getcurrent")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/getcurrent");




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

// Find locations where a service is available
//
// Allows the user to search for appointment availability by location or service.
//
void
AppointmentAPI_appointmentGetlocations(apiClient_t *apiClient, char * serviceid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/getlocations")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/getlocations");




    // query parameters
    char *keyQuery_serviceid = NULL;
    char * valueQuery_serviceid ;
    keyValuePair_t *keyPairQuery_serviceid = 0;
    if (serviceid)
    {
        keyQuery_serviceid = strdup("serviceid");
        valueQuery_serviceid = (serviceid);
        keyPairQuery_serviceid = keyValuePair_create(keyQuery_serviceid, &valueQuery_serviceid);
        list_addElement(localVarQueryParameters,keyPairQuery_serviceid);
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

// View a list of appointments
//
// Allows the user to view all upcoming appointments for the location or locations they are scoped to.
//
void
AppointmentAPI_appointmentList(apiClient_t *apiClient, int from , int count , char startdate , char enddate , char * userid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/list");




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

// View all my upcoming appointments
//
void
AppointmentAPI_appointmentListmine(apiClient_t *apiClient, char start , char modifiedafter )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/listmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/listmine");




    // query parameters
    char *keyQuery_start = NULL;
    char valueQuery_start ;
    keyValuePair_t *keyPairQuery_start = 0;
    if (start)
    {
        keyQuery_start = strdup("start");
        valueQuery_start = (start);
        keyPairQuery_start = keyValuePair_create(keyQuery_start, &valueQuery_start);
        list_addElement(localVarQueryParameters,keyPairQuery_start);
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

// Search and view details of all my upcoming appointments
//
// Allows the user to view all of their own upcoming appointments.
//
void
AppointmentAPI_appointmentListupcoming(apiClient_t *apiClient, char start , char modifiedafter )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/listupcoming")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/listupcoming");




    // query parameters
    char *keyQuery_start = NULL;
    char valueQuery_start ;
    keyValuePair_t *keyPairQuery_start = 0;
    if (start)
    {
        keyQuery_start = strdup("start");
        valueQuery_start = (start);
        keyPairQuery_start = keyValuePair_create(keyQuery_start, &valueQuery_start);
        list_addElement(localVarQueryParameters,keyPairQuery_start);
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

// Reschedule an appointment from MS Outlook.
//
// Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.
//
void
AppointmentAPI_appointmentRescheduleoutlook(apiClient_t *apiClient, char * id , char start , char end )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/rescheduleoutlook")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/rescheduleoutlook");




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
    char *keyQuery_start = NULL;
    char valueQuery_start ;
    keyValuePair_t *keyPairQuery_start = 0;
    if (start)
    {
        keyQuery_start = strdup("start");
        valueQuery_start = (start);
        keyPairQuery_start = keyValuePair_create(keyQuery_start, &valueQuery_start);
        list_addElement(localVarQueryParameters,keyPairQuery_start);
    }

    // query parameters
    char *keyQuery_end = NULL;
    char valueQuery_end ;
    keyValuePair_t *keyPairQuery_end = 0;
    if (end)
    {
        keyQuery_end = strdup("end");
        valueQuery_end = (end);
        keyPairQuery_end = keyValuePair_create(keyQuery_end, &valueQuery_end);
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

}

// Restore an appointment
//
// Allows the user to restore a canceled appointment.
//
void
AppointmentAPI_appointmentRestore(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/restore")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/restore");




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

// Restore an appointment even if it breaks activated rules
//
// Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.
//
void
AppointmentAPI_appointmentRestoreanyway(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/restoreanyway")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/restoreanyway");




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

// Schedule an appointment
//
// Allows the user to schedule an appointment within the rules of the location and the availability of staff members.
//
void
AppointmentAPI_appointmentSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/{id}");


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

// Schedule an appointment even if it breaks activated rules
//
// Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.
//
void
AppointmentAPI_appointmentSetasvalid(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/setasvalid")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/setasvalid");




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

// View the locations with most appointments
//
// Allows the user to view suggestions for the most popular locations in which to make appointments
//
void
AppointmentAPI_appointmentSuggestlocations(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/suggestlocations")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/suggestlocations");



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

// View the services with most appointments
//
// Allows the user to view suggestions for the most popular services for which to make appointments.
//
void
AppointmentAPI_appointmentSuggestservices(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/suggestservices")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/suggestservices");



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

// Void an appointment
//
// Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.
//
void
AppointmentAPI_appointmentVoid(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appointment/void")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appointment/void");




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

