# Wireless Network Performance

```python
wireless_network_performance_api = client.wireless_network_performance
```

## Class Name

`WirelessNetworkPerformanceApi`

## Methods

* [Near Real Time Network Conditions](../../doc/controllers/wireless-network-performance.md#near-real-time-network-conditions)
* [Domestic 4 G and 5G Nationwide Network Coverage](../../doc/controllers/wireless-network-performance.md#domestic-4-g-and-5g-nationwide-network-coverage)
* [Site Proximity](../../doc/controllers/wireless-network-performance.md#site-proximity)
* [Device Experience 30 Days History](../../doc/controllers/wireless-network-performance.md#device-experience-30-days-history)
* [Device Experience Bulk Latest](../../doc/controllers/wireless-network-performance.md#device-experience-bulk-latest)


# Near Real Time Network Conditions

WNP Query for current network condition.

```python
def near_real_time_network_conditions(self,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for current network health. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```python
body = GetNetworkConditionsRequest(
    account_name='0000123456-00001',
    location_type='LONGLAT',
    coordinates=Coordinates(
        latitude='-33.84819',
        longitude='151.22049'
    )
)

result = wireless_network_performance_api.near_real_time_network_conditions(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Domestic 4 G and 5G Nationwide Network Coverage

Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.

```python
def domestic_4_g_and_5g_nationwide_network_coverage(self,
                                                   body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M2MV1IntelligenceWirelessCoverageRequest`](../../doc/models/m2m-v1-intelligence-wireless-coverage-request.md) | Body, Required | Request for network coverage details. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```python
body = M2MV1IntelligenceWirelessCoverageRequest(
    additional_properties=None,
    account_name='0000123456-00001',
    request_type='FWA',
    location_type='ADDRESS',
    locations=Locations1(
        additional_properties=None,
        address_list=[
            AddressItem(
                address_line_1='street address',
                city='city',
                state='LA',
                country='USA',
                zip='00000'
            )
        ]
    ),
    network_types_list=[
        NetworkTypeObject(
            network_type='LTE'
        )
    ]
)

result = wireless_network_performance_api.domestic_4_g_and_5g_nationwide_network_coverage(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Site Proximity

Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.

```python
def site_proximity(self,
                  body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for cell site proximity. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```python
body = GetNetworkConditionsRequest(
    account_name='0000123456-00001',
    location_type='LONGLAT',
    coordinates=Coordinates(
        latitude='-33.84819',
        longitude='151.22049'
    )
)

result = wireless_network_performance_api.site_proximity(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience 30 Days History

A report of a specific device's service scores over a 30 day period.

```python
def device_experience_30_days_history(self,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreHistoryRequest`](../../doc/models/get-device-experience-score-history-request.md) | Body, Required | Request for a device's 30 day experience. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```python
body = GetDeviceExperienceScoreHistoryRequest(
    account_name='0000123456-00001',
    device_id=DeviceIdentifier(
        kind='iccid',
        id='01234567899876543210',
        mdn='0123456789'
    )
)

result = wireless_network_performance_api.device_experience_30_days_history(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience Bulk Latest

Run a report to view the latest device experience score for specific devices.

```python
def device_experience_bulk_latest(self,
                                 body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreBulkRequest`](../../doc/models/get-device-experience-score-bulk-request.md) | Body, Required | Request for bulk latest history details. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```python
body = GetDeviceExperienceScoreBulkRequest(
    account_name='0000123456-00001',
    device_list=[
        DeviceIdentifier(
            kind='iccid',
            id='01234567899876543210',
            mdn='0123456789'
        )
    ]
)

result = wireless_network_performance_api.device_experience_bulk_latest(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |

