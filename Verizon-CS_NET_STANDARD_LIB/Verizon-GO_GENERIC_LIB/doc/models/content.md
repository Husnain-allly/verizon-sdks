
# Content

*This model accepts additional fields of type interface{}.*

## Structure

`Content`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Advisory` | [`[]models.AdvisoryItem2`](../../doc/models/containers/advisory-item-2.md) | Required | The use of ITIS codes interspersed with free text. The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `100` |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

