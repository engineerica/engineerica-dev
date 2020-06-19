#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Cancel an appointment
//
// Allows the user to cancel an appointment.
//
void
AppointmentAPI_appointmentCancel(apiClient_t *apiClient, char * id );


// Check if an appointment is valid or not
//
void
AppointmentAPI_appointmentCheckisvalid(apiClient_t *apiClient, char * id , int editing );


// Edit an appointment even if it breaks activated rules
//
// Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.
//
void
AppointmentAPI_appointmentEditanyway(apiClient_t *apiClient, char * id , char * attendee , char * staff , char * location , char start , char end , char * term , char * event , char * services , char * notes );


// Edit the no-show status of an appointment
//
// Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.
//
void
AppointmentAPI_appointmentEditpresence(apiClient_t *apiClient, char * id , int showedup );


// Finds all staff available slots filtered by service, date, etc
//
// Allows the user to view available appointment slots when creating an appointment.
//
void
AppointmentAPI_appointmentFindallstaffslots(apiClient_t *apiClient, char starttime , char endtime , char * serviceids , char * locationid , char * eventid , int photosize );


// Finds available slots filtered by service, date, staff, etc
//
// Allows the user to view available appointment slots when creating an appointment.
//
void
AppointmentAPI_appointmentFindslots(apiClient_t *apiClient, char * staffid , char starttime , char endtime , char * serviceids , char * eventid , char * locationid );


// Finds staff available by service, date, event, etc
//
// Allows the user to view staff availability when creating an appointment.
//
void
AppointmentAPI_appointmentFindstaff(apiClient_t *apiClient, char * serviceids , char starttime , char endtime , char * eventid , char * locationid , int photosize );


// Search and view details of an appointment
//
// Allows the user to view an individual appointment and its details.
//
void
AppointmentAPI_appointmentGet(apiClient_t *apiClient, char * id );


// Get the current appointments for the user that is about to sign-in via the specified sign-in station.
//
void
AppointmentAPI_appointmentGetcurrent(apiClient_t *apiClient, char * station , char * user , char * location );


// Find locations where a service is available
//
// Allows the user to search for appointment availability by location or service.
//
void
AppointmentAPI_appointmentGetlocations(apiClient_t *apiClient, char * serviceid );


// View a list of appointments
//
// Allows the user to view all upcoming appointments for the location or locations they are scoped to.
//
void
AppointmentAPI_appointmentList(apiClient_t *apiClient, int from , int count , char startdate , char enddate , char * userid );


// View all my upcoming appointments
//
void
AppointmentAPI_appointmentListmine(apiClient_t *apiClient, char start , char modifiedafter );


// Search and view details of all my upcoming appointments
//
// Allows the user to view all of their own upcoming appointments.
//
void
AppointmentAPI_appointmentListupcoming(apiClient_t *apiClient, char start , char modifiedafter );


// Reschedule an appointment from MS Outlook.
//
// Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.
//
void
AppointmentAPI_appointmentRescheduleoutlook(apiClient_t *apiClient, char * id , char start , char end );


// Restore an appointment
//
// Allows the user to restore a canceled appointment.
//
void
AppointmentAPI_appointmentRestore(apiClient_t *apiClient, char * id );


// Restore an appointment even if it breaks activated rules
//
// Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.
//
void
AppointmentAPI_appointmentRestoreanyway(apiClient_t *apiClient, char * id );


// Schedule an appointment
//
// Allows the user to schedule an appointment within the rules of the location and the availability of staff members.
//
void
AppointmentAPI_appointmentSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Schedule an appointment even if it breaks activated rules
//
// Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.
//
void
AppointmentAPI_appointmentSetasvalid(apiClient_t *apiClient, char * id );


// View the locations with most appointments
//
// Allows the user to view suggestions for the most popular locations in which to make appointments
//
void
AppointmentAPI_appointmentSuggestlocations(apiClient_t *apiClient);


// View the services with most appointments
//
// Allows the user to view suggestions for the most popular services for which to make appointments.
//
void
AppointmentAPI_appointmentSuggestservices(apiClient_t *apiClient);


// Void an appointment
//
// Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.
//
void
AppointmentAPI_appointmentVoid(apiClient_t *apiClient, char * id );


