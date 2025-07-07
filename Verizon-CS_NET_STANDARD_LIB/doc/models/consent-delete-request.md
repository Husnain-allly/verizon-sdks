
# Consent Delete Request

*This model accepts additional fields of type object.*

## Structure

`ConsentDeleteRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account identifier. |
| `DeviceList` | `List<string>` | Optional | Device ID list. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "MyAccount-1",
  "deviceList": [
    "deviceList2",
    "deviceList3"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

