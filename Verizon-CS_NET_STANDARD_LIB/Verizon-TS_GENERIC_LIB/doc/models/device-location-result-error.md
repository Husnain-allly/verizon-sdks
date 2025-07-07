
# Device Location Result Error

Will be empty if there was no error.

*This model accepts additional fields of type unknown.*

## Structure

`DeviceLocationResultError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `errorCode` | `string` | Required | - |
| `errorMessage` | `string` | Required | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "The type of error, such as INVALID_REQUEST.",
  "errorMessage": "Additional error information.",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

