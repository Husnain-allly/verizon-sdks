
# Api Response Code

ResponseCode and/or a message indicating success or failure of the request.

*This model accepts additional fields of type unknown.*

## Structure

`ApiResponseCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `responseCode` | [`ResponseCode`](../../doc/models/response-code.md) | Required | Possible response codes. |
| `message` | `string` | Required | More details about the responseCode received. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "responseCode": "INVALID_ACCESS",
  "message": "message4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

