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
use Core\Response\Types\ErrorType;
use CoreInterfaces\Core\Request\RequestMethod;
use VerizonLib\Exceptions\MapDataResponseErrorException;
use VerizonLib\Http\ApiResponse;
use VerizonLib\Models\Geofence;
use VerizonLib\Server;

class MapDataManagerApi extends BaseApi
{
    /**
     * This endpoint allows the user to upload map messages in SAE J2735 MAP messages in ASN.1 UPER or JER
     * (JSON) formats. The MAP data message can have more than one intersections in it.
     * Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and
     * Session/M2M tokens in order to call this API.
     *
     * @param string $vendorId The VendorID set during the Vendor registration call.
     * @param string $body
     *
     * @return ApiResponse Response from the API call
     */
    public function uploadMapDataMessage(string $vendorId, string $body): ApiResponse
    {
        $_reqBuilder = $this->requestBuilder(RequestMethod::POST, '/api/v2/mapdata')
            ->server(Server::IMP_SERVER)
            ->auth(Auth::and('thingspace_oauth', 'SessionToken'))
            ->parameters(
                HeaderParam::init('VendorID', $vendorId)->required(),
                HeaderParam::init('Content-Type', 'application/json'),
                BodyParam::init($body)->required()
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Invalid request', MapDataResponseErrorException::class))
            ->throwErrorOn('401', ErrorType::init('Unauthorized', MapDataResponseErrorException::class))
            ->throwErrorOn('403', ErrorType::init('Forbidden Request', MapDataResponseErrorException::class))
            ->throwErrorOn('429', ErrorType::init('Too Many Requests', MapDataResponseErrorException::class))
            ->throwErrorOn('503', ErrorType::init('Internal server Error', MapDataResponseErrorException::class))
            ->throwErrorOn('0', ErrorType::init('Unexpected Error', MapDataResponseErrorException::class))
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * This endpoint allows user to download SAE J2735 MAP messages in ASN.1 UPER format. The area for the
     * MAP messages is needed to be defined in the query.
     *
     * @param string $vendorId The VendorID set during the Vendor registration call.
     * @param Geofence $geofence The area where the user wants to receive MAP data from.
     *
     * @return ApiResponse Response from the API call
     */
    public function downloadMapDataMessage(string $vendorId, Geofence $geofence): ApiResponse
    {
        $_reqBuilder = $this->requestBuilder(RequestMethod::GET, '/api/v2/mapdata')
            ->server(Server::IMP_SERVER)
            ->auth(Auth::and('thingspace_oauth', 'SessionToken'))
            ->parameters(
                HeaderParam::init('VendorID', $vendorId)->required(),
                QueryParam::init('Geofence', $geofence)->required()
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn('400', ErrorType::init('Invalid request', MapDataResponseErrorException::class))
            ->throwErrorOn('401', ErrorType::init('Unauthorized', MapDataResponseErrorException::class))
            ->throwErrorOn('403', ErrorType::init('Forbidden Request', MapDataResponseErrorException::class))
            ->throwErrorOn('429', ErrorType::init('Too Many Requests', MapDataResponseErrorException::class))
            ->throwErrorOn('503', ErrorType::init('Internal server Error', MapDataResponseErrorException::class))
            ->throwErrorOn('0', ErrorType::init('Unexpected Error', MapDataResponseErrorException::class))
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }
}
