
# Change Pwn Device Profile Response

Response to change PWN device profile

*This model accepts additional fields of type unknown.*

## Structure

`ChangePwnDeviceProfileResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string \| undefined` | Optional | A unique string that associates the request with the results that are sent via a callback service. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "requestId": "24da9f9a-d110-4a54-86b4-93fb76aab83c",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

