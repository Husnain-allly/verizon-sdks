
# Api Response Code

ResponseCode and/or a message indicating success or failure of the request.

*This model accepts additional fields of type array.*

## Structure

`ApiResponseCode`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `responseCode` | [`string(ResponseCode)`](../../doc/models/response-code.md) | Required | Possible response codes. | getResponseCode(): string | setResponseCode(string responseCode): void |
| `message` | `string` | Required | More details about the responseCode received. | getMessage(): string | setMessage(string message): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

