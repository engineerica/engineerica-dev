# coding: utf-8

"""
    AccuCampus OpenAPI 3 Documentation

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import openapi_client
from openapi_client.models.action_result import ActionResult  # noqa: E501
from openapi_client.rest import ApiException

class TestActionResult(unittest.TestCase):
    """ActionResult unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test ActionResult
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.action_result.ActionResult()  # noqa: E501
        if include_optional :
            return ActionResult(
                success = True, 
                results = [
                    None
                    ], 
                message = '0'
            )
        else :
            return ActionResult(
        )

    def testActionResult(self):
        """Test ActionResult"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()
