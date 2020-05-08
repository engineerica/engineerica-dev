#ifndef error_action_result_TEST
#define error_action_result_TEST

// the following is to include only the main from the first c file
#ifndef TEST_MAIN
#define TEST_MAIN
#define error_action_result_MAIN
#endif // TEST_MAIN

#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include <stdbool.h>
#include "../external/cJSON.h"

#include "../model/error_action_result.h"
error_action_result_t* instantiate_error_action_result(int include_optional);



error_action_result_t* instantiate_error_action_result(int include_optional) {
  error_action_result_t* error_action_result = NULL;
  if (include_optional) {
    error_action_result = error_action_result_create(
      1,
      "0",
      "0",
      "0",
      "0"
    );
  } else {
    error_action_result = error_action_result_create(
      1,
      "0",
      "0",
      "0",
      "0"
    );
  }

  return error_action_result;
}


#ifdef error_action_result_MAIN

void test_error_action_result(int include_optional) {
    error_action_result_t* error_action_result_1 = instantiate_error_action_result(include_optional);

	cJSON* jsonerror_action_result_1 = error_action_result_convertToJSON(error_action_result_1);
	printf("error_action_result :\n%s\n", cJSON_Print(jsonerror_action_result_1));
	error_action_result_t* error_action_result_2 = error_action_result_parseFromJSON(jsonerror_action_result_1);
	cJSON* jsonerror_action_result_2 = error_action_result_convertToJSON(error_action_result_2);
	printf("repeating error_action_result:\n%s\n", cJSON_Print(jsonerror_action_result_2));
}

int main() {
  test_error_action_result(1);
  test_error_action_result(0);

  printf("Hello world \n");
  return 0;
}

#endif // error_action_result_MAIN
#endif // error_action_result_TEST
