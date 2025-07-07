
# Fota V2 Success Result

Response to a successful request.

*This model accepts additional fields of type object.*

## Structure

`FotaV2SuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Success` | `bool` | Required | - |
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

