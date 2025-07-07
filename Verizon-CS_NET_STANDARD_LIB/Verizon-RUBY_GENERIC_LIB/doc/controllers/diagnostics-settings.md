# Diagnostics Settings

```ruby
diagnostics_settings_api = client.diagnostics_settings
```

## Class Name

`DiagnosticsSettingsApi`


# List Diagnostics Settings

This endpoint retrieves diagnostics settings synchronously.

```ruby
def list_diagnostics_settings(account_name,
                              devices)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Query, Required | Account identifier. |
| `devices` | `String` | Query, Required | Devices list formatted as "id, kind" |

## Server

`Server::DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<DiagnosticObservationSetting>`](../../doc/models/diagnostic-observation-setting.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

devices = '864508030026238,IMEI'

result = diagnostics_settings_api.list_diagnostics_settings(
  account_name,
  devices
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
[
  {
    "accountName": "string",
    "device": {
      "id": "864508030026238",
      "kind": "IMEI"
    },
    "attributes": [
      {
        "name": "MANUFACTURER",
        "value": "string",
        "createdOn": "2019-09-07T23:08:03.532Z",
        "isObservable": true,
        "isObserving": true,
        "frequency": {
          "value": 5,
          "unit": "SECOND"
        }
      }
    ]
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

