
# Device Firmware Version Update Result

Device firmware version update response.

*This model accepts additional fields of type array.*

## Structure

`DeviceFirmwareVersionUpdateResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier. | getAccountName(): string | setAccountName(string accountName): void |
| `requestId` | `string` | Required | Request identifier. | getRequestId(): string | setRequestId(string requestId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "accountName4",
  "requestId": "requestId2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

