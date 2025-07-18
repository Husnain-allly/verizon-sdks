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
use Core\Request\Parameters\QueryParam;
use Core\Request\Parameters\TemplateParam;
use Core\Response\Types\ErrorType;
use CoreInterfaces\Core\Request\RequestMethod;
use VerizonLib\Exceptions\FotaV2ResultException;
use VerizonLib\Http\ApiResponse;
use VerizonLib\Models\FotaV2SuccessResult;
use VerizonLib\Models\V2LicenseImei;
use VerizonLib\Models\V2LicensesAssignedRemovedResult;
use VerizonLib\Models\V2LicenseSummary;
use VerizonLib\Models\V2ListOfLicensesToRemove;
use VerizonLib\Models\V2ListOfLicensesToRemoveRequest;
use VerizonLib\Models\V2ListOfLicensesToRemoveResult;
use VerizonLib\Server;

class SoftwareManagementLicensesV2Api extends BaseApi
{
    /**
     * The endpoint allows user to list license usage.
     *
     * @param string $account Account identifier.
     * @param string|null $lastSeenDeviceId Last seen device identifier.
     *
     * @return ApiResponse Response from the API call
     */
    public function getAccountLicenseStatus(string $account, ?string $lastSeenDeviceId = null): ApiResponse
    {
        $_reqBuilder = $this->requestBuilder(RequestMethod::GET, '/licenses/{account}')
            ->server(Server::SOFTWARE_MANAGEMENT_V2)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(
                TemplateParam::init('account', $account)->required(),
                QueryParam::init('lastSeenDeviceId', $lastSeenDeviceId)
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV2ResultException::class))
            ->type(V2LicenseSummary::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * This endpoint allows user to assign licenses to a list of devices.
     *
     * @deprecated
     *
     * @param string $account Account identifier.
     * @param V2LicenseImei $body License assignment.
     *
     * @return ApiResponse Response from the API call
     */
    public function assignLicensesToDevices(string $account, V2LicenseImei $body): ApiResponse
    {
        trigger_error('Method ' . __METHOD__ . ' is deprecated.', E_USER_DEPRECATED);

        $_reqBuilder = $this->requestBuilder(RequestMethod::POST, '/licenses/{account}/assign')
            ->server(Server::SOFTWARE_MANAGEMENT_V2)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(
                TemplateParam::init('account', $account)->required(),
                HeaderParam::init('Content-Type', '*/*'),
                BodyParam::init($body)->required()
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV2ResultException::class))
            ->type(V2LicensesAssignedRemovedResult::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * This endpoint allows user to remove licenses from a list of devices.
     *
     * @deprecated
     *
     * @param string $account Account identifier.
     * @param V2LicenseImei $body License removal.
     *
     * @return ApiResponse Response from the API call
     */
    public function removeLicensesFromDevices(string $account, V2LicenseImei $body): ApiResponse
    {
        trigger_error('Method ' . __METHOD__ . ' is deprecated.', E_USER_DEPRECATED);

        $_reqBuilder = $this->requestBuilder(RequestMethod::POST, '/licenses/{account}/remove')
            ->server(Server::SOFTWARE_MANAGEMENT_V2)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(
                TemplateParam::init('account', $account)->required(),
                HeaderParam::init('Content-Type', '*/*'),
                BodyParam::init($body)->required()
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV2ResultException::class))
            ->type(V2LicensesAssignedRemovedResult::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * The license cancel endpoint allows user to list registered license cancellation candidate devices.
     *
     * @deprecated
     *
     * @param string $account Account identifier.
     * @param string|null $startIndex Start index to retrieve.
     *
     * @return ApiResponse Response from the API call
     */
    public function listLicensesToRemove(string $account, ?string $startIndex = null): ApiResponse
    {
        trigger_error('Method ' . __METHOD__ . ' is deprecated.', E_USER_DEPRECATED);

        $_reqBuilder = $this->requestBuilder(RequestMethod::GET, '/licenses/{account}/cancel')
            ->server(Server::SOFTWARE_MANAGEMENT_V2)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(
                TemplateParam::init('account', $account)->required(),
                QueryParam::init('startIndex', $startIndex)
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV2ResultException::class))
            ->type(V2ListOfLicensesToRemove::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * The license cancel endpoint allows user to create a list of license cancellation candidate devices.
     *
     * @deprecated
     *
     * @param string $account Account identifier.
     * @param V2ListOfLicensesToRemoveRequest $body List of licensess to remove.
     *
     * @return ApiResponse Response from the API call
     */
    public function createListOfLicensesToRemove(string $account, V2ListOfLicensesToRemoveRequest $body): ApiResponse
    {
        trigger_error('Method ' . __METHOD__ . ' is deprecated.', E_USER_DEPRECATED);

        $_reqBuilder = $this->requestBuilder(RequestMethod::POST, '/licenses/{account}/cancel')
            ->server(Server::SOFTWARE_MANAGEMENT_V2)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(
                TemplateParam::init('account', $account)->required(),
                HeaderParam::init('Content-Type', '*/*'),
                BodyParam::init($body)->required()
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV2ResultException::class))
            ->type(V2ListOfLicensesToRemoveResult::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * This endpoint allows user to delete a created cancel candidate device list.
     *
     * @deprecated
     *
     * @param string $account Account identifier.
     *
     * @return ApiResponse Response from the API call
     */
    public function deleteListOfLicensesToRemove(string $account): ApiResponse
    {
        trigger_error('Method ' . __METHOD__ . ' is deprecated.', E_USER_DEPRECATED);

        $_reqBuilder = $this->requestBuilder(RequestMethod::DELETE, '/licenses/{account}/cancel')
            ->server(Server::SOFTWARE_MANAGEMENT_V2)
            ->auth(Auth::and('thingspace_oauth', 'VZ-M2M-Token'))
            ->parameters(TemplateParam::init('account', $account)->required());

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Unexpected error.', FotaV2ResultException::class))
            ->type(FotaV2SuccessResult::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }
}
