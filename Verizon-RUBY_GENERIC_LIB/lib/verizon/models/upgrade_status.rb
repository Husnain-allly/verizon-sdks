# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # The status of the upgrades that you want to retrieve.
  class UpgradeStatus
    UPGRADE_STATUS = [
      # TODO: Write general description for REQUESTPENDING
      REQUESTPENDING = 'RequestPending'.freeze,

      # TODO: Write general description for QUEUED
      QUEUED = 'Queued'.freeze,

      # TODO: Write general description for REQUESTFAILED
      REQUESTFAILED = 'RequestFailed'.freeze,

      # TODO: Write general description for INPROGRESS
      INPROGRESS = 'InProgress'.freeze,

      # TODO: Write general description for FINISHED
      FINISHED = 'Finished'.freeze,

      # TODO: Write general description for UPGRADEFAILED
      UPGRADEFAILED = 'UpgradeFailed'.freeze
    ].freeze

    def self.validate(value)
      return false if value.nil?

      UPGRADE_STATUS.include?(value)
    end
  end
end
