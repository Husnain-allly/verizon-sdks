
# Onboarding

*This model accepts additional fields of type array.*

## Structure

`Onboarding`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `sensoridentifier` | `?string` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer | getSensoridentifier(): ?string | setSensoridentifier(?string sensoridentifier): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "sensoridentifier": "The unique EUI64 address of the device",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

