
# Device Extended Diagnostics Request

Request for obtaining device extended diagnostics.

*This model accepts additional fields of type object.*

## Structure

`DeviceExtendedDiagnosticsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The Verizon billing account that the device belongs to. An account name is usually numeric, and must include any leading zeros. |
| `DeviceList` | [`List<DeviceId>`](../../doc/models/device-id.md) | Required | The device for which you want diagnostic information, specified by the device's MDN. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "deviceList": [
    {
      "id": "10-digit MDN",
      "kind": "mdn",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

