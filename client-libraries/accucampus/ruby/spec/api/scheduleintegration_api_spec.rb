=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::ScheduleintegrationApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'ScheduleintegrationApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::ScheduleintegrationApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of ScheduleintegrationApi' do
    it 'should create an instance of ScheduleintegrationApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::ScheduleintegrationApi)
    end
  end

  # unit tests for scheduleintegration_clearids
  # Clear all third party IDs from specified staff member&#39;s schedule items.
  # @param staff The ID of the staff member whose schedule items third party IDs must be cleared.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'scheduleintegration_clearids test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for scheduleintegration_deleteitem
  # Delete a schedule item looking up by a third party ID
  # @param [Hash] opts the optional parameters
  # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
  # @return [nil]
  describe 'scheduleintegration_deleteitem test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for scheduleintegration_deleteitemsbymasterid
  # Delete multiple schedule items looking up by a third party master ID
  # @param [Hash] opts the optional parameters
  # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
  # @return [nil]
  describe 'scheduleintegration_deleteitemsbymasterid test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for scheduleintegration_getitem
  # Get a schedule item looking up by a third party ID
  # @param thirdpartyid The third party id to search for the schedule item.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'scheduleintegration_getitem test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for scheduleintegration_saveitem
  # Save a schedule item looking up by a third party ID
  # @param [Hash] opts the optional parameters
  # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
  # @return [nil]
  describe 'scheduleintegration_saveitem test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for scheduleintegration_setid
  # Set a 3rd party ID on a specific schedule item
  # @param id The id of the schedule block / appointment.
  # @param thirdpartyid The 3rd party ID to set.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :thirdpartymasterid The 3rd party master ID to set (useful to handle recurring items).
  # @return [nil]
  describe 'scheduleintegration_setid test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
