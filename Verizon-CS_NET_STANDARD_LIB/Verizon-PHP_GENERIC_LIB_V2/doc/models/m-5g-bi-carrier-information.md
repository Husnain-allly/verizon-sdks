
# M 5G Bi Carrier Information

*This model accepts additional fields of type array.*

## Structure

`M5GBiCarrierInformation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `carrierName` | `?string` | Optional | - | getCarrierName(): ?string | setCarrierName(?string carrierName): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "carrierName": "Verizon Wireless",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

