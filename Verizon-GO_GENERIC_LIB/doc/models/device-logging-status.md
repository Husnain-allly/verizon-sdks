
# Device Logging Status

Device logging status information.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceLoggingStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `ExpiryDate` | `time.Time` | Required | The date when device logging expires. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "expiryDate": "2020-10-19",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

