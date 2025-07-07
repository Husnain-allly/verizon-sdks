
# Search Device by Property Response List

A success response includes an array of all matching devices.

*This model accepts additional fields of type array.*

## Structure

`SearchDeviceByPropertyResponseList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceProperty` | [`?(SearchDeviceByPropertyResponse[])`](../../doc/models/search-device-by-property-response.md) | Optional | **Constraints**: *Maximum Items*: `100` | getDeviceProperty(): ?array | setDeviceProperty(?array deviceProperty): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "DeviceProperty": [
    {
      "billingaccountid": "billingaccountid4",
      "createdon": "createdon6",
      "eventretention": "eventretention2",
      "fields": {
        "item": {
          "acceleration": {
            "x": "x6",
            "y": "y4",
            "z": "z6",
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          },
          "battery": "battery0",
          "humidity": "humidity4",
          "light": "light6",
          "pressure": "pressure2",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "iccid": "iccid4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "billingaccountid": "billingaccountid4",
      "createdon": "createdon6",
      "eventretention": "eventretention2",
      "fields": {
        "item": {
          "acceleration": {
            "x": "x6",
            "y": "y4",
            "z": "z6",
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          },
          "battery": "battery0",
          "humidity": "humidity4",
          "light": "light6",
          "pressure": "pressure2",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "iccid": "iccid4",
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

