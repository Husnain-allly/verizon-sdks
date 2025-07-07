
# Device Location Success Result

Whether the device location request was successful or not.

*This model accepts additional fields of type object.*

## Structure

`DeviceLocationSuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Success` | `bool?` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "success": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

