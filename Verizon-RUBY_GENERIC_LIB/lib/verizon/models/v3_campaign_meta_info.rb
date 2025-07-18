# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Campaign and campaign details.
  class V3CampaignMetaInfo < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # Account identifier.
    # @return [String]
    attr_accessor :account_name

    # Campaign identifier.
    # @return [String]
    attr_accessor :id

    # Campaign name.
    # @return [String]
    attr_accessor :campaign_name

    # Firmware name.
    # @return [String]
    attr_accessor :firmware_name

    # Old firmware version.
    # @return [String]
    attr_accessor :firmware_from

    # New software version.
    # @return [String]
    attr_accessor :firmware_to

    # Firmware protocol. Valid values include: LWM2M, OMD-DM.
    # @return [CampaignMetaInfoProtocol]
    attr_accessor :protocol

    # Device make.
    # @return [String]
    attr_accessor :make

    # Device model.
    # @return [String]
    attr_accessor :model

    # Campaign start date.
    # @return [Date]
    attr_accessor :start_date

    # Campaign end date.
    # @return [Date]
    attr_accessor :end_date

    # List of allowed campaign time windows.
    # @return [Array[V3TimeWindow]]
    attr_accessor :campaign_time_window_list

    # Firmware upgrade status.
    # @return [String]
    attr_accessor :status

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['id'] = 'id'
      @_hash['campaign_name'] = 'campaignName'
      @_hash['firmware_name'] = 'firmwareName'
      @_hash['firmware_from'] = 'firmwareFrom'
      @_hash['firmware_to'] = 'firmwareTo'
      @_hash['protocol'] = 'protocol'
      @_hash['make'] = 'make'
      @_hash['model'] = 'model'
      @_hash['start_date'] = 'startDate'
      @_hash['end_date'] = 'endDate'
      @_hash['campaign_time_window_list'] = 'campaignTimeWindowList'
      @_hash['status'] = 'status'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        campaign_name
        firmware_name
        firmware_from
        firmware_to
        protocol
        campaign_time_window_list
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name:, id:, make:, model:, start_date:, end_date:,
                   status:, campaign_name: SKIP, firmware_name: SKIP,
                   firmware_from: SKIP, firmware_to: SKIP,
                   protocol: CampaignMetaInfoProtocol::LW_M2M,
                   campaign_time_window_list: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name
      @id = id
      @campaign_name = campaign_name unless campaign_name == SKIP
      @firmware_name = firmware_name unless firmware_name == SKIP
      @firmware_from = firmware_from unless firmware_from == SKIP
      @firmware_to = firmware_to unless firmware_to == SKIP
      @protocol = protocol unless protocol == SKIP
      @make = make
      @model = model
      @start_date = start_date
      @end_date = end_date
      unless campaign_time_window_list == SKIP
        @campaign_time_window_list =
          campaign_time_window_list
      end
      @status = status
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : nil
      id = hash.key?('id') ? hash['id'] : nil
      make = hash.key?('make') ? hash['make'] : nil
      model = hash.key?('model') ? hash['model'] : nil
      start_date = hash.key?('startDate') ? hash['startDate'] : nil
      end_date = hash.key?('endDate') ? hash['endDate'] : nil
      status = hash.key?('status') ? hash['status'] : nil
      campaign_name = hash.key?('campaignName') ? hash['campaignName'] : SKIP
      firmware_name = hash.key?('firmwareName') ? hash['firmwareName'] : SKIP
      firmware_from = hash.key?('firmwareFrom') ? hash['firmwareFrom'] : SKIP
      firmware_to = hash.key?('firmwareTo') ? hash['firmwareTo'] : SKIP
      protocol = hash['protocol'] ||= CampaignMetaInfoProtocol::LW_M2M
      # Parameter is an array, so we need to iterate through it
      campaign_time_window_list = nil
      unless hash['campaignTimeWindowList'].nil?
        campaign_time_window_list = []
        hash['campaignTimeWindowList'].each do |structure|
          campaign_time_window_list << (V3TimeWindow.from_hash(structure) if structure)
        end
      end

      campaign_time_window_list = SKIP unless hash.key?('campaignTimeWindowList')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      V3CampaignMetaInfo.new(account_name: account_name,
                             id: id,
                             make: make,
                             model: model,
                             start_date: start_date,
                             end_date: end_date,
                             status: status,
                             campaign_name: campaign_name,
                             firmware_name: firmware_name,
                             firmware_from: firmware_from,
                             firmware_to: firmware_to,
                             protocol: protocol,
                             campaign_time_window_list: campaign_time_window_list,
                             additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, id: #{@id}, campaign_name:"\
      " #{@campaign_name}, firmware_name: #{@firmware_name}, firmware_from: #{@firmware_from},"\
      " firmware_to: #{@firmware_to}, protocol: #{@protocol}, make: #{@make}, model: #{@model},"\
      " start_date: #{@start_date}, end_date: #{@end_date}, campaign_time_window_list:"\
      " #{@campaign_time_window_list}, status: #{@status}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, id: #{@id.inspect}, campaign_name:"\
      " #{@campaign_name.inspect}, firmware_name: #{@firmware_name.inspect}, firmware_from:"\
      " #{@firmware_from.inspect}, firmware_to: #{@firmware_to.inspect}, protocol:"\
      " #{@protocol.inspect}, make: #{@make.inspect}, model: #{@model.inspect}, start_date:"\
      " #{@start_date.inspect}, end_date: #{@end_date.inspect}, campaign_time_window_list:"\
      " #{@campaign_time_window_list.inspect}, status: #{@status.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
