# coding: utf-8

"""
    AccuClub OpenAPI 3

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import openapi_client
from openapi_client.api.quickpanel_api import QuickpanelApi  # noqa: E501
from openapi_client.rest import ApiException


class TestQuickpanelApi(unittest.TestCase):
    """QuickpanelApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.quickpanel_api.QuickpanelApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_quickpanel_deletewidget(self):
        """Test case for quickpanel_deletewidget

        Deletes a widget from the Quick Panel  # noqa: E501
        """
        pass

    def test_quickpanel_fetchwidget(self):
        """Test case for quickpanel_fetchwidget

        Fetches the information for a specific widget.  # noqa: E501
        """
        pass

    def test_quickpanel_getwidget(self):
        """Test case for quickpanel_getwidget

        View details of a widget included in the Quick Panel  # noqa: E501
        """
        pass

    def test_quickpanel_init(self):
        """Test case for quickpanel_init

        Returns the initial information required to show the quick panels  # noqa: E501
        """
        pass

    def test_quickpanel_listwidgets(self):
        """Test case for quickpanel_listwidgets

        Lists all the widgets that are added in the Quick Panel  # noqa: E501
        """
        pass

    def test_quickpanel_listwidgettypes(self):
        """Test case for quickpanel_listwidgettypes

        Lists all the widget types available in the system  # noqa: E501
        """
        pass

    def test_quickpanel_reorderwidgets(self):
        """Test case for quickpanel_reorderwidgets

        Reorders the widgets and moves them to a specific column  # noqa: E501
        """
        pass

    def test_quickpanel_savewidget(self):
        """Test case for quickpanel_savewidget

        Saves a widget for the Quick Panel  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
