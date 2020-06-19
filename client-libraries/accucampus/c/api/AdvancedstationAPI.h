#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Check whether the user is known by the system.
//
void
AdvancedstationAPI_advancedstationCheckunknownuser(apiClient_t *apiClient, char * station , char * user , char * location );


// Check whether the user is a staff member, an attendee or both.
//
void
AdvancedstationAPI_advancedstationCheckuserrole(apiClient_t *apiClient, char * station , char * user , char * location );


// Creates a user via a sign-in station.
//
void
AdvancedstationAPI_advancedstationCreateuser(apiClient_t *apiClient, char * station , char * user , char * location , char * firstname , char * lastname , char * email , char * middlename );


// Gets the courses available for a specific location and a specific student.
//
void
AdvancedstationAPI_advancedstationGetevents(apiClient_t *apiClient, char * station , char * location , char * user );


// Gets the info to display in the sign-in station by it's ID.
//
void
AdvancedstationAPI_advancedstationGetinfo(apiClient_t *apiClient, char * id , char * event );


// Gets the locations available in a sign-in station.
//
void
AdvancedstationAPI_advancedstationGetlocations(apiClient_t *apiClient, char * station , char * user );


// Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
//
void
AdvancedstationAPI_advancedstationGetlogstaff(apiClient_t *apiClient, char * station , char * attendancelog , int photosize );


// Gets the user roles of the user trying to sign-in.
//
void
AdvancedstationAPI_advancedstationGetroles(apiClient_t *apiClient, char * station , char * signinrole , char * user , char * location );


// Gets the services available for a specific location.
//
void
AdvancedstationAPI_advancedstationGetservices(apiClient_t *apiClient, char * station , char * location , char * user );


// Gets the staff/tutors available for a specific location, course and service.
//
void
AdvancedstationAPI_advancedstationGetstaff(apiClient_t *apiClient, char * station , char * locationid , char * user , char * services , char * eventid , int photosize );


// Gets whether a user is signed-in or not.
//
void
AdvancedstationAPI_advancedstationIssignedin(apiClient_t *apiClient, char * station , char time , char * user , char * location );


