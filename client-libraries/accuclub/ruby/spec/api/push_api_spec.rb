=begin
#AccuClub OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::PushApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'PushApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::PushApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of PushApi' do
    it 'should create an instance of PushApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::PushApi)
    end
  end

  # unit tests for push_deregister
  # Deregisters the current device to receive push notifications
  # @param devicetoken The device token where to send the notification.
  # @param platform Either ios or android
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'push_deregister test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for push_register
  # Registers the current device to receive push notifications
  # @param devicetoken The device token where to send the notification.
  # @param platform Either ios or android
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'push_register test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
