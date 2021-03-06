# coding: utf-8

"""
    AccuCampus OpenAPI 3

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import openapi_client
from openapi_client.api.serviceassignment_api import ServiceassignmentApi  # noqa: E501
from openapi_client.rest import ApiException


class TestServiceassignmentApi(unittest.TestCase):
    """ServiceassignmentApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.serviceassignment_api.ServiceassignmentApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_serviceassignment_addservice(self):
        """Test case for serviceassignment_addservice

        Enable a service in a specific location  # noqa: E501
        """
        pass

    def test_serviceassignment_getlocation(self):
        """Test case for serviceassignment_getlocation

        View a list of services enabled for a specific location  # noqa: E501
        """
        pass

    def test_serviceassignment_getservice(self):
        """Test case for serviceassignment_getservice

        View a list of locations where a service is available  # noqa: E501
        """
        pass

    def test_serviceassignment_removeservice(self):
        """Test case for serviceassignment_removeservice

        Remove a service from a location  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
