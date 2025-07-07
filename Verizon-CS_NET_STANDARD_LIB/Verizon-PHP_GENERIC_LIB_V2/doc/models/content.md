
# Content

*This model accepts additional fields of type array.*

## Structure

`Content`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `advisory` | array<[AdvisoryItem](../../doc/models/advisory-item.md)\|[AdvisoryItem](../../doc/models/advisory-item.md)1> | Required | The use of ITIS codes interspersed with free text. The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `100` | getAdvisory(): array | setAdvisory(array advisory): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "advisory": [
    {
      "item": {
        "itis": 10
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "item": {
        "itis": 10
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "item": {
        "itis": 10
      },
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

