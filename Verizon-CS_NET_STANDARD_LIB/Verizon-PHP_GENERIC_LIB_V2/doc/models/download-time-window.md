
# Download Time Window

*This model accepts additional fields of type array.*

## Structure

`DownloadTimeWindow`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `startTime` | `?string` | Optional | Device IMEI list. | getStartTime(): ?string | setStartTime(?string startTime): void |
| `endTime` | `?string` | Optional | Device IMEI list. | getEndTime(): ?string | setEndTime(?string endTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "startTime": "0",
  "endTime": "0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

