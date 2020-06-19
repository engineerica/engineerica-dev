#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a rule
//
// Allows the user to delete an existing rule.
//
void
RuleAPI_ruleDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a rule
//
// Allows the user to view an individual rule and its details.
//
void
RuleAPI_ruleGet(apiClient_t *apiClient, char * id );


// View details of a rule event type
//
// Allows the user to view the trigger and its available conditions for the rule.
//
void
RuleAPI_ruleGeteventtype(apiClient_t *apiClient, char * event );


// View a list of user rules
//
// Allows the user to view the list of all rules.
//
void
RuleAPI_ruleList(apiClient_t *apiClient, int from , int count );


// View a list of rule actions available
//
// Allows the user to view all the available rule actions.
//
void
RuleAPI_ruleListactions(apiClient_t *apiClient);


// View a list of rule event types
//
// Allows the user to view a list of available triggers for rules.
//
void
RuleAPI_ruleListeventtypes(apiClient_t *apiClient);


// View all the http requests sent as a result of a rule
//
void
RuleAPI_ruleListhttprequests(apiClient_t *apiClient, int from , int count , int failed , int status );


// Create or edit a rule
//
// Allows the user to create or edit a rule.
//
void
RuleAPI_ruleSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


