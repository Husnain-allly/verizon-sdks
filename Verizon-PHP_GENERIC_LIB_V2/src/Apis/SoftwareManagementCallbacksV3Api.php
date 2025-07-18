<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Apis;

use Core\Authentication\Auth;
use Core\Request\Parameters\BodyParam;
use Core\Request\Parameters\HeaderParam;
use Core\Request\Parameters\TemplateParam;
use Core\Response\Types\ErrorType;
use CoreInterfaces\Core\Request\RequestMethod;
use VerizonLib\Exceptions\FotaV3ResultException;
use VerizonLib\Http\ApiResponse;
use VerizonLib\Models\FotaV3CallbackRegistrationRequest;
use VerizonLib\Models\FotaV3CallbackRegistrationResult;
use VerizonLib\Models\FotaV3CallbackSummary;
use VerizonLib\Models\FotaV3SuccessResult;
use VerizonLib\Server;

class SoftwareManagementCallbacksV3Api extends BaseApi
{
    /**
     * This endpoint allows user to get the registered callback information.
     *
     * @param string $acc Account identifier.
     *
     * @return ApiResponse Response from the API call
     */
    public function listRegisteredCallbacks(string $acc): ApiResponse
    {
        $_reqBuilder = $this->requestBuilder(RequestMethod::GET, '/callbacks/{acc}')
            ->server(Server::SOFTWARE_MANAGEMENT_V3)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(TemplateParam::init('acc', $acc)->required());

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV3ResultException::class))
            ->type(FotaV3CallbackSummary::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * This endpoint allows the user to update the HTTPS callback address.
     *
     * @param string $acc Account identifier.
     * @param FotaV3CallbackRegistrationRequest $body Callback URL registration.
     *
     * @return ApiResponse Response from the API call
     */
    public function updateCallback(string $acc, FotaV3CallbackRegistrationRequest $body): ApiResponse
    {
        $_reqBuilder = $this->requestBuilder(RequestMethod::PUT, '/callbacks/{acc}')
            ->server(Server::SOFTWARE_MANAGEMENT_V3)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(
                TemplateParam::init('acc', $acc)->required(),
                HeaderParam::init('Content-Type', 'application/json'),
                BodyParam::init($body)->required()
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV3ResultException::class))
            ->type(FotaV3CallbackRegistrationResult::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * This endpoint allows the user to create the HTTPS callback address.
     *
     * @param string $acc Account identifier.
     * @param FotaV3CallbackRegistrationRequest $body Callback URL registration.
     *
     * @return ApiResponse Response from the API call
     */
    public function registerCallback(string $acc, FotaV3CallbackRegistrationRequest $body): ApiResponse
    {
        $_reqBuilder = $this->requestBuilder(RequestMethod::POST, '/callbacks/{acc}')
            ->server(Server::SOFTWARE_MANAGEMENT_V3)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(
                TemplateParam::init('acc', $acc)->required(),
                HeaderParam::init('Content-Type', 'application/json'),
                BodyParam::init($body)->required()
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV3ResultException::class))
            ->type(FotaV3CallbackRegistrationResult::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * This endpoint allows user to delete a previously registered callback URL.
     *
     * @param string $acc Account identifier.
     *
     * @return ApiResponse Response from the API call
     */
    public function deregisterCallback(string $acc): ApiResponse
    {
        $_reqBuilder = $this->requestBuilder(RequestMethod::DELETE, '/callbacks/{acc}')
            ->server(Server::SOFTWARE_MANAGEMENT_V3)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(TemplateParam::init('acc', $acc)->required());

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV3ResultException::class))
            ->type(FotaV3SuccessResult::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }
}
