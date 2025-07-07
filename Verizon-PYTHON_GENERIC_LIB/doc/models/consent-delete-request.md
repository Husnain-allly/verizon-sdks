
# Consent Delete Request

*This model accepts additional fields of type Any.*

## Structure

`ConsentDeleteRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | Account identifier. |
| `device_list` | `List[str]` | Optional | Device ID list. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

