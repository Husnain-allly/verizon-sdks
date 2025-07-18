# Diagnostics Observations

```ruby
diagnostics_observations_api = client.diagnostics_observations
```

## Class Name

`DiagnosticsObservationsApi`

## Methods

* [Start Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#start-diagnostics-observation)
* [Stop Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#stop-diagnostics-observation)


# Start Diagnostics Observation

This endpoint allows the user to start or change observe diagnostics.

```ruby
def start_diagnostics_observation(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ObservationRequest`](../../doc/models/observation-request.md) | Body, Required | Request for device observation information. |

## Server

`Server::DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DiagnosticsObservationResult`](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```ruby
body = ObservationRequest.new(
  account_name: 'TestQAAccount',
  devices: [
    Device.new(
      id: '864508030026238',
      kind: 'IMEI'
    )
  ],
  attributes: [
    ObservationRequestAttribute.new(
      name: AttributeIdentifier::RADIO_SIGNAL_STRENGTH
    ),
    ObservationRequestAttribute.new(
      name: AttributeIdentifier::LINK_QUALITY
    ),
    ObservationRequestAttribute.new(
      name: AttributeIdentifier::NETWORK_BEARER
    ),
    ObservationRequestAttribute.new(
      name: AttributeIdentifier::CELL_ID
    )
  ],
  frequency: NumericalData.new(
    value: 15,
    unit: NumericalDataUnit::SECOND
  ),
  duration: NumericalData.new(
    value: 15,
    unit: NumericalDataUnit::SECOND
  )
)

result = diagnostics_observations_api.start_diagnostics_observation(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |


# Stop Diagnostics Observation

This endpoint allows the user to stop or reset observe diagnostics.

```ruby
def stop_diagnostics_observation(transaction_id,
                                 account_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transaction_id` | `String` | Query, Required | The ID value associated with the transaction. |
| `account_name` | `String` | Query, Required | The numeric account name. |

## Server

`Server::DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DiagnosticsObservationResult`](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```ruby
transaction_id = '5f4bd2ff-5d7f-444d-af17-3f6a80bb2a94'

account_name = '0000123456-00001'

result = diagnostics_observations_api.stop_diagnostics_observation(
  transaction_id,
  account_name
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

