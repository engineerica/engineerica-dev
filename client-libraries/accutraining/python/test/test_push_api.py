# coding: utf-8

"""
    AccuTraining OpenAPI 3

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import openapi_client
from openapi_client.api.push_api import PushApi  # noqa: E501
from openapi_client.rest import ApiException


class TestPushApi(unittest.TestCase):
    """PushApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.push_api.PushApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_push_deregister(self):
        """Test case for push_deregister

        Deregisters the current device to receive push notifications  # noqa: E501
        """
        pass

    def test_push_register(self):
        """Test case for push_register

        Registers the current device to receive push notifications  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
