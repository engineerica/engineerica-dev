=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::NotificationApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'NotificationApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::NotificationApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of NotificationApi' do
    it 'should create an instance of NotificationApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::NotificationApi)
    end
  end

  # unit tests for notification_delete
  # Delete a notification
  # Allows the user to delete an existing notification.
  # @param id The id of the notification to delete.
  # @param [Hash] opts the optional parameters
  # @option opts [AnyType] :body 
  # @return [nil]
  describe 'notification_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_get
  # View a notification
  # @param id The id of the notification to get.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'notification_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_getforstation
  # Gets all public (in station) notifications for the specific user
  # @param station The id of the sign-in station to get.
  # @param user The card of the user.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'notification_getforstation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_getunreadcount
  # Get the number of unread notifications
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'notification_getunreadcount test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_list
  # View a list of all sent notifications
  # Allows the user to view the list of all sent notifications.
  # @param from The first record to return.
  # @param count The max number of records to return.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :recipient The recipient whose notifications have to be listed.
  # @option opts [Integer] :status The status of the notifications to list. Read, Unread or All.
  # @option opts [DateTime] :startdate The start date of the period to filter the notifications.
  # @option opts [DateTime] :enddate The end date of the period to filter the notifications.
  # @option opts [Boolean] :sentonscreen Specifies whether to list the notifications that were sent on-screen or not.
  # @option opts [Boolean] :sentemail Specifies whether to list the notifications that were sent via e-mail or not.
  # @option opts [Boolean] :sentsms Specifies whether to list the notifications that were sent via sms or not.
  # @return [nil]
  describe 'notification_list test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_listmine
  # View all the notifications sent to the current user
  # @param from The first record to return.
  # @param count The max number of records to return.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :status Specifies the status of the notifications to list. Read, Unread or All.
  # @option opts [DateTime] :startdate The start date of the period to filter the notifications.
  # @option opts [DateTime] :enddate The end date of the period to filter the notifications.
  # @return [nil]
  describe 'notification_listmine test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_markasread
  # Mark a notification as read
  # @param [Hash] opts the optional parameters
  # @option opts [String] :id The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
  # @option opts [Integer] :status Specifies the status to filter the notifications. Read, Unread or All.
  # @option opts [DateTime] :startdate The start date of the period to filter the notifications.
  # @option opts [DateTime] :enddate The end date of the period to filter the notifications.
  # @return [nil]
  describe 'notification_markasread test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_markasunread
  # Mark a notification as unread
  # @param [Hash] opts the optional parameters
  # @option opts [String] :id The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
  # @option opts [Integer] :status Specifies the status to filter the notifications. Read, Unread or All.
  # @option opts [DateTime] :startdate The start date of the period to filter the notifications.
  # @option opts [DateTime] :enddate The end date of the period to filter the notifications.
  # @return [nil]
  describe 'notification_markasunread test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_send
  # Send notifications on screen, via email or text to users
  # Allows the user to send notifications to other users through the Send Message link.
  # @param emailenabled Whether send the notification via email.
  # @param onscreenenabled Whether to display the notification on screen.
  # @param smsenabled Whether to send the notification via text message.
  # @param title Notification title.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :tousers Comma-separated Ids of users to send the notification.
  # @option opts [String] :togroups Comma-separated Ids of user groups to send the notification.
  # @option opts [String] :onscreenbody Body of the message for on-screen display.
  # @option opts [String] :onscreenclick What to do when the notification is clicked. Valid values: hide, view, url.
  # @option opts [String] :onscreenurl Url to redirect the user, if onscreenclick&#x3D;url.
  # @option opts [String] :onscreenclass How to display the notification. Valid values: info, success, warning, error
  # @option opts [Integer] :onscreenduration Time in seconds to display the notification.
  # @option opts [Integer] :showonstation Whether to show the notification in the sign-in station.
  # @option opts [String] :emailfromname Name of the email sender.
  # @option opts [String] :emailfrom Reply-to email.
  # @option opts [String] :emailsubject Subject of the email.
  # @option opts [String] :emailbody Body of the email.
  # @option opts [String] :textmessagebody Message for SMS. Max 160 characters.
  # @return [nil]
  describe 'notification_send test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for notification_sendonscreen
  # Send on-screen notifications
  # @param notification The ID of the notification to send.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'notification_sendonscreen test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
