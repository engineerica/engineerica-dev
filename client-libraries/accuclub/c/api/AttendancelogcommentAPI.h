#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a comment on an attendance log
//
void
AttendancelogcommentAPI_attendancelogcommentDelete(apiClient_t *apiClient, char * id ,  body );


// View a comment on an attendance log
//
void
AttendancelogcommentAPI_attendancelogcommentGet(apiClient_t *apiClient, char * id );


// View all the comments on a specific attendance log
//
void
AttendancelogcommentAPI_attendancelogcommentList(apiClient_t *apiClient, char * attendancelog );


// Save a comment on an attendance log
//
void
AttendancelogcommentAPI_attendancelogcommentSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


