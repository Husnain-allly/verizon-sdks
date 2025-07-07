
# Fota V1 Success Result

A response to a successful request contains a single Boolean value.

*This model accepts additional fields of type unknown.*

## Structure

`FotaV1SuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `success` | `boolean \| undefined` | Optional | True is returned in case of success. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

