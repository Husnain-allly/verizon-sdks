
# Device Location Success Result

Whether the device location request was successful or not.

*This model accepts additional fields of type Object.*

## Structure

`DeviceLocationSuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Success` | `Boolean` | Optional | - | Boolean getSuccess() | setSuccess(Boolean success) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

