
# Fota V3 Success Result

Cancelation status.

*This model accepts additional fields of type Object.*

## Structure

`FotaV3SuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Success` | `boolean` | Required | True or false. | boolean getSuccess() | setSuccess(boolean success) |
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

