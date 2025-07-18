<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib;

use Psr\Log\LogLevel;

/**
 * Default values for the configuration parameters of the client.
 */
class ConfigurationDefaults
{
    public const TIMEOUT = 30;

    public const ENABLE_RETRIES = false;

    public const NUMBER_OF_RETRIES = 0;

    public const RETRY_INTERVAL = 1;

    public const BACK_OFF_FACTOR = 2;

    public const MAXIMUM_RETRY_WAIT_TIME = 0;

    public const RETRY_ON_TIMEOUT = true;

    public const HTTP_STATUS_CODES_TO_RETRY = [408, 413, 429, 500, 502, 503, 504, 521, 522, 524];

    public const HTTP_METHODS_TO_RETRY = ['GET', 'PUT'];

    public const ENVIRONMENT = Environment::PRODUCTION;

    public const O_AUTH_CLIENT_ID = '';

    public const O_AUTH_CLIENT_SECRET = '';

    public const O_AUTH_TOKEN = null;

    public const O_AUTH_SCOPES = null;

    public const VZ_M2_M_TOKEN = '';

    public const O_AUTH_CLIENT_ID_2 = '';

    public const O_AUTH_CLIENT_SECRET_2 = '';

    public const O_AUTH_TOKEN_2 = null;

    public const SESSION_TOKEN = '';

    public const PROXY_CONFIGURATION = [
        'port' => 0,
        'tunnel' => false,
        'address' => '',
        'auth' => ['user' => '', 'pass' => '', 'method' => CURLAUTH_BASIC]
    ];

    public const THINGSPACE_OAUTH_CLOCK_SKEW = 0;

    public const THINGSPACE_OAUTH_1_CLOCK_SKEW = 0;

    public const LOGGER_ALLOWED_LEVELS = [
        LogLevel::EMERGENCY,
        LogLevel::ALERT,
        LogLevel::CRITICAL,
        LogLevel::ERROR,
        LogLevel::WARNING,
        LogLevel::NOTICE,
        LogLevel::INFO,
        LogLevel::DEBUG
    ];

    public const LOGGER_LEVEL = LogLevel::INFO;

    public const LOGGER_MASK_SENSITIVE_HEADERS = true;

    public const LOGGER_INCLUDE_QUERY_IN_PATH = false;

    public const LOGGER_LOG_BODY = false;

    public const LOGGER_LOG_HEADERS = false;

    public const LOGGER_EXCLUDE_HEADERS = [];

    public const LOGGER_INCLUDE_HEADERS = [];

    public const LOGGER_UNMASK_HEADERS = [];

    /**
     * @var array Associative list of all default configurations
     */
    public const _ALL = [
        'timeout' => self::TIMEOUT,
        'enableRetries' => self::ENABLE_RETRIES,
        'numberOfRetries' => self::NUMBER_OF_RETRIES,
        'retryInterval' => self::RETRY_INTERVAL,
        'backOffFactor' => self::BACK_OFF_FACTOR,
        'maximumRetryWaitTime' => self::MAXIMUM_RETRY_WAIT_TIME,
        'retryOnTimeout' => self::RETRY_ON_TIMEOUT,
        'httpStatusCodesToRetry' => self::HTTP_STATUS_CODES_TO_RETRY,
        'httpMethodsToRetry' => self::HTTP_METHODS_TO_RETRY,
        'environment' => self::ENVIRONMENT,
        'oauthClientId' => self::O_AUTH_CLIENT_ID,
        'oauthClientSecret' => self::O_AUTH_CLIENT_SECRET,
        'oauthToken' => self::O_AUTH_TOKEN,
        'oauthScopes' => self::O_AUTH_SCOPES,
        'vzM2MToken' => self::VZ_M2_M_TOKEN,
        'oauthClientId2' => self::O_AUTH_CLIENT_ID_2,
        'oauthClientSecret2' => self::O_AUTH_CLIENT_SECRET_2,
        'oauthToken2' => self::O_AUTH_TOKEN_2,
        'sessionToken' => self::SESSION_TOKEN,
        'thingspace_oauth-ClockSkew' => self::THINGSPACE_OAUTH_CLOCK_SKEW,
        'thingspace_oauth-TokenProvider' => null,
        'thingspace_oauth-OnTokenUpdate' => null,
        'thingspace_oauth1-ClockSkew' => self::THINGSPACE_OAUTH_1_CLOCK_SKEW,
        'thingspace_oauth1-TokenProvider' => null,
        'thingspace_oauth1-OnTokenUpdate' => null,
        'loggingConfiguration' => null,
        'proxyConfiguration' => self::PROXY_CONFIGURATION
    ];
}
