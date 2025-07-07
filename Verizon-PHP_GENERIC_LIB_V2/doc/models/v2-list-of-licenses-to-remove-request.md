
# V2 List of Licenses to Remove Request

License cancellation candidate devices.

*This model accepts additional fields of type array.*

## Structure

`V2ListOfLicensesToRemoveRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `type` | `?string` | Optional | List creation option. | getType(): ?string | setType(?string type): void |
| `count` | `?int` | Optional | The number of devices. | getCount(): ?int | setCount(?int count): void |
| `deviceList` | `string[]` | Required | Device IMEI list. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "type": "append",
  "count": 2,
  "deviceList": [
    "990003425730535",
    "990000473475989"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

