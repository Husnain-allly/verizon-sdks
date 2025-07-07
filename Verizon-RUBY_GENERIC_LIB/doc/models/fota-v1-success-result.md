
# Fota V1 Success Result

A response to a successful request contains a single Boolean value.

*This model accepts additional fields of type Object.*

## Structure

`FotaV1SuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `success` | `TrueClass \| FalseClass` | Optional | True is returned in case of success. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

