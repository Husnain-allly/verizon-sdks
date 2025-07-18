# Service Endpoints

```php
$serviceEndpointsApi = $client->getServiceEndpointsApi();
```

## Class Name

`ServiceEndpointsApi`

## Methods

* [List Optimal Service Endpoints](../../doc/controllers/service-endpoints.md#list-optimal-service-endpoints)
* [Register Service Endpoints](../../doc/controllers/service-endpoints.md#register-service-endpoints)
* [List All Service Endpoints](../../doc/controllers/service-endpoints.md#list-all-service-endpoints)
* [Get Service Endpoint](../../doc/controllers/service-endpoints.md#get-service-endpoint)
* [Update Service Endpoint](../../doc/controllers/service-endpoints.md#update-service-endpoint)
* [Deregister Service Endpoint](../../doc/controllers/service-endpoints.md#deregister-service-endpoint)


# List Optimal Service Endpoints

Returns a list of optimal Service Endpoints that client devices can connect to. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - Region plus Service Endpoints IDs and Subscriber density (density is optional but recommended), Region plus Service Endpoints IDs and UEIdentity(Including UEIdentity Type) and Service Endpoints IDs plus UEIdentity(Including UEIdentity Type).

```php
function listOptimalServiceEndpoints(
    ?string $region = null,
    ?int $subscriberDensity = null,
    ?string $ueIdentityType = null,
    ?string $ueIdentity = null,
    ?string $serviceEndpointsIds = null
): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `region` | `?string` | Query, Optional | MEC region name. Current valid values are US_WEST_2 and US_EAST_1. |
| `subscriberDensity` | `?int` | Query, Optional | Minimum number of 4G/5G subscribers per square kilometer.<br><br>**Constraints**: `>= 1`, `<= 100` |
| `ueIdentityType` | [`?string(UserEquipmentIdentityType)`](../../doc/models/user-equipment-identity-type.md) | Query, Optional | Type of User Equipment identifier used in `UEIdentity`. |
| `ueIdentity` | `?string` | Query, Optional | The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6. |
| `serviceEndpointsIds` | `?string` | Query, Optional | A system-defined string identifier representing one or more registered Service Endpoints. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ListOptimalServiceEndpointsResult`](../../doc/models/list-optimal-service-endpoints-result.md).

## Example Usage

```php
$region = 'US_WEST_2';

$ueIdentityType = UserEquipmentIdentityType::IPADDRESS;

$ueIdentity = '2600:1010:b1d0:0000:0000:0000:0000:0012';

$serviceEndpointsIds = '43f3f7bb-d6c5-4bad-b081-9a3a0df2db98';

$apiResponse = $serviceEndpointsApi->listOptimalServiceEndpoints(
    $region,
    null,
    $ueIdentityType,
    $ueIdentity,
    $serviceEndpointsIds
);
```

## Example Response *(as JSON)*

```json
{
  "serviceEndpoints": [
    {
      "ern": "LASVEGAS_NV_WL",
      "serviceEndpoint": {
        "URI": "http://base_path/some_segment/id",
        "FQDN": "thingtest.verizon.com",
        "IPv4Address": "192.168.11.10",
        "IPv6Address": "2001:0db8:85a3:0000:0000:8a2e:0370:1234",
        "port": 1234
      },
      "applicationServerProviderId": "AWS",
      "applicationId": "IogspaceJan15",
      "serviceDescription": "ThieIt"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Register Service Endpoints

Register Service Endpoints of a deployed application to specified MEC Platforms.

```php
function registerServiceEndpoints(array $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResourcesEdgeHostedServiceWithProfileId[]`](../../doc/models/resources-edge-hosted-service-with-profile-id.md) | Body, Required | An array of Service Endpoint data for a deployed application. The request body passes all of the needed parameters to create a service endpoint. Parameters will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId`, `applicationId` and `serviceProfileID` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**. Also, if you do not know one of the optional values (i.e. URI), you can erase the line from the query by back-spacing over it.<br><br>**Constraints**: *Maximum Items*: `100` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`RegisterServiceEndpointResult`](../../doc/models/register-service-endpoint-result.md).

## Example Usage

```php
$body = [
    ResourcesEdgeHostedServiceWithProfileIdBuilder::init()
        ->ern('us-east-1-wl1-atl-wlz-1')
        ->serviceEndpoint(
            ResourcesServiceEndpointBuilder::init()
                ->uri('http://base_path/some_segment/id')
                ->fqdn('thingtest.verizon.com')
                ->iPv4Address('192.168.11.10')
                ->iPv6Address('2001:0db8:85a3:0000:0000:8a2e:0370:1234')
                ->port(1234)
                ->build()
        )
        ->applicationServerProviderId('AWS')
        ->applicationId('IogspaceJan15')
        ->serviceDescription('ThieIt')
        ->serviceProfileId('4054ea9a-593e-4776-b488-697b1bfa4f3b')
        ->build()
];

$apiResponse = $serviceEndpointsApi->registerServiceEndpoints($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# List All Service Endpoints

Returns a list of all registered service endpoints.

```php
function listAllServiceEndpoints(): ApiResponse
```

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ListAllServiceEndpointsResult`](../../doc/models/list-all-service-endpoints-result.md).

## Example Usage

```php
$apiResponse = $serviceEndpointsApi->listAllServiceEndpoints();
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "data": [
    "serviceEndpointsId"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Get Service Endpoint

Returns endpoint information for all Service Endpoints registered to a specified serviceEndpointId.

```php
function getServiceEndpoint(string $serviceEndpointsId): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceEndpointsId` | `string` | Template, Required | A system-defined string identifier representing one or more registered Service Endpoints. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourcesEdgeHostedServiceWithProfileId[]`](../../doc/models/resources-edge-hosted-service-with-profile-id.md).

## Example Usage

```php
$serviceEndpointsId = '43f3f7bb-d6c5-4bad-b081-9a3a0df2db98';

$apiResponse = $serviceEndpointsApi->getServiceEndpoint($serviceEndpointsId);
```

## Example Response *(as JSON)*

```json
[
  {
    "serviceEndpoint": {
      "FQDN": "thingtest.verizon.com",
      "IPv4Address": "192.168.11.10",
      "IPv6Address": "2001:0db8:85a3:0000:0000:8a2e:0370:1234",
      "port": 1234,
      "URI": "http://base_path/some_segment/id"
    },
    "applicationId": "IogspaceJan15",
    "serviceDescription": "ThieIt",
    "applicationServerProviderId": "AWS",
    "ern": "us-east-1-wl1-atl-wlz-1",
    "serviceProfileID": "4054ea9a-593e-4776-b488-697b1bfa4f3b"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Update Service Endpoint

Update registered Service Endpoint information.

```php
function updateServiceEndpoint(string $serviceEndpointsId, array $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceEndpointsId` | `string` | Template, Required | A system-defined string identifier representing one or more registered Service Endpoints. |
| `body` | [`ResourcesEdgeHostedServiceWithProfileId[]`](../../doc/models/resources-edge-hosted-service-with-profile-id.md) | Body, Required | Data needed for Service Endpoint information. The request body passes the rest of the needed parameters to create a service endpoint. Parameters other than `serviceEndpointsId` will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId` and `applicationId` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**.<br><br>**Constraints**: *Maximum Items*: `100` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`UpdateServiceEndpointResult`](../../doc/models/update-service-endpoint-result.md).

## Example Usage

```php
$serviceEndpointsId = '43f3f7bb-d6c5-4bad-b081-9a3a0df2db98';

$body = [
    ResourcesEdgeHostedServiceWithProfileIdBuilder::init()
        ->ern('us-east-1-wl1-atl-wlz-1')
        ->serviceEndpoint(
            ResourcesServiceEndpointBuilder::init()
                ->uri('http://base_path/some_segment/id')
                ->fqdn('thingtest.verizon.com')
                ->iPv4Address('192.168.11.10')
                ->iPv6Address('2001:0db8:85a3:0000:0000:8a2e:0370:1234')
                ->port(1234)
                ->build()
        )
        ->applicationServerProviderId('AWS')
        ->applicationId('IogspaceJan15')
        ->serviceDescription('ThieIt')
        ->serviceProfileId('4054ea9a-593e-4776-b488-697b1bfa4f3b')
        ->build()
];

$apiResponse = $serviceEndpointsApi->updateServiceEndpoint(
    $serviceEndpointsId,
    $body
);
```

## Example Response *(as JSON)*

```json
{
  "status": "Success",
  "message": "EdgeAppServices are updated"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Deregister Service Endpoint

Deregister an application's Service Endpoint from the MEC Platform(s).

```php
function deregisterServiceEndpoint(string $serviceEndpointsId): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceEndpointsId` | `string` | Template, Required | A system-defined string identifier representing one or more registered Service Endpoints. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DeregisterServiceEndpointResult`](../../doc/models/deregister-service-endpoint-result.md).

## Example Usage

```php
$serviceEndpointsId = '43f3f7bb-d6c5-4bad-b081-9a3a0df2db98';

$apiResponse = $serviceEndpointsApi->deregisterServiceEndpoint($serviceEndpointsId);
```

## Example Response *(as JSON)*

```json
{
  "status": "Success",
  "message": "EdgeAppServicesID Deleted"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |

