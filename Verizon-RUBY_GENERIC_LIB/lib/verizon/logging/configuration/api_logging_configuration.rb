# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Initializes a new instance of RequestLoggingConfiguration.
  class RequestLoggingConfiguration < CoreLibrary::ApiRequestLoggingConfiguration
    # @param log_body [Boolean] Indicates whether the message body should be logged. Default is false.
    # @param log_headers [Boolean] Indicates whether the message headers should be logged. Default is false.
    # @param headers_to_exclude [Array<String>] Array of headers not displayed in logging. Default is an empty array.
    # @param headers_to_include [Array<String>] Array of headers to be displayed in logging. Default is an empty array.
    # @param headers_to_unmask [Array<String>] Array of headers which values are non-sensitive to display in logging.
    #   Default is an empty array.
    def initialize(log_body: false, log_headers: false, headers_to_include: nil,
                   headers_to_exclude: nil, headers_to_unmask: nil,
                   include_query_in_path: false)
      super(
        log_body,
        log_headers,
        headers_to_exclude,
        headers_to_include,
        headers_to_unmask,
        include_query_in_path
      )
    end

    def clone_with(log_body: nil, log_headers: nil, headers_to_include: nil,
                   headers_to_exclude: nil, headers_to_unmask: nil, include_query_in_path: nil)
      log_body ||= self.log_body
      log_headers ||= self.log_headers
      headers_to_include ||= self.headers_to_include
      headers_to_exclude ||= self.headers_to_exclude
      headers_to_unmask ||= self.headers_to_unmask
      include_query_in_path ||= self.include_query_in_path

      RequestLoggingConfiguration.class.new(log_body: log_body, log_headers: log_headers,
                                            headers_to_include: headers_to_include,
                                            headers_to_exclude: headers_to_exclude,
                                            headers_to_unmask: headers_to_unmask,
                                            include_query_in_path: include_query_in_path)
    end
  end

  # Initializes a new instance of ResponseLoggingConfiguration.
  class ResponseLoggingConfiguration < CoreLibrary::ApiResponseLoggingConfiguration
    # @param log_body [Boolean] Indicates whether the message body should be logged. Default is false.
    # @param log_headers [Boolean] Indicates whether the message headers should be logged. Default is false.
    # @param headers_to_exclude [Array<String>] Array of headers not displayed in logging. Default is an empty array.
    # @param headers_to_include [Array<String>] Array of headers to be displayed in logging. Default is an empty array.
    # @param headers_to_unmask [Array<String>] Array of headers which values are non-sensitive to display in logging.
    #   Default is an empty array.
    def initialize(log_body: false, log_headers: false, headers_to_include: nil,
                   headers_to_exclude: nil, headers_to_unmask: nil)
      super(
        log_body,
        log_headers,
        headers_to_exclude,
        headers_to_include,
        headers_to_unmask
      )
    end

    def clone_with(log_body: nil, log_headers: nil, headers_to_include: nil,
                   headers_to_exclude: nil, headers_to_unmask: nil)
      log_body ||= self.log_body
      log_headers ||= self.log_headers
      headers_to_include ||= self.headers_to_include
      headers_to_exclude ||= self.headers_to_exclude
      headers_to_unmask ||= self.headers_to_unmask

      ResponseLoggingConfiguration.new(log_body: log_body, log_headers: log_headers,
                                       headers_to_include: headers_to_include,
                                       headers_to_exclude: headers_to_exclude,
                                       headers_to_unmask: headers_to_unmask)
    end
  end

  # Initializes a new instance of LoggingConfiguration.
  class LoggingConfiguration < CoreLibrary::ApiLoggingConfiguration
    # @param logger [LoggerInterface] The logger to use for logging messages.
    # @param log_level [LogLevel] The log level to determine which messages should be logged.
    # @param request_logging_config [RequestLoggingConfiguration] Options for logging HTTP requests.
    # @param response_logging_config [ResponseLoggingConfiguration] Options for logging HTTP responses.
    # @param mask_sensitive_headers [Boolean] Indicates whether sensitive headers should be masked in logged messages.
    def initialize(logger: nil, log_level: nil, mask_sensitive_headers: true,
                   request_logging_config: nil,
                   response_logging_config: nil)
      request_logging_config ||= RequestLoggingConfiguration.new
      response_logging_config ||= ResponseLoggingConfiguration.new
      super(
        logger,
        log_level,
        request_logging_config,
        response_logging_config,
        mask_sensitive_headers
      )
    end

    def clone_with(logger: nil, log_level: nil, mask_sensitive_headers: nil,
                   request_logging_config: nil, response_logging_config: nil)
      logger ||= self.logger
      log_level ||= self.log_level
      mask_sensitive_headers = self.mask_sensitive_headers ||= mask_sensitive_headers
      request_logging_config ||= self.request_logging_config.clone
      response_logging_config ||= self.response_logging_config.clone

      LoggingConfiguration.new(logger: logger, log_level: log_level,
                               mask_sensitive_headers: mask_sensitive_headers,
                               request_logging_config: request_logging_config,
                               response_logging_config: response_logging_config)
    end
  end
end
