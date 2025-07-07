
# Fota V1 Success Result

A response to a successful request contains a single Boolean value.

*This model accepts additional fields of type Any.*

## Structure

`FotaV1SuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `success` | `bool` | Optional | True is returned in case of success. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

