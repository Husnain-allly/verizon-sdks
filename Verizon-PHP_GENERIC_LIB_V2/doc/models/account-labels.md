
# Account Labels

Maximum of 2,000 objects are allowed in the array.

*This model accepts additional fields of type array.*

## Structure

`AccountLabels`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `devices` | [`DeviceList[]`](../../doc/models/device-list.md) | Required | - | getDevices(): array | setDevices(array devices): void |
| `label` | [`?(DeviceLabels[])`](../../doc/models/device-labels.md) | Optional | - | getLabel(): ?array | setLabel(?array label): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "label": [
    {
      "name": "name0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "name": "name0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "name": "name0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

