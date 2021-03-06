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
from openapi_client.api.report_api import ReportApi  # noqa: E501
from openapi_client.rest import ApiException


class TestReportApi(unittest.TestCase):
    """ReportApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.report_api.ReportApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_report_attanalyticsprepare(self):
        """Test case for report_attanalyticsprepare

        Query and load an attendance analytics report  # noqa: E501
        """
        pass

    def test_report_list(self):
        """Test case for report_list

        View a list of available reports  # noqa: E501
        """
        pass

    def test_report_permissionsbyuser(self):
        """Test case for report_permissionsbyuser

        Permissions by user report  # noqa: E501
        """
        pass

    def test_report_prepare(self):
        """Test case for report_prepare

        Queries and loads the specified report, in background.  # noqa: E501
        """
        pass

    def test_report_query(self):
        """Test case for report_query

        Query and load a specified report  # noqa: E501
        """
        pass

    def test_report_tagresults(self):
        """Test case for report_tagresults

        Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
