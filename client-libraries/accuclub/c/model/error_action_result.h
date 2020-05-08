/*
 * error_action_result.h
 *
 * Object returned when the action execution failed
 */

#ifndef _error_action_result_H_
#define _error_action_result_H_

#include <string.h>
#include "../external/cJSON.h"
#include "../include/list.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"

typedef struct error_action_result_t error_action_result_t;




typedef struct error_action_result_t {
    int success; //boolean
    char *message; // string
    char *error_flag; // string
    char *domain; // string
    char *redirect_url; // string

} error_action_result_t;

error_action_result_t *error_action_result_create(
    int success,
    char *message,
    char *error_flag,
    char *domain,
    char *redirect_url
);

void error_action_result_free(error_action_result_t *error_action_result);

error_action_result_t *error_action_result_parseFromJSON(cJSON *error_action_resultJSON);

cJSON *error_action_result_convertToJSON(error_action_result_t *error_action_result);

#endif /* _error_action_result_H_ */

