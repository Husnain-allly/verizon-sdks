# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Campaign and campaign details.
  class V2CampaignMetaInfo < BaseModel
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

    # Software name.
    # @return [String]
    attr_accessor :software_name

    # LWM2M, OMD-DM or HTTP.
    # @return [String]
    attr_accessor :distribution_type

    # Old software name.
    # @return [String]
    attr_accessor :software_from

    # New software name.
    # @return [String]
    attr_accessor :software_to

    # Applicable make.
    # @return [String]
    attr_accessor :make

    # Applicable model.
    # @return [String]
    attr_accessor :model

    # Campaign start date.
    # @return [Date]
    attr_accessor :start_date

    # Campaign end date.
    # @return [Date]
    attr_accessor :end_date

    # Specifies starting date client should download package. If null, client
    # will download as soon as possible.
    # @return [Date]
    attr_accessor :download_after_date

    # List of allowed download time windows.
    # @return [Array[V2TimeWindow]]
    attr_accessor :download_time_window_list

    # Client will install package after date. If null, client will install as
    # soon as possible.
    # @return [Date]
    attr_accessor :install_after_date

    # List of allowed install time windows.
    # @return [Array[V2TimeWindow]]
    attr_accessor :install_time_window_list

    # Software upgrade status.
    # @return [String]
    attr_accessor :status

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['id'] = 'id'
      @_hash['campaign_name'] = 'campaignName'
      @_hash['software_name'] = 'softwareName'
      @_hash['distribution_type'] = 'distributionType'
      @_hash['software_from'] = 'softwareFrom'
      @_hash['software_to'] = 'softwareTo'
      @_hash['make'] = 'make'
      @_hash['model'] = 'model'
      @_hash['start_date'] = 'startDate'
      @_hash['end_date'] = 'endDate'
      @_hash['download_after_date'] = 'downloadAfterDate'
      @_hash['download_time_window_list'] = 'downloadTimeWindowList'
      @_hash['install_after_date'] = 'installAfterDate'
      @_hash['install_time_window_list'] = 'installTimeWindowList'
      @_hash['status'] = 'status'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        campaign_name
        download_after_date
        download_time_window_list
        install_after_date
        install_time_window_list
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name:, id:, software_name:, distribution_type:,
                   software_from:, software_to:, make:, model:, start_date:,
                   end_date:, status:, campaign_name: SKIP,
                   download_after_date: SKIP, download_time_window_list: SKIP,
                   install_after_date: SKIP, install_time_window_list: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name
      @id = id
      @campaign_name = campaign_name unless campaign_name == SKIP
      @software_name = software_name
      @distribution_type = distribution_type
      @software_from = software_from
      @software_to = software_to
      @make = make
      @model = model
      @start_date = start_date
      @end_date = end_date
      @download_after_date = download_after_date unless download_after_date == SKIP
      unless download_time_window_list == SKIP
        @download_time_window_list =
          download_time_window_list
      end
      @install_after_date = install_after_date unless install_after_date == SKIP
      @install_time_window_list = install_time_window_list unless install_time_window_list == SKIP
      @status = status
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : nil
      id = hash.key?('id') ? hash['id'] : nil
      software_name = hash.key?('softwareName') ? hash['softwareName'] : nil
      distribution_type =
        hash.key?('distributionType') ? hash['distributionType'] : nil
      software_from = hash.key?('softwareFrom') ? hash['softwareFrom'] : nil
      software_to = hash.key?('softwareTo') ? hash['softwareTo'] : nil
      make = hash.key?('make') ? hash['make'] : nil
      model = hash.key?('model') ? hash['model'] : nil
      start_date = hash.key?('startDate') ? hash['startDate'] : nil
      end_date = hash.key?('endDate') ? hash['endDate'] : nil
      status = hash.key?('status') ? hash['status'] : nil
      campaign_name = hash.key?('campaignName') ? hash['campaignName'] : SKIP
      download_after_date =
        hash.key?('downloadAfterDate') ? hash['downloadAfterDate'] : SKIP
      # Parameter is an array, so we need to iterate through it
      download_time_window_list = nil
      unless hash['downloadTimeWindowList'].nil?
        download_time_window_list = []
        hash['downloadTimeWindowList'].each do |structure|
          download_time_window_list << (V2TimeWindow.from_hash(structure) if structure)
        end
      end

      download_time_window_list = SKIP unless hash.key?('downloadTimeWindowList')
      install_after_date =
        hash.key?('installAfterDate') ? hash['installAfterDate'] : SKIP
      # Parameter is an array, so we need to iterate through it
      install_time_window_list = nil
      unless hash['installTimeWindowList'].nil?
        install_time_window_list = []
        hash['installTimeWindowList'].each do |structure|
          install_time_window_list << (V2TimeWindow.from_hash(structure) if structure)
        end
      end

      install_time_window_list = SKIP unless hash.key?('installTimeWindowList')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      V2CampaignMetaInfo.new(account_name: account_name,
                             id: id,
                             software_name: software_name,
                             distribution_type: distribution_type,
                             software_from: software_from,
                             software_to: software_to,
                             make: make,
                             model: model,
                             start_date: start_date,
                             end_date: end_date,
                             status: status,
                             campaign_name: campaign_name,
                             download_after_date: download_after_date,
                             download_time_window_list: download_time_window_list,
                             install_after_date: install_after_date,
                             install_time_window_list: install_time_window_list,
                             additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, id: #{@id}, campaign_name:"\
      " #{@campaign_name}, software_name: #{@software_name}, distribution_type:"\
      " #{@distribution_type}, software_from: #{@software_from}, software_to: #{@software_to},"\
      " make: #{@make}, model: #{@model}, start_date: #{@start_date}, end_date: #{@end_date},"\
      " download_after_date: #{@download_after_date}, download_time_window_list:"\
      " #{@download_time_window_list}, install_after_date: #{@install_after_date},"\
      " install_time_window_list: #{@install_time_window_list}, status: #{@status},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, id: #{@id.inspect}, campaign_name:"\
      " #{@campaign_name.inspect}, software_name: #{@software_name.inspect}, distribution_type:"\
      " #{@distribution_type.inspect}, software_from: #{@software_from.inspect}, software_to:"\
      " #{@software_to.inspect}, make: #{@make.inspect}, model: #{@model.inspect}, start_date:"\
      " #{@start_date.inspect}, end_date: #{@end_date.inspect}, download_after_date:"\
      " #{@download_after_date.inspect}, download_time_window_list:"\
      " #{@download_time_window_list.inspect}, install_after_date: #{@install_after_date.inspect},"\
      " install_time_window_list: #{@install_time_window_list.inspect}, status:"\
      " #{@status.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
