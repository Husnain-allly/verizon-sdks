
# Fota V2 Success Result

Response to a successful request.

*This model accepts additional fields of type Object.*

## Structure

`FotaV2SuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Success` | `boolean` | Required | - | boolean getSuccess() | setSuccess(boolean success) |
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

