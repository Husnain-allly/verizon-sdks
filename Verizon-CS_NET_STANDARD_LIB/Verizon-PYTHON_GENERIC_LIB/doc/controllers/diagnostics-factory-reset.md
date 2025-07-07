# Diagnostics Factory Reset

```python
diagnostics_factory_reset_api = client.diagnostics_factory_reset
```

## Class Name

`DiagnosticsFactoryResetApi`


# Decives Restart

Performs a device reboot or a factory reset on the modem portion of the device.

```python
def decives_restart(self,
                   body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceResetRequest`](../../doc/models/device-reset-request.md) | Body, Required | A request to perform a device reboot. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`DiagnosticsObservationResult`](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```python
body = DeviceResetRequest(
    additional_properties=None,
    account_name='0642233522-00003',
    action='reboot',
    devices=[
        Device(
            id='355154080648401',
            kind='IMEI',
            additional_properties=None
        )
    ]
)

result = diagnostics_factory_reset_api.decives_restart(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "createdOn": "2019-02-03T06:48:07",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "FACTORY_RESET_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

