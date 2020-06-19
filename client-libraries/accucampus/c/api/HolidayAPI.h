#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// View a list of entered holidays
//
// Allows the user to view all holidays entered.
//
void
HolidayAPI_holidayList(apiClient_t *apiClient, char * term );


// Create or edit a list of holidays
//
// Allows the user to create or edit holidays.
//
void
HolidayAPI_holidaySave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View the holiday suggestions in the given term
//
// Allows the user to view the holiday suggestions for each term.
//
void
HolidayAPI_holidaySuggest(apiClient_t *apiClient, char * term );


